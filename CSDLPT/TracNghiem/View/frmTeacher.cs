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
    public partial class frmTeacher : Form
    {
        int index = 0;
        String branchID = "";
        String currentTeacherID = "";
        String method = "";

        public frmTeacher()
        {
            InitializeComponent();
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {
            dataSetTracNghiem.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dataSetTracNghiem.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.gIAOVIENTableAdapter.Fill(this.dataSetTracNghiem.GIAOVIEN);

            initUIComboBoxDep();

            groupBox1.Enabled = true;
            txtTeacherID.Enabled = txtFirstName.Enabled = txtLastName.Enabled = txtDegree.Enabled = false;

            setCurrentRole();
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

        private void cbbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getDataTeacherFromDep(getMaKhoaSelected());
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsTeacherFromDep.Position;
            groupBox1.Enabled = true;
            bdsTeacherFromDep.AddNew();
            txtTeacherID.Enabled = txtFirstName.Enabled = txtLastName.Enabled = txtDegree.Enabled = true;
            cbbBranch.Enabled = false;
            groupBox2.Enabled = false;
            txtTeacherID.Focus();
            method = Program.NEW_METHOD;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnRefresh.Enabled = btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsTeacherFromDep.Position;
            groupBox1.Enabled = true;
            txtTeacherID.Enabled = false;
            txtFirstName.Enabled = txtLastName.Enabled = txtDegree.Enabled = true;
            cbbBranch.Enabled = false;
            groupBox2.Enabled = false;
            method = Program.UPDATE_METHOD;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnDel.Enabled = btnNew.Enabled = btnRefresh.Enabled = btnEdit.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsTeacherFromDep.Count != 1)
            {
                currentTeacherID = ((DataRowView)bdsTeacherFromDep[index])["MAGV"].ToString();
            }
            String sqlStr = "";

            if (method == Program.NEW_METHOD)
            {
                sqlStr = "exec sp_KiemTraGiaoVienTheoKhoa '" + txtTeacherID.Text + "', '" + method + "'";

                Program.myReader = Program.ExecSqlDataReader(sqlStr);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                if (Program.myReader.FieldCount > 0)
                {
                    MessageBox.Show("The " + txtTeacherID.Text + " has already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.myReader.Close();
                    return;
                }
                else
                {
                    if (txtTeacherID.Text.Length == 0 || txtLastName.Text.Length == 0 || txtFirstName.Text.Length == 0)
                    {
                        MessageBox.Show("Teacher ID or Name can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        try
                        {
                            this.Validate();
                            bdsTeacherFromDep.EndEdit();
                            bdsTeacherFromDep.ResetCurrentItem();
                            this.sp_DanhSachGiaoVienTheoKhoaTableAdapter.Insert(txtTeacherID.Text, txtLastName.Text, txtFirstName.Text, txtDegree.Text, getMaKhoaSelected());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Create teacher failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                            Program.myReader.Close();
                            return;
                        }
                    }
                    Program.myReader.Close();
                }
            }
            else if (method == Program.UPDATE_METHOD)
            {
                sqlStr = "exec sp_KiemTraGiaoVienTheoKhoa '" + txtTeacherID.Text + "', '" + method + "'";

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
                        bdsTeacherFromDep.EndEdit();
                        bdsTeacherFromDep.ResetCurrentItem();
                        this.sp_DanhSachGiaoVienTheoKhoaTableAdapter.Update(currentTeacherID, txtLastName.Text, txtFirstName.Text, txtDegree.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update teacher failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;
                    }
                    Program.myReader.Close();
                }
            }
            groupBox1.Enabled = true;
            cbbBranch.Enabled = true;
            groupBox2.Enabled = true;
            txtTeacherID.Enabled = txtFirstName.Enabled = txtLastName.Enabled = txtDegree.Enabled = false;
            btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsTeacherFromDep.Position;
            method = Program.DETELE_METHOD;
            currentTeacherID = ((DataRowView)bdsTeacherFromDep[index])["MAGV"].ToString();

            String sqlStr = "";
            sqlStr = "exec sp_KiemTraGiaoVienTheoKhoa'" + currentTeacherID + "', '" + method + "'";
            Program.myReader = Program.ExecSqlDataReader(sqlStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            if (Program.myReader.FieldCount > 0)
            {
                MessageBox.Show("Can not delete this teacher. \nThe teacher has data available! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Program.myReader.Close();
            }
            else
            {
                if (MessageBox.Show("Do you want to delete this teacher?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bdsTeacherFromDep.RemoveCurrent();
                        this.sp_DanhSachGiaoVienTheoKhoaTableAdapter.Delete(currentTeacherID);
                        if (bdsTeacherFromDep.Count == 0)
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
                        getDataTeacherFromDep(getMaKhoaSelected());
                        bdsTeacherFromDep.Position = bdsTeacherFromDep.Find("MAGV", currentTeacherID);
                        return;
                    }
                }
            }
            Program.myReader.Close();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            txtTeacherID.Enabled = txtFirstName.Enabled = txtLastName.Enabled = txtDegree.Enabled = false;

            if (bdsTeacherFromDep.Count == 0) btnDel.Enabled = false;
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
            groupBox2.Enabled = true;
            bdsTeacherFromDep.MoveFirst();
            getDataTeacherFromDep(getMaKhoaSelected());

            btnNew.Enabled = btnEdit.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            txtTeacherID.Enabled = txtFirstName.Enabled = txtLastName.Enabled = txtDegree.Enabled = false;
            bdsTeacherFromDep.MoveFirst();
            getDataTeacherFromDep(getMaKhoaSelected());
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
                initButtonBarManage(false);
            }
            else
            {
                cbbDep.Enabled = false;
                cbbDep.Visible = false;
                cbbBranch.Enabled = true;
                btnNew.Enabled = btnEdit.Enabled = btnRefresh.Enabled = true;
                btnSave.Enabled = btnCancel.Enabled = false;

                if (bdsTeacherFromDep.Count == 0)
                {
                    btnDel.Enabled = btnEdit.Enabled = btnRefresh.Enabled = false;
                }
                else
                {
                    btnDel.Enabled = btnEdit.Enabled = btnRefresh.Enabled = true;
                }
            }
        }

        public void initUIComboBoxBranch()
        {
            String currentBranchName = cbbDep.SelectedValue.ToString();
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

        public void getDataTeacherFromDep(String branchID)
        {
            try
            {
                this.sp_DanhSachGiaoVienTheoKhoaTableAdapter.Fill(this.dataSetTracNghiem.sp_DanhSachGiaoVienTheoKhoa, branchID);
                this.sp_DanhSachGiaoVienTheoKhoaTableAdapter.ClearBeforeFill = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            setCurrentRole();
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
    }
}
