using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class ClsClienteWeb
    {
        public string ServerWeb { get; set; }
        public string RutaApiReniec { get; set; } = "http://aveoperu.com/dniconsulta/";
        public void AsignarServer(string server = "")
        {
            ServerWeb = server;
        }
        public Boolean VerificarServer()
        {
            ServerWeb = "http://localhost/ApiFile/";
           // ServerWeb = "http://localhost:62067/";


            if (ServerWeb == "" || ServerWeb == null)
            {
                if (ClsWebParametros.WebServer == "" || ClsWebParametros.WebServer == null)
                {
                    return false;
                }
                else
                {
                    ServerWeb = ClsWebParametros.WebServer;
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        public string SubirArchivos(string archivos, string[] parametros, object[] valores, string ruta)
        {
            if (VerificarServer())
            {
                RestClient client = new RestClient(ServerWeb);
                client.Timeout = -1;
                RestRequest request = new RestRequest(ruta, Method.POST);
                int i = 0;
                foreach (string parametro in parametros)
                {
                    request.AddParameter(parametro, valores[i]);
                    i = i + 1;
                }
                //foreach (var archivo in archivos)
                //{
                request.AddFile("file", archivos);
                //}
                IRestResponse response = client.Execute(request);
                string status = response.StatusCode.ToString();
                if (status == "NotFound")
                {
                    return null;
                }
                return response.Content.ToString();
            }
            return null;
        }

        public IRestResponse EnvioJson(string accion, object datos)
        {
            if (VerificarServer())
            {
                //RestClient client = new RestClient(ServerWeb);
                //client.Timeout = -1;
                //RestRequest request = new RestRequest(accion, Method.POST);
                //request.RequestFormat = DataFormat.Json;
                //var json = request.JsonSerializer.Serialize(datos);
                //request.AddJsonBody(json);
                //IRestResponse response = client.Execute(request);
                //return response;



                RestClient client = new RestClient(ServerWeb);
                client.Timeout = -1;
                RestRequest request = new RestRequest(accion, Method.POST);
                request.RequestFormat = DataFormat.Json;
               // var json = request.JsonSerializer.Serialize(datos);
                request.AddJsonBody(datos);
                IRestResponse response = client.Execute(request);
                //return new JsonDeserializer().Deserialize<NRespuesta>(response);
                return response;
            }
            return null;
        }

        public string ConsultaDni( string dni)
        {
            //RestClient client = new RestClient(ServerWeb);
            //client.Timeout = -1;
            //RestRequest request = new RestRequest(accion, Method.POST);
            //request.RequestFormat = DataFormat.Json;
            //// var json = request.JsonSerializer.Serialize(datos);
            //request.AddJsonBody(datos);
            //IRestResponse response = client.Execute(request);
            ////return new JsonDeserializer().Deserialize<NRespuesta>(response);
            //return response;


            string accion = "BuscarDni.php?dni=" + dni;
            RestClient client = new RestClient(RutaApiReniec);
            client.Timeout = -1;
            RestRequest request = new RestRequest(accion, Method.POST);
            request.RequestFormat = DataFormat.Json;
            // var json = request.JsonSerializer.Serialize(datos);
          //  request.AddJsonBody(datos);
            IRestResponse response = client.Execute(request);
            //return new JsonDeserializer().Deserialize<NRespuesta>(response);
            return response.Content.ToString();
           // return response;

        }
    }
}
