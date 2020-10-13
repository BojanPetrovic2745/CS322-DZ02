using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_DZ02_BojanPetrovic2745
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            
            
            string ime = tbIme.Text;
            string prezime = tbPrezime.Text;
            string adresa = tbAdresa.Text;

            if(isImeAdresaValid(ime, adresa))
            {
                MessageBox.Show("Ime je validno, podaci su " +  ime + " " + prezime + " " + adresa);
            }
            else
            {
                MessageBox.Show("Ime i adresa nisu validni! Ime mora biti jedna reč, adresa više od jedne reči");
            }
        }

        public static bool isImeAdresaValid(string ime, string adresa)
        {
            string regexIme = @"^\b[a-zA-Z0-9_]+\b$";
            string regexAdresa = @"\w\s\w";

            Regex reIme = new Regex(regexIme);
            Regex reAdresa = new Regex(regexAdresa);

            if (reIme.IsMatch(ime) && reAdresa.IsMatch(adresa))
                return (true);
            else
                return (false);
        }

    }
}
