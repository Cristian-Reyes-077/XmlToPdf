namespace XmlToPdf.Xmlv40
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteInformacionGlobal
    {

        private string periodicidadField;

        private string mesesField;

        private string añoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Periodicidad
        {
            get
            {
                return this.periodicidadField;
            }
            set
            {
                this.periodicidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Meses
        {
            get
            {
                return this.mesesField;
            }
            set
            {
                this.mesesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Año
        {
            get
            {
                return this.añoField;
            }
            set
            {
                this.añoField = value;
            }
        }
        
    }
}
