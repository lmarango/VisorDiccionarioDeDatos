using Con_DiccDeDatos.Datos;
using System.Data;
using Oracle.DataAccess.Client;

namespace Con_DiccDeDatos.Logica
{
    class clsDicDatos
    {
        #region Atributos
        /// <summary>
        /// Objeto de la clase clsDatos
        /// </summary>
        clsDatos objDatos = new clsDatos();
        /// <summary>
        /// Atributo que indica si la cadena de conexión está o nó nula
        /// </summary>
        OracleConnection atrConexión = null;
        #endregion
        #region Métodos
        /// <summary>
        /// Inicia conexión recibiendo el usuario y contraseña en parámetros.
        /// </summary>
        /// <param name="prmUsuario">Usuario a hacer conexión</param>
        /// <param name="prmContrasena">contrasena para el usuario</param>
        /// <returns>verdadero si la conexión fue exitosa, falso de lo contrario. </returns>
        public bool IniciarSesion(string prmUsuario, string prmContrasena)
        {
            bool varEstado;
            varEstado = objDatos.IniciarSesion(prmUsuario, prmContrasena);
            return varEstado;
        }
        /// <summary>
        /// Consulta las restricciones del usuario en conexión
        /// </summary>
        /// <returns>DataSet con los datos obtenidos en la consulta.</returns>
        public DataSet ConsRestriciones()
        {
            DataSet varRestricciones = new DataSet();
            varRestricciones = objDatos.ConsRestriciones();
            return varRestricciones;
        }
        /// <summary>
        /// Consulta los objetos del usuario en conexión.
        /// </summary>
        /// <param name="prmObjeto">Nombre del objeto aconsultar.</param>
        /// <returns>DataSet con los datos obtenidos en la consulta.</returns>
        public DataSet ConsObjUsuario(string prmObjeto)
        {
            DataSet varObjetos = new DataSet();
            varObjetos = objDatos.ConsObjUsuario(prmObjeto);
            return varObjetos;
        }
        /// <summary>
        /// Consulta la información de las tablas del usuario en conexión.
        /// </summary>
        /// <param name="prmTabla">Nombre de la tablama consultar</param>
        /// <returns>DataSet con los tuplas obtenidas en la consulta.</returns>
        public DataSet ConsTabla(string prmTabla)
        {
            DataSet varDatos = new DataSet();
            varDatos = objDatos.ConsTabla(prmTabla);
            return varDatos;
        }
        #region Metodo Auxiliares
        /// <summary>
        /// Obtiene el listado de las tablas para el usaurio en conexión
        /// </summary>
        /// <returns>DataSet con los datos obtenidos en la consulta.</returns>
        public DataTable ObtenerTablas()
        {
            DataTable varTablas = new DataTable("Tabla");
            varTablas = objDatos.ObtenerTablas();
            return varTablas;
        }
        public string ObtenerNumFilas(string prmTabla)
        {
            string varFilas = "";
            varFilas = objDatos.ObtnerNumFilas(prmTabla);
            return varFilas;
        }
        #endregion
        #region Getters
        /// <summary>
        /// Retorna la conexión actual
        /// </summary>
        /// <returns>La conexion si se ha establecido una, de lo contrario null.</returns>
        public OracleConnection GetConexion()
        {
            atrConexión = objDatos.GetConexion();
            return atrConexión;
        }
        #endregion
        #endregion
    }
}
