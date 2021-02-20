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
    public partial class Ejercicio9_3 : Form
    {
        public Ejercicio9_3()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            NombreDueñoTextBox.Clear();
            DireccionTextBox.Clear();
            TelefonoMaskedTextBox.Clear();
            NombreMascotaTextBox.Clear();
            RazaTextBox.Clear();
        }
        public struct Dueño
        {
            public string Nombre;
            public string Direccion;
            public string Telefono;

            public Dueño(string Nombre, string Direccion, string Telefono)
            {
                this.Nombre = Nombre;
                this.Direccion = Direccion;
                this.Telefono = Telefono;
            }
        }

        public struct Mascota
        {
            public string Nombre;
            public string Raza;
            public Dueño Propietario;

            public Mascota(string Nombre, string Raza, string NombreD, string Direccion, string Telefono)
            {
                this.Nombre = Nombre;
                this.Raza = Raza;
                Propietario = new Dueño(NombreD, Direccion, Telefono);
            }
        }
 
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            string NombreD = NombreDueñoTextBox.Text;
            string Direccion = DireccionTextBox.Text;
            string Telefono = Convert.ToString(TelefonoMaskedTextBox.Text);
            string NombreM = NombreMascotaTextBox.Text;
            string Raza = RazaTextBox.Text;
            Mascota Animal;

            Animal = new Mascota(NombreM, Raza, NombreD, Direccion, Telefono);
            Limpiar();
        }

       
    }
}
