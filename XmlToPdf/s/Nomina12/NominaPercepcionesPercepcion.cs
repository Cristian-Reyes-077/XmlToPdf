using System;
using System.Data;

namespace XmlToPdf.Controlelrs.Nomina12
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaPercepcionesPercepcion
    {

        private NominaPercepcionesPercepcionAccionesOTitulos accionesOTitulosField;

        private NominaPercepcionesPercepcionHorasExtra[] horasExtraField;

        private string tipoPercepcionField;

        private string claveField;

        private string conceptoField;

        private decimal importeGravadoField;

        private decimal importeExentoField;

        /// <remarks/>
        public NominaPercepcionesPercepcionAccionesOTitulos AccionesOTitulos
        {
            get
            {
                return accionesOTitulosField;
            }
            set
            {
                accionesOTitulosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("HorasExtra")]
        public NominaPercepcionesPercepcionHorasExtra[] HorasExtra
        {
            get
            {
                return horasExtraField;
            }
            set
            {
                horasExtraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string TipoPercepcion
        {
            get
            {
                return tipoPercepcionField;
            }
            set
            {
                tipoPercepcionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Clave
        {
            get
            {
                return claveField;
            }
            set
            {
                claveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Concepto
        {
            get
            {
                return conceptoField;
            }
            set
            {
                conceptoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal ImporteGravado
        {
            get
            {
                return importeGravadoField;
            }
            set
            {
                importeGravadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal ImporteExento
        {
            get
            {
                return importeExentoField;
            }
            set
            {
                importeExentoField = value;
            }
        }
       
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaPercepcionesPercepcionAccionesOTitulos
    {

        private decimal valorMercadoField;

        private decimal precioAlOtorgarseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal ValorMercado
        {
            get
            {
                return valorMercadoField;
            }
            set
            {
                valorMercadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal PrecioAlOtorgarse
        {
            get
            {
                return precioAlOtorgarseField;
            }
            set
            {
                precioAlOtorgarseField = value;
            }
        }
        
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaPercepcionesPercepcionHorasExtra
    {

        private int diasField;

        private string tipoHorasField;

        private int horasExtraField;

        private decimal importePagadoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public int Dias
        {
            get
            {
                return diasField;
            }
            set
            {
                diasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string TipoHoras
        {
            get
            {
                return tipoHorasField;
            }
            set
            {
                tipoHorasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public int HorasExtra
        {
            get
            {
                return horasExtraField;
            }
            set
            {
                horasExtraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal ImportePagado
        {
            get
            {
                return importePagadoField;
            }
            set
            {
                importePagadoField = value;
            }
        }
        
    }
}