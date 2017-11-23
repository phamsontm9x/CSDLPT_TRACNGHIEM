using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracNghiem
{
    public partial class frmTest : Form
    {
        public class ItemQuestion
        {
            public string title;
            public int status;
            public string answer1;
            public string answer2;
            public string answer3;
            public string answer4;
            public int answer;
            public ItemQuestion(string Title, int Status)
            {
                title = Title;
                status = Status;
            }
        }

        public List<ItemQuestion> listQuestion;
 
        public frmTest()
        {
            InitializeComponent();
            listQuestion = new List<ItemQuestion>();
            getDataQuestion();
        }

        public void getDataQuestion()
        {
            for (int i = 0; i < 30; i++)
            {
                ItemQuestion item = new ItemQuestion("Cau " + i, 0);
                lbQuestion.Items.Add(item.title);
                item.answer1 = "Cau tra loi A " + i;
                item.answer2 = "Cau tra loi B " + i;
                item.answer3 = "Cau tra loi C " + i;
                item.answer4 = "Cau tra loi D " + i;
                
                listQuestion.Add(item);
            }
        }

        public void updateDataListBox ()
        {
            lbQuestion.Update();
        }


        public void initQuestionAtIndex(int indexQuestion)
        {
            ItemQuestion item = listQuestion[indexQuestion];
            btnAnswer1.Text = item.answer1;
            btnAnswer2.Text = item.answer2;
            btnAnswer3.Text = item.answer3;
            btnAnswer4.Text = item.answer4;

            setCheckAnswerQuestion(item.answer);
        }

        public void selectedAnswer(int index, int value)
        {
            ItemQuestion item = listQuestion[index];
            item.answer = value;
            updateDataListBox();
        }

        private void lbQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            initQuestionAtIndex(lbQuestion.SelectedIndex);
        }

        private void btnAnswer1_CheckedChanged(object sender, EventArgs e)
        {
            int index = lbQuestion.SelectedIndex;
            if (index >= 0)
            {
                selectedAnswer(index, 1);
            }

        }

        private void btnAnswer2_CheckedChanged(object sender, EventArgs e)
        {
            int index = lbQuestion.SelectedIndex;
            if (index >= 0)
            {
                selectedAnswer(index, 2);
            }
        }

        private void btnAnswer3_CheckedChanged(object sender, EventArgs e)
        {
            int index = lbQuestion.SelectedIndex;
            if (index >= 0)
            {
                selectedAnswer(index, 3);
            }
        }

        private void btnAnswer4_CheckedChanged(object sender, EventArgs e)
        {
            int index = lbQuestion.SelectedIndex;
            if (index >= 0)
            {
                selectedAnswer(index, 4);
            }
        }

        public void setCheckAnswerQuestion (int index)
        {
            if (index == 1)
            {
                btnAnswer1.Checked = true;
            }
            else if (index == 2)
            {
                btnAnswer2.Checked = true;
            }
            else if (index == 3)
            {
                btnAnswer3.Checked = true;
            }
            else if (index == 4)
            {
                btnAnswer4.Checked = true;
            }
            else
            {
                btnAnswer1.Checked = false;
                btnAnswer2.Checked = false;
                btnAnswer3.Checked = false;
                btnAnswer4.Checked = false;
            }
        }

        private void lbQuestion_DrawItem(object sender, DrawItemEventArgs e)
        {
            ItemQuestion item = listQuestion[e.Index];
            e.DrawBackground();
            Graphics g = e.Graphics;
            g.DrawString(item.title, e.Font, item.answer > 0 ? Brushes.Green : Brushes.Black, new PointF(e.Bounds.X, e.Bounds.Y));
            e.DrawFocusRectangle();
        }
    }
}
