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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
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
                    initUIComboBoxClass();
                    getDataClassFromDep();
                }
            }
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            dataSetTracNghiem.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dataSetTracNghiem.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dataSetTracNghiem.MONHOC);

            initUIComboBoxDep();
        }

        public void initUIComboBoxDep()
        {
            cbbDep.DataSource = Program.bds;
            cbbDep.DisplayMember = "MACS";
            cbbDep.ValueMember = "TENCS";
            cbbDep.SelectedIndex = Program.currentBranch;

            getDataClassFromDep();
            initUIComboBoxClass();
        }

        public void initUIComboBoxClass()
        {
            String currentServerName = cbbDep.SelectedValue.ToString();
            int indexStr = currentServerName.IndexOf("\\") + 1;
            currentServerName = currentServerName.Substring(indexStr);

            String strLenh = "exec sp_DanhSachLopTheoKhoaVaCoSo " + "NULL" + ",'" + currentServerName + "'";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
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
                MessageBox.Show("Can not show list branch", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void getDataClassFromDep()
        {
            try
            {
                String currentServerName = cbbDep.SelectedValue.ToString();
                int indexStr = currentServerName.IndexOf("\\") + 1;
                currentServerName = currentServerName.Substring(indexStr);
                this.sp_DanhSachGVDKTheoCosoTableAdapter.Fill(this.dataSetTracNghiem.sp_DanhSachGVDKTheoCoso, currentServerName);
                this.sp_DanhSachGVDKTheoCosoTableAdapter.ClearBeforeFill = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //setCurrentRole();
        }
    }
}
