using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public class ClsDocumetoConciliacion
    {
        ClsConexion sql = new ClsConexion();

        public int IdConciliacion { get; set; }
        public string dniCliente { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificaion { get; set; }
        public string TipoArchivo { get; set; }
        public string NombreArchivo { get; set; }
        public string RutaArchivo { get; set; }


        public void Agregar(ClsDocumetoConciliacion d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdConciliacion", "@dniCliente", "@IdEmpresa", "@FechaRegistro", "@FechaModificaion", "@TipoArchivo", "@NombreArchivo", "@RutaArchivo" };
            SqlDbType[] tipoParametro = new SqlDbType[] { SqlDbType.Int, SqlDbType.VarChar, SqlDbType.Int, SqlDbType.DateTime, SqlDbType.DateTime, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar };
            object[] valores = { d.IdConciliacion, d.dniCliente, d.IdEmpresa, d.FechaRegistro, d.FechaModificaion, d.TipoArchivo, d.NombreArchivo, d.RutaArchivo };

            sql.EjecutarProcedure("Str_DocumentosConciliacion_I", parametros, valores, tipoParametro, 8);
        }

        public DataTable Lista(ClsDocumetoConciliacion d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa", "@idConciliacion" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int, SqlDbType.Int };
            object[] valores = { d.IdEmpresa, d.IdConciliacion };
            return sql.ProcedureSQL("Str_DocumentosConciliacion_S", parametros, valores, tipoParametro, 2).Tables[0];
        }

        public DataTable ListaDoc(ClsDocumetoConciliacion d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa", "@DniCliente", "@idConciliacion", };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int,SqlDbType.VarChar, SqlDbType.Int };
            object[] valores = { d.IdEmpresa, d.dniCliente, d.IdConciliacion };
            return sql.ProcedureSQL("Str_DocumentosConciliacionCliente_S", parametros, valores, tipoParametro, 3).Tables[0];
        }
    }
}
