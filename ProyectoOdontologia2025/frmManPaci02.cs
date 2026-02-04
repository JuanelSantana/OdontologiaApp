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
    public partial class frmManPaci02 : BaseForm
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");

        public frmManPaci02()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void frmManPaci02_Load(object sender, EventArgs e)
        {
            refrescarTablas();
        }

        private void refrescarTablas()
        {
            dgvManPac.DataSource = null;
            try
            {
                conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Pacientes", conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvManPac.DataSource = FuenteDatos;
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

        private void frmManPaci02_Activated(object sender, EventArgs e)
        {
            comand.Connection = conexion;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Possibly 'Nuevo' or 'Cancelar'
            LimpiarObjetos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Pacientes where ced_pac = '" + txtCedula.Text + "'");       
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
            txtCedula.Text = "";
            txtNombre.Clear();
            txtApellido.Clear();
            txtTipoPaciente.Clear();
            mtbTel.Clear();
            txtCondicion.Clear();
            txtCorreo.Clear();
            txtIdSeg.Clear();
            txtNombre.Focus();
            DtpFechaNac.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Default for mandatory gen_pac
            string genPac = "X";
            
            // Handle optional id_seg (int)
            string idSegVal = "NULL";
            if(!string.IsNullOrEmpty(txtIdSeg.Text)) idSegVal = txtIdSeg.Text;

            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT 1 FROM Pacientes WHERE ced_pac = '" + txtCedula.Text.Trim() + "'", conexion);
            SqlDataReader reader = cmd.ExecuteReader();
            bool existe = reader.Read();
            reader.Close();
            conexion.Close();

            if (existe)
            {
                // Update with ALL fields
                EscribirDatos("UPDATE Pacientes SET nom_pac = '" + txtNombre.Text.Trim() +
                              "', ape_pac = '" + txtApellido.Text.Trim() +
                              "', fec_nac_pac = '" + DtpFechaNac.Value.ToString("yyyy-MM-dd") +      
                              "', tel_pac = '" + mtbTel.Text.Trim() +
                              "', eml_pac = '" + txtCorreo.Text.Trim() +
                              "', tip_pac = '" + txtTipoPaciente.Text.Trim() +
                              "', cnd_sal_pac = '" + txtCondicion.Text.Trim() +
                              "', id_seg = " + idSegVal +
                              " WHERE ced_pac = '" + txtCedula.Text.Trim() + "'");
                MessageBox.Show("Registro actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Insert
                EscribirDatos("INSERT INTO Pacientes (ced_pac, nom_pac, ape_pac, fec_nac_pac, tel_pac, eml_pac, gen_pac, tip_pac, cnd_sal_pac, id_seg) VALUES ('" +
                              txtCedula.Text.Trim() + "', '" +
                              txtNombre.Text.Trim() + "', '" +
                              txtApellido.Text.Trim() + "', '" +
                              DtpFechaNac.Value.ToString("yyyy-MM-dd") + "', '" +
                              mtbTel.Text.Trim() + "', '" +
                              txtCorreo.Text.Trim() + "', '" +
                              genPac + "', '" +
                              txtTipoPaciente.Text.Trim() + "', '" +
                              txtCondicion.Text.Trim() + "', " +
                              idSegVal + ")");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            refrescarTablas();
            LimpiarObjetos();
        }

        private void dgvManPac_Click(object sender, EventArgs e)
        {
            if (dgvManPac.SelectedCells.Count > 0)
            {
                int r = dgvManPac.SelectedCells[0].RowIndex;
                try {
                    // Columns: 0:id_pac, 1:nom_pac, 2:ape_pac, 3:ced_pac, 4:gen_pac, 5:fec_nac_pac, 6:tel_pac, 7:eml_pac, 
                    // 8:tip_pac, 9:cnd_sal_pac, 10:id_seg
          
                    txtCedula.Text = dgvManPac.Rows[r].Cells[3].Value.ToString();
                    txtNombre.Text = dgvManPac.Rows[r].Cells[1].Value.ToString();
                    txtApellido.Text = dgvManPac.Rows[r].Cells[2].Value.ToString();
                    DtpFechaNac.Value = Convert.ToDateTime(dgvManPac.Rows[r].Cells[5].Value);
                    mtbTel.Text = dgvManPac.Rows[r].Cells[6].Value.ToString();     
                    txtCorreo.Text = dgvManPac.Rows[r].Cells[7].Value.ToString();
                    
                    txtTipoPaciente.Text = dgvManPac.Rows[r].Cells[8].Value.ToString();
                    txtCondicion.Text = dgvManPac.Rows[r].Cells[9].Value.ToString();
                    txtIdSeg.Text = dgvManPac.Rows[r].Cells[10].Value.ToString();
                    
                } catch { }
            }
        }
        
        // Event handlers placeholders
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void groupBox3_Enter(object sender, EventArgs e) { }
    }
}
