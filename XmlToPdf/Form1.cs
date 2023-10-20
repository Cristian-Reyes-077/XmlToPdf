using System.Xml;
using System.Xml.Serialization;
using XmlToPdf.Controlelrs.Objects;
using XmlToPdf.Controlelrs;
using XmlToPdf.Xmlv40;
using System.Diagnostics;
using HandlebarsDotNet;
using System.Security.Policy;
using DotLiquid;
using System.util;
using XmlToPdf.Xmlv40.Conceptos;
using Hash = DotLiquid.Hash;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using XMLToClassSAT;
using XmlToPdf.Xmlv40.Impsts;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;


namespace XmlToPdf
{
    public partial class Form1 : Form
    {
        Comprobante comprobantXml = new Comprobante();


        public Form1()
        {
            InitializeComponent();
        }



        private void button5_Click_1(object sender, EventArgs e)
        {
            // verificar que exista archivo xml
            if (!File.Exists(textBox1.Text))
            {
                MessageBox.Show("El archivo XML no existe en la ruta especificada.", "RENOVATIO PyME");
                return;
            }


            // verifica que no ewsten vacios los campos necesarios
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese los 2 cambos requeridos.", "RENOVATIO PyME");
                return;
            }

            if (!Directory.Exists(textBox2.Text.Trim()))
            {
                try
                {
                    Directory.CreateDirectory(textBox2.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Valio ocurrio el siguiente error al crear directorio: {ex.Message}", "RENOVATIO PyME");
                }
            }

            textBox2.Text = ponerDiagInvert(textBox2.Text);

            //01
            deserealiza(textBox1.Text.Trim());

            TimbreFiscalDigital tfd = getDes();


            string paap = comprobantXml.Emisor.Nombre;
            string pap = comprobantXml.Version;
            string paps = comprobantXml.FormaPago;
            string paaw = comprobantXml.Fecha;
            string papd = comprobantXml.Folio;
            string uid = tfd.UUID;

            //02
            //string path = AppDomain.CurrentDomain.BaseDirectory + "/";
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string pathHTMLtemp = path + "miHtml.html";//plantilla temporal
            //string pathPlantillaHTML = path + "Plantillas\\plantillaHtmlPdfTwo.html";
            string pathPlantillaHTML = path + "Plantillas\\plantillaHtmlPdfs.html";
            string sHtml = GetStrOffile(pathPlantillaHTML);
            string resultHtml = "";


            resultHtml = remplaceObjtoHtml(sHtml);

            //// Rellena la plantilla con los datos
            //Template template = Template.Parse(sHtml);
            //resultHtml = template.Render(DotLiquid.Hash.FromAnonymousObject(comprobantXml));

            // resultHtml = RazorEngine.Razor.Parse(sHtml, comprobantXml);// Con ayuda de razor sustituimos variables del html con las del objeto

            //Creamos el archivo temporal
            System.IO.File.WriteAllText(pathHTMLtemp, resultHtml);

            string pathWKHTMLTOPDF = path + "wkhtmltox/wkhtmltopdf.exe";//ruta del archivo que convierte html en pdf

            //procesar linea de comandos
            ProcessStartInfo oProcessStartInfo = new ProcessStartInfo();
            oProcessStartInfo.UseShellExecute = false;
            oProcessStartInfo.FileName = pathWKHTMLTOPDF;

            oProcessStartInfo.Arguments = $"miHtml.html {textBox2.Text}{uid}.pdf";

            using (Process oProcess = Process.Start(oProcessStartInfo))
            {
                oProcess.WaitForExit();
            }


            //Borramos el archivo temporal
            System.IO.File.Delete(pathHTMLtemp);












            //Comprobante40 oComprobante = new Comprobante40();

            //string path = textBox1.Text.Trim();

            //XmlSerializer oSerializer = new XmlSerializer(typeof(Comprobante40));

            //using(StreamReader sr = new StreamReader(path))
            //{
            //    //Deserealizamos y guardamos los datos en la clase comprobante
            //    oComprobante=(Comprobante40)oSerializer.Deserialize(sr);
            //}
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = "C:\\Users\\Guadalupe Reyes C\\OneDrive - Universidad Tecnologica de Aguascalientes\\Documentos lap ant\\13 Empresas\\FR Diaz\\xml\\XmlToPdf\\760F0728-7261-D24D-8E7D-7706C0D75E96.xml";
            //textBox1.Text = "C:\\MiXml.xml";
            textBox2.Text = "C:\\RENOVATIO\\";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // instancia del OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // config de OpenFileDialog
            openFileDialog.Filter = "Archivos XML (*.xml)|*.xml";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;

            // moostrar el cuadro de diálogo y espera a que el usuario seleccione un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obt ruta del archivo seleccionado
                string rutaArchivo = openFileDialog.FileName;

                //  ruta del archivo en el TextBox
                textBox1.Text = rutaArchivo;
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = ponerDiagInvert(textBox2.Text);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia de FolderBrowserDialog
            FolderBrowserDialog folder = new FolderBrowserDialog();

            // Establecer propiedades del diálogo
            folder.Description = "Seleccione una carpeta.";

            // Mostrar el diálogo y comprobar si el usuario seleccionó una carpeta
            if (folder.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta de la carpeta seleccionada
                textBox2.Text = folder.SelectedPath;
            }
        }
            private string ponerDiagInvert(String cadena)
            {
                if (!cadena.EndsWith("\\"))
                {
                    cadena = $"{cadena.Trim()}\\";
                }

                return cadena;
            }


        private string remplaceObjtoHtml(String strHtml)
        {
            string html = strHtml;

            Comprobante com = comprobantXml;
            TimbreFiscalDigital tfd = getDes();



            //--Ruta img qr--//
            string strImage = comprobantXml.QR;

            //--Emisor--//
            string strEmisorRfc = comprobantXml.Emisor.Rfc;
            string strEmisorName = comprobantXml.Emisor.Nombre;
            string strEmisorRegInt = comprobantXml.Emisor.RegimenFiscal;
            string strEmisorRegi = getRegimenFiscal(Int32.Parse(comprobantXml.Emisor.RegimenFiscal));

            //--Receptor--//
            string strReceptorUsoCfdi = comprobantXml.Receptor.UsoCFDI;
            string strReceptorRfc = comprobantXml.Receptor.Rfc;
            string strReceptorName = comprobantXml.Receptor.Nombre;
            int intReceptorRegi = Int32.Parse(comprobantXml.Receptor.RegimenFiscalReceptor);
            string strReceptorRegi = getRegimenFiscal(Int32.Parse(comprobantXml.Receptor.RegimenFiscalReceptor));
            string strReceptorDirr = comprobantXml.Receptor.DomicilioFiscalReceptor;

            //--About comprobante--//
            string strUuid = tfd.UUID;
            string strFolioCom = com.Folio;
            string strNoCerCom = com.NoCertificado;
            string strNoCerSat = tfd.NoCertificadoSAT;
            string strVersionTf = tfd.Version;
            string strSubtotalCom = intAMoneda(0, com.SubTotal, "");
            string strImpTotalCom = intAMoneda(0, com.Total, "");
            decimal strImpTotalId = com.Total - com.SubTotal;
            string strImpTotalImp = intAMoneda(0, strImpTotalId, "");
            string strDescuentCom = intAMoneda(0, com.Descuento, "");
            string strSelloCfdi = tfd.SelloCFD;
            string strSelloSatt = tfd.SelloSAT;
            string strRfcProvTim = tfd.RfcProvCertif;
            string strTipoCom = com.TipoDeComprobante;
            string strFechaTimb = tfd.FechaTimbrado.ToString("s");


            string strCfdiVersion = comprobantXml.Version;
            string strFormaPago = comprobantXml.FormaPago;
            string strFormaPagoletra = getMetodoPagoLetra(Int32.Parse(strFormaPago));
            string strMetodoPago = comprobantXml.MetodoPago;
            string paaw = comprobantXml.Fecha;

            var asd = com.Impuestos.Traslados;
            var aasd = com.Impuestos;

            //--Impuestos--//
            //var pimpuestos = comprobantXml.Impuestos.Traslados.ToList();
            var pimpuestos = comprobantXml.Impuestos.Traslados.ToList();
            var pimpuestosAdaptados = pimpuestos.Select(b => new ImpuestoAdapter(b)).ToList();////Convertir objetos conceptos a objetos ProductoAdapter

            //--Conceptos--//
            var pproductos = comprobantXml.Conceptos.ToList();
            var pproductosAdaptados = pproductos.Select(p => new ProductoAdapter(p)).ToList();////Convertir objetos conceptos a objetos ProductoAdapter

            switch (strTipoCom.Trim())
            {
                case "I":
                    strTipoCom = "Ingreso";
                    break;
                default:
                    strTipoCom = "Egreso";
                    break;
            }
            // Crear un objeto de datos para la plantilla
            var data = new
            {
                fecha = DateTime.Now.ToShortDateString(),
                comprobante = new
                {
                    uuid = $"{strUuid}",// UUID de la factura (sustituye con el valor real)
                    tipo = $"{strTipoCom}",
                    version = $"{strCfdiVersion}",
                    formpago = $"{strFormaPago}",
                    formapagostr = $"{strFormaPagoletra}",
                    metodopago = $"{strMetodoPago}",
                    nocertificado = $"{strNoCerCom}",
                    nocertificadosat = $"{strNoCerSat}",
                    folio = $"{strFolioCom}",
                    total = $"{strImpTotalCom}",
                    sellocfdi = $"{strSelloCfdi}",
                    descuento = $"{strDescuentCom}",
                    sellosatt = $"{strSelloSatt}",
                    monedaconletra = $"{MonedaConLetra}",
                    cadenacomp = $"||{strVersionTf}|{strUuid}|{strFechaTimb}|{strRfcProvTim}|{strSelloCfdi}"
                },
                emisor = new
                {
                    rfc = $"{strEmisorRfc}",
                    nombre = $"{strEmisorName}",
                    regimen = $"{strEmisorRegi}",
                    numregimen = $"{strEmisorRegInt}",
                    direccion = "Dirección del Emisor"
                },
                receptor = new
                {
                    rfc = $"{strReceptorRfc}",
                    nombre = $"{strReceptorName}",
                    regimen = $"{strReceptorRegi}",
                    usocfdi = $"{strReceptorUsoCfdi}",
                    direccion = "Dirección del Receptor"
                },
                impuestoo = pimpuestosAdaptados,
                urlimage = strImage,
                productos = pproductosAdaptados,
                totalimpuestos = strImpTotalImp,
                totalFactura = intAMoneda(0, pproductos.Sum(p => p.Importe), "") // Calcula el total de la factura
            };

            //string templateSource = "C:\\Users\\Guadalupe Reyes C\\Downloads\\prueba.html"; // (plantilla HTML prueba2)
            //String content = File.ReadAllText(templateSource);

            // Compila la plantilla
            Template template = Template.Parse(html);

            // Rellena la plantilla con los datos
            string htmlMamalon = template.Render(Hash.FromAnonymousObject(data));

            return htmlMamalon;
        }

        private string MonedaConLetra
        {
            get
            {
                Comprobante com = comprobantXml;

                Moneda oMoneda = new Moneda();
                return oMoneda.Convertir(com.Total.ToString("#.00"), true);
            }
        }

        private void deserealiza(String pathXml)
        {
            //NodosCFDI.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/4");
            var serializer = new XmlSerializer(typeof(Comprobante));
            bool seguardo = false;

            string pathxml = pathXml;

            using (var reader = XmlReader.Create(pathxml))
            {
                //XMLv40.Comprobante info = (XMLv40.Comprobante)serializer.Deserialize(reader);
                Comprobante comprobanteXml = (Comprobante)serializer.Deserialize(reader);
                Dictionary<string, object> objetosComplemento = new Dictionary<string, object>();
                ComprobanteComplemento complementos = comprobanteXml.Complemento;
                if (complementos != null)
                {
                    var cmps = complementos.Any;//.SelectNodes("//NombreNodo", nsmgr);
                    foreach (XmlElement elem in complementos.Any)
                    {
                        string[] elementosAccept = new string[7] { "nomina", "nomina12", "tfd", "pago10", "pago20", "implocal", "cartaporte20" };
                        string prefijo = elem.Prefix;
                        string nombre = elem.LocalName;
                        if (elementosAccept.Contains(prefijo))
                        {
                            switch (prefijo)
                            {
                                case "nomina":
                                    {

                                        XmlToPdf.Controlelrs.Nomina11.Nomina nom = (FuncionesG.DeserializarXml<XmlToPdf.Controlelrs.Nomina11.Nomina>(elem));
                                        if (nom != null)
                                            objetosComplemento.Add(prefijo, nom);
                                        break;
                                    }
                                case "nomina12":
                                    {
                                        XmlToPdf.Controlelrs.Nomina12.Nomina nom = (FuncionesG.DeserializarXml<XmlToPdf.Controlelrs.Nomina12.Nomina>(elem));
                                        if (nom != null)
                                            objetosComplemento.Add(prefijo, nom);
                                        break;
                                    }
                                case "tfd":
                                    {
                                        TimbreFiscalDigital nom = (FuncionesG.DeserializarXml<TimbreFiscalDigital>(elem));
                                        if (nom != null)
                                            objetosComplemento.Add(prefijo, nom);
                                        break;
                                    }
                                case "pago10":
                                    {
                                        XmlToPdf.Controlelrs.Pagos10.Pagos nom = (FuncionesG.DeserializarXml<XmlToPdf.Controlelrs.Pagos10.Pagos>(elem));
                                        if (nom != null)
                                            objetosComplemento.Add(prefijo, nom);
                                        break;
                                    }
                                case "pago20":
                                    {
                                        XmlToPdf.Controlelrs.Pagos20.Pagos nom = (FuncionesG.DeserializarXml<XmlToPdf.Controlelrs.Pagos20.Pagos>(elem));
                                        if (nom != null)
                                            objetosComplemento.Add(prefijo, nom);
                                        break;
                                    }
                                case "implocal":
                                    {
                                        XmlToPdf.Controlelrs.ImpuestosLocales.ImpuestosLocales nom = (FuncionesG.DeserializarXml<XmlToPdf.Controlelrs.ImpuestosLocales.ImpuestosLocales>(elem));
                                        if (nom != null)
                                            objetosComplemento.Add(prefijo, nom);
                                        break;
                                    }
                                case "cartaporte20":
                                    {
                                        XmlToPdf.Controlelrs.CartaPorte20.CartaPorte nom = (FuncionesG.DeserializarXml<XmlToPdf.Controlelrs.CartaPorte20.CartaPorte>(elem));
                                        if (nom != null)
                                            objetosComplemento.Add(prefijo, nom);
                                        break;
                                    }
                            }

                        }
                        var objetos = objetosComplemento.ContainsKey("tfd");

                        comprobantXml = comprobanteXml;
                    }
                    //if (objetosComplemento.ContainsKey("tfd"))
                    //    seguardo = info.guardarComprobante(objetosComplemento, textoxml);
                }
            }
        }
        private static string GetStrOffile(string pathFile)
        {
            String content = File.ReadAllText(pathFile);
            return content;
        }

        private TimbreFiscalDigital getDes()
        {
            ComprobanteComplemento comp = comprobantXml.Complemento;

            var cmps = comp.Any;//.SelectNodes("//NombreNodo", nsmgr);
            Dictionary<string, object> objetosComplemento = new Dictionary<string, object>();
            TimbreFiscalDigital tfd = new TimbreFiscalDigital();
            foreach (XmlElement elem in comp.Any)
            {
                string[] elementosAccept = new string[7] { "nomina", "nomina12", "tfd", "pago10", "pago20", "implocal", "cartaporte20" };
                string prefijo = elem.Prefix;
                string nombre = elem.LocalName;
                if (elementosAccept.Contains(prefijo))
                {
                    switch (prefijo)
                    {
                        case "tfd":
                            {
                                tfd = (FuncionesG.DeserializarXml<TimbreFiscalDigital>(elem));
                                if (tfd != null)
                                    objetosComplemento.Add(prefijo, tfd);
                                break;
                            }
                    }

                }

            }

            return tfd;
        }

        public static string intAMoneda(int valor, decimal val, String valo)
        {
            if (val != 0)
            {
                string mstring = String.Format("{0:C}", val);
                return mstring;
            }
            else if (valo != "")
            {
                decimal num = Decimal.Parse(valo);
                string mstring = String.Format("{0:C}", num);
                return mstring;
            }
            else if (valor != 0)
            {
                string mstring = String.Format("{0:C}", valor);
                return mstring;
            }
            else
            {
                int cell = 0;
                string mstring = String.Format("{0:C}", cell);
                return mstring;
            }
        }

        public static string getRegimenFiscal(int codigoReg)
        {
            Dictionary<int, String> dicRegimen = new Dictionary<int, string>();

            dicRegimen.Add(601, "General de Ley Personas Morales");
            dicRegimen.Add(603, "Personas Morales con Fines no Lucrativos");
            dicRegimen.Add(605, "Sueldos y Salarios e Ingresos Asimilados a Salarios");
            dicRegimen.Add(606, "Arrendamiento");
            dicRegimen.Add(607, "Régimen de Enajenación o Adquisición de Bienes");
            dicRegimen.Add(608, "Demás ingresos");
            dicRegimen.Add(609, "Consolidación");
            dicRegimen.Add(610, "Residentes en el Extranjero sin Establecimiento Permanente en México");
            dicRegimen.Add(611, "Ingresos por Dividendos(socios y accionistas)");
            dicRegimen.Add(612, "Personas Físicas con Actividades Empresariales y Profesionales");
            dicRegimen.Add(614, "Ingresos por intereses");
            dicRegimen.Add(615, "Régimen de los ingresos por obtención de premios");
            dicRegimen.Add(616, "Sin obligaciones fiscales");
            dicRegimen.Add(620, "Sociedades Cooperativas de Producción que optan por diferir sus ingresos");
            dicRegimen.Add(621, "Incorporación Fiscal");
            dicRegimen.Add(622, "Actividades Agrícolas, Ganaderas, Silvícolas y Pesqueras");
            dicRegimen.Add(623, "Opcional para Grupos de Sociedades");
            dicRegimen.Add(624, "Coordinados");
            dicRegimen.Add(625, "Régimen de las Actividades Empresariales con ingresos a través de Plataformas Tecnológicas");
            dicRegimen.Add(626, "Régimen Simplificado de Confianza");
            dicRegimen.Add(628, "Hidrocarburos");
            dicRegimen.Add(629, "De los Regímenes Fiscales Preferentes y de las Empresas Multinacionales");
            dicRegimen.Add(630, "Enajenación de acciones en bolsa de valores");

            String regimenFis = string.Empty;
            if (dicRegimen.ContainsKey(codigoReg))
            {
                regimenFis = dicRegimen[codigoReg];
            }

            return regimenFis;
        }

        public static string getMetodoPagoLetra(int codigoPago)
        {
            Dictionary<int, String> dicRegimen = new Dictionary<int, string>();

            dicRegimen.Add(01, "Efectivo");
            dicRegimen.Add(02, "Cheque nominativo");
            dicRegimen.Add(03, "Transferencia electrónica de fondos");
            dicRegimen.Add(04, "Tarjeta de crédito");
            dicRegimen.Add(05, "Monedero electrónico");
            dicRegimen.Add(06, "Dinero electrónico");
            dicRegimen.Add(08, "Vales de despensa");
            dicRegimen.Add(12, "Dación en pago");
            dicRegimen.Add(13, "Pago por subrogación");
            dicRegimen.Add(14, "Pago por consignación");
            dicRegimen.Add(15, "Condonación");
            dicRegimen.Add(17, "Compensación");
            dicRegimen.Add(23, "Novación");
            dicRegimen.Add(24, "Confusión");
            dicRegimen.Add(25, "Remisión de deuda");
            dicRegimen.Add(26, "Prescripción o caducidad");
            dicRegimen.Add(27, "A satisfacción del acreedor");
            dicRegimen.Add(28, "Tarjeta de débito");
            dicRegimen.Add(29, "Tarjeta de servicios");
            dicRegimen.Add(30, "Aplicación de anticipos");
            dicRegimen.Add(99, "Por definir");

            String regimenFis = "No encontrado";
            if (dicRegimen.ContainsKey(codigoPago))
            {
                regimenFis = dicRegimen[codigoPago];
            }

            return regimenFis;
        }

        //public static string getUsoCfdiLetra(String codigoUso)
        //{
        //    Dictionary<int, String> dicUsoFiscal = new Dictionary<int, string>();

        //    dicUsoFiscal.Add("G01", "Adquisición de mercancías.");
        //    dicUsoFiscal.Add(G02, "Devoluciones, descuentos o bonificaciones.");
        //    dicUsoFiscal.Add(G03, "Gastos en general.");
        //    dicUsoFiscal.Add(I01, "Construcciones.");
        //    dicUsoFiscal.Add(I02, "Mobiliario y equipo de oficina por inversiones.");
        //    dicUsoFiscal.Add(I03, "Equipo de transporte.");
        //    dicUsoFiscal.Add(I04, "Equipo de computo y accesorios.");
        //    dicUsoFiscal.Add(I05, "Dados, troqueles, moldes, matrices y herramental.");
        //    dicUsoFiscal.Add(I06, "Comunicaciones telefónicas.");
        //    dicUsoFiscal.Add(I07, "Comunicaciones satelitales.");
        //    dicUsoFiscal.Add(I08, "Otra maquinaria y equipo.");
        //    dicUsoFiscal.Add(D01, "Honorarios médicos, dentales y gastos hospitalarios.");
        //    dicUsoFiscal.Add(D02, "Gastos médicos por incapacidad o discapacidad.");
        //    dicUsoFiscal.Add(D03, "Gastos funerales.");
        //    dicUsoFiscal.Add(D04, "Donativos.");
        //    dicUsoFiscal.Add(D05, "Intereses reales efectivamente pagados por créditos hipotecarios (casa habitación).");
        //    dicUsoFiscal.Add(D06, "Aportaciones voluntarias al SAR.");
        //    dicUsoFiscal.Add(D07, "Primas por seguros de gastos médicos.");
        //    dicUsoFiscal.Add(D08, "Gastos de transportación escolar obligatoria.");
        //    dicUsoFiscal.Add(D09, "Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensiones.");
        //    dicUsoFiscal.Add(D10, "Pagos por servicios educativos (colegiaturas).");
        //    dicUsoFiscal.Add(S01, "Sin efectos fiscales.");
        //    dicUsoFiscal.Add(CP01, "Pagos");
        //    dicUsoFiscal.Add(CN01, "Nómina");

        //    String regimenFis = "No encontrado";
        //    if (dicRegimen.ContainsKey(codigoPago))
        //    {
        //        regimenFis = dicRegimen[codigoPago];
        //    }

        //    return regimenFis;
        //}
        //----Interface para poder trabhajar con ToLiquid y la interfaz de la plantilla html----//
        public class ProductoAdapter : ILiquidizable
        {
            private readonly Concepto _producto;

            public ProductoAdapter(Concepto producto)
            {
                _producto = producto;
            }

            public object ToLiquid()
            {
                return new Hash
            {
                { "Clave", _producto.NoIdentificacion },
                { "Descripcion", _producto.Descripcion },
                { "Cantidad", _producto.Cantidad },
                { "Unidad", _producto.Unidad + $"<br> <p class=\"small-text\"> {_producto.ClaveUnidad} <p>" },
                { "PrecioUnitario", _producto.ValorUnitario },
                { "Total", _producto.Importe }
             };
            }
        }

        public class ImpuestoAdapter : ILiquidizable
        {
            private readonly ImpuestosTraslado _impuesto;

            public ImpuestoAdapter(ImpuestosTraslado impuesto)
            {
                _impuesto = impuesto;
            }

            public object ToLiquid()
            {
                return new Hash
            {
                //{ "Clave", _impuesto.Impuesto },
                //{ "TipoFact", _impuesto.TipoFactor },
                //{ "TasaOCuota", _impuesto.TasaOCuota },
                { "Totall", _impuesto.Importe }
             };
            }

        }

        

    }
}
