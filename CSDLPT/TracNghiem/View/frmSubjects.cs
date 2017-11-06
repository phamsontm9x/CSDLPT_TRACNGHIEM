using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracNghiem.View
{
    public partial class frmSubjects : Form
    {
        public frmSubjects()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSubjects.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTracNghiem);

        }

        private void frmSubjects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTracNghiem.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dataSetTracNghiem.MONHOC);

        }
    }
}
