namespace TracNghiem
{
    partial class frmDep
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDepName = new DevExpress.XtraEditors.TextEdit();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTracNghiem = new TracNghiem.dataSetTracNghiem();
            this.txtDepID = new DevExpress.XtraEditors.TextEdit();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kHOAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DepID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kHOATableAdapter = new TracNghiem.dataSetTracNghiemTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new TracNghiem.dataSetTracNghiemTableAdapters.TableAdapterManager();
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTracNghiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepID.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(462, 126);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(63, 22);
            mAKHLabel.TabIndex = 2;
            mAKHLabel.Text = "DepID";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(436, 171);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(89, 22);
            tENKHLabel.TabIndex = 4;
            tENKHLabel.Text = "DepName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(tENKHLabel);
            this.groupBox1.Controls.Add(this.txtDepName);
            this.groupBox1.Controls.Add(mAKHLabel);
            this.groupBox1.Controls.Add(this.txtDepID);
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.cbbDep);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(966, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtDepName
            // 
            this.txtDepName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "TENKH", true));
            this.txtDepName.Location = new System.Drawing.Point(543, 172);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(316, 22);
            this.txtDepName.TabIndex = 5;
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.dataSetTracNghiem;
            // 
            // dataSetTracNghiem
            // 
            this.dataSetTracNghiem.DataSetName = "dataSetTracNghiem";
            this.dataSetTracNghiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDepID
            // 
            this.txtDepID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MAKH", true));
            this.txtDepID.Enabled = false;
            this.txtDepID.Location = new System.Drawing.Point(543, 126);
            this.txtDepID.Name = "txtDepID";
            this.txtDepID.Size = new System.Drawing.Size(316, 22);
            this.txtDepID.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("VNI-Jamai", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(24, 30);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(326, 55);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Department Info";
            // 
            // cbbDep
            // 
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(34, 126);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(316, 30);
            this.cbbDep.TabIndex = 0;
            this.cbbDep.SelectedIndexChanged += new System.EventHandler(this.cbbDep_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kHOAGridControl);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(966, 318);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // kHOAGridControl
            // 
            this.kHOAGridControl.DataSource = this.bdsKhoa;
            this.kHOAGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kHOAGridControl.Location = new System.Drawing.Point(3, 26);
            this.kHOAGridControl.MainView = this.gridView1;
            this.kHOAGridControl.Name = "kHOAGridControl";
            this.kHOAGridControl.Size = new System.Drawing.Size(960, 289);
            this.kHOAGridControl.TabIndex = 0;
            this.kHOAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DepID,
            this.DepName});
            this.gridView1.GridControl = this.kHOAGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // DepID
            // 
            this.DepID.Caption = "DepID";
            this.DepID.FieldName = "MAKH";
            this.DepID.Name = "DepID";
            this.DepID.OptionsColumn.AllowEdit = false;
            this.DepID.OptionsColumn.ReadOnly = true;
            this.DepID.Visible = true;
            this.DepID.VisibleIndex = 0;
            this.DepID.Width = 289;
            // 
            // DepName
            // 
            this.DepName.Caption = "DepName";
            this.DepName.FieldName = "TENKH";
            this.DepName.Name = "DepName";
            this.DepName.OptionsColumn.AllowEdit = false;
            this.DepName.OptionsColumn.ReadOnly = true;
            this.DepName.Visible = true;
            this.DepName.VisibleIndex = 1;
            this.DepName.Width = 651;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.dataSetTracNghiemTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDep";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.frmDep_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTracNghiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepID.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kHOAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private dataSetTracNghiem dataSetTracNghiem;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private dataSetTracNghiemTableAdapters.KHOATableAdapter kHOATableAdapter;
        private dataSetTracNghiemTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl kHOAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.Label lblInfo;
        private DevExpress.XtraGrid.Columns.GridColumn DepID;
        private DevExpress.XtraGrid.Columns.GridColumn DepName;
        private DevExpress.XtraEditors.TextEdit txtDepName;
        private DevExpress.XtraEditors.TextEdit txtDepID;
    }
}