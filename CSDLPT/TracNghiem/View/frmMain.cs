using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TracNghiem
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmLogin f = new frmLogin();
                f.Show();
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.currentRole = "";
            Program.currentUserName = "";
            Program.currentServer = "";
            Program.currentPass = "";
            Program.currentID = "";

            btnLogin.Enabled = true;
            btnLogout.Enabled = false;

            userID.Text = "UerID";
            userName.Text = "Name";
            userRole.Text = "Role";

            initRib(true);
            initRibGroup(false);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnLogout.Enabled = false;
            initRibGroup(false);
        }

        public void initRibGroup(Boolean isEnable)
        {
            ribbonTeacherGroup.Enabled = isEnable;
            ribbonStudentGroup.Enabled = isEnable;
            ribbonReportGroup.Enabled = isEnable;
            ribbonManaGroup.Enabled = isEnable;
        }

        public void initRib(Boolean isVisible)
        {
            ribStudent.Visible = isVisible;
            ribTeacher.Visible = isVisible;
            ribManage.Visible = isVisible;
            ribReport.Visible = isVisible;
        }

        private void btnDep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDep));
            if (frm != null) frm.Activate();
            else
            {
                frmDep f = new frmDep();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSubjects));
            if (frm != null) frm.Activate();
            else
            {
                frmSubjects f = new frmSubjects();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnCLass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmClass));
            if (frm != null) frm.Activate();
            else
            {
                frmClass f = new frmClass();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTeacher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTeacher));
            if (frm != null) frm.Activate();
            else
            {
                frmTeacher f = new frmTeacher();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmStudent));
            if (frm != null) frm.Activate();
            else
            {
                frmStudent f = new frmStudent();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnExam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmQuestion));
            if (frm != null) frm.Activate();
            else
            {
                frmQuestion f = new frmQuestion();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPoint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("We are developing this function", "", MessageBoxButtons.OK);
        }

        private void btnCreate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("We are developing this function", "", MessageBoxButtons.OK);
        }

        private void btnSign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmRegistration));
            if (frm != null) frm.Activate();
            else
            {
                frmRegistration f = new frmRegistration();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("We are developing this function", "", MessageBoxButtons.OK);
        }

        private void btnTest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("We are developing this function", "", MessageBoxButtons.OK);
        }

        private void btnTry_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("We are developing this function", "", MessageBoxButtons.OK);
        }
    }
}
