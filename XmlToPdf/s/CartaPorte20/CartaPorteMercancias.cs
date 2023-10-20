using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlToPdf.Controlelrs.CartaPorte20
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercancias
    {
        [XmlIgnore] public int mercancia_id { get; set; }
        private CartaPorteMercanciasMercancia[] mercanciaField;

        private CartaPorteMercanciasAutotransporte autotransporteField;

        private CartaPorteMercanciasTransporteMaritimo transporteMaritimoField;

        private CartaPorteMercanciasTransporteAereo transporteAereoField;

        private CartaPorteMercanciasTransporteFerroviario transporteFerroviarioField;

        private decimal pesoBrutoTotalField;

        private string unidadPesoField;

        private decimal pesoNetoTotalField;

        private bool pesoNetoTotalFieldSpecified;

        private int numTotalMercanciasField;

        private decimal cargoPorTasacionField;

        private bool cargoPorTasacionFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Mercancia")]
        public CartaPorteMercanciasMercancia[] Mercancia
        {
            get
            {
                return this.mercanciaField;
            }
            set
            {
                this.mercanciaField = value;
            }
        }

        /// <remarks/>
        public CartaPorteMercanciasAutotransporte Autotransporte
        {
            get
            {
                return this.autotransporteField;
            }
            set
            {
                this.autotransporteField = value;
            }
        }

        /// <remarks/>
        public CartaPorteMercanciasTransporteMaritimo TransporteMaritimo
        {
            get
            {
                return this.transporteMaritimoField;
            }
            set
            {
                this.transporteMaritimoField = value;
            }
        }

        /// <remarks/>
        public CartaPorteMercanciasTransporteAereo TransporteAereo
        {
            get
            {
                return this.transporteAereoField;
            }
            set
            {
                this.transporteAereoField = value;
            }
        }

        /// <remarks/>
        public CartaPorteMercanciasTransporteFerroviario TransporteFerroviario
        {
            get
            {
                return this.transporteFerroviarioField;
            }
            set
            {
                this.transporteFerroviarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoBrutoTotal
        {
            get
            {
                return this.pesoBrutoTotalField;
            }
            set
            {
                this.pesoBrutoTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnidadPeso
        {
            get
            {
                return this.unidadPesoField;
            }
            set
            {
                this.unidadPesoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoNetoTotal
        {
            get
            {
                return this.pesoNetoTotalField;
            }
            set
            {
                this.pesoNetoTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PesoNetoTotalSpecified
        {
            get
            {
                return this.pesoNetoTotalFieldSpecified;
            }
            set
            {
                this.pesoNetoTotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int NumTotalMercancias
        {
            get
            {
                return this.numTotalMercanciasField;
            }
            set
            {
                this.numTotalMercanciasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal CargoPorTasacion
        {
            get
            {
                return this.cargoPorTasacionField;
            }
            set
            {
                this.cargoPorTasacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CargoPorTasacionSpecified
        {
            get
            {
                return this.cargoPorTasacionFieldSpecified;
            }
            set
            {
                this.cargoPorTasacionFieldSpecified = value;
            }
        }
       
    }
}
