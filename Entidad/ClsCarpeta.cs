using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ClsCarpeta
    {
        public string NombreCarpeta { get; set; }
        public int IdEmpresa { get; set; }

        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; }

        ClsConexion sql = new ClsConexion();

        public void Agregar(ClsCarpeta d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");

            string[] parametros = new[] { "@NombreCarpeta", "@IdEmpresa", "@Fecha", "@Cantidad", "@Estado" };
            SqlDbType[] tipoParametro = new SqlDbType[] { SqlDbType.VarChar, SqlDbType.Int, SqlDbType.DateTime, SqlDbType.Int, SqlDbType.VarChar };
            object[] valores = { d.NombreCarpeta, d.IdEmpresa, d.Fecha, d.Cantidad, d.Estado };

            sql.EjecutarProcedure("Str_Carpeta_I", parametros, valores, tipoParametro, 5);

        }

        public DataTable Lista(ClsCarpeta d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int };
            object[] valores = { d.IdEmpresa };
            return sql.ProcedureSQL("Str_Carpeta_S", parametros, valores, tipoParametro, 1).Tables[0];


        }


    }
}
