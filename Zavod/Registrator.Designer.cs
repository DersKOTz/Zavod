namespace Zavod
{
    partial class Registrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrator));
            this.dataSet1 = new Zavod.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RegisterFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RegisterFormTableAdapter = new Zavod.DataSet1TableAdapters.RegisterFormTableAdapter();
            this.Register = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.labRegis = new System.Windows.Forms.Label();
            this.passwordPic = new System.Windows.Forms.PictureBox();
            this.mailPic = new System.Windows.Forms.PictureBox();
            this.usernamePic = new System.Windows.Forms.PictureBox();
            this.turn = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.passwordEye = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEye)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // RegisterFormBindingSource
            // 
            this.RegisterFormBindingSource.DataMember = "RegisterForm";
            this.RegisterFormBindingSource.DataSource = this.dataSet1;
            // 
            // RegisterFormTableAdapter
            // 
            this.RegisterFormTableAdapter.ClearBeforeFill = true;
            // 
            // Register
            // 
            this.Register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Register.BackColor = System.Drawing.Color.OldLace;
            this.Register.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.Register.FlatAppearance.BorderSize = 0;
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.Location = new System.Drawing.Point(89, 251);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(207, 38);
            this.Register.TabIndex = 15;
            this.Register.TabStop = false;
            this.Register.Text = "Зарегистрироваться";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Username
            // 
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Username.Location = new System.Drawing.Point(89, 117);
            this.Username.MaxLength = 25;
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(207, 29);
            this.Username.TabIndex = 14;
            this.Username.TabStop = false;
            this.Username.Text = "Username*";
            this.Username.Leave += new System.EventHandler(this.Username_Leave);
            this.Username.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Username_MouseUp);
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Password.Location = new System.Drawing.Point(89, 187);
            this.Password.MaxLength = 25;
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(207, 29);
            this.Password.TabIndex = 13;
            this.Password.TabStop = false;
            this.Password.Text = "Password*";
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            this.Password.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Password_MouseUp);
            // 
            // Mail
            // 
            this.Mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Mail.Location = new System.Drawing.Point(89, 152);
            this.Mail.MaxLength = 25;
            this.Mail.Multiline = true;
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(207, 29);
            this.Mail.TabIndex = 12;
            this.Mail.TabStop = false;
            this.Mail.Text = "E-mail";
            this.Mail.Leave += new System.EventHandler(this.Mail_Leave);
            this.Mail.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mail_MouseUp);
            // 
            // enter
            // 
            this.enter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enter.BackColor = System.Drawing.Color.LightBlue;
            this.enter.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.enter.FlatAppearance.BorderSize = 0;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(128, 295);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(115, 38);
            this.enter.TabIndex = 20;
            this.enter.TabStop = false;
            this.enter.Text = "Войти";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // labRegis
            // 
            this.labRegis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labRegis.AutoSize = true;
            this.labRegis.BackColor = System.Drawing.Color.LightBlue;
            this.labRegis.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRegis.Location = new System.Drawing.Point(110, 47);
            this.labRegis.Name = "labRegis";
            this.labRegis.Size = new System.Drawing.Size(156, 31);
            this.labRegis.TabIndex = 21;
            this.labRegis.Text = "Регистрация";
            // 
            // passwordPic
            // 
            this.passwordPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordPic.BackColor = System.Drawing.Color.LightBlue;
            this.passwordPic.Image = global::Zavod.Properties.Resources.free_icon_padlock_494933;
            this.passwordPic.Location = new System.Drawing.Point(42, 187);
            this.passwordPic.Name = "passwordPic";
            this.passwordPic.Size = new System.Drawing.Size(41, 29);
            this.passwordPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordPic.TabIndex = 24;
            this.passwordPic.TabStop = false;
            // 
            // mailPic
            // 
            this.mailPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mailPic.BackColor = System.Drawing.Color.LightBlue;
            this.mailPic.Image = global::Zavod.Properties.Resources.free_icon_mail_646135;
            this.mailPic.Location = new System.Drawing.Point(42, 152);
            this.mailPic.Name = "mailPic";
            this.mailPic.Size = new System.Drawing.Size(41, 29);
            this.mailPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mailPic.TabIndex = 23;
            this.mailPic.TabStop = false;
            // 
            // usernamePic
            // 
            this.usernamePic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernamePic.BackColor = System.Drawing.Color.LightBlue;
            this.usernamePic.Image = global::Zavod.Properties.Resources.free_icon_avatar_6387915;
            this.usernamePic.Location = new System.Drawing.Point(42, 117);
            this.usernamePic.Name = "usernamePic";
            this.usernamePic.Size = new System.Drawing.Size(41, 29);
            this.usernamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usernamePic.TabIndex = 22;
            this.usernamePic.TabStop = false;
            // 
            // turn
            // 
            this.turn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.turn.BackColor = System.Drawing.Color.LightBlue;
            this.turn.Image = global::Zavod.Properties.Resources.free_icon_minimize_sign_6057365;
            this.turn.Location = new System.Drawing.Point(294, 8);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(37, 26);
            this.turn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.turn.TabIndex = 19;
            this.turn.TabStop = false;
            this.turn.Click += new System.EventHandler(this.turn_Click);
            this.turn.MouseEnter += new System.EventHandler(this.turn_MouseEnter);
            this.turn.MouseLeave += new System.EventHandler(this.turn_MouseLeave);
            // 
            // Close
            // 
            this.Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Close.BackColor = System.Drawing.Color.LightBlue;
            this.Close.Image = global::Zavod.Properties.Resources.free_icon_delete_cross_63694;
            this.Close.Location = new System.Drawing.Point(328, 8);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(38, 26);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 18;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // passwordEye
            // 
            this.passwordEye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordEye.BackColor = System.Drawing.Color.LightBlue;
            this.passwordEye.Image = ((System.Drawing.Image)(resources.GetObject("passwordEye.Image")));
            this.passwordEye.Location = new System.Drawing.Point(302, 187);
            this.passwordEye.Name = "passwordEye";
            this.passwordEye.Size = new System.Drawing.Size(41, 29);
            this.passwordEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordEye.TabIndex = 17;
            this.passwordEye.TabStop = false;
            this.passwordEye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passwordEye_MouseDown);
            this.passwordEye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.passwordEye_MouseUp);
            // 
            // error
            // 
            this.error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.error.BackColor = System.Drawing.Color.LightBlue;
            this.error.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.Location = new System.Drawing.Point(89, 221);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(207, 27);
            this.error.TabIndex = 25;
            this.error.Visible = false;
            // 
            // Registrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(373, 368);
            this.Controls.Add(this.error);
            this.Controls.Add(this.passwordPic);
            this.Controls.Add(this.mailPic);
            this.Controls.Add(this.usernamePic);
            this.Controls.Add(this.labRegis);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.passwordEye);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Mail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrator";
            this.Load += new System.EventHandler(this.Registrator_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registrator_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Registrator_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Registrator_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource RegisterFormBindingSource;
        private DataSet1TableAdapters.RegisterFormTableAdapter RegisterFormTableAdapter;
        private System.Windows.Forms.PictureBox turn;
        private new System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox passwordEye;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label labRegis;
        private System.Windows.Forms.PictureBox usernamePic;
        private System.Windows.Forms.PictureBox mailPic;
        private System.Windows.Forms.PictureBox passwordPic;
        private System.Windows.Forms.Label error;
    }
}