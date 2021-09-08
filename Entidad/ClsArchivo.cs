using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ClsArchivo
    {
       ClsConexion sql = new ClsConexion();

        public int IdCarpeta { get; set; }
        public int IdEmpresa { get; set; }
        public string NombreArchivo { get; set; }
        public string Tipo { get; set; }
        public long Size { get; set; }
        public string Estado { get; set; }
        public string RutaServidor { get; set; }
        public DateTime FechaRegistro { get; set; }

        public void Agregar(ClsArchivo d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");

            string[] parametros = new[] { "@IdCarpeta", "@IdEmpresa", "@NombreArchivo", "@Tipo", "@Size", "@Estado", "@RutaServidor", "@FechaRegistro" };
            SqlDbType[] tipoParametro = new SqlDbType[] { SqlDbType.Int, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.VarChar,SqlDbType.Int, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.Date };
            object[] valores = { d.IdCarpeta, d.IdEmpresa, d.NombreArchivo, d.Tipo,d.Size, d.Estado, d.RutaServidor, d.FechaRegistro };

            sql.EjecutarProcedure("Str_Archivo_I", parametros, valores, tipoParametro, 8);

        }

        public DataTable Lista(ClsArchivo d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa", "@IdCarpeta" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int, SqlDbType.Int };
            object[] valores = { d.IdEmpresa, d.IdCarpeta };
            return sql.ProcedureSQL("Str_Archivo_S", parametros, valores, tipoParametro, 2).Tables[0];


        }
        public DataTable ListaTodo(ClsArchivo d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int };
            object[] valores = { d.IdEmpresa };
            return sql.ProcedureSQL("Str_TodosDocumentos_S", parametros, valores, tipoParametro, 1).Tables[0];


        }
    }
}
