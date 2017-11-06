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
        public frmSubjects()
        {
            InitializeComponent();
        }

        private void frmSubjects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTracNghiem.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dataSetTracNghiem.MONHOC);
            groupBox1.Enabled = false;
            btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
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
                if (txtSubID.Text.Length > 5)
                {
                    MessageBox.Show("Subjects ID can not exceed 5 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSubID.Focus();
                    return;
                }
                else if (txtSubName.Text.Length > 40)
                {
                    MessageBox.Show("Subject Name can not exceed 40 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            btnNew.Enabled = btnEdit.Enabled = btnDel.Enabled = btnRefresh.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
    }
}
