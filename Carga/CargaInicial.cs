using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carga
{
    public partial class CargaInicial : Form
    {
        string response = "";
        int Contador = 0;

        public CargaInicial()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.Opacity < 1) this.Opacity += 0.05; //Opacity trabaja en procentaje 1 es 100%
                circularProgressBar1.Value += 1;

                if (circularProgressBar1.Value == 500)
                {
                    circularProgressBar1.Value = 0;
                    TimerInicio.Stop();
                    TimerInicio.Start();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                this.Opacity -= 0.1;
                if (this.Opacity == 0)
                {
                    TimerCierre.Stop();
                    if (response != "")
                    {
                        TimerMensajes.Stop();
                        TimerInicio.Stop();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargaInicial_Load(object sender, EventArgs e)
        {
            try
            {
                circularProgressBar1.Value = 0;
                circularProgressBar1.Minimum = 0;
                circularProgressBar1.Maximum = 500;
                TimerInicio.Start();
                TimerMensajes.Start();
                TimerCierre.Start();
            }
           
            catch (Exception ex)
            {
                this.Hide();
                MessageBox.Show("Error al intertar cargar datos. \r" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

       

        private void TimerMensajes_Tick(object sender, EventArgs e)
        {
            try
            {
                Contador++;
                if (Contador == 1)
                {
                    LblTextoCarga.Text = "Modificando.";
                    LblTextoCarga.Left = (this.ClientSize.Width - LblTextoCarga.Width) / 2;
                }
                if (Contador == 2)
                {
                    LblTextoCarga.Text = "Modificando..";
                    LblTextoCarga.Left = (this.ClientSize.Width - LblTextoCarga.Width) / 2;
                }
                if (Contador == 3)
                {
                    LblTextoCarga.Text = "Modificando...";
                    LblTextoCarga.Left = (this.ClientSize.Width - LblTextoCarga.Width) / 2;
                }
                if (Contador == 4)
                {
                    Contador = 0;
                    TimerMensajes.Stop();
                    TimerMensajes.Start();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
