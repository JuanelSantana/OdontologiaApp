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
    public partial class frmConCoti09 : BaseForm
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");

        public frmConCoti09()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void frmConCoti09_Load(object sender, EventArgs e)
        {
            RefrescarTabla("Select * from Cotizaciones");
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
            if (rdbIdCotizacion.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where IdCotizacion like '%" + txtCriterio.Text + "%'");
            }

            if (rdbIdDiagnostico.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where IdDiagnostico like '%" + txtCriterio.Text + "%'");
            }

            if (rdbIdCedula.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where Cedula like '%" + txtCriterio.Text + "%'");
            }

            if (rdbMonto.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where Monto like '%" + txtCriterio.Text + "%'");
            }

            if (rdbIdEmpleado.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where IdEmpleado like '%" + txtCriterio.Text + "%'");
            }

            if (rdbDescipcion.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where Descripcion like '%" + txtCriterio.Text + "%'");
            }

            if (rdbCantidad.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where Cantidad like '%" + txtCriterio.Text + "%'");
            }

            if (rdbBalance.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where Balance like '%" + txtCriterio.Text + "%'");
            }

            if (rdbEstado.Checked == true)
            {
                RefrescarTabla("Select * from Cotizaciones Where Estado like '%" + txtCriterio.Text + "%'");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
