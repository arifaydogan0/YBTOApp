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
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxUniteler = new System.Windows.Forms.ListBox();
            this.buttonYeniUniteEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHastaListesi = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewHastaListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHastaListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHastaListesi.Location = new System.Drawing.Point(3, 28);
            this.dataGridViewHastaListesi.Name = "dataGridViewHastaListesi";
            this.dataGridViewHastaListesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridViewHastaListesi.RowTemplate.Height = 25;
            this.dataGridViewHastaListesi.Size = new System.Drawing.Size(1062, 568);
            this.dataGridViewHastaListesi.TabIndex = 0;
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
            this.timer1.Interval = 10;
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
    }
}