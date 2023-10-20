using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlToPdf.Controlelrs.Pagos20
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPago
    {

        private PagosPagoDoctoRelacionado[] doctoRelacionadoField;

        private PagosPagoImpuestosP impuestosPField;

        private System.DateTime fechaPagoField;

        private string formaDePagoPField;

        private string monedaPField;

        private decimal tipoCambioPField;

        private bool tipoCambioPFieldSpecified;

        private decimal montoField;

        private string numOperacionField;

        private string rfcEmisorCtaOrdField;

        private string nomBancoOrdExtField;

        private string ctaOrdenanteField;

        private string rfcEmisorCtaBenField;

        private string ctaBeneficiarioField;

        private string tipoCadPagoField;

        private bool tipoCadPagoFieldSpecified;

        private byte[] certPagoField;

        private string cadPagoField;

        private byte[] selloPagoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DoctoRelacionado")]
        public PagosPagoDoctoRelacionado[] DoctoRelacionado
        {
            get
            {
                return this.doctoRelacionadoField;
            }
            set
            {
                this.doctoRelacionadoField = value;
            }
        }

        /// <remarks/>
        public PagosPagoImpuestosP ImpuestosP
        {
            get
            {
                return this.impuestosPField;
            }
            set
            {
                this.impuestosPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime FechaPago
        {
            get
            {
                return this.fechaPagoField;
            }
            set
            {
                this.fechaPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FormaDePagoP
        {
            get
            {
                return this.formaDePagoPField;
            }
            set
            {
                this.formaDePagoPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MonedaP
        {
            get
            {
                return this.monedaPField;
            }
            set
            {
                this.monedaPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TipoCambioP
        {
            get
            {
                return this.tipoCambioPField;
            }
            set
            {
                this.tipoCambioPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoCambioPSpecified
        {
            get
            {
                return this.tipoCambioPFieldSpecified;
            }
            set
            {
                this.tipoCambioPFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Monto
        {
            get
            {
                return this.montoField;
            }
            set
            {
                this.montoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumOperacion
        {
            get
            {
                return this.numOperacionField;
            }
            set
            {
                this.numOperacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RfcEmisorCtaOrd
        {
            get
            {
                return this.rfcEmisorCtaOrdField;
            }
            set
            {
                this.rfcEmisorCtaOrdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NomBancoOrdExt
        {
            get
            {
                return this.nomBancoOrdExtField;
            }
            set
            {
                this.nomBancoOrdExtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CtaOrdenante
        {
            get
            {
                return this.ctaOrdenanteField;
            }
            set
            {
                this.ctaOrdenanteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RfcEmisorCtaBen
        {
            get
            {
                return this.rfcEmisorCtaBenField;
            }
            set
            {
                this.rfcEmisorCtaBenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CtaBeneficiario
        {
            get
            {
                return this.ctaBeneficiarioField;
            }
            set
            {
                this.ctaBeneficiarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoCadPago
        {
            get
            {
                return this.tipoCadPagoField;
            }
            set
            {
                this.tipoCadPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoCadPagoSpecified
        {
            get
            {
                return this.tipoCadPagoFieldSpecified;
            }
            set
            {
                this.tipoCadPagoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
        public byte[] CertPago
        {
            get
            {
                return this.certPagoField;
            }
            set
            {
                this.certPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CadPago
        {
            get
            {
                return this.cadPagoField;
            }
            set
            {
                this.cadPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
        public byte[] SelloPago
        {
            get
            {
                return this.selloPagoField;
            }
            set
            {
                this.selloPagoField = value;
            }
        }
       
    }
}
