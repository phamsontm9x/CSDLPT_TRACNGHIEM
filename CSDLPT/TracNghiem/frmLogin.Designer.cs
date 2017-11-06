namespace TracNghiem
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.rbGiaoVien = new System.Windows.Forms.RadioButton();
            this.rbSinhVien = new System.Windows.Forms.RadioButton();
            this.cbbTenCS = new System.Windows.Forms.ComboBox();
            this.bdsDSPhanManh = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTracNghiem = new TracNghiem.dataSetTracNghiem();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.vIEW_DS_PHANMANHTableAdapter = new TracNghiem.dataSetTracNghiemTableAdapters.VIEW_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new TracNghiem.dataSetTracNghiemTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPhanManh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTracNghiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.rbGiaoVien);
            this.groupBox1.Controls.Add(this.rbSinhVien);
            this.groupBox1.Controls.Add(this.cbbTenCS);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Location = new System.Drawing.Point(65, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Blue;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(362, 115);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(172, 66);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // rbGiaoVien
            // 
            this.rbGiaoVien.AutoSize = true;
            this.rbGiaoVien.Location = new System.Drawing.Point(224, 187);
            this.rbGiaoVien.Name = "rbGiaoVien";
            this.rbGiaoVien.Size = new System.Drawing.Size(109, 26);
            this.rbGiaoVien.TabIndex = 4;
            this.rbGiaoVien.Text = "Giáo viên";
            this.rbGiaoVien.UseVisualStyleBackColor = true;
            this.rbGiaoVien.CheckedChanged += new System.EventHandler(this.rbGiaoVien_CheckedChanged);
            // 
            // rbSinhVien
            // 
            this.rbSinhVien.AutoSize = true;
            this.rbSinhVien.Location = new System.Drawing.Point(53, 187);
            this.rbSinhVien.Name = "rbSinhVien";
            this.rbSinhVien.Size = new System.Drawing.Size(105, 26);
            this.rbSinhVien.TabIndex = 3;
            this.rbSinhVien.Text = "Sinh viên";
            this.rbSinhVien.UseVisualStyleBackColor = true;
            this.rbSinhVien.CheckedChanged += new System.EventHandler(this.rbSinhVien_CheckedChanged);
            // 
            // cbbTenCS
            // 
            this.cbbTenCS.DataSource = this.bdsDSPhanManh;
            this.cbbTenCS.DisplayMember = "MACS";
            this.cbbTenCS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenCS.FormattingEnabled = true;
            this.cbbTenCS.Location = new System.Drawing.Point(53, 40);
            this.cbbTenCS.Name = "cbbTenCS";
            this.cbbTenCS.Size = new System.Drawing.Size(280, 30);
            this.cbbTenCS.TabIndex = 0;
            this.cbbTenCS.ValueMember = "TENCS";
            this.cbbTenCS.SelectedIndexChanged += new System.EventHandler(this.cbbTenCS_SelectedIndexChanged);
            // 
            // bdsDSPhanManh
            // 
            this.bdsDSPhanManh.DataMember = "VIEW_DS_PHANMANH";
            this.bdsDSPhanManh.DataSource = this.dataSetTracNghiem;
            // 
            // dataSetTracNghiem
            // 
            this.dataSetTracNghiem.DataSetName = "dataSetTracNghiem";
            this.dataSetTracNghiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPass
            // 
            this.txtPass.ForeColor = System.Drawing.Color.LightGray;
            this.txtPass.Location = new System.Drawing.Point(53, 151);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(280, 30);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "Password";
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Load);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_DidLoad);
            // 
            // txtUser
            // 
            this.txtUser.ForeColor = System.Drawing.Color.LightGray;
            this.txtUser.Location = new System.Drawing.Point(53, 115);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(280, 30);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Username";
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Load);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_DidLoad);
            // 
            // vIEW_DS_PHANMANHTableAdapter
            // 
            this.vIEW_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.UpdateOrder = TracNghiem.dataSetTracNghiemTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::TracNghiem.Properties.Resources.backGround;
            this.ClientSize = new System.Drawing.Size(711, 342);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPhanManh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTracNghiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private dataSetTracNghiem dataSetTracNghiem;
        private System.Windows.Forms.BindingSource bdsDSPhanManh;
        private dataSetTracNghiemTableAdapters.VIEW_DS_PHANMANHTableAdapter vIEW_DS_PHANMANHTableAdapter;
        private dataSetTracNghiemTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbbTenCS;
        private System.Windows.Forms.RadioButton rbGiaoVien;
        private System.Windows.Forms.RadioButton rbSinhVien;
        private System.Windows.Forms.Button btnLogin;
    }
}