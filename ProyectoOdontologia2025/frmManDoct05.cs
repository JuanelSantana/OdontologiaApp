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
    public partial class frmManDoct05 : BaseForm
    {

        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");

        public frmManDoct05()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void refrescarTablas()
        {
            dgvManDoc.DataSource = null;
            try
            {
                conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Doctores", conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvManDoc.DataSource = FuenteDatos;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void frmManDoct05_Activated(object sender, EventArgs e)
        {
            comand.Connection = conexion;
        }

        private void frmManDoct05_Load(object sender, EventArgs e)
        {
            refrescarTablas();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void EscribirDatos(string Parametro)
        {
            //Permite ejectuar las instrucciones recibidas en Parametro en la base de datos       
            comand.CommandText = Parametro;
            conexion.Open();
            comand.Transaction = conexion.BeginTransaction();
            comand.ExecuteNonQuery();
            comand.Transaction.Commit();
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validating/Converting Especialidad to INT
            string valEsp = "1";
            if(int.TryParse(txtEsp.Text, out int parsed)) valEsp = parsed.ToString();

            if (string.IsNullOrEmpty(txtIdDoc.Text))
            {
                //Agrego registro nuevo
                // Inserting defaults for: ced_doc, tel_doc, eml_doc ('N/A')
                EscribirDatos("Insert into Doctores (nom_doc, ape_doc, id_esp, ced_doc, tel_doc, eml_doc) Values ('" + 
                              txtNom.Text.Trim() + "' , '" + 
                              txtApe.Text.Trim() + "' , '" + 
                              valEsp + "', 'N/A', 'N/A', 'N/A')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Doctores Set nom_doc = '" + txtNom.Text.Trim() + 
                              "', ape_doc =  '" + txtApe.Text.Trim() + 
                              "', id_esp =  '" + valEsp + 
                              "' where id_doc = '" + txtIdDoc.Text + "'");
            }

            refrescarTablas(); //Invoco función
            LimpiarObjetos();

        }
        private void LimpiarObjetos()
        {
            txtIdDoc.Text = "";
            txtNom.Clear();
            txtApe.Clear();
            txtEsp.Clear();
            txtNom.Focus();
        }

        private void dgvManSegu_Click(object sender, EventArgs e)
        {
            if(dgvManDoc.SelectedCells.Count > 0)
            {
                int r = dgvManDoc.SelectedCells[0].RowIndex;
                // Mapping: 0:id_doc, 1:nom_doc, 2:ape_doc, 3:ced_doc, 4:tel_doc, 5:eml_doc, 6:id_esp
                try {
                    txtIdDoc.Text = dgvManDoc.Rows[r].Cells[0].Value.ToString();
                    txtNom.Text = dgvManDoc.Rows[r].Cells[1].Value.ToString();
                    txtApe.Text = dgvManDoc.Rows[r].Cells[2].Value.ToString();
                    txtEsp.Text = dgvManDoc.Rows[r].Cells[6].Value.ToString();
                } catch {}
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Doctores where id_doc= '" + txtIdDoc.Text + "'");        
            LimpiarObjetos();
            refrescarTablas();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
