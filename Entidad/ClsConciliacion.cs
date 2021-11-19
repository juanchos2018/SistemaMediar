using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
  public  class ClsConciliacion
    {
        public int IdConciliacion { get; set; }

        public int IdEmpresa { get; set; }
        public string DniCliente { get; set; }
        public string Titulo { get; set; }
        public string Materia { get; set; }
        public int IdCaso { get; set; }
        public string Desrcipcioncaso { get; set; }
        public decimal Tarfia { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string Estado { get; set; }

        ClsConexion sql = new ClsConexion();

        public void Agregar(ClsConciliacion d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa", "@DniCliente", "@Titulo", "@Materia", "@IdCaso", "@Desrcipcioncaso", "@Tarfia", "@FechaCreacion", "@FechaActualizacion", "@Estado" };
            SqlDbType[] tipoParametro = new SqlDbType[] { SqlDbType.Int,SqlDbType.VarChar,
                                        SqlDbType.VarChar, SqlDbType.VarChar,
                                        SqlDbType.Int, SqlDbType.VarChar, SqlDbType.Decimal,
                                        SqlDbType.DateTime, SqlDbType.DateTime, SqlDbType.VarChar };
            object[] valores = { d.IdEmpresa, d.DniCliente, d.Titulo, d.Materia, d.IdCaso, d.Desrcipcioncaso, d.Tarfia, FechaCreacion, d.FechaActualizacion, d.Estado };
            sql.EjecutarProcedure("Str_Conciliacion_I", parametros, valores, tipoParametro, 10);
        }
        public int AddReturId(ClsConciliacion d)
        {
          sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
          
          return  sql.CreateNewMember(d.IdEmpresa, d.DniCliente, d.Titulo, d.Materia, d.IdCaso, d.Desrcipcioncaso, d.Tarfia, FechaCreacion, d.FechaActualizacion, d.Estado);
        }
        public DataTable Lista(ClsConciliacion d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa", };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int };
            object[] valores = { d.IdEmpresa };
            return sql.ProcedureSQL("Str_Conciliacion_S", parametros, valores, tipoParametro, 1).Tables[0];
        }
        public DataTable TotalConciliacion(ClsConciliacion d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int };
            object[] valores = { d.IdEmpresa };
            return sql.ProcedureSQL("TotalCasos", parametros, valores, tipoParametro, 1).Tables[0];
        }

        public void Actualizar(ClsConciliacion d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa", "@IdConciliacion", "@Estado" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int, SqlDbType.Int, SqlDbType.VarChar };
            object[] valores = { d.IdEmpresa, d.IdConciliacion, d.Estado };
            sql.ProcedureSQL("Str_Conciliacion_U", parametros, valores, tipoParametro, 3);
        }

        public DataTable ListaDocCliente(ClsConciliacion d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa", "@DniCliente" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int,SqlDbType.VarChar };
            object[] valores = { d.IdEmpresa,d.DniCliente };
            return sql.ProcedureSQL("Str_ConciliacionCliente_S", parametros, valores, tipoParametro, 2).Tables[0];
        }
    }
}
