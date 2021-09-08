using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ClsMateria
    {
        ClsConexion sql = new ClsConexion();

        public int IdEmpresa { get; set; }
        public int IdMateria { get; set; }

        public string NombreMateria { get; set; }
        public int idcarpeta { get; set; }

        public void Agregar(ClsMateria d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa", "@NombreMateria", "@idcarpeta" };
            SqlDbType[] tipoParametro = new SqlDbType[] { SqlDbType.VarChar, SqlDbType.Int };
            object[] valores = { d.IdEmpresa, d.NombreMateria, d.idcarpeta };
            sql.EjecutarProcedure("Str_Materia_I", parametros, valores, tipoParametro, 3);


        }
        public DataTable Lista(ClsMateria d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int };
            object[] valores = { d.IdEmpresa };
            return sql.ProcedureSQL("Str_Materia_S", parametros, valores, tipoParametro, 1).Tables[0];
        }
    }
}
