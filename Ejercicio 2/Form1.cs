using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Ejercicio_2_Guia_10
{
    public partial class Form1 : Form
    {
        static int ascienden, descienden;
        static int horas, minutos, llegadahora, llegadamin;
        static int asientos;
        static int salidahora, salidamin;
        static int demorahora, demoramin;
        static int total;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gbreocorrido_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int finhora, finmin;
            finhora = Convert.ToInt32(tbfinhora.Text);
            finmin = Convert.ToInt32(tbfinmin.Text);
            if (finhora > 12 || finhora < 1 || finmin > 59 || finmin < 1)
            {
                tbfinhora.Clear();
                tbfinhora.Clear();
                lbfin.Items.Clear();
                lbfin.Items.Add("Ingrese los datos otra vez, horario fuera de rango");
                finhora = 0;
                finmin = 0;
            }
            else if (finmin <= 59 && finmin >= 0 && finhora <= 12 && finhora >= 1)
            {
                tbfinhora.Clear();
                tbfinmin.Clear();
                lbfin.Items.Clear();
                lbfin.Items.Add("Los datos fueron cargados perfectamente");
                lbfin.Items.Add("------------------------------------------------");
                lbfin.Items.Add($"*Durante todo el viaje");
                lbfin.Items.Add($"-Cantidad de pasajeros transportados: {total}");
                lbfin.Items.Add($"*Duracion del viaje: {Math.Abs(finhora-horas)}:{Math.Abs(finmin - minutos)}hs");
                lbfin.Items.Add("*Cantidad de paradas: 1");
                lbfin.Items.Add($"*Tiempo total en demoras: {demorahora}:{demoramin}hs");
                gbfinrecorrido.Enabled = false;
                gbreocorrido.Enabled = true;
                lbparada.Items.Clear();
                lbfueraderangominutosohoras.Items.Clear();
            }

        }

        private void brecorrido_Click(object sender, EventArgs e)
        {
            lbfin.Items.Clear();
            minutos = Convert.ToInt32(tbminutos.Text);
            horas = Convert.ToInt32(tbhora.Text);
            asientos = Convert.ToInt32(tbasientos.Text);

            if (horas > 12 || horas < 1 || minutos > 59 || minutos < 1)
            {
                tbhora.Clear();
                tbminutos.Clear();
                tbasientos.Clear();
                lbfueraderangominutosohoras.Items.Clear();
                lbfueraderangominutosohoras.Items.Add("Ingrese los datos otra vez, horario fuera de rango");
                minutos = 0;
                horas = 0;
                asientos = 0;
            }
            else if (minutos <= 59 && minutos >= 0 && horas <= 12 && horas >= 1)
            {
                tbhora.Clear();
                tbminutos.Clear();
                tbasientos.Clear();
                lbfueraderangominutosohoras.Items.Clear();
                lbfueraderangominutosohoras.Items.Add("Los datos fueron cargados perfectamente");
                gbreocorrido.Enabled = false;
                gbparada.Enabled = true;

            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            llegadahora = Convert.ToInt32(tbLlegadahora.Text);
            llegadamin = Convert.ToInt32(tbLlegadamin.Text);
            descienden = Convert.ToInt32(tbDesc.Text);
            salidahora = Convert.ToInt32(tbSalidahora.Text);
            salidamin = Convert.ToInt32(tbSalidamin.Text);
            ascienden = Convert.ToInt32(tbAscien.Text);

            if (llegadahora > 12 || llegadahora < 1 || llegadamin > 59 || llegadamin < 1 || salidahora > 12 || salidahora < 1 || salidamin > 59 || salidamin < 1)
            {
                tbLlegadahora.Clear();
                tbLlegadamin.Clear();
                tbSalidahora.Clear();
                tbSalidamin.Clear();
                lbparada.Items.Clear();
                lbparada.Items.Add("Ingrese los datos otra vez, horario fuera de rango");
                llegadahora = 0;
                llegadamin = 0;
                salidahora = 0;
                salidamin = 0;
            }
            else if (llegadamin <= 59 && llegadamin >= 0 && llegadahora <= 12 && llegadahora >= 1 && salidamin <= 59 && salidamin >= 0 && salidahora <= 12 && salidahora >= 1)
            {
                tbLlegadahora.Clear();
                tbLlegadamin.Clear();
                tbSalidahora.Clear();
                tbSalidamin.Clear();
                tbDesc.Clear();
                tbAscien.Clear();
                calculardemora();
                lbparada.Items.Clear();
                lbparada.Items.Add("Los datos fueron cargados perfectamente");
                lbparada.Items.Add("--------------------------------------");
                lbparada.Items.Add("Total de personas durante todo el vijae;");
                lbparada.Items.Add($"- Que han descendido: {descienden}");
                lbparada.Items.Add($"- Que han ascendido: {ascienden}");
                lbparada.Items.Add($"*Demora en la parada: {demorahora}:{demoramin}hs");
                lbparada.Items.Add($"*Porcentaje de ocupacion: {porcentajeocupacion(asientos, ascienden, descienden)}%");
                gbparada.Enabled = false;
                gbfinrecorrido.Enabled = true;
            }

        }

        private void tbasientos_TextChanged(object sender, EventArgs e)
        {

        }

        static void calculardemora()
        {
            demorahora = Math.Abs(llegadahora - salidahora);
            demoramin = Math.Abs(llegadamin - salidamin);
        } 

        static double porcentajeocupacion(int asientos, int ascienden, int descienden)
        {
            double porcentaje;

            total = asientos + ascienden - descienden;

            porcentaje = (total * 100) / asientos;

            return porcentaje;


        }
        

        


    }
}
