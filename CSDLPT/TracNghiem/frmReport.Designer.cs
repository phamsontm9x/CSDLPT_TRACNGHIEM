namespace TracNghiem
{
    partial class frmReport
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
            this.cbbSubject = new System.Windows.Forms.ComboBox();
            this.spTime = new DevExpress.XtraEditors.SpinEdit();
            this.dataSetTracNghiem = new TracNghiem.dataSetTracNghiem();
            this.bdsSubject = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new TracNghiem.dataSetTracNghiemTableAdapters.MONHOCTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.crtReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bdsStudentExam = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BaiThiSinhVienTableAdapter = new TracNghiem.dataSetTracNghiemTableAdapters.sp_BaiThiSinhVienTableAdapter();
            this.tableAdapterManager = new TracNghiem.dataSetTracNghiemTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.spTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTracNghiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsStudentExam)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbSubject
            // 
            this.cbbSubject.DataSource = this.bdsSubject;
            this.cbbSubject.DisplayMember = "MAMH";
            this.cbbSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.Location = new System.Drawing.Point(245, 39);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(208, 30);
            this.cbbSubject.TabIndex = 0;
            this.cbbSubject.ValueMember = "MAMH";
            // 
            // spTime
            // 
            this.spTime.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spTime.Location = new System.Drawing.Point(628, 39);
            this.spTime.Name = "spTime";
            this.spTime.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spTime.Properties.Appearance.Options.UseFont = true;
            this.spTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spTime.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spTime.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spTime.Size = new System.Drawing.Size(57, 28);
            this.spTime.TabIndex = 1;
            // 
            // dataSetTracNghiem
            // 
            this.dataSetTracNghiem.DataSetName = "dataSetTracNghiem";
            this.dataSetTracNghiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSubject
            // 
            this.bdsSubject.DataMember = "MONHOC";
            this.bdsSubject.DataSource = this.dataSetTracNghiem;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subject ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::TracNghiem.Properties.Resources.icons8_print_32;
            this.btnPrint.Location = new System.Drawing.Point(803, 40);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 40);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::TracNghiem.Properties.Resources.icons8_exit_32;
            this.btnClose.Location = new System.Drawing.Point(928, 40);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // crtReport
            // 
            this.crtReport.ActiveViewIndex = -1;
            this.crtReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crtReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtReport.Location = new System.Drawing.Point(2, 97);
            this.crtReport.Name = "crtReport";
            this.crtReport.Size = new System.Drawing.Size(1186, 573);
            this.crtReport.TabIndex = 4;
            // 
            // bdsStudentExam
            // 
            this.bdsStudentExam.DataMember = "sp_BaiThiSinhVien";
            this.bdsStudentExam.DataSource = this.dataSetTracNghiem;
            // 
            // sp_BaiThiSinhVienTableAdapter
            // 
            this.sp_BaiThiSinhVienTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.sp_DanhSachBoDeTableAdapter = null;
            this.tableAdapterManager.sp_DanhSachGiaoVienTheoKhoaTableAdapter = null;
            this.tableAdapterManager.sp_DanhSachGVDKTheoCosoTableAdapter = null;
            this.tableAdapterManager.sp_DanhSachLopTheoKhoaVaCoSoTableAdapter = null;
            this.tableAdapterManager.sp_DanhSachSinhVienTheoLopTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.dataSetTracNghiemTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 671);
            this.Controls.Add(this.crtReport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spTime);
            this.Controls.Add(this.cbbSubject);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTracNghiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsStudentExam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSubject;
        private DevExpress.XtraEditors.SpinEdit spTime;
        private dataSetTracNghiem dataSetTracNghiem;
        private System.Windows.Forms.BindingSource bdsSubject;
        private dataSetTracNghiemTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtReport;
        private System.Windows.Forms.BindingSource bdsStudentExam;
        private dataSetTracNghiemTableAdapters.sp_BaiThiSinhVienTableAdapter sp_BaiThiSinhVienTableAdapter;
        private dataSetTracNghiemTableAdapters.TableAdapterManager tableAdapterManager;
    }
}