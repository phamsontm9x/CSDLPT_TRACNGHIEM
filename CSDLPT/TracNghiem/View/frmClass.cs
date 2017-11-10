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
                    MessageBox.Show("Can not connect to new server", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    initUIComboBoxBranch();
                    getDataClassFromDep(getMaKhoaSelected());
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

            cbbDep.DataSource = Program.bds;
            cbbDep.DisplayMember = "MACS";
            cbbDep.ValueMember = "TENCS";
            cbbDep.SelectedIndex = Program.currentBranch;

            initUIComboBoxBranch();
            getDataClassFromDep(getMaKhoaSelected());

            if (Program.currentRole == "TRUONG") cbbDep.Enabled = true;
            else cbbDep.Enabled = false;
        }

        public void initUIComboBoxBranch ()
        {
            String currentBranchName = cbbDep.SelectedValue.ToString();
            int indexStr = currentBranchName.IndexOf("\\") + 1;
            currentBranchName = currentBranchName.Substring(indexStr);

            String strLenh = "exec sp_DanhSachKhoa'" + currentBranchName + "'";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            if (dt != null)
            {
                cbbBranch.DataSource = dt;
                cbbBranch.DisplayMember = "TENKH";
                cbbBranch.ValueMember = "MAKH";
            } else
            {
                MessageBox.Show("Can not show list branch", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            String branchID = cbbBranch.SelectedValue.ToString();
        }

        public String getMaKhoaSelected()
        {
            String branchID = cbbBranch.SelectedValue.ToString();
            return branchID;
        }

        public void getDataClassFromDep(String branchID)
        {
            try
            {
                this.sp_DanhSachLopTheoKhoaTableAdapter.Fill(this.dataSetTracNghiem.sp_DanhSachLopTheoKhoa, branchID);
                this.sp_DanhSachLopTheoKhoaTableAdapter.ClearBeforeFill = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void cbbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getDataClassFromDep(getMaKhoaSelected());
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsClassFromDep.Position;
            groupBox1.Enabled = true;
            bdsClassFromDep.AddNew();
            txtClassId.Enabled = true;
            txtClassName.Enabled = true;
            cbbDep.Enabled = false;
            cbbBranch.Enabled = false;
            
            //txtBranchID.Text = depID;
            //txtBranchID.Enabled = false;
            //groupBox2.Enabled = false;
            //txtDepID.Focus();
            //method = Program.NEW_METHOD;

            //btnCancel.Enabled = btnSave.Enabled = true;
            //btnRefresh.Enabled = btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = false;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            txtClassId.Enabled = txtClassName.Enabled = false;
            if (Program.currentRole == "TRUONG")
            {
                cbbDep.Enabled = true;
            }
            else
            {
                cbbDep.Enabled = false;
            }
            groupBox2.Enabled = true;
            bdsClassFromDep.MoveFirst();
            getDataClassFromDep(getMaKhoaSelected());

            btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }
    }
}
