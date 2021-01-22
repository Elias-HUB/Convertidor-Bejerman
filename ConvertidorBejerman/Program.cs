using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConvertidorBejerman
{
    static class Program
    {
        static public Bejerman.Singleton singleton = null;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Cursor Cursor = Cursors.WaitCursor;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                singleton = Bejerman.Singleton.Instance;
                string TextoConvertido = "";
                string NuevaCadena = "";
                List<Bejerman.BejermanConfig> ListConfig = new List<Bejerman.BejermanConfig>();
                ListConfig = singleton.getXml();
                string RutaItems = singleton.RutaBejerman.Replace("VCabec00.TXT", "VItems00.TXT");
                string RutaPago = singleton.RutaBejerman.Replace("VCabec00.TXT", "VMedPa00.TXT");
                string RutaFMedPa = singleton.RutaBejerman.Replace("VCabec00.TXT", "FMedPa00.TXT");
                string RutaVRegEs = singleton.RutaBejerman.Replace("VCabec00.TXT", "VRegEs00.TXT");
                string[] textItems = System.IO.File.ReadAllLines(RutaItems, Encoding.Default);
                string[] textPago = System.IO.File.ReadAllLines(RutaPago, Encoding.Default);
                string[] text = System.IO.File.ReadAllLines(singleton.RutaBejerman, Encoding.Default);
                string[] textFMedPa = System.IO.File.ReadAllLines(RutaFMedPa, Encoding.Default);
                string[] textVRegEs = System.IO.File.ReadAllLines(RutaVRegEs, Encoding.Default);
                string[] TextArray = new string[text.Count()];
                string[] TextArrayItems = new string[textItems.Count()];
                string[] TextArrayPago = new string[textPago.Count()];
                string[] TextArrayFMedPa = new string[textFMedPa.Count()];
                string[] TextArrayVRegEs = new string[textVRegEs.Count()];
                int contador = 0;
                int IndicePV = 4;
                int IndiceCZ = 114;
                int IndiceAC = 160;


                //Cabecera
                foreach (string item in text)
                {
                    if (item != "")
                    {
                        string Total = item.Substring(137, 16);
                        string Factura = item.Substring(3, 13);
                        string PV = item.Substring(IndicePV, 4);
                        string CZ = item.Substring(IndiceCZ, 4);
                        string AC = item.Substring(IndiceAC, 4);
                        string Cliente = item.Substring(32, 6);
                        foreach (Bejerman.BejermanConfig Config in ListConfig)
                        {
                            if (Config.PuntodeVenta == PV || Config.PuntodeVentaElect == PV)
                            {
                                NuevaCadena = item.Substring(0, 114);
                                NuevaCadena += Config.CodigoZona;
                                NuevaCadena += item.Substring(118, 41);
                                NuevaCadena += Config.AperturaContable;
                                NuevaCadena += item.Substring(163, item.Length - 163);
                                continue;
                            }
                        }
                        if (NuevaCadena != "")
                        {
                            //if (item.Substring(148, 5) == " 0.00")
                            //{
                            //    NuevaCadena = item.Substring(0, 152) + "1" + item.Substring(153, item.Length - 153);
                            //}
                            if(Cliente == "999999")
                            {
                                NuevaCadena = NuevaCadena.Substring(0, 32) + "      " + NuevaCadena.Substring(38, NuevaCadena.Length - 38);
                                NuevaCadena = NuevaCadena.Substring(0, 122) + "1" + NuevaCadena.Substring(123, NuevaCadena.Length - 123);
                            }
                            TextArray[contador] = NuevaCadena;
                            NuevaCadena = "";
                        }
                        else
                        {
                            TextArray[contador] = item;
                        }
                    }
                    contador++;
                }

                //ITEMS
                contador = 0;
                NuevaCadena = "";
                
                foreach (string item in textItems)
                {
                    string Cliente = item.Substring(32, 6);
                    NuevaCadena = item.Replace("VENTAS", "VTAMER");
                    NuevaCadena = NuevaCadena.Replace("ASEÑA", "CSEÑA");
                    NuevaCadena = NuevaCadena.Replace("PATLINCE", "PAT     ");
                    //if (NuevaCadena.Substring(155, 5) == " 0.00")
                    //{
                    //    TextoConvertido = "";
                    //    TextoConvertido = NuevaCadena.Substring(0, 159) + "1" + NuevaCadena.Substring(160, 63) + "1" + NuevaCadena.Substring(224, 139) + "1";
                    //    NuevaCadena = TextoConvertido + NuevaCadena.Substring(364, item.Length - 364);
                    //}

                    if (Cliente == "999999")
                    {
                        NuevaCadena = NuevaCadena.Substring(0, 32) + "      " + NuevaCadena.Substring(38, NuevaCadena.Length - 38);
                    }
                    TextArrayItems[contador] = NuevaCadena;
                    contador++;
                }


                //Pago
                contador = 0;
                foreach (string item in textPago)
                {
                    NuevaCadena = item;
                    string Total = item.Substring(71, 16);
                    string Factura = item.Substring(3, 13);
                    string TotalFinal = item.Substring(297, 16);
                    string Valor = item.Substring(45, 3);
                    string Cliente = item.Substring(32, 6);
                    var algo = NuevaCadena.Length;
                    if (TotalFinal != Total)
                    {
                        NuevaCadena = item.Replace(Total, TotalFinal);
                    }
                    NuevaCadena = NuevaCadena;
                    //if (item.Substring(82, 5) == " 0.00")
                    //{
                    //    TextoConvertido = "";
                    //    NuevaCadena = item.Substring(0, 86) + "1" + item.Substring(87, 225) + "1";
                    //}

                    if (Valor == "0  " || Valor == "1  ")
                    {
                        NuevaCadena = NuevaCadena.Substring(0, 45) + "CAJ" + NuevaCadena.Substring(48, item.Length - 48);
                    }

                    if (Cliente == "999999")
                    {
                        NuevaCadena = NuevaCadena.Substring(0, 32) + "      " + NuevaCadena.Substring(38, NuevaCadena.Length - 38);
                    }

                    TextArrayPago[contador] = NuevaCadena;
                    contador++;
                }


                //FMedPa
                contador = 0;
                NuevaCadena = "";
                foreach (string item in textFMedPa)
                {
                    string Origen = item.Substring(12, 14);
                    string Monto = item.Substring(96, 16);
                    string AC = item.Substring(338, 4);
                    if (Origen == "CIERRE DE CAJA" || Monto == "            0.00")
                    {
                        continue;
                    }
                    string Apertura = item.Substring(338, 4);
                    NuevaCadena = item.Substring(0, 364) + Apertura + item.Substring(367, item.Length - 367);

                    foreach (Bejerman.BejermanConfig Config in ListConfig)
                    {
                        if (Config.AperturaContable == AC)
                        {
                            NuevaCadena = NuevaCadena.Substring(0, 346) + Config.PuntodeVenta + NuevaCadena.Substring(350, NuevaCadena.Length - 350);
                            continue;
                        }
                    }


                    TextArrayFMedPa[contador] = NuevaCadena;
                    contador++;
                }

                TextArrayFMedPa = TextArrayFMedPa.Where(i => i != null).ToArray();



                //VRegEs
                NuevaCadena = "";
                contador = 0;
                foreach (string item in textVRegEs)
                {
                    if (item != "")
                    {
                        NuevaCadena = item.Substring(0, 32) + "@@@#@@" + item.Substring(38, item.Length - 38);
                        TextArrayVRegEs[contador] = NuevaCadena;
                    }
                    contador++;
                }


                System.IO.File.WriteAllLines(singleton.RutaBejerman, TextArray, Encoding.Default);
                System.IO.File.WriteAllLines(RutaItems, TextArrayItems, Encoding.Default);
                System.IO.File.WriteAllLines(RutaPago, TextArrayPago, Encoding.Default);
                System.IO.File.WriteAllLines(RutaFMedPa, TextArrayFMedPa, Encoding.Default);
                System.IO.File.WriteAllLines(RutaVRegEs, TextArrayVRegEs, Encoding.Default);

                MessageBox.Show("Finalizo de manera correcta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verificar Log");
                ConsoleLog(ex.Message);
            }
        }

        static public void ConsoleLog(string Message)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(".\\Log.txt", true))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + " - Error log: \n" + Message + " \n");
                    file.Close();
                }
            }
            catch
            {

            }
        }

        static public void Crear(string Message, string Ruta)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(Ruta, false))
                {
                    file.WriteLine(Message);
                    file.Close();
                }
            }
            catch
            {

            }
        }
    }
}
