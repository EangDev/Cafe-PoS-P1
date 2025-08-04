namespace Cafe_PoS
{
    partial class Login
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPasswordIN = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.Label();
            this.txtUsernameIN = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.Label();
            this.BG = new System.Windows.Forms.PictureBox();
            this.btnExit = new Cafe_PoS.Resources.RJButton();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BG)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.btnExit);
            this.MainPanel.Controls.Add(this.btnSignUp);
            this.MainPanel.Controls.Add(this.btnLogin);
            this.MainPanel.Controls.Add(this.txtPasswordIN);
            this.MainPanel.Controls.Add(this.txtPassword);
            this.MainPanel.Controls.Add(this.txtUsernameIN);
            this.MainPanel.Controls.Add(this.txtUsername);
            this.MainPanel.Controls.Add(this.txtPos);
            this.MainPanel.Controls.Add(this.BG);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 550);
            this.MainPanel.TabIndex = 0;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Noto Sans SC", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(28, 477);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(250, 70);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign Up!";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(120)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Noto Sans SC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(28, 404);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(250, 70);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // txtPasswordIN
            // 
            this.txtPasswordIN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPasswordIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.txtPasswordIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordIN.Font = new System.Drawing.Font("Noto Sans SC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordIN.ForeColor = System.Drawing.Color.White;
            this.txtPasswordIN.Location = new System.Drawing.Point(28, 321);
            this.txtPasswordIN.MaxLength = 8;
            this.txtPasswordIN.Name = "txtPasswordIN";
            this.txtPasswordIN.PasswordChar = '*';
            this.txtPasswordIN.Size = new System.Drawing.Size(347, 39);
            this.txtPasswordIN.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.AutoSize = true;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.txtPassword.Font = new System.Drawing.Font("Noto Sans SC", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(28, 264);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 49);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsernameIN
            // 
            this.txtUsernameIN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsernameIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.txtUsernameIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernameIN.Font = new System.Drawing.Font("Noto Sans SC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsernameIN.Location = new System.Drawing.Point(28, 201);
            this.txtUsernameIN.MaxLength = 250;
            this.txtUsernameIN.Name = "txtUsernameIN";
            this.txtUsernameIN.Size = new System.Drawing.Size(347, 39);
            this.txtUsernameIN.TabIndex = 2;
            this.txtUsernameIN.Text = "Admin123";
            this.txtUsernameIN.TextChanged += new System.EventHandler(this.txtUsernameIN_TextChanged);
            this.txtUsernameIN.Enter += new System.EventHandler(this.txtUsernameIN_TextChanged);
            this.txtUsernameIN.Leave += new System.EventHandler(this.txtUsernameIN_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.AutoSize = true;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.txtUsername.Font = new System.Drawing.Font("Noto Sans SC", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(28, 143);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(194, 49);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPos
            // 
            this.txtPos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPos.AutoSize = true;
            this.txtPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.txtPos.Font = new System.Drawing.Font("Noto Sans SC", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPos.ForeColor = System.Drawing.Color.White;
            this.txtPos.Location = new System.Drawing.Point(219, 12);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(309, 79);
            this.txtPos.TabIndex = 1;
            this.txtPos.Text = "Rests-POS";
            this.txtPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BG
            // 
            this.BG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BG.Image = global::Cafe_PoS.Properties.Resources.Cafe_LoginBG1;
            this.BG.Location = new System.Drawing.Point(0, 0);
            this.BG.Name = "BG";
            this.BG.Size = new System.Drawing.Size(800, 550);
            this.BG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BG.TabIndex = 0;
            this.BG.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(112)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::Cafe_PoS.Properties.Resources.switch_off1;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox BG;
        private System.Windows.Forms.Label txtPos;
        private System.Windows.Forms.TextBox txtPasswordIN;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.TextBox txtUsernameIN;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private Resources.RJButton btnExit;
    }
}

