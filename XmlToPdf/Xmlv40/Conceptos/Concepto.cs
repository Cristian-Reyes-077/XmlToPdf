using System.Xml.Serialization;

namespace XmlToPdf.Xmlv40.Conceptos
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class Concepto
    {
        [XmlIgnore] public int cfd_concepto_id { get; set; }
        private ConceptoImpuestos impuestosField;

        private ConceptoACuentaTerceros aCuentaTercerosField;

        private ConceptoInformacionAduanera[] informacionAduaneraField;

        private ConceptoCuentaPredial[] cuentaPredialField;

        private ConceptoComplementoConcepto complementoConceptoField;

        private ConceptoParte[] parteField;

        private string claveProdServField;

        private string noIdentificacionField;

        private decimal cantidadField;

        private string claveUnidadField;

        private string unidadField;

        private string descripcionField;

        private decimal valorUnitarioField;

        private decimal importeField;

        private decimal descuentoField;

        private bool descuentoFieldSpecified;

        private string objetoImpField;

        /// <remarks/>
        public ConceptoImpuestos Impuestos
        {
            get
            {
                return this.impuestosField;
            }
            set
            {
                this.impuestosField = value;
            }
        }

        /// <remarks/>
        public ConceptoACuentaTerceros ACuentaTerceros
        {
            get
            {
                return this.aCuentaTercerosField;
            }
            set
            {
                this.aCuentaTercerosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InformacionAduanera")]
        public ConceptoInformacionAduanera[] InformacionAduanera
        {
            get
            {
                return this.informacionAduaneraField;
            }
            set
            {
                this.informacionAduaneraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CuentaPredial")]
        public ConceptoCuentaPredial[] CuentaPredial
        {
            get
            {
                return this.cuentaPredialField;
            }
            set
            {
                this.cuentaPredialField = value;
            }
        }

        /// <remarks/>
        public ConceptoComplementoConcepto ComplementoConcepto
        {
            get
            {
                return this.complementoConceptoField;
            }
            set
            {
                this.complementoConceptoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parte")]
        public ConceptoParte[] Parte
        {
            get
            {
                return this.parteField;
            }
            set
            {
                this.parteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveProdServ
        {
            get
            {
                return this.claveProdServField;
            }
            set
            {
                this.claveProdServField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NoIdentificacion
        {
            get
            {
                return this.noIdentificacionField;
            }
            set
            {
                this.noIdentificacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Cantidad
        {
            get
            {
                return this.cantidadField;
            }
            set
            {
                this.cantidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveUnidad
        {
            get
            {
                return this.claveUnidadField;
            }
            set
            {
                this.claveUnidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Unidad
        {
            get
            {
                return this.unidadField;
            }
            set
            {
                this.unidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Descripcion
        {
            get
            {
                return this.descripcionField;
            }
            set
            {
                this.descripcionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ValorUnitario
        {
            get
            {
                return this.valorUnitarioField;
            }
            set
            {
                this.valorUnitarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe
        {
            get
            {
                return this.importeField;
            }
            set
            {
                this.importeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Descuento
        {
            get
            {
                return this.descuentoField;
            }
            set
            {
                this.descuentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DescuentoSpecified
        {
            get
            {
                return this.descuentoFieldSpecified;
            }
            set
            {
                this.descuentoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ObjetoImp
        {
            get
            {
                return this.objetoImpField;
            }
            set
            {
                this.objetoImpField = value;
            }
        }
        
    }
}