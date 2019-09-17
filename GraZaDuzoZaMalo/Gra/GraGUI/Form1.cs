using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraLib;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private ModelGry gra;
        private object goupBoxOdgadywanie;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxLosowanie.Visible = true;
            buttonNowaGra.Enabled = false;
            buttonPoddaj.Visible = true;
        }

        private void buttonPoddaj_Click(object sender, EventArgs e)
        {
            buttonPoddaj.Visible = false;
            buttonNowaGra.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            int x;
            try
            {
                 x = int.Parse(textBoxOd.Text);
                
            }
            catch(FormatException)
            {
                textBoxOd.BackColor = Color.Red;
                return;
            }
            textBoxOd.BackColor = Color.White;

            int y = int.Parse(textBoxDo.Text);

            groupBoxLosowanie.Enabled = false;
            groupBoxOdgadywanie.Visible = true;
            

            gra = new ModelGry(x,y);
            
        }

        private void textBoxDo_TextChanged(object sender, EventArgs e)
        {
            int wynik;
            if (int.TryParse(textBoxDo.Text, out wynik))
                textBoxDo.BackColor = Color.LightGreen;
            else
                textBoxDo.BackColor = Color.LightPink; //int.Parse() na wejściu string '123' i konwersja na int 123 jeżeli się nie uda to jest wyjątek
            // może być też TryParse od razu daje wynik prawda lub fałsz
        }
    }
}
