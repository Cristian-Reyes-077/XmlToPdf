using XmlToPdf.Controlelrs.Pagos10;
using System.Data;

namespace XmlToPdf.Controlelrs.Pagos20
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoImpuestosP
    {

        private PagosPagoImpuestosPRetencionP[] retencionesPField;

        private PagosPagoImpuestosPTrasladoP[] trasladosPField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RetencionP", IsNullable = false)]
        public PagosPagoImpuestosPRetencionP[] RetencionesP
        {
            get
            {
                return this.retencionesPField;
            }
            set
            {
                this.retencionesPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TrasladoP", IsNullable = false)]
        public PagosPagoImpuestosPTrasladoP[] TrasladosP
        {
            get
            {
                return this.trasladosPField;
            }
            set
            {
                this.trasladosPField = value;
            }
        }
       
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoImpuestosPRetencionP
    {

        private string impuestoPField;

        private decimal importePField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ImpuestoP
        {
            get
            {
                return this.impuestoPField;
            }
            set
            {
                this.impuestoPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ImporteP
        {
            get
            {
                return this.importePField;
            }
            set
            {
                this.importePField = value;
            }
        }
        
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoImpuestosPTrasladoP
    {

        private decimal basePField;

        private string impuestoPField;

        private string tipoFactorPField;

        private decimal tasaOCuotaPField;

        private bool tasaOCuotaPFieldSpecified;

        private decimal importePField;

        private bool importePFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal BaseP
        {
            get
            {
                return this.basePField;
            }
            set
            {
                this.basePField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ImpuestoP
        {
            get
            {
                return this.impuestoPField;
            }
            set
            {
                this.impuestoPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoFactorP
        {
            get
            {
                return this.tipoFactorPField;
            }
            set
            {
                this.tipoFactorPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TasaOCuotaP
        {
            get
            {
                return this.tasaOCuotaPField;
            }
            set
            {
                this.tasaOCuotaPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TasaOCuotaPSpecified
        {
            get
            {
                return this.tasaOCuotaPFieldSpecified;
            }
            set
            {
                this.tasaOCuotaPFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ImporteP
        {
            get
            {
                return this.importePField;
            }
            set
            {
                this.importePField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImportePSpecified
        {
            get
            {
                return this.importePFieldSpecified;
            }
            set
            {
                this.importePFieldSpecified = value;
            }
        }
       
    }
}