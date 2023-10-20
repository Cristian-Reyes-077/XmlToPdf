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
    public partial class NominaDeducciones
    {

        private NominaDeduccionesDeduccion[] deduccionField;

        private decimal totalOtrasDeduccionesField;

        private bool totalOtrasDeduccionesFieldSpecified;

        private decimal totalImpuestosRetenidosField;

        private bool totalImpuestosRetenidosFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Deduccion")]
        public NominaDeduccionesDeduccion[] Deduccion
        {
            get
            {
                return deduccionField;
            }
            set
            {
                deduccionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal TotalOtrasDeducciones
        {
            get
            {
                return totalOtrasDeduccionesField;
            }
            set
            {
                totalOtrasDeduccionesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool TotalOtrasDeduccionesSpecified
        {
            get
            {
                return totalOtrasDeduccionesFieldSpecified;
            }
            set
            {
                totalOtrasDeduccionesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal TotalImpuestosRetenidos
        {
            get
            {
                return totalImpuestosRetenidosField;
            }
            set
            {
                totalImpuestosRetenidosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool TotalImpuestosRetenidosSpecified
        {
            get
            {
                return totalImpuestosRetenidosFieldSpecified;
            }
            set
            {
                totalImpuestosRetenidosFieldSpecified = value;
            }
        }
       
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaDeduccionesDeduccion
    {

        private string tipoDeduccionField;

        private string claveField;

        private string conceptoField;

        private decimal importeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string TipoDeduccion
        {
            get
            {
                return tipoDeduccionField;
            }
            set
            {
                tipoDeduccionField = value;
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
        public decimal Importe
        {
            get
            {
                return importeField;
            }
            set
            {
                importeField = value;
            }
        }
       
    }
}