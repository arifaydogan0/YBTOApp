namespace App.Forms
{
    partial class FormAnasayfa
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxUniteler = new System.Windows.Forms.ListBox();
            this.buttonYeniUniteEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHastaListesi = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yaş = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHastaListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(317, 3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(600, 46);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "YOĞUN BAKIM TAKİP UYGULAMASI";
            // 
            // listBoxUniteler
            // 
            this.listBoxUniteler.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxUniteler.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxUniteler.FormattingEnabled = true;
            this.listBoxUniteler.ItemHeight = 23;
            this.listBoxUniteler.Items.AddRange(new object[] {
            "Yoğun Bakım Ünitesi 1",
            "Yoğun Bakım Ünitesi 2",
            "Yoğun Bakım Ünitesi 3",
            "Yoğun Bakım Ünitesi 4",
            "Yoğun Bakım Ünitesi 5"});
            this.listBoxUniteler.Location = new System.Drawing.Point(12, 83);
            this.listBoxUniteler.Name = "listBoxUniteler";
            this.listBoxUniteler.Size = new System.Drawing.Size(195, 142);
            this.listBoxUniteler.TabIndex = 1;
            this.listBoxUniteler.SelectedIndexChanged += new System.EventHandler(this.listBoxUniteler_SelectedIndexChanged);
            // 
            // buttonYeniUniteEkle
            // 
            this.buttonYeniUniteEkle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonYeniUniteEkle.Location = new System.Drawing.Point(12, 236);
            this.buttonYeniUniteEkle.Name = "buttonYeniUniteEkle";
            this.buttonYeniUniteEkle.Size = new System.Drawing.Size(195, 50);
            this.buttonYeniUniteEkle.TabIndex = 2;
            this.buttonYeniUniteEkle.Text = "Yeni Ünite Ekle";
            this.buttonYeniUniteEkle.UseVisualStyleBackColor = true;
            this.buttonYeniUniteEkle.Click += new System.EventHandler(this.buttonYeniUniteEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewHastaListesi);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(222, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 599);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Listesi";
            // 
            // dataGridViewHastaListesi
            // 
            this.dataGridViewHastaListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHastaListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHastaListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column2,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHastaListesi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHastaListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHastaListesi.Location = new System.Drawing.Point(3, 28);
            this.dataGridViewHastaListesi.Name = "dataGridViewHastaListesi";
            this.dataGridViewHastaListesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridViewHastaListesi.RowTemplate.Height = 25;
            this.dataGridViewHastaListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHastaListesi.Size = new System.Drawing.Size(1062, 568);
            this.dataGridViewHastaListesi.TabIndex = 0;
            this.dataGridViewHastaListesi.DoubleClick += new System.EventHandler(this.dataGridViewHastaListesi_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "İsim";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Yaş";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cinsiyet";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nabız";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ateş";
            this.Column6.Name = "Column6";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tansiyon";
            this.Column2.Name = "Column2";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Saturasyon";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Durum";
            this.Column8.Name = "Column8";
            // 
            // İsim
            // 
            this.İsim.HeaderText = "İsim";
            this.İsim.Name = "İsim";
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.HeaderText = "Cinsiyet";
            this.Cinsiyet.Name = "Cinsiyet";
            // 
            // Yaş
            // 
            this.Yaş.HeaderText = "Yaş";
            this.Yaş.Name = "Yaş";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1302, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonYeniUniteEkle);
            this.Controls.Add(this.listBoxUniteler);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormAnasayfa";
            this.Text = "FormAnasayfa";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHastaListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private ListBox listBoxUniteler;
        private Button buttonYeniUniteEkle;
        private GroupBox groupBox1;
        private DataGridView dataGridViewHastaListesi;
        private DataGridViewTextBoxColumn İsim;
        private DataGridViewTextBoxColumn Cinsiyet;
        private DataGridViewTextBoxColumn Yaş;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}