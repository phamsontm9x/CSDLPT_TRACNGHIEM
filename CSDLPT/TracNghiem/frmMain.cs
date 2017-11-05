﻿using System;
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
            Program.currentName = "";

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
    }
}
