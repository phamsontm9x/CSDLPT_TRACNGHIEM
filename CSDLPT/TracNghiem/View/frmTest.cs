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
        // object exam
        public int timeExam = 60;
        public int totalQuestionCorrect = 0;
        public float score = 0;

        public bool isFinal = false;
        public class ItemQuestion
        {
            public string titleListBox;
            public string title;
            public int status;
            public string answer1;
            public string answer2;
            public string answer3;
            public string answer4;
            public string answer;
            public string correctAnswer;
            public ItemQuestion(string Title, string TitleListBox, int Status, string Answer1, string Answer2, string Answer3, string Answer4, string Answer)
            {
                title = Title;
                status = Status;
                answer1 = Answer1;
                answer2 = Answer2;
                answer3 = Answer3;
                answer4 = Answer4;
                correctAnswer = Answer;
                titleListBox = TitleListBox;
            }
        }

        public List<ItemQuestion> listQuestion;
 
        public frmTest()
        {
            InitializeComponent();
            listQuestion = new List<ItemQuestion>();
            getDataQuestion();
            initRoleTest();
        }

        public void getDataQuestion()
        {
            String MAMH = "TD1";
            String TRINHDO = "A";
            String MACS = "CS1";
            int SoCauHoi = 4;

            String strLenh = "exec sp_RandomQuestionTest'" + MAMH + "', '" + TRINHDO + "', '" + MACS + "', '" + SoCauHoi + "'";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            if (dt != null)
            {
                int i = 1;
                foreach (DataRow dtRow in dt.Rows)
                {
                    var title = dtRow[3].ToString();
                    var answer1 = dtRow[4].ToString();
                    var answer2 = dtRow[5].ToString();
                    var answer3 = dtRow[6].ToString();
                    var answer4 = dtRow[7].ToString();
                    var correctAnswer = dtRow[8].ToString();
                    string titleListBox = "Cau " + i++;
                    ItemQuestion item = new ItemQuestion(title, titleListBox, 0, answer1, answer2, answer3, answer4, correctAnswer);
                    listQuestion.Add(item);
                    lbQuestion.Items.Add(titleListBox);
                }
            }
            else
            {
                MessageBox.Show("Can not show exam", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            lbQuestion.SelectedIndex = -1;
        }

        public void initRoleTest()
        {
            lblQuestion.Text = @"HOC SINH CHU Y KHONG DUOC SU DUNG TAI LIEU HOAC DIEN THOAI";
            setHiddenAnswer(true);
            lbQuestion.Enabled = false;
            btnFinish.Hide();
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

            lblQuestion.Text = item.title;

            setCheckAnswerQuestion(item.answer);
        }

        public void selectedAnswer(int index, string value)
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
            if (index >= 0 && btnAnswer1.Checked)
            {
                selectedAnswer(index, "A");
            }

        }

        private void btnAnswer2_CheckedChanged(object sender, EventArgs e)
        {
            int index = lbQuestion.SelectedIndex;
            if (index >= 0 && btnAnswer2.Checked)
            {
                selectedAnswer(index, "B");
            }
        }

        private void btnAnswer3_CheckedChanged(object sender, EventArgs e)
        {
            int index = lbQuestion.SelectedIndex;
            if (index >= 0 && btnAnswer3.Checked)
            {
                selectedAnswer(index, "C");
            }
        }

        private void btnAnswer4_CheckedChanged(object sender, EventArgs e)
        {
            int index = lbQuestion.SelectedIndex;
            if (index >= 0 && btnAnswer4.Checked)
            {
                selectedAnswer(index, "D");
            }
        }

        public void setCheckAnswerQuestion (string index)
        {
            if (index == "A")
            {
                btnAnswer1.Checked = true;
            }
            else if (index == "B")
            {
                btnAnswer2.Checked = true;
            }
            else if (index == "C")
            {
                btnAnswer3.Checked = true;
            }
            else if (index == "D")
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

        public void setHiddenAnswer (Boolean value)
        {
            if (value == true)
            {
                btnAnswer1.Hide();
                btnAnswer2.Hide();
                btnAnswer3.Hide();
                btnAnswer4.Hide();
            } else
            {
                btnAnswer1.Show();
                btnAnswer2.Show();
                btnAnswer3.Show();
                btnAnswer4.Show();
            }
        }

        private void lbQuestion_DrawItem(object sender, DrawItemEventArgs e)
        {
            ItemQuestion item = listQuestion[e.Index];
            e.DrawBackground();
            Graphics g = e.Graphics;
            if (isFinal)
            {
                string title = item.answer == item.correctAnswer ? item.titleListBox + "\t(" + item.answer + ")" : item.titleListBox + "\t(" + item.answer + ") " + item.correctAnswer;
                g.DrawString(title, e.Font, item.answer == item.correctAnswer ? Brushes.Green : Brushes.Red, new PointF(e.Bounds.X, e.Bounds.Y));
            } else
            {
                string title = item.answer != null ? item.titleListBox + "\t(" + item.answer + ")" : item.titleListBox;
                g.DrawString(title, e.Font, item.answer != null ? Brushes.Green : Brushes.Black, new PointF(e.Bounds.X, e.Bounds.Y));
            }    
            e.DrawFocusRectangle();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            lbQuestion.SelectedIndex = 0;
            lbQuestion.Enabled = true;
            setHiddenAnswer(false);
            btnBegin.Hide();
            btnFinish.Show();
            InitTimmer();
        }

        public void InitTimmer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeExam == 0)
            {
                timer1.Stop();
                setFinal();
            } else
            {
                timeExam--;
                lblTimer.Text = timeExam / 60 + ":" + (timeExam % 60 >= 10 ? (timeExam % 60).ToString() : "0" + timeExam % 60);
            }
            
        }

        public void getScoreExam()
        {
            float scorePerQuestion = 10 / (float)listQuestion.Count;
            foreach (ItemQuestion item in listQuestion)
            {
                if (item.answer == item.correctAnswer)
                {
                    score += scorePerQuestion;
                    totalQuestionCorrect++;
                }
            }
           // score = (float) Math.Round(score,2);
            lblTimer.Text = "Score:" + score;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            setFinal();
            btnFinish.Hide();
            MessageBox.Show("You have " + totalQuestionCorrect + "\n Your score is: " + score + "", "Nofitication", MessageBoxButtons.OK);
        }
        public void setFinal()
        {
            if (isFinal == false)
            {
                getScoreExam();
                isFinal = true;
                btnAnswer1.Enabled = false;
                btnAnswer2.Enabled = false;
                btnAnswer3.Enabled = false;
                btnAnswer4.Enabled = false;
            } 
        }
    }
}
