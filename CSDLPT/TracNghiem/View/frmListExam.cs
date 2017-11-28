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
            this.sp_DanhSachMonThiTableAdapter.Fill(this.dataSetTracNghiem.sp_DanhSachMonThi, "011");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
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
    }
}
