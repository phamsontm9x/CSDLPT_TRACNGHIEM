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

            this.sp_DanhSachMonThiTableAdapter.Fill(this.dataSetTracNghiem.sp_DanhSachMonThi, Program.currentID);
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
            this.sp_DanhSachMonThiTableAdapter.Fill(this.dataSetTracNghiem.sp_DanhSachMonThi, Program.currentID);
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
    }
}
