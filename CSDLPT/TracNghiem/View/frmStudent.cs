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
    public partial class frmStudent : Form
    {
        int index;
        String method = "";
        String branchID = "";
        String classID = "";
        public frmStudent()
        {
            InitializeComponent();
        }


        private void frmStudent_Load(object sender, EventArgs e)
        {
            dataSetTracNghiem.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dataSetTracNghiem.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.dataSetTracNghiem.SINHVIEN);

            initUIComboBoxDep();
            
        }

        public void initUIComboBoxDep()
        {
            cbbDep.DataSource = Program.bds;
            cbbDep.DisplayMember = "MACS";
            cbbDep.ValueMember = "TENCS";
            cbbDep.SelectedIndex = Program.currentBranch;

            initUIComboBoxBranch();
        }

        public void initUIComboBoxBranch()
        {
            String currentBranchName = getDepSelected();
            int indexStr = currentBranchName.IndexOf("\\") + 1;
            currentBranchName = currentBranchName.Substring(indexStr);

            String strLenh = "exec sp_DanhSachKhoa'" + currentBranchName + "'";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            if (dt != null)
            {
                cbbBranch.DataSource = dt;
                cbbBranch.DisplayMember = "TENKH";
                cbbBranch.ValueMember = "MAKH";
                initUIComboBoxClass();
            }
            else
            {
                MessageBox.Show("Can not show list branch", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void initUIComboBoxClass()
        {
            String currentClassName = getBranchSelected();

            String strLenh = "exec sp_DanhSachLopTheoKhoa'" + currentClassName + "'";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    cbbClass.SelectedIndex = -1;
                    cbbClass.DataSource = null;
                }
                else
                {
                    cbbClass.DataSource = dt;
                    cbbClass.DisplayMember = "TENLOP";
                    cbbClass.ValueMember = "MALOP";
                }
                cbbClass.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Can not show list class", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void getListDataStudentFormClassID(String classID)
        {

        }


        public String getDepSelected()
        {
            return cbbDep.SelectedValue.ToString();
        }

        public String getBranchSelected()
        {
            branchID = cbbBranch.SelectedValue.ToString();
            return branchID;
        }

        public String getClassSelected()
        {
            classID = cbbClass.SelectedValue.ToString();
            return classID;
        }


        private void cbbDep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbDep.SelectedValue != null)
            {
                if (cbbDep.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.serverName = cbbDep.SelectedValue.ToString();

                if (cbbDep.SelectedIndex != Program.currentBranch)
                {
                    Program.userName = Program.remoteLogin;
                    Program.password = Program.remotePass;
                }
                else
                {
                    Program.userName = Program.currentUserName;
                    Program.password = Program.currentPass;
                }
                if (Program.Connection() == 0)
                    MessageBox.Show("Can not connect to new server", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    initUIComboBoxBranch();
                }
            }
        }

        private void cbbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            initUIComboBoxClass();
        }

        private void cbbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getListDataStudentFormClassID("LOPID");
        }
    }
}
