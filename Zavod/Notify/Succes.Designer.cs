namespace Zavod
{
    partial class Succes
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
            this.error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.error.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.error.FlatAppearance.BorderSize = 0;
            this.error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.error.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.error.ForeColor = System.Drawing.Color.Black;
            this.error.Location = new System.Drawing.Point(56, 14);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(298, 49);
            this.error.TabIndex = 47;
            this.error.TabStop = false;
            this.error.Text = "Регистрация успешна!";
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
            this.close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.close.Image = global::Zavod.Properties.Resources.free_icon_cross_sign_4653743;
            this.close.Location = new System.Drawing.Point(360, 14);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(55, 49);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 49;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // errorPic
            // 
            this.errorPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.errorPic.Image = global::Zavod.Properties.Resources.free_icon_tick_mark_665939;
            this.errorPic.Location = new System.Drawing.Point(-1, 14);
            this.errorPic.Name = "errorPic";
            this.errorPic.Size = new System.Drawing.Size(55, 49);
            this.errorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.errorPic.TabIndex = 48;
            this.errorPic.TabStop = false;
            // 
            // Succes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(417, 75);
            this.ControlBox = false;
            this.Controls.Add(this.close);
            this.Controls.Add(this.errorPic);
            this.Controls.Add(this.error);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Succes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notification";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Succes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox errorPic;
        public System.Windows.Forms.Button error;
    }
}