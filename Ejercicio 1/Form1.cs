using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_guia_10
{
    public partial class Form1 : Form
    {

        int bici;
        int moto;
        int autos;
        int publicos;
        double kmbicis;
        double kmmotos;
        double promediobicis;
        double promediomotos;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bregistrar_Click(object sender, EventArgs e)
        {
            double distancia = Convert.ToDouble(tbdistancia.Text);
            if (rbbici.Checked == true)
            {
                registrar(1, distancia);
            }
            else if(rbmoto.Checked == true)
            {
                registrar(2, distancia);
            }
            else if(rbauto.Checked == true)
            {
                registrar(3);
            }
            else if(rbpublico.Checked == true)
            {
                registrar(4);
            }

            rbbici.Checked = false;
            rbmoto.Checked = false;
            rbauto.Checked = false;
            rbpublico.Checked = false;
            tbdistancia.Clear();
        }

        void registrar(int opcion, double cantidadkm = 0)
        {
            switch (opcion)
            {
                case 1:
                    {
                        bici++;
                        kmbicis += Convert.ToDouble(tbdistancia.Text);
                    }
                    break;
                case 2:
                    {
                        moto++;
                        kmmotos += Convert.ToDouble(tbdistancia.Text);
                    }
                    break;
                case 3:
                    {
                        autos++;
                    }
                    break;
                case 4:
                    {
                        publicos++;
                    }
                    break;

            }
        }

        private void bresultados_Click(object sender, EventArgs e)
        {
            int totalencuestados = bici + moto + autos + publicos;
            prombicis();
            prommoto();
            lbresultados.Items.Clear();
            lbresultados.Items.Add($"Población: {totalencuestados}");
            lbresultados.Items.Add($"--------------------------------------");
            lbresultados.Items.Add($"Cantidad de personas que usan");
            lbresultados.Items.Add($"-Bicicleta {bici}");
            lbresultados.Items.Add($"-Motocicleta {moto}");
            lbresultados.Items.Add($"-Automovil {autos}");
            lbresultados.Items.Add($"-Transporte Público {publicos}");
            lbresultados.Items.Add($"--------------------------------------");
            lbresultados.Items.Add($"Distancia promedio por vehiculo");
            lbresultados.Items.Add($"-Bicicleta {promediobicis}");
            lbresultados.Items.Add($"-Motocicleta {promediomotos}");


        }

        void prombicis()
        {
            if (bici > 0)
            {
                promediobicis = kmbicis / bici;
            }
        }

        void prommoto()
        {
            if (moto > 0)
            {
                promediomotos = kmmotos / moto;
            }
        }
    }
}
