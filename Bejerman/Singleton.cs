using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace Bejerman
{
    public class Singleton
    {
        public string config = "config.xml";
        public string Archivo = "";

        public string RutaBejerman = "";        

        private static Singleton _instance = null;

        private Singleton()
        {
            getXml();
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        public List<BejermanConfig> getXml()
        {
            try
            {
                if (File.Exists(config))
                {
                    List<BejermanConfig> ListConfig = new List<BejermanConfig>();

                    XDocument Raiz = XDocument.Load(".\\" + config, LoadOptions.None);
                    XElement ElementBejerman = Raiz.Element("Bejerman");
                    RutaBejerman = ElementBejerman.Element("RutaExportacion").Value;
                    IEnumerable<XElement> Config = ElementBejerman.Descendants("Config");
                    foreach (XElement Parametro in Config)
                    {
                        BejermanConfig config = new BejermanConfig();
                        config.PuntodeVenta = Parametro.Element("PuntodeVenta").Value;
                        config.PuntodeVentaElect = Parametro.Element("PuntodeVentaElect").Value;
                        config.CodigoZona = Parametro.Element("CodigoZona").Value;
                        config.AperturaContable = Parametro.Element("AperturaContable").Value;
                        ListConfig.Add(config);
                    }
                    return ListConfig;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Crear(List<BejermanConfig> ListConfig, string Ruta)
        {
            try
            {
                RutaBejerman = Ruta;
                Archivo = Ruta.Substring(Ruta.LastIndexOf(@"\"));
                Archivo = Archivo.Replace("\\", "");
                XmlDocument doc = new XmlDocument();
                XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = doc.DocumentElement;
                doc.InsertBefore(xmlDeclaration, root);
                XmlElement elementBejerman = doc.CreateElement(string.Empty, "Bejerman", string.Empty);
                doc.AppendChild(elementBejerman);

                XmlElement RutaExportacion = doc.CreateElement(string.Empty, "RutaExportacion", string.Empty);
                elementBejerman.AppendChild(RutaExportacion);
                XmlText textRB = doc.CreateTextNode(RutaBejerman);
                RutaExportacion.AppendChild(textRB);

                foreach (BejermanConfig Parametros in ListConfig)
                {
                    XmlElement BejermanConfig = doc.CreateElement(string.Empty, "Config", string.Empty);
                    elementBejerman.AppendChild(BejermanConfig);


                    XmlElement elementPuntodeVenta = doc.CreateElement(string.Empty, "PuntodeVenta", string.Empty);
                    BejermanConfig.AppendChild(elementPuntodeVenta);
                    XmlText textPV = doc.CreateTextNode(Parametros.PuntodeVenta);
                    elementPuntodeVenta.AppendChild(textPV);

                    XmlElement elementPuntodeVentaElect = doc.CreateElement(string.Empty, "PuntodeVentaElect", string.Empty);
                    BejermanConfig.AppendChild(elementPuntodeVentaElect);
                    XmlText textPVElect = doc.CreateTextNode(Parametros.PuntodeVentaElect);
                    elementPuntodeVentaElect.AppendChild(textPVElect);

                    XmlElement elementCodigoZona = doc.CreateElement(string.Empty, "CodigoZona", string.Empty);
                    BejermanConfig.AppendChild(elementCodigoZona);
                    XmlText textCZ = doc.CreateTextNode(Parametros.CodigoZona);
                    elementCodigoZona.AppendChild(textCZ);


                    XmlElement elementAperturaContable = doc.CreateElement(string.Empty, "AperturaContable", string.Empty);
                    BejermanConfig.AppendChild(elementAperturaContable);
                    XmlText textAC = doc.CreateTextNode(Parametros.AperturaContable);
                    elementAperturaContable.AppendChild(textAC);

                }
                doc.Save(".\\"+config);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
