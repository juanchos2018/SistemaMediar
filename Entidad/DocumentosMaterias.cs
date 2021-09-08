using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
     public  class DocumentosMaterias
    {
        ClsConexion sql = new ClsConexion();            

        public int IdMateriaDocumentoMateria { get; set; }
        public int IdMateria { get; set; }
        public int IdEmpresa { get; set; }
        public string NombreDocumento  { get; set; }
        public string RutaDocumento   { get; set; }
        public string TipoDocumento   { get; set; }

        public void Agregar(DocumentosMaterias d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdMateria", "@IdEmpresa", "@NombreDocumento", "@RutaDocumento", "@TipoDocumento" };
            SqlDbType[] tipoParametro = new SqlDbType[] { SqlDbType.Int, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar };
            object[] valores = { d.IdMateria, d.IdEmpresa, d.NombreDocumento,d.RutaDocumento,d.TipoDocumento };
            sql.EjecutarProcedure("Str_DocumentosMaterias_I", parametros, valores, tipoParametro, 5);

        }
        public DataTable Lista(ClsMateria d)
        {//modificar eesto we
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int };
            object[] valores = { d.IdEmpresa };
            return sql.ProcedureSQL("Str_Materia_S", parametros, valores, tipoParametro, 1).Tables[0];
        }
    }
}
