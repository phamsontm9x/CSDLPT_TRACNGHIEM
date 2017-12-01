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
        String method = "";

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
                    initUIComboBoxSubject();
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

            cbbSubject.Visible = cbbClass.Visible = false;
            txtClass.Enabled = txtSubject.Enabled = false;
            txtLevel.Enabled = pickerDate.Enabled = txtTime.Enabled = txtCountdown.Enabled = txtQuestNum.Enabled = txtTeacherID.Enabled = false;

            setCurrentRole();
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
            initUIComboBoxSubject();
        }

        public void initUIComboBoxClass()
        {
            String currentServerName = cbbDep.SelectedValue.ToString();
            int indexStr = currentServerName.IndexOf("\\") + 1;
            currentServerName = currentServerName.Substring(indexStr);
            Program.insertDepID = currentServerName == "MSSQLSERVER1" ? "CS1" : "CS2";

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

        public void initUIComboBoxSubject()
        {
            String currentServerName = cbbDep.SelectedValue.ToString();
            int indexStr = currentServerName.IndexOf("\\") + 1;
            currentServerName = currentServerName.Substring(indexStr);

            String strLenh = "exec sp_DanhSachMonHoc '" + currentServerName + "'";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    cbbSubject.DataSource = null;
                }
                else
                {
                    cbbSubject.DataSource = dt;
                    cbbSubject.DisplayMember = "TENMH";
                    cbbSubject.ValueMember = "MAMH";
                }
                cbbSubject.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Can not show list subject", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                //this.sp_DanhSachGVDKTheoCosoTableAdapter.ClearBeforeFill = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            setCurrentRole();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsRegistrationFromDep.Position;
            method = Program.NEW_METHOD;
            groupBox1.Enabled = true;
            bdsRegistrationFromDep.AddNew();
            txtLevel.Enabled = txtTime.Enabled = pickerDate.Enabled = txtCountdown.Enabled = txtQuestNum.Enabled = true;

            pickerDate.MinDate = DateTime.Now;
            pickerDate.Format = DateTimePickerFormat.Custom;
            //pickerDate.CustomFormat = " ";

            txtTeacherID.Enabled = false;
            txtTeacherID.Text = Program.currentID;
            cbbSubject.Enabled = cbbClass.Enabled = true;
            groupBox2.Enabled = false;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnRefresh.Enabled = btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = false;

            txtSubject.Visible = txtClass.Visible = false;
            cbbClass.Visible = cbbSubject.Visible = true;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsRegistrationFromDep.Position;
            method = Program.UPDATE_METHOD;
            groupBox1.Enabled = true;

            cbbSubject.Enabled = txtTeacherID.Enabled = cbbClass.Enabled = false;
            txtLevel.Enabled = pickerDate.Enabled = txtTime.Enabled = txtCountdown.Enabled = txtQuestNum.Enabled = true;
            txtSubject.Visible = txtClass.Visible = true;
            cbbClass.Visible = cbbSubject.Visible = false;
            pickerDate.MinDate = DateTime.Now;

            cbbDep.Enabled = false;
            groupBox2.Enabled = false;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnDel.Enabled = btnNew.Enabled = btnRefresh.Enabled = btnEdit.Enabled = false;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsRegistrationFromDep.Position;
            if (MessageBox.Show("Do you want to delete this registration?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bdsRegistrationFromDep.RemoveCurrent();
                    this.sp_DanhSachGVDKTheoCosoTableAdapter.Delete(txtSubject.Text, txtClass.Text, Int32.Parse(txtTime.Text));
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

                groupBox1.Enabled = true;
                cbbClass.Enabled = false;
                cbbSubject.Enabled = false;
                groupBox2.Enabled = true;
                txtLevel.Enabled = pickerDate.Enabled = txtTime.Enabled = txtCountdown.Enabled = txtQuestNum.Enabled = true;
                btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
                btnSave.Enabled = btnCancel.Enabled = false;
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String sqlStr = "";
            if (method == Program.NEW_METHOD)
            {
                Program.connect.Open();

                sqlStr = "sp_KiemTraGVDK";
                Program.cmd = Program.connect.CreateCommand();
                Program.cmd.CommandType = CommandType.StoredProcedure;
                Program.cmd.CommandText = sqlStr;

                Program.cmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = getClassIDSelected();
                Program.cmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = getSubjectIDSelected();
                Program.cmd.Parameters.Add("@LAN", SqlDbType.Int).Value = Int32.Parse(txtTime.Text.ToString());
                Program.cmd.Parameters.Add("@TRINHDO", SqlDbType.NChar).Value = txtLevel.Text.ToString();
                Program.cmd.Parameters.Add("@SOCAUTHI", SqlDbType.Int).Value = txtQuestNum.Text.ToString();
                Program.cmd.Parameters.Add("@ReturnValue", SqlDbType.VarChar).Direction = ParameterDirection.ReturnValue;
                Program.cmd.ExecuteNonQuery();
                Program.connect.Close();

                String result = Program.cmd.Parameters["@ReturnValue"].Value.ToString();

                if (result == "-1")
                {
                    MessageBox.Show("The registration for this class has already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.myReader.Close();
                    return;
                }
                else
                {
                    if (txtQuestNum.Text.Length == 0 || txtTime.Text.Length == 0 || txtLevel.Text.Length == 0 || txtCountdown.Text.Length == 0)
                    {
                        MessageBox.Show("Can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Program.myReader.Close();
                        return;
                    }
                    else if (result == "2")
                    {
                        if(MessageBox.Show("University have not enough exam code. \nUpdate new exam code?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Program.insertLevel = txtLevel.Text;
                            Program.insertSubjectID = getSubjectIDSelected();
                            Program.insertTeacherID = txtTeacherID.Text;
                            Program.insertClassID = txtClass.Text;

                            frmInsertQuestion frm = new frmInsertQuestion();
                            frm.ShowDialog();
                            Program.myReader.Close();
                        }
                        else
                            return;
                    }
                    else if (result == "3")
                    {
                        MessageBox.Show("This class have not tested yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Program.myReader.Close();
                        return;
                    }
                    else if (result == "0" || result == "1")
                    {
                        try
                        {
                            this.Validate();
                            bdsRegistrationFromDep.EndEdit();
                            bdsRegistrationFromDep.ResetCurrentItem();
                            this.sp_DanhSachGVDKTheoCosoTableAdapter.Insert(txtTeacherID.Text, getClassIDSelected(), getSubjectIDSelected(), txtLevel.Text, pickerDate.Value.Date, Int32.Parse(txtTime.Text), Int32.Parse(txtQuestNum.Text), Int32.Parse(txtCountdown.Text));
                            getDataClassFromDep();
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
            else if (method == Program.UPDATE_METHOD)
            {
                if (txtQuestNum.Text.Length == 0 || txtTime.Text.Length == 0 || txtCountdown.Text.Length == 0)
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
                        this.sp_DanhSachGVDKTheoCosoTableAdapter.Update(txtSubject.Text, txtClass.Text, Int32.Parse(txtTime.Text), txtLevel.Text, pickerDate.Value.Date, Int32.Parse(txtQuestNum.Text), Int32.Parse(txtCountdown.Text));
                        getDataClassFromDep();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update registration failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;
                    }
                }
                Program.myReader.Close();
            }

            groupBox1.Enabled = true;
            cbbClass.Enabled = false;
            cbbSubject.Enabled = false;
            groupBox2.Enabled = true;
            txtLevel.Enabled = pickerDate.Enabled = txtTime.Enabled = txtCountdown.Enabled = txtQuestNum.Enabled = false;
            btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
            txtSubject.Visible = txtClass.Visible = true;
            cbbClass.Visible = cbbSubject.Visible = false;
            btnSave.Enabled = btnCancel.Enabled = false;
        }
        
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            cbbSubject.Enabled = txtTeacherID.Enabled = cbbClass.Enabled = false;
            txtLevel.Enabled = pickerDate.Enabled = txtTime.Enabled = txtCountdown.Enabled = txtQuestNum.Enabled = false;

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
            getDataClassFromDep();
            bdsRegistrationFromDep.MoveFirst();
            txtSubject.Visible = txtClass.Visible = true;
            cbbClass.Visible = cbbSubject.Visible = false;

            btnNew.Enabled = btnEdit.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            txtTeacherID.Enabled = txtLevel.Enabled = txtTime.Enabled = pickerDate.Enabled = txtQuestNum.Enabled = txtCountdown.Enabled = false;
            groupBox2.Enabled = true;
            getDataClassFromDep();
            bdsRegistrationFromDep.MoveFirst();
            txtSubject.Visible = txtClass.Visible = true;
            cbbClass.Visible = cbbSubject.Visible = false;

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
                cbbClass.Visible = false;
                cbbSubject.Visible = false;
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

        private void pickerDate_ValueChanged(object sender, EventArgs e)
        {
            pickerDate.Format = DateTimePickerFormat.Short;
            pickerDate.CustomFormat = "yyyy-MM-dd";
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DateTime currentDate = DateTime.Now.Date;
            DateTime selectedDate = pickerDate.Value.Date;

            index = bdsRegistrationFromDep.Position;
            String currentTeacherID = ((DataRowView)bdsRegistrationFromDep[index])["MAGV"].ToString();
            if (Program.currentRole != "TRUONG")
            {
                if (currentTeacherID.Replace(" ", String.Empty) != Program.currentID)
                {
                    btnEdit.Enabled = false;
                    btnDel.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = true;
                    btnDel.Enabled = true;
                }
            }
        }

        private Boolean compareDates(DateTime currentDate, DateTime selectedDate)
        {
            int different = (int)((currentDate - selectedDate).TotalDays);

            if (different < 0)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Program.insertLevel = txtLevel.Text;
            Program.insertSubjectID = txtSubject.Text;
            Program.insertTeacherID = txtTeacherID.Text;
            Program.insertClassID = txtClass.Text;

            frmInsertQuestion frm = new frmInsertQuestion();
            frm.ShowDialog();
        }
    }
}
