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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            initTextBox(true);
        }

        private void initTextBox(Boolean isEnable)
        {
            this.txtUser.Enabled = isEnable;
            this.txtPass.Enabled = isEnable;
        }

        private void txtUser_Load(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_DidLoad(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtPass_Load(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_DidLoad(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTracNghiem.VIEW_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.vIEW_DS_PHANMANHTableAdapter.Fill(this.dataSetTracNghiem.VIEW_DS_PHANMANH);

            
        }

        private void rbSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            initTextBox(true);
        }

        private void rbGiaoVien_CheckedChanged(object sender, EventArgs e)
        {
            initTextBox(true);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "Username" || txtPass.Text.Trim() == "Password")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtUser.Focus();
                txtPass.Focus();
                return;
            }

            try
            {
                Program.userName = txtUser.Text.Trim();
                Program.password = txtPass.Text.Trim();
                Program.currentBranch = cbbTenCS.SelectedIndex;
                Program.serverName = cbbTenCS.SelectedValue.ToString().Trim();

                Program.connect = Database.Connection(Program.serverName, Program.userName, Program.password);
                if (Program.connect == null) return;

                Program.currentUserName = Program.userName;
                Program.currentPass = Program.password;
                String strLenh = "";
                if (rbGiaoVien.Checked == true)
                {
                    strLenh = "exec sp_DangNhapGiaoVien '" + Program.userName + "'";
                }
                else if (rbSinhVien.Checked == true)
                {
                    strLenh = "exec sp_DangNhapSinhVien '" + Program.userName + "'";
                }
                Program.dataReader = Database.ExecSqlDataReader(strLenh);
                if (Program.dataReader == null)
                {
                    return;
                }
                Program.dataReader.Read();

                Program.loginName = Program.dataReader.GetString(0);     // Lay username
                if (Convert.IsDBNull(Program.loginName))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại Username của cơ sở dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }
                Program.currentName = Program.dataReader.GetString(1); // lấy họ tên 
                Program.currentRole = Program.dataReader.GetString(2); // lấy nhóm quyền
                Program.dataReader.Close();
                Program.connect.Close();

                initForm();

                Close();
            }
            catch
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username của cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void initForm()
        {
            Program.frmChinh.userID.Text = "UserID : " + Program.loginName;
            Program.frmChinh.userName.Text = "Username : " + Program.currentName;
            Program.frmChinh.userRole.Text = "Group : " + Program.currentRole;

            Program.frmChinh.btnLogin.Enabled = false;
            Program.frmChinh.btnLogout.Enabled = true;

            if (Program.currentRole == "GIANGVIEN")
            {
                initRibGroup(true);
                Program.frmChinh.ribManage.Visible = false;
                Program.frmChinh.ribStudent.Visible = false;
                Program.frmChinh.ribReport.Visible = false;
            }
            else if (Program.currentRole == "SINHVIEN")
            {
                initRibGroup(true);
                Program.frmChinh.ribTeacher.Visible = false;
                Program.frmChinh.ribManage.Visible = false;
                Program.frmChinh.ribReport.Visible = false;
            }
            else if (Program.currentRole == "TRUONG")
            {
                initRibGroup(true);
            }
            else if (Program.currentRole == "COSO")
            {
                initRibGroup(true);
            } 
        }
        public void initRibGroup(Boolean isEnable)
        {
            Program.frmChinh.ribbonTeacherGroup.Enabled = isEnable;
            Program.frmChinh.ribbonStudentGroup.Enabled = isEnable;
            Program.frmChinh.ribbonReportGroup.Enabled = isEnable;
            Program.frmChinh.ribbonManaGroup.Enabled = isEnable;
        }

        private void cbbTenCS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

