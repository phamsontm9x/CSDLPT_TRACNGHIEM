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
    public partial class frmStudent : Form
    {
        int index;
        String method = "";
        String currentStudentID = "";
        String branchID = "";
        String classID = "";
        public frmStudent()
        {
            InitializeComponent();
        }


        private void frmStudent_Load(object sender, EventArgs e)
        {
            dataSetTracNghiem.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dataSetTracNghiem.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.dataSetTracNghiem.SINHVIEN);

            initUIComboBoxDep();

            groupBox1.Enabled = true;
            txtStudentID.Enabled = txtFirstName.Enabled = txtLastName.Enabled = txtAddress.Enabled = pickerBirthday.Enabled = false;

            setCurrentRole();
        }

        public void initUIComboBoxDep()
        {
            cbbDep.DataSource = Program.bds;
            cbbDep.DisplayMember = "MACS";
            cbbDep.ValueMember = "TENCS";
            cbbDep.SelectedIndex = Program.currentBranch;

            initUIComboBoxBranch();
        }

        public void initUIComboBoxBranch()
        {
            String currentBranchName = getDepIDSelected();
            int indexStr = currentBranchName.IndexOf("\\") + 1;
            currentBranchName = currentBranchName.Substring(indexStr);

            String strLenh = "exec sp_DanhSachKhoa'" + currentBranchName + "'";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    cbbBranch.SelectedIndex = -1;
                    cbbBranch.DataSource = null;
                }
                else
                {
                    cbbBranch.DataSource = dt;
                    cbbBranch.DisplayMember = "TENKH";
                    cbbBranch.ValueMember = "MAKH";
                }

                cbbBranch.SelectedIndex = -1;
                getDataStudentFormClassID("");
                //initUIComboBoxClass();
            }
            else
            {
                MessageBox.Show("Can not show list branch", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void initUIComboBoxClass()
        {
            String currentClassName = getBranchIDSelected();

            String strLenh = "exec sp_DanhSachLopTheoKhoa'" + currentClassName + "'";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    cbbClass.SelectedIndex = -1;
                    cbbClass.DataSource = null;
                }
                else
                {
                    cbbClass.DataSource = dt;
                    cbbClass.DisplayMember = "MALOP";
                    cbbClass.ValueMember = "MALOP";
                }
                cbbClass.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Can not show list class", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void getDataStudentFormClassID(String classID)
        {
            try
            {
                String currentServerName = cbbDep.SelectedValue.ToString();
                int indexStr = currentServerName.IndexOf("\\") + 1;
                currentServerName = currentServerName.Substring(indexStr);

                this.sp_DanhSachSinhVienTheoLopTableAdapter.Fill(this.dataSetTracNghiem.sp_DanhSachSinhVienTheoLop, classID, currentServerName);
                this.sp_DanhSachSinhVienTheoLopTableAdapter.ClearBeforeFill = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            setCurrentRole();
        }


        public String getDepIDSelected()
        {
            return cbbDep.SelectedValue.ToString();
        }

        public String getBranchIDSelected()
        {
            branchID = cbbBranch.SelectedValue.ToString();
            return branchID;
        }

        public String getClassIDSelected()
        {
            classID = cbbClass.SelectedValue.ToString();
            return classID;
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

        private void cbbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            initUIComboBoxClass();
        }

        private void cbbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getDataStudentFormClassID(getClassIDSelected());
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsStudentFromClass.Position;
            groupBox1.Enabled = true;
            bdsStudentFromClass.AddNew();
            txtStudentID.Enabled = txtFirstName.Enabled = txtLastName.Enabled = txtAddress.Enabled = pickerBirthday.Enabled = true;
            pickerBirthday.Format = DateTimePickerFormat.Custom;
            pickerBirthday.CustomFormat = " ";
            cbbBranch.Enabled = false;
            cbbClass.Enabled = false;
            groupBox2.Enabled = false;
            txtStudentID.Focus();
            method = Program.NEW_METHOD;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnRefresh.Enabled = btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsStudentFromClass.Position;
            groupBox1.Enabled = true;
            txtStudentID.Enabled = false;
            txtFirstName.Enabled = txtLastName.Enabled = txtAddress.Enabled = pickerBirthday.Enabled = true;
            cbbBranch.Enabled = false;
            cbbClass.Enabled = false;
            groupBox2.Enabled = false;
            method = Program.UPDATE_METHOD;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnDel.Enabled = btnNew.Enabled = btnRefresh.Enabled = btnEdit.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsStudentFromClass.Count != 1)
            {
                currentStudentID = ((DataRowView)bdsStudentFromClass[index])["MASV"].ToString();
            }
            String sqlStr = "";

            if (method == Program.NEW_METHOD)
            {
                sqlStr = "exec sp_KiemTraSinhVienTheoLop '" + txtStudentID.Text + "', '" + method + "'";

                Program.myReader = Program.ExecSqlDataReader(sqlStr);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                if (Program.myReader.FieldCount > 0)
                {
                    MessageBox.Show("The " + txtStudentID.Text + " has already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.myReader.Close();
                    return;
                }
                else
                {
                    if (txtStudentID.Text.Length == 0 || txtLastName.Text.Length == 0 || txtFirstName.Text.Length == 0)
                    {
                        MessageBox.Show("Teacher ID or Name can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        try
                        {
                            this.Validate();
                            bdsStudentFromClass.EndEdit();
                            bdsStudentFromClass.ResetCurrentItem();
                            this.sp_DanhSachSinhVienTheoLopTableAdapter.Insert(txtStudentID.Text, txtLastName.Text, txtFirstName.Text, pickerBirthday.Value.Date, txtAddress.Text, getClassIDSelected());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Create student failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                            Program.myReader.Close();
                            return;
                        }
                    }
                    Program.myReader.Close();
                }
            }
            else if (method == Program.UPDATE_METHOD)
            {
                sqlStr = "exec sp_KiemTraSinhVienTheoLop '" + txtStudentID.Text + "', '" + method + "'";

                Program.myReader = Program.ExecSqlDataReader(sqlStr);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                if (txtLastName.Text.Length == 0)
                {
                    MessageBox.Show("Last Name can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtFirstName.Text.Length == 0)
                {
                    MessageBox.Show("First Name can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        this.Validate();
                        bdsStudentFromClass.EndEdit();
                        bdsStudentFromClass.ResetCurrentItem();
                        this.sp_DanhSachSinhVienTheoLopTableAdapter.Update(currentStudentID, txtLastName.Text, txtFirstName.Text, pickerBirthday.Value.Date, txtAddress.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update student failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;
                    }
                }
                Program.myReader.Close();
            }
            groupBox1.Enabled = true;
            cbbBranch.Enabled = true;
            groupBox2.Enabled = true;
            txtStudentID.Enabled = txtFirstName.Enabled = txtLastName.Enabled = txtAddress.Enabled = pickerBirthday.Enabled = false;
            btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsStudentFromClass.Position;
            method = Program.DETELE_METHOD;
            currentStudentID = ((DataRowView)bdsStudentFromClass[index])["MASV"].ToString();

            String sqlStr = "";
            sqlStr = "exec sp_KiemTraSinhVienTheoLop '" + currentStudentID + "', '" + method + "'";
            Program.myReader = Program.ExecSqlDataReader(sqlStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            if (Program.myReader.FieldCount > 0)
            {
                MessageBox.Show("Can not delete this student. \nThe student has data available! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Program.myReader.Close();
            }
            else
            {
                if (MessageBox.Show("Do you want to delete this student?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bdsStudentFromClass.RemoveCurrent();
                        this.sp_DanhSachSinhVienTheoLopTableAdapter.Delete(currentStudentID);
                        if (bdsStudentFromClass.Count == 0)
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
                        getDataStudentFormClassID(getClassIDSelected());
                        bdsStudentFromClass.Position = bdsStudentFromClass.Find("MASV", currentStudentID);
                        return;
                    }
                }
            }
            Program.myReader.Close();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            txtStudentID.Enabled = txtFirstName.Enabled = txtLastName.Enabled = txtAddress.Enabled = pickerBirthday.Enabled = false;

            if (bdsStudentFromClass.Count == 0) btnDel.Enabled = false;
            else btnDel.Enabled = true;

            if (Program.currentRole == "TRUONG")
            {
                cbbDep.Enabled = true;
                cbbBranch.Enabled = true;
                cbbClass.Enabled = true;
            }
            else
            {
                cbbDep.Enabled = false;
                cbbBranch.Enabled = true;
                cbbClass.Enabled = true;
            }
            groupBox2.Enabled = true;
            bdsStudentFromClass.MoveFirst();
            getDataStudentFormClassID(getClassIDSelected());

            btnNew.Enabled = btnEdit.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            txtStudentID.Enabled = txtFirstName.Enabled = txtLastName.Enabled = txtAddress.Enabled = pickerBirthday.Enabled = false;
            bdsStudentFromClass.MoveFirst();
            getDataStudentFormClassID(getClassIDSelected());
            groupBox2.Enabled = true;

            setCurrentRole();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        public void setCurrentRole()
        {
            if (Program.currentRole == "TRUONG")
            {
                cbbDep.Enabled = true;
                cbbBranch.Enabled = true;
                cbbClass.Enabled = true;
                initButtonBarManage(false);
            }
            else
            {
                cbbDep.Enabled = false;
                cbbBranch.Enabled = true;
                cbbClass.Enabled = true;
                btnNew.Enabled = btnEdit.Enabled = btnRefresh.Enabled = true;
                btnSave.Enabled = btnCancel.Enabled = false;

                if (bdsStudentFromClass.Count == 0)
                {
                    btnDel.Enabled = btnEdit.Enabled = btnRefresh.Enabled = false;
                }
                else
                {
                    btnDel.Enabled = btnEdit.Enabled = btnRefresh.Enabled = true;
                }
            }
        }

        public void initButtonBarManage(Boolean isEnable)
        {
            btnNew.Enabled = btnEdit.Enabled = btnSave.Enabled = btnRefresh.Enabled = btnDel.Enabled = btnCancel.Enabled = isEnable;
        }

        private void txtFirstName_KeyboardPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyboardPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pickerBirthday_ValueChanged(object sender, EventArgs e)
        {
            pickerBirthday.Format = DateTimePickerFormat.Short;
            pickerBirthday.CustomFormat = "yyyy-MM-dd";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            bdsStudentFromClass.Filter = "MASV LIKE '%" + this.txtSearch.Text + "%'" + " OR TEN LIKE '%" + this.txtSearch.Text + "%'";
        }

        private void checkBoxSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSearch.Checked == true)
            {
                txtSearch.Text = "";
                getDataStudentFormClassID("");
                cbbBranch.SelectedIndex = -1;
                cbbClass.SelectedIndex = -1;
                cbbClass.Enabled = false;
                cbbBranch.Enabled = false;
            }
            else
            {
                txtSearch.Text = "";
                cbbClass.Enabled = true;
                cbbBranch.Enabled = true;
            }
        }
    }
}
