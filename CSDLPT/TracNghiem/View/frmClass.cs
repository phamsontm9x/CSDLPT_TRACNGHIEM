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
        String currentClassID = "";
        String currentClassName = "";
        String method = "";
        String branchID = "";
        public frmClass()
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
                    initUIComboBoxBranch();
                }
            }
        }

        public void initUIComboBoxDep()
        {
            cbbDep.DataSource = Program.bds;
            cbbDep.DisplayMember = "MACS";
            cbbDep.ValueMember = "TENCS";
            cbbDep.SelectedIndex = Program.currentBranch;

            initUIComboBoxBranch();
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            dataSetTracNghiem.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connectStr;
            // TODO: This line of code loads data into the 'dataSetTracNghiem.LOP' table. You can move, or remove it, as needed.

            initUIComboBoxDep();

            groupBox1.Enabled = true;
            txtClassName.Enabled = txtClassId.Enabled = false;

            setCurrentRole();
        }
        public void setCurrentRole()
        {
            if (Program.currentRole == "TRUONG")
            {
                cbbDep.Enabled = true;
                cbbBranch.Enabled = true;
                initButtonBarManage(false);
            }
            else
            {
                cbbDep.Enabled = false;
                cbbDep.Visible = false;
                cbbBranch.Enabled = true;
                btnNew.Enabled = btnEdit.Enabled = btnRefresh.Enabled = true;
                btnSave.Enabled = btnCancel.Enabled = false;

                if (bdsClassFromDep.Count == 0)
                {
                    btnDel.Enabled = btnEdit.Enabled = btnRefresh.Enabled = false;
                }
                else
                {
                    btnDel.Enabled = btnEdit.Enabled = btnRefresh.Enabled = true;
                }
            }
        }

        public void initUIComboBoxBranch ()
        {
            String currentServerName = cbbDep.SelectedValue.ToString();
            int indexStr = currentServerName.IndexOf("\\") + 1;
            currentServerName = currentServerName.Substring(indexStr);

            String strLenh = "exec sp_DanhSachKhoa'" + currentServerName + "'";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    cbbBranch.DataSource = null;
                }
                else
                {
                    cbbBranch.DataSource = dt;
                    cbbBranch.DisplayMember = "TENKH";
                    cbbBranch.ValueMember = "MAKH";
                }
                cbbBranch.SelectedIndex = -1;
                getDataClassFromDep("");
            }
            else
            {
                MessageBox.Show("Can not show list branch", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public String getMaKhoaSelected()
        {
            if (cbbBranch.Items.Count > 0)
            branchID = cbbBranch.SelectedValue.ToString();
            return branchID;
        }

        public void getDataClassFromDep(String branchID)
        {
            try
            {
                String currentServerName = cbbDep.SelectedValue.ToString();
                int indexStr = currentServerName.IndexOf("\\") + 1;
                currentServerName = currentServerName.Substring(indexStr);
                this.sp_DanhSachLopTheoKhoaTableAdapter.Fill(this.dataSetTracNghiem.sp_DanhSachLopTheoKhoa, branchID, currentServerName);
                this.sp_DanhSachLopTheoKhoaTableAdapter.ClearBeforeFill = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            setCurrentRole();
        }

        private void cbbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            getDataClassFromDep(getMaKhoaSelected());
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            txtClassId.Enabled = txtClassName.Enabled = false;

            if (bdsClassFromDep.Count == 0) btnDel.Enabled = false;
            else btnDel.Enabled = true;

            if (Program.currentRole == "TRUONG")
            {
                cbbDep.Enabled = true;
                cbbBranch.Enabled = true;
            }
            else
            {
                cbbDep.Enabled = false;
                cbbBranch.Enabled = true;
            }
            groupBox3.Enabled = true;
            bdsClassFromDep.MoveFirst();
            getDataClassFromDep(getMaKhoaSelected());

            btnNew.Enabled = btnEdit.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsClassFromDep.Position;
            groupBox1.Enabled = true;
            bdsClassFromDep.AddNew();
            txtClassId.Enabled = txtClassName.Enabled = true;
            cbbBranch.Enabled = false;
            groupBox3.Enabled = false;
            txtClassId.Focus();
            method = Program.NEW_METHOD;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnRefresh.Enabled = btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = false;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
            branchID = "";
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsClassFromDep.Count == 0) btnDel.Enabled = false;
            index = bdsClassFromDep.Position;
            method = Program.DETELE_METHOD;
            currentClassID = ((DataRowView)bdsClassFromDep[index])["MALOP"].ToString();
            currentClassName = ((DataRowView)bdsClassFromDep[index])["TENLOP"].ToString();

            String sqlStr = "";
            sqlStr = "exec sp_KiemTraLopTheoKhoa'" + currentClassID + "', '" + method + "'";
            Program.myReader = Program.ExecSqlDataReader(sqlStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            if (Program.myReader.FieldCount > 0)
            {
                MessageBox.Show("Can not delete " + currentClassName + " class. \nThe class has data available! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (MessageBox.Show("Do you want to delete " + currentClassName + " class?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bdsClassFromDep.RemoveCurrent();
                        this.sp_DanhSachLopTheoKhoaTableAdapter.Delete(currentClassID);
                        if (bdsClassFromDep.Count == 0)
                        {
                            btnDel.Enabled = false;
                            btnEdit.Enabled = false;
                            btnRefresh.Enabled = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failure. Please delete again!\n" + ex.Message, "",
                           MessageBoxButtons.OK);
                        getDataClassFromDep(getMaKhoaSelected());
                        bdsClassFromDep.Position = bdsClassFromDep.Find("MALOP", currentClassID);
                        return;
                    }
                }
            }
            Program.myReader.Close();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsClassFromDep.Count != 1)
            {
                currentClassID = ((DataRowView)bdsClassFromDep[index])["MALOP"].ToString();
                currentClassName = ((DataRowView)bdsClassFromDep[index])["TENLOP"].ToString();
            }
            String sqlStr = "";

            if (method == Program.NEW_METHOD)
            {
                sqlStr = "exec sp_KiemTraLopTheoKhoa '" + txtClassId.Text + "', '" + method + "'";

                Program.myReader = Program.ExecSqlDataReader(sqlStr);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                if (Program.myReader.FieldCount > 0)
                {
                    MessageBox.Show("The " + txtClassId.Text + " has already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.myReader.Close();
                    return;
                }
                else
                {
                    if (txtClassId.Text.Length == 0 || txtClassName.Text.Length == 0)
                    {
                        MessageBox.Show("Class ID or Class Name can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        try
                        {
                            this.Validate();
                            bdsClassFromDep.EndEdit();
                            bdsClassFromDep.ResetCurrentItem();
                            this.sp_DanhSachLopTheoKhoaTableAdapter.Insert(txtClassId.Text, txtClassName.Text, getMaKhoaSelected());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Create class failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                            Program.myReader.Close();
                            return;
                        }
                    }
                    Program.myReader.Close();
                }
            }
            else if (method == Program.UPDATE_METHOD)
            {
                sqlStr = "exec sp_KiemTraLopTheoKhoa '" + txtClassId.Text + "', '" + method + "'";

                Program.myReader = Program.ExecSqlDataReader(sqlStr);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                if (txtClassName.Text == currentClassName)
                {
                    MessageBox.Show("You must type different name!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.myReader.Close();
                    return;
                }
                else
                {
                    if (txtClassName.Text.Length == 0)
                    {
                        MessageBox.Show("Class Name can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        try
                        {
                            this.Validate();
                            bdsClassFromDep.EndEdit();
                            bdsClassFromDep.ResetCurrentItem();
                            this.sp_DanhSachLopTheoKhoaTableAdapter.Update(currentClassID, txtClassName.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Update class failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                            Program.myReader.Close();
                            return;
                        }
                    }
                }
                Program.myReader.Close();
            }

            groupBox1.Enabled = true;
            cbbBranch.Enabled = true;
            groupBox3.Enabled = true;
            txtClassId.Enabled = txtClassName.Enabled = false;
            btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsClassFromDep.Position;
            groupBox1.Enabled = true;
            txtClassId.Enabled = false;
            txtClassName.Enabled = true;
            cbbBranch.Enabled = false;
            groupBox3.Enabled = false;
            method = Program.UPDATE_METHOD;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnDel.Enabled = btnNew.Enabled = btnRefresh.Enabled = btnEdit.Enabled = false;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            txtClassId.Enabled = txtClassName.Enabled = false;
            groupBox3.Enabled = true;
            bdsClassFromDep.MoveFirst();
            getDataClassFromDep(getMaKhoaSelected());

            setCurrentRole();
        }
        public void initButtonBarManage(Boolean isEnable)
        {
            btnNew.Enabled = btnEdit.Enabled = btnSave.Enabled = btnRefresh.Enabled = btnDel.Enabled = btnCancel.Enabled = isEnable;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            bdsClassFromDep.Filter =  "MALOP LIKE '%" + this.txtSearch.Text + "%'" + " OR TENLOP LIKE '%" + this.txtSearch.Text + "%'";
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxSearch.Checked == true)
            {
                getDataClassFromDep("");
                cbbBranch.SelectedIndex = -1;
                cbbBranch.Enabled = false;
            } else
            {
                cbbBranch.Enabled = true;
            }
        }
    }
}
