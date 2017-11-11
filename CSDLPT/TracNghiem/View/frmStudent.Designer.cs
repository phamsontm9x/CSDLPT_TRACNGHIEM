namespace TracNghiem
{
    partial class frmStudent
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.bdsStudentFromClass = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTracNghiem = new TracNghiem.dataSetTracNghiem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.txtStudentID = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.cbbBranch = new System.Windows.Forms.ComboBox();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.bdsStudent = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new TracNghiem.dataSetTracNghiemTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new TracNghiem.dataSetTracNghiemTableAdapters.TableAdapterManager();
            this.sp_DanhSachSinhVienTheoLopTableAdapter = new TracNghiem.dataSetTracNghiemTableAdapters.sp_DanhSachSinhVienTheoLopTableAdapter();
            this.sp_DanhSachSinhVienTheoLopGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsStudentFromClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTracNghiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachSinhVienTheoLopGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(496, 86);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(93, 22);
            mASVLabel.TabIndex = 4;
            mASVLabel.Text = "Student ID";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(495, 135);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(94, 22);
            hOLabel.TabIndex = 6;
            hOLabel.Text = "Last Name";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(860, 135);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(98, 22);
            tENLabel.TabIndex = 8;
            tENLabel.Text = "First Name";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(495, 182);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(78, 22);
            nGAYSINHLabel.TabIndex = 10;
            nGAYSINHLabel.Text = "Birthday";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(495, 228);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(76, 22);
            dIACHILabel.TabIndex = 12;
            dIACHILabel.Text = "Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(nGAYSINHLabel);
            this.groupBox1.Controls.Add(this.pickerBirthday);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(mASVLabel);
            this.groupBox1.Controls.Add(this.txtStudentID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbClass);
            this.groupBox1.Controls.Add(this.cbbBranch);
            this.groupBox1.Controls.Add(this.cbbDep);
            this.groupBox1.Location = new System.Drawing.Point(0, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1127, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(757, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Class ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Branch ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Department ID";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsStudentFromClass, "DIACHI", true));
            this.txtAddress.Location = new System.Drawing.Point(598, 229);
            this.txtAddress.MenuManager = this.barManager1;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.MaxLength = 40;
            this.txtAddress.Size = new System.Drawing.Size(466, 22);
            this.txtAddress.TabIndex = 13;
            // 
            // bdsStudentFromClass
            // 
            this.bdsStudentFromClass.DataMember = "sp_DanhSachSinhVienTheoLop";
            this.bdsStudentFromClass.DataSource = this.dataSetTracNghiem;
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
            this.btnSave,
            this.btnDel,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Glyph = global::TracNghiem.Properties.Resources.icons8_save;
            this.btnSave.Id = 2;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnDel
            // 
            this.btnDel.Caption = "Delete";
            this.btnDel.Glyph = global::TracNghiem.Properties.Resources.icons8_trash;
            this.btnDel.Id = 3;
            this.btnDel.Name = "btnDel";
            this.btnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDel_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1127, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 664);
            this.barDockControlBottom.Size = new System.Drawing.Size(1127, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 605);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1127, 59);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 605);
            // 
            // pickerBirthday
            // 
            this.pickerBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsStudentFromClass, "NGAYSINH", true));
            this.pickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerBirthday.Location = new System.Drawing.Point(598, 176);
            this.pickerBirthday.Name = "pickerBirthday";
            this.pickerBirthday.Size = new System.Drawing.Size(171, 30);
            this.pickerBirthday.TabIndex = 11;
            this.pickerBirthday.ValueChanged += new System.EventHandler(this.pickerBirthday_ValueChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsStudentFromClass, "TEN", true));
            this.txtFirstName.Location = new System.Drawing.Point(964, 136);
            this.txtFirstName.MenuManager = this.barManager1;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Properties.MaxLength = 10;
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 9;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyboardPressed);
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsStudentFromClass, "HO", true));
            this.txtLastName.Location = new System.Drawing.Point(598, 136);
            this.txtLastName.MenuManager = this.barManager1;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Properties.MaxLength = 40;
            this.txtLastName.Size = new System.Drawing.Size(238, 22);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyboardPressed);
            // 
            // txtStudentID
            // 
            this.txtStudentID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsStudentFromClass, "MASV", true));
            this.txtStudentID.Location = new System.Drawing.Point(598, 87);
            this.txtStudentID.MenuManager = this.barManager1;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Properties.MaxLength = 8;
            this.txtStudentID.Size = new System.Drawing.Size(171, 22);
            this.txtStudentID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Jamai", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Info";
            // 
            // cbbClass
            // 
            this.cbbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(842, 29);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(191, 30);
            this.cbbClass.TabIndex = 0;
            this.cbbClass.SelectionChangeCommitted += new System.EventHandler(this.cbbClass_SelectionChangeCommitted);
            // 
            // cbbBranch
            // 
            this.cbbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBranch.FormattingEnabled = true;
            this.cbbBranch.Location = new System.Drawing.Point(480, 29);
            this.cbbBranch.Name = "cbbBranch";
            this.cbbBranch.Size = new System.Drawing.Size(250, 30);
            this.cbbBranch.TabIndex = 0;
            this.cbbBranch.SelectionChangeCommitted += new System.EventHandler(this.cbbBranch_SelectionChangeCommitted);
            // 
            // cbbDep
            // 
            this.cbbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(212, 29);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(143, 30);
            this.cbbDep.TabIndex = 0;
            this.cbbDep.SelectedIndexChanged += new System.EventHandler(this.cbbDep_SelectionChangeCommitted);
            // 
            // bdsStudent
            // 
            this.bdsStudent.DataMember = "SINHVIEN";
            this.bdsStudent.DataSource = this.dataSetTracNghiem;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.sp_DanhSachGiaoVienTheoKhoaTableAdapter = null;
            this.tableAdapterManager.sp_DanhSachLopTheoKhoaTableAdapter = null;
            this.tableAdapterManager.sp_DanhSachSinhVienTheoLopTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.dataSetTracNghiemTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sp_DanhSachSinhVienTheoLopTableAdapter
            // 
            this.sp_DanhSachSinhVienTheoLopTableAdapter.ClearBeforeFill = true;
            // 
            // sp_DanhSachSinhVienTheoLopGridControl
            // 
            this.sp_DanhSachSinhVienTheoLopGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sp_DanhSachSinhVienTheoLopGridControl.DataSource = this.bdsStudentFromClass;
            this.sp_DanhSachSinhVienTheoLopGridControl.Location = new System.Drawing.Point(0, 5);
            this.sp_DanhSachSinhVienTheoLopGridControl.MainView = this.gridView1;
            this.sp_DanhSachSinhVienTheoLopGridControl.MenuManager = this.barManager1;
            this.sp_DanhSachSinhVienTheoLopGridControl.Name = "sp_DanhSachSinhVienTheoLopGridControl";
            this.sp_DanhSachSinhVienTheoLopGridControl.Size = new System.Drawing.Size(1127, 271);
            this.sp_DanhSachSinhVienTheoLopGridControl.TabIndex = 6;
            this.sp_DanhSachSinhVienTheoLopGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colDIACHI});
            this.gridView1.GridControl = this.sp_DanhSachSinhVienTheoLopGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Student ID";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 123;
            // 
            // colHO
            // 
            this.colHO.Caption = "Last Name";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.OptionsColumn.ReadOnly = true;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 271;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "First Name";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.OptionsColumn.ReadOnly = true;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 131;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Birthday";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.OptionsColumn.ReadOnly = true;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            this.colNGAYSINH.Width = 188;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Address";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.OptionsColumn.ReadOnly = true;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 303;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sp_DanhSachSinhVienTheoLopGridControl);
            this.groupBox2.Location = new System.Drawing.Point(0, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1127, 276);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 664);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudent";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsStudentFromClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTracNghiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachSinhVienTheoLopGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.ComboBox cbbBranch;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.BindingSource bdsStudent;
        private dataSetTracNghiem dataSetTracNghiem;
        private dataSetTracNghiemTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private dataSetTracNghiemTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsStudentFromClass;
        private dataSetTracNghiemTableAdapters.sp_DanhSachSinhVienTheoLopTableAdapter sp_DanhSachSinhVienTheoLopTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl sp_DanhSachSinhVienTheoLopGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private System.Windows.Forms.DateTimePicker pickerBirthday;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.TextEdit txtStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}