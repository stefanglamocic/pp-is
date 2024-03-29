﻿
namespace JPPP
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblThemeDark = new System.Windows.Forms.Label();
            this.lblThemeLight = new System.Windows.Forms.Label();
            this.lblThemePop = new System.Windows.Forms.Label();
            this.pbSrb = new System.Windows.Forms.PictureBox();
            this.pbUK = new System.Windows.Forms.PictureBox();
            this.pnlContainerSrb = new System.Windows.Forms.Panel();
            this.pnlContainerUK = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSrb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUK)).BeginInit();
            this.pnlContainerSrb.SuspendLayout();
            this.pnlContainerUK.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTop
            // 
            this.lblTop.Text = "Prijavite se na sistem";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnMaximize.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserName.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbUserName.Location = new System.Drawing.Point(33, 189);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(295, 28);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Text = "Korisničko Ime";
            this.tbUserName.Enter += new System.EventHandler(this.tbUserName_Enter);
            this.tbUserName.Leave += new System.EventHandler(this.tbUserName_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPassword.Location = new System.Drawing.Point(33, 240);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(295, 28);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "Lozinka";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(73)))), ((int)(((byte)(23)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(209)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(33, 326);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(295, 47);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Prijavite se";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::JPPP.Properties.Resources.LogoJPPGP;
            this.pbLogo.Location = new System.Drawing.Point(112, 44);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(142, 117);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // lblThemeDark
            // 
            this.lblThemeDark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThemeDark.AutoSize = true;
            this.lblThemeDark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblThemeDark.ForeColor = System.Drawing.SystemColors.Info;
            this.lblThemeDark.Location = new System.Drawing.Point(81, 475);
            this.lblThemeDark.Name = "lblThemeDark";
            this.lblThemeDark.Size = new System.Drawing.Size(30, 13);
            this.lblThemeDark.TabIndex = 5;
            this.lblThemeDark.Text = "Dark";
            this.lblThemeDark.Click += new System.EventHandler(this.lblThemeDark_Click);
            // 
            // lblThemeLight
            // 
            this.lblThemeLight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThemeLight.AutoSize = true;
            this.lblThemeLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblThemeLight.ForeColor = System.Drawing.SystemColors.Info;
            this.lblThemeLight.Location = new System.Drawing.Point(245, 475);
            this.lblThemeLight.Name = "lblThemeLight";
            this.lblThemeLight.Size = new System.Drawing.Size(30, 13);
            this.lblThemeLight.TabIndex = 6;
            this.lblThemeLight.Text = "Light";
            this.lblThemeLight.Click += new System.EventHandler(this.lblThemeLight_Click);
            // 
            // lblThemePop
            // 
            this.lblThemePop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThemePop.AutoSize = true;
            this.lblThemePop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblThemePop.ForeColor = System.Drawing.SystemColors.Info;
            this.lblThemePop.Location = new System.Drawing.Point(165, 475);
            this.lblThemePop.Name = "lblThemePop";
            this.lblThemePop.Size = new System.Drawing.Size(26, 13);
            this.lblThemePop.TabIndex = 7;
            this.lblThemePop.Text = "Pop";
            this.lblThemePop.Click += new System.EventHandler(this.lblThemePop_Click);
            // 
            // pbSrb
            // 
            this.pbSrb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSrb.Image = global::JPPP.Properties.Resources.srb;
            this.pbSrb.Location = new System.Drawing.Point(2, 2);
            this.pbSrb.Name = "pbSrb";
            this.pbSrb.Size = new System.Drawing.Size(30, 20);
            this.pbSrb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSrb.TabIndex = 8;
            this.pbSrb.TabStop = false;
            this.pbSrb.Click += new System.EventHandler(this.pbSrb_Click);
            // 
            // pbUK
            // 
            this.pbUK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUK.Image = global::JPPP.Properties.Resources.uk;
            this.pbUK.Location = new System.Drawing.Point(2, 2);
            this.pbUK.Name = "pbUK";
            this.pbUK.Size = new System.Drawing.Size(30, 20);
            this.pbUK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUK.TabIndex = 9;
            this.pbUK.TabStop = false;
            this.pbUK.Click += new System.EventHandler(this.pbUK_Click);
            // 
            // pnlContainerSrb
            // 
            this.pnlContainerSrb.Controls.Add(this.pbSrb);
            this.pnlContainerSrb.Location = new System.Drawing.Point(127, 427);
            this.pnlContainerSrb.Name = "pnlContainerSrb";
            this.pnlContainerSrb.Size = new System.Drawing.Size(34, 24);
            this.pnlContainerSrb.TabIndex = 10;
            // 
            // pnlContainerUK
            // 
            this.pnlContainerUK.Controls.Add(this.pbUK);
            this.pnlContainerUK.Location = new System.Drawing.Point(192, 427);
            this.pnlContainerUK.Name = "pnlContainerUK";
            this.pnlContainerUK.Size = new System.Drawing.Size(34, 24);
            this.pnlContainerUK.TabIndex = 11;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(375, 511);
            this.Controls.Add(this.pnlContainerUK);
            this.Controls.Add(this.pnlContainerSrb);
            this.Controls.Add(this.lblThemePop);
            this.Controls.Add(this.lblThemeLight);
            this.Controls.Add(this.lblThemeDark);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.tbUserName, 0);
            this.Controls.SetChildIndex(this.tbPassword, 0);
            this.Controls.SetChildIndex(this.btnLogin, 0);
            this.Controls.SetChildIndex(this.pbLogo, 0);
            this.Controls.SetChildIndex(this.lblThemeDark, 0);
            this.Controls.SetChildIndex(this.lblThemeLight, 0);
            this.Controls.SetChildIndex(this.lblThemePop, 0);
            this.Controls.SetChildIndex(this.pnlContainerSrb, 0);
            this.Controls.SetChildIndex(this.pnlContainerUK, 0);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSrb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUK)).EndInit();
            this.pnlContainerSrb.ResumeLayout(false);
            this.pnlContainerUK.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblThemeDark;
        private System.Windows.Forms.Label lblThemeLight;
        private System.Windows.Forms.Label lblThemePop;
        private System.Windows.Forms.PictureBox pbSrb;
        private System.Windows.Forms.PictureBox pbUK;
        private System.Windows.Forms.Panel pnlContainerSrb;
        private System.Windows.Forms.Panel pnlContainerUK;
    }
}