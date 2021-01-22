using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Bejerman
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
            List<BejermanConfig> ListConfig = new List<BejermanConfig>();
            ListConfig = Program.singleton.getXml();
            TxtOrigen.Text = Program.singleton.RutaBejerman;

            if (ListConfig != null && ListConfig.Count > 0)
            {
                for (int i = 0; i < ListConfig.Count; i++)
                {
                    DGVConfig.Rows.Add(ListConfig[i].PuntodeVenta, ListConfig[i].PuntodeVentaElect, ListConfig[i].CodigoZona, ListConfig[i].AperturaContable);
                }
                for (int i = 0; i < 40 - ListConfig.Count; i++) DGVConfig.Rows.Add();
            }
            else
            {
                for (int i = 0; i < 40; i++) DGVConfig.Rows.Add();
            }

        }

        private void BrnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool Validador = false;
                List<BejermanConfig> ListConfig = new List<BejermanConfig>();
                foreach (DataGridViewRow row in DGVConfig.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null)
                    {
                        BejermanConfig config = new BejermanConfig();
                        config.PuntodeVenta = string.Concat(Enumerable.Repeat("0", 4 - (row.Cells[0].Value.ToString()).Length)) + row.Cells[0].Value.ToString();
                        config.PuntodeVentaElect = string.Concat(Enumerable.Repeat("0", 4 - (row.Cells[1].Value.ToString()).Length)) + row.Cells[1].Value.ToString();
                        config.CodigoZona = string.Concat(row.Cells[2].Value.ToString());
                        config.CodigoZona = config.CodigoZona.PadRight(4);
                        config.AperturaContable = string.Concat(row.Cells[3].Value.ToString());
                        config.AperturaContable = config.AperturaContable.PadRight(4);
                        ListConfig.Add(config);
                        Validador = true;
                    }
                }
                if(Validador == true){ 
                Program.singleton.Crear(ListConfig, TxtOrigen.Text);
                MessageBox.Show("Se guardo la configuracion de manera correcta");
                }
                else
                {
                    MessageBox.Show("Inserte datos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            // El siguiente código servirá para que si hacemos un click en Ok con el selector de archivos, el texto del TextBox1 sea el archivo seleccionado.
            var resultado = ofd1.ShowDialog();
            if (resultado == DialogResult.OK) { TxtOrigen.Text = ofd1.FileName; }
        }
    }
}
