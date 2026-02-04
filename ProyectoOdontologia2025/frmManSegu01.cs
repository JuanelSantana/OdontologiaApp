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
    public partial class frmManSegu01 : BaseForm
    {
        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");

        public frmManSegu01()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private  void refrescarTablas()
        {
            dgvManSegu.DataSource = null;
            try
            {
                conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Seguros", conexion); 
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvManSegu.DataSource = FuenteDatos;
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

        private void label1_Click(object sender, EventArgs e) 
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmManSegu01_Load(object sender, EventArgs e)
        {
            refrescarTablas();
        }


        private void frmManSegu01_Activated(object sender, EventArgs e)
        {
            comand.Connection = conexion;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdSeg.Text))
            {
                //Agrego registro nuevo
                EscribirDatos("Insert into Seguros (nom_seg, tel_seg) Values ('" + 
                              NombreSeg.Text.Trim() + "' , '" + 
                              mtbTel.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Seguros Set nom_seg = '" + NombreSeg.Text.Trim() + 
                              "', tel_seg =  '" + mtbTel.Text.Trim() + 
                              "' where id_seg = '" + txtIdSeg.Text + "'");
            }

            refrescarTablas(); //Invoco funcin
            LimpiarObjetos();

        }
        private void LimpiarObjetos()
        {
            txtIdSeg.Text = "";
            NombreSeg.Clear();
            mtbTel.Clear();
            NombreSeg.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Seguros where id_seg= '" + txtIdSeg.Text + "'");
            LimpiarObjetos();
            refrescarTablas();

        }

        private void dgvManSegu_Click(object sender, EventArgs e)
        {
            if(dgvManSegu.SelectedCells.Count > 0)
            {
                int r = dgvManSegu.SelectedCells[0].RowIndex;
                try {
                // Mapping: 0:id_seg, 1:nom_seg, 2:tel_seg
                txtIdSeg.Text = dgvManSegu.Rows[r].Cells[0].Value.ToString(); 
                NombreSeg.Text = dgvManSegu.Rows[r].Cells[1].Value.ToString();
                mtbTel.Text = dgvManSegu.Rows[r].Cells[2].Value.ToString();   
                } catch { }
            }
        }
    }
}
