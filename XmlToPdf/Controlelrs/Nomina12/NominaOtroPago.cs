using System;
using System.Data;

namespace XmlToPdf.Controlelrs.Nomina12
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaOtroPago
    {

        private NominaOtroPagoSubsidioAlEmpleo subsidioAlEmpleoField;

        private NominaOtroPagoCompensacionSaldosAFavor compensacionSaldosAFavorField;

        private string tipoOtroPagoField;

        private string claveField;

        private string conceptoField;

        private decimal importeField;

        /// <remarks/>
        public NominaOtroPagoSubsidioAlEmpleo SubsidioAlEmpleo
        {
            get
            {
                return subsidioAlEmpleoField;
            }
            set
            {
                subsidioAlEmpleoField = value;
            }
        }

        /// <remarks/>
        public NominaOtroPagoCompensacionSaldosAFavor CompensacionSaldosAFavor
        {
            get
            {
                return compensacionSaldosAFavorField;
            }
            set
            {
                compensacionSaldosAFavorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string TipoOtroPago
        {
            get
            {
                return tipoOtroPagoField;
            }
            set
            {
                tipoOtroPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Clave
        {
            get
            {
                return claveField;
            }
            set
            {
                claveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Concepto
        {
            get
            {
                return conceptoField;
            }
            set
            {
                conceptoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal Importe
        {
            get
            {
                return importeField;
            }
            set
            {
                importeField = value;
            }
        }
        
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaOtroPagoSubsidioAlEmpleo
    {

        private decimal subsidioCausadoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal SubsidioCausado
        {
            get
            {
                return subsidioCausadoField;
            }
            set
            {
                subsidioCausadoField = value;
            }
        }
       
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaOtroPagoCompensacionSaldosAFavor
    {

        private decimal saldoAFavorField;

        private short añoField;

        private decimal remanenteSalFavField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal SaldoAFavor
        {
            get
            {
                return saldoAFavorField;
            }
            set
            {
                saldoAFavorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public short Año
        {
            get
            {
                return añoField;
            }
            set
            {
                añoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal RemanenteSalFav
        {
            get
            {
                return remanenteSalFavField;
            }
            set
            {
                remanenteSalFavField = value;
            }
        }
       
    }
}