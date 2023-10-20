using System;

namespace XmlToPdf.Controlelrs.Nomina12
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaIncapacidad
    {

        private int diasIncapacidadField;

        private string tipoIncapacidadField;

        private decimal importeMonetarioField;

        private bool importeMonetarioFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public int DiasIncapacidad
        {
            get
            {
                return diasIncapacidadField;
            }
            set
            {
                diasIncapacidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string TipoIncapacidad
        {
            get
            {
                return tipoIncapacidadField;
            }
            set
            {
                tipoIncapacidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal ImporteMonetario
        {
            get
            {
                return importeMonetarioField;
            }
            set
            {
                importeMonetarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool ImporteMonetarioSpecified
        {
            get
            {
                return importeMonetarioFieldSpecified;
            }
            set
            {
                importeMonetarioFieldSpecified = value;
            }
        }
        
    }
}