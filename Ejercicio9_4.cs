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
    public partial class Ejercicio9_4 : Form
    {
        public Ejercicio9_4()
        {
            InitializeComponent();
        }
        enum Neumatico
        {
            Diagonal = 1, Radial, Verano, Invierno, AllSeason,
            Asimetrico, Direccionales, Tubuless,
            PerfilBajo, ReCauchutados, RunFlat, Ecologicos,montaña,nieve,reparados
        }
        
        
        public int Acumulador { get; set; } = 0;
        
        private void SiguienteButton_Click(object sender, EventArgs e)
        {
            Neumatico neumaticos;
            neumaticos = Neumatico.Diagonal + Acumulador;
            EnumLabel.Text = Convert.ToString(neumaticos);

            Acumulador++;

            if (Acumulador == 12)
                Acumulador = 0;
        }


    }
}
