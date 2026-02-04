using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoOdontologia2025
{
    public partial class frmManProveedores07 : BaseForm
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");

        public frmManProveedores07()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void frmManProveedores07_Load(object sender, EventArgs e)
        {
            refrescarTablas();
        }

        private void refrescarTablas()
        {
            try
            {
                if(dgvManPro == null) return;
                
                dgvManPro.DataSource = null;
                conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Proveedores", conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvManPro.DataSource = FuenteDatos;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                if(conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        private void frmManProveedores07_Activated(object sender, EventArgs e)
        {
            comand.Connection = conexion;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarObjetos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             EscribirDatos("Delete from Proveedores where id_prv = '" + txtIdProv.Text + "'");
             LimpiarObjetos();
             refrescarTablas();
        }

        private void EscribirDatos(string Parametro)
        {
            comand.CommandText = Parametro;
            conexion.Open();
            comand.Transaction = conexion.BeginTransaction();
            comand.ExecuteNonQuery();
            comand.Transaction.Commit();
            conexion.Close();
        }

        private void LimpiarObjetos()
        {
            txtIdProv.Text = "";
            txtNombre.Clear();
            txtLocalidad.Clear();
            txtTelefono.Clear();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProv.Text))
            {
                // Insert
                EscribirDatos("Insert into Proveedores (nom_prv, loc_prv, tel_prv) Values ('" +
                              txtNombre.Text.Trim() + "' , '" +
                              txtLocalidad.Text.Trim() + "' , '" +
                              txtTelefono.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Update
                EscribirDatos("Update Proveedores Set nom_prv = '" + txtNombre.Text.Trim() +
                              "', loc_prv =  '" + txtLocalidad.Text.Trim() +
                              "', tel_prv =  '" + txtTelefono.Text.Trim() +
                              "' where id_prv = '" + txtIdProv.Text + "'");
            }
            refrescarTablas();
            LimpiarObjetos();
        }

        private void dgvManPro_Click(object sender, EventArgs e)
        {
            if (dgvManPro.SelectedCells.Count > 0)
            {
                int r = dgvManPro.SelectedCells[0].RowIndex;
                try {
                    // Columns: 0:id, 1:nom, 2:loc, 3:tel
                    txtIdProv.Text = dgvManPro.Rows[r].Cells[0].Value.ToString();
                    txtNombre.Text = dgvManPro.Rows[r].Cells[1].Value.ToString();
                    txtLocalidad.Text = dgvManPro.Rows[r].Cells[2].Value.ToString();
                    txtTelefono.Text = dgvManPro.Rows[r].Cells[3].Value.ToString();
                } catch { }
            }
        }
    }
}
