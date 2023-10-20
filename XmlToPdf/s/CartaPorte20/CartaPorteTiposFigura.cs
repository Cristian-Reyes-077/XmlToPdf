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
    public partial class CartaPorteTiposFigura
    {
        [XmlIgnore] public int tipofigura_id { get; set; }
        private CartaPorteTiposFiguraPartesTransporte[] partesTransporteField;

        private CartaPorteTiposFiguraDomicilio domicilioField;

        private string tipoFiguraField;//c_FiguraTransporte

        private string rFCFiguraField;

        private string numLicenciaField;

        private string nombreFiguraField;

        private string numRegIdTribFiguraField;

        private string residenciaFiscalFiguraField;//c_Pais

        private bool residenciaFiscalFiguraFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartesTransporte")]
        public CartaPorteTiposFiguraPartesTransporte[] PartesTransporte
        {
            get
            {
                return this.partesTransporteField;
            }
            set
            {
                this.partesTransporteField = value;
            }
        }

        /// <remarks/>
        public CartaPorteTiposFiguraDomicilio Domicilio
        {
            get
            {
                return this.domicilioField;
            }
            set
            {
                this.domicilioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoFigura//c_FiguraTransporte
        {
            get
            {
                return this.tipoFiguraField;
            }
            set
            {
                this.tipoFiguraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RFCFigura
        {
            get
            {
                return this.rFCFiguraField;
            }
            set
            {
                this.rFCFiguraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumLicencia
        {
            get
            {
                return this.numLicenciaField;
            }
            set
            {
                this.numLicenciaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreFigura
        {
            get
            {
                return this.nombreFiguraField;
            }
            set
            {
                this.nombreFiguraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTribFigura
        {
            get
            {
                return this.numRegIdTribFiguraField;
            }
            set
            {
                this.numRegIdTribFiguraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResidenciaFiscalFigura//c_Pais
        {
            get
            {
                return this.residenciaFiscalFiguraField;
            }
            set
            {
                this.residenciaFiscalFiguraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidenciaFiscalFiguraSpecified
        {
            get
            {
                return this.residenciaFiscalFiguraFieldSpecified;
            }
            set
            {
                this.residenciaFiscalFiguraFieldSpecified = value;
            }
        }
        
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteTiposFiguraPartesTransporte
    {

        private string parteTransporteField;//c_ParteTransporte

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParteTransporte//c_ParteTransporte
        {
            get
            {
                return this.parteTransporteField;
            }
            set
            {
                this.parteTransporteField = value;
            }
        }
        
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteTiposFiguraDomicilio
    {

        private string calleField;

        private string numeroExteriorField;

        private string numeroInteriorField;

        private string coloniaField;

        private string localidadField;

        private string referenciaField;

        private string municipioField;

        private string estadoField;

        private string paisField;//c_Pais

        private string codigoPostalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Calle
        {
            get
            {
                return this.calleField;
            }
            set
            {
                this.calleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumeroExterior
        {
            get
            {
                return this.numeroExteriorField;
            }
            set
            {
                this.numeroExteriorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumeroInterior
        {
            get
            {
                return this.numeroInteriorField;
            }
            set
            {
                this.numeroInteriorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Colonia
        {
            get
            {
                return this.coloniaField;
            }
            set
            {
                this.coloniaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Localidad
        {
            get
            {
                return this.localidadField;
            }
            set
            {
                this.localidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Referencia
        {
            get
            {
                return this.referenciaField;
            }
            set
            {
                this.referenciaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Municipio
        {
            get
            {
                return this.municipioField;
            }
            set
            {
                this.municipioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Estado
        {
            get
            {
                return this.estadoField;
            }
            set
            {
                this.estadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Pais//c_Pais
        {
            get
            {
                return this.paisField;
            }
            set
            {
                this.paisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodigoPostal
        {
            get
            {
                return this.codigoPostalField;
            }
            set
            {
                this.codigoPostalField = value;
            }
        }
        
    }
}
