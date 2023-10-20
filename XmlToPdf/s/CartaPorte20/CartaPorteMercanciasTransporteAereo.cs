using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlToPdf.Controlelrs.CartaPorte20
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasTransporteAereo
    {

        private string permSCTField;

        private string numPermisoSCTField;

        private string matriculaAeronaveField;

        private string nombreAsegField;

        private string numPolizaSeguroField;

        private string numeroGuiaField;

        private string lugarContratoField;

        private string codigoTransportistaField;

        private string rFCEmbarcadorField;

        private string numRegIdTribEmbarcField;

        private string residenciaFiscalEmbarcField;

        private bool residenciaFiscalEmbarcFieldSpecified;

        private string nombreEmbarcadorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PermSCT
        {
            get
            {
                return this.permSCTField;
            }
            set
            {
                this.permSCTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumPermisoSCT
        {
            get
            {
                return this.numPermisoSCTField;
            }
            set
            {
                this.numPermisoSCTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MatriculaAeronave
        {
            get
            {
                return this.matriculaAeronaveField;
            }
            set
            {
                this.matriculaAeronaveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreAseg
        {
            get
            {
                return this.nombreAsegField;
            }
            set
            {
                this.nombreAsegField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumPolizaSeguro
        {
            get
            {
                return this.numPolizaSeguroField;
            }
            set
            {
                this.numPolizaSeguroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumeroGuia
        {
            get
            {
                return this.numeroGuiaField;
            }
            set
            {
                this.numeroGuiaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LugarContrato
        {
            get
            {
                return this.lugarContratoField;
            }
            set
            {
                this.lugarContratoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodigoTransportista
        {
            get
            {
                return this.codigoTransportistaField;
            }
            set
            {
                this.codigoTransportistaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RFCEmbarcador
        {
            get
            {
                return this.rFCEmbarcadorField;
            }
            set
            {
                this.rFCEmbarcadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTribEmbarc
        {
            get
            {
                return this.numRegIdTribEmbarcField;
            }
            set
            {
                this.numRegIdTribEmbarcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResidenciaFiscalEmbarc
        {
            get
            {
                return this.residenciaFiscalEmbarcField;
            }
            set
            {
                this.residenciaFiscalEmbarcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidenciaFiscalEmbarcSpecified
        {
            get
            {
                return this.residenciaFiscalEmbarcFieldSpecified;
            }
            set
            {
                this.residenciaFiscalEmbarcFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreEmbarcador
        {
            get
            {
                return this.nombreEmbarcadorField;
            }
            set
            {
                this.nombreEmbarcadorField = value;
            }
        }
       
    }
}
