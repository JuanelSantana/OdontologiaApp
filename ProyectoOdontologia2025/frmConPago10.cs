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
    public partial class frmConPago10 : BaseForm
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");

        public frmConPago10()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmConPago10_Load(object sender, EventArgs e)
        {
            RefrescarTabla("Select * from Pagos");
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

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            if (rdbIdPago.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where IdPago like '%" + txtCriterio.Text + "%'");
            }

            if (rdbIdCotizacion.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where IdCotizacion like '%" + txtCriterio.Text + "%'");
            }

            if (rdbIdCedula.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where Cedula like '%" + txtCriterio.Text + "%'");
            }

            if (rdbFormaPago.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where FormaPago like '%" + txtCriterio.Text + "%'");
            }

            if (rdbFecha.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where Fecha like '%" + txtCriterio.Text + "%'");
            }

            if (rdbMontoPago.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where MontoPago like '%" + txtCriterio.Text + "%'");
            }

            if (rdbIdEmpleado.Checked == true)
            {
                RefrescarTabla("Select * from Pagos Where IdEmpleado like '%" + txtCriterio.Text + "%'");
            }
        }
    }
}
