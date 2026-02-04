using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOdontologia2025
{

    public partial class frmConEmpl07 : BaseForm
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");

        public frmConEmpl07()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void RefrescarTabla(String Parametro)
        {
            dataGridView1.DataSource = null; //Con esta linea le estoy diciendo al datagridview que quite todos los registros que haya en el mismo 

            try //Si hacemos la captura de error, el programa no explota si hay un error
            {
                conexion.Open(); //abro la conexion
                DataTable datos = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(Parametro, conexion);
                adaptador.Fill(datos);
                BindingSource fuentedatos = new BindingSource();
                fuentedatos.DataSource = datos;
                dataGridView1.DataSource = fuentedatos;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                conexion.Close();
            }

        }

        private void frmConEmpl07_Load(object sender, EventArgs e)
        {
            RefrescarTabla("Select * from Empleados");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rdbIdEmpleado.Checked == true)
            {
                RefrescarTabla("Select * from Empleados Where IdEmpleado like '%" + txtCriterio.Text + "%'");
            }

            if (rdbNombre.Checked == true)
            {
                RefrescarTabla("Select * from Empleados Where Nombre like '%" + txtCriterio.Text + "%'");
            }

            if (rdbApellido.Checked == true)
            {
                RefrescarTabla("Select * from Empleados Where Apellido like '%" + txtCriterio.Text + "%'");
            }

            if (rdbDireccion.Checked == true)
            {
                RefrescarTabla("Select * from Empleados Where Direccion like '%" + txtCriterio.Text + "%'");
            }

            if (rdbTel.Checked == true)
            {
                RefrescarTabla("Select * from Empleados Where Telefono like '%" + txtCriterio.Text + "%'");
            }

            if (rdbCargo.Checked == true)
            {
                RefrescarTabla("Select * from Empleados Where Cargo like '%" + txtCriterio.Text + "%'");
            }
        }
    }
}
