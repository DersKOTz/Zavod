namespace Zavod.Menu
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.title = new System.Windows.Forms.Label();
            this.textPic = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textPic)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.Font = new System.Drawing.Font("Times New Roman", 25.75F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(397, 86);
            this.title.TabIndex = 0;
            this.title.Text = "Все, что нужно рабочей группе, собрано вместе";
            // 
            // textPic
            // 
            this.textPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPic.BackColor = System.Drawing.Color.LightBlue;
            this.textPic.Image = ((System.Drawing.Image)(resources.GetObject("textPic.Image")));
            this.textPic.Location = new System.Drawing.Point(298, 228);
            this.textPic.Name = "textPic";
            this.textPic.Size = new System.Drawing.Size(338, 246);
            this.textPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.textPic.TabIndex = 54;
            this.textPic.TabStop = false;
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(182)))), ((int)(((byte)(201)))));
            this.start.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Times New Roman", 14.75F);
            this.start.Location = new System.Drawing.Point(19, 287);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(191, 52);
            this.start.TabIndex = 55;
            this.start.TabStop = false;
            this.start.Text = "Начать сейчас!";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // text
            // 
            this.text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text.Font = new System.Drawing.Font("Times New Roman", 14.75F);
            this.text.Location = new System.Drawing.Point(15, 106);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(262, 132);
            this.text.TabIndex = 56;
            this.text.Text = "Ders - не просто безопасное хранилище для файлов. Это   умное рабочее пространств" +
    "о, в котором собраны рабочие   группы, инструменты и         данные.";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(648, 486);
            this.Controls.Add(this.text);
            this.Controls.Add(this.start);
            this.Controls.Add(this.textPic);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox textPic;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label text;
    }
}