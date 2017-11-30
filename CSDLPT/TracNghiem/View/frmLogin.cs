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
            //if (txtUser.Text == "Username")
            //{
            //    txtUser.Text = "";
            //    txtUser.ForeColor = Color.Black;
            //}

            // define UserName
            txtUser.Text = "TUNG";
        }

        private void txtUser_DidLoad(object sender, EventArgs e)
        {
            //if (txtUser.Text == "")
            //{
            //    txtUser.Text = "Username";
            //    txtUser.ForeColor = Color.LightGray;
            //}
        }

        private void txtPass_Load(object sender, EventArgs e)
        {
            //if (txtPass.Text == "Password")
            //{
            //    txtPass.Text = "";
            //    txtPass.ForeColor = Color.Black;
            //    txtPass.UseSystemPasswordChar = true;
            //}

            // define Password
            txtPass.Text = "123456";
        }

        private void txtPass_DidLoad(object sender, EventArgs e)
        {
            //if (txtPass.Text == "")
            //{
            //    txtPass.Text = "Password";
            //    txtPass.ForeColor = Color.LightGray;
            //    txtPass.UseSystemPasswordChar = false;
            //}
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTracNghiem.VIEW_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.vIEW_DS_PHANMANHTableAdapter.Fill(this.dataSetView.VIEW_DS_PHANMANH);
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
                Program.serverName = cbbTenCS.SelectedValue.ToString().Trim();

                if (Program.Connection() == 0) return;
                Program.currentBranch = cbbTenCS.SelectedIndex;
                Program.bds = bdsDSPhanManh;
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
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                Program.currentID = Program.myReader.GetString(0);     // Lay username
                if (Convert.IsDBNull(Program.currentID))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại Username của cơ sở dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }
                Program.currentLoginName = Program.myReader.GetString(1); // lấy họ tên 
                Program.currentRole = Program.myReader.GetString(2); // lấy nhóm quyền
                Program.myReader.Close();
                Program.connect.Close();

                initForm();

                Hide();

            }
            catch
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username của cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void initForm()
        {
            Program.frmChinh.userID.Text = "UserID : " + Program.currentID;
            Program.frmChinh.userName.Text = "Username : " + Program.currentLoginName;
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
                Program.frmChinh.btnCreate.Enabled = false;
                Program.frmChinh.btnTry.Enabled = false;
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
    }
}
