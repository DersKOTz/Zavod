namespace Zavod.Menu
{
    partial class Notification
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
            this.error = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.close = new System.Windows.Forms.PictureBox();
            this.errorPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPic)).BeginInit();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(29)))));
            this.error.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.error.FlatAppearance.BorderSize = 0;
            this.error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.error.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.error.ForeColor = System.Drawing.Color.Black;
            this.error.Location = new System.Drawing.Point(56, 16);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(288, 41);
            this.error.TabIndex = 50;
            this.error.TabStop = false;
            this.error.Text = "Введите имя";
            this.error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.error.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 7000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(29)))));
            this.close.Image = global::Zavod.Properties.Resources.free_icon_cross_sign_4653743;
            this.close.Location = new System.Drawing.Point(444, 13);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(55, 49);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 52;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // errorPic
            // 
            this.errorPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(29)))));
            this.errorPic.Image = global::Zavod.Properties.Resources.free_icon_warning_3756663;
            this.errorPic.Location = new System.Drawing.Point(0, 13);
            this.errorPic.Name = "errorPic";
            this.errorPic.Size = new System.Drawing.Size(55, 49);
            this.errorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.errorPic.TabIndex = 51;
            this.errorPic.TabStop = false;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(505, 75);
            this.ControlBox = false;
            this.Controls.Add(this.close);
            this.Controls.Add(this.errorPic);
            this.Controls.Add(this.error);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox close;
        public System.Windows.Forms.PictureBox errorPic;
        public System.Windows.Forms.Button error;
        private System.Windows.Forms.Timer timer1;
    }
}