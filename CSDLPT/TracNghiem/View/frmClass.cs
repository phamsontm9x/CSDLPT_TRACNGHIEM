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
    public partial class frmClass : Form
    {
        int index;
        String depID = "";
        public frmClass()
        {
            InitializeComponent();
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
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.lOPTableAdapter.Fill(this.dataSetTracNghiem.LOP);
                    depID = ((DataRowView)bdsClass[0])["MAKH"].ToString();
                }
            }
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsClass.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTracNghiem);

        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            dataSetTracNghiem.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connectStr;
            // TODO: This line of code loads data into the 'dataSetTracNghiem.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dataSetTracNghiem.LOP);
            depID = ((DataRowView)bdsClass[0])["MAKH"].ToString();
            cbbDep.DataSource = Program.bds;
            cbbDep.DisplayMember = "MACS";
            cbbDep.ValueMember = "TENCS";
            cbbDep.SelectedIndex = Program.currentBranch;

            if (Program.currentRole == "TRUONG") cbbDep.Enabled = true;
            else cbbDep.Enabled = false;
        }

        private void cbbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
