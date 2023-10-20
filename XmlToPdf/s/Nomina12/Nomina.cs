using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlToPdf.Controlelrs.Nomina12
{
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://www.sat.gob.mx/nomina12", IsNullable = false)]
    public partial class Nomina
    {

        private NominaEmisor emisorField;

        private NominaReceptor receptorField;

        private NominaPercepciones percepcionesField;

        private NominaDeducciones deduccionesField;

        private NominaOtroPago[] otrosPagosField;

        private NominaIncapacidad[] incapacidadesField;

        private string versionField;

        private string tipoNominaField;

        private DateTime fechaPagoField;

        private DateTime fechaInicialPagoField;

        private DateTime fechaFinalPagoField;

        private decimal numDiasPagadosField;

        private decimal totalPercepcionesField;

        private bool totalPercepcionesFieldSpecified;

        private decimal totalDeduccionesField;

        private bool totalDeduccionesFieldSpecified;

        private decimal totalOtrosPagosField;

        private bool totalOtrosPagosFieldSpecified;

        public Nomina()
        {
            versionField = "1.2";
        }

        /// <remarks/>
        public NominaEmisor Emisor
        {
            get
            {
                return emisorField;
            }
            set
            {
                emisorField = value;
            }
        }

        /// <remarks/>
        public NominaReceptor Receptor
        {
            get
            {
                return receptorField;
            }
            set
            {
                receptorField = value;
            }
        }

        /// <remarks/>
        public NominaPercepciones Percepciones
        {
            get
            {
                return percepcionesField;
            }
            set
            {
                percepcionesField = value;
            }
        }

        /// <remarks/>
        public NominaDeducciones Deducciones
        {
            get
            {
                return deduccionesField;
            }
            set
            {
                deduccionesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem("OtroPago", IsNullable = false)]
        public NominaOtroPago[] OtrosPagos
        {
            get
            {
                return otrosPagosField;
            }
            set
            {
                otrosPagosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem("Incapacidad", IsNullable = false)]
        public NominaIncapacidad[] Incapacidades
        {
            get
            {
                return incapacidadesField;
            }
            set
            {
                incapacidadesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string Version
        {
            get
            {
                return versionField;
            }
            set
            {
                versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string TipoNomina
        {
            get
            {
                return tipoNominaField;
            }
            set
            {
                tipoNominaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType = "date")]
        public DateTime FechaPago
        {
            get
            {
                return fechaPagoField;
            }
            set
            {
                fechaPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType = "date")]
        public DateTime FechaInicialPago
        {
            get
            {
                return fechaInicialPagoField;
            }
            set
            {
                fechaInicialPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType = "date")]
        public DateTime FechaFinalPago
        {
            get
            {
                return fechaFinalPagoField;
            }
            set
            {
                fechaFinalPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal NumDiasPagados
        {
            get
            {
                return numDiasPagadosField;
            }
            set
            {
                numDiasPagadosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal TotalPercepciones
        {
            get
            {
                return totalPercepcionesField;
            }
            set
            {
                totalPercepcionesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool TotalPercepcionesSpecified
        {
            get
            {
                return totalPercepcionesFieldSpecified;
            }
            set
            {
                totalPercepcionesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal TotalDeducciones
        {
            get
            {
                return totalDeduccionesField;
            }
            set
            {
                totalDeduccionesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool TotalDeduccionesSpecified
        {
            get
            {
                return totalDeduccionesFieldSpecified;
            }
            set
            {
                totalDeduccionesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public decimal TotalOtrosPagos
        {
            get
            {
                return totalOtrosPagosField;
            }
            set
            {
                totalOtrosPagosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool TotalOtrosPagosSpecified
        {
            get
            {
                return totalOtrosPagosFieldSpecified;
            }
            set
            {
                totalOtrosPagosFieldSpecified = value;
            }
        }
        
    }
}
