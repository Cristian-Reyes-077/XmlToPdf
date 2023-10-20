namespace XmlToPdf.Controlelrs.Pagos20
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoDoctoRelacionadoImpuestosDR
    {

        private PagosPagoDoctoRelacionadoImpuestosDRRetencionDR[] retencionesDRField;

        private PagosPagoDoctoRelacionadoImpuestosDRTrasladoDR[] trasladosDRField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RetencionDR", IsNullable = false)]
        public PagosPagoDoctoRelacionadoImpuestosDRRetencionDR[] RetencionesDR
        {
            get
            {
                return this.retencionesDRField;
            }
            set
            {
                this.retencionesDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TrasladoDR", IsNullable = false)]
        public PagosPagoDoctoRelacionadoImpuestosDRTrasladoDR[] TrasladosDR
        {
            get
            {
                return this.trasladosDRField;
            }
            set
            {
                this.trasladosDRField = value;
            }
        }
       
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoDoctoRelacionadoImpuestosDRRetencionDR
    {

        private decimal baseDRField;

        private string impuestoDRField;

        private string tipoFactorDRField;

        private decimal tasaOCuotaDRField;

        private decimal importeDRField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal BaseDR
        {
            get
            {
                return this.baseDRField;
            }
            set
            {
                this.baseDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ImpuestoDR
        {
            get
            {
                return this.impuestoDRField;
            }
            set
            {
                this.impuestoDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoFactorDR
        {
            get
            {
                return this.tipoFactorDRField;
            }
            set
            {
                this.tipoFactorDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TasaOCuotaDR
        {
            get
            {
                return this.tasaOCuotaDRField;
            }
            set
            {
                this.tasaOCuotaDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ImporteDR
        {
            get
            {
                return this.importeDRField;
            }
            set
            {
                this.importeDRField = value;
            }
        }
       
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoDoctoRelacionadoImpuestosDRTrasladoDR
    {

        private decimal baseDRField;

        private string impuestoDRField;

        private string tipoFactorDRField;

        private decimal tasaOCuotaDRField;

        private bool tasaOCuotaDRFieldSpecified;

        private decimal importeDRField;

        private bool importeDRFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal BaseDR
        {
            get
            {
                return this.baseDRField;
            }
            set
            {
                this.baseDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ImpuestoDR
        {
            get
            {
                return this.impuestoDRField;
            }
            set
            {
                this.impuestoDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoFactorDR
        {
            get
            {
                return this.tipoFactorDRField;
            }
            set
            {
                this.tipoFactorDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TasaOCuotaDR
        {
            get
            {
                return this.tasaOCuotaDRField;
            }
            set
            {
                this.tasaOCuotaDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TasaOCuotaDRSpecified
        {
            get
            {
                return this.tasaOCuotaDRFieldSpecified;
            }
            set
            {
                this.tasaOCuotaDRFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ImporteDR
        {
            get
            {
                return this.importeDRField;
            }
            set
            {
                this.importeDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImporteDRSpecified
        {
            get
            {
                return this.importeDRFieldSpecified;
            }
            set
            {
                this.importeDRFieldSpecified = value;
            }
        }
        
    }
}