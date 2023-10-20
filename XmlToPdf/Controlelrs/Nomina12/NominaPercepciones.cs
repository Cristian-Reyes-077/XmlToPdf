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
    public partial class NominaPercepciones
    {

        private NominaPercepcionesPercepcion[] percepcionField;

        private NominaPercepcionesJubilacionPensionRetiro jubilacionPensionRetiroField;

        private NominaPercepcionesSeparacionIndemnizacion separacionIndemnizacionField;

        private decimal totalSueldosField;

        private bool totalSueldosFieldSpecified;

        private decimal totalSeparacionIndemnizacionField;

        private bool totalSeparacionIndemnizacionFieldSpecified;

        private decimal totalJubilacionPensionRetiroField;

        private bool totalJubilacionPensionRetiroFieldSpecified;

        private decimal totalGravadoField;

        private decimal totalExentoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Percepcion")]
        public NominaPercepcionesPercepcion[] Percepcion
        {
            get
            {
                return percepcionField;
            }
            set
            {
                percepcionField = value;
            }
        }

        /// <remarks/>
        public NominaPercepcionesJubilacionPensionRetiro JubilacionPensionRetiro
        {
            get
            {
                return jubilacionPensionRetiroField;
            }
            set
            {
                jubilacionPensionRetiroField = value;
            }
        }

        /// <remarks/>
        public NominaPercepcionesSeparacionIndemnizacion SeparacionIndemnizacion
        {
            get
            {
                return separacionIndemnizacionField;
            }
            set
            {
                separacionIndemnizacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal TotalSueldos
        {
            get
            {
                return totalSueldosField;
            }
            set
            {
                totalSueldosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool TotalSueldosSpecified
        {
            get
            {
                return totalSueldosFieldSpecified;
            }
            set
            {
                totalSueldosFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal TotalSeparacionIndemnizacion
        {
            get
            {
                return totalSeparacionIndemnizacionField;
            }
            set
            {
                totalSeparacionIndemnizacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool TotalSeparacionIndemnizacionSpecified
        {
            get
            {
                return totalSeparacionIndemnizacionFieldSpecified;
            }
            set
            {
                totalSeparacionIndemnizacionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal TotalJubilacionPensionRetiro
        {
            get
            {
                return totalJubilacionPensionRetiroField;
            }
            set
            {
                totalJubilacionPensionRetiroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool TotalJubilacionPensionRetiroSpecified
        {
            get
            {
                return totalJubilacionPensionRetiroFieldSpecified;
            }
            set
            {
                totalJubilacionPensionRetiroFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal TotalGravado
        {
            get
            {
                return totalGravadoField;
            }
            set
            {
                totalGravadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal TotalExento
        {
            get
            {
                return totalExentoField;
            }
            set
            {
                totalExentoField = value;
            }
        }
        
    }
}