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

        String tipo = "";
        int resultado = 0;

        private void Iniciarbutton_Click(object sender, EventArgs e)
        {
            int entero = Convert.ToInt32(EnterotextBox.Text);

            ParImpar(entero);
            PositivoNegativo(entero);

            if (resultado == 0)
            {
                ParImpartextBox.Text = ("El numero: " + entero + ", es par");
            } else
            {
                ParImpartextBox.Text = ("El numero: " + entero + ", es impar");
            }

            PositivoNegativotextBox.Text = ("El numero: " + entero + ", es " + tipo);  
        }

        public decimal ParImpar(int entero)
        {
   
            resultado = entero % 2;

            return resultado;
        }

        public String PositivoNegativo(int entero)
        {

            if (entero > 0)
            {
                tipo = "positivo";
            }
            else
            {
                tipo = "negativo";
            }
            return tipo;
        } 


    }
}
