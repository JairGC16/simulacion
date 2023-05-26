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
    public partial class Pruebas : Form
    {
        public Pruebas(object datasource)
        {
            InitializeComponent();

            dgvNums2.DataSource = datasource;
            DataGridViewColumn id = dgvNums2.Columns[0];
            id.Width = 30;
            DataGridViewColumn num = dgvNums2.Columns[1];
            num.Width = 100;


            dgvNums2.Refresh();

            //dgvNums2.Rows.Add(1, 0.11399);
            //dgvNums2.Rows.Add(2, 0.52632);
            //dgvNums2.Rows.Add(3, 0.17152);
            //dgvNums2.Rows.Add(4, 0.33645);
            //dgvNums2.Rows.Add(5, 0.99453);
            //dgvNums2.Rows.Add(6, 0.46050);
            //dgvNums2.Rows.Add(7, 0.52373);
            //dgvNums2.Rows.Add(8, 0.91012);
            //dgvNums2.Rows.Add(9, 0.93542);
            //dgvNums2.Rows.Add(10, 0.48997);
            //dgvNums2.Rows.Add(11, 0.50009);
            //dgvNums2.Rows.Add(12, 0.52191);
            //dgvNums2.Rows.Add(13, 0.72596);
            //dgvNums2.Rows.Add(14, 0.33469);
            //dgvNums2.Rows.Add(15, 0.81630);
            //dgvNums2.Rows.Add(16, 0.45980);
            //dgvNums2.Rows.Add(17, 0.45244);
            //dgvNums2.Rows.Add(18, 0.70984);
            //dgvNums2.Rows.Add(19, 0.70690);
            //dgvNums2.Rows.Add(20, 0.40986);
        }

        private void cmdPoker_Click(object sender, EventArgs e)
        {
            int[,] digUsado = new int[dgvNums2.RowCount, 2];

            int digActual, contCant;
            bool dif = false;

            float FE = 0;
            int TD = 0, P1 = 0, P2 = 0, I3 = 0, TP = 0, I4 = 0, TI = 0;

            int cont = 0;
            foreach (DataGridViewRow row in dgvNums2.Rows)
            {
                int digs;

                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() != "")
                {
                    int[] digitos = new int[5];

                    //Redondea al 5to decimal
                    digs = (int)(float.Parse(row.Cells[1].Value.ToString()) * 100000);

                    //Se separa el numero en digitos
                    for (int i = 0; i < 5; i++)
                    {
                        digitos[i] = digs % 10;
                        digs = digs / 10;

                        //Se establaece un digito que nunca seria usado.
                        digUsado[i, 0] = 10;
                    }

                    for (int a = 0; a < digitos.Length; a++)
                    {
                        contCant = 0;
                        dif = true;
                        digActual = digitos[a];
                        for (int d = 0; d < 5; d++)
                        {
                            //si ya esta usado
                            if (digActual == digUsado[d, 0])
                            {
                                dif = false;
                                break;
                            }
                        }

                        if (dif)
                        {
                            for (int f = 0; f < digitos.Length; f++)
                            {
                                if (digActual == digitos[f])
                                {
                                    digUsado[a, 1] = ++contCant;
                                }
                            }
                            digUsado[a, 0] = digActual;
                        }
                    }

                    

                    int pares = 0, tercia = 0, cuartetos = 0, quintuples = 0;
                    for (int p = 0; p < 5; p++)
                    {
                        if (digUsado[p, 0] != 10)
                        {
                            if (digUsado[p, 1] == 2)
                            {
                                pares++;
                            }
                            else if (digUsado[p, 1] == 3)
                            {
                                tercia++;
                            }
                            else if (digUsado[p, 1] == 4)
                            {
                                cuartetos++;
                            }
                            else if (digUsado[p, 1] == 5)
                            {
                                quintuples++;
                            }
                        }
                    }

                    if (pares == 0 && tercia == 0 && cuartetos == 0 && quintuples == 0)
                    {
                        TD++;
                    }
                    else if (quintuples > 0)
                    {
                        TI++;
                    }
                    else if (cuartetos > 0)
                    {
                        I4++;
                    }
                    else if (tercia > 0 && pares == 1)
                    {
                        TP++;
                    }
                    else if (tercia > 0)
                    {
                        I3++;
                    }
                    else if (pares == 1)
                    {
                        P1++;
                    }
                    else if (pares == 2)
                    {
                        P2++;
                    }
                }

                cont++;
            }
            float formu, total = 0, totalFE = 0, totalFO;

            FE = (dgvNums2.RowCount - 1) * 0.30240f;
            totalFE += FE;
            formu = (float)Math.Pow(TD - FE, 2) / FE;
            dgvPoker.Rows.Add("TODOS DIFERENTES",FE, TD, formu);

            FE = (dgvNums2.RowCount - 1) * 0.50400f;
            totalFE += FE;
            formu = (float)Math.Pow((P1 - FE), 2) / FE;
            dgvPoker.Rows.Add("UN PAR", FE, P1, formu);

            FE = (dgvNums2.RowCount - 1) * (0.10800f);
            totalFE += FE;
            formu = (float)Math.Pow((P2 - FE), 2) / FE;
            dgvPoker.Rows.Add("DOS PARES", FE, P2, formu);

            FE = (dgvNums2.RowCount - 1) * (0.07200f);
            totalFE += FE;
            formu = (float)Math.Pow((I3 - FE), 2) / FE;
            dgvPoker.Rows.Add("TRES IGUALES", FE, I3, formu);

            FE = (dgvNums2.RowCount - 1) * (0.00900f);
            totalFE += FE;
            formu = (float)Math.Pow((TP - FE), 2) / FE;

            dgvPoker.Rows.Add("TERCIA y PAR", FE, TP, formu);
            FE = (dgvNums2.RowCount - 1) * (0.00450f);
            totalFE += FE;
            formu = (float)Math.Pow((I4 - FE), 2) / FE;
            dgvPoker.Rows.Add("CUATRO IGUALES", FE, I4, formu);

            FE = (dgvNums2.RowCount - 1) * (0.00010f);
            totalFE += FE;
            formu = (float)Math.Pow((TI - FE), 2) / FE;
            dgvPoker.Rows.Add("TODOS IGUALES", FE, TI, formu);

            totalFO = TD + P1 + P2 + I3 + TP + I4 + TI;

            foreach (DataGridViewRow row in dgvPoker.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[1].Value.ToString() != "")
                {
                    total += float.Parse(row.Cells[3].Value.ToString());
                }
            }

            dgvPoker.Rows.Add("", totalFE, totalFO, total);

            cmdPoker.Enabled = false;

            if(total < 12.59)
            {
                lblRechazo.Text = "Los numeros estan distribuidos uniformemente\n - POKER";
            }
            else
            {
                lblRechazo.Text = "Los numeros NO estan distribuidos uniformemente\n - POKER";
            }
        }

        private void cmdPromedio_Click(object sender, EventArgs e)
        {
            float promedio = 0, z0;
            int N = dgvNums2.RowCount - 1;
            foreach(DataGridViewRow row in dgvNums2.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() != "")
                    promedio += float.Parse(row.Cells[1].Value.ToString());
            }
            promedio /= N;

            z0 = (promedio - 0.5f) * (float)Math.Pow(N,1/2) / (float)Math.Pow(1/12, 1/2);
            z0 = (float)Math.Pow(Math.Pow(z0, 2), 0.5);

            txtProm.Text = promedio.ToString();
            txtZ0.Text = z0.ToString();

            if(z0 < 1.96)
            {
                lblRechazo.Text = "Los numeros estan distribuidos uniformemente\n - PROMEDIO";
            }
            else
            {
                lblRechazo.Text = "Los numeros NO estan distribuidos uniformemente\n - PROMEDIO";
            }
        }
    }
}
