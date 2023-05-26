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
    public partial class frmPoyecto : Form
    {
        float[,] Camiones = new float[4, 4];
        float[,] Llegadas = new float[4, 9];
        float[,] Servicio3 = new float[4, 9];
        float[,] Servicio4 = new float[4, 9];
        float[,] Servicio5 = new float[4, 9];
        float[,] Servicio6 = new float[4, 9];
        float[,] PseudoAleatorios = new float[2, 36];
        float[] pesudorand = null;
        float celdaAnt;
        float tExtra = 0;
        int contR = 1;
        public frmPoyecto()
        {
            InitializeComponent();

            float Lim = 0;

            //Arreglo y for para la tabla Camiones Esperando
            Camiones[0, 0] = 0;
            Camiones[1, 0] = 0.50f;
            Camiones[0, 1] = 1;
            Camiones[1, 1] = 0.25f;
            Camiones[0, 2] = 2;
            Camiones[1, 2] = 0.15f;
            Camiones[0, 3] = 3;
            Camiones[1, 3] = 0.10f;

            Lim = 0;

            for (int C = 0; C < 4; C++)
            {
                Camiones[2, C] = Lim;
                Camiones[3, C] = Lim + Camiones[1, C];
            }

            //Arreglo y for para la tabla Tiempo Entre Llegadas
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

            Lim = 0;

            for (int C = 0; C < 9; C++)
            {
                Llegadas[2, C] = Lim;
                Llegadas[3, C] = Lim + Llegadas[1, C];
                Lim = Lim + Llegadas[1, C];
            }

            //Arreglo y for para la tabla Tiempo de servicio equipo 3
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

            //Arreglo y for para la tabla Tiempo de servicio equipo 4
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

            //Arreglo y for para la tabla Tiempo de servicio equipo 5
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

            //Arreglo y for para la tabla Tiempo de servicio equipo 6
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

            Lim = 0;
            for (int C = 0; C < 9; C++)
            {
                Servicio3[2, C] = Lim;
                Lim = Lim + Servicio3[1, C];
                Servicio3[3, C] = Lim;
            }

            Lim = 0;
            for (int C = 0; C < 9; C++)
            {
                Servicio4[2, C] = Lim;
                Lim = Lim + Servicio4[1, C];
                Servicio4[3, C] = Lim;
            }

            Lim = 0;
            for (int C = 0; C < 9; C++)
            {
                Servicio5[2, C] = Lim;
                Lim = Lim + Servicio5[1, C];
                Servicio5[3, C] = Lim;
            }

            Lim = 0;
            for (int C = 0; C < 8; C++)
            {
                Servicio6[2, C] = Lim;
                Servicio6[3, C] = Lim;
                Lim = Lim + Servicio6[1, C];
            }
            Servicio6[3, 8] = 1.00f;


            Lim = 0;
            for (int C = 0; C < 9; C++)
            {
                dgvEquipo.Rows.Add(Servicio3[0, C], Servicio3[1, C], Lim, Lim + Servicio3[1, C]);
                Servicio3[2, C] = Lim;
                Lim = Lim + Servicio3[1, C];
                Servicio3[3, C] = Lim;
            }
        }
        


        string eq3, eq4, eq5, eq6;
        //float[,] Hours = new float[2, 30];
        //float[,] Minuts = new float[2, 30];


        private void cmdIntroducir_Click(object sender, EventArgs e)
        {

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdClean_Click(object sender, EventArgs e)
        {
            //Limpiar
            txtC_A.Clear();
            txtC_M.Clear();
            txtMod.Clear();
            txtSemilla.Clear();
            txtCant.Clear();
            dgvNums.Rows.Clear();
            dgvProblema.Rows.Clear();
            contR = 1;

            //Habilitar
            txtC_A.ReadOnly = false;
            txtC_M.ReadOnly = false;
            txtMod.ReadOnly = false;
            txtSemilla.ReadOnly = false;
            txtCant.ReadOnly = false;
        }

        private void txtC_M_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtC_M_AcceptsTabChanged(object sender, EventArgs e)
        {

        }

        private void cmdDefault_Click(object sender, EventArgs e)
        {
            //txtC_A.Text = "89";
            //txtC_M.Text = "81";
            //txtMod.Text = "100";
            //txtSemilla.Text = "5";
            //txtCant.Text = "100";

            txtC_A.Text = "57";
            txtC_M.Text = "981";
            txtMod.Text = "1003620";
            txtSemilla.Text = "1024";
            txtCant.Text = "100";
        }

        private void cmdDatos_Click(object sender, EventArgs e)
        {
            frmDatos Data = new frmDatos();

            Data.Show();
        }

        void InicioServicio()
        {
            
        }



        private void cmdResolver_Click(object sender, EventArgs e)
        {
            dgvProblema.Rows.Clear();
            contR = 1;
            //60 Numeros Pseudo aleatorios para la tabla
            int c = Convert.ToInt32(nudEquipo.Text), Hour1, Minuts1, Auxiliar1 = 660;

            int camionesIn = 0;
            
            if(celdaAnt > 0 && celdaAnt <= 0.5 )
            {
                camionesIn = 0;
            }
            else if (celdaAnt > 0.5 && celdaAnt <= 0.75)
            {
                camionesIn = 1;
            }
            else if (celdaAnt > 0.75 && celdaAnt <= 0.9)
            {
                camionesIn = 2;
            }
            else if (celdaAnt > 0.9 && celdaAnt <= 1)
            {
                camionesIn = 3;
            }
            int tempServicio = 0;

            switch (c)
            {
                case 3:
                    //El error es que Servicio no tienen valores en las columnas 2 y 3 Bruu

                    tempServicio = 0;

                    for (int I = 0; I < camionesIn; I++)
                    {
                        for (int P = 0; P <= 8; P++)
                        {
                            if ((pesudorand[I + 1] >= Servicio3[2, P]) && (pesudorand[I + 1] <= Servicio3[3, P]))
                            {
                                tempServicio = (int)Servicio3[0, P];
                                break;
                            }
                        }

                        string TerminacionServ, inicioSer;
                        int ocio, tiempoEspera, cola = 0;

                        if (((Auxiliar1 + tempServicio) % 60) < 10)
                        {
                            TerminacionServ = ((Auxiliar1 + tempServicio) / 60).ToString() + ":0" + ((Auxiliar1 + tempServicio) % 60).ToString();
                        }
                        else
                        {
                            TerminacionServ = ((Auxiliar1 + tempServicio) / 60).ToString() + ":" + ((Auxiliar1 + tempServicio) % 60).ToString();
                        }

                        if (contR == 1)
                        {
                            dgvProblema.Rows.Add(contR++, celdaAnt, 0, "11:00", "11:00", pesudorand[I + 1], tempServicio, TerminacionServ, 0, 0, 0);
                        }
                        else
                        {
                            inicioSer = dgvProblema.Rows[I - 1].Cells[7].Value.ToString();
                            string[] temp = dgvProblema.Rows[I - 1].Cells[7].Value.ToString().Split(':');
                            if (((Auxiliar1 + tempServicio + int.Parse(temp[1])) % 60) < 10)
                            {
                                TerminacionServ = ((Auxiliar1 + tempServicio + int.Parse(temp[1])) / 60).ToString() + ":0" + ((Auxiliar1 + tempServicio + int.Parse(temp[1])) % 60).ToString();
                            }
                            else
                            {
                                TerminacionServ = ((Auxiliar1 + tempServicio + int.Parse(temp[1])) / 60).ToString() + ":" + ((Auxiliar1 + tempServicio + int.Parse(temp[1])) % 60).ToString();
                            }

                            TimeSpan algo = TimeSpan.Parse(inicioSer) - TimeSpan.Parse("11:00");
                            tiempoEspera = algo.Hours * 60 + algo.Minutes;

                            if (tiempoEspera > 0)
                            {
                                for (int x = dgvProblema.RowCount - 2; x >= 0; x--)
                                {
                                    if (int.Parse(dgvProblema.Rows[x].Cells[9].Value.ToString()) > 0)
                                    {
                                        cola++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                cola = 0;
                            }
                            

                            dgvProblema.Rows.Add(contR++, celdaAnt, 0, "11:00", inicioSer, pesudorand[I + 1], tempServicio, TerminacionServ, 0, tiempoEspera, cola);
                        }

                    }

                    string[] muyTarde = new string[2];

                    for (int I = camionesIn + 1; I <= 60 - camionesIn; I = I + 2)
                    {
                        
                        for (int P = 0; P <= 8; P++)
                        {
                            if ((pesudorand[I + 1] >= Servicio3[2, P]) && (pesudorand[I + 1] <= Servicio3[3, P]))
                            {
                                tempServicio = (int)Servicio3[0, P];
                                break;
                            }
                        }
                        for (int B = 0; B <= 8; B++)
                        {
                            if ((pesudorand[I] >= Llegadas[2, B]) && (pesudorand[I] <= Llegadas[3, B]))
                            {
                                //Calculo del tiempo de llegada
                                Auxiliar1 = Auxiliar1 + Convert.ToInt32(Llegadas[0, B]);

                                //Definir horario
                                if (Auxiliar1 >= 1400)
                                {
                                    Auxiliar1 = Auxiliar1 - 1400;
                                }

                                Hour1 = Auxiliar1 / 60;
                                Minuts1 = Auxiliar1 % 60;
                                //Impresiones en el DataGridView
                                //Sigue resolver la casilla de Inicio del Servicio y ajustar terminacion del sevicio posterior a eso
                                string Tllegada;
                                if (Minuts1 < 10)
                                {
                                    Tllegada = Hour1.ToString() + ":0" + Minuts1.ToString();
                                }
                                else
                                {
                                    Tllegada = Hour1.ToString() + ":" + Minuts1.ToString();
                                }


                                string TerminacionServ, inicioSer;
                                int ocio, tiempoEspera, cola = 0;

                                if (((Auxiliar1 + tempServicio) % 60) < 10)
                                {
                                    TerminacionServ = ((Auxiliar1 + tempServicio) / 60).ToString() + ":0" + ((Auxiliar1 + tempServicio) % 60).ToString();
                                }
                                else
                                {
                                    TerminacionServ = ((Auxiliar1 + tempServicio) / 60).ToString() + ":" + ((Auxiliar1 + tempServicio) % 60).ToString();
                                }

                                if (contR == 1)
                                {
                                    TimeSpan algo = TimeSpan.Parse(Tllegada) - TimeSpan.Parse("11:00");
                                    ocio = algo.Hours * 60 + algo.Minutes;
                                    dgvProblema.Rows.Add(contR++, pesudorand[I], 0, Tllegada, Tllegada, pesudorand[I + 1], tempServicio, TerminacionServ, ocio, 0, 0);
                                }
                                else
                                {
                                    inicioSer = dgvProblema.Rows[contR - 2].Cells[7].Value.ToString();
                                    string[] temp = dgvProblema.Rows[contR - 2].Cells[7].Value.ToString().Split(':');
                                    int aux2 = int.Parse(temp[0]) * 60;
                                    int iniser = 0;

                                    if (aux2 >= 1400)
                                    {
                                        aux2 -= 1400;
                                    }




                                    if (TimeSpan.Compare(TimeSpan.Parse(dgvProblema.Rows[contR - 2].Cells[7].Value.ToString()), TimeSpan.Parse(Tllegada)) < 0)
                                    {
                                        inicioSer = Tllegada;

                                    }

                                    int z = 0;
                                    foreach (string n in inicioSer.Split(':'))
                                    {
                                        if(z++ ==0)
                                        {
                                            iniser += int.Parse(n) * 60;
                                        }
                                        else
                                        {
                                            iniser += int.Parse(n);
                                        }
                                        
                                    }

                                    if (((aux2 + tempServicio + int.Parse(temp[1])) % 60) < 10)
                                    {
                                        TerminacionServ = ((tempServicio + iniser) / 60).ToString() + ":0" + ((tempServicio + iniser) % 60).ToString();
                                    }
                                    else
                                    {
                                        TerminacionServ = ((tempServicio + iniser) / 60).ToString() + ":" + ((tempServicio + iniser) % 60).ToString();
                                    }

                                    if (TimeSpan.Compare(TimeSpan.Parse(TerminacionServ), TimeSpan.Parse("19:00")) > 0)
                                    {
                                        TimeSpan extra = TimeSpan.Parse(TerminacionServ) - TimeSpan.Parse("19:00");
                                        tExtra = extra.Hours * 60 + extra.Minutes;
                                    }

                                    TimeSpan algo = TimeSpan.Parse(inicioSer) - TimeSpan.Parse(Tllegada);
                                    tiempoEspera = algo.Hours * 60 + algo.Minutes;

                                    algo = TimeSpan.Parse(inicioSer)  - TimeSpan.Parse(dgvProblema.Rows[contR - 2].Cells[7].Value.ToString());
                                    ocio = algo.Hours * 60 + algo.Minutes;

                                    if (tiempoEspera > 0)
                                    {
                                        for (int x = dgvProblema.RowCount - 2; x >= 0; x--)
                                        {
                                            if (int.Parse(dgvProblema.Rows[x].Cells[9].Value.ToString()) > 0)
                                            {
                                                cola++;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        cola = 0;
                                    }

                                    dgvProblema.Rows.Add(contR++, pesudorand[I], Llegadas[0,B], Tllegada, inicioSer, pesudorand[I + 1], tempServicio, TerminacionServ, ocio, tiempoEspera, cola);
                                }
                                break;
                            }
                        }
                        muyTarde = dgvProblema.Rows[contR - 2].Cells[3].Value.ToString().Split(':');
                        if (int.Parse(muyTarde[0]) >= 19)
                        {                        
                            break;
                        }
                            
                    }
                    break;

                case 4:
                    //El error es que Servicio no tienen valores en las columnas 2 y 3 Bruu

                    tempServicio = 0;

                    for (int I = 0; I < camionesIn; I++)
                    {
                        for (int P = 0; P <= 8; P++)
                        {
                            if ((pesudorand[I + 1] >= Servicio4[2, P]) && (pesudorand[I + 1] <= Servicio4[3, P]))
                            {
                                tempServicio = (int)Servicio4[0, P];
                                break;
                            }
                        }

                        string TerminacionServ, inicioSer;
                        int ocio, tiempoEspera, cola = 0;

                        if (((Auxiliar1 + tempServicio) % 60) < 10)
                        {
                            TerminacionServ = ((Auxiliar1 + tempServicio) / 60).ToString() + ":0" + ((Auxiliar1 + tempServicio) % 60).ToString();
                        }
                        else
                        {
                            TerminacionServ = ((Auxiliar1 + tempServicio) / 60).ToString() + ":" + ((Auxiliar1 + tempServicio) % 60).ToString();
                        }

                        if (contR == 1)
                        {
                            dgvProblema.Rows.Add(contR++, celdaAnt, 0, "11:00", "11:00", pesudorand[I + 1], tempServicio, TerminacionServ, 0, 0, 0);
                        }
                        else
                        {
                            inicioSer = dgvProblema.Rows[I - 1].Cells[7].Value.ToString();
                            string[] temp = dgvProblema.Rows[I - 1].Cells[7].Value.ToString().Split(':');
                            if (((Auxiliar1 + tempServicio + int.Parse(temp[1])) % 60) < 10)
                            {
                                TerminacionServ = ((Auxiliar1 + tempServicio + int.Parse(temp[1])) / 60).ToString() + ":0" + ((Auxiliar1 + tempServicio + int.Parse(temp[1])) % 60).ToString();
                            }
                            else
                            {
                                TerminacionServ = ((Auxiliar1 + tempServicio + int.Parse(temp[1])) / 60).ToString() + ":" + ((Auxiliar1 + tempServicio + int.Parse(temp[1])) % 60).ToString();
                            }

                            TimeSpan algo = TimeSpan.Parse(inicioSer) - TimeSpan.Parse("11:00");
                            tiempoEspera = algo.Hours * 60 + algo.Minutes;

                            if (tiempoEspera > 0)
                            {
                                for (int x = dgvProblema.RowCount - 2; x >= 0; x--)
                                {
                                    if (int.Parse(dgvProblema.Rows[x].Cells[9].Value.ToString()) > 0)
                                    {
                                        cola++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                cola = 0;
                            }


                            dgvProblema.Rows.Add(contR++, celdaAnt, 0, "11:00", inicioSer, pesudorand[I + 1], tempServicio, TerminacionServ, 0, tiempoEspera, cola);
                        }

                    }

                    muyTarde = new string[2];

                    for (int I = camionesIn + 1; I <= 60 - camionesIn; I = I + 2)
                    {

                        for (int P = 0; P <= 8; P++)
                        {
                            if ((pesudorand[I + 1] >= Servicio4[2, P]) && (pesudorand[I + 1] <= Servicio4[3, P]))
                            {
                                tempServicio = (int)Servicio4[0, P];
                                break;
                            }
                        }
                        for (int B = 0; B <= 8; B++)
                        {
                            if ((pesudorand[I] >= Llegadas[2, B]) && (pesudorand[I] <= Llegadas[3, B]))
                            {
                                //Calculo del tiempo de llegada
                                Auxiliar1 = Auxiliar1 + Convert.ToInt32(Llegadas[0, B]);

                                //Definir horario
                                if (Auxiliar1 >= 1400)
                                {
                                    Auxiliar1 = Auxiliar1 - 1400;
                                }

                                Hour1 = Auxiliar1 / 60;
                                Minuts1 = Auxiliar1 % 60;
                                //Impresiones en el DataGridView
                                //Sigue resolver la casilla de Inicio del Servicio y ajustar terminacion del sevicio posterior a eso
                                string Tllegada;
                                if (Minuts1 < 10)
                                {
                                    Tllegada = Hour1.ToString() + ":0" + Minuts1.ToString();
                                }
                                else
                                {
                                    Tllegada = Hour1.ToString() + ":" + Minuts1.ToString();
                                }


                                string TerminacionServ, inicioSer;
                                int ocio, tiempoEspera, cola = 0;

                                if (((Auxiliar1 + tempServicio) % 60) < 10)
                                {
                                    TerminacionServ = ((Auxiliar1 + tempServicio) / 60).ToString() + ":0" + ((Auxiliar1 + tempServicio) % 60).ToString();
                                }
                                else
                                {
                                    TerminacionServ = ((Auxiliar1 + tempServicio) / 60).ToString() + ":" + ((Auxiliar1 + tempServicio) % 60).ToString();
                                }

                                if (contR == 1)
                                {
                                    TimeSpan algo = TimeSpan.Parse(Tllegada) - TimeSpan.Parse("11:00");
                                    ocio = algo.Hours * 60 + algo.Minutes;
                                    dgvProblema.Rows.Add(contR++, pesudorand[I], 0, Tllegada, Tllegada, pesudorand[I + 1], tempServicio, TerminacionServ, ocio, 0, 0);
                                }
                                else
                                {
                                    inicioSer = dgvProblema.Rows[contR - 2].Cells[7].Value.ToString();
                                    string[] temp = dgvProblema.Rows[contR - 2].Cells[7].Value.ToString().Split(':');
                                    int aux2 = int.Parse(temp[0]) * 60;
                                    int iniser = 0;

                                    if (aux2 >= 1400)
                                    {
                                        aux2 -= 1400;
                                    }




                                    if (TimeSpan.Compare(TimeSpan.Parse(dgvProblema.Rows[contR - 2].Cells[7].Value.ToString()), TimeSpan.Parse(Tllegada)) < 0)
                                    {
                                        inicioSer = Tllegada;

                                    }

                                    int z = 0;
                                    foreach (string n in inicioSer.Split(':'))
                                    {
                                        if (z++ == 0)
                                        {
                                            iniser += int.Parse(n) * 60;
                                        }
                                        else
                                        {
                                            iniser += int.Parse(n);
                                        }

                                    }

                                    if (((aux2 + tempServicio + int.Parse(temp[1])) % 60) < 10)
                                    {
                                        TerminacionServ = ((tempServicio + iniser) / 60).ToString() + ":0" + ((tempServicio + iniser) % 60).ToString();
                                    }
                                    else
                                    {
                                        TerminacionServ = ((tempServicio + iniser) / 60).ToString() + ":" + ((tempServicio + iniser) % 60).ToString();
                                    }

                                    if (TimeSpan.Compare(TimeSpan.Parse(TerminacionServ), TimeSpan.Parse("19:00")) > 0)
                                    {
                                        TimeSpan extra = TimeSpan.Parse(TerminacionServ) - TimeSpan.Parse("19:00");
                                        tExtra = extra.Hours * 60 + extra.Minutes;
                                    }

                                    TimeSpan algo = TimeSpan.Parse(inicioSer) - TimeSpan.Parse(Tllegada);
                                    tiempoEspera = algo.Hours * 60 + algo.Minutes;

                                    algo = TimeSpan.Parse(inicioSer) - TimeSpan.Parse(dgvProblema.Rows[contR - 2].Cells[7].Value.ToString());
                                    ocio = algo.Hours * 60 + algo.Minutes;

                                    if (tiempoEspera > 0)
                                    {
                                        for (int x = dgvProblema.RowCount - 2; x >= 0; x--)
                                        {
                                            if (int.Parse(dgvProblema.Rows[x].Cells[9].Value.ToString()) > 0)
                                            {
                                                cola++;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        cola = 0;
                                    }

                                    dgvProblema.Rows.Add(contR++, pesudorand[I], Llegadas[0, B], Tllegada, inicioSer, pesudorand[I + 1], tempServicio, TerminacionServ, ocio, tiempoEspera, cola);
                                }
                                break;
                            }
                        }
                        muyTarde = dgvProblema.Rows[contR - 2].Cells[3].Value.ToString().Split(':');
                        if (int.Parse(muyTarde[0]) >= 19)
                        {
                            break;
                        }

                    }
                    break;

                case 5:
                    //El error es que Servicio no tienen valores en las columnas 2 y 3 Bruu

                    tempServicio = 0;

                    for (int I = 0; I < camionesIn; I++)
                    {
                        for (int P = 0; P <= 8; P++)
                        {
                            if ((pesudorand[I + 1] >= Servicio5[2, P]) && (pesudorand[I + 1] <= Servicio5[3, P]))
                            {
                                tempServicio = (int)Servicio5[0, P];
                                break;
                            }
                        }

                        string TerminacionServ, inicioSer;
                        int ocio, tiempoEspera, cola = 0;

                        if (((Auxiliar1 + tempServicio) % 60) < 10)
                        {
                            TerminacionServ = ((Auxiliar1 + tempServicio) / 60).ToString() + ":0" + ((Auxiliar1 + tempServicio) % 60).ToString();
                        }
                        else
                        {
                            TerminacionServ = ((Auxiliar1 + tempServicio) / 60).ToString() + ":" + ((Auxiliar1 + tempServicio) % 60).ToString();
                        }

                        if (contR == 1)
                        {
                            dgvProblema.Rows.Add(contR++, celdaAnt, 0, "11:00", "11:00", pesudorand[I + 1], tempServicio, TerminacionServ, 0, 0, 0);
                        }
                        else
                        {
                            inicioSer = dgvProblema.Rows[I - 1].Cells[7].Value.ToString();
                            string[] temp = dgvProblema.Rows[I - 1].Cells[7].Value.ToString().Split(':');
                            if (((Auxiliar1 + tempServicio + int.Parse(temp[1])) % 60) < 10)
                            {
                                TerminacionServ = ((Auxiliar1 + tempServicio + int.Parse(temp[1])) / 60).ToString() + ":0" + ((Auxiliar1 + tempServicio + int.Parse(temp[1])) % 60).ToString();
                            }
                            else
                            {
                                TerminacionServ = ((Auxiliar1 + tempServicio + int.Parse(temp[1])) / 60).ToString() + ":" + ((Auxiliar1 + tempServicio + int.Parse(temp[1])) % 60).ToString();
                            }

                            TimeSpan algo = TimeSpan.Parse(inicioSer) - TimeSpan.Parse("11:00");
                            tiempoEspera = algo.Hours * 60 + algo.Minutes;

                            if (tiempoEspera > 0)
                            {
                                for (int x = dgvProblema.RowCount - 2; x >= 0; x--)
                                {
                                    if (int.Parse(dgvProblema.Rows[x].Cells[9].Value.ToString()) > 0)
                                    {
                                        cola++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                cola = 0;
                            }


                            dgvProblema.Rows.Add(contR++, celdaAnt, 0, "11:00", inicioSer, pesudorand[I + 1], tempServicio, TerminacionServ, 0, tiempoEspera, cola);
                        }

                    }

                    muyTarde = new string[2];

                    for (int I = camionesIn + 1; I <= 60 - camionesIn; I = I + 2)
                    {

                        for (int P = 0; P <= 8; P++)
                        {
                            if ((pesudorand[I + 1] >= Servicio5[2, P]) && (pesudorand[I + 1] <= Servicio5[3, P]))
                            {
                                tempServicio = (int)Servicio5[0, P];
                                break;
                            }
                        }
                        for (int B = 0; B <= 8; B++)
                        {
                            if ((pesudorand[I] >= Llegadas[2, B]) && (pesudorand[I] <= Llegadas[3, B]))
                            {
                                //Calculo del tiempo de llegada
                                Auxiliar1 = Auxiliar1 + Convert.ToInt32(Llegadas[0, B]);

                                //Definir horario
                                if (Auxiliar1 >= 1400)
                                {
                                    Auxiliar1 = Auxiliar1 - 1400;
                                }

                                Hour1 = Auxiliar1 / 60;
                                Minuts1 = Auxiliar1 % 60;
                                //Impresiones en el DataGridView
                                //Sigue resolver la casilla de Inicio del Servicio y ajustar terminacion del sevicio posterior a eso
                                string Tllegada;
                                if (Minuts1 < 10)
                                {
                                    Tllegada = Hour1.ToString() + ":0" + Minuts1.ToString();
                                }
                                else
                                {
                                    Tllegada = Hour1.ToString() + ":" + Minuts1.ToString();
                                }


                                string TerminacionServ, inicioSer;
                                int ocio, tiempoEspera, cola = 0;

                                if (((Auxiliar1 + tempServicio) % 60) < 10)
                                {
                                    TerminacionServ = ((Auxiliar1 + tempServicio) / 60).ToString() + ":0" + ((Auxiliar1 + tempServicio) % 60).ToString();
                                }
                                else
                                {
                                    TerminacionServ = ((Auxiliar1 + tempServicio) / 60).ToString() + ":" + ((Auxiliar1 + tempServicio) % 60).ToString();
                                }

                                if (contR == 1)
                                {
                                    TimeSpan algo = TimeSpan.Parse(Tllegada) - TimeSpan.Parse("11:00");
                                    ocio = algo.Hours * 60 + algo.Minutes;
                                    dgvProblema.Rows.Add(contR++, pesudorand[I], 0, Tllegada, Tllegada, pesudorand[I + 1], tempServicio, TerminacionServ, ocio, 0, 0);
                                }
                                else
                                {
                                    inicioSer = dgvProblema.Rows[contR - 2].Cells[7].Value.ToString();
                                    string[] temp = dgvProblema.Rows[contR - 2].Cells[7].Value.ToString().Split(':');
                                    int aux2 = int.Parse(temp[0]) * 60;
                                    int iniser = 0;

                                    if (aux2 >= 1400)
                                    {
                                        aux2 -= 1400;
                                    }




                                    if (TimeSpan.Compare(TimeSpan.Parse(dgvProblema.Rows[contR - 2].Cells[7].Value.ToString()), TimeSpan.Parse(Tllegada)) < 0)
                                    {
                                        inicioSer = Tllegada;

                                    }

                                    int z = 0;
                                    foreach (string n in inicioSer.Split(':'))
                                    {
                                        if (z++ == 0)
                                        {
                                            iniser += int.Parse(n) * 60;
                                        }
                                        else
                                        {
                                            iniser += int.Parse(n);
                                        }

                                    }

                                    if (((aux2 + tempServicio + int.Parse(temp[1])) % 60) < 10)
                                    {
                                        TerminacionServ = ((tempServicio + iniser) / 60).ToString() + ":0" + ((tempServicio + iniser) % 60).ToString();
                                    }
                                    else
                                    {
                                        TerminacionServ = ((tempServicio + iniser) / 60).ToString() + ":" + ((tempServicio + iniser) % 60).ToString();
                                    }

                                    if (TimeSpan.Compare(TimeSpan.Parse(TerminacionServ), TimeSpan.Parse("19:00")) > 0)
                                    {
                                        TimeSpan extra = TimeSpan.Parse(TerminacionServ) - TimeSpan.Parse("19:00");
                                        tExtra = extra.Hours * 60 + extra.Minutes;
                                    }

                                    TimeSpan algo = TimeSpan.Parse(inicioSer) - TimeSpan.Parse(Tllegada);
                                    tiempoEspera = algo.Hours * 60 + algo.Minutes;

                                    algo = TimeSpan.Parse(inicioSer) - TimeSpan.Parse(dgvProblema.Rows[contR - 2].Cells[7].Value.ToString());
                                    ocio = algo.Hours * 60 + algo.Minutes;

                                    if (tiempoEspera > 0)
                                    {
                                        for (int x = dgvProblema.RowCount - 2; x >= 0; x--)
                                        {
                                            if (int.Parse(dgvProblema.Rows[x].Cells[9].Value.ToString()) > 0)
                                            {
                                                cola++;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        cola = 0;
                                    }

                                    dgvProblema.Rows.Add(contR++, pesudorand[I], Llegadas[0, B], Tllegada, inicioSer, pesudorand[I + 1], tempServicio, TerminacionServ, ocio, tiempoEspera, cola);
                                }
                                break;
                            }
                        }
                        muyTarde = dgvProblema.Rows[contR - 2].Cells[3].Value.ToString().Split(':');
                        if (int.Parse(muyTarde[0]) >= 19)
                        {
                            break;
                        }

                    }
                    break;

                case 6:
                    //El error es que Servicio no tienen valores en las columnas 2 y 3 Bruu

                    tempServicio = 0;

                    for (int I = 0; I < camionesIn; I++)
                    {
                        for (int P = 0; P <= 8; P++)
                        {
                            if ((pesudorand[I + 1] >= Servicio6[2, P]) && (pesudorand[I + 1] <= Servicio6[3, P]))
                            {
                                tempServicio = (int)Servicio6[0, P];
                                break;
                            }
                        }

                        string TerminacionServ, inicioSer;
                        int ocio, tiempoEspera, cola = 0;

                        if (((Auxiliar1 + tempServicio) % 60) < 10)
                        {
                            TerminacionServ = ((Auxiliar1 + tempServicio) / 60).ToString() + ":0" + ((Auxiliar1 + tempServicio) % 60).ToString();
                        }
                        else
                        {
                            TerminacionServ = ((Auxiliar1 + tempServicio) / 60).ToString() + ":" + ((Auxiliar1 + tempServicio) % 60).ToString();
                        }

                        if (contR == 1)
                        {
                            dgvProblema.Rows.Add(contR++, celdaAnt, 0, "11:00", "11:00", pesudorand[I + 1], tempServicio, TerminacionServ, 0, 0, 0);
                        }
                        else
                        {
                            inicioSer = dgvProblema.Rows[I - 1].Cells[7].Value.ToString();
                            string[] temp = dgvProblema.Rows[I - 1].Cells[7].Value.ToString().Split(':');
                            if (((Auxiliar1 + tempServicio + int.Parse(temp[1])) % 60) < 10)
                            {
                                TerminacionServ = ((Auxiliar1 + tempServicio + int.Parse(temp[1])) / 60).ToString() + ":0" + ((Auxiliar1 + tempServicio + int.Parse(temp[1])) % 60).ToString();
                            }
                            else
                            {
                                TerminacionServ = ((Auxiliar1 + tempServicio + int.Parse(temp[1])) / 60).ToString() + ":" + ((Auxiliar1 + tempServicio + int.Parse(temp[1])) % 60).ToString();
                            }

                            TimeSpan algo = TimeSpan.Parse(inicioSer) - TimeSpan.Parse("11:00");
                            tiempoEspera = algo.Hours * 60 + algo.Minutes;

                            if (tiempoEspera > 0)
                            {
                                for (int x = dgvProblema.RowCount - 2; x >= 0; x--)
                                {
                                    if (int.Parse(dgvProblema.Rows[x].Cells[9].Value.ToString()) > 0)
                                    {
                                        cola++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                cola = 0;
                            }


                            dgvProblema.Rows.Add(contR++, celdaAnt, 0, "11:00", inicioSer, pesudorand[I + 1], tempServicio, TerminacionServ, 0, tiempoEspera, cola);
                        }

                    }

                    muyTarde = new string[2];

                    for (int I = camionesIn + 1; I <= 60 - camionesIn; I = I + 2)
                    {

                        for (int P = 0; P <= 8; P++)
                        {
                            if ((pesudorand[I + 1] >= Servicio6[2, P]) && (pesudorand[I + 1] <= Servicio6[3, P]))
                            {
                                tempServicio = (int)Servicio6[0, P];
                                break;
                            }
                        }
                        for (int B = 0; B <= 8; B++)
                        {
                            if ((pesudorand[I] >= Llegadas[2, B]) && (pesudorand[I] <= Llegadas[3, B]))
                            {
                                //Calculo del tiempo de llegada
                                Auxiliar1 = Auxiliar1 + Convert.ToInt32(Llegadas[0, B]);

                                //Definir horario
                                if (Auxiliar1 >= 1400)
                                {
                                    Auxiliar1 = Auxiliar1 - 1400;
                                }

                                Hour1 = Auxiliar1 / 60;
                                Minuts1 = Auxiliar1 % 60;
                                //Impresiones en el DataGridView
                                //Sigue resolver la casilla de Inicio del Servicio y ajustar terminacion del sevicio posterior a eso
                                string Tllegada;
                                if (Minuts1 < 10)
                                {
                                    Tllegada = Hour1.ToString() + ":0" + Minuts1.ToString();
                                }
                                else
                                {
                                    Tllegada = Hour1.ToString() + ":" + Minuts1.ToString();
                                }


                                string TerminacionServ, inicioSer;
                                int ocio, tiempoEspera, cola = 0;

                                if (((Auxiliar1 + tempServicio) % 60) < 10)
                                {
                                    TerminacionServ = ((Auxiliar1 + tempServicio) / 60).ToString() + ":0" + ((Auxiliar1 + tempServicio) % 60).ToString();
                                }
                                else
                                {
                                    TerminacionServ = ((Auxiliar1 + tempServicio) / 60).ToString() + ":" + ((Auxiliar1 + tempServicio) % 60).ToString();
                                }

                                if (contR == 1)
                                {
                                    TimeSpan algo = TimeSpan.Parse(Tllegada) - TimeSpan.Parse("11:00");
                                    ocio = algo.Hours * 60 + algo.Minutes;
                                    dgvProblema.Rows.Add(contR++, pesudorand[I], 0, Tllegada, Tllegada, pesudorand[I + 1], tempServicio, TerminacionServ, ocio, 0, 0);
                                }
                                else
                                {
                                    inicioSer = dgvProblema.Rows[contR - 2].Cells[7].Value.ToString();
                                    string[] temp = dgvProblema.Rows[contR - 2].Cells[7].Value.ToString().Split(':');
                                    int aux2 = int.Parse(temp[0]) * 60;
                                    int iniser = 0;

                                    if (aux2 >= 1400)
                                    {
                                        aux2 -= 1400;
                                    }




                                    if (TimeSpan.Compare(TimeSpan.Parse(dgvProblema.Rows[contR - 2].Cells[7].Value.ToString()), TimeSpan.Parse(Tllegada)) < 0)
                                    {
                                        inicioSer = Tllegada;

                                    }

                                    int z = 0;
                                    foreach (string n in inicioSer.Split(':'))
                                    {
                                        if (z++ == 0)
                                        {
                                            iniser += int.Parse(n) * 60;
                                        }
                                        else
                                        {
                                            iniser += int.Parse(n);
                                        }

                                    }

                                    if (((aux2 + tempServicio + int.Parse(temp[1])) % 60) < 10)
                                    {
                                        TerminacionServ = ((tempServicio + iniser) / 60).ToString() + ":0" + ((tempServicio + iniser) % 60).ToString();
                                    }
                                    else
                                    {
                                        TerminacionServ = ((tempServicio + iniser) / 60).ToString() + ":" + ((tempServicio + iniser) % 60).ToString();
                                    }

                                    if (TimeSpan.Compare(TimeSpan.Parse(TerminacionServ), TimeSpan.Parse("19:00")) > 0)
                                    {
                                        TimeSpan extra = TimeSpan.Parse(TerminacionServ) - TimeSpan.Parse("19:00");
                                        tExtra = extra.Hours * 60 + extra.Minutes;
                                    }

                                    TimeSpan algo = TimeSpan.Parse(inicioSer) - TimeSpan.Parse(Tllegada);
                                    tiempoEspera = algo.Hours * 60 + algo.Minutes;

                                    algo = TimeSpan.Parse(inicioSer) - TimeSpan.Parse(dgvProblema.Rows[contR - 2].Cells[7].Value.ToString());
                                    ocio = algo.Hours * 60 + algo.Minutes;

                                    if (tiempoEspera > 0)
                                    {
                                        for (int x = dgvProblema.RowCount - 2; x >= 0; x--)
                                        {
                                            if (int.Parse(dgvProblema.Rows[x].Cells[9].Value.ToString()) > 0)
                                            {
                                                cola++;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        cola = 0;
                                    }

                                    dgvProblema.Rows.Add(contR++, pesudorand[I], Llegadas[0, B], Tllegada, inicioSer, pesudorand[I + 1], tempServicio, TerminacionServ, ocio, tiempoEspera, cola);
                                }
                                break;
                            }
                        }
                        muyTarde = dgvProblema.Rows[contR - 2].Cells[3].Value.ToString().Split(':');
                        if (int.Parse(muyTarde[0]) >= 19)
                        {
                            break;
                        }

                    }
                    break;
            }
        }



        //private void cmdEquipo_Click(object sender, EventArgs e)
        //{
        //    //Limpieza del dgv
        //    dgvEquipo.Rows.Clear();

        //    //Declaracion de variables
        //    float Lim;



        //    Lim = 0;
        //    int Equipo = Int32.Parse(nudEquipo.Text);

        //    switch (Equipo)
        //    {
        //        case 3:
        //            for (int C = 0; C < 9; C++)
        //            {
        //                dgvEquipo.Rows.Add(Servicio3[0, C], Servicio3[1, C], Lim, Lim + Servicio3[1, C]);
        //                Servicio3[2, C] = Lim;
        //                Lim = Lim + Servicio3[1, C];
        //                Servicio3[3, C] = Lim;
        //            }
        //            break;

        //        case 4:
        //            for (int C = 0; C < 9; C++)
        //            {
        //                dgvEquipo.Rows.Add(Servicio4[0, C], Servicio4[1, C], Lim, Lim + Servicio4[1, C]);
        //                Servicio4[2, C] = Lim;
        //                Lim = Lim + Servicio4[1, C];
        //                Servicio4[3, C] = Lim;
        //            }
        //            break;

        //        case 5:
        //            for (int C = 0; C < 9; C++)
        //            {
        //                dgvEquipo.Rows.Add(Servicio5[0, C], Servicio5[1, C], Lim, Lim + Servicio5[1, C]);
        //                Servicio5[2, C] = Lim;
        //                Lim = Lim + Servicio5[1, C];
        //                Servicio5[3, C] = Lim;
        //            }
        //            break;

        //        case 6:
        //            for (int C = 0; C < 8; C++)
        //            {
        //                dgvEquipo.Rows.Add(Servicio6[0, C], Servicio6[1, C], Lim, Lim + Servicio6[1, C]);
        //                Servicio6[2, C] = Lim;
        //                Servicio6[3, C] = Lim;
        //                Lim = Lim + Servicio6[1, C];
        //            }
        //            dgvEquipo.Rows.Add(Servicio6[0, 8], Servicio6[1, 8], Lim, 1);
        //            Servicio6[3, 8] = 1.00f;
        //            break;
        //    }
        //}

        private void cmdIntroducir_Click_1(object sender, EventArgs e)
        {
            //Declaracion
            float X;
            int A, C, M, Cant;

            //Captura
            try
            {
                X = float.Parse(txtSemilla.Text);
                A = Int32.Parse(txtC_M.Text);
                C = Int32.Parse(txtC_A.Text);
                M = Int32.Parse(txtMod.Text);
                Cant = Int32.Parse(txtCant.Text);

                for (int i = 0; i < Cant; i++)
                {
                    X = (A * X + C) % M;

                    dgvNums.Rows.Add((i + 1), X / M);
                }

                txtC_A.ReadOnly = true;
                txtC_M.ReadOnly = true;
                txtMod.ReadOnly = true;
                txtSemilla.ReadOnly = true;
                txtCant.ReadOnly = true;

                pesudorand = new float[Cant];
            }

            catch (FormatException)
            {
                MessageBox.Show("Error \nLos datos introducidos no son validos. \n Porfavor vuelva a intentarlo",
                    "Datos Erroneos", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtC_A.Clear();
                txtC_M.Clear();
                txtMod.Clear();
                txtSemilla.Clear();
            }

            cmdResolver.Enabled = true;
        }

        

        private void dgvNums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            try
            {
                if (n > -1)
                {
                    //for para agregar los numeros pseudo aleatorios al arreglo
                    for (int i = 0; i <= 65; i++)
                    {
                        pesudorand[i] = Convert.ToSingle(dgvNums.Rows[n + i].Cells[1].Value);
                    }
                    celdaAnt = Convert.ToSingle(dgvNums.Rows[n].Cells[1].Value);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error \nLa casilla seleccionada no esta disponible \npor favor escoja ina con un id menor \n Porfavor vuelva a intentarlo",
                    "Casilla fuera de los limites", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void cmdPruebas_Click(object sender, EventArgs e)
        {
            Pruebas p = new Pruebas(GetDataTableFromDGV(dgvNums));

            p.Show();
        }

        private void cmdComp_Click(object sender, EventArgs e)
        {
            string comparacion = "";
            if(eq3 != null)
            {
                comparacion += "Equipo de 3 \n"+ eq3 + "\n\n";
            }
            if (eq4 != null)
            {
                comparacion += "Equipo de 4 \n" + eq4 + "\n\n";
            }
            if (eq5 != null)
            {
                comparacion += "Equipo de 5 \n" + eq5 + "\n\n";
            }
            if (eq6 != null)
            {
                comparacion += "Equipo de 6 \n" + eq6;
            }

            MessageBox.Show(comparacion, "COMPARACION");
        }

        private void nudEquipo_ValueChanged(object sender, EventArgs e)
        {
            dgvEquipo.Rows.Clear();
            float Lim = 0;
            int Equipo = (int)nudEquipo.Value;

            switch (Equipo)
            {
                case 3:
                    for (int C = 0; C < 9; C++)
                    {
                        dgvEquipo.Rows.Add(Servicio3[0, C], Servicio3[1, C], Lim, Lim + Servicio3[1, C]);
                        Servicio3[2, C] = Lim;
                        Lim = Lim + Servicio3[1, C];
                        Servicio3[3, C] = Lim;
                    }
                    break;

                case 4:
                    for (int C = 0; C < 9; C++)
                    {
                        dgvEquipo.Rows.Add(Servicio4[0, C], Servicio4[1, C], Lim, Lim + Servicio4[1, C]);
                        Servicio4[2, C] = Lim;
                        Lim = Lim + Servicio4[1, C];
                        Servicio4[3, C] = Lim;
                    }
                    break;

                case 5:
                    for (int C = 0; C < 9; C++)
                    {
                        dgvEquipo.Rows.Add(Servicio5[0, C], Servicio5[1, C], Lim, Lim + Servicio5[1, C]);
                        Servicio5[2, C] = Lim;
                        Lim = Lim + Servicio5[1, C];
                        Servicio5[3, C] = Lim;
                    }
                    break;

                case 6:
                    for (int C = 0; C < 8; C++)
                    {
                        dgvEquipo.Rows.Add(Servicio6[0, C], Servicio6[1, C], Lim, Lim + Servicio6[1, C]);
                        Servicio6[2, C] = Lim;
                        Servicio6[3, C] = Lim;
                        Lim = Lim + Servicio6[1, C];
                    }
                    dgvEquipo.Rows.Add(Servicio6[0, 8], Servicio6[1, 8], Lim, 1);
                    Servicio6[3, 8] = 1.00f;
                    break;
            }
        }

        private void cmdTeam_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" PALACIOS IGNACIO JOSAFAT\n PEREZ OWEN OSVALDO\n PONCE ANDRES", "EQUIPO");
        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add(column.Name);
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];

            int ContC = 1;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (ContC < dgv.Rows.Count)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        cellValues[i] = row.Cells[i].Value;
                    }
                    dt.Rows.Add(cellValues);
                }
                ContC++;
            }

            return dt;
        }

        private void dgvNums_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdRes_Click(object sender, EventArgs e)
        {
            float sueldo = 0, costoOp = 0, costoEs = 0, costoTot;

            sueldo += 8 * 25 + tExtra * 37.50f / 60;
            costoOp += 8 * 500 + tExtra * 500 / 60;

            for(int x = 0; x < dgvProblema.RowCount - 1; x++)
            {
                costoEs += int.Parse(dgvProblema.Rows[x].Cells[9].Value.ToString());
            }

            costoTot = sueldo + costoOp + costoEs / 60 * 100;

            MessageBox.Show("Sueldo: $" + sueldo + "\nCosto Operacional: $" + costoOp + "\nCosto Espera: $" + costoEs / 60 * 100 + "\nCosto Total: $" + costoTot);

            switch(nudEquipo.Text)
            {
                case "3":
                    eq3 = "Sueldo: $" + sueldo + "\nCosto Operacional: $" + costoOp + "\nCosto Espera: $" + costoEs / 60 * 100 + "\nCosto Total: $" + costoTot;
                break;

                case "4":
                    eq4 = "Sueldo: $" + sueldo + "\nCosto Operacional: $" + costoOp + "\nCosto Espera: $" + costoEs / 60 * 100 + "\nCosto Total: $" + costoTot;
                break;

                case "5":
                    eq5 = "Sueldo: $" + sueldo + "\nCosto Operacional: $" + costoOp + "\nCosto Espera: $" + costoEs / 60 * 100 + "\nCosto Total: $" + costoTot;
                    break;

                case "6":
                    eq6 = "Sueldo: $" + sueldo + "\nCosto Operacional: $" + costoOp + "\nCosto Espera: $" + costoEs / 60 * 100 + "\nCosto Total: $" + costoTot;
                    break;
            }
        }
    }
}
