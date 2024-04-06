namespace Steganografia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDoZaszyfrowania = new System.Windows.Forms.TextBox();
            this.textBoxKlucz = new System.Windows.Forms.TextBox();
            this.textBoxTekstZakodowanyWObrazie = new System.Windows.Forms.TextBox();
            this.zaszyfrowanyTekst = new System.Windows.Forms.TextBox();
            this.buttonZaszyfrujTekst = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDoZakodowania = new System.Windows.Forms.TextBox();
            this.textBoxSciezka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonKoduj = new System.Windows.Forms.Button();
            this.buttonOdkoduj = new System.Windows.Forms.Button();
            this.textBoxSciezkaDoZakodowanegoObrazu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxZaszyfrowanyTekstZObrazu = new System.Windows.Forms.TextBox();
            this.buttonOdszyfruj = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxOdszyfrowanyTekst = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxKluczDoOdszyfrowania = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(64, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zaszyfruj tekst ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(64, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odszyfruj tekst ";
            // 
            // textBoxDoZaszyfrowania
            // 
            this.textBoxDoZaszyfrowania.Location = new System.Drawing.Point(69, 77);
            this.textBoxDoZaszyfrowania.Name = "textBoxDoZaszyfrowania";
            this.textBoxDoZaszyfrowania.Size = new System.Drawing.Size(331, 20);
            this.textBoxDoZaszyfrowania.TabIndex = 4;
            // 
            // textBoxKlucz
            // 
            this.textBoxKlucz.Location = new System.Drawing.Point(69, 133);
            this.textBoxKlucz.Name = "textBoxKlucz";
            this.textBoxKlucz.Size = new System.Drawing.Size(331, 20);
            this.textBoxKlucz.TabIndex = 5;
            // 
            // textBoxTekstZakodowanyWObrazie
            // 
            this.textBoxTekstZakodowanyWObrazie.Location = new System.Drawing.Point(606, 486);
            this.textBoxTekstZakodowanyWObrazie.Name = "textBoxTekstZakodowanyWObrazie";
            this.textBoxTekstZakodowanyWObrazie.Size = new System.Drawing.Size(321, 20);
            this.textBoxTekstZakodowanyWObrazie.TabIndex = 6;
            // 
            // zaszyfrowanyTekst
            // 
            this.zaszyfrowanyTekst.Location = new System.Drawing.Point(69, 221);
            this.zaszyfrowanyTekst.Name = "zaszyfrowanyTekst";
            this.zaszyfrowanyTekst.Size = new System.Drawing.Size(331, 20);
            this.zaszyfrowanyTekst.TabIndex = 7;
            // 
            // buttonZaszyfrujTekst
            // 
            this.buttonZaszyfrujTekst.Location = new System.Drawing.Point(69, 165);
            this.buttonZaszyfrujTekst.Name = "buttonZaszyfrujTekst";
            this.buttonZaszyfrujTekst.Size = new System.Drawing.Size(75, 23);
            this.buttonZaszyfrujTekst.TabIndex = 8;
            this.buttonZaszyfrujTekst.Text = "Szyfruj";
            this.buttonZaszyfrujTekst.UseVisualStyleBackColor = true;
            this.buttonZaszyfrujTekst.Click += new System.EventHandler(this.buttonZaszyfrujTekst_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Podaj tekst ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Podaj klucz przesunięcia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Zaszyfrowany tekst";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(600, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kodowanie tekstu ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Podaj tekst do zakodowania ";
            // 
            // textBoxDoZakodowania
            // 
            this.textBoxDoZakodowania.Location = new System.Drawing.Point(605, 110);
            this.textBoxDoZakodowania.Name = "textBoxDoZakodowania";
            this.textBoxDoZakodowania.Size = new System.Drawing.Size(321, 20);
            this.textBoxDoZakodowania.TabIndex = 14;
            // 
            // textBoxSciezka
            // 
            this.textBoxSciezka.Location = new System.Drawing.Point(605, 156);
            this.textBoxSciezka.Name = "textBoxSciezka";
            this.textBoxSciezka.Size = new System.Drawing.Size(321, 20);
            this.textBoxSciezka.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(602, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Podaj ścieżkę do obrazu";
            // 
            // buttonKoduj
            // 
            this.buttonKoduj.Location = new System.Drawing.Point(605, 195);
            this.buttonKoduj.Name = "buttonKoduj";
            this.buttonKoduj.Size = new System.Drawing.Size(75, 23);
            this.buttonKoduj.TabIndex = 17;
            this.buttonKoduj.Text = "Koduj";
            this.buttonKoduj.UseVisualStyleBackColor = true;
            this.buttonKoduj.Click += new System.EventHandler(this.buttonKoduj_Click);
            // 
            // buttonOdkoduj
            // 
            this.buttonOdkoduj.Location = new System.Drawing.Point(605, 401);
            this.buttonOdkoduj.Name = "buttonOdkoduj";
            this.buttonOdkoduj.Size = new System.Drawing.Size(75, 23);
            this.buttonOdkoduj.TabIndex = 18;
            this.buttonOdkoduj.Text = "Odkoduj";
            this.buttonOdkoduj.UseVisualStyleBackColor = true;
            this.buttonOdkoduj.Click += new System.EventHandler(this.buttonOdkoduj_Click);
            // 
            // textBoxSciezkaDoZakodowanegoObrazu
            // 
            this.textBoxSciezkaDoZakodowanegoObrazu.Location = new System.Drawing.Point(605, 365);
            this.textBoxSciezkaDoZakodowanegoObrazu.Name = "textBoxSciezkaDoZakodowanegoObrazu";
            this.textBoxSciezkaDoZakodowanegoObrazu.Size = new System.Drawing.Size(321, 20);
            this.textBoxSciezkaDoZakodowanegoObrazu.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(602, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Podaj ścieżkę do zakodowanego obrazu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(603, 470);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Zakodowany tekst w obrazie";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(644, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "w obrazie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(600, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(258, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Odkoduj tekst z obrazu";
            // 
            // textBoxZaszyfrowanyTekstZObrazu
            // 
            this.textBoxZaszyfrowanyTekstZObrazu.Location = new System.Drawing.Point(69, 365);
            this.textBoxZaszyfrowanyTekstZObrazu.Name = "textBoxZaszyfrowanyTekstZObrazu";
            this.textBoxZaszyfrowanyTekstZObrazu.Size = new System.Drawing.Size(331, 20);
            this.textBoxZaszyfrowanyTekstZObrazu.TabIndex = 24;
            // 
            // buttonOdszyfruj
            // 
            this.buttonOdszyfruj.Location = new System.Drawing.Point(69, 444);
            this.buttonOdszyfruj.Name = "buttonOdszyfruj";
            this.buttonOdszyfruj.Size = new System.Drawing.Size(75, 23);
            this.buttonOdszyfruj.TabIndex = 26;
            this.buttonOdszyfruj.Text = "Odszyfruj";
            this.buttonOdszyfruj.UseVisualStyleBackColor = true;
            this.buttonOdszyfruj.Click += new System.EventHandler(this.buttonOdszyfruj_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Podaj zaszyfrowany tekst z obrazu";
            // 
            // textBoxOdszyfrowanyTekst
            // 
            this.textBoxOdszyfrowanyTekst.Location = new System.Drawing.Point(69, 509);
            this.textBoxOdszyfrowanyTekst.Name = "textBoxOdszyfrowanyTekst";
            this.textBoxOdszyfrowanyTekst.Size = new System.Drawing.Size(331, 20);
            this.textBoxOdszyfrowanyTekst.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(65, 493);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Odszyfrowany tekst";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(66, 401);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(217, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Podaj klucz który był uzyty do zaszyfrowania";
            // 
            // textBoxKluczDoOdszyfrowania
            // 
            this.textBoxKluczDoOdszyfrowania.Location = new System.Drawing.Point(69, 418);
            this.textBoxKluczDoOdszyfrowania.Name = "textBoxKluczDoOdszyfrowania";
            this.textBoxKluczDoOdszyfrowania.Size = new System.Drawing.Size(331, 20);
            this.textBoxKluczDoOdszyfrowania.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 590);
            this.Controls.Add(this.textBoxKluczDoOdszyfrowania);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxOdszyfrowanyTekst);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonOdszyfruj);
            this.Controls.Add(this.textBoxZaszyfrowanyTekstZObrazu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSciezkaDoZakodowanegoObrazu);
            this.Controls.Add(this.buttonOdkoduj);
            this.Controls.Add(this.buttonKoduj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSciezka);
            this.Controls.Add(this.textBoxDoZakodowania);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonZaszyfrujTekst);
            this.Controls.Add(this.zaszyfrowanyTekst);
            this.Controls.Add(this.textBoxTekstZakodowanyWObrazie);
            this.Controls.Add(this.textBoxKlucz);
            this.Controls.Add(this.textBoxDoZaszyfrowania);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDoZaszyfrowania;
        private System.Windows.Forms.TextBox textBoxKlucz;
        private System.Windows.Forms.TextBox textBoxTekstZakodowanyWObrazie;
        private System.Windows.Forms.TextBox zaszyfrowanyTekst;
        private System.Windows.Forms.Button buttonZaszyfrujTekst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDoZakodowania;
        private System.Windows.Forms.TextBox textBoxSciezka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonKoduj;
        private System.Windows.Forms.Button buttonOdkoduj;
        private System.Windows.Forms.TextBox textBoxSciezkaDoZakodowanegoObrazu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxZaszyfrowanyTekstZObrazu;
        private System.Windows.Forms.Button buttonOdszyfruj;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxOdszyfrowanyTekst;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxKluczDoOdszyfrowania;
    }
}

