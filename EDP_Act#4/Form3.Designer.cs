namespace EDP_Act_4
{
    partial class ForgotPass
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
            this.label1 = new System.Windows.Forms.Label();
            this.Newpasstextbox = new System.Windows.Forms.TextBox();
            this.LEmailLabel = new System.Windows.Forms.Label();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.LEmailTextbox = new System.Windows.Forms.TextBox();
            this.Fpassbut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Fcpasstextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.25F);
            this.label1.Location = new System.Drawing.Point(59, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Create New Password";
            // 
            // Newpasstextbox
            // 
            this.Newpasstextbox.Location = new System.Drawing.Point(62, 159);
            this.Newpasstextbox.Name = "Newpasstextbox";
            this.Newpasstextbox.PasswordChar = '*';
            this.Newpasstextbox.Size = new System.Drawing.Size(273, 20);
            this.Newpasstextbox.TabIndex = 13;
            this.Newpasstextbox.UseSystemPasswordChar = true;
            // 
            // LEmailLabel
            // 
            this.LEmailLabel.AutoSize = true;
            this.LEmailLabel.Font = new System.Drawing.Font("Arial", 10.25F);
            this.LEmailLabel.Location = new System.Drawing.Point(59, 95);
            this.LEmailLabel.Name = "LEmailLabel";
            this.LEmailLabel.Size = new System.Drawing.Size(41, 16);
            this.LEmailLabel.TabIndex = 12;
            this.LEmailLabel.Text = "Email";
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLabel.Location = new System.Drawing.Point(66, 25);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(276, 40);
            this.LogInLabel.TabIndex = 11;
            this.LogInLabel.Text = "Forgot Password";
            // 
            // LEmailTextbox
            // 
            this.LEmailTextbox.Location = new System.Drawing.Point(62, 114);
            this.LEmailTextbox.Name = "LEmailTextbox";
            this.LEmailTextbox.Size = new System.Drawing.Size(273, 20);
            this.LEmailTextbox.TabIndex = 10;
            // 
            // Fpassbut
            // 
            this.Fpassbut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fpassbut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fpassbut.Location = new System.Drawing.Point(54, 245);
            this.Fpassbut.Name = "Fpassbut";
            this.Fpassbut.Size = new System.Drawing.Size(288, 43);
            this.Fpassbut.TabIndex = 9;
            this.Fpassbut.Text = "Reset Password";
            this.Fpassbut.UseVisualStyleBackColor = true;
            this.Fpassbut.Click += new System.EventHandler(this.Fpassbut_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.25F);
            this.label2.Location = new System.Drawing.Point(59, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Confirm New Password";
            // 
            // Fcpasstextbox
            // 
            this.Fcpasstextbox.Location = new System.Drawing.Point(62, 206);
            this.Fcpasstextbox.Name = "Fcpasstextbox";
            this.Fcpasstextbox.PasswordChar = '*';
            this.Fcpasstextbox.Size = new System.Drawing.Size(273, 20);
            this.Fcpasstextbox.TabIndex = 15;
            this.Fcpasstextbox.UseSystemPasswordChar = true;
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(383, 346);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fcpasstextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Newpasstextbox);
            this.Controls.Add(this.LEmailLabel);
            this.Controls.Add(this.LogInLabel);
            this.Controls.Add(this.LEmailTextbox);
            this.Controls.Add(this.Fpassbut);
            this.Name = "ForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.ForgotPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Newpasstextbox;
        private System.Windows.Forms.Label LEmailLabel;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.TextBox LEmailTextbox;
        private System.Windows.Forms.Button Fpassbut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fcpasstextbox;
    }
}