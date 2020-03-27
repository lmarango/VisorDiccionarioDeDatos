using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Con_DiccDeDatos.Datos
{
    class clsDatos
    {
        #region Atributos
        /// <summary>
        /// Atributo que define el usuario que se va hacer conexión con la base de datos.
        /// </summary>
        string atrUser;
        /// <summary>
        /// Atributo que define la contraseña para el usuario descrito en <param>atrUser</param>
        /// </summary>
        string atrContrasena;
        /// <summary>
        /// Atributo que define la cadena de conecctió, debe ser asginada en un método de conexión.
        /// </summary>
        OracleConnection atrConexion = null;
        #endregion
        #region Metodos
        /// <summary>
        /// Metodo que inicia sesion (conecta) con la base de datos utilizando dos parámetros
        /// </summary>
        /// <param name="prmUsuario">string que define el usuario.</param>
        /// <param name="prmContrasena">string que define la contrasena del usuario.</param>
        /// <returns></returns>
        /// 
        public bool IniciarSesion(string prmUsuario, string prmContrasena)
        {
            atrConexion = new OracleConnection(@"Data Source=LOCALHOST;User ID=" + prmUsuario + ";Password=" + prmContrasena);
            try
            {
                atrConexion.Open();
                if (atrConexion.State == ConnectionState.Open)
                {
                    atrConexion.Close();
                }
                atrUser = prmUsuario;
                atrContrasena = prmContrasena;
                MessageBox.Show("Conexión Exitosa.");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de Conexión. Compruebe si digito correctamente en los campos.");
                return false;
            }
        }
        /// <summary>
        /// Consulta las restricciones usando procedimientos almacenados para el usuario.
        /// </summary>
        /// <returns>n-tuplas en tipo DataSet</returns>
        public DataSet ConsRestriciones()
        {
            try
            {
                atrConexion.Open();
                OracleCommand varComando = new OracleCommand(atrUser + ".CONSRESUSUARIO", atrConexion);
                varComando.Parameters.Add("O_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                varComando.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter varda = new OracleDataAdapter(varComando);
                DataSet vards = new DataSet();
                varda.Fill(vards, "Restricciones");
                return vards;
            }
            finally
            {
                if (atrConexion.State == ConnectionState.Open)
                {
                    atrConexion.Close();
                }
            }
        }
        /// <summary>
        /// Consulta los objetos del usuario en conexión usando procedimientos almacenados
        /// </summary>
        /// <param name="prmObjeto"></param>
        /// <returns></returns>
        public DataSet ConsObjUsuario(string prmObjeto)
        {
            try
            {
                atrConexion.Open();
                OracleCommand varComando = new OracleCommand(atrUser + ".CONSOBJUSUARIO", atrConexion);
                varComando.Parameters.Add("prmObjeto", OracleDbType.Varchar2, 256, prmObjeto, ParameterDirection.Input);
                varComando.Parameters.Add("o_cursor", OracleDbType.RefCursor, ParameterDirection.Output);
                varComando.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter varda = new OracleDataAdapter(varComando);
                DataSet vards = new DataSet();
                varda.Fill(vards, prmObjeto);
                return vards;
            }
            finally
            {
                if (atrConexion.State == ConnectionState.Open)
                {
                    atrConexion.Close();
                }
            }
        }
        /// <summary>
        /// Consulta las tablas para el usuario en conexión usando procedimientos almacenados.
        /// </summary>
        /// <param name="prmTabla">Nombre de la tabla a consular</param>
        /// <returns>DataSet con la consulta recuperada de la base de datos.</returns>
        public DataSet ConsTabla(string prmTabla)
        {
            try
            {
                atrConexion.Open();
                OracleCommand varComando = new OracleCommand(atrUser + ".INF_COLUMNS", atrConexion);
                varComando.Parameters.Add("prmTabla", OracleDbType.Varchar2, 256, prmTabla, ParameterDirection.Input);
                varComando.Parameters.Add("o_cursor", OracleDbType.RefCursor, ParameterDirection.Output);
                varComando.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter varda = new OracleDataAdapter(varComando);
                DataSet vards = new DataSet();
                varda.Fill(vards, prmTabla);
                return vards;
            }
            finally 
            {
                if (atrConexion.State == ConnectionState.Open)
                {
                    atrConexion.Close();
                }
            }
        }
        #region Metodo Auxiliares
        /// <summary>
        /// Obtiene las tablas para el usuario en conexión usando procedimientos almacenados
        /// </summary>
        /// <returns>DataSet con los datos obtenido en la consulta.</returns>
        public DataTable ObtenerTablas()
        {
            try
            {
                atrConexion.Open();
                OracleCommand varComando = new OracleCommand(atrUser + ".CONSTABLAS", atrConexion);
                varComando.Parameters.Add("o_cursor", OracleDbType.RefCursor, ParameterDirection.Output);
                varComando.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter varda = new OracleDataAdapter(varComando);
                DataTable vards = new DataTable("Tabla");
                varda.Fill(vards);
                return vards;
            }
            finally
            {
                if(atrConexion.State == ConnectionState.Open)
                {
                    atrConexion.Close();
                }
            }
        }
        public string ObtnerNumFilas(string prmTabla)
        {
            string varFilas;
            try
            {
                atrConexion.Open();
                OracleCommand varComando = new OracleCommand(atrUser + ".NUM_ROWS", atrConexion);
                varComando.CommandType = CommandType.StoredProcedure;

                varComando.Parameters.Add("prmNombre", OracleDbType.Varchar2, 256, prmTabla, ParameterDirection.Input);
                varComando.Parameters.Add("vFilas", OracleDbType.Decimal).Direction = ParameterDirection.Output;

                varComando.ExecuteNonQuery();
                varFilas = varComando.Parameters["vFilas"].Value.ToString();
                return varFilas;
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                if (atrConexion.State == ConnectionState.Open)
                {
                    atrConexion.Close();
                }
            }
        }
        #endregion
        #region Getters
        /// <summary>
        /// Retorna el estado de la conexión
        /// </summary>
        /// <returns>Conexión si está establecida o nula si ho se ha hecho una conexión previa.</returns>
        public OracleConnection GetConexion()
        {
            return atrConexion;
        }
        #endregion
        #endregion
    }
}
