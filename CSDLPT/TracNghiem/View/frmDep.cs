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
    public partial class frmDep : Form
    {
        int index = 0;
        String depID = "";
        String currentBranchID = "";
        String currentBranchName = "";
        String method = "";

        // Stack Undo
        public Stack stUndo = new Stack();
        public Stack stRedo = new Stack();
        public DepDto dtoUndo = new DepDto("","","");
        public bool isUndo = false;
        public bool isRedo = false;


        public class DepDto
        {
            public String strDepID;
            public String strDepName;
            public String method;
            public int index;
            public DepDto(String depID, String depName, String strMethod)
            {
                strDepID = depID;
                strDepName = depName;
                method = strMethod;
            }
        }

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
            updateUIUndo();
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
                cbbDep.Visible = false;
                btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
                btnSave.Enabled = btnCancel.Enabled = false;
            }
        }

        public void updateUIUndo()
        {
            if (stUndo.Count > 0)
            {
                btnUndo.Enabled = true;
            } else
            {
                btnUndo.Enabled = false;
            }

            if (stRedo.Count > 0)
            {
                btnRedo.Enabled = true;
            }
            else
            {
                btnRedo.Enabled = false;
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
            bdsDep.AddNew();
            groupBox1.Enabled = true;
            txtDepID.Enabled = txtDepName.Enabled = true;
            cbbDep.Enabled = false;
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
            // 
            currentBranchName = ((DataRowView)bdsDep[index])["TENKH"].ToString();
            currentBranchID = ((DataRowView)bdsDep[index])["MAKH"].ToString();

            dtoUndo.strDepID = currentBranchID;
            dtoUndo.strDepName = currentBranchName;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnDel.Enabled = btnNew.Enabled = btnRefresh.Enabled = btnEdit.Enabled = false;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsDep.Position;
            method = Program.DETELE_METHOD;
            currentBranchName = ((DataRowView)bdsDep[index])["TENKH"].ToString();
            currentBranchID = ((DataRowView)bdsDep[index])["MAKH"].ToString();
            sqlDeleteMethod(currentBranchID, currentBranchName, method);
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (method == Program.NEW_METHOD)
            {
                sqlNewMethod(txtDepID.Text,txtDepName.Text, method);
            }
            else if (method == Program.UPDATE_METHOD)
            {
                sqlUpdateMethod(txtDepID.Text, txtDepName.Text, method);
            }

            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        public void sqlNewMethod(String strDepID, String strDepName, String method)
        {
            String sqlStr = "exec sp_KiemTraKhoa '" + strDepID + "', '" + method + "'";
   
            Program.myReader = Program.ExecSqlDataReader(sqlStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            if (Program.myReader.FieldCount > 0)
            {
                MessageBox.Show("The " + strDepID + " has already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.myReader.Close();
                return;
            }
            else
            {
                if (strDepID.Length == 0 || strDepName.Length == 0)
                {
                    MessageBox.Show("Department ID or Department Name can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Program.myReader.Close();
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
                        if (isUndo == false)
                        {
                            DepDto dataUndo = new DepDto(strDepID, strDepName, method);
                            stUndo.Push(dataUndo);
                            updateUIUndo();
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Create department failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;
                    }
                }
            }
            Program.myReader.Close();
        }

        public void sqlUpdateMethod(String strDepID, String strDepName, String method)
        {
            String sqlStr = "exec sp_KiemTraKhoa '" + txtDepID.Text + "', '" + method + "'";

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
                    try
                    {
                        this.Validate();
                        bdsDep.EndEdit();
                        bdsDep.ResetCurrentItem();
                        this.kHOATableAdapter.Update(this.dataSetTracNghiem.KHOA);
                        if (isUndo == false)
                        {
                            DepDto dataUndo = new DepDto(dtoUndo.strDepID, dtoUndo.strDepName, method);
                            stUndo.Push(dataUndo);
                            updateUIUndo();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update subjects failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;
                    }
                }
            }
            Program.myReader.Close();
        }

        public void sqlDeleteMethod(String strDepID, String strDepName, String method )
        {
            String sqlStr = "exec sp_KiemTraKhoa '" + strDepID + "', '" + method + "'";

            Program.myReader = Program.ExecSqlDataReader(sqlStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            if (Program.myReader.FieldCount > 0)
            {
                MessageBox.Show("Can not delete " + strDepName + " branch. \nThe branch has data available! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Program.myReader.Close();
            }
            else
            {
                if (MessageBox.Show("Do you want to delete " + strDepName + " branch?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bdsDep.RemoveCurrent();
                        this.kHOATableAdapter.Update(this.dataSetTracNghiem.KHOA);
                        if (isUndo == false)
                        {
                            DepDto dataUndo = new DepDto(strDepID, strDepName, method);
                            stUndo.Push(dataUndo);
                            updateUIUndo();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failure. Please delete again!\n" + ex.Message, "",
                            MessageBoxButtons.OK);
                        Program.myReader.Close();
                        this.kHOATableAdapter.Fill(this.dataSetTracNghiem.KHOA);
                        bdsDep.Position = bdsDep.Find("MAKH", strDepID);
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
            stUndo.Clear();
            stRedo.Clear();
            updateUIUndo();
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
            btnNew.Enabled = btnEdit.Enabled = btnSave.Enabled = btnRefresh.Enabled = btnDel.Enabled = btnCancel.Enabled = btnUndo.Enabled = btnRedo.Enabled = isEnable;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isUndo = true;
            DepDto dataUndo = (DepDto)stUndo.Pop();
            if (dataUndo.method == Program.NEW_METHOD)
            {
                stRedo.Push(dataUndo);
                int index = getIndexDBS(dataUndo.strDepID);
                if (index >= 0)
                {
                    bdsDep.Position = index;
                    sqlDeleteMethod(dataUndo.strDepID, dataUndo.strDepName, Program.DETELE_METHOD);
                }
            } else if (dataUndo.method == Program.UPDATE_METHOD)
            {
                int index = getIndexDBS(dataUndo.strDepID);
                if (index >= 0)
                {
                    DepDto dataRedo = new DepDto(txtDepID.Text, txtDepName.Text, method);
                    stRedo.Push(dataRedo);
                    bdsDep.Position = index;
                    txtDepName.Text = dataUndo.strDepName;
                    txtDepID.Text = dataUndo.strDepID;
                    sqlUpdateMethod(dataUndo.strDepID, dataUndo.strDepName, method);
                }

            } else if (dataUndo.method == Program.DETELE_METHOD)
            {
                stRedo.Push(dataUndo);
                bdsDep.AddNew();
                txtBranchID.Text = depID;
                txtDepName.Text = dataUndo.strDepName;
                txtDepID.Text = dataUndo.strDepID;
                sqlNewMethod(dataUndo.strDepID, dataUndo.strDepName, Program.NEW_METHOD);
            }
            isUndo = false;
            updateUIUndo();
        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isRedo = isUndo = true;
            DepDto dataRedo = (DepDto)stRedo.Pop();
            if (dataRedo.method == Program.NEW_METHOD)
            {
                stUndo.Push(dataRedo);
                bdsDep.AddNew();
                txtBranchID.Text = depID;
                txtDepName.Text = dataRedo.strDepName;
                txtDepID.Text = dataRedo.strDepID;
                sqlNewMethod(dataRedo.strDepID, dataRedo.strDepName, Program.NEW_METHOD);
            }
            else if (dataRedo.method == Program.UPDATE_METHOD)
            {
                int index = getIndexDBS(dataRedo.strDepID);
                if (index >= 0)
                {
                    DepDto dataUndo = new DepDto(txtDepID.Text, txtDepName.Text, method);
                    stUndo.Push(dataUndo);
                    bdsDep.Position = index;
                    txtDepName.Text = dataRedo.strDepName;
                    txtDepID.Text = dataRedo.strDepID;
                    sqlUpdateMethod(dataRedo.strDepID, dataRedo.strDepName, method);
                }

            }
            else if (dataRedo.method == Program.DETELE_METHOD)
            {
                stUndo.Push(dataRedo);
                int index = getIndexDBS(dataRedo.strDepID);
                if (index >= 0)
                {
                    bdsDep.Position = index;
                    sqlDeleteMethod(dataRedo.strDepID, dataRedo.strDepName, Program.DETELE_METHOD);
                }
            }
            isRedo = isUndo = false;
            updateUIUndo();
        }

        public int getIndexDBS(string strDepID)
        {
            for (int i = 0; i < bdsDep.Count; i++)
            {
                if (strDepID.Trim() == ((DataRowView)bdsDep[i])["MAKH"].ToString().Trim())
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
