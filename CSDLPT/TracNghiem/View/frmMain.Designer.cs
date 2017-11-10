namespace TracNghiem
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStudent = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDep = new DevExpress.XtraBars.BarButtonItem();
            this.btnCLass = new DevExpress.XtraBars.BarButtonItem();
            this.btnTeacher = new DevExpress.XtraBars.BarButtonItem();
            this.btnSubject = new DevExpress.XtraBars.BarButtonItem();
            this.btnPoint = new DevExpress.XtraBars.BarButtonItem();
            this.btnExam = new DevExpress.XtraBars.BarButtonItem();
            this.btnSign = new DevExpress.XtraBars.BarButtonItem();
            this.btnTry = new DevExpress.XtraBars.BarButtonItem();
            this.btnTest = new DevExpress.XtraBars.BarButtonItem();
            this.btnReport = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreate = new DevExpress.XtraBars.BarButtonItem();
            this.ribSystem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribManage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonManaGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribTeacher = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonTeacherGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribStudent = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStudentGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribReport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonReportGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.userID = new System.Windows.Forms.ToolStripStatusLabel();
            this.userName = new System.Windows.Forms.ToolStripStatusLabel();
            this.userRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudent
            // 
            this.btnStudent.Caption = "Student";
            this.btnStudent.Id = 7;
            this.btnStudent.LargeGlyph = global::TracNghiem.Properties.Resources.icons8_student_male;
            this.btnStudent.Name = "btnStudent";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLogin,
            this.btnLogout,
            this.btnExit,
            this.btnDep,
            this.btnCLass,
            this.btnTeacher,
            this.btnStudent,
            this.btnSubject,
            this.btnPoint,
            this.btnExam,
            this.btnSign,
            this.btnTry,
            this.btnTest,
            this.btnReport,
            this.btnCreate});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribSystem,
            this.ribManage,
            this.ribTeacher,
            this.ribStudent,
            this.ribReport});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(943, 179);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Sign in";
            this.btnLogin.Id = 1;
            this.btnLogin.LargeGlyph = global::TracNghiem.Properties.Resources.icons8_Login_Filled_32;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Sign Out";
            this.btnLogout.Id = 2;
            this.btnLogout.LargeGlyph = global::TracNghiem.Properties.Resources.icons8_Sign_Out_Filled_32;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Close";
            this.btnExit.Id = 3;
            this.btnExit.LargeGlyph = global::TracNghiem.Properties.Resources.icons8_Shutdown_32;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // btnDep
            // 
            this.btnDep.Caption = "Department";
            this.btnDep.Id = 4;
            this.btnDep.LargeGlyph = global::TracNghiem.Properties.Resources.icons8_department;
            this.btnDep.Name = "btnDep";
            this.btnDep.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDep_ItemClick);
            // 
            // btnCLass
            // 
            this.btnCLass.Caption = "Class";
            this.btnCLass.Id = 5;
            this.btnCLass.LargeGlyph = global::TracNghiem.Properties.Resources.icons8_classroom;
            this.btnCLass.Name = "btnCLass";
            this.btnCLass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCLass_ItemClick);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Caption = "Teacher";
            this.btnTeacher.Id = 6;
            this.btnTeacher.LargeGlyph = global::TracNghiem.Properties.Resources.icons8_user_account_filled;
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTeacher_ItemClick);
            // 
            // btnSubject
            // 
            this.btnSubject.Caption = "Subjects";
            this.btnSubject.Id = 8;
            this.btnSubject.LargeGlyph = global::TracNghiem.Properties.Resources.icons8_book;
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSubject_ItemClick);
            // 
            // btnPoint
            // 
            this.btnPoint.Caption = "Transcript";
            this.btnPoint.Id = 9;
            this.btnPoint.LargeGlyph = global::TracNghiem.Properties.Resources.icons8_scorecard_filled;
            this.btnPoint.Name = "btnPoint";
            // 
            // btnExam
            // 
            this.btnExam.Caption = "Exam";
            this.btnExam.Id = 10;
            this.btnExam.LargeGlyph = global::TracNghiem.Properties.Resources.icons8_questionnaire;
            this.btnExam.Name = "btnExam";
            // 
            // btnSign
            // 
            this.btnSign.Caption = "Registration";
            this.btnSign.Id = 11;
            this.btnSign.LargeGlyph = global::TracNghiem.Properties.Resources.icons8_registration_filled;
            this.btnSign.Name = "btnSign";
            // 
            // btnTry
            // 
            this.btnTry.Caption = "Try Test";
            this.btnTry.Id = 12;
            this.btnTry.LargeGlyph = global::TracNghiem.Properties.Resources.icons8_todo_list;
            this.btnTry.Name = "btnTry";
            // 
            // btnTest
            // 
            this.btnTest.Caption = "Test";
            this.btnTest.Id = 13;
            this.btnTest.LargeGlyph = global::TracNghiem.Properties.Resources.icons8_todo_list;
            this.btnTest.Name = "btnTest";
            // 
            // btnReport
            // 
            this.btnReport.Caption = "Report";
            this.btnReport.Id = 14;
            this.btnReport.LargeGlyph = global::TracNghiem.Properties.Resources.icons8_report_card;
            this.btnReport.Name = "btnReport";
            // 
            // btnCreate
            // 
            this.btnCreate.Caption = "Register";
            this.btnCreate.Id = 15;
            this.btnCreate.LargeGlyph = global::TracNghiem.Properties.Resources.icons8_add_user_male;
            this.btnCreate.Name = "btnCreate";
            // 
            // ribSystem
            // 
            this.ribSystem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribSystem.Name = "ribSystem";
            this.ribSystem.Text = "System";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnExit);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribManage
            // 
            this.ribManage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonManaGroup});
            this.ribManage.Name = "ribManage";
            this.ribManage.Text = "Management";
            // 
            // ribbonManaGroup
            // 
            this.ribbonManaGroup.ItemLinks.Add(this.btnDep);
            this.ribbonManaGroup.ItemLinks.Add(this.btnCLass);
            this.ribbonManaGroup.ItemLinks.Add(this.btnTeacher);
            this.ribbonManaGroup.ItemLinks.Add(this.btnStudent);
            this.ribbonManaGroup.ItemLinks.Add(this.btnSubject);
            this.ribbonManaGroup.ItemLinks.Add(this.btnPoint);
            this.ribbonManaGroup.ItemLinks.Add(this.btnCreate);
            this.ribbonManaGroup.Name = "ribbonManaGroup";
            // 
            // ribTeacher
            // 
            this.ribTeacher.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonTeacherGroup});
            this.ribTeacher.Name = "ribTeacher";
            this.ribTeacher.Text = "Teacher";
            // 
            // ribbonTeacherGroup
            // 
            this.ribbonTeacherGroup.ItemLinks.Add(this.btnExam);
            this.ribbonTeacherGroup.ItemLinks.Add(this.btnSign);
            this.ribbonTeacherGroup.ItemLinks.Add(this.btnTry);
            this.ribbonTeacherGroup.Name = "ribbonTeacherGroup";
            // 
            // ribStudent
            // 
            this.ribStudent.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonStudentGroup});
            this.ribStudent.Name = "ribStudent";
            this.ribStudent.Text = "Student";
            // 
            // ribbonStudentGroup
            // 
            this.ribbonStudentGroup.ItemLinks.Add(this.btnTest);
            this.ribbonStudentGroup.Name = "ribbonStudentGroup";
            // 
            // ribReport
            // 
            this.ribReport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonReportGroup});
            this.ribReport.Name = "ribReport";
            this.ribReport.Text = "Report";
            // 
            // ribbonReportGroup
            // 
            this.ribbonReportGroup.ItemLinks.Add(this.btnReport);
            this.ribbonReportGroup.Name = "ribbonReportGroup";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userID,
            this.userName,
            this.userRole});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 22, 0);
            this.statusStrip1.Size = new System.Drawing.Size(943, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // userID
            // 
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(53, 20);
            this.userID.Text = "UserID";
            // 
            // userName
            // 
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(49, 20);
            this.userName.Text = "Name";
            // 
            // userRole
            // 
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(39, 20);
            this.userRole.Text = "Role";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 509);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Đề tài Trắc Nghiệm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        public System.Windows.Forms.ToolStripStatusLabel userID;
        public System.Windows.Forms.ToolStripStatusLabel userName;
        public System.Windows.Forms.ToolStripStatusLabel userRole;
        private DevExpress.XtraBars.BarButtonItem btnDep;
        private DevExpress.XtraBars.BarButtonItem btnCLass;
        private DevExpress.XtraBars.BarButtonItem btnTeacher;
        private DevExpress.XtraBars.BarButtonItem btnSubject;
        private DevExpress.XtraBars.BarButtonItem btnPoint;
        private DevExpress.XtraBars.BarButtonItem btnExam;
        private DevExpress.XtraBars.BarButtonItem btnSign;
        private DevExpress.XtraBars.BarButtonItem btnTry;
        private DevExpress.XtraBars.BarButtonItem btnTest;
        private DevExpress.XtraBars.BarButtonItem btnReport;
        private DevExpress.XtraBars.BarButtonItem btnCreate;
        public DevExpress.XtraBars.BarButtonItem btnLogout;
        public DevExpress.XtraBars.BarButtonItem btnLogin;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribSystem;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribManage;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribTeacher;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribStudent;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribReport;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonManaGroup;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonReportGroup;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonStudentGroup;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonTeacherGroup;
        private DevExpress.XtraBars.BarButtonItem btnStudent;
    }
}

