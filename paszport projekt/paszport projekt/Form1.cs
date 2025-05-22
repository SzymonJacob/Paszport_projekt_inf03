using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
namespace paszport_projekt
{
    public partial class Form1 : Form
    {
        
        private string eyes_color;//Zmienna do przechowywania koloru oczu
        public Form1()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += radioButton_CheckedChanged;//przycisk radiobutton
            radioButton2.CheckedChanged += radioButton_CheckedChanged;//przycisk radiobutton
            radioButton3.CheckedChanged += radioButton_CheckedChanged;//przycisk radiobutton
            radioButton4.CheckedChanged += radioButton_CheckedChanged;//przycisk radiobutton
            radioButton5.CheckedChanged += radioButton_CheckedChanged;//przycisk radiobutton
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Wprowadzenie numerów zdjęć
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Wprowadzenie imienia
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Wprowadzenie nazwiska
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;//nie oznacza nazwy użytkownika. Jest to funkcja, która zwraca katalog bazowy aplikacji (czyli folder, w którym znajduje się plik wykonywalny .exe Twojej aplikacji).
            string fileName = textBox1.Text;// Pobranie numeru z textBox1
            MessageBox.Show(textBox2.Text+"  "+textBox3.Text+" ma kolor oczu "+eyes_color);//Okienko, które wyswietla imie,nazwisko oraz wybrany przez użytkownika kolor oczu
            if (string.IsNullOrEmpty(fileName))//Jezeli nie wpisano numerów to wyswieli messagebox z proba o wpisanie numerow
            {
                MessageBox.Show("BRAK WPISANEGO NUMERU!\nProszę wpisać numer 000,111,333", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);//informujacy messagebox
                return;
            }

            try//probowanie odczytu zdjec
            {
                pictureBox1.Image = System.Drawing.Image.FromFile($"{basePath}{fileName}-zdjecie.jpg");// Próba załadowania zdjęcia na podstawie numeru
                pictureBox2.Image = System.Drawing.Image.FromFile($"{basePath}{fileName}-odcisk.jpg"); // Próba załadowania zdjęcia na podstawie numeru
            }
            catch
            {
                MessageBox.Show("ZLY NUMER!!!\nWpisz numer 000,111 czy 333");// Jeśli wystąpi błąd (brak plików),(zly numer), wyświetl komunikat

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;// Rzutowanie sender na RadioButton
            if (rb != null && rb.Checked)// Jeśli radioButton istnieje i jest zaznaczony, przypisz jego tekst do eyes_color
            {
                eyes_color = rb.Text; // Przypisanie tekstu wybranego radiobuttona do zmiennej
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) // Zdarzenie kliknięcia na pictureBox1
        {
            //PUSTE
        }

        private void pictureBox2_Click(object sender, EventArgs e) // Zdarzenie kliknięcia na pictureBox2
        {
            //PUSTE
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)//zdarzenie niechcący dodane do radiobutton4
        {
            //PUSTE
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)//zdarzenie niechcący dodane do radiobutton5
        {
            //PUSTE
        }
    }
}
