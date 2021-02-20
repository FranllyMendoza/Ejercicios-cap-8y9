using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_cap_8y9
{
    public partial class Ejercicio8_5 : Form
    {
        public Ejercicio8_5()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            string menor, mayor;
            if (Cadena2TextBox.Text.CompareTo(Cadena1TextBox.Text) < 0)
            {
                menor = Cadena1TextBox.Text;
                mayor = Cadena2TextBox.Text;
            }
            else
            {
                mayor = Cadena1TextBox.Text;
                menor = Cadena2TextBox.Text;
            }
            listaDecadenaslist.Items.Add("1. " + mayor);
            listaDecadenaslist.Items.Add("2. " + menor);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            listaDecadenaslist.Items.Clear();
            Cadena2TextBox.Clear();
            Cadena1TextBox.Clear();
        }
    }
}
