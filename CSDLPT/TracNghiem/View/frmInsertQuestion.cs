using System;
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
    public partial class frmInsertQuestion : Form
    {
        public frmInsertQuestion()
        {
            InitializeComponent();
        }

        private void frmInsertQuestion_Load(object sender, EventArgs e)
        {
            txtSubjectID.Text = Program.insertSubjectID;
            txtTeacherID.Text = Program.insertTeacherID;
            txtLevel.Text = Program.insertLevel;
            txtDepID.Text = Program.insertDepID;

            txtSubjectID.Enabled = txtTeacherID.Enabled = txtLevel.Enabled = txtDepID.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String sqlStr = "";
                sqlStr = "exec sp_KiemTraBoDe '" + txtQuestID.Text + "', '" + Program.NEW_METHOD + "'";

                Program.myReader = Program.ExecSqlDataReader(sqlStr);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                if (Program.myReader.FieldCount > 0)
                {
                    MessageBox.Show("The " + txtQuestID.Text + " has already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.myReader.Close();
                    return;
                }
                else
                {
                    if (txtContent.Text.Length == 0 || txtA.Text.Length == 0 || txtB.Text.Length == 0 || txtC.Text.Length == 0 || txtD.Text.Length == 0 || txtAnswer.Text.Length == 0)
                    {
                        MessageBox.Show("Can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                    Program.myReader.Close();
                    try
                        {
                        String sqlStrInsert = "exec sp_DanhSachBoDe_Insert '" + txtQuestID.Text + "', '" + txtSubjectID.Text + "', '" +
                        txtLevel.Text + "', '" + txtContent.Text + "', '" + txtA.Text + "', '" + txtB.Text + "', '" + txtC.Text + "', '" +
                        txtD.Text + "', '" + txtAnswer.Text + "', '" + txtTeacherID.Text + "', '" + txtDepID.Text + "'";

                        Program.myReader = Program.ExecSqlDataReader(sqlStrInsert);
                        if (Program.myReader == null) return;
                        Program.myReader.Read();

                        MessageBox.Show("Update exam code successful", "Notification", MessageBoxButtons.OK);
                        Program.myReader.Close();

                        txtContent.Text = txtC.Text = txtB.Text = txtA.Text = txtD.Text = txtQuestID.Text = txtAnswer.Text = "";
                    }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Create exam failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                            Program.myReader.Close();
                            return;
                        }
                    }
                    Program.myReader.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtQuestID_KeyboardPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAnswer_KeyboardPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
