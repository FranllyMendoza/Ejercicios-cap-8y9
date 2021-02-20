using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicios_cap_8y9
{
    public partial class Ejercicio8_3 : Form
    {
        public Ejercicio8_3()
        {
            InitializeComponent();
        }

        private void tiempofecha_timer_Tick(object sender, EventArgs e)
        {
            HoraLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            FechaLabel.Text = DateTime.Now.ToString("yyyy / ddd / MMM");
        }
    }
}
