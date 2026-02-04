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
    public partial class frmManTrat08 : BaseForm
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");

        public frmManTrat08()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void frmManTrat08_Load(object sender, EventArgs e)
        {
            refrescarTablas();
        }

        private void RefrescarTabla(String Parametro)
        {
            // KEEPING THIS METHOD if it was used by Query logic inside maintenance
            try
            {
                conexion.Open();
                DataTable datos = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(Parametro, conexion);
                adaptador.Fill(datos);
                BindingSource fuentedatos = new BindingSource();
                fuentedatos.DataSource = datos;
                dgvManTrat.DataSource = fuentedatos;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
               if(conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        private void refrescarTablas()
        {
            try
            {
                if(dgvManTrat == null) return;
                
                dgvManTrat.DataSource = null;
                conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Tratamientos", conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvManTrat.DataSource = FuenteDatos;
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

        private void frmManTrat08_Activated(object sender, EventArgs e)
        {
            comand.Connection = conexion;
        }

        private void button3_Click(object sender, EventArgs e)
        {
             LimpiarObjetos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             EscribirDatos("Delete from Tratamientos where id_tra = '" + txtIdTratamiento.Text + "'");
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
            txtIdTratamiento.Text = "";
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCosto.Clear();
            txtDuracion.Clear();
            txtIdCita.Clear();
            txtCedula.Clear();
            txtIdDoctor.Clear();
            txtNombre.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             // Lookup id_pac from Cedula
            string idPac = "0";
            if(!string.IsNullOrEmpty(txtCedula.Text))
            {
                try {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_pac FROM Pacientes WHERE ced_pac = '" + txtCedula.Text.Trim() + "'", conexion);
                object result = cmd.ExecuteScalar();
                if(result != null) idPac = result.ToString();
                conexion.Close();
                } catch { if(conexion.State == ConnectionState.Open) conexion.Close(); }
            }

            // Defaults
            string idDoc = string.IsNullOrEmpty(txtIdDoctor.Text) ? "1" : txtIdDoctor.Text;
            string idTtr = "1";
            string idSrv = "1";
            string fecIni = DateTime.Now.ToString("yyyy-MM-dd");
            string idCit = string.IsNullOrEmpty(txtIdCita.Text) ? "NULL" : txtIdCita.Text;
            string cost = string.IsNullOrEmpty(txtCosto.Text) ? "0.00" : txtCosto.Text;

            if (string.IsNullOrEmpty(txtIdTratamiento.Text))
            {
                // Insert
                EscribirDatos("Insert into Tratamientos (id_pac, id_doc, id_ttr, id_srv, nom_tra, dsc_tra, cst_tra, dur_tra, fec_ini_tra, id_cit) Values (" +
                              idPac + " , " +
                              idDoc + " , " +
                              idTtr + " , " +
                              idSrv + " , '" +
                              txtNombre.Text.Trim() + "', '" +
                              txtDescripcion.Text.Trim() + "', " +
                              cost + ", '" + 
                              txtDuracion.Text.Trim() + "', '" +
                              fecIni + "', " +
                              idCit + ")");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Update
                EscribirDatos("Update Tratamientos Set id_pac = " + idPac +
                              ", id_doc = " + idDoc +
                              ", nom_tra = '" + txtNombre.Text.Trim() + 
                              "', dsc_tra =  '" + txtDescripcion.Text.Trim() + 
                              "', cst_tra =  " + cost + 
                              ", dur_tra =  '" + txtDuracion.Text.Trim() + 
                              "', id_cit =  " + idCit + 
                              " where id_tra = '" + txtIdTratamiento.Text + "'");
            }
            refrescarTablas();
            LimpiarObjetos();
        }

        private void dgvManPac_Click(object sender, EventArgs e)
        {
            if (dgvManTrat.SelectedCells.Count > 0)
            {
                int r = dgvManTrat.SelectedCells[0].RowIndex;
                try {
                    // Columns: 0:id_tra, 1:id_pac, 2:id_doc, 3:id_ttr, 4:id_srv, 5:dsc_tra, 6:cst_tra, 7:fec_ini, 8:fec_fin, 9:nom_tra, 10:dur_tra, 11:id_cit
                    txtIdTratamiento.Text = dgvManTrat.Rows[r].Cells[0].Value.ToString();
                    
                    // We need to fetch Cedula from id_pac
                    // For now leaving cedula empty or just showing id_pac if user types it.
                    // Ideally we query back.
                    
                    txtIdDoctor.Text = dgvManTrat.Rows[r].Cells[2].Value.ToString();
                    txtDescripcion.Text = dgvManTrat.Rows[r].Cells[5].Value.ToString();
                    txtCosto.Text = dgvManTrat.Rows[r].Cells[6].Value.ToString();
                    txtNombre.Text = dgvManTrat.Rows[r].Cells[9].Value.ToString();
                    txtDuracion.Text = dgvManTrat.Rows[r].Cells[10].Value.ToString();
                    txtIdCita.Text = dgvManTrat.Rows[r].Cells[11].Value.ToString();
                } catch { }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {}

        // Added handler referenced by designer; no-op or implement validation if needed
        private void txtIdCita_TextChanged(object sender, EventArgs e)
        {
            // Intentionally left blank; placeholder for designer event
        }
    }
}
