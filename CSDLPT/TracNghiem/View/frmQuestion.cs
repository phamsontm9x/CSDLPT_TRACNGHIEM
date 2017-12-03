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
    public partial class frmQuestion : Form
    {
        int index;
        String method = "";
        String filterSubject = "FALSE";
        String filterTeacher = "FALSE";
        String currentDepID = "";
        String subjectID = "";
        String teacherID = "";
        int currentQuestID;

        public frmQuestion()
        {
            InitializeComponent();
        }

        private void frmQuestion_Load(object sender, EventArgs e)
        {
            dataSetTracNghiem.EnforceConstraints = false;
            this.sp_DanhSachBoDeTableAdapter.Connection.ConnectionString = Program.connectStr;
            // TODO: This line of code loads data into the 'dataSetTracNghiem.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dataSetTracNghiem.MONHOC);
            // TODO: This line of code loads data into the 'dataSetTracNghiem.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Fill(this.dataSetTracNghiem.BODE);

            initUIComboBoxDep();
            cbSubject.Checked = cbTeacher.Checked = false;
            cbbTeacher.Enabled = cbbSubject.Enabled = false;

            groupBox1.Enabled = true;
            txtQuestID.Enabled = txtTeacherID.Enabled = txtSubID.Enabled = txtDepID.Enabled = false;
            txtLevel.Enabled = txtContent.Enabled = txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = txtAnswer.Enabled = false;

            setCurrentRole();

        }

        private void cbSubject_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSubject.Checked == true)
            {
                filterSubject = "TRUE";
                cbbSubject.Enabled = true;
                subjectID = "";
            }
            else
            {
                filterSubject = "FALSE";
                cbbSubject.Enabled = false;
                subjectID = getSubjectIDSelected();
            }
        }

        private void cbTeacher_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTeacher.Checked == true)
            {
                filterTeacher = "TRUE";
                cbbTeacher.Enabled = true;
                teacherID = "";
            }
            else
            {
                filterTeacher = "FALSE";
                cbbTeacher.Enabled = false;
                teacherID = getTeacherIDSelected();
            }
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
                    initUIComboBoxTeacher();
                }
            }
        }
        public void initUIComboBoxDep()
        {
            cbbDep.DataSource = Program.bds;
            cbbDep.DisplayMember = "MACS";
            cbbDep.ValueMember = "TENCS";
            cbbDep.SelectedIndex = Program.currentBranch;

            currentDepID = "CS" + (cbbDep.SelectedIndex + 1) + "";

            initUIComboBoxTeacher();
            cbbSubject.SelectedIndex = -1;
        }
        public void initUIComboBoxTeacher()
        {
            String currentBranchName = cbbDep.SelectedValue.ToString();
            int indexStr = currentBranchName.IndexOf("\\") + 1;
            currentBranchName = currentBranchName.Substring(indexStr);

            String strLenh = "exec sp_DanhSachGiaoVienTheoKhoaVaCoSo NULL, '" + currentBranchName + "'";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    cbbTeacher.SelectedIndex = -1;
                    cbbTeacher.DataSource = null;
                }
                else
                {
                    cbbTeacher.DataSource = dt;
                    cbbTeacher.DisplayMember = "MAGV";
                    cbbTeacher.ValueMember = "MAGV";
                }
                cbbTeacher.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Can not show list teacher", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            this.sp_DanhSachBoDeTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.sp_DanhSachBoDeTableAdapter.Fill(this.dataSetTracNghiem.sp_DanhSachBoDe, subjectID, teacherID, currentDepID, filterSubject, filterTeacher);
            setCurrentRole();
        }

        public String getSubjectIDSelected()
        {
            subjectID = cbbSubject.SelectedValue.ToString();
            return subjectID;
        }
        public String getTeacherIDSelected()
        {
            teacherID = cbbTeacher.SelectedValue.ToString();
            return teacherID;
        }

        private void cbbSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getSubjectIDSelected();
        }

        private void cbbTeacher_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getTeacherIDSelected();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsListExamCode.Position;
            groupBox1.Enabled = true;
            bdsListExamCode.AddNew();
            txtQuestID.Enabled = txtSubID.Enabled = true;
            txtLevel.Enabled = txtContent.Enabled = txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = txtAnswer.Enabled = true;
            cbbDep.Enabled = false;
            cbbSubject.Enabled = false;
            cbbTeacher.Enabled = false;
            groupBox2.Enabled = false;
            txtQuestID.Focus();
            method = Program.NEW_METHOD;

            txtDepID.Text = currentDepID;
            txtTeacherID.Text = Program.currentID;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnRefresh.Enabled = btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsListExamCode.Position;
            groupBox1.Enabled = true;
            txtQuestID.Enabled = false;
            txtQuestID.Enabled = txtTeacherID.Enabled = txtSubID.Enabled = txtDepID.Enabled = false;
            txtLevel.Enabled = txtContent.Enabled = txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = txtAnswer.Enabled = true;
            cbbDep.Enabled = false;
            cbbSubject.Enabled = false;
            cbbTeacher.Enabled = false;
            groupBox2.Enabled = false;
            method = Program.UPDATE_METHOD;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnDel.Enabled = btnNew.Enabled = btnRefresh.Enabled = btnEdit.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsListExamCode.Count != 1)
            {
                currentQuestID = Int32.Parse(((DataRowView)bdsListExamCode[index])["CAUHOI"].ToString());
            }
            String sqlStr = "";

            if (method == Program.NEW_METHOD)
            {
                sqlStr = "exec sp_KiemTraBoDe '" + txtQuestID.Text + "', '" + method + "', '" + txtSubID.Text + "', '" + txtLevel.Text + "', '" + txtContent.Text + "'";

                Program.myReader = Program.ExecSqlDataReader(sqlStr);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                if (Program.myReader.FieldCount > 0)
                {
                    MessageBox.Show("The " + txtQuestID.Text + " has already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.myReader.Close();
                    return;
                }
                else
                {
                    if (txtQuestID.Text.Length == 0 || txtLevel.Text.Length == 0 || txtSubID.Text.Length == 0 || txtTeacherID.Text.Length == 0)
                    {
                        MessageBox.Show("Can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtA.Text == txtB.Text || txtA.Text == txtC.Text || txtA.Text == txtD.Text ||
                        txtB.Text == txtC.Text || txtB.Text == txtD.Text || txtC.Text == txtD.Text)
                    {
                        MessageBox.Show("Answer cannot same as same other answer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        try
                        {
                            this.Validate();
                            bdsListExamCode.EndEdit();
                            bdsListExamCode.ResetCurrentItem();
                            this.sp_DanhSachBoDeTableAdapter.Insert(Int32.Parse(txtQuestID.Text), txtSubID.Text, txtLevel.Text, txtContent.Text, txtA.Text, txtB.Text, txtC.Text, txtD.Text, txtAnswer.Text, txtTeacherID.Text, txtDepID.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Create exam failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                            Program.myReader.Close();
                            return;
                        }
                    }
                    Program.myReader.Close();
                }
            }
            else if (method == Program.UPDATE_METHOD)
            {
                if (txtLevel.Text.Length == 0)
                {
                    MessageBox.Show("Level can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtA.Text == txtB.Text || txtA.Text == txtC.Text || txtA.Text == txtD.Text ||
                        txtB.Text == txtC.Text || txtB.Text == txtD.Text || txtC.Text == txtD.Text)
                {
                    MessageBox.Show("Answer cannot same as same other answer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtAnswer.Text.Length == 0)
                {
                    MessageBox.Show("Answer can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        this.Validate();
                        bdsListExamCode.EndEdit();
                        bdsListExamCode.ResetCurrentItem();
                        this.sp_DanhSachBoDeTableAdapter.Update(Int32.Parse(txtQuestID.Text), txtLevel.Text, txtContent.Text, txtA.Text, txtB.Text, txtC.Text, txtD.Text, txtAnswer.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update exam failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                        Program.myReader.Close();
                        return;
                    }
                }
                Program.myReader.Close();
            }
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            txtQuestID.Enabled = txtTeacherID.Enabled = txtSubID.Enabled = txtDepID.Enabled = false;
            txtLevel.Enabled = txtContent.Enabled = txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = txtAnswer.Enabled = false;
            btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.connect.Close();
            index = bdsListExamCode.Position;
            method = Program.DETELE_METHOD;
            currentQuestID = Int32.Parse(((DataRowView)bdsListExamCode[index])["CAUHOI"].ToString());

            Program.connect.Open();

            String sqlStr = "";
            sqlStr = "sp_KiemTraBoDe";
            Program.cmd = Program.connect.CreateCommand();
            Program.cmd.CommandType = CommandType.StoredProcedure;
            Program.cmd.CommandText = sqlStr;

            Program.cmd.Parameters.Add("@CAUHOI", SqlDbType.Int).Value = txtQuestID.Text;
            Program.cmd.Parameters.Add("@METHOD", SqlDbType.NChar).Value = method;
            Program.cmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = txtSubID.Text;
            Program.cmd.Parameters.Add("@TRINHDO", SqlDbType.NChar).Value = txtLevel.Text;
            Program.cmd.Parameters.Add("@NOIDUNG", SqlDbType.NVarChar).Value = txtContent.Text;
            Program.cmd.Parameters.Add("@ReturnValue", SqlDbType.VarChar).Direction = ParameterDirection.ReturnValue;
            Program.cmd.ExecuteNonQuery();
            Program.connect.Close();


            String result = Program.cmd.Parameters["@ReturnValue"].Value.ToString();

            if (result == "0" || result == "1")
            {
                MessageBox.Show("Can not delete this question. \nThe question has data available! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Program.myReader.Close();
            }
            else
            {
                if (MessageBox.Show("Do you want to delete this question?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bdsListExamCode.RemoveCurrent();
                        this.sp_DanhSachBoDeTableAdapter.Delete(currentQuestID);
                        if (bdsListExamCode.Count == 0)
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
                        bdsListExamCode.Position = bdsListExamCode.Find("CAUHOI", currentQuestID);
                        return;
                    }
                }
            }
            Program.myReader.Close();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            txtQuestID.Enabled = txtTeacherID.Enabled = txtSubID.Enabled = txtDepID.Enabled = false;
            txtLevel.Enabled = txtContent.Enabled = txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = txtAnswer.Enabled = false;

            if (bdsListExamCode.Count == 0) btnDel.Enabled = false;
            else btnDel.Enabled = true;

            if (Program.currentRole == "TRUONG")
            {
                cbbDep.Enabled = true;
            }
            else
            {
                cbbDep.Enabled = false;
            }
            groupBox2.Enabled = true;
            bdsListExamCode.MoveFirst();

            btnNew.Enabled = btnEdit.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            txtQuestID.Enabled = txtTeacherID.Enabled = txtSubID.Enabled = txtDepID.Enabled = false;
            txtLevel.Enabled = txtContent.Enabled = txtA.Enabled = txtB.Enabled = txtC.Enabled = txtD.Enabled = txtAnswer.Enabled = false;
            bdsListExamCode.ResetCurrentItem();
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
                initButtonBarManage(false);
            }
            else
            {
                cbbDep.Enabled = false;
                btnNew.Enabled = btnEdit.Enabled = btnRefresh.Enabled = true;
                btnSave.Enabled = btnCancel.Enabled = false;

                if (bdsListExamCode.Count == 0)
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

        private void txtQuestID_KeyboardPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLevel_KeyboardPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAnswer_KeyboardPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            index = bdsListExamCode.Position;
            String currentTeacherID = ((DataRowView)bdsListExamCode[index])["MAGV"].ToString();
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
}