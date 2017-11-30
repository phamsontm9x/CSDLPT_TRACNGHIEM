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
    public partial class frmTranscript : Form
    {
        String subjectID = "";
        String branchID = "";
        String classID = "";
        public frmTranscript()
        {
            InitializeComponent();
        }

        private void frmTranscript_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTracNghiem.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dataSetTracNghiem.MONHOC);
            dataSetTracNghiem.EnforceConstraints = false;
            this.sp_BangDiemMonHocLopTableAdapter.Connection.ConnectionString = Program.connectStr;
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
            String currentBranchName = getDepIDSelected();
            int indexStr = currentBranchName.IndexOf("\\") + 1;
            currentBranchName = currentBranchName.Substring(indexStr);

            String strLenh = "exec sp_DanhSachKhoa'" + currentBranchName + "'";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    cbbBranch.SelectedIndex = -1;
                    cbbBranch.DataSource = null;
                }
                else
                {
                    cbbBranch.DataSource = dt;
                    cbbBranch.DisplayMember = "TENKH";
                    cbbBranch.ValueMember = "MAKH";
                }

                cbbBranch.SelectedIndex = -1;
                initUIComboBoxClass();
            }
            else
            {
                MessageBox.Show("Can not show list branch", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void initUIComboBoxClass()
        {
            String currentClassName = getBranchIDSelected();

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
                    cbbClass.DisplayMember = "MALOP";
                    cbbClass.ValueMember = "MALOP";
                }
                cbbClass.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Can not show list class", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        public String getDepIDSelected()
        {
            return cbbDep.SelectedValue.ToString();
        }

        public String getBranchIDSelected()
        {
            branchID = cbbBranch.SelectedIndex >= 0 ? cbbBranch.SelectedValue.ToString() : "";
            return branchID;
        }

        public String getClassIDSelected()
        {
            classID = cbbClass.SelectedIndex >= 0 ? cbbClass.SelectedValue.ToString() : "";
            return classID;
        }

        public String getSubjectIDSelected()
        {
            subjectID = cbbSubject.SelectedIndex >= 0 ? cbbSubject.SelectedValue.ToString() : "";
            return subjectID;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            reportTranscript rp = new reportTranscript();
            String sqlStr = "exec sp_BangDiemMonHocLop '" + getClassIDSelected() + "', '" + getSubjectIDSelected() + "', '" + spTime.Text + "'";

            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable(sqlStr);

            rp.SetDataSource(dt);
            rp.SetParameterValue("MALOP", getClassIDSelected());
            rp.SetParameterValue("MAMH", getSubjectIDSelected());
            rp.SetParameterValue("LAN", spTime.Text);
            reportTranScript.ReportSource = rp;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
