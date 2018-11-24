namespace _13_11_2018
{
    partial class Form1
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgwPlaysforDate = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblFltrStad = new System.Windows.Forms.Label();
            this.lblFltrDate = new System.Windows.Forms.Label();
            this.dtpFltDate = new System.Windows.Forms.DateTimePicker();
            this.cmbFltrStad = new System.Windows.Forms.ComboBox();
            this.Btnfilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddDatabaseDatas = new System.Windows.Forms.Button();
            this.btnAddStat = new System.Windows.Forms.Button();
            this.AddPerson = new System.Windows.Forms.Button();
            this.dtpStadiumDate = new System.Windows.Forms.DateTimePicker();
            this.cmbPerson = new System.Windows.Forms.ComboBox();
            this.cmbHours = new System.Windows.Forms.ComboBox();
            this.cmbStadium = new System.Windows.Forms.ComboBox();
            this.LblPerson = new System.Windows.Forms.Label();
            this.LblHours = new System.Windows.Forms.Label();
            this.LblStadiumDate = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlaysforDate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgwPlaysforDate);
            this.panel3.Controls.Add(this.LblFltrStad);
            this.panel3.Controls.Add(this.lblFltrDate);
            this.panel3.Controls.Add(this.dtpFltDate);
            this.panel3.Controls.Add(this.cmbFltrStad);
            this.panel3.Controls.Add(this.Btnfilter);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(589, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 726);
            this.panel3.TabIndex = 1;
            // 
            // dgwPlaysforDate
            // 
            this.dgwPlaysforDate.AllowUserToAddRows = false;
            this.dgwPlaysforDate.AllowUserToDeleteRows = false;
            this.dgwPlaysforDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPlaysforDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPlaysforDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgwPlaysforDate.Location = new System.Drawing.Point(12, 148);
            this.dgwPlaysforDate.Name = "dgwPlaysforDate";
            this.dgwPlaysforDate.RowTemplate.Height = 28;
            this.dgwPlaysforDate.Size = new System.Drawing.Size(821, 563);
            this.dgwPlaysforDate.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Meydança";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Şəxs";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefon";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tarix";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Saat";
            this.Column6.Name = "Column6";
            // 
            // LblFltrStad
            // 
            this.LblFltrStad.AutoSize = true;
            this.LblFltrStad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFltrStad.Location = new System.Drawing.Point(344, 95);
            this.LblFltrStad.Name = "LblFltrStad";
            this.LblFltrStad.Size = new System.Drawing.Size(79, 25);
            this.LblFltrStad.TabIndex = 5;
            this.LblFltrStad.Text = "Stadion";
            // 
            // lblFltrDate
            // 
            this.lblFltrDate.AutoSize = true;
            this.lblFltrDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFltrDate.Location = new System.Drawing.Point(19, 94);
            this.lblFltrDate.Name = "lblFltrDate";
            this.lblFltrDate.Size = new System.Drawing.Size(56, 25);
            this.lblFltrDate.TabIndex = 4;
            this.lblFltrDate.Text = "Tarix";
            // 
            // dtpFltDate
            // 
            this.dtpFltDate.CustomFormat = "dd.MM.yyyy";
            this.dtpFltDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFltDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFltDate.Location = new System.Drawing.Point(95, 93);
            this.dtpFltDate.Name = "dtpFltDate";
            this.dtpFltDate.Size = new System.Drawing.Size(200, 30);
            this.dtpFltDate.TabIndex = 3;
            // 
            // cmbFltrStad
            // 
            this.cmbFltrStad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFltrStad.FormattingEnabled = true;
            this.cmbFltrStad.Location = new System.Drawing.Point(437, 91);
            this.cmbFltrStad.Name = "cmbFltrStad";
            this.cmbFltrStad.Size = new System.Drawing.Size(182, 33);
            this.cmbFltrStad.TabIndex = 2;
            // 
            // Btnfilter
            // 
            this.Btnfilter.Location = new System.Drawing.Point(661, 82);
            this.Btnfilter.Name = "Btnfilter";
            this.Btnfilter.Size = new System.Drawing.Size(122, 46);
            this.Btnfilter.TabIndex = 1;
            this.Btnfilter.Text = "Göstər";
            this.Btnfilter.UseVisualStyleBackColor = true;
            this.Btnfilter.Click += new System.EventHandler(this.Btnfilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oyun Cədvəli";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddDatabaseDatas);
            this.panel1.Controls.Add(this.btnAddStat);
            this.panel1.Controls.Add(this.AddPerson);
            this.panel1.Controls.Add(this.dtpStadiumDate);
            this.panel1.Controls.Add(this.cmbPerson);
            this.panel1.Controls.Add(this.cmbHours);
            this.panel1.Controls.Add(this.cmbStadium);
            this.panel1.Controls.Add(this.LblPerson);
            this.panel1.Controls.Add(this.LblHours);
            this.panel1.Controls.Add(this.LblStadiumDate);
            this.panel1.Controls.Add(this.lblStadium);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 723);
            this.panel1.TabIndex = 2;
            // 
            // AddDatabaseDatas
            // 
            this.AddDatabaseDatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDatabaseDatas.Location = new System.Drawing.Point(100, 504);
            this.AddDatabaseDatas.Name = "AddDatabaseDatas";
            this.AddDatabaseDatas.Size = new System.Drawing.Size(137, 54);
            this.AddDatabaseDatas.TabIndex = 5;
            this.AddDatabaseDatas.Text = "Tamamla";
            this.AddDatabaseDatas.UseVisualStyleBackColor = true;
            this.AddDatabaseDatas.Visible = false;
            this.AddDatabaseDatas.Click += new System.EventHandler(this.AddDatabaseDatas_Click);
            // 
            // btnAddStat
            // 
            this.btnAddStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStat.Location = new System.Drawing.Point(325, 133);
            this.btnAddStat.Name = "btnAddStat";
            this.btnAddStat.Size = new System.Drawing.Size(41, 43);
            this.btnAddStat.TabIndex = 4;
            this.btnAddStat.Text = "+";
            this.btnAddStat.UseVisualStyleBackColor = true;
            this.btnAddStat.Click += new System.EventHandler(this.btnAddStat_Click);
            // 
            // AddPerson
            // 
            this.AddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPerson.Location = new System.Drawing.Point(325, 435);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(41, 43);
            this.AddPerson.TabIndex = 4;
            this.AddPerson.Text = "+";
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Visible = false;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // dtpStadiumDate
            // 
            this.dtpStadiumDate.CustomFormat = "dd.MM.yyyy";
            this.dtpStadiumDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStadiumDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStadiumDate.Location = new System.Drawing.Point(46, 236);
            this.dtpStadiumDate.MinDate = new System.DateTime(2018, 11, 14, 0, 0, 0, 0);
            this.dtpStadiumDate.Name = "dtpStadiumDate";
            this.dtpStadiumDate.Size = new System.Drawing.Size(262, 32);
            this.dtpStadiumDate.TabIndex = 3;
            this.dtpStadiumDate.ValueChanged += new System.EventHandler(this.dtpStadiumDate_ValueChanged);
            // 
            // cmbPerson
            // 
            this.cmbPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPerson.FormattingEnabled = true;
            this.cmbPerson.Location = new System.Drawing.Point(46, 435);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(262, 34);
            this.cmbPerson.TabIndex = 2;
            this.cmbPerson.Visible = false;
            // 
            // cmbHours
            // 
            this.cmbHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHours.FormattingEnabled = true;
            this.cmbHours.Location = new System.Drawing.Point(46, 334);
            this.cmbHours.Name = "cmbHours";
            this.cmbHours.Size = new System.Drawing.Size(262, 34);
            this.cmbHours.TabIndex = 2;
            this.cmbHours.SelectedIndexChanged += new System.EventHandler(this.cmbHours_SelectedIndexChanged);
            // 
            // cmbStadium
            // 
            this.cmbStadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStadium.FormattingEnabled = true;
            this.cmbStadium.Location = new System.Drawing.Point(47, 133);
            this.cmbStadium.Name = "cmbStadium";
            this.cmbStadium.Size = new System.Drawing.Size(261, 34);
            this.cmbStadium.TabIndex = 2;
            this.cmbStadium.SelectedIndexChanged += new System.EventHandler(this.cmbStadium_SelectedIndexChanged);
            // 
            // LblPerson
            // 
            this.LblPerson.AutoSize = true;
            this.LblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPerson.Location = new System.Drawing.Point(50, 387);
            this.LblPerson.Name = "LblPerson";
            this.LblPerson.Size = new System.Drawing.Size(61, 26);
            this.LblPerson.TabIndex = 1;
            this.LblPerson.Text = "Şəxs";
            this.LblPerson.Visible = false;
            // 
            // LblHours
            // 
            this.LblHours.AutoSize = true;
            this.LblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHours.Location = new System.Drawing.Point(54, 293);
            this.LblHours.Name = "LblHours";
            this.LblHours.Size = new System.Drawing.Size(57, 26);
            this.LblHours.TabIndex = 1;
            this.LblHours.Text = "Saat";
            // 
            // LblStadiumDate
            // 
            this.LblStadiumDate.AutoSize = true;
            this.LblStadiumDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStadiumDate.Location = new System.Drawing.Point(54, 190);
            this.LblStadiumDate.Name = "LblStadiumDate";
            this.LblStadiumDate.Size = new System.Drawing.Size(59, 26);
            this.LblStadiumDate.TabIndex = 1;
            this.LblStadiumDate.Text = "Tarix";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadium.Location = new System.Drawing.Point(54, 90);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(112, 26);
            this.lblStadium.TabIndex = 1;
            this.lblStadium.Text = "Meydança";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qeydiyyat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 754);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlaysforDate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStadium;
        private System.Windows.Forms.DateTimePicker dtpStadiumDate;
        private System.Windows.Forms.ComboBox cmbPerson;
        private System.Windows.Forms.ComboBox cmbHours;
        private System.Windows.Forms.Label LblPerson;
        private System.Windows.Forms.Label LblHours;
        private System.Windows.Forms.Label LblStadiumDate;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.Button AddDatabaseDatas;
        private System.Windows.Forms.Label LblFltrStad;
        private System.Windows.Forms.Label lblFltrDate;
        private System.Windows.Forms.DateTimePicker dtpFltDate;
        private System.Windows.Forms.ComboBox cmbFltrStad;
        private System.Windows.Forms.Button Btnfilter;
        private System.Windows.Forms.DataGridView dgwPlaysforDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnAddStat;
    }
}

