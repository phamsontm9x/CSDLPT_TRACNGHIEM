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
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.groupQuestion = new System.Windows.Forms.GroupBox();
            this.btnAnswer4 = new System.Windows.Forms.RadioButton();
            this.btnAnswer3 = new System.Windows.Forms.RadioButton();
            this.btnAnswer2 = new System.Windows.Forms.RadioButton();
            this.btnAnswer1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbQuestion = new System.Windows.Forms.ListBox();
            this.groupQuestion.SuspendLayout();
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
            this.groupQuestion.Controls.Add(this.label1);
            this.groupQuestion.Location = new System.Drawing.Point(176, 83);
            this.groupQuestion.Name = "groupQuestion";
            this.groupQuestion.Size = new System.Drawing.Size(1030, 506);
            this.groupQuestion.TabIndex = 0;
            this.groupQuestion.TabStop = false;
            this.groupQuestion.Text = "groupQuestion";
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.AutoSize = true;
            this.btnAnswer4.Location = new System.Drawing.Point(48, 244);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(110, 21);
            this.btnAnswer4.TabIndex = 10;
            this.btnAnswer4.TabStop = true;
            this.btnAnswer4.Text = "radioButton4";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            this.btnAnswer4.CheckedChanged += new System.EventHandler(this.btnAnswer4_CheckedChanged);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.AutoSize = true;
            this.btnAnswer3.Location = new System.Drawing.Point(48, 198);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(110, 21);
            this.btnAnswer3.TabIndex = 9;
            this.btnAnswer3.TabStop = true;
            this.btnAnswer3.Text = "radioButton3";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            this.btnAnswer3.CheckedChanged += new System.EventHandler(this.btnAnswer3_CheckedChanged);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.AutoSize = true;
            this.btnAnswer2.Location = new System.Drawing.Point(48, 158);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(110, 21);
            this.btnAnswer2.TabIndex = 8;
            this.btnAnswer2.TabStop = true;
            this.btnAnswer2.Text = "radioButton2";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            this.btnAnswer2.CheckedChanged += new System.EventHandler(this.btnAnswer2_CheckedChanged);
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.AutoSize = true;
            this.btnAnswer1.Location = new System.Drawing.Point(48, 113);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(110, 21);
            this.btnAnswer1.TabIndex = 7;
            this.btnAnswer1.TabStop = true;
            this.btnAnswer1.Text = "radioButton1";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            this.btnAnswer1.CheckedChanged += new System.EventHandler(this.btnAnswer1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 70);
            this.label1.MaximumSize = new System.Drawing.Size(300, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cau 1:";
            // 
            // lbQuestion
            // 
            this.lbQuestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbQuestion.FormattingEnabled = true;
            this.lbQuestion.ItemHeight = 16;
            this.lbQuestion.Location = new System.Drawing.Point(2, 89);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(168, 308);
            this.lbQuestion.TabIndex = 1;
            this.lbQuestion.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbQuestion_DrawItem);
            this.lbQuestion.SelectedIndexChanged += new System.EventHandler(this.lbQuestion_SelectedIndexChanged);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 638);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.groupQuestion);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.groupQuestion.ResumeLayout(false);
            this.groupQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.GroupBox groupQuestion;
        private System.Windows.Forms.ListBox lbQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btnAnswer4;
        private System.Windows.Forms.RadioButton btnAnswer3;
        private System.Windows.Forms.RadioButton btnAnswer2;
        private System.Windows.Forms.RadioButton btnAnswer1;
    }
}