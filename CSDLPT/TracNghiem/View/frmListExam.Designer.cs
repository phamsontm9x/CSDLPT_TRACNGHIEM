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
            this.btnStart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.bdsListExam = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTracNghiem = new TracNghiem.dataSetTracNghiem();
            this.tHOIGIANLabel1 = new System.Windows.Forms.Label();
            this.lANLabel1 = new System.Windows.Forms.Label();
            this.sOCAUTHILabel1 = new System.Windows.Forms.Label();
            this.tRINHDOLabel1 = new System.Windows.Forms.Label();
            this.mAMHLabel1 = new System.Windows.Forms.Label();
            this.mALOPLabel1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sp_DanhSachMonThiGridControl = new DevExpress.XtraGrid.GridControl();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsListExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTracNghiem)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachMonThiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDate);
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
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(788, 117);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 48);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Countdown :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Time :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Level :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Subject ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Class ID :";
            // 
            // lblDate
            // 
            this.lblDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsListExam, "NGAYTHI", true));
            this.lblDate.Location = new System.Drawing.Point(606, 117);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 23);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date";
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
            // tHOIGIANLabel1
            // 
            this.tHOIGIANLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsListExam, "THOIGIAN", true));
            this.tHOIGIANLabel1.Location = new System.Drawing.Point(575, 179);
            this.tHOIGIANLabel1.Name = "tHOIGIANLabel1";
            this.tHOIGIANLabel1.Size = new System.Drawing.Size(100, 23);
            this.tHOIGIANLabel1.TabIndex = 9;
            this.tHOIGIANLabel1.Text = "Countdown";
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
            // sOCAUTHILabel1
            // 
            this.sOCAUTHILabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsListExam, "SOCAUTHI", true));
            this.sOCAUTHILabel1.Location = new System.Drawing.Point(394, 117);
            this.sOCAUTHILabel1.Name = "sOCAUTHILabel1";
            this.sOCAUTHILabel1.Size = new System.Drawing.Size(100, 23);
            this.sOCAUTHILabel1.TabIndex = 5;
            this.sOCAUTHILabel1.Text = "Num Quest";
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
            // mAMHLabel1
            // 
            this.mAMHLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsListExam, "MAMH", true));
            this.mAMHLabel1.Location = new System.Drawing.Point(556, 48);
            this.mAMHLabel1.Name = "mAMHLabel1";
            this.mAMHLabel1.Size = new System.Drawing.Size(100, 23);
            this.mAMHLabel1.TabIndex = 2;
            this.mAMHLabel1.Text = "Subject ID";
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
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
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
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsListExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTracNghiem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachMonThiGridControl)).EndInit();
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
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label tHOIGIANLabel1;
        private System.Windows.Forms.Label lANLabel1;
        private System.Windows.Forms.Label sOCAUTHILabel1;
        private System.Windows.Forms.Label tRINHDOLabel1;
        private System.Windows.Forms.Label mAMHLabel1;
        private System.Windows.Forms.Label mALOPLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
    }
}