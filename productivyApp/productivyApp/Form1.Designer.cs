
namespace productivyApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDeskripsi = new System.Windows.Forms.TextBox();
            this.jamMulai = new System.Windows.Forms.MaskedTextBox();
            this.jamBerakhir = new System.Windows.Forms.MaskedTextBox();
            this.cbSkalaPrioritas = new System.Windows.Forms.ComboBox();
            this.cbJenis = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbYa = new System.Windows.Forms.RadioButton();
            this.cbSequence = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nama = new System.Windows.Forms.Label();
            this.cbNamaKegiatan = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(402, 439);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "jenis : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(14, 130);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jam Mulai :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(14, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jam Berakhir :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(9, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tanggal dikerjakan :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(14, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Skala Prioritas :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(14, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Deskripsi :";
            // 
            // tbDeskripsi
            // 
            this.tbDeskripsi.Location = new System.Drawing.Point(122, 308);
            this.tbDeskripsi.Multiline = true;
            this.tbDeskripsi.Name = "tbDeskripsi";
            this.tbDeskripsi.Size = new System.Drawing.Size(355, 105);
            this.tbDeskripsi.TabIndex = 13;
            this.tbDeskripsi.TextChanged += new System.EventHandler(this.tbDeskripsi_TextChanged);
            // 
            // jamMulai
            // 
            this.jamMulai.Location = new System.Drawing.Point(122, 127);
            this.jamMulai.Mask = "00:00";
            this.jamMulai.Name = "jamMulai";
            this.jamMulai.Size = new System.Drawing.Size(41, 23);
            this.jamMulai.TabIndex = 15;
            this.jamMulai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jamMulai.ValidatingType = typeof(System.DateTime);
            this.jamMulai.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.jamMulai_MaskInputRejected);
            // 
            // jamBerakhir
            // 
            this.jamBerakhir.Location = new System.Drawing.Point(122, 165);
            this.jamBerakhir.Mask = "00:00";
            this.jamBerakhir.Name = "jamBerakhir";
            this.jamBerakhir.Size = new System.Drawing.Size(41, 23);
            this.jamBerakhir.TabIndex = 16;
            this.jamBerakhir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jamBerakhir.ValidatingType = typeof(System.DateTime);
            this.jamBerakhir.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.jamBerakhir_MaskInputRejected);
            // 
            // cbSkalaPrioritas
            // 
            this.cbSkalaPrioritas.FormattingEnabled = true;
            this.cbSkalaPrioritas.Items.AddRange(new object[] {
            "Tinggi",
            "Sedang",
            "Rendah"});
            this.cbSkalaPrioritas.Location = new System.Drawing.Point(122, 205);
            this.cbSkalaPrioritas.Name = "cbSkalaPrioritas";
            this.cbSkalaPrioritas.Size = new System.Drawing.Size(121, 23);
            this.cbSkalaPrioritas.TabIndex = 17;
            this.cbSkalaPrioritas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbJenis
            // 
            this.cbJenis.FormattingEnabled = true;
            this.cbJenis.Items.AddRange(new object[] {
            "Kuliah",
            "Tugas Kuliah",
            "Organisasi",
            "Lain-lain"});
            this.cbJenis.Location = new System.Drawing.Point(122, 49);
            this.cbJenis.Name = "cbJenis";
            this.cbJenis.Size = new System.Drawing.Size(121, 23);
            this.cbJenis.TabIndex = 18;
            this.cbJenis.SelectedIndexChanged += new System.EventHandler(this.cbJenis_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(14, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Repeat :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // rbYa
            // 
            this.rbYa.AutoSize = true;
            this.rbYa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.rbYa.Location = new System.Drawing.Point(122, 246);
            this.rbYa.Name = "rbYa";
            this.rbYa.Size = new System.Drawing.Size(37, 19);
            this.rbYa.TabIndex = 20;
            this.rbYa.TabStop = true;
            this.rbYa.Text = "ya";
            this.rbYa.UseVisualStyleBackColor = false;
            this.rbYa.CheckedChanged += new System.EventHandler(this.rbYa_CheckedChanged);
            // 
            // cbSequence
            // 
            this.cbSequence.FormattingEnabled = true;
            this.cbSequence.Items.AddRange(new object[] {
            "Setiap Hari",
            "Setiap Minggu",
            "Setiap Bulan"});
            this.cbSequence.Location = new System.Drawing.Point(122, 271);
            this.cbSequence.Name = "cbSequence";
            this.cbSequence.Size = new System.Drawing.Size(121, 23);
            this.cbSequence.TabIndex = 22;
            this.cbSequence.SelectedIndexChanged += new System.EventHandler(this.cbSequence_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Font = new System.Drawing.Font("Bebas Neue", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(199, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Input Kegiatan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-12, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 43);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.nama);
            this.panel2.Controls.Add(this.cbNamaKegiatan);
            this.panel2.Location = new System.Drawing.Point(-2, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 439);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Location = new System.Drawing.Point(251, 11);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(94, 15);
            this.nama.TabIndex = 1;
            this.nama.Text = "Nama Kegiatan :";
            // 
            // cbNamaKegiatan
            // 
            this.cbNamaKegiatan.Location = new System.Drawing.Point(351, 8);
            this.cbNamaKegiatan.Name = "cbNamaKegiatan";
            this.cbNamaKegiatan.Size = new System.Drawing.Size(129, 23);
            this.cbNamaKegiatan.TabIndex = 0;
            this.cbNamaKegiatan.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 478);
            this.Controls.Add(this.cbSequence);
            this.Controls.Add(this.rbYa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbJenis);
            this.Controls.Add(this.cbSkalaPrioritas);
            this.Controls.Add(this.jamBerakhir);
            this.Controls.Add(this.jamMulai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDeskripsi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDeskripsi;
        private System.Windows.Forms.MaskedTextBox jamMulai;
        private System.Windows.Forms.MaskedTextBox jamBerakhir;
        private System.Windows.Forms.ComboBox cbSkalaPrioritas;
        private System.Windows.Forms.ComboBox cbJenis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbYa;
        private System.Windows.Forms.ComboBox cbSequence;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.TextBox cbNamaKegiatan;
    }
}

