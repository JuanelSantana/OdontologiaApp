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
    public partial class frmConCita05 : BaseForm
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");

        public frmConCita05()
        {
            InitializeComponent();
             this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }
        private void frmConCita05_Load(object sender, EventArgs e)
        {
            RefrescarTabla("Select * from Citas");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rdbIdCita.Checked == true)
            {
                RefrescarTabla("Select * from Citas Where id_cit like '%" + txtCriterio.Text + "%'");
            }

            if (rdbCedula.Checked == true)
            {
                // Citas table has 'id_pac' (int), not Cedula (string).
                // Searching by id_pac for now.
                RefrescarTabla("Select * from Citas Where id_pac like '%" + txtCriterio.Text + "%'");
            }

            if (rdbFecha.Checked == true)
            {
                RefrescarTabla("Select * from Citas Where fec_cit like '%" + txtCriterio.Text + "%'");
            }

            if (rdbIdDoctor.Checked == true)
            {
                RefrescarTabla("Select * from Citas Where id_doc like '%" + txtCriterio.Text + "%'");
            }

            if (rdbIdEmpleado.Checked == true)
            {
                // Citas has 'id_usr' (Created by).
                RefrescarTabla("Select * from Citas Where id_usr like '%" + txtCriterio.Text + "%'");
            }
        }
    }
}
