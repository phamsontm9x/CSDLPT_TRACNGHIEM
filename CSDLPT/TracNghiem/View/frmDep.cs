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
    public partial class frmDep : Form
    {
        int index = 0;
        String depID = "";
        public frmDep()
        {
            InitializeComponent();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTracNghiem);
        }

        private void frmDep_Load(object sender, EventArgs e)
        {
            dataSetTracNghiem.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dataSetTracNghiem.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connectStr;
            this.kHOATableAdapter.Fill(this.dataSetTracNghiem.KHOA);
            depID = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
            cbbDep.DataSource = Program.bds;
            cbbDep.DisplayMember = "MACS";
            cbbDep.ValueMember = "TENCS";
            cbbDep.SelectedIndex = Program.currentBranch;

            if (Program.currentRole == "TRUONG") cbbDep.Enabled = true;
            else cbbDep.Enabled = false;
            Program.currentBidingSource = bdsKhoa;
        }

        private void cbbDep_SelectedIndexChanged(object sender, EventArgs e)
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
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                else
                {
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.kHOATableAdapter.Fill(this.dataSetTracNghiem.KHOA);
                    depID = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
                }
            }
        }
    }
}
