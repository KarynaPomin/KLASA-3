/*
Stwórz za pomocą WinForms kilka aplikacji wg opisu:

1. Apka z buttonem, który kliknięty zamyka aplikację
2. Apka z textboxem i buttonem. Jeśli w textbox się wpisze bye to kliknięcie buttona zamknie aplikację
3. Apka z buttonem, który kliknięty pokazuje komunikat z bieżącą datą i po kliknięciu ok drugi komunikat z bieżącą godziną.
4. Apka z dwoma textboxami do wpisania dwóch liczb. Po kliknięciu w button na labelu poniżej ma się wyświetlić NWD i NWW liczb z textboxów. Nie rób walidacji, załóż, że user wpisał liczby.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox_1.Text == "bye")
                Close();       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("t"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString(@"dd \\ MM \\ yyyy"));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (int.Parse()).....
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
