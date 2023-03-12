
namespace WindowsFormsApp2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.etunimi_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lisaa_btn = new System.Windows.Forms.Button();
            this.txt_etunimi = new System.Windows.Forms.TextBox();
            this.txt_tokanimi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sukunimi = new System.Windows.Forms.TextBox();
            this.txt_hetu = new System.Windows.Forms.TextBox();
            this.txt_postinro = new System.Windows.Forms.TextBox();
            this.txt_katuosoite = new System.Windows.Forms.TextBox();
            this.txt_kutsumanimi = new System.Windows.Forms.TextBox();
            this.txt_postipaikka = new System.Windows.Forms.TextBox();
            this.poista_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txt_titteli = new System.Windows.Forms.TextBox();
            this.txt_yksikkö = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.etunimi_dgv,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridView1.Location = new System.Drawing.Point(455, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(345, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // etunimi_dgv
            // 
            this.etunimi_dgv.HeaderText = "Etunimi";
            this.etunimi_dgv.Name = "etunimi_dgv";
            this.etunimi_dgv.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Toinen Nimi";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sukunimi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kutusma nimi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Henkilötunnus";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Katuosoite";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Postinumero";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Postitoimipaikka";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Alkamispäivä";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Päättymispäivä";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Nimike";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Yksikkö";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // lisaa_btn
            // 
            this.lisaa_btn.Location = new System.Drawing.Point(725, 415);
            this.lisaa_btn.Name = "lisaa_btn";
            this.lisaa_btn.Size = new System.Drawing.Size(75, 23);
            this.lisaa_btn.TabIndex = 1;
            this.lisaa_btn.Text = "Lisää";
            this.lisaa_btn.UseVisualStyleBackColor = true;
            this.lisaa_btn.Click += new System.EventHandler(this.lisaa_btn_Click);
            // 
            // txt_etunimi
            // 
            this.txt_etunimi.Location = new System.Drawing.Point(12, 45);
            this.txt_etunimi.Name = "txt_etunimi";
            this.txt_etunimi.Size = new System.Drawing.Size(102, 20);
            this.txt_etunimi.TabIndex = 2;
            // 
            // txt_tokanimi
            // 
            this.txt_tokanimi.Location = new System.Drawing.Point(120, 45);
            this.txt_tokanimi.Name = "txt_tokanimi";
            this.txt_tokanimi.Size = new System.Drawing.Size(105, 20);
            this.txt_tokanimi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Etunimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Toinen nimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sukunimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kutsumanimi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "HETU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Katuosoite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Postitoimipaikka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Postinumero";
            // 
            // txt_sukunimi
            // 
            this.txt_sukunimi.Location = new System.Drawing.Point(12, 100);
            this.txt_sukunimi.Name = "txt_sukunimi";
            this.txt_sukunimi.Size = new System.Drawing.Size(213, 20);
            this.txt_sukunimi.TabIndex = 12;
            // 
            // txt_hetu
            // 
            this.txt_hetu.Location = new System.Drawing.Point(259, 100);
            this.txt_hetu.Name = "txt_hetu";
            this.txt_hetu.Size = new System.Drawing.Size(143, 20);
            this.txt_hetu.TabIndex = 13;
            this.txt_hetu.TextChanged += new System.EventHandler(this.txt_hetu_TextChanged);
            // 
            // txt_postinro
            // 
            this.txt_postinro.Location = new System.Drawing.Point(12, 197);
            this.txt_postinro.Name = "txt_postinro";
            this.txt_postinro.Size = new System.Drawing.Size(102, 20);
            this.txt_postinro.TabIndex = 15;
            // 
            // txt_katuosoite
            // 
            this.txt_katuosoite.Location = new System.Drawing.Point(12, 152);
            this.txt_katuosoite.Name = "txt_katuosoite";
            this.txt_katuosoite.Size = new System.Drawing.Size(213, 20);
            this.txt_katuosoite.TabIndex = 17;
            // 
            // txt_kutsumanimi
            // 
            this.txt_kutsumanimi.Location = new System.Drawing.Point(259, 45);
            this.txt_kutsumanimi.Name = "txt_kutsumanimi";
            this.txt_kutsumanimi.Size = new System.Drawing.Size(143, 20);
            this.txt_kutsumanimi.TabIndex = 18;
            // 
            // txt_postipaikka
            // 
            this.txt_postipaikka.AutoCompleteCustomSource.AddRange(new string[] {
            "Kuopio",
            "Helsinki",
            "Turku",
            "Espoo",
            "Tampere",
            "Oulu",
            "Varkaus",
            "Vantaa",
            "Rovaniemi",
            "Mikkeli",
            "Juva",
            "Siilinjärvi",
            "Jyväskylä",
            "Kouvola",
            "Kempele"});
            this.txt_postipaikka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_postipaikka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_postipaikka.Location = new System.Drawing.Point(120, 197);
            this.txt_postipaikka.Name = "txt_postipaikka";
            this.txt_postipaikka.Size = new System.Drawing.Size(105, 20);
            this.txt_postipaikka.TabIndex = 20;
            // 
            // poista_btn
            // 
            this.poista_btn.Location = new System.Drawing.Point(455, 415);
            this.poista_btn.Name = "poista_btn";
            this.poista_btn.Size = new System.Drawing.Size(75, 23);
            this.poista_btn.TabIndex = 21;
            this.poista_btn.Text = "Poista";
            this.poista_btn.UseVisualStyleBackColor = true;
            this.poista_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 252);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(259, 252);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // txt_titteli
            // 
            this.txt_titteli.Location = new System.Drawing.Point(12, 312);
            this.txt_titteli.Name = "txt_titteli";
            this.txt_titteli.Size = new System.Drawing.Size(213, 20);
            this.txt_titteli.TabIndex = 24;
            // 
            // txt_yksikkö
            // 
            this.txt_yksikkö.Location = new System.Drawing.Point(259, 312);
            this.txt_yksikkö.Name = "txt_yksikkö";
            this.txt_yksikkö.Size = new System.Drawing.Size(143, 20);
            this.txt_yksikkö.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Alkamispäivä";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Päättymispäivä";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Titteli";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(256, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Yksikkö";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_yksikkö);
            this.Controls.Add(this.txt_titteli);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.poista_btn);
            this.Controls.Add(this.txt_postipaikka);
            this.Controls.Add(this.txt_kutsumanimi);
            this.Controls.Add(this.txt_katuosoite);
            this.Controls.Add(this.txt_postinro);
            this.Controls.Add(this.txt_hetu);
            this.Controls.Add(this.txt_sukunimi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tokanimi);
            this.Controls.Add(this.txt_etunimi);
            this.Controls.Add(this.lisaa_btn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = " Tietojenhallinta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button lisaa_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etunimi_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.TextBox txt_etunimi;
        private System.Windows.Forms.TextBox txt_tokanimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_sukunimi;
        private System.Windows.Forms.TextBox txt_hetu;
        private System.Windows.Forms.TextBox txt_postinro;
        private System.Windows.Forms.TextBox txt_katuosoite;
        private System.Windows.Forms.TextBox txt_kutsumanimi;
        private System.Windows.Forms.TextBox txt_postipaikka;
        private System.Windows.Forms.Button poista_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txt_titteli;
        private System.Windows.Forms.TextBox txt_yksikkö;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

