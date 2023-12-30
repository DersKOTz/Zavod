namespace Zavod.Menu
{
    partial class resetPassword
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
            this.passwordPic = new System.Windows.Forms.PictureBox();
            this.newPassword2Pic = new System.Windows.Forms.PictureBox();
            this.currentPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.newPassword2 = new System.Windows.Forms.TextBox();
            this.newPasswordPic = new System.Windows.Forms.PictureBox();
            this.change = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Label();
            this.adminbutton = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassword2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordPic
            // 
            this.passwordPic.BackColor = System.Drawing.Color.LightBlue;
            this.passwordPic.Image = global::Zavod.Properties.Resources.free_icon_padlock_494933;
            this.passwordPic.Location = new System.Drawing.Point(6, 7);
            this.passwordPic.Name = "passwordPic";
            this.passwordPic.Size = new System.Drawing.Size(41, 29);
            this.passwordPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordPic.TabIndex = 40;
            this.passwordPic.TabStop = false;
            // 
            // newPassword2Pic
            // 
            this.newPassword2Pic.BackColor = System.Drawing.Color.LightBlue;
            this.newPassword2Pic.Image = global::Zavod.Properties.Resources.free_icon_eye_7615155;
            this.newPassword2Pic.Location = new System.Drawing.Point(266, 87);
            this.newPassword2Pic.Name = "newPassword2Pic";
            this.newPassword2Pic.Size = new System.Drawing.Size(41, 29);
            this.newPassword2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newPassword2Pic.TabIndex = 39;
            this.newPassword2Pic.TabStop = false;
            this.newPassword2Pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newPassword2Pic_MouseDown);
            this.newPassword2Pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.newPassword2Pic_MouseUp);
            // 
            // currentPassword
            // 
            this.currentPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.currentPassword.Location = new System.Drawing.Point(53, 7);
            this.currentPassword.MaxLength = 25;
            this.currentPassword.Multiline = true;
            this.currentPassword.Name = "currentPassword";
            this.currentPassword.Size = new System.Drawing.Size(207, 29);
            this.currentPassword.TabIndex = 38;
            this.currentPassword.TabStop = false;
            this.currentPassword.Text = "Текущий пароль";
            this.currentPassword.Leave += new System.EventHandler(this.currentPassword_Leave);
            this.currentPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.currentPassword_MouseUp);
            // 
            // newPassword
            // 
            this.newPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.newPassword.Location = new System.Drawing.Point(53, 52);
            this.newPassword.MaxLength = 25;
            this.newPassword.Multiline = true;
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(207, 29);
            this.newPassword.TabIndex = 41;
            this.newPassword.TabStop = false;
            this.newPassword.Text = "Новый пароль";
            this.newPassword.Leave += new System.EventHandler(this.newPassword_Leave);
            this.newPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.newPassword_MouseUp);
            // 
            // newPassword2
            // 
            this.newPassword2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.newPassword2.Location = new System.Drawing.Point(53, 87);
            this.newPassword2.MaxLength = 25;
            this.newPassword2.Multiline = true;
            this.newPassword2.Name = "newPassword2";
            this.newPassword2.Size = new System.Drawing.Size(207, 29);
            this.newPassword2.TabIndex = 43;
            this.newPassword2.TabStop = false;
            this.newPassword2.Text = "Новый пароль еще раз";
            this.newPassword2.Leave += new System.EventHandler(this.newPassword2_Leave);
            this.newPassword2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.newPassword2_MouseUp);
            // 
            // newPasswordPic
            // 
            this.newPasswordPic.BackColor = System.Drawing.Color.LightBlue;
            this.newPasswordPic.Image = global::Zavod.Properties.Resources.free_icon_eye_7615155;
            this.newPasswordPic.Location = new System.Drawing.Point(266, 52);
            this.newPasswordPic.Name = "newPasswordPic";
            this.newPasswordPic.Size = new System.Drawing.Size(41, 29);
            this.newPasswordPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newPasswordPic.TabIndex = 45;
            this.newPasswordPic.TabStop = false;
            this.newPasswordPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newPasswordPic_MouseDown);
            this.newPasswordPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.newPasswordPic_MouseUp);
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(182)))), ((int)(((byte)(201)))));
            this.change.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.change.FlatAppearance.BorderSize = 0;
            this.change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.change.Location = new System.Drawing.Point(78, 126);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(150, 45);
            this.change.TabIndex = 48;
            this.change.TabStop = false;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // settings
            // 
            this.settings.Font = new System.Drawing.Font("Times New Roman", 25.75F, System.Drawing.FontStyle.Bold);
            this.settings.Location = new System.Drawing.Point(12, 9);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(329, 42);
            this.settings.TabIndex = 49;
            this.settings.Text = "Настройки";
            // 
            // adminbutton
            // 
            this.adminbutton.AutoSize = true;
            this.adminbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.adminbutton.Location = new System.Drawing.Point(6, 42);
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.Size = new System.Drawing.Size(101, 24);
            this.adminbutton.TabIndex = 60;
            this.adminbutton.Text = "Вкл/Выкл";
            this.adminbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminbutton.UseVisualStyleBackColor = false;
            this.adminbutton.CheckedChanged += new System.EventHandler(this.admin_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.75F);
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 61;
            this.label1.Text = "Поиск по:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox1.Location = new System.Drawing.Point(18, 98);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 24);
            this.checkBox1.TabIndex = 62;
            this.checkBox1.Text = "Фамилия";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox2.Location = new System.Drawing.Point(18, 128);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 24);
            this.checkBox2.TabIndex = 63;
            this.checkBox2.Text = "Группа";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.75F);
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 30);
            this.label2.TabIndex = 64;
            this.label2.Text = "Режим администратора";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(182)))), ((int)(((byte)(201)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button1.Location = new System.Drawing.Point(14, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 31);
            this.button1.TabIndex = 65;
            this.button1.TabStop = false;
            this.button1.Text = "Изменить пароль";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentPassword);
            this.panel1.Controls.Add(this.newPassword2Pic);
            this.panel1.Controls.Add(this.passwordPic);
            this.panel1.Controls.Add(this.newPassword);
            this.panel1.Controls.Add(this.newPassword2);
            this.panel1.Controls.Add(this.newPasswordPic);
            this.panel1.Controls.Add(this.change);
            this.panel1.Location = new System.Drawing.Point(5, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 177);
            this.panel1.TabIndex = 66;
            this.panel1.Visible = false;
            // 
            // admin
            // 
            this.admin.Controls.Add(this.label2);
            this.admin.Controls.Add(this.adminbutton);
            this.admin.Location = new System.Drawing.Point(399, 397);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(237, 77);
            this.admin.TabIndex = 67;
            // 
            // resetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(648, 486);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "resetPassword";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.resetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassword2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.admin.ResumeLayout(false);
            this.admin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox passwordPic;
        private System.Windows.Forms.PictureBox newPassword2Pic;
        private System.Windows.Forms.TextBox currentPassword;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox newPassword2;
        private System.Windows.Forms.PictureBox newPasswordPic;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Label settings;
        private System.Windows.Forms.CheckBox adminbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel admin;
    }
}