namespace LatvanyossagokApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lakosokSzama = new System.Windows.Forms.NumericUpDown();
            this.varosHozzaad = new System.Windows.Forms.Button();
            this.varosNev = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.latvanyossagHozzaad = new System.Windows.Forms.Button();
            this.latvanyossagLeiras = new System.Windows.Forms.TextBox();
            this.latvanyossagAr = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.latvanyossagNev = new System.Windows.Forms.TextBox();
            this.varosLista = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.varosTorol = new System.Windows.Forms.Button();
            this.varosModosit = new System.Windows.Forms.Button();
            this.lakossagSzamModosit = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.varosNevModosit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.latvanyossagTorles = new System.Windows.Forms.Button();
            this.latvanyossagModosit = new System.Windows.Forms.Button();
            this.latvanyossagLeirasModosit = new System.Windows.Forms.TextBox();
            this.latvanyossagArModosit = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.latvanyossagNevModosit = new System.Windows.Forms.TextBox();
            this.latvanyossagLista = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lakosokSzama)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossagAr)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lakossagSzamModosit)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossagArModosit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lakosokSzama);
            this.groupBox1.Controls.Add(this.varosHozzaad);
            this.groupBox1.Controls.Add(this.varosNev);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Város hozzáadása:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lakosok száma:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Név:";
            // 
            // lakosokSzama
            // 
            this.lakosokSzama.Location = new System.Drawing.Point(96, 53);
            this.lakosokSzama.Name = "lakosokSzama";
            this.lakosokSzama.Size = new System.Drawing.Size(120, 20);
            this.lakosokSzama.TabIndex = 1;
            this.lakosokSzama.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // varosHozzaad
            // 
            this.varosHozzaad.Location = new System.Drawing.Point(242, 32);
            this.varosHozzaad.Name = "varosHozzaad";
            this.varosHozzaad.Size = new System.Drawing.Size(75, 23);
            this.varosHozzaad.TabIndex = 2;
            this.varosHozzaad.Text = "OK";
            this.varosHozzaad.UseVisualStyleBackColor = true;
            this.varosHozzaad.Click += new System.EventHandler(this.varosHozzaad_Click);
            // 
            // varosNev
            // 
            this.varosNev.Location = new System.Drawing.Point(96, 19);
            this.varosNev.Name = "varosNev";
            this.varosNev.Size = new System.Drawing.Size(100, 20);
            this.varosNev.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.varosTorol);
            this.groupBox2.Controls.Add(this.latvanyossagHozzaad);
            this.groupBox2.Controls.Add(this.latvanyossagLeiras);
            this.groupBox2.Controls.Add(this.latvanyossagAr);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.latvanyossagNev);
            this.groupBox2.Controls.Add(this.varosLista);
            this.groupBox2.Location = new System.Drawing.Point(13, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Látványosság hozzáadása:";
            // 
            // latvanyossagHozzaad
            // 
            this.latvanyossagHozzaad.Location = new System.Drawing.Point(242, 150);
            this.latvanyossagHozzaad.Name = "latvanyossagHozzaad";
            this.latvanyossagHozzaad.Size = new System.Drawing.Size(75, 23);
            this.latvanyossagHozzaad.TabIndex = 7;
            this.latvanyossagHozzaad.Text = "OK";
            this.latvanyossagHozzaad.UseVisualStyleBackColor = true;
            this.latvanyossagHozzaad.Click += new System.EventHandler(this.latvanyossagHozzaad_Click);
            // 
            // latvanyossagLeiras
            // 
            this.latvanyossagLeiras.Location = new System.Drawing.Point(198, 51);
            this.latvanyossagLeiras.Name = "latvanyossagLeiras";
            this.latvanyossagLeiras.Size = new System.Drawing.Size(100, 20);
            this.latvanyossagLeiras.TabIndex = 6;
            // 
            // latvanyossagAr
            // 
            this.latvanyossagAr.Location = new System.Drawing.Point(197, 82);
            this.latvanyossagAr.Name = "latvanyossagAr";
            this.latvanyossagAr.Size = new System.Drawing.Size(120, 20);
            this.latvanyossagAr.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ár:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Leírás:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Név:";
            // 
            // latvanyossagNev
            // 
            this.latvanyossagNev.Location = new System.Drawing.Point(198, 20);
            this.latvanyossagNev.Name = "latvanyossagNev";
            this.latvanyossagNev.Size = new System.Drawing.Size(100, 20);
            this.latvanyossagNev.TabIndex = 1;
            // 
            // varosLista
            // 
            this.varosLista.FormattingEnabled = true;
            this.varosLista.Location = new System.Drawing.Point(7, 20);
            this.varosLista.Name = "varosLista";
            this.varosLista.Size = new System.Drawing.Size(120, 121);
            this.varosLista.TabIndex = 0;
            this.varosLista.SelectedIndexChanged += new System.EventHandler(this.varosLista_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.varosModosit);
            this.groupBox3.Controls.Add(this.lakossagSzamModosit);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.varosNevModosit);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(379, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 147);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Város módosítása és törlése:";
            // 
            // varosTorol
            // 
            this.varosTorol.Location = new System.Drawing.Point(7, 147);
            this.varosTorol.Name = "varosTorol";
            this.varosTorol.Size = new System.Drawing.Size(120, 23);
            this.varosTorol.TabIndex = 6;
            this.varosTorol.Text = "Törlés";
            this.varosTorol.UseVisualStyleBackColor = true;
            this.varosTorol.Click += new System.EventHandler(this.varosTorol_Click);
            // 
            // varosModosit
            // 
            this.varosModosit.Location = new System.Drawing.Point(234, 107);
            this.varosModosit.Name = "varosModosit";
            this.varosModosit.Size = new System.Drawing.Size(75, 23);
            this.varosModosit.TabIndex = 5;
            this.varosModosit.Text = "OK";
            this.varosModosit.UseVisualStyleBackColor = true;
            this.varosModosit.Click += new System.EventHandler(this.varosModosit_Click);
            // 
            // lakossagSzamModosit
            // 
            this.lakossagSzamModosit.Location = new System.Drawing.Point(96, 48);
            this.lakossagSzamModosit.Name = "lakossagSzamModosit";
            this.lakossagSzamModosit.Size = new System.Drawing.Size(120, 20);
            this.lakossagSzamModosit.TabIndex = 5;
            this.lakossagSzamModosit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lakosok száma:";
            // 
            // varosNevModosit
            // 
            this.varosNevModosit.Location = new System.Drawing.Point(42, 19);
            this.varosNevModosit.Name = "varosNevModosit";
            this.varosNevModosit.Size = new System.Drawing.Size(100, 20);
            this.varosNevModosit.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Név:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.latvanyossagTorles);
            this.groupBox4.Controls.Add(this.latvanyossagModosit);
            this.groupBox4.Controls.Add(this.latvanyossagLeirasModosit);
            this.groupBox4.Controls.Add(this.latvanyossagArModosit);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.latvanyossagNevModosit);
            this.groupBox4.Controls.Add(this.latvanyossagLista);
            this.groupBox4.Location = new System.Drawing.Point(379, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(359, 182);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Látványosság hozzáadása:";
            // 
            // latvanyossagTorles
            // 
            this.latvanyossagTorles.Location = new System.Drawing.Point(7, 147);
            this.latvanyossagTorles.Name = "latvanyossagTorles";
            this.latvanyossagTorles.Size = new System.Drawing.Size(120, 23);
            this.latvanyossagTorles.TabIndex = 7;
            this.latvanyossagTorles.Text = "Törlés";
            this.latvanyossagTorles.UseVisualStyleBackColor = true;
            this.latvanyossagTorles.Click += new System.EventHandler(this.latvanyossagTorles_Click);
            // 
            // latvanyossagModosit
            // 
            this.latvanyossagModosit.Location = new System.Drawing.Point(259, 147);
            this.latvanyossagModosit.Name = "latvanyossagModosit";
            this.latvanyossagModosit.Size = new System.Drawing.Size(75, 23);
            this.latvanyossagModosit.TabIndex = 7;
            this.latvanyossagModosit.Text = "OK";
            this.latvanyossagModosit.UseVisualStyleBackColor = true;
            // 
            // latvanyossagLeirasModosit
            // 
            this.latvanyossagLeirasModosit.Location = new System.Drawing.Point(198, 51);
            this.latvanyossagLeirasModosit.Name = "latvanyossagLeirasModosit";
            this.latvanyossagLeirasModosit.Size = new System.Drawing.Size(100, 20);
            this.latvanyossagLeirasModosit.TabIndex = 6;
            // 
            // latvanyossagArModosit
            // 
            this.latvanyossagArModosit.Location = new System.Drawing.Point(197, 82);
            this.latvanyossagArModosit.Name = "latvanyossagArModosit";
            this.latvanyossagArModosit.Size = new System.Drawing.Size(120, 20);
            this.latvanyossagArModosit.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ár:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Leírás:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Név:";
            // 
            // latvanyossagNevModosit
            // 
            this.latvanyossagNevModosit.Location = new System.Drawing.Point(198, 20);
            this.latvanyossagNevModosit.Name = "latvanyossagNevModosit";
            this.latvanyossagNevModosit.Size = new System.Drawing.Size(100, 20);
            this.latvanyossagNevModosit.TabIndex = 1;
            // 
            // latvanyossagLista
            // 
            this.latvanyossagLista.FormattingEnabled = true;
            this.latvanyossagLista.Location = new System.Drawing.Point(7, 20);
            this.latvanyossagLista.Name = "latvanyossagLista";
            this.latvanyossagLista.Size = new System.Drawing.Size(120, 121);
            this.latvanyossagLista.TabIndex = 0;
            this.latvanyossagLista.SelectedIndexChanged += new System.EventHandler(this.latvanyossagLista_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "x";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lakosokSzama)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossagAr)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lakossagSzamModosit)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossagArModosit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown lakosokSzama;
        private System.Windows.Forms.TextBox varosNev;
        private System.Windows.Forms.Button varosHozzaad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button latvanyossagHozzaad;
        private System.Windows.Forms.TextBox latvanyossagLeiras;
        private System.Windows.Forms.NumericUpDown latvanyossagAr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox latvanyossagNev;
        private System.Windows.Forms.ListBox varosLista;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button varosTorol;
        private System.Windows.Forms.Button varosModosit;
        private System.Windows.Forms.NumericUpDown lakossagSzamModosit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox varosNevModosit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button latvanyossagTorles;
        private System.Windows.Forms.Button latvanyossagModosit;
        private System.Windows.Forms.TextBox latvanyossagLeirasModosit;
        private System.Windows.Forms.NumericUpDown latvanyossagArModosit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox latvanyossagNevModosit;
        private System.Windows.Forms.ListBox latvanyossagLista;
    }
}

