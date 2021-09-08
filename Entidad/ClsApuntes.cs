using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
  public   class ClsApuntes
    {

        ClsConexion sql = new ClsConexion();


        public int IdApunte { get; set; }
        public int IdEmpresa { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Hora { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; }


        public void Agregar(ClsApuntes d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa", "@Titulo", "@Descripcion", "@FechaRegistro", "@Hora", "@Estado", "@Tipo" };
            SqlDbType[] tipoParametro = new SqlDbType[] { SqlDbType.Int, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.Date, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar };
            object[] valores = { d.IdEmpresa, d.Titulo, d.Descripcion, d.FechaRegistro, d.Hora, d.Estado, d.Titulo };
            sql.EjecutarProcedure("Str_Apuntes_I", parametros, valores, tipoParametro, 7);
        }

        public DataTable Lista(ClsApuntes d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa", "@fecha" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int, SqlDbType.DateTime };
            object[] valores = { d.IdEmpresa, d.FechaRegistro };
            return sql.ProcedureSQL("StrApuntes_S", parametros, valores, tipoParametro, 2).Tables[0];
        }

        public DataTable Lista1(ClsApuntes d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int };
            object[] valores = { d.IdEmpresa };
            return sql.ProcedureSQL("StrApuntes_SS", parametros, valores, tipoParametro, 1).Tables[0];
        }
    }
}
