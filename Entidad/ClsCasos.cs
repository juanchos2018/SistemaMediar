using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ClsCasos
    {
        public int IdCaso { get; set; }
        public int IdEmpresa { get; set; }
        public int IdMateria { get; set; }
        public string Descripcion { get; set; }

        ClsConexion sql = new ClsConexion();

        public DataTable Lista(ClsCasos d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa", "@IdMateria" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int, SqlDbType.Int };
            object[] valores = { d.IdEmpresa, d.IdMateria };
            return sql.ProcedureSQL("Str_Casos_S", parametros, valores, tipoParametro, 2).Tables[0];
        }

    }
}
