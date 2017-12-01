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
    public partial class frmSignUp : Form
    {
        String userRole = "";

        public frmSignUp()
        {
            InitializeComponent();
            txtPass.Enabled = txtPassConfirm.Enabled = txtUserID.Enabled = txtUserName.Enabled = cbbRole.Enabled = false;
            btnCreate.Enabled = false;

            if (Program.currentRole == "TRUONG")
            {
                rbStudent.Visible = false;
                cbbRole.Items.Clear();
                cbbRole.Items.Add("TRUONG");
            }
            else
            {
                rbStudent.Visible = true;
                cbbRole.Items.Clear();
                cbbRole.Items.Add("GIANGVIEN");
                cbbRole.Items.Add("COSO");
                cbbRole.Items.Add("TRUONG");
            }
        }

        private void rbTeacher_CheckedChanged(object sender, EventArgs e)
        {
            cbbRole.Visible = true;
            txtUserName.Visible = true;
            lblROle.Visible = lblUserName.Visible = true;
            txtPass.Enabled = txtPassConfirm.Enabled = txtUserID.Enabled = txtUserName.Enabled = cbbRole.Enabled = true;
            btnCreate.Enabled = true;
            txtUserID.MaxLength = 5;
        }

        private void rbStudent_CheckedChanged(object sender, EventArgs e)
        {
            cbbRole.Visible = false;
            txtUserName.Visible = false;
            lblROle.Visible = lblUserName.Visible = false;
            txtPass.Enabled = txtPassConfirm.Enabled = txtUserID.Enabled = txtUserName.Enabled = true;
            btnCreate.Enabled = true;
            txtUserID.MaxLength = 3;
        }

        private String checkExistsAccount(String userID)
        {
            String sqlStr = "";
            Program.connect.Open();

            sqlStr = "sp_KiemTraTaiKhoanDangKy_GV";
            Program.cmd = Program.connect.CreateCommand();
            Program.cmd.CommandType = CommandType.StoredProcedure;
            Program.cmd.CommandText = sqlStr;

            Program.cmd.Parameters.Add("@TENUSER", SqlDbType.NChar).Value = userID;
            Program.cmd.Parameters.Add("@ReturnValue", SqlDbType.VarChar).Direction = ParameterDirection.ReturnValue;
            Program.cmd.ExecuteNonQuery();
            Program.connect.Close();

            String result = Program.cmd.Parameters["@ReturnValue"].Value.ToString();

            return result;
        }

        private void createAccount()
        {
            if (rbStudent.Checked)
            {
                userRole = "SINHVIEN";
                txtUserName.Text = txtUserID.Text;
            }
            else
            {
                userRole = cbbRole.SelectedItem.ToString();
            }

            String checkExists = checkExistsAccount(txtUserID.Text);
            if (checkExists == "-1")
            {
                MessageBox.Show("The User ID hasn't exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.myReader.Close();
                return;
            }
            else if (checkExists == "1")
            {
                MessageBox.Show("The User ID has been registerd!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.myReader.Close();
                return;
            }
            else
            {
                if (txtUserID.Text.Length == 0 || txtPass.Text.Length == 0 || txtPassConfirm.Text.Length == 0)
                {
                    MessageBox.Show("Can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtPassConfirm.UseSystemPasswordChar.ToString() != txtPassConfirm.UseSystemPasswordChar.ToString())
                {
                    MessageBox.Show("Confirm password incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        String sqlStr = "";
                        sqlStr = "exec sp_TaoLogin '" + txtUserName.Text + "', '" + txtPass.Text + "', '" + txtUserID.Text + "', '" + userRole + "'";

                        Program.myReader = Program.ExecSqlDataReader(sqlStr);
                        if (Program.myReader == null) return;
                        Program.myReader.Read();
                        MessageBox.Show("Create user successfully!", "Notification", MessageBoxButtons.OK);
                        Program.myReader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Create user failed!" + ex.Message, "Error", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;
                    }
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            createAccount();
            txtPass.Text = "";
            txtPassConfirm.Text = "";
            txtUserID.Text = "";
            txtUserName.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
