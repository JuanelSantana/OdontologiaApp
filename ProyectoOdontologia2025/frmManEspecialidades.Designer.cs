namespace ProyectoOdontologia2025
{
    partial class frmManEspecialidades
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvManEsp = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdEsp = new System.Windows.Forms.TextBox();
            
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManEsp)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            
            // groupBox4 (Grid)
            this.groupBox4.Controls.Add(this.dgvManEsp);
            this.groupBox4.Location = new System.Drawing.Point(74, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(800, 200);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.Text = "Registros";
            
            // dgvManEsp
            this.dgvManEsp.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvManEsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManEsp.Location = new System.Drawing.Point(16, 30);
            this.dgvManEsp.Name = "dgvManEsp";
            this.dgvManEsp.Size = new System.Drawing.Size(760, 150);
            this.dgvManEsp.TabIndex = 0;
            this.dgvManEsp.Click += new System.EventHandler(this.dgvManEsp_Click);

            // groupBox3 (Inputs)
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.txtIdEsp);
            this.groupBox3.Controls.Add(this.lblDesc);
            this.groupBox3.Controls.Add(this.lblNombre);
            this.groupBox3.Controls.Add(this.lblId);
            this.groupBox3.Location = new System.Drawing.Point(74, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 200);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.Text = "Datos de Especialidad";

            // Buttons
            this.button2.Location = new System.Drawing.Point(650, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.Text = "Borrar";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            
            this.btnGuardar.Location = new System.Drawing.Point(650, 37);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // Inputs
            this.txtIdEsp.Enabled = false;
            this.txtIdEsp.Location = new System.Drawing.Point(120, 30);
            this.txtIdEsp.Name = "txtIdEsp";
            this.txtIdEsp.Size = new System.Drawing.Size(150, 26);
            
            this.txtNombre.Location = new System.Drawing.Point(120, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 26);
            
            this.txtDescripcion.Location = new System.Drawing.Point(120, 110);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(300, 26);

            // Labels
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 33);
            this.lblId.Text = "Id Esp:";
            
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 73);
            this.lblNombre.Text = "Nombre:";
            
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(20, 113);
            this.lblDesc.Text = "Descripcion:";

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmManEspecialidades";
            this.Text = "Mantenimiento Especialidades";
            this.Load += new System.EventHandler(this.frmManEspecialidades_Load);
            
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManEsp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvManEsp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdEsp;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
    }
}
