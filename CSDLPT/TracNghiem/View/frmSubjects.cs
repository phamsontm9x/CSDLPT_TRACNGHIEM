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
    public partial class frmSubjects : Form
    {
        int index;
        String currentSubName = "";
        String currentSubID = "";
        public frmSubjects()
        {
            InitializeComponent();
        }

        private void frmSubjects_Load(object sender, EventArgs e)
        {
            dataSetTracNghiem.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dataSetTracNghiem.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dataSetTracNghiem.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'dataSetTracNghiem.BAITHI' table. You can move, or remove it, as needed.
            this.bAITHITableAdapter.Fill(this.dataSetTracNghiem.BAITHI);
            // TODO: This line of code loads data into the 'dataSetTracNghiem.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Fill(this.dataSetTracNghiem.BANGDIEM);
            // TODO: This line of code loads data into the 'dataSetTracNghiem.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Fill(this.dataSetTracNghiem.BODE);
            // TODO: This line of code loads data into the 'dataSetTracNghiem.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dataSetTracNghiem.MONHOC);
            groupBox1.Enabled = false;

            setCurrentRole();
        }

        public void setCurrentRole()
        {
            if (Program.currentRole == "TRUONG")
            {
                initButtonBarManage(false);
            }
            else
            {
                btnNew.Enabled = btnEdit.Enabled = btnRefresh.Enabled = true;
                btnSave.Enabled = btnCancel.Enabled = false;

                if (bdsSubjects.Count == 0)
                {
                    btnDel.Enabled = btnEdit.Enabled = btnRefresh.Enabled = false;
                }
                else
                {
                    btnDel.Enabled = btnEdit.Enabled = btnRefresh.Enabled = true;
                }
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsSubjects.Position;
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;

            btnCancel.Enabled = btnSave.Enabled = true;
            btnDel.Enabled = btnNew.Enabled = btnRefresh.Enabled = btnEdit.Enabled = false;
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsSubjects.Position;
            groupBox1.Enabled = true;
            bdsSubjects.AddNew();
            groupBox2.Enabled = false;
            txtSubID.Focus();

            btnCancel.Enabled = btnSave.Enabled = true;
            btnRefresh.Enabled = btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtSubID.Text.Length == 0 || txtSubName.Text.Length == 0)
            {
                MessageBox.Show("Subjects ID or Subject Name can not empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    this.Validate();
                    bdsSubjects.EndEdit();
                    bdsSubjects.ResetCurrentItem();
                    this.mONHOCTableAdapter.Update(this.dataSetTracNghiem.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update subjects failed! \n" + ex.Message, "Error", MessageBoxButtons.OK);
                    return;
                }
            }

            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            index = bdsSubjects.Position;
            bdsSubjects.CancelEdit();

            btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            bdsSubjects.MoveFirst();
            this.mONHOCTableAdapter.Fill(this.dataSetTracNghiem.MONHOC);

            btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = bdsSubjects.Position;
            currentSubName = ((DataRowView)bdsSubjects[index])["TENMH"].ToString();
            currentSubID = ((DataRowView)bdsSubjects[index])["MAMH"].ToString();
            if (bdsExam.Count > 0 || bdsRegistration.Count > 0 || bdsTest.Count > 0 || bdsTranscript.Count > 0)
            {
                MessageBox.Show("Can not delete " + currentSubName + " subject. \nThe subject has data available! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (MessageBox.Show("Do you want to delete " + currentSubName + " subject?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bdsSubjects.RemoveCurrent();
                    this.mONHOCTableAdapter.Update(this.dataSetTracNghiem.MONHOC);
                    if (bdsSubjects.Count == 0)
                    {
                        btnCancel.Enabled = btnDel.Enabled = btnEdit.Enabled = btnRefresh.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failure. Please delete again!\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.dataSetTracNghiem.MONHOC);
                    bdsSubjects.Position = bdsSubjects.Find("MAMH", currentSubID);
                    return;
                }
            }
            if (bdsSubjects.Count == 0) btnDel.Enabled = false;
        }
        public void initButtonBarManage(Boolean isEnable)
        {
            btnNew.Enabled = btnEdit.Enabled = btnSave.Enabled = btnRefresh.Enabled = btnDel.Enabled = btnCancel.Enabled = isEnable;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            bdsSubjects.Filter = "MAMH LIKE '%" + this.txtSearch.Text + "%'" + " OR TENMH LIKE '%" + this.txtSearch.Text + "%'";
        }
    }
}
