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
    public partial class frmDep : Form
    {
        public frmDep()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTracNghiem);

        }

        private void frmDep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTracNghiem.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.dataSetTracNghiem.KHOA);

        }
    }
}
