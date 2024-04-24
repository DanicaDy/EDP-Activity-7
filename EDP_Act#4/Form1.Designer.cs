namespace EDP_Act_4
{
    partial class LogIn
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
            this.logInButton = new System.Windows.Forms.Button();
            this.LEmailTextbox = new System.Windows.Forms.TextBox();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.LEmailLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.fpassLinkL = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SignUplinklabel = new System.Windows.Forms.LinkLabel();
            this.RememberMe = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // logInButton
            // 
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(35, 202);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(280, 43);
            this.logInButton.TabIndex = 0;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // LEmailTextbox
            // 
            this.LEmailTextbox.Location = new System.Drawing.Point(42, 91);
            this.LEmailTextbox.Name = "LEmailTextbox";
            this.LEmailTextbox.Size = new System.Drawing.Size(273, 20);
            this.LEmailTextbox.TabIndex = 1;
            this.LEmailTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLabel.Location = new System.Drawing.Point(118, 19);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(111, 40);
            this.LogInLabel.TabIndex = 2;
            this.LogInLabel.Text = "Log In";
            this.LogInLabel.Click += new System.EventHandler(this.LogInLabel_Click);
            // 
            // LEmailLabel
            // 
            this.LEmailLabel.AutoSize = true;
            this.LEmailLabel.Font = new System.Drawing.Font("Arial", 10.25F);
            this.LEmailLabel.Location = new System.Drawing.Point(39, 72);
            this.LEmailLabel.Name = "LEmailLabel";
            this.LEmailLabel.Size = new System.Drawing.Size(41, 16);
            this.LEmailLabel.TabIndex = 3;
            this.LEmailLabel.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.25F);
            this.label1.Location = new System.Drawing.Point(39, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(42, 136);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.Size = new System.Drawing.Size(273, 20);
            this.passwordtextbox.TabIndex = 4;
            this.passwordtextbox.UseSystemPasswordChar = true;
            this.passwordtextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fpassLinkL
            // 
            this.fpassLinkL.AutoSize = true;
            this.fpassLinkL.Location = new System.Drawing.Point(212, 169);
            this.fpassLinkL.Name = "fpassLinkL";
            this.fpassLinkL.Size = new System.Drawing.Size(92, 13);
            this.fpassLinkL.TabIndex = 6;
            this.fpassLinkL.TabStop = true;
            this.fpassLinkL.Text = "Forgot Password?";
            this.fpassLinkL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fpassLinkL_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Don\'t have Account?";
            // 
            // SignUplinklabel
            // 
            this.SignUplinklabel.AutoSize = true;
            this.SignUplinklabel.Location = new System.Drawing.Point(196, 266);
            this.SignUplinklabel.Name = "SignUplinklabel";
            this.SignUplinklabel.Size = new System.Drawing.Size(45, 13);
            this.SignUplinklabel.TabIndex = 8;
            this.SignUplinklabel.TabStop = true;
            this.SignUplinklabel.Text = "Sign Up";
            this.SignUplinklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUplinklabel_LinkClicked);
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.Location = new System.Drawing.Point(54, 168);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(95, 17);
            this.RememberMe.TabIndex = 9;
            this.RememberMe.Text = "Remember Me";
            this.RememberMe.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(349, 351);
            this.Controls.Add(this.RememberMe);
            this.Controls.Add(this.SignUplinklabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fpassLinkL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.LEmailLabel);
            this.Controls.Add(this.LogInLabel);
            this.Controls.Add(this.LEmailTextbox);
            this.Controls.Add(this.logInButton);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.TextBox LEmailTextbox;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.Label LEmailLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.LinkLabel fpassLinkL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel SignUplinklabel;
        private System.Windows.Forms.CheckBox RememberMe;
    }
}

