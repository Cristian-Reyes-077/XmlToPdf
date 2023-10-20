using System.Data;
using System.Xml.Serialization;

namespace XmlToPdf.Xmlv40
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteCfdiRelacionados
    {

        private ComprobanteCfdiRelacionadosCfdiRelacionado[] cfdiRelacionadoField;

        private string tipoRelacionField;
        [XmlIgnore]
        public int cfd_cfdirelacionado_id { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CfdiRelacionado")]
        public ComprobanteCfdiRelacionadosCfdiRelacionado[] CfdiRelacionado
        {
            get
            {
                return this.cfdiRelacionadoField;
            }
            set
            {
                this.cfdiRelacionadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoRelacion
        {
            get
            {
                return this.tipoRelacionField;
            }
            set
            {
                this.tipoRelacionField = value;
            }
        }
        public string GetElemsInsert(int idComprobante)
        {
            
            string values = "";
            for (int i=0;i < this.cfdiRelacionadoField.Length;i++)
            {
                ComprobanteCfdiRelacionadosCfdiRelacionado item = this.cfdiRelacionadoField[i];
                values += $"({idComprobante},'{this.tipoRelacionField}','{item.UUID}')";
                if(i < (this.cfdiRelacionadoField.Length - 1)){
                    values += ",";
                }
            }

            return values;
        }
        
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteCfdiRelacionadosCfdiRelacionado
    {

        private string uUIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UUID
        {
            get
            {
                return this.uUIDField;
            }
            set
            {
                this.uUIDField = value;
            }
        }
       
    }
}
