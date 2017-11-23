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

        int index;
        String subjectID = "";
        String classID = "";

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
            this.mONHOCTableAdapter.Fill(this.dataSetTracNghiem.MONHOC);
            this.sp_DanhSachGVDKTheoCosoTableAdapter.Connection.ConnectionString = Program.connectStr;
            // TODO: This line of code loads data into the 'dataSetTracNghiem.MONHOC' table. You can move, or remove it, as needed.

            initUIComboBoxDep();
            
            cbbSubject.Enabled = txtTeacherID.Enabled = cbbClass.Enabled = false;
            //txtLevel.Enabled = txtDate.Enabled = txtTime.Enabled = txtCountdown.Enabled = false;
        }

        public String getSubjectIDSelected()
        {
            subjectID = cbbSubject.SelectedValue.ToString();
            return subjectID;
        }
        public String getClassIDSelected()
        {
            classID = cbbClass.SelectedValue.ToString();
            return classID;
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

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsRegistrationFromDep.Position;
            groupBox1.Enabled = true;
            bdsRegistrationFromDep.AddNew();
            txtLevel.Enabled = txtTime.Enabled = txtCountdown.Enabled = true;

            txtTeacherID.Enabled = false;
            txtTeacherID.Text = Program.currentID;
            cbbSubject.Enabled = cbbClass.Enabled = true;
            groupBox2.Enabled = false;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnRefresh.Enabled = btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsRegistrationFromDep.Position;
            groupBox1.Enabled = true;
            
            cbbSubject.Enabled = txtTeacherID.Enabled = cbbClass.Enabled = false;
            //txtLevel.Enabled = txtDate.Enabled = txtTime.Enabled = txtCountdown.Enabled = true;
            cbbDep.Enabled = false;
            groupBox2.Enabled = false;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnDel.Enabled = btnNew.Enabled = btnRefresh.Enabled = btnEdit.Enabled = false;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsRegistrationFromDep.Position;
            try
            {
                bdsRegistrationFromDep.RemoveCurrent();
                this.sp_DanhSachGVDKTheoCosoTableAdapter.Delete(getSubjectIDSelected(), getClassIDSelected(), Int32.Parse(txtTime.Text));
                if (bdsRegistrationFromDep.Count == 0)
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
                return;
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String sqlStr = "";

            sqlStr = "exec sp_KiemTraGVDK '" + getClassIDSelected() + "', '" + getSubjectIDSelected() + "', '" + txtTime.Text + "'";

            Program.myReader = Program.ExecSqlDataReader(sqlStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            if (Program.myReader.FieldCount > 0)
            {
                MessageBox.Show("The registration for this class has already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.myReader.Close();
                return;
            }
            else
            {
                if (txtQuestNum.Text.Length == 0 || txtLevel.Text.Length == 0 || txtLevel.Text.Length == 0 || txtTeacherID.Text.Length == 0)
                {
                    MessageBox.Show("Can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        this.Validate();
                        bdsRegistrationFromDep.EndEdit();
                        bdsRegistrationFromDep.ResetCurrentItem();
                        this.sp_DanhSachGVDKTheoCosoTableAdapter.Insert(txtTeacherID.Text, getClassIDSelected(), getSubjectIDSelected(), txtLevel.Text, pickerDate.Value.Date, Int32.Parse(txtTime.Text), Int32.Parse(txtQuestNum.Text), Int32.Parse(txtCountdown.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Create registration failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;
                    }
                }
                Program.myReader.Close();
            }

        }
        
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            cbbSubject.Enabled = txtTeacherID.Enabled = cbbClass.Enabled = false;
            //txtLevel.Enabled = txtDate.Enabled = txtTime.Enabled = txtCountdown.Enabled = false;

            if (bdsRegistrationFromDep.Count == 0) btnDel.Enabled = false;
            else btnDel.Enabled = true;

            if (Program.currentRole == "TRUONG")
            {
                cbbDep.Enabled = true;
                cbbClass.Enabled = cbbSubject.Enabled = false;
            }
            else
            {
                cbbDep.Enabled = false;
                cbbClass.Enabled = cbbSubject.Enabled = true;
            }
            groupBox2.Enabled = true;
            bdsRegistrationFromDep.MoveFirst();

            btnNew.Enabled = btnEdit.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            txtTeacherID.Enabled = txtLevel.Enabled = txtTime.Enabled = txtCountdown.Enabled = false;
            groupBox2.Enabled = true;
            bdsRegistrationFromDep.MoveFirst();

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
                cbbClass.Visible = false;
                cbbSubject.Visible = false;
                initButtonBarManage(false);
            }
            else
            {
                cbbDep.Visible = false;
                cbbClass.Visible = true;
                cbbSubject.Visible = true;
                btnNew.Enabled = btnEdit.Enabled = btnRefresh.Enabled = true;
                btnSave.Enabled = btnCancel.Enabled = false;

                if (bdsRegistrationFromDep.Count == 0)
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
    }
}
