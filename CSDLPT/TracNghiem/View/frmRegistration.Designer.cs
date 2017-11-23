namespace TracNghiem
{
    partial class frmRegistration
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label nGAYTHILabel1;
            System.Windows.Forms.Label sOCAUTHILabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCountdown = new DevExpress.XtraEditors.SpinEdit();
            this.bdsRegistrationFromDep = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTracNghiem = new TracNghiem.dataSetTracNghiem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.sOCAUTHISpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.txtTime = new DevExpress.XtraEditors.SpinEdit();
            this.txtLevel = new DevExpress.XtraEditors.TextEdit();
            this.txtTeacherID = new DevExpress.XtraEditors.TextEdit();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.cbbSubject = new System.Windows.Forms.ComboBox();
            this.bdsSubject = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sp_DanhSachGVDKTheoCosoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sp_DanhSachGVDKTheoCosoTableAdapter = new TracNghiem.dataSetTracNghiemTableAdapters.sp_DanhSachGVDKTheoCosoTableAdapter();
            this.tableAdapterManager = new TracNghiem.dataSetTracNghiemTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new TracNghiem.dataSetTracNghiemTableAdapters.MONHOCTableAdapter();
            this.pickerDate = new System.Windows.Forms.DateTimePicker();
            this.txtQuestNum = new DevExpress.XtraEditors.SpinEdit();
            mAGVLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            nGAYTHILabel1 = new System.Windows.Forms.Label();
            sOCAUTHILabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountdown.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRegistrationFromDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTracNghiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCAUTHISpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeacherID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubject)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachGVDKTheoCosoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestNum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAGVLabel.Location = new System.Drawing.Point(220, 111);
            mAGVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(98, 22);
            mAGVLabel.TabIndex = 3;
            mAGVLabel.Text = "Teacher ID";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tRINHDOLabel.Location = new System.Drawing.Point(569, 111);
            tRINHDOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(55, 22);
            tRINHDOLabel.TabIndex = 5;
            tRINHDOLabel.Text = "Level";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lANLabel.Location = new System.Drawing.Point(586, 177);
            lANLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(50, 22);
            lANLabel.TabIndex = 9;
            lANLabel.Text = "Time";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Location = new System.Drawing.Point(1097, 309);
            sOCAUTHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(113, 22);
            sOCAUTHILabel.TabIndex = 11;
            sOCAUTHILabel.Text = "SOCAUTHI:";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tHOIGIANLabel.Location = new System.Drawing.Point(129, 180);
            tHOIGIANLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(100, 22);
            tHOIGIANLabel.TabIndex = 13;
            tHOIGIANLabel.Text = "Countdown";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(sOCAUTHILabel1);
            this.groupBox1.Controls.Add(this.txtQuestNum);
            this.groupBox1.Controls.Add(nGAYTHILabel1);
            this.groupBox1.Controls.Add(this.pickerDate);
            this.groupBox1.Controls.Add(tHOIGIANLabel);
            this.groupBox1.Controls.Add(this.txtCountdown);
            this.groupBox1.Controls.Add(sOCAUTHILabel);
            this.groupBox1.Controls.Add(this.sOCAUTHISpinEdit);
            this.groupBox1.Controls.Add(lANLabel);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(tRINHDOLabel);
            this.groupBox1.Controls.Add(this.txtLevel);
            this.groupBox1.Controls.Add(mAGVLabel);
            this.groupBox1.Controls.Add(this.txtTeacherID);
            this.groupBox1.Controls.Add(this.cbbDep);
            this.groupBox1.Controls.Add(this.cbbClass);
            this.groupBox1.Controls.Add(this.cbbSubject);
            this.groupBox1.Location = new System.Drawing.Point(4, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1020, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtCountdown
            // 
            this.txtCountdown.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsRegistrationFromDep, "THOIGIAN", true));
            this.txtCountdown.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.txtCountdown.Location = new System.Drawing.Point(245, 175);
            this.txtCountdown.Margin = new System.Windows.Forms.Padding(4);
            this.txtCountdown.MenuManager = this.barManager1;
            this.txtCountdown.Name = "txtCountdown";
            this.txtCountdown.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountdown.Properties.Appearance.Options.UseFont = true;
            this.txtCountdown.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCountdown.Properties.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txtCountdown.Properties.MinValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.txtCountdown.Size = new System.Drawing.Size(55, 28);
            this.txtCountdown.TabIndex = 14;
            // 
            // bdsRegistrationFromDep
            // 
            this.bdsRegistrationFromDep.DataMember = "sp_DanhSachGVDKTheoCoso";
            this.bdsRegistrationFromDep.DataSource = this.dataSetTracNghiem;
            // 
            // dataSetTracNghiem
            // 
            this.dataSetTracNghiem.DataSetName = "dataSetTracNghiem";
            this.dataSetTracNghiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNew,
            this.btnEdit,
            this.btnDel,
            this.btnSave,
            this.btnRefresh,
            this.btnCancel,
            this.btnClose});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNew, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnNew
            // 
            this.btnNew.Caption = "New";
            this.btnNew.Glyph = global::TracNghiem.Properties.Resources.icons8_plus;
            this.btnNew.Id = 0;
            this.btnNew.LargeGlyph = global::TracNghiem.Properties.Resources.icons8_plus;
            this.btnNew.Name = "btnNew";
            this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit";
            this.btnEdit.Glyph = global::TracNghiem.Properties.Resources.icons8_pencil;
            this.btnEdit.Id = 1;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDel
            // 
            this.btnDel.Caption = "Delete";
            this.btnDel.Glyph = global::TracNghiem.Properties.Resources.icons8_trash;
            this.btnDel.Id = 2;
            this.btnDel.Name = "btnDel";
            this.btnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDel_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Glyph = global::TracNghiem.Properties.Resources.icons8_save;
            this.btnSave.Id = 3;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Glyph = global::TracNghiem.Properties.Resources.icons8_refresh;
            this.btnRefresh.Id = 4;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Cancel";
            this.btnCancel.Glyph = global::TracNghiem.Properties.Resources.icons8_cancel;
            this.btnCancel.Id = 5;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.Glyph = global::TracNghiem.Properties.Resources.icons8_home;
            this.btnClose.Id = 6;
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1024, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 642);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1024, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 583);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1024, 59);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 583);
            // 
            // sOCAUTHISpinEdit
            // 
            this.sOCAUTHISpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsRegistrationFromDep, "SOCAUTHI", true));
            this.sOCAUTHISpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sOCAUTHISpinEdit.Location = new System.Drawing.Point(1218, 305);
            this.sOCAUTHISpinEdit.Margin = new System.Windows.Forms.Padding(4);
            this.sOCAUTHISpinEdit.MenuManager = this.barManager1;
            this.sOCAUTHISpinEdit.Name = "sOCAUTHISpinEdit";
            this.sOCAUTHISpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sOCAUTHISpinEdit.Size = new System.Drawing.Size(138, 22);
            this.sOCAUTHISpinEdit.TabIndex = 12;
            // 
            // txtTime
            // 
            this.txtTime.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsRegistrationFromDep, "LAN", true));
            this.txtTime.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTime.Location = new System.Drawing.Point(644, 174);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.MenuManager = this.barManager1;
            this.txtTime.Name = "txtTime";
            this.txtTime.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Properties.Appearance.Options.UseFont = true;
            this.txtTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTime.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtTime.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTime.Size = new System.Drawing.Size(45, 28);
            this.txtTime.TabIndex = 10;
            // 
            // txtLevel
            // 
            this.txtLevel.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsRegistrationFromDep, "TRINHDO", true));
            this.txtLevel.Location = new System.Drawing.Point(644, 108);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(4);
            this.txtLevel.MenuManager = this.barManager1;
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLevel.Properties.Appearance.Options.UseFont = true;
            this.txtLevel.Properties.MaxLength = 1;
            this.txtLevel.Size = new System.Drawing.Size(95, 28);
            this.txtLevel.TabIndex = 6;
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsRegistrationFromDep, "MAGV", true));
            this.txtTeacherID.Location = new System.Drawing.Point(332, 108);
            this.txtTeacherID.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeacherID.MenuManager = this.barManager1;
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherID.Properties.Appearance.Options.UseFont = true;
            this.txtTeacherID.Properties.MaxLength = 8;
            this.txtTeacherID.Size = new System.Drawing.Size(138, 28);
            this.txtTeacherID.TabIndex = 4;
            // 
            // cbbDep
            // 
            this.cbbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(59, 29);
            this.cbbDep.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(159, 30);
            this.cbbDep.TabIndex = 2;
            this.cbbDep.SelectionChangeCommitted += new System.EventHandler(this.cbbDep_SelectionChangeCommitted);
            // 
            // cbbClass
            // 
            this.cbbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(539, 31);
            this.cbbClass.Margin = new System.Windows.Forms.Padding(4);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(408, 30);
            this.cbbClass.TabIndex = 1;
            // 
            // cbbSubject
            // 
            this.cbbSubject.DataSource = this.bdsSubject;
            this.cbbSubject.DisplayMember = "MAMH";
            this.cbbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.Location = new System.Drawing.Point(308, 29);
            this.cbbSubject.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(156, 30);
            this.cbbSubject.TabIndex = 0;
            this.cbbSubject.ValueMember = "MAMH";
            // 
            // bdsSubject
            // 
            this.bdsSubject.DataSource = this.bdsRegistrationFromDep;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sp_DanhSachGVDKTheoCosoGridControl);
            this.groupBox2.Location = new System.Drawing.Point(4, 357);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1020, 287);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // sp_DanhSachGVDKTheoCosoGridControl
            // 
            this.sp_DanhSachGVDKTheoCosoGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sp_DanhSachGVDKTheoCosoGridControl.DataSource = this.bdsRegistrationFromDep;
            this.sp_DanhSachGVDKTheoCosoGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.sp_DanhSachGVDKTheoCosoGridControl.Location = new System.Drawing.Point(0, 23);
            this.sp_DanhSachGVDKTheoCosoGridControl.MainView = this.gridView1;
            this.sp_DanhSachGVDKTheoCosoGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.sp_DanhSachGVDKTheoCosoGridControl.MenuManager = this.barManager1;
            this.sp_DanhSachGVDKTheoCosoGridControl.Name = "sp_DanhSachGVDKTheoCosoGridControl";
            this.sp_DanhSachGVDKTheoCosoGridControl.Size = new System.Drawing.Size(1020, 264);
            this.sp_DanhSachGVDKTheoCosoGridControl.TabIndex = 0;
            this.sp_DanhSachGVDKTheoCosoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMALOP,
            this.colMAMH,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.gridView1.GridControl = this.sp_DanhSachGVDKTheoCosoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "Teacher ID";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.OptionsColumn.AllowEdit = false;
            this.colMAGV.OptionsColumn.ReadOnly = true;
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Class ID";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.OptionsColumn.ReadOnly = true;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 1;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Subject ID";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.OptionsColumn.ReadOnly = true;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 2;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.Caption = "Level";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.OptionsColumn.AllowEdit = false;
            this.colTRINHDO.OptionsColumn.ReadOnly = true;
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.Caption = "Date";
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.OptionsColumn.AllowEdit = false;
            this.colNGAYTHI.OptionsColumn.ReadOnly = true;
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            // 
            // colLAN
            // 
            this.colLAN.Caption = "Time";
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.OptionsColumn.AllowEdit = false;
            this.colLAN.OptionsColumn.ReadOnly = true;
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 5;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.Caption = "Number Quest";
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.OptionsColumn.AllowEdit = false;
            this.colSOCAUTHI.OptionsColumn.ReadOnly = true;
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 6;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.Caption = "Countdown";
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.OptionsColumn.AllowEdit = false;
            this.colTHOIGIAN.OptionsColumn.ReadOnly = true;
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 7;
            // 
            // sp_DanhSachGVDKTheoCosoTableAdapter
            // 
            this.sp_DanhSachGVDKTheoCosoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.sp_DanhSachBoDeTableAdapter = null;
            this.tableAdapterManager.sp_DanhSachGiaoVienTheoKhoaTableAdapter = null;
            this.tableAdapterManager.sp_DanhSachGVDKTheoCosoTableAdapter = null;
            this.tableAdapterManager.sp_DanhSachLopTheoKhoaVaCoSoTableAdapter = null;
            this.tableAdapterManager.sp_DanhSachSinhVienTheoLopTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.dataSetTracNghiemTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // nGAYTHILabel1
            // 
            nGAYTHILabel1.AutoSize = true;
            nGAYTHILabel1.Location = new System.Drawing.Point(722, 177);
            nGAYTHILabel1.Name = "nGAYTHILabel1";
            nGAYTHILabel1.Size = new System.Drawing.Size(47, 22);
            nGAYTHILabel1.TabIndex = 14;
            nGAYTHILabel1.Text = "Date";
            // 
            // pickerDate
            // 
            this.pickerDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsRegistrationFromDep, "NGAYTHI", true));
            this.pickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerDate.Location = new System.Drawing.Point(791, 172);
            this.pickerDate.Name = "pickerDate";
            this.pickerDate.Size = new System.Drawing.Size(122, 30);
            this.pickerDate.TabIndex = 15;
            // 
            // sOCAUTHILabel1
            // 
            sOCAUTHILabel1.AutoSize = true;
            sOCAUTHILabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOCAUTHILabel1.Location = new System.Drawing.Point(346, 180);
            sOCAUTHILabel1.Name = "sOCAUTHILabel1";
            sOCAUTHILabel1.Size = new System.Drawing.Size(118, 22);
            sOCAUTHILabel1.TabIndex = 15;
            sOCAUTHILabel1.Text = "NumberQuest";
            // 
            // txtQuestNum
            // 
            this.txtQuestNum.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsRegistrationFromDep, "SOCAUTHI", true));
            this.txtQuestNum.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtQuestNum.Location = new System.Drawing.Point(485, 177);
            this.txtQuestNum.MenuManager = this.barManager1;
            this.txtQuestNum.Name = "txtQuestNum";
            this.txtQuestNum.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestNum.Properties.Appearance.Options.UseFont = true;
            this.txtQuestNum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuestNum.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtQuestNum.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtQuestNum.Size = new System.Drawing.Size(53, 28);
            this.txtQuestNum.TabIndex = 16;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 642);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistration";
            this.Text = "frmRegistration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountdown.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRegistrationFromDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTracNghiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCAUTHISpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeacherID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubject)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachGVDKTheoCosoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestNum.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ComboBox cbbSubject;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource bdsRegistrationFromDep;
        private dataSetTracNghiem dataSetTracNghiem;
        private dataSetTracNghiemTableAdapters.sp_DanhSachGVDKTheoCosoTableAdapter sp_DanhSachGVDKTheoCosoTableAdapter;
        private dataSetTracNghiemTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sp_DanhSachGVDKTheoCosoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private System.Windows.Forms.BindingSource bdsSubject;
        private dataSetTracNghiemTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DevExpress.XtraEditors.SpinEdit txtCountdown;
        private DevExpress.XtraEditors.SpinEdit sOCAUTHISpinEdit;
        private DevExpress.XtraEditors.SpinEdit txtTime;
        private DevExpress.XtraEditors.TextEdit txtLevel;
        private DevExpress.XtraEditors.TextEdit txtTeacherID;
        private System.Windows.Forms.DateTimePicker pickerDate;
        private DevExpress.XtraEditors.SpinEdit txtQuestNum;
    }
}