namespace EDP_Act_4
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutbut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.reportbut = new System.Windows.Forms.Button();
            this.aboutbut = new System.Windows.Forms.Button();
            this.homebut = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(144, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 44);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "REPORT GENERATOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.logoutbut);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.reportbut);
            this.panel2.Controls.Add(this.aboutbut);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.homebut);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 416);
            this.panel2.TabIndex = 6;
            // 
            // logoutbut
            // 
            this.logoutbut.FlatAppearance.BorderSize = 0;
            this.logoutbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbut.Location = new System.Drawing.Point(3, 310);
            this.logoutbut.Name = "logoutbut";
            this.logoutbut.Size = new System.Drawing.Size(137, 37);
            this.logoutbut.TabIndex = 10;
            this.logoutbut.Text = "LOGOUT";
            this.logoutbut.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Admin";
            // 
            // reportbut
            // 
            this.reportbut.FlatAppearance.BorderSize = 0;
            this.reportbut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.reportbut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbut.Location = new System.Drawing.Point(0, 178);
            this.reportbut.Name = "reportbut";
            this.reportbut.Size = new System.Drawing.Size(143, 37);
            this.reportbut.TabIndex = 4;
            this.reportbut.Text = "REPORT";
            this.reportbut.UseVisualStyleBackColor = true;
            // 
            // aboutbut
            // 
            this.aboutbut.FlatAppearance.BorderSize = 0;
            this.aboutbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutbut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutbut.Location = new System.Drawing.Point(3, 221);
            this.aboutbut.Name = "aboutbut";
            this.aboutbut.Size = new System.Drawing.Size(137, 37);
            this.aboutbut.TabIndex = 5;
            this.aboutbut.Text = "ABOUT";
            this.aboutbut.UseVisualStyleBackColor = true;
            this.aboutbut.Click += new System.EventHandler(this.aboutbut_Click);
            // 
            // homebut
            // 
            this.homebut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(188)))), ((int)(((byte)(189)))));
            this.homebut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homebut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homebut.FlatAppearance.BorderSize = 0;
            this.homebut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebut.Location = new System.Drawing.Point(3, 135);
            this.homebut.Name = "homebut";
            this.homebut.Size = new System.Drawing.Size(137, 37);
            this.homebut.TabIndex = 0;
            this.homebut.Text = "HOME";
            this.homebut.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::EDP_Act_4.Properties.Resources.market_research_report;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(144, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(617, 368);
            this.panel6.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::EDP_Act_4.Properties.Resources.SETTING_removebg_preview;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(572, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(31, 33);
            this.panel5.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(533, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(33, 33);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::EDP_Act_4.Properties.Resources.User50px;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(37, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(67, 68);
            this.panel4.TabIndex = 8;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 416);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logoutbut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reportbut;
        private System.Windows.Forms.Button aboutbut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button homebut;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
    }
}