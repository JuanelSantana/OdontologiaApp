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
using System.Windows.Input;

namespace ProyectoOdontologia2025
{
    public partial class frmManEmpl03 : BaseForm
    {

        SqlCommand comand = new SqlCommand();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M1L55O8; initial catalog=OdontologiaBD; trusted_connection=yes;");

        public frmManEmpl03()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void refrescarTablas()
        {
            dgvManEmp.DataSource = null;
            try
            {
                conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Empleados", conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvManEmp.DataSource = FuenteDatos;
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

        private void frmManEmpl03_Load(object sender, EventArgs e)
        {
            refrescarTablas();
        }

        private void frmManEmpl03_Activated(object sender, EventArgs e)
        {
            comand.Connection = conexion;
        }

        private void label5_Click(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(txtIdEmp.Text))
            {
                //Agrego registro nuevo
                EscribirDatos("Insert into Empleados (nom_emp, ape_emp, dir_emp, tel_emp, crg_emp) Values ('" + 
                              txtNombre.Text.Trim() + "' , '" + 
                              txtApe.Text.Trim() + "' , '" + 
                              txtDire.Text.Trim() + "' , '" + 
                              mtbTel.Text.Trim() + "' , '" + 
                              txtCargo.Text.Trim() + "')");
                MessageBox.Show("Nuevo registro guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Modificar un registro existente
                EscribirDatos("Update Empleados Set nom_emp = '" + txtNombre.Text.Trim() + 
                              "', ape_emp =  '" + txtApe.Text.Trim() + 
                              "', dir_emp =  '" + txtDire.Text.Trim() + 
                              "', tel_emp =  '" + mtbTel.Text.Trim() + 
                              "', crg_emp =  '" + txtCargo.Text.Trim() + 
                              "' where id_emp = '" + txtIdEmp.Text + "'");
            }

            refrescarTablas(); //Invoco función
            LimpiarObjetos();

        }
        private void LimpiarObjetos()
        {

            txtIdEmp.Text = "";
            txtNombre.Clear();
            mtbTel.Clear();
            txtDire.Clear();
            txtApe.Clear();
            txtCargo.Clear();
            txtNombre.Focus();
        }

        private void dgvManSegu_Click(object sender, EventArgs e)
        {
            if(dgvManEmp.SelectedCells.Count > 0)
            {
                int r = dgvManEmp.SelectedCells[0].RowIndex;
                // Mapping: 0:id_emp, 1:nom_emp, 2:ape_emp, 3:dir_emp, 4:tel_emp, 5:crg_emp 
                try {
                txtIdEmp.Text = dgvManEmp.Rows[r].Cells[0].Value.ToString();   
                txtNombre.Text = dgvManEmp.Rows[r].Cells[1].Value.ToString();  
                txtApe.Text = dgvManEmp.Rows[r].Cells[2].Value.ToString();     
                txtDire.Text = dgvManEmp.Rows[r].Cells[3].Value.ToString();    
                mtbTel.Text = dgvManEmp.Rows[r].Cells[4].Value.ToString();     
                txtCargo.Text = dgvManEmp.Rows[r].Cells[5].Value.ToString();   
                } catch { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Empleados where id_emp= '" + txtIdEmp.Text + "'");     
            LimpiarObjetos();
            refrescarTablas();
        }
    }
}
