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
    public partial class CartaPorteMercanciasTransporteFerroviarioCarro
    {
        [XmlIgnore] public int ferroviario_carro_id { get; set; }
        private CartaPorteMercanciasTransporteFerroviarioCarroContenedor[] contenedorField;

        private string tipoCarroField;//c_TipoCarro

        private string matriculaCarroField;

        private string guiaCarroField;

        private decimal toneladasNetasCarroField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Contenedor")]
        public CartaPorteMercanciasTransporteFerroviarioCarroContenedor[] Contenedor
        {
            get
            {
                return this.contenedorField;
            }
            set
            {
                this.contenedorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoCarro//c_TipoCarro
        {
            get
            {
                return this.tipoCarroField;
            }
            set
            {
                this.tipoCarroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MatriculaCarro
        {
            get
            {
                return this.matriculaCarroField;
            }
            set
            {
                this.matriculaCarroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GuiaCarro
        {
            get
            {
                return this.guiaCarroField;
            }
            set
            {
                this.guiaCarroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ToneladasNetasCarro
        {
            get
            {
                return this.toneladasNetasCarroField;
            }
            set
            {
                this.toneladasNetasCarroField = value;
            }
        }
        
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasTransporteFerroviarioCarroContenedor
    {

        private string tipoContenedorField;//c_Contenedor

        private decimal pesoContenedorVacioField;

        private decimal pesoNetoMercanciaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoContenedor//c_Contenedor
        {
            get
            {
                return this.tipoContenedorField;
            }
            set
            {
                this.tipoContenedorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoContenedorVacio
        {
            get
            {
                return this.pesoContenedorVacioField;
            }
            set
            {
                this.pesoContenedorVacioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoNetoMercancia
        {
            get
            {
                return this.pesoNetoMercanciaField;
            }
            set
            {
                this.pesoNetoMercanciaField = value;
            }
        }
        
    }
}
