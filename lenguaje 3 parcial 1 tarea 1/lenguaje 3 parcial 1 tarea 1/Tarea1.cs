using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lenguaje_3_parcial_1_tarea_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal entero = 0;

        private void Iniciarbutton_Click(object sender, EventArgs e)
        {
            entero = Convert.ToDecimal(EnterotextBox.Text);

            ParImpar();
            PositivoNegativo();

        }

        public void ParImpar()
        {
            decimal resultado = 0;
            resultado = entero % 2;

            if (resultado == 0)
            {
                ParImpartextBox.Text = ("El numero: " + entero + " Es par");
            }
            else 
            {
                ParImpartextBox.Text = ("El numero: " + entero + " Es impar");
            }

        }

        public void PositivoNegativo()
        {
            if (entero > 0)
            {
                PositivoNegativotextBox.Text = ("El numero: " + entero + " Es positivo");
            }
             else
            {

                PositivoNegativotextBox.Text = ("El numero: " + entero + " Es Negativo");
            }

        }


    }
}
