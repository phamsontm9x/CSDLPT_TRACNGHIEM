using System;
using System.Collections;
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

        public Stack st = new Stack();
        public ClassDto dtoUndo = new ClassDto("", "", "");
        public bool isUndo = false;

        public class ClassDto
        {
            public String strID;
            public String strName;
            public String method;
            public int index;
            public ClassDto(String classID, String className, String strMethod)
            {
                strID = classID;
                strName = className;
                method = strMethod;
            }
        }

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

        private void frmClass_Load(object sender, EventArgs e)
        {
            dataSetTracNghiem.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connectStr;
            // TODO: This line of code loads data into the 'dataSetTracNghiem.LOP' table. You can move, or remove it, as needed.

            initUIComboBoxDep();
            setCurrentRole();
            updateUI();
            groupBox1.Enabled = true;
            txtClassName.Enabled = txtClassId.Enabled = false;

            
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

                if (cbbBranch.SelectedIndex < 0)
                {
                    st.Clear();
                    btnNew.Enabled = btnEdit.Enabled = btnRefresh.Enabled = btnUndo.Enabled = btnDel.Enabled = false;
                }
            }
        }

        public void updateUI ()
        {
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
                this.sp_DanhSachLopTheoKhoaVaCoSoTableAdapter.Fill(this.dataSetTracNghiem.sp_DanhSachLopTheoKhoaVaCoSo, branchID, currentServerName);
                this.sp_DanhSachLopTheoKhoaVaCoSoTableAdapter.ClearBeforeFill = true;
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
            st.Clear();
            updateUIUndo();
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
            sqlDeleteMethod(currentClassID, currentClassName, method);
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsClassFromDep.Count != 1)
            {
                currentClassID = ((DataRowView)bdsClassFromDep[index])["MALOP"].ToString();
                currentClassName = ((DataRowView)bdsClassFromDep[index])["TENLOP"].ToString();
            }

            if (method == Program.NEW_METHOD)
            {
                sqlNewMethod(txtClassId.Text, txtClassName.Text, method);
            }
            else if (method == Program.UPDATE_METHOD)
            {
                sqlUpdateMethod(txtClassId.Text, txtClassName.Text, method);
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

            currentClassName = ((DataRowView)bdsClassFromDep[index])["TENLOP"].ToString();
            currentClassID = ((DataRowView)bdsClassFromDep[index])["MALOP"].ToString();

            dtoUndo.strID = currentClassID;
            dtoUndo.strName = currentClassName;

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


        public void sqlNewMethod(String strID, String strName, String method)
        {
            String sqlStr = "exec sp_KiemTraLopTheoKhoa '" + strID + "', '" + method + "'";

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
                if (strID.Length == 0 || strName.Length == 0)
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
                        this.sp_DanhSachLopTheoKhoaVaCoSoTableAdapter.Insert(strID, strName, getMaKhoaSelected());
                        if (isUndo == false)
                        {
                            ClassDto dataUndo = new ClassDto(strID, strName, method);
                            st.Push(dataUndo);
                            updateUIUndo();
                        }
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

        public void sqlUpdateMethod(String strID, String strName, String method)
        {
            String sqlStr = "exec sp_KiemTraLopTheoKhoa '" + strID + "', '" + method + "'";

            Program.myReader = Program.ExecSqlDataReader(sqlStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            currentClassName = ((DataRowView)bdsClassFromDep[index])["TENLOP"].ToString();
            if (strName == currentClassName)
            {
                MessageBox.Show("You must type different name!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.myReader.Close();
                return;
            }
            else
            {
                if (strName.Length == 0)
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
                        this.sp_DanhSachLopTheoKhoaVaCoSoTableAdapter.Update(strID, strName);
                        if (isUndo == false)
                        {
                            ClassDto dataUndo = new ClassDto(dtoUndo.strID, dtoUndo.strName, method);
                            st.Push(dataUndo);
                            updateUIUndo();
                        }
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

        public void sqlDeleteMethod(String strID, String strName, String method)
        {
            String sqlStr = "";
            sqlStr = "exec sp_KiemTraLopTheoKhoa'" + strID + "', '" + method + "'";
            Program.myReader = Program.ExecSqlDataReader(sqlStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            if (Program.myReader.FieldCount > 0)
            {
                MessageBox.Show("Can not delete " + strName + " class. \nThe class has data available! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (MessageBox.Show("Do you want to delete " + strName + " class?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bdsClassFromDep.RemoveCurrent();
                        this.sp_DanhSachLopTheoKhoaVaCoSoTableAdapter.Delete(strID);
                        if (bdsClassFromDep.Count == 0)
                        {
                            btnDel.Enabled = false;
                            btnEdit.Enabled = false;
                            btnRefresh.Enabled = false;
                        }
                        if (isUndo == false)
                        {
                            ClassDto dataUndo = new ClassDto(strID, strName, method);
                            st.Push(dataUndo);
                            updateUIUndo();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failure. Please delete again!\n" + ex.Message, "",
                           MessageBoxButtons.OK);
                        getDataClassFromDep(getMaKhoaSelected());
                        bdsClassFromDep.Position = bdsClassFromDep.Find("MALOP", strID);
                        return;
                    }
                }
            }
            Program.myReader.Close();
        }

        public void initButtonBarManage(Boolean isEnable)
        {
            btnNew.Enabled = btnEdit.Enabled = btnSave.Enabled = btnRefresh.Enabled = btnDel.Enabled = btnCancel.Enabled = btnUndo.Enabled = isEnable;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            bdsClassFromDep.Filter = "MALOP LIKE '%" + this.txtSearch.Text + "%'" + " OR TENLOP LIKE '%" + this.txtSearch.Text + "%'";
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxSearch.Checked == true)
            {
                txtSearch.Text = "";
                getDataClassFromDep("");
                cbbBranch.SelectedIndex = -1;
                cbbBranch.Enabled = false;
            }
            else
            {
                txtSearch.Text = "";
                cbbBranch.Enabled = true;
            }
            updateUI();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isUndo = true;
            ClassDto dataUndo = (ClassDto)st.Pop();
            if (dataUndo.method == Program.NEW_METHOD)
            {
                int index = getIndexDBS(dataUndo.strID);
                if (index >= 0)
                {
                    bdsClassFromDep.Position = index;
                    sqlDeleteMethod(dataUndo.strID, dataUndo.strName, Program.DETELE_METHOD);
                }
            }
            else if (dataUndo.method == Program.UPDATE_METHOD)
            {
                int index = getIndexDBS(dataUndo.strID);
                if (index >= 0)
                {
                    bdsClassFromDep.Position = index;
                    txtClassName.Text = dataUndo.strName;
                    txtClassId.Text = dataUndo.strID;
                    sqlUpdateMethod(dataUndo.strID, dataUndo.strName, method);
                }

            }
            else if (dataUndo.method == Program.DETELE_METHOD)
            {
                bdsClassFromDep.AddNew();
                txtClassName.Text = dataUndo.strName;
                txtClassId.Text = dataUndo.strID;
                sqlNewMethod(dataUndo.strID, dataUndo.strName, Program.NEW_METHOD);
            }
            isUndo = false;
            updateUIUndo();
        }

        public int getIndexDBS(string strID)
        {
            for (int i = 0; i < bdsClassFromDep.Count; i++)
            {
                if (strID.Trim() == ((DataRowView)bdsClassFromDep[i])["MALOP"].ToString().Trim())
                {
                    return i;
                }
            }
            return -1;
        }
        public void updateUIUndo()
        {
            if (st.Count > 0)
            {
                btnUndo.Enabled = true;
            }
            else
            {
                btnUndo.Enabled = false;
            }
        }
    }
}
