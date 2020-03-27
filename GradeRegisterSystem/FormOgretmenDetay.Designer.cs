namespace NotKayitSistemi
{
    partial class FormOgretmenDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtS3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblGecen = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oGRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRNUMARADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRTALAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tBLDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSet = new NotKayitSistemi.dbNotKayitDataSet();
            this.tBLDERSTableAdapter = new NotKayitSistemi.dbNotKayitDataSetTableAdapters.TBLDERSTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtNumara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(289, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Öğrenci Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(88, 112);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(171, 28);
            this.txtSoyad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(88, 78);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(171, 28);
            this.txtAd.TabIndex = 2;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(88, 44);
            this.txtNumara.Mask = "0000";
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(171, 28);
            this.txtNumara.TabIndex = 1;
            this.txtNumara.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtS3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtS2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtS1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(320, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(289, 225);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınav Notları";
            // 
            // txtS3
            // 
            this.txtS3.Location = new System.Drawing.Point(82, 115);
            this.txtS3.Name = "txtS3";
            this.txtS3.Size = new System.Drawing.Size(171, 28);
            this.txtS3.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(82, 81);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(171, 28);
            this.txtS2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sınav 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sınav 2:";
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(82, 44);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(171, 28);
            this.txtS1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sınav 1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblKalan);
            this.groupBox3.Controls.Add(this.lblGecen);
            this.groupBox3.Controls.Add(this.lblOrtalama);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(625, 38);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(255, 225);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğrenci Ekle";
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Location = new System.Drawing.Point(157, 125);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(28, 21);
            this.lblKalan.TabIndex = 7;
            this.lblKalan.Text = "00";
            // 
            // lblGecen
            // 
            this.lblGecen.AutoSize = true;
            this.lblGecen.Location = new System.Drawing.Point(157, 94);
            this.lblGecen.Name = "lblGecen";
            this.lblGecen.Size = new System.Drawing.Size(28, 21);
            this.lblGecen.TabIndex = 6;
            this.lblGecen.Text = "00";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(157, 63);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(28, 21);
            this.lblOrtalama.TabIndex = 5;
            this.lblOrtalama.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kalan Sayısı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Geçen Sayısı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ortalama:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(14, 280);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(866, 252);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oGRIDDataGridViewTextBoxColumn,
            this.oGRNUMARADataGridViewTextBoxColumn,
            this.oGRADDataGridViewTextBoxColumn,
            this.oGRSOYADDataGridViewTextBoxColumn,
            this.oGRS1DataGridViewTextBoxColumn,
            this.oGRS2DataGridViewTextBoxColumn,
            this.oGRS3DataGridViewTextBoxColumn,
            this.oRTALAMADataGridViewTextBoxColumn,
            this.dURUMDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLDERSBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(860, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // oGRIDDataGridViewTextBoxColumn
            // 
            this.oGRIDDataGridViewTextBoxColumn.DataPropertyName = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.HeaderText = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRIDDataGridViewTextBoxColumn.Name = "oGRIDDataGridViewTextBoxColumn";
            this.oGRIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oGRNUMARADataGridViewTextBoxColumn
            // 
            this.oGRNUMARADataGridViewTextBoxColumn.DataPropertyName = "OGRNUMARA";
            this.oGRNUMARADataGridViewTextBoxColumn.HeaderText = "OGRNUMARA";
            this.oGRNUMARADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRNUMARADataGridViewTextBoxColumn.Name = "oGRNUMARADataGridViewTextBoxColumn";
            // 
            // oGRADDataGridViewTextBoxColumn
            // 
            this.oGRADDataGridViewTextBoxColumn.DataPropertyName = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.HeaderText = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRADDataGridViewTextBoxColumn.Name = "oGRADDataGridViewTextBoxColumn";
            // 
            // oGRSOYADDataGridViewTextBoxColumn
            // 
            this.oGRSOYADDataGridViewTextBoxColumn.DataPropertyName = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.HeaderText = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRSOYADDataGridViewTextBoxColumn.Name = "oGRSOYADDataGridViewTextBoxColumn";
            // 
            // oGRS1DataGridViewTextBoxColumn
            // 
            this.oGRS1DataGridViewTextBoxColumn.DataPropertyName = "OGRS1";
            this.oGRS1DataGridViewTextBoxColumn.HeaderText = "OGRS1";
            this.oGRS1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRS1DataGridViewTextBoxColumn.Name = "oGRS1DataGridViewTextBoxColumn";
            // 
            // oGRS2DataGridViewTextBoxColumn
            // 
            this.oGRS2DataGridViewTextBoxColumn.DataPropertyName = "OGRS2";
            this.oGRS2DataGridViewTextBoxColumn.HeaderText = "OGRS2";
            this.oGRS2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRS2DataGridViewTextBoxColumn.Name = "oGRS2DataGridViewTextBoxColumn";
            // 
            // oGRS3DataGridViewTextBoxColumn
            // 
            this.oGRS3DataGridViewTextBoxColumn.DataPropertyName = "OGRS3";
            this.oGRS3DataGridViewTextBoxColumn.HeaderText = "OGRS3";
            this.oGRS3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRS3DataGridViewTextBoxColumn.Name = "oGRS3DataGridViewTextBoxColumn";
            // 
            // oRTALAMADataGridViewTextBoxColumn
            // 
            this.oRTALAMADataGridViewTextBoxColumn.DataPropertyName = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.HeaderText = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oRTALAMADataGridViewTextBoxColumn.Name = "oRTALAMADataGridViewTextBoxColumn";
            // 
            // dURUMDataGridViewCheckBoxColumn
            // 
            this.dURUMDataGridViewCheckBoxColumn.DataPropertyName = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.HeaderText = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.dURUMDataGridViewCheckBoxColumn.Name = "dURUMDataGridViewCheckBoxColumn";
            // 
            // tBLDERSBindingSource
            // 
            this.tBLDERSBindingSource.DataMember = "TBLDERS";
            this.tBLDERSBindingSource.DataSource = this.dbNotKayitDataSet;
            // 
            // dbNotKayitDataSet
            // 
            this.dbNotKayitDataSet.DataSetName = "dbNotKayitDataSet";
            this.dbNotKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLDERSTableAdapter
            // 
            this.tBLDERSTableAdapter.ClearBeforeFill = true;
            // 
            // FormOgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(963, 588);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOgretmenDetay";
            this.Text = "FormOgretmenDetay";
            this.Load += new System.EventHandler(this.FormOgretmenDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox txtNumara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtS3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label lblGecen;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbNotKayitDataSet dbNotKayitDataSet;
        private System.Windows.Forms.BindingSource tBLDERSBindingSource;
        private dbNotKayitDataSetTableAdapters.TBLDERSTableAdapter tBLDERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRNUMARADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRTALAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dURUMDataGridViewCheckBoxColumn;
    }
}