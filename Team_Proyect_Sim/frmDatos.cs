using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Proyect_Sim
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdDesplegar_Click(object sender, EventArgs e)
        {
            cmdEquipo.Enabled = true;
            cmdDesplegar.Enabled = false;

            float[,] Camiones = new float[4, 4];
            Camiones[0, 0] = 0;
            Camiones[1, 0] = 0.50f;
            Camiones[0, 1] = 1;
            Camiones[1, 1] = 0.25f;
            Camiones[0, 2] = 2;
            Camiones[1, 2] = 0.15f;
            Camiones[0, 3] = 3;
            Camiones[1, 3] = 0.10f;

            float[,] Servicio = new float[4, 9];
            Servicio[0, 0] = 20;
            Servicio[0, 1] = 25;
            Servicio[0, 2] = 30;
            Servicio[0, 3] = 35;
            Servicio[0, 4] = 40;
            Servicio[0, 5] = 45;
            Servicio[0, 6] = 50;
            Servicio[0, 7] = 55;
            Servicio[0, 8] = 60;
            Servicio[1, 0] = 0.05f;
            Servicio[1, 1] = 0.10f;
            Servicio[1, 2] = 0.20f;
            Servicio[1, 3] = 0.25f;
            Servicio[1, 4] = 0.12f;
            Servicio[1, 5] = 0.10f;
            Servicio[1, 6] = 0.08f;
            Servicio[1, 7] = 0.06f;
            Servicio[1, 8] = 0.04f;

            float[,] Llegadas = new float[4, 9];
            Llegadas[0, 0] = 20;
            Llegadas[0, 1] = 25;
            Llegadas[0, 2] = 30;
            Llegadas[0, 3] = 35;
            Llegadas[0, 4] = 40;
            Llegadas[0, 5] = 45;
            Llegadas[0, 6] = 50;
            Llegadas[0, 7] = 55;
            Llegadas[0, 8] = 60;
            Llegadas[1, 0] = 0.02f;
            Llegadas[1, 1] = 0.08f;
            Llegadas[1, 2] = 0.12f;
            Llegadas[1, 3] = 0.25f;
            Llegadas[1, 4] = 0.20f;
            Llegadas[1, 5] = 0.15f;
            Llegadas[1, 6] = 0.10f;
            Llegadas[1, 7] = 0.05f;
            Llegadas[1, 8] = 0.03f;

            float Lim = 0.00f;

            for (int C = 0; C < 4; C++)
            {
                Camiones[2, C] = Lim;
                Camiones[3, C] = Lim + Camiones[1, C];
                //dgvCamionesEsp.Rows.Add(Camiones[0, C], Camiones[1, C], Lim, Lim + Camiones[1, C]);
                //Lim = Lim + Camiones[1, C];
                dgvCamionesEsp.Rows.Add(Camiones[0, C], Camiones[1, C], Camiones[2, C], Camiones[3, C]);
                Lim = Lim + Camiones[1, C];
            }

            Lim = 0.00f;

            for (int C = 0; C < 9; C++)
            {
                dgvTieempoServicio.Rows.Add(Servicio[0, C], Servicio[1, C], Lim, Lim + Servicio[1, C]);
                Lim = Lim + Servicio[1, C];
            }

            Lim = 0.00f;

            for (int C = 0; C < 9; C++)
            {
                dgvTiempoLlegada.Rows.Add(Llegadas[0, C], Llegadas[1, C], Lim, Lim + Llegadas[1, C]);
                Lim = Lim + Llegadas[1, C];
            }

            nudEquipo.Value = 3;
        }

        private void nudEquipo_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdEquipo_Click(object sender, EventArgs e)
        {
            float[,] Servicio3 = new float[2, 9];
            Servicio3[0, 0] = 20;
            Servicio3[0, 1] = 25;
            Servicio3[0, 2] = 30;
            Servicio3[0, 3] = 35;
            Servicio3[0, 4] = 40;
            Servicio3[0, 5] = 45;
            Servicio3[0, 6] = 50;
            Servicio3[0, 7] = 55;
            Servicio3[0, 8] = 60;
            Servicio3[1, 0] = 0.05f;
            Servicio3[1, 1] = 0.10f;
            Servicio3[1, 2] = 0.20f;
            Servicio3[1, 3] = 0.25f;
            Servicio3[1, 4] = 0.12f;
            Servicio3[1, 5] = 0.10f;
            Servicio3[1, 6] = 0.08f;
            Servicio3[1, 7] = 0.06f;
            Servicio3[1, 8] = 0.04f;

            float[,] Servicio4 = new float[2, 9];
            Servicio4[0, 0] = 15;
            Servicio4[0, 1] = 20;
            Servicio4[0, 2] = 25;
            Servicio4[0, 3] = 30;
            Servicio4[0, 4] = 35;
            Servicio4[0, 5] = 40;
            Servicio4[0, 6] = 45;
            Servicio4[0, 7] = 50;
            Servicio4[0, 8] = 55;
            Servicio4[1, 0] = 0.05f;
            Servicio4[1, 1] = 0.15f;
            Servicio4[1, 2] = 0.20f;
            Servicio4[1, 3] = 0.20f;
            Servicio4[1, 4] = 0.15f;
            Servicio4[1, 5] = 0.12f;
            Servicio4[1, 6] = 0.08f;
            Servicio4[1, 7] = 0.04f;
            Servicio4[1, 8] = 0.01f;

            float[,] Servicio5 = new float[2, 9];
            Servicio5[0, 0] = 10;
            Servicio5[0, 1] = 15;
            Servicio5[0, 2] = 20;
            Servicio5[0, 3] = 25;
            Servicio5[0, 4] = 30;
            Servicio5[0, 5] = 35;
            Servicio5[0, 6] = 40;
            Servicio5[0, 7] = 45;
            Servicio5[0, 8] = 50;
            Servicio5[1, 0] = 0.10f;
            Servicio5[1, 1] = 0.18f;
            Servicio5[1, 2] = 0.22f;
            Servicio5[1, 3] = 0.18f;
            Servicio5[1, 4] = 0.10f;
            Servicio5[1, 5] = 0.08f;
            Servicio5[1, 6] = 0.06f;
            Servicio5[1, 7] = 0.05f;
            Servicio5[1, 8] = 0.03f;

            float[,] Servicio6 = new float[2, 9];
            Servicio6[0, 0] = 5;
            Servicio6[0, 1] = 10;
            Servicio6[0, 2] = 15;
            Servicio6[0, 3] = 20;
            Servicio6[0, 4] = 25;
            Servicio6[0, 5] = 30;
            Servicio6[0, 6] = 35;
            Servicio6[0, 7] = 40;
            Servicio6[0, 8] = 45;
            Servicio6[1, 0] = 0.12f;
            Servicio6[1, 1] = 0.15f;
            Servicio6[1, 2] = 0.26f;
            Servicio6[1, 3] = 0.15f;
            Servicio6[1, 4] = 0.12f;
            Servicio6[1, 5] = 0.08f;
            Servicio6[1, 6] = 0.06f;
            Servicio6[1, 7] = 0.04f;
            Servicio6[1, 8] = 0.02f;

            int Equipo = Int32.Parse(nudEquipo.Text);

            float Lim = 0;

            dgvTieempoServicio.Rows.Clear();

            switch (Equipo)
            {
                case 3:
                    for (int C = 0; C < 9; C++)
                    {
                        dgvTieempoServicio.Rows.Add(Servicio3[0, C], Servicio3[1, C], Lim, Lim + Servicio3[1, C]);
                        Lim = Lim + Servicio3[1, C];
                    }
                    break;

                case 4:
                    for (int C = 0; C < 9; C++)
                    {
                        dgvTieempoServicio.Rows.Add(Servicio4[0, C], Servicio4[1, C], Lim, Lim + Servicio4[1, C]);
                        Lim = Lim + Servicio4[1, C];
                    }
                    break;

                case 5:
                    for (int C = 0; C < 9; C++)
                    {
                        dgvTieempoServicio.Rows.Add(Servicio5[0, C], Servicio5[1, C], Lim, Lim + Servicio5[1, C]);
                        Lim = Lim + Servicio5[1, C];
                    }
                    break;

                case 6:
                    for (int C = 0; C < 8; C++)
                    {
                        dgvTieempoServicio.Rows.Add(Servicio6[0, C], Servicio6[1, C], Lim, Lim + Servicio6[1, C]);
                        Lim = Lim + Servicio6[1, C];
                    }
                    dgvTieempoServicio.Rows.Add(Servicio6[0, 8], Servicio6[1, 8], Lim, 1);
                    break;
            }
        }
    }
}
