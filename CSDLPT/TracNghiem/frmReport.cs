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
    public partial class frmReport : Form
    {
        String subjectID = "";
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTracNghiem.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dataSetTracNghiem.MONHOC);
            dataSetTracNghiem.EnforceConstraints = false;
            this.sp_BaiThiSinhVienTableAdapter.Connection.ConnectionString = Program.connectStr;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            reportStudentExam rp = new reportStudentExam();
            String sqlStr = "exec sp_BaiThiSinhVien '" + Program.currentID + "', '" + getSubjectIDSelected() + "', '" + spTime.Text + "'";

            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable(sqlStr);

            rp.SetDataSource(dt);
            rp.SetParameterValue("MASV", Program.currentID);
            rp.SetParameterValue("MAMH", getSubjectIDSelected());
            rp.SetParameterValue("LAN", spTime.Text);
            crtReport.ReportSource = rp;
        }

        public String getSubjectIDSelected()
        {
            subjectID = cbbSubject.SelectedIndex >= 0 ? cbbSubject.SelectedValue.ToString() : "";
            return subjectID;
        }
    }
}
