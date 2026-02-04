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
    public partial class frmManCitas : BaseForm
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");

        public frmManCitas()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void frmManCitas_Load(object sender, EventArgs e)
        {
            refrescarTablas();
        }

        private void refrescarTablas()
        {
            try
            {
                if(dgvManCit == null) return;
                
                dgvManCit.DataSource = null;
                conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Citas", conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvManCit.DataSource = FuenteDatos;
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

        private void button2_Click(object sender, EventArgs e)
        {
             EscribirDatos("Delete from Citas where id_cit = '" + txtIdCita.Text + "'");
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
            txtIdCita.Text = "";
            txtIdPac.Clear();
            txtIdDoc.Clear();
            txtIdUsr.Clear();
            txtMotivo.Clear();
            txtComentario.Clear();
            txtEstado.Clear();
            txtMotivo.Focus();
            dtpFecha.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Defaults
            string idP = string.IsNullOrEmpty(txtIdPac.Text) ? "0" : txtIdPac.Text;
            string idD = string.IsNullOrEmpty(txtIdDoc.Text) ? "1" : txtIdDoc.Text;
            string idU = string.IsNullOrEmpty(txtIdUsr.Text) ? "1" : txtIdUsr.Text; // Assuming User 1 exists or is current
            string est = string.IsNullOrEmpty(txtEstado.Text) ? "1" : txtEstado.Text; // Default Pending
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd HH:mm");

            if (string.IsNullOrEmpty(txtIdCita.Text))
            {
                // Insert
                EscribirDatos("Insert into Citas (id_pac, id_doc, id_eci, fec_cit, mtv_cit, cmt_cit, id_usr) Values (" +
                              idP + " , " +
                              idD + " , " +
                              est + " , '" +
                              fecha + "', '" +
                              txtMotivo.Text.Trim() + "', '" + 
                              txtComentario.Text.Trim() + "', " +
                              idU + ")");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Update
                EscribirDatos("Update Citas Set id_pac = " + idP +
                              ", id_doc = " + idD +
                              ", id_eci = " + est +
                              ", fec_cit = '" + fecha + 
                              "', mtv_cit = '" + txtMotivo.Text.Trim() + 
                              "', cmt_cit = '" + txtComentario.Text.Trim() + 
                              "', id_usr = " + idU +
                              " where id_cit = '" + txtIdCita.Text + "'");
            }
            refrescarTablas();
            LimpiarObjetos();
        }

        private void dgvManCit_Click(object sender, EventArgs e)
        {
            if (dgvManCit.SelectedCells.Count > 0)
            {
                int r = dgvManCit.SelectedCells[0].RowIndex;
                try {
                    // Columns: 0:id_cit, 1:id_pac, 2:id_doc, 3:id_eci, 4:fec_cit, 5:mtv_cit, 6:cmt_cit, 7:id_usr
                    txtIdCita.Text = dgvManCit.Rows[r].Cells[0].Value.ToString();
                    txtIdPac.Text = dgvManCit.Rows[r].Cells[1].Value.ToString();
                    txtIdDoc.Text = dgvManCit.Rows[r].Cells[2].Value.ToString();
                    txtEstado.Text = dgvManCit.Rows[r].Cells[3].Value.ToString();
                    dtpFecha.Value = Convert.ToDateTime(dgvManCit.Rows[r].Cells[4].Value);
                    txtMotivo.Text = dgvManCit.Rows[r].Cells[5].Value.ToString();
                    
                    if(dgvManCit.ColumnCount > 6)
                        txtComentario.Text = dgvManCit.Rows[r].Cells[6].Value.ToString();
                    
                    if(dgvManCit.ColumnCount > 7)
                        txtIdUsr.Text = dgvManCit.Rows[r].Cells[7].Value.ToString();

                } catch { }
            }
        }
    }
}
