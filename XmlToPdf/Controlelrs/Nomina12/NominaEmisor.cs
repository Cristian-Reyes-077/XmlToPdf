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
    public partial class NominaEmisor
    {

        private NominaEmisorEntidadSNCF entidadSNCFField;

        private string curpField;

        private string registroPatronalField;

        private string rfcPatronOrigenField;

        /// <remarks/>
        public NominaEmisorEntidadSNCF EntidadSNCF
        {
            get
            {
                return entidadSNCFField;
            }
            set
            {
                entidadSNCFField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Curp
        {
            get
            {
                return curpField;
            }
            set
            {
                curpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string RegistroPatronal
        {
            get
            {
                return registroPatronalField;
            }
            set
            {
                registroPatronalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string RfcPatronOrigen
        {
            get
            {
                return rfcPatronOrigenField;
            }
            set
            {
                rfcPatronOrigenField = value;
            }
        }
        
    }
}