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
    // New Maintenance Form for Servicios
    public partial class frmManServicios : BaseForm
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");

        // UI Controls (simulated code-behind, assuming Designer would have these)
        // Since we are creating this file from scratch, we might lack the Designer.cs. 
        // Ideally this code is pasted into an existing Form file created by the user.
        // But I will provide the full logic here.
        
        public frmManServicios()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void frmManServicios_Load(object sender, EventArgs e)
        {
            refrescarTablas();
        }

        private void refrescarTablas()
        {
            // Assuming dgvManServ exist
            // dgvManServ.DataSource = null; 
            // For now, using a generic name or assuming functionality if controls existed
             
            // To make this functional without Designer, User needs to add controls.
            // This code acts as the logic template.
            
            try
            {
                if (dgvManServ == null) return; 

                dgvManServ.DataSource = null;
                conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Servicios", conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvManServ.DataSource = FuenteDatos;
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
            // Inputs: txtIdServicio, txtNombre, txtDescripcion, txtCosto
            
            if (string.IsNullOrEmpty(txtIdServicio.Text))
            {
                // Insert
                EscribirDatos("Insert into Servicios (nom_srv, dsc_srv, cst_srv) Values ('" + 
                              txtNombre.Text.Trim() + "' , '" + 
                              txtDescripcion.Text.Trim() + "' , '" + 
                              txtCosto.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Update
                EscribirDatos("Update Servicios Set nom_srv = '" + txtNombre.Text.Trim() + 
                              "', dsc_srv =  '" + txtDescripcion.Text.Trim() + 
                              "', cst_srv =  '" + txtCosto.Text.Trim() + 
                              "' where id_srv = '" + txtIdServicio.Text + "'");
            }

            refrescarTablas();
            LimpiarObjetos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Delete
            EscribirDatos("Delete from Servicios where id_srv = '" + txtIdServicio.Text + "'");
            LimpiarObjetos();
            refrescarTablas();
        }

        private void LimpiarObjetos()
        {
            txtIdServicio.Text = "";
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCosto.Clear();
            txtNombre.Focus();
        }

        private void dgvManServ_Click(object sender, EventArgs e)
        {
             if(dgvManServ.SelectedCells.Count > 0)
            {
                int r = dgvManServ.SelectedCells[0].RowIndex;
                try {
                // 0:id, 1:nom, 2:dsc, 3:cst
                txtIdServicio.Text = dgvManServ.Rows[r].Cells[0].Value.ToString();
                txtNombre.Text = dgvManServ.Rows[r].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvManServ.Rows[r].Cells[2].Value.ToString();
                txtCosto.Text = dgvManServ.Rows[r].Cells[3].Value.ToString();
                } catch {}
            }
        }
    }
}
