﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlToPdf.Controlelrs.ImpuestosLocales
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/implocal")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/implocal", IsNullable = false)]
    public partial class ImpuestosLocales
    {

        private ImpuestosLocalesRetencionesLocales[] retencionesLocalesField;

        private ImpuestosLocalesTrasladosLocales[] trasladosLocalesField;

        private string versionField;

        private decimal totaldeRetencionesField;

        private decimal totaldeTrasladosField;

        public ImpuestosLocales()
        {
            this.versionField = "1.0";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RetencionesLocales")]
        public ImpuestosLocalesRetencionesLocales[] RetencionesLocales
        {
            get
            {
                return this.retencionesLocalesField;
            }
            set
            {
                this.retencionesLocalesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TrasladosLocales")]
        public ImpuestosLocalesTrasladosLocales[] TrasladosLocales
        {
            get
            {
                return this.trasladosLocalesField;
            }
            set
            {
                this.trasladosLocalesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotaldeRetenciones
        {
            get
            {
                return this.totaldeRetencionesField;
            }
            set
            {
                this.totaldeRetencionesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotaldeTraslados
        {
            get
            {
                return this.totaldeTrasladosField;
            }
            set
            {
                this.totaldeTrasladosField = value;
            }
        }
        
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/implocal")]
    public partial class ImpuestosLocalesRetencionesLocales
    {

        private string impLocRetenidoField;

        private decimal tasadeRetencionField;

        private decimal importeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ImpLocRetenido
        {
            get
            {
                return this.impLocRetenidoField;
            }
            set
            {
                this.impLocRetenidoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TasadeRetencion
        {
            get
            {
                return this.tasadeRetencionField;
            }
            set
            {
                this.tasadeRetencionField = value;
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
        
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/implocal")]
    public partial class ImpuestosLocalesTrasladosLocales
    {

        private string impLocTrasladadoField;

        private decimal tasadeTrasladoField;

        private decimal importeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ImpLocTrasladado
        {
            get
            {
                return this.impLocTrasladadoField;
            }
            set
            {
                this.impLocTrasladadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TasadeTraslado
        {
            get
            {
                return this.tasadeTrasladoField;
            }
            set
            {
                this.tasadeTrasladoField = value;
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
        
    }
}
