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
    public partial class frmConDiag03 : BaseForm
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");

        public frmConDiag03()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void frmConDiag03_Load(object sender, EventArgs e)
        {
            RefrescarTabla("Select * from Diagnostico");
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
            if (rdbIdDiagnostico.Checked == true)
            {
                RefrescarTabla("Select * from Diagnostico Where IdDiagnostico like '%" + txtCriterio.Text + "%'");
            }

            if (rdbIdEvaluaion.Checked == true)
            {
                RefrescarTabla("Select * from Diagnostico Where IdEvaluacion like '%" + txtCriterio.Text + "%'");
            }

            if (rdbIdDoctor.Checked == true)
            {
                RefrescarTabla("Select * from Diagnostico Where IdDoctor like '%" + txtCriterio.Text + "%'");
            }

            if (rdbIdCedula.Checked == true)
            {
                RefrescarTabla("Select * from Diagnostico Where Cedula like '%" + txtCriterio.Text + "%'");
            }

            if (rdbDescDiag.Checked == true)
            {
                RefrescarTabla("Select * from Diagnostico Where DescripcionDiagnostico like '%" + txtCriterio.Text + "%'");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
