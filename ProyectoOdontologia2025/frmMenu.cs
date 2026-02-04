using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOdontologia2025
{
    public partial class frmMenu : BaseForm
    {
        public frmMenu()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        // Timer for Date/Time
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        // --- Mantenimientos ---

        private void segurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManSegu01 frm = new frmManSegu01();
            frm.ShowDialog();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManPaci02 frm = new frmManPaci02();
            frm.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManEmpl03 frm = new frmManEmpl03();
            frm.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManUser04 frm = new frmManUser04();
            frm.ShowDialog();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManDoct05 frm = new frmManDoct05();
            frm.ShowDialog();
        }

        private void materialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManMateriales06 frm = new frmManMateriales06();
            frm.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManProveedores07 frm = new frmManProveedores07();
            frm.ShowDialog();
        }

        private void tratamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManTrat08 frm = new frmManTrat08();
            frm.ShowDialog();
        }

        // --- New Forms ---

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Implement frmManServicios form and uncomment below
            // frmManServicios frm = new frmManServicios();
            // frm.ShowDialog();
            MessageBox.Show("Funcionalidad de Servicios no disponible (formulario faltante).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Implement frmManEspecialidades form and uncomment below
            // frmManEspecialidades frm = new frmManEspecialidades();
            // frm.ShowDialog();
            MessageBox.Show("Funcionalidad de Especialidades no disponible (formulario faltante).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void citasManToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Implement frmManCitas form and uncomment below
            // frmManCitas frm = new frmManCitas();
            // frm.ShowDialog();
            MessageBox.Show("Funcionalidad de Citas no disponible (formulario faltante).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- Salir ---

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
