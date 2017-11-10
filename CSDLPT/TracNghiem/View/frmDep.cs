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
        String method = "";
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


            cbbDep.DataSource = Program.bds;
            cbbDep.DisplayMember = "MACS";
            cbbDep.ValueMember = "TENCS";
            cbbDep.SelectedIndex = Program.currentBranch;


            depID = ((DataRowView)bdsDep[0])["MAKH"].ToString();
            depID = "CS" + (cbbDep.SelectedIndex + 1) + "";

            
            Program.currentBidingSource = bdsDep;

            groupBox1.Enabled = true;
            txtDepName.Enabled = txtDepID.Enabled = false;

            setCurrentRole();
            if (bdsDep.Count == 0) btnDel.Enabled = false;
        }

        public void setCurrentRole()
        {
            if (Program.currentRole == "TRUONG")
            {
                cbbDep.Enabled = true;
                initButtonBarManage(false);
            }
            else
            {
                cbbDep.Enabled = false;
                btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
                btnSave.Enabled = btnCancel.Enabled = false;
            }
        }

        private void cbbDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDep.SelectedValue != null)
            {
                if (cbbDep.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.serverName = cbbDep.SelectedValue.ToString();
                depID = "CS" + (cbbDep.SelectedIndex + 1) + "";

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
                    MessageBox.Show("Connect Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.kHOATableAdapter.Fill(this.dataSetTracNghiem.KHOA);
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
            txtBranchID.Text = depID;
            txtBranchID.Enabled = false;
            groupBox2.Enabled = false;
            txtDepID.Focus();
            method = Program.NEW_METHOD;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnRefresh.Enabled = btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsDep.Position;
            groupBox1.Enabled = true;
            txtDepID.Enabled = false;
            txtDepName.Enabled = true;
            cbbDep.Enabled = false;
            groupBox2.Enabled = false;
            method = Program.UPDATE_METHOD;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnDel.Enabled = btnNew.Enabled = btnRefresh.Enabled = btnEdit.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String sqlStr = "";
            if (method == Program.NEW_METHOD)
            {
                sqlStr = "exec sp_KiemTraKhoa '" + txtDepID.Text + "', '" + method + "'";

                Program.myReader = Program.ExecSqlDataReader(sqlStr);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                if (Program.myReader.FieldCount > 0)
                {
                    MessageBox.Show("The " + txtDepID.Text + " has already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (txtDepID.Text.Length == 0 || txtDepName.Text.Length == 0)
                    {
                        MessageBox.Show("Department ID or Department Name can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Program.myReader.Close();
                        return;
                    }
                    else
                    {
                        if (txtDepID.Text.Length > 8)
                        {
                            MessageBox.Show("Department ID can not exceed 8 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtDepID.Focus();
                            return;
                        }
                        else if (txtDepName.Text.Length > 40)
                        {
                            MessageBox.Show("Department Name can not exceed 40 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtDepName.Focus();
                            return;
                        }
                        else
                        {
                            try
                            {
                                this.Validate();
                                bdsDep.EndEdit();
                                bdsDep.ResetCurrentItem();
                                this.kHOATableAdapter.Update(this.dataSetTracNghiem.KHOA);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Create department failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                                Program.myReader.Close();
                                return;
                            }
                        }
                    }
                }
                Program.myReader.Close();
            }
            else if (method == Program.UPDATE_METHOD)
            {
                sqlStr = "exec sp_KiemTraKhoa '" + txtDepID.Text + "', '" + method + "'";

                Program.myReader = Program.ExecSqlDataReader(sqlStr);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                currentBranchName = ((DataRowView)bdsDep[index])["TENKH"].ToString();
                if (txtDepName.Text == currentBranchName)
                {
                    MessageBox.Show("You must type different name!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.myReader.Close();
                    return;
                }
                else
                {
                    if (txtDepName.Text.Length == 0)
                    {
                        MessageBox.Show("Department Name can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (txtDepName.Text.Length > 40)
                        {
                            MessageBox.Show("Department Name can not exceed 40 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtDepName.Focus();
                            return;
                        }
                        else
                        {
                            try
                            {
                                this.Validate();
                                bdsDep.EndEdit();
                                bdsDep.ResetCurrentItem();
                                this.kHOATableAdapter.Update(this.dataSetTracNghiem.KHOA);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Update subjects failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                                Program.myReader.Close();
                                return;
                            }
                        }
                    }
                }
                Program.myReader.Close();
            }

            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsDep.Position;
            method = Program.DETELE_METHOD;
            currentBranchName = ((DataRowView)bdsDep[index])["TENKH"].ToString();
            currentBranchID = ((DataRowView)bdsDep[index])["MAKH"].ToString();
            String sqlStr = "";
            sqlStr = "exec sp_KiemTraKhoa '" + currentBranchID + "', '" + method + "'";
            
            Program.myReader = Program.ExecSqlDataReader(sqlStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            if(Program.myReader.FieldCount > 0)
            {
                MessageBox.Show("Can not delete " + currentBranchName + " branch. \nThe branch has data available! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Program.myReader.Close();
            } else
            {
                if (MessageBox.Show("Do you want to delete " + currentBranchName + " branch", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                        Program.myReader.Close();
                        this.kHOATableAdapter.Fill(this.dataSetTracNghiem.KHOA);
                        bdsDep.Position = bdsDep.Find("MAKH", currentBranchID);
                        return;
                    }
                }
            }
            Program.myReader.Close();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            txtDepID.Enabled = txtDepName.Enabled = false;
            if (Program.currentRole == "TRUONG")
            {
                cbbDep.Enabled = true;
            }
            else
            {
                cbbDep.Enabled = false;
            }
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

            setCurrentRole();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        public void initButtonBarManage(Boolean isEnable)
        {
            btnNew.Enabled = btnEdit.Enabled = btnSave.Enabled = btnRefresh.Enabled = btnDel.Enabled = btnCancel.Enabled = isEnable;
        }
    }
}
