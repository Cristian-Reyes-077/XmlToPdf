using System;

namespace XmlToPdf.Controlelrs.Nomina12
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaEmisorEntidadSNCF
    {

        private string origenRecursoField;

        private decimal montoRecursoPropioField;

        private bool montoRecursoPropioFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string OrigenRecurso
        {
            get
            {
                return origenRecursoField;
            }
            set
            {
                origenRecursoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal MontoRecursoPropio
        {
            get
            {
                return montoRecursoPropioField;
            }
            set
            {
                montoRecursoPropioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool MontoRecursoPropioSpecified
        {
            get
            {
                return montoRecursoPropioFieldSpecified;
            }
            set
            {
                montoRecursoPropioFieldSpecified = value;
            }
        }
        
    }
}