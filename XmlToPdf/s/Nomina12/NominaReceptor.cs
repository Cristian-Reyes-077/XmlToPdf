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
    public partial class NominaReceptor
    {

        private NominaReceptorSubContratacion[] subContratacionField;

        private string curpField;

        private string numSeguridadSocialField;

        private DateTime fechaInicioRelLaboralField;

        private bool fechaInicioRelLaboralFieldSpecified;

        private string antigüedadField;

        private string tipoContratoField;

        private string sindicalizadoField;

        private bool sindicalizadoFieldSpecified;

        private string tipoJornadaField;

        private bool tipoJornadaFieldSpecified;

        private string tipoRegimenField;

        private string numEmpleadoField;

        private string departamentoField;

        private string puestoField;

        private string riesgoPuestoField;

        private bool riesgoPuestoFieldSpecified;

        private string periodicidadPagoField;

        private string bancoField;

        private bool bancoFieldSpecified;

        private string cuentaBancariaField;

        private decimal salarioBaseCotAporField;

        private bool salarioBaseCotAporFieldSpecified;

        private decimal salarioDiarioIntegradoField;

        private bool salarioDiarioIntegradoFieldSpecified;

        private string claveEntFedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SubContratacion")]
        public NominaReceptorSubContratacion[] SubContratacion
        {
            get
            {
                return subContratacionField;
            }
            set
            {
                subContratacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Curp
        {
            get
            {
                return curpField;
            }
            set
            {
                curpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string NumSeguridadSocial
        {
            get
            {
                return numSeguridadSocialField;
            }
            set
            {
                numSeguridadSocialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType = "date")]
        public DateTime FechaInicioRelLaboral
        {
            get
            {
                return fechaInicioRelLaboralField;
            }
            set
            {
                fechaInicioRelLaboralField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool FechaInicioRelLaboralSpecified
        {
            get
            {
                return fechaInicioRelLaboralFieldSpecified;
            }
            set
            {
                fechaInicioRelLaboralFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Antigüedad
        {
            get
            {
                return antigüedadField;
            }
            set
            {
                antigüedadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string TipoContrato
        {
            get
            {
                return tipoContratoField;
            }
            set
            {
                tipoContratoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Sindicalizado
        {
            get
            {
                return sindicalizadoField;
            }
            set
            {
                sindicalizadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool SindicalizadoSpecified
        {
            get
            {
                return sindicalizadoFieldSpecified;
            }
            set
            {
                sindicalizadoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string TipoJornada
        {
            get
            {
                return tipoJornadaField;
            }
            set
            {
                tipoJornadaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool TipoJornadaSpecified
        {
            get
            {
                return tipoJornadaFieldSpecified;
            }
            set
            {
                tipoJornadaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string TipoRegimen
        {
            get
            {
                return tipoRegimenField;
            }
            set
            {
                tipoRegimenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string NumEmpleado
        {
            get
            {
                return numEmpleadoField;
            }
            set
            {
                numEmpleadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Departamento
        {
            get
            {
                return departamentoField;
            }
            set
            {
                departamentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Puesto
        {
            get
            {
                return puestoField;
            }
            set
            {
                puestoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string RiesgoPuesto
        {
            get
            {
                return riesgoPuestoField;
            }
            set
            {
                riesgoPuestoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool RiesgoPuestoSpecified
        {
            get
            {
                return riesgoPuestoFieldSpecified;
            }
            set
            {
                riesgoPuestoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string PeriodicidadPago
        {
            get
            {
                return periodicidadPagoField;
            }
            set
            {
                periodicidadPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Banco
        {
            get
            {
                return bancoField;
            }
            set
            {
                bancoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool BancoSpecified
        {
            get
            {
                return bancoFieldSpecified;
            }
            set
            {
                bancoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType = "integer")]
        public string CuentaBancaria
        {
            get
            {
                return cuentaBancariaField;
            }
            set
            {
                cuentaBancariaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal SalarioBaseCotApor
        {
            get
            {
                return salarioBaseCotAporField;
            }
            set
            {
                salarioBaseCotAporField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool SalarioBaseCotAporSpecified
        {
            get
            {
                return salarioBaseCotAporFieldSpecified;
            }
            set
            {
                salarioBaseCotAporFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal SalarioDiarioIntegrado
        {
            get
            {
                return salarioDiarioIntegradoField;
            }
            set
            {
                salarioDiarioIntegradoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool SalarioDiarioIntegradoSpecified
        {
            get
            {
                return salarioDiarioIntegradoFieldSpecified;
            }
            set
            {
                salarioDiarioIntegradoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string ClaveEntFed
        {
            get
            {
                return claveEntFedField;
            }
            set
            {
                claveEntFedField = value;
            }
        }
        
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaReceptorSubContratacion
    {

        private string rfcLaboraField;

        private decimal porcentajeTiempoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string RfcLabora
        {
            get
            {
                return rfcLaboraField;
            }
            set
            {
                rfcLaboraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal PorcentajeTiempo
        {
            get
            {
                return porcentajeTiempoField;
            }
            set
            {
                porcentajeTiempoField = value;
            }
        }
        
    }
}