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
    public partial class frmManMateriales06 : BaseForm
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");

        public frmManMateriales06()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void frmManMateriales06_Load(object sender, EventArgs e)
        {
            refrescarTablas();
        }

        private void refrescarTablas()
        {
            try
            {
                if(dgvManMat == null) return;
                
                dgvManMat.DataSource = null;
                conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Materiales", conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvManMat.DataSource = FuenteDatos;
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

        private void frmManMateriales06_Activated(object sender, EventArgs e)
        {
            comand.Connection = conexion;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarObjetos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             EscribirDatos("Delete from Materiales where id_mat = '" + txtIdMaterial.Text + "'");
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
            txtIdMaterial.Text = "";
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtCosto.Clear();
            txtTipo.Clear();
            txtProveedor.Clear();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Default handling
            string cant = string.IsNullOrEmpty(txtCantidad.Text) ? "0" : txtCantidad.Text.Trim();
            string cost = string.IsNullOrEmpty(txtCosto.Text) ? "0.00" : txtCosto.Text.Trim();
            string idPrv = string.IsNullOrEmpty(txtProveedor.Text) ? "NULL" : txtProveedor.Text.Trim();
            
            if (string.IsNullOrEmpty(txtIdMaterial.Text))
            {
                // Insert
                EscribirDatos("Insert into Materiales (nom_mat, dsc_mat, cnt_mat, cst_mat, tip_mat, id_prv) Values ('" +
                              txtNombre.Text.Trim() + "' , '" +
                              txtDescripcion.Text.Trim() + "' , " +
                              cant + ", " +
                              cost + ", '" +
                              txtTipo.Text.Trim() + "', " +
                              idPrv + ")");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Update
                EscribirDatos("Update Materiales Set nom_mat = '" + txtNombre.Text.Trim() +
                              "', dsc_mat =  '" + txtDescripcion.Text.Trim() +
                              "', cnt_mat =  " + cant +
                              ", cst_mat =  " + cost +
                              ", tip_mat =  '" + txtTipo.Text.Trim() +
                              "', id_prv =  " + idPrv +
                              " where id_mat = '" + txtIdMaterial.Text + "'");
            }
            refrescarTablas();
            LimpiarObjetos();
        }

        private void dgvManMat_Click(object sender, EventArgs e)
        {
            if (dgvManMat.SelectedCells.Count > 0)
            {
                int r = dgvManMat.SelectedCells[0].RowIndex;
                try {
                    // Columns: 0:id, 1:nom, 2:dsc, 3:cnt, 4:cst, 5:tip, 6:id_prv
                    txtIdMaterial.Text = dgvManMat.Rows[r].Cells[0].Value.ToString();
                    txtNombre.Text = dgvManMat.Rows[r].Cells[1].Value.ToString();
                    txtDescripcion.Text = dgvManMat.Rows[r].Cells[2].Value.ToString();
                    txtCantidad.Text = dgvManMat.Rows[r].Cells[3].Value.ToString();
                    txtCosto.Text = dgvManMat.Rows[r].Cells[4].Value.ToString();
                    txtTipo.Text = dgvManMat.Rows[r].Cells[5].Value.ToString();
                    txtProveedor.Text = dgvManMat.Rows[r].Cells[6].Value.ToString();
                } catch { }
            }
        }
    }
}
