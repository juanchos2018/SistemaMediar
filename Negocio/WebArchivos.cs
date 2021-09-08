using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
  public  class WebArchivos
    {
        ClsClienteWeb server = new ClsClienteWeb();
        public string SubirArchivos(string archivos, int IdEmpresa, string IdCarpeta)
        {//  client.SubirArchivos(files, RUC, txtanio.Text,NombreCaja, Serie, NumeroLiquidacion.ToString(), tipo);
            string[] parametros = { "IdEmpresa", "IdCarpeta" };
            object[] valores = { IdEmpresa, IdCarpeta };
            return server.SubirArchivos(archivos, parametros, valores, "api/Archivo");
        }


        public string ConsultaDni(string dni)
        {//  client.SubirArchivos(files, RUC, txtanio.Text,NombreCaja, Serie, NumeroLiquidacion.ToString(), tipo);
           
            return server.ConsultaDni(dni);
        }

        public string EnviarCorreo(string correo, string ruta)
        {
            var datosjson = new
            {
                correo = correo,
                ruta = ruta,
                asunto = "Envio de documneot",
                mensaje = "Documento we",
                remitente = "jcarlossenati@gmail.com",
                nombre_empresa = "Mediar-JSB",
                passwword = "Universidad2020"

            };
            var response = server.EnvioJson("api/Correo", datosjson);
            var res = response.Content;
            Content d = new JsonDeserializer().Deserialize<Content>(response);
            return d.estatus;
        }
    }
}
