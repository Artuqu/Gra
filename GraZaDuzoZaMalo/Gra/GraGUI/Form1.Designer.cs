namespace GraGUI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.groupBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPoddaj = new System.Windows.Forms.Button();
            this.groupBoxOdgadywanie = new System.Windows.Forms.GroupBox();
            this.labelOcena = new System.Windows.Forms.Label();
            this.buttonWyslij = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxLosowanie.SuspendLayout();
            this.groupBoxOdgadywanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(35, 47);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "NowaGra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(53, 19);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxOd.TabIndex = 1;
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(53, 69);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDo.TabIndex = 2;
            this.textBoxDo.TextChanged += new System.EventHandler(this.textBoxDo_TextChanged);
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(187, 51);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonLosuj.TabIndex = 3;
            this.buttonLosuj.Text = "Losuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // groupBoxLosowanie
            // 
            this.groupBoxLosowanie.Controls.Add(this.label3);
            this.groupBoxLosowanie.Controls.Add(this.label2);
            this.groupBoxLosowanie.Controls.Add(this.buttonLosuj);
            this.groupBoxLosowanie.Controls.Add(this.textBoxOd);
            this.groupBoxLosowanie.Controls.Add(this.textBoxDo);
            this.groupBoxLosowanie.Location = new System.Drawing.Point(35, 76);
            this.groupBoxLosowanie.Name = "groupBoxLosowanie";
            this.groupBoxLosowanie.Size = new System.Drawing.Size(289, 189);
            this.groupBoxLosowanie.TabIndex = 4;
            this.groupBoxLosowanie.TabStop = false;
            this.groupBoxLosowanie.Text = "Losowanie";
            this.groupBoxLosowanie.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Od:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonPoddaj
            // 
            this.buttonPoddaj.Location = new System.Drawing.Point(317, 47);
            this.buttonPoddaj.Name = "buttonPoddaj";
            this.buttonPoddaj.Size = new System.Drawing.Size(75, 23);
            this.buttonPoddaj.TabIndex = 5;
            this.buttonPoddaj.Text = "Poddaję się";
            this.buttonPoddaj.UseVisualStyleBackColor = true;
            this.buttonPoddaj.Visible = false;
            this.buttonPoddaj.Click += new System.EventHandler(this.buttonPoddaj_Click);
            // 
            // groupBoxOdgadywanie
            // 
            this.groupBoxOdgadywanie.Controls.Add(this.labelOcena);
            this.groupBoxOdgadywanie.Controls.Add(this.buttonWyslij);
            this.groupBoxOdgadywanie.Controls.Add(this.textBox1);
            this.groupBoxOdgadywanie.Controls.Add(this.label1);
            this.groupBoxOdgadywanie.Location = new System.Drawing.Point(35, 282);
            this.groupBoxOdgadywanie.Name = "groupBoxOdgadywanie";
            this.groupBoxOdgadywanie.Size = new System.Drawing.Size(289, 96);
            this.groupBoxOdgadywanie.TabIndex = 6;
            this.groupBoxOdgadywanie.TabStop = false;
            this.groupBoxOdgadywanie.Text = "Odgadnij";
            this.groupBoxOdgadywanie.Visible = false;
            // 
            // labelOcena
            // 
            this.labelOcena.AutoSize = true;
            this.labelOcena.Location = new System.Drawing.Point(19, 77);
            this.labelOcena.Name = "labelOcena";
            this.labelOcena.Size = new System.Drawing.Size(35, 13);
            this.labelOcena.TabIndex = 3;
            this.labelOcena.Text = "label4";
            // 
            // buttonWyslij
            // 
            this.buttonWyslij.Location = new System.Drawing.Point(170, 43);
            this.buttonWyslij.Name = "buttonWyslij";
            this.buttonWyslij.Size = new System.Drawing.Size(75, 23);
            this.buttonWyslij.TabIndex = 2;
            this.buttonWyslij.Text = "Wyślij";
            this.buttonWyslij.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wylosowałem liczbę odgadnij ją";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 457);
            this.Controls.Add(this.groupBoxOdgadywanie);
            this.Controls.Add(this.buttonPoddaj);
            this.Controls.Add(this.groupBoxLosowanie);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxLosowanie.ResumeLayout(false);
            this.groupBoxLosowanie.PerformLayout();
            this.groupBoxOdgadywanie.ResumeLayout(false);
            this.groupBoxOdgadywanie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.GroupBox groupBoxLosowanie;
        private System.Windows.Forms.Button buttonPoddaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOcena;
        private System.Windows.Forms.Button buttonWyslij;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxOdgadywanie;
    }
}

