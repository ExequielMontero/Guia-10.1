using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_de_Prueba_visto_en_teoria
{
    public partial class Form1 : Form
    {
        static double acum;
        static double promedio;
        static int contador;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btNota_Click(object sender, EventArgs e)
        {
            int nota = Convert.ToInt32(tbNota.Text);
            ingresarnota(nota);
            tbNota.Clear();
            
        }

        static void calcularpromedio()
        {
            
            if(contador>0)
            promedio = acum/contador;
        }

        static void ingresarnota(int nota)
        {
            acum += nota;
            contador++;
        }

        private void btPromedio_Click(object sender, EventArgs e)
        {
            calcularpromedio();
            lbPromedio.Items.Clear();
            lbPromedio.Items.Add(promedio);
            
        }
    }
}
