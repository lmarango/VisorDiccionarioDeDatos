using Con_DiccDeDatos.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Con_DiccDeDatos
{
    public partial class FormSesion : Form
    {
        public FormSesion()
        {
            InitializeComponent();
        }

        #region Atributos
        /// <summary>
        /// atributo que se utiliza para asigna una cadena para retornar una seleción
        /// </summary>
        string atrOpcionElegida;
        /// <summary>
        /// Objeto de la clase clsDicDatos
        /// </summary>
        clsDicDatos objDicDato = new clsDicDatos();
        #endregion
        #region Eventos
        /// <summary>
        /// Evento que genera o nó una conexión a la base de datos.
        /// </summary>
        /// <param name="sender">Objeto recibido de la acción en el formulario.</param>
        /// <param name="e">Clase base que contiene los eventos</param>
        private void btnIniSesion_Click(object sender, EventArgs e)
        {
            String varUsuario = txtUsuario.Text;
            String varContrasena = txtContrasena.Text;
            objDicDato.IniciarSesion(varUsuario, varContrasena); 
        }
        /// <summary>
        /// Evento que permite seleccionar y accionar una consulta principal. Nota: Alguna de ellas tienen subopciones al seleccionar.
        /// </summary>
        /// <param name="sender">Objeto recibido de la cción del formulario.</param>
        /// <param name="e">Clase base que contiene los eventos.</param>
        private void cbConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSel2.Visible = false;
            cbSelOpc2.Visible = false;
            lblSel3.Visible = false;
            cbSelOpc3.Visible = false;
            lblSelOpc3.Visible = false;
            if (objDicDato.GetConexion() != null)
            {
                if (cbConsulta.SelectedIndex == 0)
                {
                    DataSet varDatos = new DataSet();
                    varDatos = objDicDato.ConsRestriciones();
                    dgvConsulta.DataSource = varDatos;
                    dgvConsulta.DataMember = "Restricciones";
                }
                if (cbConsulta.SelectedIndex == 1)
                {
                    lblSel2.Visible = true;
                    cbSelOpc2.Visible = true;
                }
                if (cbConsulta.SelectedIndex == 2)
                {
                    lblSel3.Visible = true;
                    cbSelOpc3.Visible = true;
                    ObtenerTablas();
                    cbSelOpc3.DisplayMember = "Tablas";
                }
            }
            else
            {
                MessageBox.Show("Para acceder a las consultas debe iniciar sesión primero.\nPor favor haga conexión e intente nuevamente.");
            }
        }
        /// <summary>
        /// Evento que permite seleccionar una accion del segundo item de la consulta principal
        /// </summary>
        /// <param name="sender">Objeto recibido de la acción del formulario</param>
        /// <param name="e">Clas base que contiene los eventos</param>
        private void cbSelOpc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbSelOpc2.SelectedIndex;

            switch (i)
            {
                case 0:
                    atrOpcionElegida = "TABLE";
                    break;

                case 1:
                    atrOpcionElegida = "INDEX";
                    break;

                case 2:
                    atrOpcionElegida = "VIEW";
                    break;

                case 3:
                    atrOpcionElegida = "PROCEDURE";
                    break;

                case 4:
                    atrOpcionElegida = "FUNCTION";
                    break;

                case 5:
                    atrOpcionElegida = "TRIGGER";
                    break;

                case 6:
                    atrOpcionElegida = "PACKAGE";
                    break;

                default:
                    MessageBox.Show("lA OPCION SELECIONADA NO ESTA DISPONIBLE.");
                    atrOpcionElegida = null;
                    break;
            }

            DataSet varDatos = new DataSet();
            varDatos = objDicDato.ConsObjUsuario(atrOpcionElegida);
            dgvConsulta.DataSource = varDatos;
            dgvConsulta.DataMember = atrOpcionElegida;
        }
        /// <summary>
        /// Evento que permite selecionar una acción del tercer item del menú principal.
        /// </summary>
        /// <param name="sender">Objeto recibido de la ación del formulario.</param>
        /// <param name="e">clase base que contiene los eventos.</param>
        private void cbSelOpc3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string varNomTabla = null;
            varNomTabla = cbSelOpc3.SelectedItem.ToString();
            lblSelOpc3.Text = "La tabla " + varNomTabla + " tiene " + objDicDato.ObtenerNumFilas(varNomTabla) + " filas.\nLa Información de las columnas es:";
            lblSelOpc3.Visible = true;
            DataSet varDatos = new DataSet();
            varDatos = objDicDato.ConsTabla(varNomTabla);
            dgvConsulta.DataSource = varDatos;
            dgvConsulta.DataMember = varNomTabla;
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Obtiene las tablas a las que tiene acceso el usuario en conexión y llena el combobox para listarlas por nombre
        /// </summary>
        private void ObtenerTablas()
        {
            //Limpiar el ComboBox
            cbSelOpc3.Items.Clear();
            //Instanciamos un data table y lo llenamos
            DataTable dt = new DataTable("Tabla");
            dt = objDicDato.ObtenerTablas();
            //Obtenemos el número de filas del DataTable
            DataRow vardr = dt.Rows[0];
            int Filas = dt.Rows.Count;
            //Declaramos una lista para insertar los nombres de cada una de las filas, que serán las tablas devueltas en la consulta
            List<string> varNombreTablas = new List<string>();
            //llenamos la lista
            for (int i = 0; i < Filas; i++)
            {
                varNombreTablas.Add(Convert.ToString(dt.Rows[i]["T_Nombre"]));
            }
            //Asignamos la lista al ComboBox
            this.cbSelOpc3.Text = "Tablas";
            this.cbSelOpc3.DisplayMember = "Tabla";
            this.cbSelOpc3.DataSource = varNombreTablas;
            
        }
        #endregion
    }
}
