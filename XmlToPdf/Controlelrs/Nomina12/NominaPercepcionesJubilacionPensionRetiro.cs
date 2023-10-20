using System;

namespace XmlToPdf.Controlelrs.Nomina12
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaPercepcionesJubilacionPensionRetiro
    {

        private decimal totalUnaExhibicionField;

        private bool totalUnaExhibicionFieldSpecified;

        private decimal totalParcialidadField;

        private bool totalParcialidadFieldSpecified;

        private decimal montoDiarioField;

        private bool montoDiarioFieldSpecified;

        private decimal ingresoAcumulableField;

        private decimal ingresoNoAcumulableField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal TotalUnaExhibicion
        {
            get
            {
                return totalUnaExhibicionField;
            }
            set
            {
                totalUnaExhibicionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool TotalUnaExhibicionSpecified
        {
            get
            {
                return totalUnaExhibicionFieldSpecified;
            }
            set
            {
                totalUnaExhibicionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal TotalParcialidad
        {
            get
            {
                return totalParcialidadField;
            }
            set
            {
                totalParcialidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool TotalParcialidadSpecified
        {
            get
            {
                return totalParcialidadFieldSpecified;
            }
            set
            {
                totalParcialidadFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal MontoDiario
        {
            get
            {
                return montoDiarioField;
            }
            set
            {
                montoDiarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool MontoDiarioSpecified
        {
            get
            {
                return montoDiarioFieldSpecified;
            }
            set
            {
                montoDiarioFieldSpecified = value;
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