using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ClsCliente
    {
       ClsConexion sql = new ClsConexion();

        public int IdEmpresa { get; set; }
        public string DniCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }

        public string CelularCliente { get; set; }

        public string CorreoCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string Pais { get; set; }
        public string ProvinciaCliente { get; set; }
        public string CiudadCliente { get; set; }
        public string Estado { get; set; }


        public void Agregar(ClsCliente d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa", "@DniCliente", "@NombreCliente", "@ApellidoCliente", "@CelularCliente", "@CorreoCliente", "@DireccionCliente", "@PaisCliente", "@ProvinciaCliente", "@CiudadCliente" };
            SqlDbType[] tipoParametro = new SqlDbType[] { SqlDbType.Int, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar };
            object[] valores = { d.IdEmpresa, d.DniCliente, d.NombreCliente, d.ApellidoCliente, d.CelularCliente, d.CorreoCliente, d.DireccionCliente, d.Pais, d.ProvinciaCliente, d.CiudadCliente };
            sql.EjecutarProcedure("Str_Cliente_I", parametros, valores, tipoParametro, 10);

        }
        public DataTable Lista(ClsCliente d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int };
            object[] valores = { d.IdEmpresa };
            return sql.ProcedureSQL("Str_Cliente_S", parametros, valores, tipoParametro, 1).Tables[0];
        }

        public DataTable Lista2(ClsCliente d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int };
            object[] valores = { d.IdEmpresa };
            return sql.ProcedureSQL("Str_Cliente_SS", parametros, valores, tipoParametro, 1).Tables[0];
        }


        public DataTable Lista1(ClsCliente d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int };
            object[] valores = { d.IdEmpresa };
            return sql.ProcedureSQL("Str_Cliente_S1", parametros, valores, tipoParametro, 1).Tables[0];

        }

        public DataTable TotalCliente(ClsCliente d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int };
            object[] valores = { d.IdEmpresa };
            return sql.ProcedureSQL("TotalClientes", parametros, valores, tipoParametro, 1).Tables[0];

        }


        public bool Existe_Cliente(ClsCliente d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            object[] parametros = new[] { "@Dnicliente" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.VarChar };
            object[] valores = new[] { d.DniCliente };
            int resultado;
            bool bandera = false;
            resultado = sql.procedimiento_escalar("Existe_Cliente", parametros, valores, tipoParametro, 1);
            if (resultado == 1)
                bandera = true;
            else
                bandera = false;
            return bandera;        
        }
        public DataTable Lista_nombre()
        {
            return sql.EjecutarConsulta("d", " select Nombre from cliente where ISNULL(estado,'V')='V' ").Tables[0];
                      
        }
        public ClsCliente Registro(ClsCliente d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@Dnicliente" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.VarChar };
            object[] valores = new[] { d.DniCliente };
            DataTable dt = new DataTable();
            dt = sql.ProcedureSQL("Cliente_SS", parametros, valores, tipoParametro, 1).Tables[0];
            if (dt.Rows.Count > 0)
            {
                d.DniCliente =   dt.Rows[0]["DniCliente"].ToString();
                d.NombreCliente = dt.Rows[0]["NombreCliente"].ToString();
                d.ApellidoCliente =  dt.Rows[0]["ApellidoCliente"].ToString();
                d.CelularCliente = dt.Rows[0]["CelularCliente"].ToString();
                d.CorreoCliente = dt.Rows[0]["CorreoCliente"].ToString();
                d.DireccionCliente = dt.Rows[0]["DireccionCliente"].ToString();
                d.Pais =  dt.Rows[0]["PaisCliente"].ToString();
            }
            else
            {
                d.DniCliente = null;
                d.NombreCliente = null;
                d.ApellidoCliente = null;
                d.CelularCliente = null;
                d.CorreoCliente = null;
                d.DireccionCliente = null;
                d.Pais = null;             
                             
            }
            return d;
        }


        public void Actualizar(ClsCliente d)
        {
            sql.Asignar_Servidor("WIN10X64-121120", "sa", "123456", "BdFiles");
            string[] parametros = new[] { "@IdEmpresa", "@DniCliente", "@Nombre", "@Apellido", "@Celular", "@Direccion", "@Correo" };
            SqlDbType[] tipoParametro = new[] { SqlDbType.Int, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar };
            object[] valores = { d.IdEmpresa, d.DniCliente, d.NombreCliente,d.ApellidoCliente,d.CelularCliente,d.DireccionCliente,d.CorreoCliente };
            sql.ProcedureSQL("Str_Cliente_U", parametros, valores, tipoParametro, 7);

        }

    }
}
