using System;

namespace XmlToPdf.Controlelrs.Nomina12
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaPercepcionesSeparacionIndemnizacion
    {

        private decimal totalPagadoField;

        private int numAñosServicioField;

        private decimal ultimoSueldoMensOrdField;

        private decimal ingresoAcumulableField;

        private decimal ingresoNoAcumulableField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal TotalPagado
        {
            get
            {
                return totalPagadoField;
            }
            set
            {
                totalPagadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public int NumAñosServicio
        {
            get
            {
                return numAñosServicioField;
            }
            set
            {
                numAñosServicioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal UltimoSueldoMensOrd
        {
            get
            {
                return ultimoSueldoMensOrdField;
            }
            set
            {
                ultimoSueldoMensOrdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal IngresoAcumulable
        {
            get
            {
                return ingresoAcumulableField;
            }
            set
            {
                ingresoAcumulableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal IngresoNoAcumulable
        {
            get
            {
                return ingresoNoAcumulableField;
            }
            set
            {
                ingresoNoAcumulableField = value;
            }
        }
       
    }
}