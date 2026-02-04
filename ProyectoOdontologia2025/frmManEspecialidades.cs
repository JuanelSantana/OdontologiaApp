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
    // New Maintenance Form for Especialidades
    public partial class frmManEspecialidades : BaseForm
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");
        
        // Constructor
        public frmManEspecialidades()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void frmManEspecialidades_Load(object sender, EventArgs e)
        {
            refrescarTablas();
        }

        private void refrescarTablas()
        {
            try
            {
                // UI Requirement: dgvManEsp (DataGridView)
                if (dgvManEsp == null) return;

                dgvManEsp.DataSource = null;
                conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Especialidades", conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvManEsp.DataSource = FuenteDatos;
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

        private void EscribirDatos(string Parametro)
        {
            comand.CommandText = Parametro;
            conexion.Open();
            comand.Transaction = conexion.BeginTransaction();
            comand.ExecuteNonQuery();
            comand.Transaction.Commit();
            conexion.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // UI Inputs: txtIdEsp, txtNombre, txtDescripcion
            
            if (string.IsNullOrEmpty(txtIdEsp.Text))
            {
                // Insert
                EscribirDatos("Insert into Especialidades (nom_esp, dsc_esp) Values ('" + 
                              txtNombre.Text.Trim() + "' , '" + 
                              txtDescripcion.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Update
                EscribirDatos("Update Especialidades Set nom_esp = '" + txtNombre.Text.Trim() + 
                              "', dsc_esp =  '" + txtDescripcion.Text.Trim() + 
                              "' where id_esp = '" + txtIdEsp.Text + "'");
            }

            refrescarTablas();
            LimpiarObjetos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Delete
            EscribirDatos("Delete from Especialidades where id_esp = '" + txtIdEsp.Text + "'");
            LimpiarObjetos();
            refrescarTablas();
        }

        private void LimpiarObjetos()
        {
            txtIdEsp.Text = "";
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtNombre.Focus();
        }

        private void dgvManEsp_Click(object sender, EventArgs e)
        {
             if(dgvManEsp.SelectedCells.Count > 0)
            {
                int r = dgvManEsp.SelectedCells[0].RowIndex;
                try {
                // 0:id, 1:nom, 2:dsc
                txtIdEsp.Text = dgvManEsp.Rows[r].Cells[0].Value.ToString();
                txtNombre.Text = dgvManEsp.Rows[r].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvManEsp.Rows[r].Cells[2].Value.ToString();
                } catch {}
            }
        }
    }
}
