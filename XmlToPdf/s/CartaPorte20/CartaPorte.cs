using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Drawing;
using System.Xml.Schema;
using System.IO;

namespace XmlToPdf.Controlelrs.CartaPorte20
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/CartaPorte20", IsNullable = false)]
    //[XmlRoot(Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorte
    {
        [XmlIgnore] public int cartaporte_id { get; set; }
        private CartaPorteUbicacion[] ubicacionesField;

        private CartaPorteMercancias mercanciasField;

        private CartaPorteTiposFigura[] figuraTransporteField;

        private string versionField;

        private string transpInternacField;//Sí,No

        private string entradaSalidaMercField;//Entrada,Salida

        private bool entradaSalidaMercFieldSpecified;

        private string paisOrigenDestinoField;//c_Pais

        private bool paisOrigenDestinoFieldSpecified;

        private string viaEntradaSalidaField;//c_CveTransporte

        private bool viaEntradaSalidaFieldSpecified;

        private decimal totalDistRecField;

        private bool totalDistRecFieldSpecified;
        public CartaPorte()
        {
            this.versionField = "2.0";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Ubicacion", IsNullable = false)]
        public CartaPorteUbicacion[] Ubicaciones
        {
            get
            {
                return this.ubicacionesField;
            }
            set
            {
                this.ubicacionesField = value;
            }
        }

        /// <remarks/>
        public CartaPorteMercancias Mercancias
        {
            get
            {
                return this.mercanciasField;
            }
            set
            {
                this.mercanciasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TiposFigura", IsNullable = false)]
        public CartaPorteTiposFigura[] FiguraTransporte
        {
            get
            {
                return this.figuraTransporteField;
            }
            set
            {
                this.figuraTransporteField = value;
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
        public string TranspInternac//Sí,No
        {
            get
            {
                return this.transpInternacField;
            }
            set
            {
                this.transpInternacField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntradaSalidaMerc//Entrada,Salida
        {
            get
            {
                return this.entradaSalidaMercField;
            }
            set
            {
                this.entradaSalidaMercField = value;
                this.EntradaSalidaMercSpecified = (this.entradaSalidaMercField != null && this.entradaSalidaMercField.Trim() != "") ?  true : false;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EntradaSalidaMercSpecified
        {
            get
            {
                return this.entradaSalidaMercFieldSpecified;
            }
            set
            {
                this.entradaSalidaMercFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaisOrigenDestino//c_Pais
        {
            get
            {
                return this.paisOrigenDestinoField;
            }
            set
            {
                this.paisOrigenDestinoField = value;
                this.PaisOrigenDestinoSpecified = (this.paisOrigenDestinoField != null && this.paisOrigenDestinoField.Trim() != "") ? true : false;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaisOrigenDestinoSpecified
        {
            get
            {
                return this.paisOrigenDestinoFieldSpecified;
            }
            set
            {
                this.paisOrigenDestinoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ViaEntradaSalida//c_CveTransporte
        {
            get
            {
                return this.viaEntradaSalidaField;
            }
            set
            {
                this.viaEntradaSalidaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ViaEntradaSalidaSpecified
        {
            get
            {
                return this.viaEntradaSalidaFieldSpecified;
            }
            set
            {
                this.viaEntradaSalidaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalDistRec
        {
            get
            {
                return this.totalDistRecField;
            }
            set
            {
                this.totalDistRecField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalDistRecSpecified
        {
            get
            {
                return this.totalDistRecFieldSpecified;
            }
            set
            {
                this.totalDistRecFieldSpecified = value;
            }
        }
       
       
       
    }
}
