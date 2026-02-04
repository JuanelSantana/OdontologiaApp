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
    public partial class frmConEval08 : BaseForm
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");
        public frmConEval08()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void frmConEval08_Load(object sender, EventArgs e)
        {
            RefrescarTabla("Select * from Evaluaciones");
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
            if (rdbIdEvaluacion.Checked == true)
            {
                RefrescarTabla("Select * from Evaluaciones Where IdEvaluacion like '%" + txtCriterio.Text + "%'");
            }

            if (rdbIdDoctor.Checked == true)
            {
                RefrescarTabla("Select * from Evaluaciones Where IdDoctor like '%" + txtCriterio.Text + "%'");
            }

            if (rdbFecha.Checked == true)
            {
                RefrescarTabla("Select * from Evaluaciones Where FechaEvaluacion like '%" + txtCriterio.Text + "%'");
            }

            if (rdbIdCedula.Checked == true)
            {
                RefrescarTabla("Select * from Evaluaciones Where Cedula like '%" + txtCriterio.Text + "%'");
            }

            if (rdbDescripcion.Checked == true)
            {
                RefrescarTabla("Select * from Evaluaciones Where Descripcion like '%" + txtCriterio.Text + "%'");
            }

            if (rdbCuadrante.Checked == true)
            {
                RefrescarTabla("Select * from Evaluaciones Where Cuadrante like '%" + txtCriterio.Text + "%'");
            }

            if (rdbObservacion.Checked == true)
            {
                RefrescarTabla("Select * from Evaluaciones Where Observacion like '%" + txtCriterio.Text + "%'");
            }
        }
    }
}
