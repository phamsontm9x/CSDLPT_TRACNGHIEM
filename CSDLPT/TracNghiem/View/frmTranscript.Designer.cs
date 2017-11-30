namespace TracNghiem
{
    partial class frmTranscript
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
            this.reportTranScript = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbbSubject = new System.Windows.Forms.ComboBox();
            this.bdsSubject = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTracNghiem = new TracNghiem.dataSetTracNghiem();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.cbbBranch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.bdsTranscript = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BangDiemMonHocLopTableAdapter = new TracNghiem.dataSetTracNghiemTableAdapters.sp_BangDiemMonHocLopTableAdapter();
            this.tableAdapterManager = new TracNghiem.dataSetTracNghiemTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new TracNghiem.dataSetTracNghiemTableAdapters.MONHOCTableAdapter();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.spTime = new DevExpress.XtraEditors.SpinEdit();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTracNghiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTranscript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // reportTranScript
            // 
            this.reportTranScript.ActiveViewIndex = -1;
            this.reportTranScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportTranScript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportTranScript.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportTranScript.Location = new System.Drawing.Point(0, 114);
            this.reportTranScript.Name = "reportTranScript";
            this.reportTranScript.Size = new System.Drawing.Size(1093, 471);
            this.reportTranScript.TabIndex = 0;
            // 
            // cbbSubject
            // 
            this.cbbSubject.DataSource = this.bdsSubject;
            this.cbbSubject.DisplayMember = "MAMH";
            this.cbbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.Location = new System.Drawing.Point(506, 66);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(213, 30);
            this.cbbSubject.TabIndex = 1;
            this.cbbSubject.ValueMember = "MAMH";
            // 
            // bdsSubject
            // 
            this.bdsSubject.DataMember = "MONHOC";
            this.bdsSubject.DataSource = this.dataSetTracNghiem;
            // 
            // dataSetTracNghiem
            // 
            this.dataSetTracNghiem.DataSetName = "dataSetTracNghiem";
            this.dataSetTracNghiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbDep
            // 
            this.cbbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(194, 17);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(132, 30);
            this.cbbDep.TabIndex = 1;
            this.cbbDep.SelectionChangeCommitted += new System.EventHandler(this.cbbDep_SelectionChangeCommitted);
            // 
            // cbbBranch
            // 
            this.cbbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBranch.FormattingEnabled = true;
            this.cbbBranch.Location = new System.Drawing.Point(475, 17);
            this.cbbBranch.Name = "cbbBranch";
            this.cbbBranch.Size = new System.Drawing.Size(240, 30);
            this.cbbBranch.TabIndex = 1;
            this.cbbBranch.SelectionChangeCommitted += new System.EventHandler(this.cbbBranch_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Branch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::TracNghiem.Properties.Resources.icons8_print_32;
            this.btnPrint.Location = new System.Drawing.Point(873, 40);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(76, 33);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // bdsTranscript
            // 
            this.bdsTranscript.DataMember = "sp_BangDiemMonHocLop";
            this.bdsTranscript.DataSource = this.dataSetTracNghiem;
            // 
            // sp_BangDiemMonHocLopTableAdapter
            // 
            this.sp_BangDiemMonHocLopTableAdapter.ClearBeforeFill = true;
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
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // cbbClass
            // 
            this.cbbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(154, 66);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(213, 30);
            this.cbbClass.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Class";
            // 
            // spTime
            // 
            this.spTime.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spTime.Location = new System.Drawing.Point(769, 42);
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
            this.spTime.Size = new System.Drawing.Size(41, 28);
            this.spTime.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::TracNghiem.Properties.Resources.icons8_exit_32;
            this.btnClose.Location = new System.Drawing.Point(973, 40);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTranscript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 585);
            this.Controls.Add(this.spTime);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbDep);
            this.Controls.Add(this.cbbBranch);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.cbbSubject);
            this.Controls.Add(this.reportTranScript);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTranscript";
            this.Text = "Transcript";
            this.Load += new System.EventHandler(this.frmTranscript_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTracNghiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTranscript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportTranScript;
        private System.Windows.Forms.ComboBox cbbSubject;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.ComboBox cbbBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
        private dataSetTracNghiem dataSetTracNghiem;
        private System.Windows.Forms.BindingSource bdsTranscript;
        private dataSetTracNghiemTableAdapters.sp_BangDiemMonHocLopTableAdapter sp_BangDiemMonHocLopTableAdapter;
        private dataSetTracNghiemTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.Label label4;
        private dataSetTracNghiemTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsSubject;
        private DevExpress.XtraEditors.SpinEdit spTime;
        private System.Windows.Forms.Button btnClose;
    }
}