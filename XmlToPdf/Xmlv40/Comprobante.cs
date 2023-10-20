using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using XmlToPdf.Controlelrs.Objects;
using XmlToPdf.Xmlv40.Conceptos;
using XmlToPdf.Xmlv40.Impsts;

namespace XmlToPdf.Xmlv40
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/cfd/4", IsNullable = false)]
    public partial class Comprobante
    {
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns { get; set; }
        private ComprobanteInformacionGlobal informacionGlobalField;

        private ComprobanteCfdiRelacionados[] cfdiRelacionadosField;

        private ComprobanteEmisor emisorField;

        private ComprobanteReceptor receptorField;

        private Concepto[] conceptosField;

        private Impuestos impuestosField;

        private ComprobanteComplemento complementoField;

        private ComprobanteAddenda addendaField;

        private string versionField;

        private string serieField;

        private string folioField;

        private string fechaField;

        private string selloField;

        private string formaPagoField;

        private bool formaPagoFieldSpecified;

        private string noCertificadoField;

        private string certificadoField;

        private string condicionesDePagoField;

        private decimal subTotalField;

        private decimal descuentoField;

        private bool descuentoFieldSpecified;

        private string monedaField;

        private decimal tipoCambioField;

        private bool tipoCambioFieldSpecified;

        private decimal totalField;

        private string tipoDeComprobanteField;

        private string exportacionField;

        private string metodoPagoField;

        private bool metodoPagoFieldSpecified;

        private string lugarExpedicionField;

        private string confirmacionField;

        public string QR
        {


            get
            {
                var cmps = this.complementoField.Any;//.SelectNodes("//NombreNodo", nsmgr);
                Dictionary<string, object> objetosComplemento = new Dictionary<string, object>();
                TimbreFiscalDigital tfd = new TimbreFiscalDigital();
                foreach (XmlElement elem in complementoField.Any)
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

                byte[] qr = null;
                string sQR = "";
                string baseQR = "";
                string cadenaQr = "https://verificacfdi.facturaelectronica.sat.gob.mx/default.aspx?id=" + tfd.UUID +
                    "&re=" + Emisor.Rfc + "&fe=" + Receptor.Rfc + "&tt=" + Total + "&fe=" + Sello.Substring(Sello.Length - 9, 8);

                qr = XMLToClassSAT.QR.createBarCode(cadenaQr);
                baseQR = System.Convert.ToBase64String(qr);
                sQR = System.String.Format("data:image/gif;base64,{0}", baseQR);

                return sQR;

            }
        }

        [XmlIgnore]
        public int cfd_comprobante_id { get; set; }

        [XmlAttribute("schemaLocation", Namespace = XmlSchema.InstanceNamespace)]
        public string xsiSchemaLocation { get; set; }
        public Comprobante()
        {
            this.versionField = "4.0";
            xmlns = new XmlSerializerNamespaces();
            xmlns.Add("cfdi", "http://www.sat.gob.mx/cfd/4");
            //xsiSchemaLocation = "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv33.xsd http://www.sat.gob.mx/CartaPorte20 http://www.sat.gob.mx/sitio_internet/cfd/CartaPorte/CartaPorte20.xsd";
            xsiSchemaLocation = "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd";
        }
        /// <remarks/>
        public ComprobanteInformacionGlobal InformacionGlobal
        {
            get
            {
                return this.informacionGlobalField;
            }
            set
            {
                this.informacionGlobalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CfdiRelacionados")]
        public ComprobanteCfdiRelacionados[] CfdiRelacionados
        {
            get
            {
                return this.cfdiRelacionadosField;
            }
            set
            {
                this.cfdiRelacionadosField = value;
            }
        }

        /// <remarks/>
        public ComprobanteEmisor Emisor
        {
            get
            {
                return this.emisorField;
            }
            set
            {
                this.emisorField = value;
            }
        }

        /// <remarks/>
        public ComprobanteReceptor Receptor
        {
            get
            {
                return this.receptorField;
            }
            set
            {
                this.receptorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Concepto", IsNullable = false)]
        public Concepto[] Conceptos
        {
            get
            {
                return this.conceptosField;
            }
            set
            {
                this.conceptosField = value;
            }
        }

        /// <remarks/>
        public Impuestos Impuestos
        {
            get
            {
                return this.impuestosField;
            }
            set
            {
                this.impuestosField = value;
            }
        }

        /// <remarks/>
        public ComprobanteComplemento Complemento
        {
            get
            {
                return this.complementoField;
            }
            set
            {
                this.complementoField = value;
            }
        }

        /// <remarks/>
        public ComprobanteAddenda Addenda
        {
            get
            {
                return this.addendaField;
            }
            set
            {
                this.addendaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Folio
        {
            get
            {
                return this.folioField;
            }
            set
            {
                this.folioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Fecha
        {
            get
            {
                return this.fechaField;
            }
            set
            {
                this.fechaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Sello
        {
            get
            {
                return this.selloField;
            }
            set
            {
                this.selloField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FormaPago
        {
            get
            {
                return this.formaPagoField;
            }
            set
            {
                this.formaPagoField = value;
                this.formaPagoFieldSpecified = (value != null);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FormaPagoSpecified
        {
            get
            {
                return this.formaPagoFieldSpecified;
            }
            set
            {
                this.formaPagoFieldSpecified = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NoCertificado
        {
            get
            {
                return this.noCertificadoField;
            }
            set
            {
                this.noCertificadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Certificado
        {
            get
            {
                return this.certificadoField;
            }
            set
            {
                this.certificadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CondicionesDePago
        {
            get
            {
                return this.condicionesDePagoField;
            }
            set
            {
                this.condicionesDePagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SubTotal
        {
            get
            {
                return this.subTotalField;
            }
            set
            {
                this.subTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Descuento
        {
            get
            {
                return this.descuentoField;
            }
            set
            {
                this.descuentoField = value;
                this.descuentoFieldSpecified = (value != null);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DescuentoSpecified
        {
            get
            {
                return this.descuentoFieldSpecified;
            }
            set
            {
                this.descuentoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Moneda
        {
            get
            {
                return this.monedaField;
            }
            set
            {
                this.monedaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TipoCambio
        {
            get
            {
                return this.tipoCambioField;
            }
            set
            {
                this.tipoCambioField = value;
                this.tipoCambioFieldSpecified = (value != null);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoCambioSpecified
        {
            get
            {
                return this.tipoCambioFieldSpecified;
            }
            set
            {
                this.tipoCambioFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoDeComprobante
        {
            get
            {
                return this.tipoDeComprobanteField;
            }
            set
            {
                this.tipoDeComprobanteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Exportacion
        {
            get
            {
                return this.exportacionField;
            }
            set
            {
                this.exportacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MetodoPago
        {
            get
            {
                return this.metodoPagoField;
            }
            set
            {
                this.metodoPagoField = value;
                this.metodoPagoFieldSpecified = (value != null);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MetodoPagoSpecified
        {
            get
            {
                return this.metodoPagoFieldSpecified;
            }
            set
            {
                this.metodoPagoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LugarExpedicion
        {
            get
            {
                return this.lugarExpedicionField;
            }
            set
            {
                this.lugarExpedicionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Confirmacion
        {
            get
            {
                return this.confirmacionField;
            }
            set
            {
                this.confirmacionField = value;
            }
        }
        //public bool guardarComprobante(Dictionary<string,object> complementos,string textoxml)
        //{
        //    List<object> listaColsVal = FuncionesG.qryInsert(this);
        //    if (listaColsVal.Count > 0 && FuncionesG.verificatfd(complementos))
        //    {
        //        string qry = $"{FuncionesG.ListaObjectToqry(listaColsVal, "insert into cfd_comprobantes(XMLTEXT,", $"values('{textoxml}','")} select IDENT_CURRENT('cfd_comprobantes') id_insert;";
        //        DataTable latabla = new DataTable();
        //        bool eject = funciones.datos_datatable_sqls(qry, latabla);
        //        //bool eject = true;
        //        int idComprobante = 0;
        //        if (eject && latabla.Rows.Count > 0 && int.TryParse(latabla.Rows[0]["id_insert"].ToString(), out idComprobante) && idComprobante > 0)
        //            if (eject && idComprobante > 0)
        //            {
        //                FuncionesG.InsertarHijosComprobante40(this, idComprobante, complementos);
        //                return true;
        //            }
        //    }
        //    return false;
        //}
        //public XMLv40.Comprobante ConsultarById(int id)
        //{
        //    string qry = $"select  A.cfd_comprobante_id cfd_comprobante_id,A.Version,A.Serie,A.Folio,A.Fecha,A.FormaPago,A.CondicionesDePago,A.SubTotal,A.Descuento,A.Moneda,A.TipoCambio,A.Total,A.TipoDeComprobante,A.Exportacion,A.MetodoPago,A.LugarExpedicion from cfd_comprobantes A where A.cfd_comprobante_id={id}";
        //    //Type tipoDeEstaClase = this.GetType();
        //    //this=funciones.ConsultaObj<Comprobante>(qry);
        //    //this = funciones.ConsultaObjByid<Comprobante>(qry);
        //    var compr = funciones.ConsultaObjByid<XMLv40.Comprobante>(qry);
        //    /*if (funciones.ConsultaObjByid<Comprobante>(qry, ref compr))
        //    {
        //        /*
        //        ComprobanteInformacionGlobal
        //        ComprobanteCfdiRelacionados[]
        //        ComprobanteEmisor
        //         ComprobanteReceptor
        //        Concepto[]
        //        Impuestos
        //        ComprobanteComplemento
        //        ComprobanteAddenda
        //        */
        //    if (compr.cfd_comprobante_id > 0)
        //    {
        //        var infGlob = new ComprobanteInformacionGlobal();
        //        compr.informacionGlobalField = infGlob.getElemento(id);

        //        var cfdRel = new ComprobanteCfdiRelacionados();
        //        List<ComprobanteCfdiRelacionados> cfdRels = cfdRel.getElementoLista(id);
        //        if (cfdRels.Count > 0)
        //        {
        //            compr.cfdiRelacionadosField = cfdRels.ToArray();
        //        }

        //        var emisor = new ComprobanteEmisor();
        //        compr.emisorField = emisor.GetElemento(id);

        //        var receptor = new ComprobanteReceptor();
        //        compr.receptorField = receptor.GetElemento(id);


        //        var concepto = new Concepto();
        //        List<Concepto> cons = concepto.getElementoLista(id);
        //        if (cons.Count > 0)
        //        {
        //            compr.conceptosField = cons.ToArray();
        //        }

        //        var impuestos = new Impuestos();
        //        compr.impuestosField = impuestos.GetElemento(id);

        //        var complemento = new ComprobanteComplemento();
        //        compr.complementoField = complemento.getElemento(id, compr);

        //        /*var complemento = new ComprobanteComplemento();
        //        List<ComprobanteComplemento> complementos = complemento.getElementoLista(id, compr);
        //        if (complementos.Count > 0)
        //        {
        //            compr.complementoField = complementos.ToArray();
        //        }*/
        //    }
        //    else
        //    {
        //        compr = null;
        //    }
        //    /*}
        //    else
        //    {
        //        compr = null;
        //    }*/
        //    return compr;
        //}
        public string generaXML()
        {
            /*StringWriter stringWriter = new StringWriter();
            // Crear un XmlWriter con las opciones de formato
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = false, // Cambia a true si no deseas la declaración XML
                Encoding = Encoding.UTF8
            };

            // Serializar el objeto Comprobante en XML

            XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
            using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
            {
                //XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                //namespaces.Add("cfdi", "http://www.sat.gob.mx/cfd/3");
                //this.QuitarAtributoXmlns(xmlWriter);
                serializer.Serialize(xmlWriter, this);
            }
            return stringWriter.ToString();*/
            // Crear un XmlWriter con las opciones de formato
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = false, // Cambia a true si no deseas la declaración XML
                Encoding = Encoding.UTF8
            };

            // Serializar el objeto Comprobante en XML
            XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));

            // Crear un StringBuilder para almacenar el XML sin el atributo
            StringBuilder xmlStringBuilder = new StringBuilder();

            using (XmlWriter xmlWriter = XmlWriter.Create(xmlStringBuilder, settings))
            {
                // Serializar el objeto Comprobante
                serializer.Serialize(xmlWriter, this);
            }

            // Reemplazar el atributo xmlns:cartaporte20 con una cadena vacía
            string xmlConAtributo = xmlStringBuilder.ToString();
            //string xmlSinAtributo = xmlConAtributo.Replace("xmlns:cartaporte20=\"http://www.sat.gob.mx/CartaPorte20\"", "");
            xmlConAtributo = this.quitarElemento(@"xmlns:cartaporte20=""([^""]+)""", xmlConAtributo);

            return xmlConAtributo;
        }
        //private void QuitarAtributoXmlns(XmlWriter xmlWriter)
        //{
        //    // Antes de serializar, elimina el atributo xmlns:cartaporte20 del elemento raíz
        //    if (xmlWriter.WriteState == WriteState.Element)
        //    {
        //        xmlWriter.WriteStartDocument();
        //        xmlWriter.WriteStartElement("root"); // Crea un elemento raíz temporal
        //        xmlWriter.WriteAttributes(xmlWriter, false); // Copia todos los atributos excepto xmlns:cartaporte20
        //    }
        //}
        protected string quitarElemento(string attr, string xml)
        {
            MatchCollection matches = Regex.Matches(xml, attr);
            if (matches.Count > 1)
            {
                string primerAtributo = matches[0].Value;
                for (int i = 1; i < matches.Count; i++)
                {
                    xml = xml.Replace(matches[i].Value, "");
                }
            }
            return xml;
        }
    }
}
