namespace Zavod.Menu
{
    partial class Administration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSet1 = new Zavod.DataSet1();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTableAdapter = new Zavod.DataSet1TableAdapters.PeopleTableAdapter();
            this.save = new System.Windows.Forms.Button();
            this.passwordPic = new System.Windows.Forms.PictureBox();
            this.currentPassword = new System.Windows.Forms.TextBox();
            this.peopleRegisterFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerFormTableAdapter = new Zavod.DataSet1TableAdapters.RegisterFormTableAdapter();
            this.peopleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.студентDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.преподавательDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пРОВЕРКАDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleRegisterFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.dataSet1;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(182)))), ((int)(((byte)(201)))));
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.save.Location = new System.Drawing.Point(499, 418);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 33);
            this.save.TabIndex = 77;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // passwordPic
            // 
            this.passwordPic.BackColor = System.Drawing.Color.LightBlue;
            this.passwordPic.Image = global::Zavod.Properties.Resources.free_icon_padlock_494933;
            this.passwordPic.Location = new System.Drawing.Point(232, 420);
            this.passwordPic.Name = "passwordPic";
            this.passwordPic.Size = new System.Drawing.Size(41, 29);
            this.passwordPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordPic.TabIndex = 79;
            this.passwordPic.TabStop = false;
            // 
            // currentPassword
            // 
            this.currentPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.currentPassword.Location = new System.Drawing.Point(278, 420);
            this.currentPassword.MaxLength = 25;
            this.currentPassword.Multiline = true;
            this.currentPassword.Name = "currentPassword";
            this.currentPassword.Size = new System.Drawing.Size(207, 29);
            this.currentPassword.TabIndex = 78;
            this.currentPassword.TabStop = false;
            this.currentPassword.Text = "Текущий пароль";
            this.currentPassword.Leave += new System.EventHandler(this.currentPassword_Leave);
            this.currentPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.currentPassword_MouseUp);
            // 
            // peopleRegisterFormBindingSource
            // 
            this.peopleRegisterFormBindingSource.DataMember = "People_RegisterForm";
            this.peopleRegisterFormBindingSource.DataSource = this.peopleBindingSource;
            // 
            // registerFormTableAdapter
            // 
            this.registerFormTableAdapter.ClearBeforeFill = true;
            // 
            // peopleBindingSource1
            // 
            this.peopleBindingSource1.DataMember = "People";
            this.peopleBindingSource1.DataSource = this.dataSet1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxSearch.Location = new System.Drawing.Point(12, 20);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(158, 27);
            this.textBoxSearch.TabIndex = 81;
            // 
            // search
            // 
            this.search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(182)))), ((int)(((byte)(201)))));
            this.search.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.search.Location = new System.Drawing.Point(176, 14);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(140, 33);
            this.search.TabIndex = 82;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(197)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(197)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.студентDataGridViewCheckBoxColumn,
            this.группаDataGridViewTextBoxColumn,
            this.преподавательDataGridViewCheckBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.пРОВЕРКАDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.peopleBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(11, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 351);
            this.dataGridView1.TabIndex = 271;
            this.dataGridView1.TabStop = false;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 80;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "НомерТелефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "НомерТелефона";
            this.номерТелефонаDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            this.номерТелефонаDataGridViewTextBoxColumn.Width = 125;
            // 
            // студентDataGridViewCheckBoxColumn
            // 
            this.студентDataGridViewCheckBoxColumn.DataPropertyName = "Студент";
            this.студентDataGridViewCheckBoxColumn.HeaderText = "Студент";
            this.студентDataGridViewCheckBoxColumn.Name = "студентDataGridViewCheckBoxColumn";
            // 
            // группаDataGridViewTextBoxColumn
            // 
            this.группаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.группаDataGridViewTextBoxColumn.DataPropertyName = "Группа";
            this.группаDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.группаDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.группаDataGridViewTextBoxColumn.Name = "группаDataGridViewTextBoxColumn";
            // 
            // преподавательDataGridViewCheckBoxColumn
            // 
            this.преподавательDataGridViewCheckBoxColumn.DataPropertyName = "Преподаватель";
            this.преподавательDataGridViewCheckBoxColumn.HeaderText = "Преподаватель";
            this.преподавательDataGridViewCheckBoxColumn.Name = "преподавательDataGridViewCheckBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // пРОВЕРКАDataGridViewCheckBoxColumn
            // 
            this.пРОВЕРКАDataGridViewCheckBoxColumn.DataPropertyName = "ПРОВЕРКА";
            this.пРОВЕРКАDataGridViewCheckBoxColumn.HeaderText = "ПРОВЕРКА";
            this.пРОВЕРКАDataGridViewCheckBoxColumn.Name = "пРОВЕРКАDataGridViewCheckBoxColumn";
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(648, 486);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.passwordPic);
            this.Controls.Add(this.currentPassword);
            this.Controls.Add(this.save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administration";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Administration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleRegisterFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private DataSet1TableAdapters.PeopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.PictureBox passwordPic;
        private System.Windows.Forms.TextBox currentPassword;
        private System.Windows.Forms.BindingSource peopleRegisterFormBindingSource;
        private DataSet1TableAdapters.RegisterFormTableAdapter registerFormTableAdapter;
        private System.Windows.Forms.BindingSource peopleBindingSource1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn студентDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn преподавательDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn пРОВЕРКАDataGridViewCheckBoxColumn;
    }
}