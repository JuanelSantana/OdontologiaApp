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
    public partial class frmConDoct06 : BaseForm
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");
        public frmConDoct06()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void frmConDoct06_Load(object sender, EventArgs e)
        {
            RefrescarTabla("Select * from Doctores");
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
            if (rdbIdDoctor.Checked == true)
            {
                RefrescarTabla("Select * from Doctores Where id_doc like '%" + txtCriterio.Text + "%'");
            }

            if (rdbNombre.Checked == true)
            {
                RefrescarTabla("Select * from Doctores Where nom_doc like '%" + txtCriterio.Text + "%'");
            }

            if (rdbApellido.Checked == true)
            {
                RefrescarTabla("Select * from Doctores Where ape_doc like '%" + txtCriterio.Text + "%'");
            }

            if (rdbEspecialidad.Checked == true)
            {
                // 'Especialidad' is now 'id_esp' (int), so LIKE might fail if typed text. 
                // But generally users might search by valid ID or we leave it.
                // Or if they expect logic "Name of specialty" we'd need JOIN.
                // Keeping simple mapping for now.
                RefrescarTabla("Select * from Doctores Where id_esp like '%" + txtCriterio.Text + "%'");
            }
        }
    }
}
