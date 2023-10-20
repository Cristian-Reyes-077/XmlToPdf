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
    public partial class CartaPorteMercanciasTransporteFerroviario
    {
        [XmlIgnore] public int ferreoviario_id { get; set; }
        private CartaPorteMercanciasTransporteFerroviarioDerechosDePaso[] derechosDePasoField;

        private CartaPorteMercanciasTransporteFerroviarioCarro[] carroField;

        private string tipoDeServicioField;//c_TipoDeServicio

        private string tipoDeTraficoField;//c_TipoDeTrafico

        private string nombreAsegField;

        private string numPolizaSeguroField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DerechosDePaso")]
        public CartaPorteMercanciasTransporteFerroviarioDerechosDePaso[] DerechosDePaso
        {
            get
            {
                return this.derechosDePasoField;
            }
            set
            {
                this.derechosDePasoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Carro")]
        public CartaPorteMercanciasTransporteFerroviarioCarro[] Carro
        {
            get
            {
                return this.carroField;
            }
            set
            {
                this.carroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoDeServicio//c_TipoDeServicio
        {
            get
            {
                return this.tipoDeServicioField;
            }
            set
            {
                this.tipoDeServicioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoDeTrafico//c_TipoDeTrafico
        {
            get
            {
                return this.tipoDeTraficoField;
            }
            set
            {
                this.tipoDeTraficoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreAseg
        {
            get
            {
                return this.nombreAsegField;
            }
            set
            {
                this.nombreAsegField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumPolizaSeguro
        {
            get
            {
                return this.numPolizaSeguroField;
            }
            set
            {
                this.numPolizaSeguroField = value;
            }
        }
       
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasTransporteFerroviarioDerechosDePaso
    {

        private string tipoDerechoDePasoField;//c_DerechosDePaso

        private decimal kilometrajePagadoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoDerechoDePaso//c_DerechosDePaso
        {
            get
            {
                return this.tipoDerechoDePasoField;
            }
            set
            {
                this.tipoDerechoDePasoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal KilometrajePagado
        {
            get
            {
                return this.kilometrajePagadoField;
            }
            set
            {
                this.kilometrajePagadoField = value;
            }
        }
       
    }
}
