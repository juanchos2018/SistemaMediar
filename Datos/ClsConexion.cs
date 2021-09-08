using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class ClsConexion
    {
        private string pc_Servidor;
        string pc_BaseDatos;
        string pc_Usuario;
        string pc_Contrasena;

        private SqlConnection po_Conexion = null/* TODO Change to default(_) if this is not a reference type */;
        private SqlDataAdapter po_Adaptador = null/* TODO Change to default(_) if this is not a reference type */;
        private SqlCommand po_Comando = null/* TODO Change to default(_) if this is not a reference type */;

        public void Asignar_Servidor(string aServidor, string aUsuario, string aContrasena)
        {
            pc_Servidor = aServidor;
            pc_Usuario = aUsuario;
            pc_Contrasena = aContrasena;
        }
        public void Asignar_Servidor(string aServidor, string aUsuario, string aContrasena, string aBaseDatos)
        {
            pc_Servidor = aServidor;
            pc_Usuario = aUsuario;
            pc_Contrasena = aContrasena;
            pc_BaseDatos = aBaseDatos;
        }

        private bool Conectar_BD()
        {
            string estadoconex = "";

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-PE");
            try
            {
                if (po_Conexion == null)
                {
                    //DESKTOP-PEKLP69\MSSQLSERVER01
                    // po_Conexion = new SqlConnection("Data Source=DESKTOP-PEKLP69\\SSQLSERVER01; Initial Catalog=CON2056568395121; Integrated Security=True;UID=sa; PWD=123456;");
                    po_Conexion = new SqlConnection("Server=" + pc_Servidor + "; DataBase=" + pc_BaseDatos + ";UID=" + pc_Usuario + "; PWD=" + pc_Contrasena + ";");
                    //    po_Conexion = new SqlConnection("Server=DESKTOP-PEKLP69\\SSQLSERVER01; DataBase=master ;UID=sa; PWD=123456;");
                    po_Conexion.Open();
                    return true;
                }
                else if (po_Conexion.State.Equals(ConnectionState.Closed)) ;
                // estadoconex = "La Conexión Se encuentra Cerrada.";
                //MessageBox.Show("a Conexión Se encuentra Cerrada.");
                else
                    estadoconex = "La Conexión ya se encuentra abierta.";
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Datos Incorrectos: revise el ID de servidor y la contraseña de usuario");

                po_Conexion = null;
            }
            return false;
        }
        public DataSet EjecutarConsulta1(string Tabla)
        {
            DataSet ds = new DataSet();
            this.po_Adaptador = new SqlDataAdapter();
            this.po_Adaptador.SelectCommand = po_Comando;
            po_Adaptador.Fill(ds, Tabla);
            return ds;
        }
        public DataSet EjecutarConsulta(string Tabla, string SentenciaSQL)
        {
            DataSet ds = new DataSet();
            string Error;
            this.po_Comando = new SqlCommand();
            this.po_Comando.CommandType = CommandType.Text;
            this.po_Comando.CommandText = SentenciaSQL;
            this.po_Comando.CommandTimeout = 200;
            this.po_Adaptador = new SqlDataAdapter();

            if (Conectar_BD() == true)
            {
                po_Comando.Connection = po_Conexion;
                this.po_Adaptador.SelectCommand = po_Comando;
                //   cmd = new SqlCommand("SELECT COUNT(*) FROM emple", con);
                // TotalRecords = int.Parse(po_Comando.ExecuteScalar().ToString());

                try
                {
                    po_Adaptador.Fill(ds, Tabla);
                }
                catch (Exception EX)
                {
                    //   Error = ("Error en expresion!: " + EX.Message);
                    // MessageBox.Show("Error en expresion!: " + EX.Message);
                    return null/* TODO Change to default(_) if this is not a reference type */;
                }
                Desconectar_BD();
            }
            return ds;
        }
        public void Desconectar_BD()
        {
            if (!(po_Conexion == null))
            {
                if (po_Conexion.State.Equals(ConnectionState.Open))
                {
                    po_Conexion.Close();
                    po_Conexion = null;
                }
            }
        }
        public int CreateNewMember(int idempresa, string dnicliente, string titulo, string materia, int idcaso, string descrioncaso, decimal tarifa, DateTime fecha, DateTime fechamod, string estado)
        {
            // values 0 --> -99 are SQL reserved.
            int new_MEM_BASIC_ID = -1971;
            SqlConnection SQLconn = new SqlConnection("Server=" + pc_Servidor + "; DataBase=" + pc_BaseDatos + ";UID=" + pc_Usuario + "; PWD=" + pc_Contrasena + ";");
            SqlCommand cmd = new SqlCommand("Str_Conciliacion_II", SQLconn);

            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter outPutVal = new SqlParameter("@New_MEM_BASIC_ID", SqlDbType.Int);

            outPutVal.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outPutVal);
        
            cmd.Parameters.Add("@IdEmpresa", SqlDbType.Int).Value= idempresa;
            cmd.Parameters.Add("@DniCliente", SqlDbType.VarChar).Value = dnicliente;
            cmd.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = titulo;
            cmd.Parameters.Add("@Materia", SqlDbType.VarChar).Value = materia;
            cmd.Parameters.Add("@IdCaso", SqlDbType.Int).Value = idcaso;
            cmd.Parameters.Add("@Desrcipcioncaso", SqlDbType.VarChar).Value = descrioncaso;
            cmd.Parameters.Add("@Tarfia", SqlDbType.Decimal).Value = tarifa;
            cmd.Parameters.Add("@FechaCreacion", SqlDbType.DateTime).Value = fecha;
            cmd.Parameters.Add("@FechaActualizacion", SqlDbType.DateTime).Value = fechamod;
            cmd.Parameters.Add("@Estado", SqlDbType.VarChar).Value = estado;

            SQLconn.Open();
            cmd.ExecuteNonQuery();
            SQLconn.Close();
            if (outPutVal.Value != DBNull.Value) new_MEM_BASIC_ID = Convert.ToInt32(outPutVal.Value);
            return new_MEM_BASIC_ID;
        }
        public int ReturIdInser(int idempresa, string dnicliente,string titulo,string materia,int idcaso,string descrioncaso,decimal tarifa,DateTime fecha, DateTime fechamod, string estado)
        {

            po_Conexion = new SqlConnection("Server=" + pc_Servidor + "; DataBase=" + pc_BaseDatos + ";UID=" + pc_Usuario + "; PWD=" + pc_Contrasena + ";");
            //    po_Conexion = new SqlConnection("Server=DESKTOP-PEKLP69\\SSQLSERVER01; DataBase=master ;UID=sa; PWD=123456;");
           
            using (SqlCommand cmd = new SqlCommand("insert into Conciliacion (IdEmpresa,DniCliente,Titulo,Materia,IdCaso,Desrcipcioncaso,Tarfia,FechaCreacion,FechaActualizacion,Estado)   values(@IdEmpresa, @DniCliente, @Titulo, @Materia, @IdCaso, @Desrcipcioncaso, @Tarfia, @FechaCreacion, @FechaActualizacion, @Estado)", po_Conexion))
            {
                ///"@IdEmpresa", "@DniCliente", "@Titulo", "@Materia", "@IdCaso", "@Desrcipcioncaso", "@Tarfia", "@FechaCreacion", "@FechaActualizacion", "@Estado"
                cmd.Parameters.AddWithValue("@IdEmpresa", idempresa);
                cmd.Parameters.AddWithValue("@DniCliente", dnicliente);
                cmd.Parameters.AddWithValue("@Titulo", titulo);
                cmd.Parameters.AddWithValue("@Materia", materia);
                cmd.Parameters.AddWithValue("@IdCaso", idcaso);
                cmd.Parameters.AddWithValue("@Desrcipcioncaso", descrioncaso);
                cmd.Parameters.AddWithValue("@Tarfia", tarifa);
                cmd.Parameters.AddWithValue("@FechaCreacion", fecha);
                cmd.Parameters.AddWithValue("@FechaActualizacion", fechamod);
                cmd.Parameters.AddWithValue("@Estado", estado);

                po_Conexion.Open();

                int modified = (int)cmd.ExecuteScalar();

                if (po_Conexion.State == System.Data.ConnectionState.Open)
                    po_Conexion.Close();

                return modified;
            }
        }
        public void EjecutarProcedure(string TxtProc, string[] sParametro, object[] vParametro, SqlDbType[] typeParam, int nParametro)
        {
            DataSet ds = new DataSet();
            int Aind;
            SqlParameter @params;
            SqlCommand comandoProc = null/* TODO Change to default(_) if this is not a reference type */;
            comandoProc = new SqlCommand();
            comandoProc.CommandType = CommandType.StoredProcedure;
            comandoProc.CommandTimeout = 120;
            comandoProc.CommandText = TxtProc;
            object obj = new object();
            for (Aind = 1; Aind <= nParametro; Aind++)
            {
                @params = new SqlParameter(sParametro[Aind - 1].ToString(), typeParam[Aind - 1], 5000000);
                @params.Direction = ParameterDirection.Input;
                comandoProc.Parameters.Add(@params);
                if (SqlDbType.Date.Equals(typeParam[Aind - 1]) == true)
                {
                    if ((vParametro[Aind - 1] == null) == true)
                        comandoProc.Parameters[Aind - 1].Value = DBNull.Value;
                    else if (vParametro[Aind - 1].ToString() == "01/01/0001 12:00:00 a. m." | vParametro[Aind - 1].ToString() == "01/01/1900 12:00:00 a. m." | vParametro[Aind - 1].ToString() == "01/01/0001 12:00:00 a.m." | vParametro[Aind - 1].ToString() == "01/01/1900 12:00:00 a.m.")
                        comandoProc.Parameters[Aind - 1].Value = DBNull.Value;
                    else
                        comandoProc.Parameters[Aind - 1].Value = vParametro[Aind - 1];
                }
                else if (SqlDbType.DateTime.Equals(typeParam[Aind - 1]) == true)
                {
                    if ((vParametro[Aind - 1] == null) == true)
                        comandoProc.Parameters[Aind - 1].Value = DBNull.Value;
                    else if (vParametro[Aind - 1].ToString() == "01/01/0001 12:00:00 a. m." | vParametro[Aind - 1].ToString() == "01/01/1900 12:00:00 a. m." | vParametro[Aind - 1].ToString() == "01/01/0001 12:00:00 a.m." | vParametro[Aind - 1].ToString() == "01/01/1900 12:00:00 a.m.")
                        comandoProc.Parameters[Aind - 1].Value = DBNull.Value;
                    else
                        comandoProc.Parameters[Aind - 1].Value = vParametro[Aind - 1];
                }
                else if ((vParametro[Aind - 1] == null) == true)
                    comandoProc.Parameters[Aind - 1].Value = DBNull.Value;
                else
                    comandoProc.Parameters[Aind - 1].Value = vParametro[Aind - 1];
            }
            if (Conectar_BD() == true)
            {
                comandoProc.Connection = po_Conexion;
                try
                {
                    comandoProc.ExecuteNonQuery();
                }
                // obj = {0, "Se realizó con exito"}
                catch (SqlException EX)
                {
                       MessageBox.Show("Error en expresión!:" + EX.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Desconectar_BD();
            }
            else
            {

            }
            //  MessageBox.Show("La conexion ha");
        }
        public DataSet ProcedureSQL(string TxtProc, string[] sParametro, object[] vParametro, SqlDbType[] typeParam, int nParametro)
        {
            DataSet lo_ds = new DataSet();
            int Aind;
            SqlParameter lo_params;
            SqlCommand lo_comandoProc;
            lo_comandoProc = new SqlCommand();
            SqlDataAdapter po_Adaptador = new SqlDataAdapter();

            lo_comandoProc.CommandType = CommandType.StoredProcedure;
            lo_comandoProc.CommandTimeout = 120;
            lo_comandoProc.CommandText = TxtProc;

            for (Aind = 1; Aind <= nParametro; Aind++)
            {
                lo_params = new SqlParameter(sParametro[Aind - 1].ToString(), typeParam[Aind - 1], 5000000);
                               
                lo_params.Direction = ParameterDirection.Input;
                lo_comandoProc.Parameters.Add(lo_params);
                if (SqlDbType.Date.Equals(typeParam[Aind - 1]) == true)
                {
                    if ((vParametro[Aind - 1] == null) == true)
                        lo_comandoProc.Parameters[Aind - 1].Value = DBNull.Value;
                    else if (vParametro[Aind - 1].ToString() == "01/01/0001 12:00:00 a. m." | vParametro[Aind - 1].ToString() == "01/01/1900 12:00:00 a. m." || vParametro[Aind - 1].ToString() == "01/01/0001 12:00:00 a.m." || vParametro[Aind - 1].ToString() == "01/01/1900 12:00:00 a.m.")
                        lo_comandoProc.Parameters[Aind - 1].Value = DBNull.Value;
                    else
                        lo_comandoProc.Parameters[Aind - 1].Value = vParametro[Aind - 1];
                }
                else if (SqlDbType.DateTime.Equals(typeParam[Aind - 1]) == true)
                {
                    if ((vParametro[Aind - 1] == null) == true)
                        lo_comandoProc.Parameters[Aind - 1].Value = DBNull.Value;
                    else if (vParametro[Aind - 1].ToString() == "01/01/0001 12:00:00 a. m." | vParametro[Aind - 1].ToString() == "01/01/1900 12:00:00 a. m." || vParametro[Aind - 1].ToString() == "01/01/0001 12:00:00 a.m." || vParametro[Aind - 1].ToString() == "01/01/1900 12:00:00 a.m.")
                        lo_comandoProc.Parameters[Aind - 1].Value = DBNull.Value;
                    else
                        lo_comandoProc.Parameters[Aind - 1].Value = vParametro[Aind - 1];
                }
                else if ((vParametro[Aind - 1] == null) == true)
                    lo_comandoProc.Parameters[Aind - 1].Value = DBNull.Value;
                else
                    lo_comandoProc.Parameters[Aind - 1].Value = vParametro[Aind - 1];
            }
            if (Conectar_BD() == true)
            {
                lo_comandoProc.Connection = po_Conexion;
                po_Adaptador.SelectCommand = lo_comandoProc;
                try
                {
                    po_Adaptador.Fill(lo_ds, "T" + TxtProc);
                }
                catch (Exception EX)
                {
                     MessageBox.Show("Error en expresión!:" + EX.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                Desconectar_BD();
            }
            return lo_ds;
        }


        public int procedimiento_escalar(string TxtProc, object[] sParametro, object[] vParametro, SqlDbType[] typeParam, int nParametro)
        {
            int Aind;
            SqlParameter @params;
            SqlCommand comandoProc = null/* TODO Change to default(_) if this is not a reference type */;
            comandoProc = new SqlCommand();
            comandoProc.Connection = po_Conexion;
            comandoProc.CommandType = CommandType.StoredProcedure;
            comandoProc.CommandTimeout = 120;
            comandoProc.CommandText = TxtProc;
            for (Aind = 1; Aind <= nParametro; Aind++)
            {
                @params = new SqlParameter(sParametro[Aind - 1].ToString(), typeParam[Aind - 1], 250);
             
                @params.Direction = ParameterDirection.Input;
                comandoProc.Parameters.Add(@params);
                if ((vParametro[Aind - 1]==null) == true)
                    comandoProc.Parameters[Aind - 1].Value = DBNull.Value;
                else
                    comandoProc.Parameters[Aind - 1].Value = vParametro[Aind - 1];
            }
            @params = new SqlParameter("@Resultado", SqlDbType.Int, 250);
            @params.Direction = ParameterDirection.Output;
            comandoProc.Parameters.Add(@params);

            if (Conectar_BD() == true)
            {
                comandoProc.Connection = po_Conexion;
                try
                {
                    comandoProc.ExecuteNonQuery();
                }
                catch (SqlException EX)
                {
                   MessageBox.Show("Error en expresión!:" + EX.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Desconectar_BD();
            }
            else
            {
                MessageBox.Show("La conexion ha fallado!!");
            }
               
            return Convert.ToInt32(comandoProc.Parameters["@Resultado"].Value);
        }


    }
}
