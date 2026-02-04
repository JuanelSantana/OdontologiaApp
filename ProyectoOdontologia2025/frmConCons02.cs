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
    public partial class frmConCons02 : BaseForm
    {

        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");
        public frmConCons02()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            if (rdbIdConsulta.Checked == true)
            {
                RefrescarTabla("Select * from Consultas Where IdConsulta like '%" + txtCriterio.Text + "%'");
            }

            if (rdbMotivo.Checked == true)
            {
                RefrescarTabla("Select * from Consultas Where Motivo like '%" + txtCriterio.Text + "%'");
            }

            if (rdbCedula.Checked == true)
            {
                RefrescarTabla("Select * from Consultas Where Cedula like '%" + txtCriterio.Text + "%'");
            }

            if (rdbFecha.Checked == true)
            {
                RefrescarTabla("Select * from Consultas Where Fecha like '%" + txtCriterio.Text + "%'");
            }

            if (rdbIdDoctor.Checked == true)
            {
                RefrescarTabla("Select * from Consultas Where IdDoctor like '%" + txtCriterio.Text + "%'");
            }
        }

        private void frmConCons02_Load(object sender, EventArgs e)
        {
            RefrescarTabla("Select * from Consultas");
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
    }
}
