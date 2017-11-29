namespace TracNghiem
{
    partial class frmTest
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
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.groupQuestion = new System.Windows.Forms.GroupBox();
            this.btnAnswer4 = new System.Windows.Forms.RadioButton();
            this.btnAnswer3 = new System.Windows.Forms.RadioButton();
            this.btnAnswer2 = new System.Windows.Forms.RadioButton();
            this.btnAnswer1 = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.lbQuestion = new System.Windows.Forms.ListBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.groupQuestion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.AllowCollapse = true;
            this.bar1.Text = "Tools";
            // 
            // groupQuestion
            // 
            this.groupQuestion.Controls.Add(this.btnAnswer4);
            this.groupQuestion.Controls.Add(this.btnAnswer3);
            this.groupQuestion.Controls.Add(this.btnAnswer2);
            this.groupQuestion.Controls.Add(this.btnAnswer1);
            this.groupQuestion.Controls.Add(this.lblQuestion);
            this.groupQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupQuestion.Location = new System.Drawing.Point(171, 172);
            this.groupQuestion.Name = "groupQuestion";
            this.groupQuestion.Size = new System.Drawing.Size(853, 426);
            this.groupQuestion.TabIndex = 0;
            this.groupQuestion.TabStop = false;
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.AutoSize = true;
            this.btnAnswer4.Location = new System.Drawing.Point(53, 369);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(134, 26);
            this.btnAnswer4.TabIndex = 10;
            this.btnAnswer4.TabStop = true;
            this.btnAnswer4.Text = "radioButton4";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            this.btnAnswer4.CheckedChanged += new System.EventHandler(this.btnAnswer4_CheckedChanged);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.AutoSize = true;
            this.btnAnswer3.Location = new System.Drawing.Point(53, 323);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(134, 26);
            this.btnAnswer3.TabIndex = 9;
            this.btnAnswer3.TabStop = true;
            this.btnAnswer3.Text = "radioButton3";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            this.btnAnswer3.CheckedChanged += new System.EventHandler(this.btnAnswer3_CheckedChanged);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.AutoSize = true;
            this.btnAnswer2.Location = new System.Drawing.Point(53, 283);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(134, 26);
            this.btnAnswer2.TabIndex = 8;
            this.btnAnswer2.TabStop = true;
            this.btnAnswer2.Text = "radioButton2";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            this.btnAnswer2.CheckedChanged += new System.EventHandler(this.btnAnswer2_CheckedChanged);
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.AutoSize = true;
            this.btnAnswer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAnswer1.Location = new System.Drawing.Point(53, 238);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(134, 26);
            this.btnAnswer1.TabIndex = 7;
            this.btnAnswer1.TabStop = true;
            this.btnAnswer1.Text = "radioButton1";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            this.btnAnswer1.CheckedChanged += new System.EventHandler(this.btnAnswer1_CheckedChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(50, 54);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(300, 80);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(62, 22);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Cau 1:";
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(925, 41);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(99, 54);
            this.btnBegin.TabIndex = 11;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // lbQuestion
            // 
            this.lbQuestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.FormattingEnabled = true;
            this.lbQuestion.ItemHeight = 16;
            this.lbQuestion.Location = new System.Drawing.Point(1, 178);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(164, 500);
            this.lbQuestion.TabIndex = 1;
            this.lbQuestion.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbQuestion_DrawItem);
            this.lbQuestion.SelectedIndexChanged += new System.EventHandler(this.lbQuestion_SelectedIndexChanged);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("VNI-Jamai", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(36, 227);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(95, 41);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(357, 20);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(72, 22);
            this.lblUserId.TabIndex = 12;
            this.lblUserId.Text = "User ID";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(61, 73);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(94, 22);
            this.lblSubject.TabIndex = 12;
            this.lblSubject.Text = "Subject ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(61, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 22);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(291, 73);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 22);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Time";
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassID.Location = new System.Drawing.Point(560, 20);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(79, 22);
            this.lblClassID.TabIndex = 12;
            this.lblClassID.Text = "Class ID";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(607, 73);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 22);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(459, 73);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(55, 22);
            this.lblLevel.TabIndex = 12;
            this.lblLevel.Text = "Level";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.Location = new System.Drawing.Point(291, 128);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(100, 22);
            this.lblCountdown.TabIndex = 12;
            this.lblCountdown.Text = "Countdown";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.lblTimer);
            this.groupBox1.Location = new System.Drawing.Point(1030, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 500);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Image = global::TracNghiem.Properties.Resources.icons8_enter_32;
            this.btnFinish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinish.Location = new System.Drawing.Point(540, 619);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(114, 34);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "Submit";
            this.btnFinish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 680);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblClassID);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.groupQuestion);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.groupQuestion.ResumeLayout(false);
            this.groupQuestion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.GroupBox groupQuestion;
        private System.Windows.Forms.ListBox lbQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton btnAnswer4;
        private System.Windows.Forms.RadioButton btnAnswer3;
        private System.Windows.Forms.RadioButton btnAnswer2;
        private System.Windows.Forms.RadioButton btnAnswer1;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}