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
    public partial class frmListExam : Form
    {
        public frmListExam()
        {
            InitializeComponent();
        }

        private void frmListExam_Load(object sender, EventArgs e)
        {
            this.dataSetTracNghiem.EnforceConstraints = false;
            this.sp_DanhSachMonThiTableAdapter.Connection.ConnectionString = Program.connectStr;

            if (Program.currentRole == "SINHVIEN")
            {
                btnStart.Visible = true;
                this.sp_DanhSachMonThiTableAdapter.Fill(this.dataSetTracNghiem.sp_DanhSachMonThi, Program.currentID);
                cbbDep.Visible = false;
            }
            else if (Program.currentRole == "TRUONG")
            {
                btnStart.Visible = false;
                cbbDep.Visible = true;
                initUIComboBoxDep();
            }
            String currentDay = DateTime.Now.ToString("MM/dd/yyyy");

            if (currentDay == lblDate.Text)
            {
                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Program.insertClassID = lblClassId.Text;
            Program.insertSubjectID = lblSubjectId.Text;
            Program.insertLevel = lblLevel.Text;
            Program.insertTime = lblTime.Text;
            Program.insertCountdown = lblCountdown.Text;
            Program.insertDate = lblDate.Text;
            Program.insertNumberQuest = lblNumber.Text;

            frmTest frm = new frmTest();
            frm.ShowDialog();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            String currentDay = DateTime.Now.ToString("MM/dd/yyyy");
              
            if (currentDay == lblDate.Text)
            {
                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.currentRole == "SINHVIEN")
            {
                btnStart.Visible = true;
                this.sp_DanhSachMonThiTableAdapter.Fill(this.dataSetTracNghiem.sp_DanhSachMonThi, Program.currentID);
                cbbDep.Visible = false;
            }
            else if (Program.currentRole == "TRUONG")
            {
                btnStart.Visible = false;
                cbbDep.Visible = true;
                getDataFromDep();
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            String currentDay = DateTime.Now.ToString("MM/dd/yyyy");

            if (currentDay == lblDate.Text)
            {
                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
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
                    getDataFromDep();
                }
            }
        }

        public void getDataFromDep()
        {
            try
            {
                String currentServerName = cbbDep.SelectedValue.ToString();
                int indexStr = currentServerName.IndexOf("\\") + 1;
                currentServerName = currentServerName.Substring(indexStr);
                this.sp_DanhSachMonThiTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.sp_DanhSachMonThiTableAdapter.Fill(this.dataSetTracNghiem.sp_DanhSachMonThi, null);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void initUIComboBoxDep()
        {
            cbbDep.DataSource = Program.bds;
            cbbDep.DisplayMember = "MACS";
            cbbDep.ValueMember = "TENCS";
            cbbDep.SelectedIndex = Program.currentBranch;

            getDataFromDep();
        }
    }
}
