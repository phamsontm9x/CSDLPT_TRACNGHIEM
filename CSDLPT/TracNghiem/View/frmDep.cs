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
        String currentBranchID = "";
        String currentBranchName = "";
        public frmDep()
        {
            InitializeComponent();
            this.bdsDep.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTracNghiem);
        }

        private void frmDep_Load(object sender, EventArgs e)
        {
            dataSetTracNghiem.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dataSetTracNghiem.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.dataSetTracNghiem.GIAOVIEN);
            // TODO: This line of code loads data into the 'dataSetTracNghiem.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dataSetTracNghiem.LOP);
            
            // TODO: This line of code loads data into the 'dataSetTracNghiem.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connectStr;
            this.kHOATableAdapter.Fill(this.dataSetTracNghiem.KHOA);
            depID = ((DataRowView)bdsDep[0])["MAKH"].ToString();
            cbbDep.DataSource = Program.bds;
            cbbDep.DisplayMember = "MACS";
            cbbDep.ValueMember = "TENCS";
            cbbDep.SelectedIndex = Program.currentBranch;

            if (Program.currentRole == "TRUONG") cbbDep.Enabled = true;
            else cbbDep.Enabled = false;
            Program.currentBidingSource = bdsDep;

            groupBox1.Enabled = true;
            txtDepName.Enabled = txtDepID.Enabled = false;
            btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
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
                    depID = ((DataRowView)bdsDep[0])["MAKH"].ToString();
                }
            }
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsDep.Position;
            groupBox1.Enabled = true;
            txtDepID.Enabled = txtDepName.Enabled = true;
            cbbDep.Enabled = false;
            bdsDep.AddNew();
            groupBox2.Enabled = false;
            txtDepID.Focus();

            btnCancel.Enabled = btnSave.Enabled = true;
            btnRefresh.Enabled = btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsDep.Position;
            groupBox1.Enabled = true;
            txtDepID.Enabled = txtDepName.Enabled = true;
            cbbDep.Enabled = false;
            groupBox2.Enabled = false;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnDel.Enabled = btnNew.Enabled = btnRefresh.Enabled = btnEdit.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsDep.Position;
            currentBranchName = ((DataRowView)bdsDep[index])["TENKH"].ToString();
            currentBranchID = ((DataRowView)bdsDep[index])["MAKH"].ToString();
            String sqlStr = "";
            sqlStr = "exec sp_KTKHOA '" + currentBranchID + "'";

            Program.myReader = Program.ExecSqlDataReader(sqlStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            if (Program.myReader.GetString(0) == "1")
            {
                MessageBox.Show("Can not delete. \nThe branch has data available! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (MessageBox.Show("Do you want to delete " + currentBranchName + " branch", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bdsDep.RemoveCurrent();
                    this.kHOATableAdapter.Update(this.dataSetTracNghiem.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failure. Please delete again!\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.kHOATableAdapter.Fill(this.dataSetTracNghiem.KHOA);
                    bdsDep.Position = bdsDep.Find("MAKH", currentBranchID);
                    return;
                }
            }
            if (bdsDep.Count == 0) btnDel.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            txtDepID.Enabled = txtDepName.Enabled = false;
            cbbDep.Enabled = true;
            groupBox2.Enabled = true;
            bdsDep.MoveFirst();
            this.kHOATableAdapter.Fill(this.dataSetTracNghiem.KHOA);

            btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            txtDepID.Enabled = txtDepName.Enabled = false;
            cbbDep.Enabled = true;
            groupBox2.Enabled = true;
            index = bdsDep.Position;
            bdsDep.CancelEdit();

            btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
