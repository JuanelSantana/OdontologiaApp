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
    public partial class frmManUser04 : BaseForm
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");

        public frmManUser04()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void frmManUser04_Load(object sender, EventArgs e)
        {
            refrescarTablas();
        }

        private void refrescarTablas()
        {
            try
            {
                if(dgvManUser == null) return;
                
                dgvManUser.DataSource = null;
                conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Usuarios", conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvManUser.DataSource = FuenteDatos;
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

        private void frmManUser04_Activated(object sender, EventArgs e)
        {
            comand.Connection = conexion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             EscribirDatos("Delete from Usuarios where id_usr = '" + txtIdUsuario.Text + "'");
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
            txtIdUsuario.Text = "";
            txtNombre.Clear();
            txtNombreUsuario.Clear();
            txtContrasena.Clear();
            txtTipoUser.Clear();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar rol
            string rol = "2"; // Default user
            if(!string.IsNullOrEmpty(txtTipoUser.Text)) rol = txtTipoUser.Text;

            if (string.IsNullOrEmpty(txtIdUsuario.Text))
            {
                // Insert
                EscribirDatos("Insert into Usuarios (nmb_usr, nom_usr, pas_usr, id_rol) Values ('" +
                              txtNombre.Text.Trim() + "' , '" +
                              txtNombreUsuario.Text.Trim() + "' , '" +
                              txtContrasena.Text.Trim() + "', " + 
                              rol + ")");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Update
                EscribirDatos("Update Usuarios Set nmb_usr = '" + txtNombre.Text.Trim() + 
                              "', nom_usr =  '" + txtNombreUsuario.Text.Trim() + 
                              "', pas_usr =  '" + txtContrasena.Text.Trim() + 
                              "', id_rol =  " + rol + 
                              " where id_usr = '" + txtIdUsuario.Text + "'");
            }
            refrescarTablas();
            LimpiarObjetos();
        }

        private void dgvManSegu_Click(object sender, EventArgs e) // Keeping original event handler name
        {
            if (dgvManUser.SelectedCells.Count > 0)
            {
                int r = dgvManUser.SelectedCells[0].RowIndex;
                try {
                    // Columns: 0:id_usr, 1:nom_usr (username), 2:pas_usr, 3:id_rol, 4:atv_usr, 5:nmb_usr (real name)
                    txtIdUsuario.Text = dgvManUser.Rows[r].Cells[0].Value.ToString();
                    txtNombreUsuario.Text = dgvManUser.Rows[r].Cells[1].Value.ToString();
                    txtContrasena.Text = dgvManUser.Rows[r].Cells[2].Value.ToString();
                    txtTipoUser.Text = dgvManUser.Rows[r].Cells[3].Value.ToString();
                    
                    // Real Name might be null or at index 5
                    if(dgvManUser.ColumnCount > 5)
                        txtNombre.Text = dgvManUser.Rows[r].Cells[5].Value.ToString();
                } catch { }
            }
        }
        
        private void label5_Click(object sender, EventArgs e) {}
    }
}
