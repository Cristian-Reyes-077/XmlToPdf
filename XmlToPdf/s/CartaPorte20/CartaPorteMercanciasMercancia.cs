using XmlToPdf.Controlelrs.ImpuestosLocales;
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
    public partial class CartaPorteMercanciasMercancia
    {
        [XmlIgnore]public int mercancia_det_id { get; set; }

        private CartaPorteMercanciasMercanciaPedimentos[] pedimentosField;

        private CartaPorteMercanciasMercanciaGuiasIdentificacion[] guiasIdentificacionField;

        private CartaPorteMercanciasMercanciaCantidadTransporta[] cantidadTransportaField;

        private CartaPorteMercanciasMercanciaDetalleMercancia detalleMercanciaField;

        private string bienesTranspField;

        private string claveSTCCField;

        private string descripcionField;

        private decimal cantidadField;

        private string claveUnidadField;

        private string unidadField;

        private string dimensionesField;

        private string materialPeligrosoField; //Sí,No

        private bool materialPeligrosoFieldSpecified;

        private string cveMaterialPeligrosoField;

        private bool cveMaterialPeligrosoFieldSpecified;

        private string embalajeField;

        private bool embalajeFieldSpecified;

        private string descripEmbalajeField;

        private decimal pesoEnKgField;

        private decimal valorMercanciaField;

        private bool valorMercanciaFieldSpecified;

        private string monedaField;

        private bool monedaFieldSpecified;

        private string fraccionArancelariaField;

        private bool fraccionArancelariaFieldSpecified;

        private string uUIDComercioExtField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Pedimentos")]
        public CartaPorteMercanciasMercanciaPedimentos[] Pedimentos
        {
            get
            {
                return this.pedimentosField;
            }
            set
            {
                this.pedimentosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GuiasIdentificacion")]
        public CartaPorteMercanciasMercanciaGuiasIdentificacion[] GuiasIdentificacion
        {
            get
            {
                return this.guiasIdentificacionField;
            }
            set
            {
                this.guiasIdentificacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CantidadTransporta")]
        public CartaPorteMercanciasMercanciaCantidadTransporta[] CantidadTransporta
        {
            get
            {
                return this.cantidadTransportaField;
            }
            set
            {
                this.cantidadTransportaField = value;
            }
        }

        /// <remarks/>
        public CartaPorteMercanciasMercanciaDetalleMercancia DetalleMercancia
        {
            get
            {
                return this.detalleMercanciaField;
            }
            set
            {
                this.detalleMercanciaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BienesTransp
        {
            get
            {
                return this.bienesTranspField;
            }
            set
            {
                this.bienesTranspField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveSTCC
        {
            get
            {
                return this.claveSTCCField;
            }
            set
            {
                this.claveSTCCField = value;
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
        public string Dimensiones
        {
            get
            {
                return this.dimensionesField;
            }
            set
            {
                this.dimensionesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MaterialPeligroso //Sí,No
        {
            get
            {
                return this.materialPeligrosoField;
            }
            set
            {
                this.materialPeligrosoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaterialPeligrosoSpecified
        {
            get
            {
                return this.materialPeligrosoFieldSpecified;
            }
            set
            {
                this.materialPeligrosoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CveMaterialPeligroso
        {
            get
            {
                return this.cveMaterialPeligrosoField;
            }
            set
            {
                this.cveMaterialPeligrosoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CveMaterialPeligrosoSpecified
        {
            get
            {
                return this.cveMaterialPeligrosoFieldSpecified;
            }
            set
            {
                this.cveMaterialPeligrosoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Embalaje
        {
            get
            {
                return this.embalajeField;
            }
            set
            {
                this.embalajeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EmbalajeSpecified
        {
            get
            {
                return this.embalajeFieldSpecified;
            }
            set
            {
                this.embalajeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DescripEmbalaje
        {
            get
            {
                return this.descripEmbalajeField;
            }
            set
            {
                this.descripEmbalajeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoEnKg
        {
            get
            {
                return this.pesoEnKgField;
            }
            set
            {
                this.pesoEnKgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ValorMercancia
        {
            get
            {
                return this.valorMercanciaField;
            }
            set
            {
                this.valorMercanciaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorMercanciaSpecified
        {
            get
            {
                return this.valorMercanciaFieldSpecified;
            }
            set
            {
                this.valorMercanciaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Moneda
        {
            get
            {
                return this.monedaField;
            }
            set
            {
                this.monedaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MonedaSpecified
        {
            get
            {
                return this.monedaFieldSpecified;
            }
            set
            {
                this.monedaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FraccionArancelaria
        {
            get
            {
                return this.fraccionArancelariaField;
            }
            set
            {
                this.fraccionArancelariaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FraccionArancelariaSpecified
        {
            get
            {
                return this.fraccionArancelariaFieldSpecified;
            }
            set
            {
                this.fraccionArancelariaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UUIDComercioExt
        {
            get
            {
                return this.uUIDComercioExtField;
            }
            set
            {
                this.uUIDComercioExtField = value;
            }
        }
       
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasMercanciaPedimentos
    {

        private string pedimentoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Pedimento
        {
            get
            {
                return this.pedimentoField;
            }
            set
            {
                this.pedimentoField = value;
            }
        }
       
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasMercanciaGuiasIdentificacion
    {

        private string numeroGuiaIdentificacionField;

        private string descripGuiaIdentificacionField;

        private decimal pesoGuiaIdentificacionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumeroGuiaIdentificacion
        {
            get
            {
                return this.numeroGuiaIdentificacionField;
            }
            set
            {
                this.numeroGuiaIdentificacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DescripGuiaIdentificacion
        {
            get
            {
                return this.descripGuiaIdentificacionField;
            }
            set
            {
                this.descripGuiaIdentificacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoGuiaIdentificacion
        {
            get
            {
                return this.pesoGuiaIdentificacionField;
            }
            set
            {
                this.pesoGuiaIdentificacionField = value;
            }
        }
       
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasMercanciaCantidadTransporta
    {

        private decimal cantidadField;

        private string iDOrigenField;

        private string iDDestinoField;

        private string cvesTransporteField;

        private bool cvesTransporteFieldSpecified;

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
        public string IDOrigen
        {
            get
            {
                return this.iDOrigenField;
            }
            set
            {
                this.iDOrigenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IDDestino
        {
            get
            {
                return this.iDDestinoField;
            }
            set
            {
                this.iDDestinoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CvesTransporte
        {
            get
            {
                return this.cvesTransporteField;
            }
            set
            {
                this.cvesTransporteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CvesTransporteSpecified
        {
            get
            {
                return this.cvesTransporteFieldSpecified;
            }
            set
            {
                this.cvesTransporteFieldSpecified = value;
            }
        }
       
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasMercanciaDetalleMercancia
    {

        private string unidadPesoMercField;

        private decimal pesoBrutoField;

        private decimal pesoNetoField;

        private decimal pesoTaraField;

        private int numPiezasField;

        private bool numPiezasFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnidadPesoMerc
        {
            get
            {
                return this.unidadPesoMercField;
            }
            set
            {
                this.unidadPesoMercField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoBruto
        {
            get
            {
                return this.pesoBrutoField;
            }
            set
            {
                this.pesoBrutoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoNeto
        {
            get
            {
                return this.pesoNetoField;
            }
            set
            {
                this.pesoNetoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoTara
        {
            get
            {
                return this.pesoTaraField;
            }
            set
            {
                this.pesoTaraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int NumPiezas
        {
            get
            {
                return this.numPiezasField;
            }
            set
            {
                this.numPiezasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumPiezasSpecified
        {
            get
            {
                return this.numPiezasFieldSpecified;
            }
            set
            {
                this.numPiezasFieldSpecified = value;
            }
        }
        
    }
}
