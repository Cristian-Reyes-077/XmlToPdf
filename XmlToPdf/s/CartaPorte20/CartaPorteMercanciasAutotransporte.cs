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
    public partial class CartaPorteMercanciasAutotransporte
    {
        [XmlIgnore]public int cpauto_id { get; set; }
        private CartaPorteMercanciasAutotransporteIdentificacionVehicular identificacionVehicularField;

        private CartaPorteMercanciasAutotransporteSeguros segurosField;

        private CartaPorteMercanciasAutotransporteRemolque[] remolquesField;

        private string permSCTField;

        private string numPermisoSCTField;

        /// <remarks/>
        public CartaPorteMercanciasAutotransporteIdentificacionVehicular IdentificacionVehicular
        {
            get
            {
                return this.identificacionVehicularField;
            }
            set
            {
                this.identificacionVehicularField = value;
            }
        }

        /// <remarks/>
        public CartaPorteMercanciasAutotransporteSeguros Seguros
        {
            get
            {
                return this.segurosField;
            }
            set
            {
                this.segurosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Remolque", IsNullable = false)]
        public CartaPorteMercanciasAutotransporteRemolque[] Remolques
        {
            get
            {
                return this.remolquesField;
            }
            set
            {
                this.remolquesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PermSCT
        {
            get
            {
                return this.permSCTField;
            }
            set
            {
                this.permSCTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumPermisoSCT
        {
            get
            {
                return this.numPermisoSCTField;
            }
            set
            {
                this.numPermisoSCTField = value;
            }
        }
        
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasAutotransporteIdentificacionVehicular
    {

        private string configVehicularField;

        private string placaVMField;

        private int anioModeloVMField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ConfigVehicular
        {
            get
            {
                return this.configVehicularField;
            }
            set
            {
                this.configVehicularField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PlacaVM
        {
            get
            {
                return this.placaVMField;
            }
            set
            {
                this.placaVMField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int AnioModeloVM
        {
            get
            {
                return this.anioModeloVMField;
            }
            set
            {
                this.anioModeloVMField = value;
            }
        }
       
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasAutotransporteRemolque
    {

        private string subTipoRemField;

        private string placaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubTipoRem
        {
            get
            {
                return this.subTipoRemField;
            }
            set
            {
                this.subTipoRemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Placa
        {
            get
            {
                return this.placaField;
            }
            set
            {
                this.placaField = value;
            }
        }
       
    }
}
