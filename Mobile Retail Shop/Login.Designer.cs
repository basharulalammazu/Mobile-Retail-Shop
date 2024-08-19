﻿namespace Mobile_Retail_Shop
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
            this.login_btn = new Guna.UI2.WinForms.Guna2Button();
            this.password_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.email_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.customer_sign_in_btn = new Guna.UI2.WinForms.Guna2Button();
            this.password_toggle_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.forgot_password = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.BorderRadius = 10;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(54, 262);
            this.login_btn.Margin = new System.Windows.Forms.Padding(5);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(320, 68);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Log in";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // password_tb
            // 
            this.password_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_tb.DefaultText = "";
            this.password_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password_tb.ForeColor = System.Drawing.Color.Black;
            this.password_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_tb.Location = new System.Drawing.Point(27, 167);
            this.password_tb.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '●';
            this.password_tb.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.password_tb.PlaceholderText = "Password";
            this.password_tb.SelectedText = "";
            this.password_tb.Size = new System.Drawing.Size(356, 54);
            this.password_tb.TabIndex = 4;
            // 
            // email_tb
            // 
            this.email_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_tb.DefaultText = "";
            this.email_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_tb.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.email_tb.ForeColor = System.Drawing.Color.Black;
            this.email_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_tb.Location = new System.Drawing.Point(27, 92);
            this.email_tb.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.email_tb.Name = "email_tb";
            this.email_tb.PasswordChar = '\0';
            this.email_tb.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.email_tb.PlaceholderText = "Email";
            this.email_tb.SelectedText = "";
            this.email_tb.Size = new System.Drawing.Size(356, 54);
            this.email_tb.TabIndex = 3;
            // 
            // customer_sign_in_btn
            // 
            this.customer_sign_in_btn.BorderRadius = 10;
            this.customer_sign_in_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customer_sign_in_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customer_sign_in_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customer_sign_in_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customer_sign_in_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customer_sign_in_btn.FillColor = System.Drawing.Color.LimeGreen;
            this.customer_sign_in_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.customer_sign_in_btn.ForeColor = System.Drawing.Color.White;
            this.customer_sign_in_btn.Location = new System.Drawing.Point(57, 382);
            this.customer_sign_in_btn.Margin = new System.Windows.Forms.Padding(5);
            this.customer_sign_in_btn.Name = "customer_sign_in_btn";
            this.customer_sign_in_btn.Size = new System.Drawing.Size(320, 68);
            this.customer_sign_in_btn.TabIndex = 5;
            this.customer_sign_in_btn.Text = "Create new account";
            this.customer_sign_in_btn.Click += new System.EventHandler(this.customer_sign_in_btn_Click);
            // 
            // password_toggle_btn
            // 
            this.password_toggle_btn.Animated = true;
            this.password_toggle_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.password_toggle_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.password_toggle_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.password_toggle_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.password_toggle_btn.FillColor = System.Drawing.Color.Transparent;
            this.password_toggle_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password_toggle_btn.ForeColor = System.Drawing.Color.White;
            this.password_toggle_btn.Image = global::Mobile_Retail_Shop.Properties.Resources.show;
            this.password_toggle_btn.Location = new System.Drawing.Point(372, 172);
            this.password_toggle_btn.Margin = new System.Windows.Forms.Padding(4);
            this.password_toggle_btn.Name = "password_toggle_btn";
            this.password_toggle_btn.Size = new System.Drawing.Size(57, 50);
            this.password_toggle_btn.TabIndex = 17;
            this.password_toggle_btn.Click += new System.EventHandler(this.password_toggle_btn_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.forgot_password);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.password_tb);
            this.guna2ShadowPanel1.Controls.Add(this.customer_sign_in_btn);
            this.guna2ShadowPanel1.Controls.Add(this.email_tb);
            this.guna2ShadowPanel1.Controls.Add(this.login_btn);
            this.guna2ShadowPanel1.Controls.Add(this.password_toggle_btn);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(579, 42);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(429, 465);
            this.guna2ShadowPanel1.TabIndex = 18;
            // 
            // forgot_password
            // 
            this.forgot_password.AutoSize = true;
            this.forgot_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgot_password.Location = new System.Drawing.Point(267, 227);
            this.forgot_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgot_password.Name = "forgot_password";
            this.forgot_password.Size = new System.Drawing.Size(116, 16);
            this.forgot_password.TabIndex = 20;
            this.forgot_password.TabStop = true;
            this.forgot_password.Text = "Forgot Password?";
            this.forgot_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgot_password_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightBlue;
            this.label2.Location = new System.Drawing.Point(108, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Welcome back. ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "-----------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "©2024 Hameem All rights reserved";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button login_btn;
        private Guna.UI2.WinForms.Guna2TextBox password_tb;
        private Guna.UI2.WinForms.Guna2TextBox email_tb;
        private Guna.UI2.WinForms.Guna2Button customer_sign_in_btn;
        private Guna.UI2.WinForms.Guna2Button password_toggle_btn;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel forgot_password;
        private System.Windows.Forms.Label label3;
    }
}

