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
    public partial class Ejercicio9_1 : Form
    {
        public Ejercicio9_1()
        {
            InitializeComponent();
        }


        public struct Producto
        {
            public float Precio;
            public string Nombre;
            public int Cantidad;

            public Producto(float Precio, string Nombre, int Cantidad)
            {
                this.Precio = Precio;
                this.Nombre = Nombre;
                this.Cantidad = Cantidad;
            }
        }
        
        public static void Tienda()
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Producto Tienda;
            float Precio;
            int Cantidad;
            string Nombre;

            Precio = Convert.ToSingle(PrecioTextBox.Text);
            Nombre = NombreTextBox.Text;
            Cantidad = Convert.ToInt32(CantidadTextBox.Text);

            Tienda = new Producto(Precio, Nombre, Cantidad);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            NombreTextBox.Clear();
            CantidadTextBox.Clear();
            PrecioTextBox.Clear();
        }
    }
}
