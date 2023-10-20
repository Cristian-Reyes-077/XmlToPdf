using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlToPdf.Controlelrs.CartaPorte20
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteUbicacion
    {
        [XmlIgnore] public int ubicacion_id { get; set; }
        private CartaPorteUbicacionDomicilio domicilioField;

        private string tipoUbicacionField;//Origen , Destino

        private string iDUbicacionField;

        private string rFCRemitenteDestinatarioField;

        private string nombreRemitenteDestinatarioField;

        private string numRegIdTribField;

        private string residenciaFiscalField;

        private bool residenciaFiscalFieldSpecified;

        private string numEstacionField;

        private bool numEstacionFieldSpecified;

        private string nombreEstacionField;

        private string navegacionTraficoField;//Altura,Cabotaje

        private bool navegacionTraficoFieldSpecified;

        private System.DateTime fechaHoraSalidaLlegadaField;

        private string tipoEstacionField;

        private bool tipoEstacionFieldSpecified;

        private decimal distanciaRecorridaField;

        private bool distanciaRecorridaFieldSpecified;

        /// <remarks/>
        public CartaPorteUbicacionDomicilio Domicilio
        {
            get
            {
                return this.domicilioField;
            }
            set
            {
                this.domicilioField = value;
            }
        }

        /// <remarks/>
        /// //Origen , Destino
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoUbicacion
        {
            get
            {
                return this.tipoUbicacionField;
            }
            set
            {
                this.tipoUbicacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IDUbicacion
        {
            get
            {
                return this.iDUbicacionField;
            }
            set
            {
                this.iDUbicacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RFCRemitenteDestinatario
        {
            get
            {
                return this.rFCRemitenteDestinatarioField;
            }
            set
            {
                this.rFCRemitenteDestinatarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreRemitenteDestinatario
        {
            get
            {
                return this.nombreRemitenteDestinatarioField;
            }
            set
            {
                this.nombreRemitenteDestinatarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTrib
        {
            get
            {
                return this.numRegIdTribField;
            }
            set
            {
                this.numRegIdTribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResidenciaFiscal
        {
            get
            {
                return this.residenciaFiscalField;
            }
            set
            {
                this.residenciaFiscalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidenciaFiscalSpecified
        {
            get
            {
                return this.residenciaFiscalFieldSpecified;
            }
            set
            {
                this.residenciaFiscalFieldSpecified = value;
            }
        }

        /// <remarks/>
        /// c_Estaciones
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumEstacion
        {
            get
            {
                return this.numEstacionField;
            }
            set
            {
                this.numEstacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumEstacionSpecified
        {
            get
            {
                return this.numEstacionFieldSpecified;
            }
            set
            {
                this.numEstacionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreEstacion
        {
            get
            {
                return this.nombreEstacionField;
            }
            set
            {
                this.nombreEstacionField = value;
            }
        }

        /// <remarks/>
        /// //Altura,Cabotaje
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NavegacionTrafico
        {
            get
            {
                return this.navegacionTraficoField;
            }
            set
            {
                this.navegacionTraficoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NavegacionTraficoSpecified
        {
            get
            {
                return this.navegacionTraficoFieldSpecified;
            }
            set
            {
                this.navegacionTraficoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime FechaHoraSalidaLlegada
        {
            get
            {
                return this.fechaHoraSalidaLlegadaField;
            }
            set
            {
                this.fechaHoraSalidaLlegadaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoEstacion
        {
            get
            {
                return this.tipoEstacionField;
            }
            set
            {
                this.tipoEstacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoEstacionSpecified
        {
            get
            {
                return this.tipoEstacionFieldSpecified;
            }
            set
            {
                this.tipoEstacionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal DistanciaRecorrida
        {
            get
            {
                return this.distanciaRecorridaField;
            }
            set
            {
                this.distanciaRecorridaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DistanciaRecorridaSpecified
        {
            get
            {
                return this.distanciaRecorridaFieldSpecified;
            }
            set
            {
                this.distanciaRecorridaFieldSpecified = value;
            }
        }
       
    }
}
