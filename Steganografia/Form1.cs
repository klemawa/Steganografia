using System;
using System.Collections;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Steganografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonZaszyfrujTekst_Click(object sender, EventArgs e)
        {
            string tekstDoZaszyfrowania = textBoxDoZaszyfrowania.Text;
            int klucz;

            // Walidacja danych
            if (!int.TryParse(textBoxKlucz.Text, out klucz) || !ValidateTextToEncrypt(tekstDoZaszyfrowania) || !ValidateKey(textBoxKlucz.Text))
            {
                MessageBox.Show("Nieprawidłowe dane wejściowe!");
                return;
            }

            string tekstZaszyfrowany = SzyfrowanieTekstu(tekstDoZaszyfrowania, klucz);
            zaszyfrowanyTekst.Text = tekstZaszyfrowany;
        }


        private string SzyfrowanieTekstu(string textBoxDoZaszyfrowania, int klucz)
        {
            string zaszyfrowanyTekst = "";
            foreach (char c in textBoxDoZaszyfrowania)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    zaszyfrowanyTekst += (char)((((c + klucz) - offset) % 26) + offset);
                }
                else
                {
                    zaszyfrowanyTekst += c;
                }
            }
            return zaszyfrowanyTekst;
        }

        private void buttonKoduj_Click(object sender, EventArgs e)
        {
            string sciezka = textBoxSciezka.Text;
            string tekstDoZakodowania = textBoxDoZakodowania.Text;

            Bitmap obraz = new Bitmap(sciezka);
            BitArray lengthBits = new BitArray(BitConverter.GetBytes(tekstDoZakodowania.Length));

            // konwertowanie tekst na tablicę bitów
            BitArray textBits = new BitArray(tekstDoZakodowania.Length * 8); // 8 bitów
            for (int i = 0; i < tekstDoZakodowania.Length; i++)
            {
                byte[] charBytes = System.Text.Encoding.ASCII.GetBytes(tekstDoZakodowania[i].ToString());
                for (int j = 0; j < 8; j++)
                {
                    textBits[i * 8 + j] = (charBytes[0] & (1 << (7 - j))) != 0;
                }
            }

            //łączeni długość tekstu i tekst w jedną tablicę bitów
            BitArray combinedBits = new BitArray(lengthBits.Length + textBits.Length);
            for (int i = 0; i < lengthBits.Length; i++)
            {
                combinedBits[i] = lengthBits[i];
            }
            for (int i = 0; i < textBits.Length; i++)
            {
                combinedBits[i + lengthBits.Length] = textBits[i];
            }

            byte[] combinedBytes = new byte[(combinedBits.Length - 1) / 8 + 1];
            combinedBits.CopyTo(combinedBytes, 0);

            int textLength = combinedBits.Length / 8; 

            MessageBox.Show("Długość tekstu: " + tekstDoZakodowania.Length);
            MessageBox.Show("Długość tablicy bajtów: " + textLength);


            int maxTextLength = obraz.Width * obraz.Height * 3;

            if (textLength > maxTextLength)
            {
                MessageBox.Show("Tekst jest zbyt długi, aby go zakodować w tym obrazie.");
                return;
            }

            int textIndex = 0;

            for (int y = 0; y < obraz.Height; y++)
            {
                for (int x = 0; x < obraz.Width; x++)
                {
                    Color pixel = obraz.GetPixel(x, y);

                    if (textIndex < textLength)
                    {
                        pixel = Color.FromArgb(
                            pixel.R & ~1 | ((combinedBytes[textIndex / 8] >> (7 - (textIndex % 8))) & 1),
                            pixel.G & ~1 | ((combinedBytes[(textIndex + 1) / 8] >> (7 - ((textIndex + 1) % 8))) & 1),
                            pixel.B & ~1 | ((combinedBytes[(textIndex + 2) / 8] >> (7 - ((textIndex + 2) % 8))) & 1)
                        );
                        obraz.SetPixel(x, y, pixel);
                        textIndex += 3;
                    }
                    else
                    {
                        break;
                    }
                }
                if (textIndex >= textLength)
                {
                    break;
                }
            }

            obraz.Save("encoded_image.bmp");
            MessageBox.Show("Tekst został zakodowany w obrazie.");

            // Walidacja danych
            if (!ValidateFilePath(sciezka) || !ValidateTextToEncrypt(tekstDoZakodowania))
            {
                MessageBox.Show("Nieprawidłowe dane wejściowe!");
                return;
            }
        }



        private void buttonOdkoduj_Click(object sender, EventArgs e)
        {
            string sciezkaZakodowanegoObrazu = textBoxSciezkaDoZakodowanegoObrazu.Text;
            Bitmap obrazZakodowany = new Bitmap(sciezkaZakodowanegoObrazu);

            string odkodowanyTekstZObrazu = OdkodujTekst(obrazZakodowany);
            textBoxTekstZakodowanyWObrazie.Text = odkodowanyTekstZObrazu;

        }

        private string OdkodujTekst(Bitmap obrazZakodowany)
        {
            BitArray textBits = new BitArray(obrazZakodowany.Width * obrazZakodowany.Height * 3);

            int textIndex = 0;

            for (int y = 0; y < obrazZakodowany.Height; y++)
            {
                for (int x = 0; x < obrazZakodowany.Width; x++)
                {
                    Color pixel = obrazZakodowany.GetPixel(x, y);

                    if (textIndex < textBits.Length)
                    {
                        textBits[textIndex++] = (pixel.R & 1) == 1;
                        textBits[textIndex++] = (pixel.G & 1) == 1;
                        textBits[textIndex++] = (pixel.B & 1) == 1;
                    }
                    else
                    {
                        break;
                    }
                }
                if (textIndex >= textBits.Length)
                {
                    break;
                }
            }
            //konwertowanie tablicy bitów na tekst

            int byteLength = (textBits.Length + 7) / 8;
            byte[] textBytes = new byte[byteLength];
            textBits.CopyTo(textBytes, 0);

            string odkodowanyTekst = System.Text.Encoding.ASCII.GetString(textBytes);

            return odkodowanyTekst;
        }


        private string OdszyfrowanieTekstu(string textBoxDoOdszyfrowania, int klucz2)
        {
            string odszyfrowanyTekst = "";
            foreach (char c in textBoxDoOdszyfrowania)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    int shifted = c - offset - klucz2;
                    shifted = (shifted + 26) % 26; 
                    odszyfrowanyTekst += (char)(shifted + offset);
                }
                else
                {
                    odszyfrowanyTekst += c;
                }
            }
            return odszyfrowanyTekst;
        }

        private void buttonOdszyfruj_Click_1(object sender, EventArgs e)
        {
            string tekstDoOdszyfrowania = textBoxZaszyfrowanyTekstZObrazu.Text;
            int klucz2;

            // Walidacja danych
            if (!int.TryParse(textBoxKluczDoOdszyfrowania.Text, out klucz2) || !ValidateTextToDecrypt(tekstDoOdszyfrowania) || !ValidateKey(textBoxKluczDoOdszyfrowania.Text))
            {
                MessageBox.Show("Nieprawidłowe dane wejściowe!");
                return;
            }

            string tekstOdszyfrowany = OdszyfrowanieTekstu(tekstDoOdszyfrowania, klucz2);
            textBoxOdszyfrowanyTekst.Text = tekstOdszyfrowany;
        }


        //sprawdzanie poprawności klucza
        private bool ValidateKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return false;
            //czy klucz składa się tylko z cyfr
            if (!Regex.IsMatch(key, @"^\d+$"))
                return false;
            return true;
        }

        //sprawdzanie poprawności ścieżki pliku
        private bool ValidateFilePath(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                return false;
            return true;
        }

        private bool ValidateTextToEncrypt(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;
            return true;
        }

        // zcy textBox nie pusty
        private bool ValidateTextToDecrypt(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;
            return true;
        }
    }
}
