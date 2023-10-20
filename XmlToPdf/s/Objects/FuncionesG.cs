using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace XmlToPdf.Controlelrs.Objects
{
    public static class FuncionesG
    {
        //public static void InsertarHijosEmisor(XMLv33.ComprobanteEmisor objeto, int idpadre)
        //{
        //    Dictionary<string, object> objectsDictionary = new Dictionary<string, object>();
        //    objectsDictionary.Add("ComprobanteCfdiRelacionados", new XMLv33.ComprobanteCfdiRelacionados());
        //    objectsDictionary.Add("ComprobanteEmisor", new XMLv33.ComprobanteEmisor());
        //    objectsDictionary.Add("ComprobanteReceptor", new XMLv33.ComprobanteReceptor());
        //    objectsDictionary.Add("Concepto", new XMLv33.Conceptos.Concepto());
        //    objectsDictionary.Add("Impuestos", new XMLv33.Impsts.Impuestos());
        //    objectsDictionary.Add("ComprobanteComplemento", new XMLv33.ComprobanteComplemento());
        //    objectsDictionary.Add("ComprobanteAddenda", new XMLv33.ComprobanteAddenda());
        //    PropertyInfo[] properties = objeto.GetType().GetProperties();
        //    foreach (PropertyInfo property in properties)
        //    {
        //        string[] tiposDatos = new string[7] { "Int", "String", "Decimal", "Float", "DateTime", "Date", "Time" };
        //        string NombreAtributo = property.Name;
        //        var res = property.GetValue(objeto, null);
        //        var tipoDato = (res == null) ? null : res.GetType();
        //        if (res != null && tipoDato != null && !tiposDatos.Contains(tipoDato.Name))
        //        {
        //            var item = res;
        //            object itm = objectsDictionary[tipoDato.Name];

        //        }
        //    }
        //}
        //public static void InsertarHijosComprobante33(XMLv33.Comprobante comp, int idComprobante, Dictionary<string, object> complementos)
        //{
        //    if (verificatInsertaComplementos(complementos, idComprobante))
        //    {
        //        if (comp.CfdiRelacionados != null)
        //            comp.CfdiRelacionados.guardarElem(idComprobante);
        //        if (comp.Emisor != null)
        //            comp.Emisor.guardarElem(idComprobante);
        //        if (comp.Receptor != null)
        //            comp.Receptor.guardarElem(idComprobante);
        //        if (comp.Conceptos != null)
        //            foreach (var item in comp.Conceptos)
        //                item.guardarElem(idComprobante);
        //        if (comp.Impuestos != null)
        //            comp.Impuestos.guardarElem(idComprobante);

        //        /*   objeto.Emisor.guardarCEmisor(idpadre);
        //       Dictionary<string, object> objectsDictionary = new Dictionary<string, object>();
        //       objectsDictionary.Add("ComprobanteCfdiRelacionados", new XMLv33.ComprobanteCfdiRelacionados());
        //       objectsDictionary.Add("ComprobanteEmisor", new XMLv33.ComprobanteEmisor());
        //       objectsDictionary.Add("ComprobanteReceptor", new XMLv33.ComprobanteReceptor());
        //       objectsDictionary.Add("Concepto", new XMLv33.Conceptos.Concepto());
        //       objectsDictionary.Add("Impuestos", new XMLv33.Impsts.Impuestos());
        //       objectsDictionary.Add("ComprobanteComplemento", new XMLv33.ComprobanteComplemento());
        //       objectsDictionary.Add("ComprobanteAddenda", new XMLv33.ComprobanteAddenda());
        //       PropertyInfo[] properties = objeto.GetType().GetProperties();
        //       foreach (PropertyInfo property in properties)
        //       {
        //           string[] tiposDatos = new string[9] { "Int", "Int16", "Int32", "String", "Decimal", "Float", "DateTime", "Date", "Time" };
        //           string NombreAtributo = property.Name;
        //           var res = property.GetValue(objeto, null);
        //           var tipoDato = (res == null) ? null : res.GetType();
        //           if (res != null && tipoDato != null && !tiposDatos.Contains(tipoDato.Name))
        //           {
        //               var item = res;
        //               object itm = objectsDictionary[tipoDato.Name];

        //           }
        //       */
        //    }
        //}
        //public static List<object> qryInsert(object objeto)
        //{
        //    PropertyInfo[] properties = objeto.GetType().GetProperties();
        //    //PropertyInfo[] properties = typeof(Comprobante).GetProperties();
        //    List<object> list = new List<object>();

        //    foreach (PropertyInfo property in properties)
        //    {
        //        string[] tiposDatos = new string[9] { "Int", "Int16", "Int32", "String", "Decimal", "Float", "DateTime", "Date", "Time" };
        //        string NombreAtributo = property.Name;
        //        var res = property.GetValue(objeto, null);
        //        var tipoDato = (res == null) ? null : res.GetType();
        //        if (res != null && tipoDato != null && tiposDatos.Contains(tipoDato.Name))
        //        {
        //            if (tipoDato.Name == "String")
        //                res = res.ToString().Replace("'", "''");
        //            list.Add(new
        //            {
        //                campo = NombreAtributo.Replace("ü", "u"),
        //                value = ((tipoDato.Name == "DateTime") ? ((DateTime)res).ToString("yyyy-MM-dd HH:mm:ss") : res)
        //            });
        //        }
        //    }
        //    return list;
        //}
        //public static string ListaObjectToqry(List<object> list, string strIncCol, string strInicVal)
        //{
        //    string cols = strIncCol;// $"insert into cfd_{tabla}(";
        //    string values = strInicVal;// "values('";
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        var item = list[i];
        //        PropertyInfo[] properties = item.GetType().GetProperties();
        //        foreach (PropertyInfo property in properties)
        //        {
        //            if (property.Name == "value")
        //            {
        //                values += property.GetValue(item, null).ToString();
        //            }
        //            else
        //            {
        //                cols += property.GetValue(item, null).ToString();
        //            }
        //        }
        //        if (i < (list.Count - 1))
        //        {
        //            cols += ",";
        //            values += "','";
        //        }
        //        else
        //        {
        //            cols += ")";
        //            values += "')";
        //        }
        //        //cols += list[i].campo.ToString();
        //        //values += list[i]["value"];
        //    }
        //    string res = cols + values;
        //    return res;
        //}
        public static T DeserializarXml<T>(XmlElement elemento)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));

            using (StringReader lector = new StringReader(elemento.OuterXml))
            {
                return (T)serializador.Deserialize(lector);
            }

        }
       // public static bool verificatfd(Dictionary<string, object> complementos)
       // {
       //     TimbreFiscalDigital TFD = (TimbreFiscalDigital)complementos["tfd"];
       //     if (TFD.ExisteRegistro()) { return false; }
       //     return true;
       // }
       // public static bool verificatInsertaComplementos(Dictionary<string, object> complementos, int idComprobante)
       // {
       //     //{ "nomina", "nomina12", "tfd", "pago10", "pago20", "implocal" };
       //     TimbreFiscalDigital TFD = (TimbreFiscalDigital)complementos["tfd"];
       //     if (TFD.ExisteRegistro()) { return false; }
       //     if (TFD.guardaElem(idComprobante))
       //     {
       //         if (complementos.ContainsKey("nomina"))
       //         {
       //             Nomina11.Nomina nomina = (Nomina11.Nomina)complementos["nomina"];
       //             if (!nomina.guardaElem(idComprobante))
       //                 return false;
       //         }
       //         if (complementos.ContainsKey("nomina12"))
       //         {
       //             Nomina12.Nomina nomina = (Nomina12.Nomina)complementos["nomina12"];
       //             if (!nomina.guardaElem(idComprobante))
       //                 return false;
       //         }
       //         if (complementos.ContainsKey("pago10"))
       //         {
       //             Pagos10.Pagos pagos = (Pagos10.Pagos)complementos["pago10"];
       //             if (!pagos.guardaElem(idComprobante))
       //                 return false;
       //         }
       //         if (complementos.ContainsKey("pago20"))
       //         {
       //             Pagos20.Pagos pagos = (Pagos20.Pagos)complementos["pago20"];
       //             if (!pagos.guardaElem(idComprobante))
       //                 return false;
       //         }
       //         if (complementos.ContainsKey("implocal"))
       //         {
       //             ImpuestosLocales.ImpuestosLocales impuestosloc = (ImpuestosLocales.ImpuestosLocales)complementos["implocal"];
       //             if (!impuestosloc.guardaElem(idComprobante))
       //                 return false;
       //         }
       //         if (complementos.ContainsKey("cartaporte20"))
       //         {
       //             CartaPorte20.CartaPorte cp = (CartaPorte20.CartaPorte)complementos["cartaporte20"];
       //             if (!cp.guardaElem(idComprobante))
       //                 return false;
       //         }
       //     }
       //     return true;
       // }
       // /**    #####################################                            funciones Comprobante version 4.0                          ##############################**/
       // public static void InsertarHijosComprobante40(XMLv40.Comprobante comp, int idComprobante, Dictionary<string, object> complementos)
       // {
       //     if (verificatInsertaComplementos(complementos, idComprobante))
       //     {
       //         if (comp.InformacionGlobal != null)
       //             comp.InformacionGlobal.guardarElem(idComprobante);
       //         if (comp.CfdiRelacionados != null)
       //             foreach (var item in comp.CfdiRelacionados)
       //                 item.guardarElem(idComprobante);
       //         if (comp.Emisor != null)
       //             comp.Emisor.guardarElem(idComprobante);
       //         if (comp.Receptor != null)
       //             comp.Receptor.guardarElem(idComprobante);
       //         if (comp.Conceptos != null)
       //             foreach (var item in comp.Conceptos)
       //                 item.guardarElem(idComprobante);
       //         if (comp.Impuestos != null)
       //             comp.Impuestos.guardarElem(idComprobante);
       //         /*string qryInsertcfRel = "insert into cfd_cfdirelacionados(comprobante_id,TipoRelacion,UUID)";
       //         string valuesInsertcfRel = "values";
       //         if (comp.CfdiRelacionados != null)
       //             for (int i = 0; i < comp.CfdiRelacionados.Length; i++)
       //             {
       //                 XMLv40.ComprobanteCfdiRelacionados item = comp.CfdiRelacionados[i];
       //                 valuesInsertcfRel += item.GetElemsInsert(idComprobante);
       //                 if (i < (comp.CfdiRelacionados.Length - 1))
       //                 {
       //                     valuesInsertcfRel += ',';
       //                 }
       //             }
       //         string qry = qryInsertcfRel + valuesInsertcfRel;*/
       //         /*if (comp.CfdiRelacionados!=null)
       //             foreach(var item in comp.CfdiRelacionados)
       //                 item.guardarElem(idComprobante);
       //         if (
       //                 ((comp.InformacionGlobal != null) ? comp.InformacionGlobal.guardarElem(idComprobante) : true)
       //                 //&& ((comp.CfdiRelacionados != null && comp.CfdiRelacionados.Length > 0) ? funciones.query_abierto_sqls(qry) : true)
       //                 && ((comp.Emisor != null) ? comp.Emisor.guardarElem(idComprobante) : true)
       //                 && ((comp.Receptor != null) ? comp.Receptor.guardarElem(idComprobante) : true)
       //          )
       //         {*/
       //         /*XMLv40.ComprobanteComplemento complemento = comp.Complemento;
       //         if (complemento != null)
       //             if (complemento.SaveComplementos())
       //             {
       //                 var e = "cumplio";
       //             }*/
       //         /*XMLv40.Conceptos.Concepto[] conceptos = comp.Conceptos;
       //         if (conceptos != null)
       //             foreach (XMLv40.Conceptos.Concepto concepto in conceptos)
       //             {
       //                 if (!concepto.guardarElem(idComprobante))
       //                 {
       //                     var noc = "nocumple";
       //                 }
       //             }
       //         XMLv40.Impsts.Impuestos impuestos = comp.Impuestos;
       //         if (impuestos != null)
       //             if (!impuestos.guardarElem(idComprobante))
       //             {
       //                 var noc = "nocumple";
       //             }

       //         var elem = "cumplio";
       //     }*/
       //         /*//objeto.Emisor.guardarCEmisor(idpadre);
       //         var l = objeto.CfdiRelacionados;
       //         Dictionary<string, object> objectsDictionary = new Dictionary<string, object>();
       //         objectsDictionary.Add("ComprobanteCfdiRelacionados", new XMLv33.ComprobanteCfdiRelacionados());
       //         objectsDictionary.Add("ComprobanteEmisor", new XMLv33.ComprobanteEmisor());
       //         objectsDictionary.Add("ComprobanteReceptor", new XMLv33.ComprobanteReceptor());
       //         objectsDictionary.Add("Concepto", new XMLv33.Conceptos.Concepto());
       //         objectsDictionary.Add("Impuestos", new XMLv33.Impsts.Impuestos());
       //         objectsDictionary.Add("ComprobanteComplemento", new XMLv33.ComprobanteComplemento());
       //         objectsDictionary.Add("ComprobanteAddenda", new XMLv33.ComprobanteAddenda());
       //         PropertyInfo[] properties = objeto.GetType().GetProperties();
       //         foreach (PropertyInfo property in properties)
       //         {
       //             string[] tiposDatos = new string[7] { "Int", "String", "Decimal", "Float", "DateTime", "Date", "Time" };
       //             string NombreAtributo = property.Name;
       //             var res = property.GetValue(objeto, null);
       //             var tipoDato = (res == null) ? null : res.GetType();
       //             if (res != null && tipoDato != null && !tiposDatos.Contains(tipoDato.Name))
       //             {
       //                 var item = res;
       //                 object itm = objectsDictionary[tipoDato.Name];

       //             }
       //         }*/
       //     }
       // }
       // /*En esta funcion se agregan los elementos igos del concepto/
       ///* public static void InsertarHijosConceptos40(XMLv40.Conceptos.Concepto concepto,int idConcepto)
       // {
       //     XMLv40.Conceptos.ConceptoImpuestos impuestos = concepto.Impuestos;
       //     string qry = ((impuestos!=null) ? impuestos.getElementosSave(idConcepto):"");
       //     if (qry != null && qry.Trim() != "" && impuestos!=null)
       //     {
       //         funciones.query_abierto_sqls(qry);
       //     }
       //     qry = "";
       //     XMLv40.Conceptos.ConceptoACuentaTerceros a_cuenta_terceros = concepto.ACuentaTerceros;
       //     qry = ((a_cuenta_terceros != null) ? a_cuenta_terceros.getElementosSave(idConcepto):"");
       //     if (qry != null && qry.Trim() != "" && a_cuenta_terceros != null)
       //     {
       //         funciones.query_abierto_sqls(qry);
       //     }
       //     qry = "";
       //     XMLv40.Conceptos.ConceptoInformacionAduanera[] inform_aduanera = concepto.InformacionAduanera;
       //     if(inform_aduanera!=null)
       //     foreach(XMLv40.Conceptos.ConceptoInformacionAduanera item in inform_aduanera)
       //     {
       //         qry+=item.getElementosSave(idConcepto);
       //     }
       //     if (qry != null && qry.Trim() != "" && inform_aduanera != null)
       //     {
       //         funciones.query_abierto_sqls(qry);
       //     }
       //     qry = "";
       //     XMLv40.Conceptos.ConceptoCuentaPredial[] cuentaPredial = concepto.CuentaPredial;
       //     if(cuentaPredial!=null)
       //     foreach (XMLv40.Conceptos.ConceptoCuentaPredial item in cuentaPredial)
       //     {
       //         qry += item.getElementosSave(idConcepto);
       //     }
       //     //qry = a_cuenta_terceros.getElementosSave(idConcepto);
       //     if (qry != null && qry.Trim() != "" && cuentaPredial != null)
       //     {
       //         funciones.query_abierto_sqls(qry);
       //     }
       //     qry = "";
       //     XMLv40.Conceptos.ConceptoComplementoConcepto complementoConcepto = concepto.ComplementoConcepto;
       //     qry = ((complementoConcepto != null) ? complementoConcepto.getElementosSave(idConcepto):"");
       //     if (qry != null && qry.Trim() != "" && complementoConcepto != null)
       //     {
       //         funciones.query_abierto_sqls(qry);
       //     }
       //     qry = "";
       //     XMLv40.Conceptos.ConceptoParte[] parte = concepto.Parte;
       //     if(parte!=null)
       //     foreach (XMLv40.Conceptos.ConceptoParte item in parte)
       //     {
       //         qry += item.getElementosSave(idConcepto);
       //     }
       //     //qry = a_cuenta_terceros.getElementosSave(idConcepto);
       //     if (qry != null && qry.Trim() != "" && parte != null)
       //     {
       //         funciones.query_abierto_sqls(qry);
       //     }
       // }*/
       // public static void GenerarComplementoXml(int idComprobante, RichTextBox rtb)
       // {
       //     string version = funciones.consulta_campo_sqls($"select A.Version from cfd_comprobantes A where A.cfd_comprobante_id={idComprobante}");
       //     version = version.Trim();
       //     if (version != null)
       //     {
       //         if (version == "3.3")
       //         {
       //             XMLv33.Comprobante comprobante = new XMLv33.Comprobante();
       //             comprobante = comprobante.ConsultarById(idComprobante);

       //             if (comprobante != null)
       //                 rtb.Text = comprobante.generaXML();


       //         }
       //         else if (version == "4.0")
       //         {
       //             XMLv40.Comprobante comprobante = new XMLv40.Comprobante();
       //             comprobante = comprobante.ConsultarById(idComprobante);
       //             string xml = "";
       //             if (comprobante != null)
       //                 xml = comprobante.generaXML();
       //             rtb.Text = xml;
       //             string nameXML = "pruebaTemp.xml";
       //             if (guardaArchTemp(nameXML, xml))
       //             {
       //                 string xmlTempPath = Path.Combine(Path.GetTempPath(), nameXML);
       //                 Timbrar t = new Timbrar(@"C:\Users\drh_r\Downloads\Certificados_de_Prueba\Certificados_Pruebas\Personas Morales\EKU9003173C9_20230517223532\", "12345678a");
       //                 t.generaCadenaOriginal(xmlTempPath);
       //                 comprobante.Certificado = t.EelementoCer.Certificado;
       //                 comprobante.Sello = t.SelloField;
       //                 comprobante.NoCertificado = t.EelementoCer.CertificadoNo;
       //                 xml = comprobante.generaXML();
       //                 rtb.Text = xml;
       //                 guardaArchTemp(nameXML, xml);
       //             }
       //         }
       //     }
       // }
       // private static bool guardaArchTemp(string nombreArchivo, string xmlContent)
       // {
       //     try
       //     {
       //         string carpetaTemporal = Path.GetTempPath();
       //         if (File.Exists(nombreArchivo))
       //         {
       //             File.Delete(nombreArchivo);
       //         }
       //         string rutaCompleta = Path.Combine(carpetaTemporal, nombreArchivo);
       //         File.WriteAllText(rutaCompleta, xmlContent);
       //         return true;
       //     }
       //     catch (Exception e)
       //     {
       //         Console.WriteLine(e.ToString());
       //     }
       //     return false;
       // }
    }
}
