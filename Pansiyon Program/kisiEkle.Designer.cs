namespace Pansiyon_Program
{
	partial class kisiEkle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kisiEkle));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.TC_NOAratextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.soyisimAraTextBox = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tCNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.karaListeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hatırlatmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pansiyonDataSet = new Pansiyon_Program.PansiyonDataSet();
			this.label6 = new System.Windows.Forms.Label();
			this.yanaGecirButton = new System.Windows.Forms.Button();
			this.isimAraTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.bilgiLabel = new System.Windows.Forms.Label();
			this.ekleButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.karaListeTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.silButton = new System.Windows.Forms.Button();
			this.hatirlatmaTextBox = new System.Windows.Forms.TextBox();
			this.TC_NOTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.soyisimTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.isimTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.telefonTextBox = new System.Windows.Forms.TextBox();
			this.customerTableAdapter = new Pansiyon_Program.PansiyonDataSetTableAdapters.CustomerTableAdapter();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pansiyonDataSet)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.TC_NOAratextBox);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.soyisimAraTextBox);
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.yanaGecirButton);
			this.groupBox2.Controls.Add(this.isimAraTextBox);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(166, 66);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(785, 498);
			this.groupBox2.TabIndex = 35;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Müşteri Görüntüleme";
			// 
			// TC_NOAratextBox
			// 
			this.TC_NOAratextBox.Location = new System.Drawing.Point(244, 40);
			this.TC_NOAratextBox.Name = "TC_NOAratextBox";
			this.TC_NOAratextBox.Size = new System.Drawing.Size(113, 20);
			this.TC_NOAratextBox.TabIndex = 28;
			this.TC_NOAratextBox.TextChanged += new System.EventHandler(this.TC_NOAratextBox_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(244, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 24;
			this.label4.Text = "TC. Kimlik No";
			// 
			// soyisimAraTextBox
			// 
			this.soyisimAraTextBox.Location = new System.Drawing.Point(125, 40);
			this.soyisimAraTextBox.Name = "soyisimAraTextBox";
			this.soyisimAraTextBox.Size = new System.Drawing.Size(113, 20);
			this.soyisimAraTextBox.TabIndex = 27;
			this.soyisimAraTextBox.TextChanged += new System.EventHandler(this.soyisimAraTextBox_TextChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.tCNODataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.karaListeDataGridViewTextBoxColumn,
            this.hatırlatmaDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.customerBindingSource;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Location = new System.Drawing.Point(6, 66);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(773, 426);
			this.dataGridView1.TabIndex = 70;
			// 
			// adDataGridViewTextBoxColumn
			// 
			this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
			this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
			this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
			this.adDataGridViewTextBoxColumn.Width = 45;
			// 
			// soyadDataGridViewTextBoxColumn
			// 
			this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
			this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
			this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
			this.soyadDataGridViewTextBoxColumn.Width = 62;
			// 
			// tCNODataGridViewTextBoxColumn
			// 
			this.tCNODataGridViewTextBoxColumn.DataPropertyName = "TC_NO";
			this.tCNODataGridViewTextBoxColumn.HeaderText = "TC_NO";
			this.tCNODataGridViewTextBoxColumn.Name = "tCNODataGridViewTextBoxColumn";
			this.tCNODataGridViewTextBoxColumn.Width = 68;
			// 
			// telefonDataGridViewTextBoxColumn
			// 
			this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
			this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
			this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
			this.telefonDataGridViewTextBoxColumn.Width = 68;
			// 
			// karaListeDataGridViewTextBoxColumn
			// 
			this.karaListeDataGridViewTextBoxColumn.DataPropertyName = "KaraListe";
			this.karaListeDataGridViewTextBoxColumn.HeaderText = "KaraListe";
			this.karaListeDataGridViewTextBoxColumn.Name = "karaListeDataGridViewTextBoxColumn";
			this.karaListeDataGridViewTextBoxColumn.Width = 76;
			// 
			// hatırlatmaDataGridViewTextBoxColumn
			// 
			this.hatırlatmaDataGridViewTextBoxColumn.DataPropertyName = "Hatırlatma";
			this.hatırlatmaDataGridViewTextBoxColumn.HeaderText = "Hatırlatma";
			this.hatırlatmaDataGridViewTextBoxColumn.Name = "hatırlatmaDataGridViewTextBoxColumn";
			this.hatırlatmaDataGridViewTextBoxColumn.Width = 79;
			// 
			// customerBindingSource
			// 
			this.customerBindingSource.DataMember = "Customer";
			this.customerBindingSource.DataSource = this.pansiyonDataSet;
			// 
			// pansiyonDataSet
			// 
			this.pansiyonDataSet.DataSetName = "PansiyonDataSet";
			this.pansiyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(3, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 13);
			this.label6.TabIndex = 27;
			this.label6.Text = "Adı";
			// 
			// yanaGecirButton
			// 
			this.yanaGecirButton.Location = new System.Drawing.Point(363, 27);
			this.yanaGecirButton.Name = "yanaGecirButton";
			this.yanaGecirButton.Size = new System.Drawing.Size(143, 33);
			this.yanaGecirButton.TabIndex = 29;
			this.yanaGecirButton.Text = "KİŞİYİ YANA GEÇİR";
			this.yanaGecirButton.UseVisualStyleBackColor = true;
			this.yanaGecirButton.Click += new System.EventHandler(this.yanaGecirButton_Click);
			// 
			// isimAraTextBox
			// 
			this.isimAraTextBox.Location = new System.Drawing.Point(6, 40);
			this.isimAraTextBox.Name = "isimAraTextBox";
			this.isimAraTextBox.Size = new System.Drawing.Size(113, 20);
			this.isimAraTextBox.TabIndex = 26;
			this.isimAraTextBox.TextChanged += new System.EventHandler(this.isimAraTextBox_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(122, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(39, 13);
			this.label7.TabIndex = 25;
			this.label7.Text = "Soyadı";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.AutoSize = true;
			this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox3.Controls.Add(this.bilgiLabel);
			this.groupBox3.Location = new System.Drawing.Point(166, 11);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(785, 49);
			this.groupBox3.TabIndex = 36;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Bilgi Ekranı";
			// 
			// bilgiLabel
			// 
			this.bilgiLabel.AutoSize = true;
			this.bilgiLabel.Location = new System.Drawing.Point(9, 20);
			this.bilgiLabel.Name = "bilgiLabel";
			this.bilgiLabel.Size = new System.Drawing.Size(26, 13);
			this.bilgiLabel.TabIndex = 0;
			this.bilgiLabel.Text = "Bilgi";
			// 
			// ekleButton
			// 
			this.ekleButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ekleButton.Location = new System.Drawing.Point(6, 353);
			this.ekleButton.Name = "ekleButton";
			this.ekleButton.Size = new System.Drawing.Size(138, 96);
			this.ekleButton.TabIndex = 24;
			this.ekleButton.Text = "EKLE";
			this.ekleButton.UseVisualStyleBackColor = true;
			this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.karaListeTextBox);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.silButton);
			this.groupBox1.Controls.Add(this.ekleButton);
			this.groupBox1.Controls.Add(this.hatirlatmaTextBox);
			this.groupBox1.Controls.Add(this.TC_NOTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.soyisimTextBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.isimTextBox);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.telefonTextBox);
			this.groupBox1.Location = new System.Drawing.Point(9, 11);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(150, 553);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Müşteri Ekleme";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 197);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(91, 13);
			this.label9.TabIndex = 20;
			this.label9.Text = "Kara Liste Nedeni";
			// 
			// karaListeTextBox
			// 
			this.karaListeTextBox.Location = new System.Drawing.Point(6, 213);
			this.karaListeTextBox.Name = "karaListeTextBox";
			this.karaListeTextBox.Size = new System.Drawing.Size(138, 20);
			this.karaListeTextBox.TabIndex = 21;
			this.karaListeTextBox.TextChanged += new System.EventHandler(this.karaListeTextBox_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 241);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 13);
			this.label8.TabIndex = 22;
			this.label8.Text = "Hatırlatma";
			// 
			// silButton
			// 
			this.silButton.Location = new System.Drawing.Point(6, 455);
			this.silButton.Name = "silButton";
			this.silButton.Size = new System.Drawing.Size(138, 92);
			this.silButton.TabIndex = 25;
			this.silButton.Text = "SİL";
			this.silButton.UseVisualStyleBackColor = true;
			this.silButton.Click += new System.EventHandler(this.silButton_Click);
			// 
			// hatirlatmaTextBox
			// 
			this.hatirlatmaTextBox.Location = new System.Drawing.Point(6, 257);
			this.hatirlatmaTextBox.Multiline = true;
			this.hatirlatmaTextBox.Name = "hatirlatmaTextBox";
			this.hatirlatmaTextBox.Size = new System.Drawing.Size(138, 90);
			this.hatirlatmaTextBox.TabIndex = 23;
			this.hatirlatmaTextBox.TextChanged += new System.EventHandler(this.hatirlatmaTextBox_TextChanged);
			// 
			// TC_NOTextBox
			// 
			this.TC_NOTextBox.Location = new System.Drawing.Point(6, 37);
			this.TC_NOTextBox.Name = "TC_NOTextBox";
			this.TC_NOTextBox.Size = new System.Drawing.Size(138, 20);
			this.TC_NOTextBox.TabIndex = 7;
			this.TC_NOTextBox.TextChanged += new System.EventHandler(this.TC_NOTextBox_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "TC. Kimlik No";
			// 
			// soyisimTextBox
			// 
			this.soyisimTextBox.Location = new System.Drawing.Point(6, 125);
			this.soyisimTextBox.Name = "soyisimTextBox";
			this.soyisimTextBox.Size = new System.Drawing.Size(138, 20);
			this.soyisimTextBox.TabIndex = 17;
			this.soyisimTextBox.TextChanged += new System.EventHandler(this.soyisimTextBox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Soyadı";
			// 
			// isimTextBox
			// 
			this.isimTextBox.Location = new System.Drawing.Point(6, 81);
			this.isimTextBox.Name = "isimTextBox";
			this.isimTextBox.Size = new System.Drawing.Size(138, 20);
			this.isimTextBox.TabIndex = 15;
			this.isimTextBox.TextChanged += new System.EventHandler(this.isimTextBox_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 153);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Telefon";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 20;
			this.label3.Text = "Adı";
			// 
			// telefonTextBox
			// 
			this.telefonTextBox.Location = new System.Drawing.Point(6, 169);
			this.telefonTextBox.Name = "telefonTextBox";
			this.telefonTextBox.Size = new System.Drawing.Size(138, 20);
			this.telefonTextBox.TabIndex = 19;
			this.telefonTextBox.Text = "0";
			this.telefonTextBox.TextChanged += new System.EventHandler(this.telefonTextBox_TextChanged);
			// 
			// customerTableAdapter
			// 
			this.customerTableAdapter.ClearBeforeFill = true;
			// 
			// kisiEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 576);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "kisiEkle";
			this.Text = "Müşteri Görüntüleme Ekranı";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pansiyonDataSet)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox TC_NOAratextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox soyisimAraTextBox;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button yanaGecirButton;
		private System.Windows.Forms.TextBox isimAraTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label bilgiLabel;
		private System.Windows.Forms.Button ekleButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button silButton;
		private System.Windows.Forms.TextBox TC_NOTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox soyisimTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox isimTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox telefonTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox hatirlatmaTextBox;
		private PansiyonDataSet pansiyonDataSet;
		private PansiyonDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tCNODataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn karaListeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hatırlatmaDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource customerBindingSource;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox karaListeTextBox;
	}
}

