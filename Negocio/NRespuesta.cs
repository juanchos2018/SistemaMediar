using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRespuesta
    {
        public string nombre { get; set; }
        public string estado { get; set; }
        public string status { get; set; }
        public string thumbail { get; set; }
        public string tipo { get; set; }
        public string ruta { get; set; }
        public Content content { get; set; }
    }
    public class NResultadoXMLSunat
    {
        public string mensaje { get; set; }
        public string errormensaje { get; set; }
        public bool error { get; set; }
    }
    public class NEnvioXMLSunat
    {
        public string ruc { get; set; }
        public string anio { get; set; }
        public string TipoDcumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Serie { get; set; }
        public bool RbtnTermico { get; set; }
    }
    public class Content
    {
        public string estatus { get; set; }
    }
}
