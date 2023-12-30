namespace Zavod.Menu
{
    partial class User
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
            this.welcomeText = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.Button();
            this.savePeople = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.CheckBox();
            this.teacher = new System.Windows.Forms.CheckBox();
            this.name3 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.name1 = new System.Windows.Forms.TextBox();
            this.numberPhonePic = new System.Windows.Forms.PictureBox();
            this.passwordPic = new System.Windows.Forms.PictureBox();
            this.passwordEye = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.post = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberPhonePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.Font = new System.Drawing.Font("Times New Roman", 25.75F, System.Drawing.FontStyle.Bold);
            this.welcomeText.Location = new System.Drawing.Point(16, 11);
            this.welcomeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(439, 52);
            this.welcomeText.TabIndex = 2;
            this.welcomeText.Text = "Личный кабинет";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.password.Location = new System.Drawing.Point(68, 412);
            this.password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password.MaxLength = 25;
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(275, 35);
            this.password.TabIndex = 38;
            this.password.TabStop = false;
            this.password.Text = "Password*";
            this.password.Leave += new System.EventHandler(this.password_Leave);
            this.password.MouseUp += new System.Windows.Forms.MouseEventHandler(this.password_MouseUp);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.LightBlue;
            this.text.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.text.FlatAppearance.BorderSize = 0;
            this.text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.text.Location = new System.Drawing.Point(68, 306);
            this.text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(36, 48);
            this.text.TabIndex = 57;
            this.text.TabStop = false;
            this.text.Text = "Я";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.text.UseVisualStyleBackColor = false;
            // 
            // savePeople
            // 
            this.savePeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(182)))), ((int)(((byte)(201)))));
            this.savePeople.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.savePeople.FlatAppearance.BorderSize = 0;
            this.savePeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePeople.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.savePeople.Location = new System.Drawing.Point(112, 455);
            this.savePeople.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savePeople.Name = "savePeople";
            this.savePeople.Size = new System.Drawing.Size(187, 48);
            this.savePeople.TabIndex = 58;
            this.savePeople.TabStop = false;
            this.savePeople.Text = "Сохранить";
            this.savePeople.UseVisualStyleBackColor = false;
            this.savePeople.Click += new System.EventHandler(this.savePeople_Click);
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Location = new System.Drawing.Point(112, 306);
            this.student.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(84, 20);
            this.student.TabIndex = 59;
            this.student.Text = "Студент";
            this.student.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.student.UseVisualStyleBackColor = true;
            this.student.CheckedChanged += new System.EventHandler(this.student_CheckedChanged);
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Location = new System.Drawing.Point(112, 335);
            this.teacher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(133, 20);
            this.teacher.TabIndex = 60;
            this.teacher.Text = "Преподаватель";
            this.teacher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.teacher.UseVisualStyleBackColor = true;
            this.teacher.CheckedChanged += new System.EventHandler(this.teacher_CheckedChanged);
            // 
            // name3
            // 
            this.name3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.name3.Location = new System.Drawing.Point(68, 215);
            this.name3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name3.MaxLength = 25;
            this.name3.Multiline = true;
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(275, 35);
            this.name3.TabIndex = 63;
            this.name3.TabStop = false;
            this.name3.Text = "Отчество";
            this.name3.Leave += new System.EventHandler(this.name3_Leave);
            this.name3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.name3_MouseUp);
            // 
            // name2
            // 
            this.name2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.name2.Location = new System.Drawing.Point(68, 172);
            this.name2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name2.MaxLength = 25;
            this.name2.Multiline = true;
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(275, 35);
            this.name2.TabIndex = 64;
            this.name2.TabStop = false;
            this.name2.Text = "Имя*";
            this.name2.Leave += new System.EventHandler(this.name2_Leave);
            this.name2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.name2_MouseUp);
            // 
            // name1
            // 
            this.name1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.name1.Location = new System.Drawing.Point(68, 129);
            this.name1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name1.MaxLength = 25;
            this.name1.Multiline = true;
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(275, 35);
            this.name1.TabIndex = 65;
            this.name1.TabStop = false;
            this.name1.Text = "Фамилия*";
            this.name1.Leave += new System.EventHandler(this.name1_Leave);
            this.name1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.name1_MouseUp);
            // 
            // numberPhonePic
            // 
            this.numberPhonePic.BackColor = System.Drawing.Color.LightBlue;
            this.numberPhonePic.Image = global::Zavod.Properties.Resources.free_icon_telephone_receiver_70677;
            this.numberPhonePic.Location = new System.Drawing.Point(5, 258);
            this.numberPhonePic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberPhonePic.Name = "numberPhonePic";
            this.numberPhonePic.Size = new System.Drawing.Size(55, 36);
            this.numberPhonePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.numberPhonePic.TabIndex = 61;
            this.numberPhonePic.TabStop = false;
            // 
            // passwordPic
            // 
            this.passwordPic.BackColor = System.Drawing.Color.LightBlue;
            this.passwordPic.Image = global::Zavod.Properties.Resources.free_icon_padlock_494933;
            this.passwordPic.Location = new System.Drawing.Point(5, 412);
            this.passwordPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordPic.Name = "passwordPic";
            this.passwordPic.Size = new System.Drawing.Size(55, 36);
            this.passwordPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordPic.TabIndex = 40;
            this.passwordPic.TabStop = false;
            // 
            // passwordEye
            // 
            this.passwordEye.BackColor = System.Drawing.Color.LightBlue;
            this.passwordEye.Image = global::Zavod.Properties.Resources.free_icon_eye_7615155;
            this.passwordEye.Location = new System.Drawing.Point(352, 412);
            this.passwordEye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordEye.Name = "passwordEye";
            this.passwordEye.Size = new System.Drawing.Size(55, 36);
            this.passwordEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordEye.TabIndex = 39;
            this.passwordEye.TabStop = false;
            this.passwordEye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passwordEye_MouseDown);
            this.passwordEye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.passwordEye_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox1.Image = global::Zavod.Properties.Resources.free_icon_avatar_6387915;
            this.pictureBox1.Location = new System.Drawing.Point(5, 129);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // post
            // 
            this.post.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.post.Location = new System.Drawing.Point(68, 369);
            this.post.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.post.MaxLength = 25;
            this.post.Multiline = true;
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(275, 35);
            this.post.TabIndex = 67;
            this.post.TabStop = false;
            this.post.Text = "Должность";
            this.post.Visible = false;
            this.post.Leave += new System.EventHandler(this.post_Leave);
            this.post.MouseUp += new System.Windows.Forms.MouseEventHandler(this.post_MouseUp);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.number.Location = new System.Drawing.Point(68, 258);
            this.number.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number.MaxLength = 25;
            this.number.Multiline = true;
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(275, 35);
            this.number.TabIndex = 68;
            this.number.TabStop = false;
            this.number.Text = "Номер телефона";
            this.number.Leave += new System.EventHandler(this.number_Leave);
            this.number.MouseUp += new System.Windows.Forms.MouseEventHandler(this.number_MouseUp);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(864, 598);
            this.Controls.Add(this.number);
            this.Controls.Add(this.post);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.numberPhonePic);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.student);
            this.Controls.Add(this.savePeople);
            this.Controls.Add(this.text);
            this.Controls.Add(this.passwordPic);
            this.Controls.Add(this.passwordEye);
            this.Controls.Add(this.password);
            this.Controls.Add(this.welcomeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "User";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberPhonePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.PictureBox passwordPic;
        private System.Windows.Forms.PictureBox passwordEye;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button text;
        private System.Windows.Forms.Button savePeople;
        private System.Windows.Forms.CheckBox student;
        private System.Windows.Forms.CheckBox teacher;
        private System.Windows.Forms.PictureBox numberPhonePic;
        private System.Windows.Forms.TextBox name3;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox post;
        private System.Windows.Forms.TextBox number;
    }
}