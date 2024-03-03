using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica_Ejercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmb_Paises_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmb_Paises.SelectedIndex;

            switch (indice)
            {
                case 0:

                    txtCapital.Text = "Santo Domingo";
                    txtContinente.Text = "Caribe";

                    break;

                case 1:

                    txtCapital.Text = "Ciudad de México";
                    txtContinente.Text = "Norteamérica";

                    break;

                case 2:

                    txtCapital.Text = "Caracas";
                    txtContinente.Text = "Sudamérica";

                    break;

                case 3:

                    txtCapital.Text = "Brazilia";
                    txtContinente.Text = "Sudamérica";

                    break;
            }
        }
    }
}
