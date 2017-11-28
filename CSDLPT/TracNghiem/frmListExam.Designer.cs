namespace TracNghiem
{
    partial class frmListExam
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sp_DanhSachMonThiGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsListExam = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTracNghiem = new TracNghiem.dataSetTracNghiem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sp_DanhSachMonThiTableAdapter = new TracNghiem.dataSetTracNghiemTableAdapters.sp_DanhSachMonThiTableAdapter();
            this.tableAdapterManager = new TracNghiem.dataSetTracNghiemTableAdapters.TableAdapterManager();
            this.mALOPLabel1 = new System.Windows.Forms.Label();
            this.mAMHLabel1 = new System.Windows.Forms.Label();
            this.tRINHDOLabel1 = new System.Windows.Forms.Label();
            this.sOCAUTHILabel1 = new System.Windows.Forms.Label();
            this.lANLabel1 = new System.Windows.Forms.Label();
            this.tHOIGIANLabel1 = new System.Windows.Forms.Label();
            this.nGAYTHILabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachMonThiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsListExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTracNghiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nGAYTHILabel1);
            this.groupBox1.Controls.Add(this.tHOIGIANLabel1);
            this.groupBox1.Controls.Add(this.lANLabel1);
            this.groupBox1.Controls.Add(this.sOCAUTHILabel1);
            this.groupBox1.Controls.Add(this.tRINHDOLabel1);
            this.groupBox1.Controls.Add(this.mAMHLabel1);
            this.groupBox1.Controls.Add(this.mALOPLabel1);
            this.groupBox1.Location = new System.Drawing.Point(4, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sp_DanhSachMonThiGridControl);
            this.groupBox2.Location = new System.Drawing.Point(-2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1019, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // sp_DanhSachMonThiGridControl
            // 
            this.sp_DanhSachMonThiGridControl.DataSource = this.bdsListExam;
            this.sp_DanhSachMonThiGridControl.Location = new System.Drawing.Point(6, 19);
            this.sp_DanhSachMonThiGridControl.MainView = this.gridView1;
            this.sp_DanhSachMonThiGridControl.Name = "sp_DanhSachMonThiGridControl";
            this.sp_DanhSachMonThiGridControl.Size = new System.Drawing.Size(1007, 224);
            this.sp_DanhSachMonThiGridControl.TabIndex = 0;
            this.sp_DanhSachMonThiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsListExam
            // 
            this.bdsListExam.DataMember = "sp_DanhSachMonThi";
            this.bdsListExam.DataSource = this.dataSetTracNghiem;
            // 
            // dataSetTracNghiem
            // 
            this.dataSetTracNghiem.DataSetName = "dataSetTracNghiem";
            this.dataSetTracNghiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colMAMH,
            this.colTRINHDO,
            this.colSOCAUTHI,
            this.colLAN,
            this.colTHOIGIAN,
            this.colNGAYTHI});
            this.gridView1.GridControl = this.sp_DanhSachMonThiGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Class ID";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.OptionsColumn.ReadOnly = true;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Subject ID";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.OptionsColumn.ReadOnly = true;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.Caption = "Level";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.OptionsColumn.AllowEdit = false;
            this.colTRINHDO.OptionsColumn.ReadOnly = true;
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 2;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.Caption = "Num Question";
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.OptionsColumn.AllowEdit = false;
            this.colSOCAUTHI.OptionsColumn.ReadOnly = true;
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 3;
            // 
            // colLAN
            // 
            this.colLAN.Caption = "Time";
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.OptionsColumn.AllowEdit = false;
            this.colLAN.OptionsColumn.ReadOnly = true;
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 4;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.Caption = "Countdown";
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.OptionsColumn.AllowEdit = false;
            this.colTHOIGIAN.OptionsColumn.ReadOnly = true;
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 5;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.Caption = "Date";
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.OptionsColumn.AllowEdit = false;
            this.colNGAYTHI.OptionsColumn.ReadOnly = true;
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 6;
            // 
            // sp_DanhSachMonThiTableAdapter
            // 
            this.sp_DanhSachMonThiTableAdapter.ClearBeforeFill = true;
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
            // mALOPLabel1
            // 
            this.mALOPLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsListExam, "MALOP", true));
            this.mALOPLabel1.Location = new System.Drawing.Point(265, 48);
            this.mALOPLabel1.Name = "mALOPLabel1";
            this.mALOPLabel1.Size = new System.Drawing.Size(100, 23);
            this.mALOPLabel1.TabIndex = 1;
            this.mALOPLabel1.Text = "Class ID";
            // 
            // mAMHLabel1
            // 
            this.mAMHLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsListExam, "MAMH", true));
            this.mAMHLabel1.Location = new System.Drawing.Point(556, 49);
            this.mAMHLabel1.Name = "mAMHLabel1";
            this.mAMHLabel1.Size = new System.Drawing.Size(100, 23);
            this.mAMHLabel1.TabIndex = 2;
            this.mAMHLabel1.Text = "Subject ID";
            // 
            // tRINHDOLabel1
            // 
            this.tRINHDOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsListExam, "TRINHDO", true));
            this.tRINHDOLabel1.Location = new System.Drawing.Point(204, 117);
            this.tRINHDOLabel1.Name = "tRINHDOLabel1";
            this.tRINHDOLabel1.Size = new System.Drawing.Size(100, 23);
            this.tRINHDOLabel1.TabIndex = 3;
            this.tRINHDOLabel1.Text = "Level";
            // 
            // sOCAUTHILabel1
            // 
            this.sOCAUTHILabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsListExam, "SOCAUTHI", true));
            this.sOCAUTHILabel1.Location = new System.Drawing.Point(394, 117);
            this.sOCAUTHILabel1.Name = "sOCAUTHILabel1";
            this.sOCAUTHILabel1.Size = new System.Drawing.Size(100, 23);
            this.sOCAUTHILabel1.TabIndex = 5;
            this.sOCAUTHILabel1.Text = "Num Quest";
            // 
            // lANLabel1
            // 
            this.lANLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsListExam, "LAN", true));
            this.lANLabel1.Location = new System.Drawing.Point(265, 178);
            this.lANLabel1.Name = "lANLabel1";
            this.lANLabel1.Size = new System.Drawing.Size(100, 23);
            this.lANLabel1.TabIndex = 7;
            this.lANLabel1.Text = "Time";
            // 
            // tHOIGIANLabel1
            // 
            this.tHOIGIANLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsListExam, "THOIGIAN", true));
            this.tHOIGIANLabel1.Location = new System.Drawing.Point(556, 178);
            this.tHOIGIANLabel1.Name = "tHOIGIANLabel1";
            this.tHOIGIANLabel1.Size = new System.Drawing.Size(100, 23);
            this.tHOIGIANLabel1.TabIndex = 9;
            this.tHOIGIANLabel1.Text = "Countdown";
            // 
            // nGAYTHILabel1
            // 
            this.nGAYTHILabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsListExam, "NGAYTHI", true));
            this.nGAYTHILabel1.Location = new System.Drawing.Point(606, 117);
            this.nGAYTHILabel1.Name = "nGAYTHILabel1";
            this.nGAYTHILabel1.Size = new System.Drawing.Size(100, 23);
            this.nGAYTHILabel1.TabIndex = 11;
            this.nGAYTHILabel1.Text = "Date";
            // 
            // frmListExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListExam";
            this.Text = "frmListExam";
            this.Load += new System.EventHandler(this.frmListExam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachMonThiGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsListExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTracNghiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private dataSetTracNghiem dataSetTracNghiem;
        private System.Windows.Forms.BindingSource bdsListExam;
        private dataSetTracNghiemTableAdapters.sp_DanhSachMonThiTableAdapter sp_DanhSachMonThiTableAdapter;
        private dataSetTracNghiemTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sp_DanhSachMonThiGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private System.Windows.Forms.Label nGAYTHILabel1;
        private System.Windows.Forms.Label tHOIGIANLabel1;
        private System.Windows.Forms.Label lANLabel1;
        private System.Windows.Forms.Label sOCAUTHILabel1;
        private System.Windows.Forms.Label tRINHDOLabel1;
        private System.Windows.Forms.Label mAMHLabel1;
        private System.Windows.Forms.Label mALOPLabel1;
    }
}