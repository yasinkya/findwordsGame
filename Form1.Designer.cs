namespace Yazılım_Yapımı_Ödev
{
    partial class Kelime_İşlem
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnHgir = new System.Windows.Forms.Button();
            this.tbxKelime = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_letter1 = new System.Windows.Forms.ComboBox();
            this.cbx_letter2 = new System.Windows.Forms.ComboBox();
            this.cbx_letter3 = new System.Windows.Forms.ComboBox();
            this.cbx_letter4 = new System.Windows.Forms.ComboBox();
            this.cbx_letter5 = new System.Windows.Forms.ComboBox();
            this.cbx_letter6 = new System.Windows.Forms.ComboBox();
            this.cbx_letter7 = new System.Windows.Forms.ComboBox();
            this.cbx_letter8 = new System.Windows.Forms.ComboBox();
            this.cbx_letterJok = new System.Windows.Forms.ComboBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lbxBulunanlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRandom.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(137, 38);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnHgir
            // 
            this.btnHgir.BackColor = System.Drawing.Color.GhostWhite;
            this.btnHgir.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHgir.Location = new System.Drawing.Point(243, 38);
            this.btnHgir.Name = "btnHgir";
            this.btnHgir.Size = new System.Drawing.Size(75, 23);
            this.btnHgir.TabIndex = 7;
            this.btnHgir.Text = "Harf Gir";
            this.btnHgir.UseVisualStyleBackColor = false;
            this.btnHgir.Click += new System.EventHandler(this.btnHgir_Click);
            // 
            // tbxKelime
            // 
            this.tbxKelime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbxKelime.Location = new System.Drawing.Point(200, 147);
            this.tbxKelime.Multiline = true;
            this.tbxKelime.Name = "tbxKelime";
            this.tbxKelime.Size = new System.Drawing.Size(138, 20);
            this.tbxKelime.TabIndex = 11;
            this.tbxKelime.TextChanged += new System.EventHandler(this.tbxKelime_TextChanged);
            this.tbxKelime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.just_letter);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCheck.Enabled = false;
            this.btnCheck.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCheck.Location = new System.Drawing.Point(344, 146);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 12;
            this.btnCheck.Text = "Kontrol Et";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Joker Harf:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kelime Tahmini:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Harf 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Harf 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Harf 4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Harf 3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Harf 8:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(327, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Harf 7:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(282, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Harf 6:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(232, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Harf 5:";
            // 
            // cbx_letter1
            // 
            this.cbx_letter1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbx_letter1.Enabled = false;
            this.cbx_letter1.FormattingEnabled = true;
            this.cbx_letter1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "Ç",
            "D",
            "E",
            "F",
            "G",
            "Ğ",
            "H",
            "I",
            "İ",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "Ö",
            "P",
            "R",
            "S",
            "Ş",
            "T",
            "U",
            "Ü",
            "V",
            "Y",
            "Z"});
            this.cbx_letter1.Location = new System.Drawing.Point(38, 90);
            this.cbx_letter1.Name = "cbx_letter1";
            this.cbx_letter1.Size = new System.Drawing.Size(42, 21);
            this.cbx_letter1.TabIndex = 23;
            this.cbx_letter1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbx_letter2
            // 
            this.cbx_letter2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbx_letter2.Enabled = false;
            this.cbx_letter2.FormattingEnabled = true;
            this.cbx_letter2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "Ç",
            "D",
            "E",
            "F",
            "G",
            "Ğ",
            "H",
            "I",
            "İ",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "Ö",
            "P",
            "R",
            "S",
            "Ş",
            "T",
            "U",
            "Ü",
            "V",
            "Y",
            "Z"});
            this.cbx_letter2.Location = new System.Drawing.Point(86, 90);
            this.cbx_letter2.Name = "cbx_letter2";
            this.cbx_letter2.Size = new System.Drawing.Size(42, 21);
            this.cbx_letter2.TabIndex = 24;
            // 
            // cbx_letter3
            // 
            this.cbx_letter3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbx_letter3.Enabled = false;
            this.cbx_letter3.FormattingEnabled = true;
            this.cbx_letter3.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "Ç",
            "D",
            "E",
            "F",
            "G",
            "Ğ",
            "H",
            "I",
            "İ",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "Ö",
            "P",
            "R",
            "S",
            "Ş",
            "T",
            "U",
            "Ü",
            "V",
            "Y",
            "Z"});
            this.cbx_letter3.Location = new System.Drawing.Point(133, 90);
            this.cbx_letter3.Name = "cbx_letter3";
            this.cbx_letter3.Size = new System.Drawing.Size(42, 21);
            this.cbx_letter3.TabIndex = 26;
            // 
            // cbx_letter4
            // 
            this.cbx_letter4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbx_letter4.Enabled = false;
            this.cbx_letter4.FormattingEnabled = true;
            this.cbx_letter4.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "Ç",
            "D",
            "E",
            "F",
            "G",
            "Ğ",
            "H",
            "I",
            "İ",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "Ö",
            "P",
            "R",
            "S",
            "Ş",
            "T",
            "U",
            "Ü",
            "V",
            "Y",
            "Z"});
            this.cbx_letter4.Location = new System.Drawing.Point(181, 90);
            this.cbx_letter4.Name = "cbx_letter4";
            this.cbx_letter4.Size = new System.Drawing.Size(42, 21);
            this.cbx_letter4.TabIndex = 25;
            this.cbx_letter4.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cbx_letter5
            // 
            this.cbx_letter5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbx_letter5.Enabled = false;
            this.cbx_letter5.FormattingEnabled = true;
            this.cbx_letter5.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "Ç",
            "D",
            "E",
            "F",
            "G",
            "Ğ",
            "H",
            "I",
            "İ",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "Ö",
            "P",
            "R",
            "S",
            "Ş",
            "T",
            "U",
            "Ü",
            "V",
            "Y",
            "Z"});
            this.cbx_letter5.Location = new System.Drawing.Point(228, 90);
            this.cbx_letter5.Name = "cbx_letter5";
            this.cbx_letter5.Size = new System.Drawing.Size(42, 21);
            this.cbx_letter5.TabIndex = 30;
            // 
            // cbx_letter6
            // 
            this.cbx_letter6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbx_letter6.Enabled = false;
            this.cbx_letter6.FormattingEnabled = true;
            this.cbx_letter6.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "Ç",
            "D",
            "E",
            "F",
            "G",
            "Ğ",
            "H",
            "I",
            "İ",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "Ö",
            "P",
            "R",
            "S",
            "Ş",
            "T",
            "U",
            "Ü",
            "V",
            "Y",
            "Z"});
            this.cbx_letter6.Location = new System.Drawing.Point(276, 90);
            this.cbx_letter6.Name = "cbx_letter6";
            this.cbx_letter6.Size = new System.Drawing.Size(42, 21);
            this.cbx_letter6.TabIndex = 29;
            // 
            // cbx_letter7
            // 
            this.cbx_letter7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbx_letter7.Enabled = false;
            this.cbx_letter7.FormattingEnabled = true;
            this.cbx_letter7.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "Ç",
            "D",
            "E",
            "F",
            "G",
            "Ğ",
            "H",
            "I",
            "İ",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "Ö",
            "P",
            "R",
            "S",
            "Ş",
            "T",
            "U",
            "Ü",
            "V",
            "Y",
            "Z"});
            this.cbx_letter7.Location = new System.Drawing.Point(321, 90);
            this.cbx_letter7.Name = "cbx_letter7";
            this.cbx_letter7.Size = new System.Drawing.Size(42, 21);
            this.cbx_letter7.TabIndex = 28;
            // 
            // cbx_letter8
            // 
            this.cbx_letter8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbx_letter8.Enabled = false;
            this.cbx_letter8.FormattingEnabled = true;
            this.cbx_letter8.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "Ç",
            "D",
            "E",
            "F",
            "G",
            "Ğ",
            "H",
            "I",
            "İ",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "Ö",
            "P",
            "R",
            "S",
            "Ş",
            "T",
            "U",
            "Ü",
            "V",
            "Y",
            "Z"});
            this.cbx_letter8.Location = new System.Drawing.Point(369, 90);
            this.cbx_letter8.Name = "cbx_letter8";
            this.cbx_letter8.Size = new System.Drawing.Size(42, 21);
            this.cbx_letter8.TabIndex = 27;
            // 
            // cbx_letterJok
            // 
            this.cbx_letterJok.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbx_letterJok.Enabled = false;
            this.cbx_letterJok.FormattingEnabled = true;
            this.cbx_letterJok.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "Ç",
            "D",
            "E",
            "F",
            "G",
            "Ğ",
            "H",
            "I",
            "İ",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "Ö",
            "P",
            "R",
            "S",
            "Ş",
            "T",
            "U",
            "Ü",
            "V",
            "Y",
            "Z"});
            this.cbx_letterJok.Location = new System.Drawing.Point(42, 146);
            this.cbx_letterJok.Name = "cbx_letterJok";
            this.cbx_letterJok.Size = new System.Drawing.Size(42, 21);
            this.cbx_letterJok.TabIndex = 31;
            this.cbx_letterJok.SelectedIndexChanged += new System.EventHandler(this.cbx_letterJok_SelectedIndexChanged);
            // 
            // btnTahmin
            // 
            this.btnTahmin.BackColor = System.Drawing.Color.GhostWhite;
            this.btnTahmin.Enabled = false;
            this.btnTahmin.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTahmin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnTahmin.Location = new System.Drawing.Point(101, 144);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(75, 23);
            this.btnTahmin.TabIndex = 32;
            this.btnTahmin.Text = "Tahmin  -->";
            this.btnTahmin.UseVisualStyleBackColor = false;
            this.btnTahmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(171, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 18);
            this.label11.TabIndex = 35;
            this.label11.Text = "PUANINIZ: ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuan.Location = new System.Drawing.Point(270, 179);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(21, 24);
            this.lblPuan.TabIndex = 36;
            this.lblPuan.Text = "0";
            // 
            // lbxBulunanlar
            // 
            this.lbxBulunanlar.BackColor = System.Drawing.Color.Azure;
            this.lbxBulunanlar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxBulunanlar.FormattingEnabled = true;
            this.lbxBulunanlar.ItemHeight = 14;
            this.lbxBulunanlar.Location = new System.Drawing.Point(137, 206);
            this.lbxBulunanlar.Name = "lbxBulunanlar";
            this.lbxBulunanlar.Size = new System.Drawing.Size(181, 186);
            this.lbxBulunanlar.TabIndex = 55;
            // 
            // Kelime_İşlem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(484, 421);
            this.Controls.Add(this.lbxBulunanlar);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.cbx_letterJok);
            this.Controls.Add(this.cbx_letter5);
            this.Controls.Add(this.cbx_letter6);
            this.Controls.Add(this.cbx_letter7);
            this.Controls.Add(this.cbx_letter8);
            this.Controls.Add(this.cbx_letter3);
            this.Controls.Add(this.cbx_letter4);
            this.Controls.Add(this.cbx_letter2);
            this.Controls.Add(this.cbx_letter1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbxKelime);
            this.Controls.Add(this.btnHgir);
            this.Controls.Add(this.btnRandom);
            this.Name = "Kelime_İşlem";
            this.Text = "Kelime İşlem";
            this.Load += new System.EventHandler(this.Kelime_İşlem_Load);
            this.Enter += new System.EventHandler(this.btnCheck_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.just_letter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnHgir;
        private System.Windows.Forms.TextBox tbxKelime;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_letter1;
        private System.Windows.Forms.ComboBox cbx_letter2;
        private System.Windows.Forms.ComboBox cbx_letter3;
        private System.Windows.Forms.ComboBox cbx_letter4;
        private System.Windows.Forms.ComboBox cbx_letter5;
        private System.Windows.Forms.ComboBox cbx_letter6;
        private System.Windows.Forms.ComboBox cbx_letter7;
        private System.Windows.Forms.ComboBox cbx_letter8;
        private System.Windows.Forms.ComboBox cbx_letterJok;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPuan;
        public System.Windows.Forms.ListBox lbxBulunanlar;
    }
}

