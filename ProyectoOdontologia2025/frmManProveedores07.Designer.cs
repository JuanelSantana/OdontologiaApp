namespace ProyectoOdontologia2025
{
    partial class frmManProveedores07
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
            this.dgvManPro = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdProv = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            
            this.labelTel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();

            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManPro)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // groupBox4
            this.groupBox4.Controls.Add(this.dgvManPro);
            this.groupBox4.Location = new System.Drawing.Point(90, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(800, 200);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Registros";

            // dgvManPro
            this.dgvManPro.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvManPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManPro.Location = new System.Drawing.Point(20, 30);
            this.dgvManPro.Name = "dgvManPro";
            this.dgvManPro.Size = new System.Drawing.Size(760, 150);
            this.dgvManPro.Click += new System.EventHandler(this.dgvManPro_Click);

            // groupBox3
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Controls.Add(this.txtTelefono);
            this.groupBox3.Controls.Add(this.txtLocalidad);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.txtIdProv);
            this.groupBox3.Controls.Add(this.labelTel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(90, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 180);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Proveedor";

            // Buttons
            this.button3.Location = new System.Drawing.Point(650, 130);
            this.button3.Text = "Nuevo";
            this.button3.Click += new System.EventHandler(this.button3_Click);

            this.button2.Location = new System.Drawing.Point(650, 80);
            this.button2.Text = "Borrar";
            this.button2.Click += new System.EventHandler(this.button2_Click);

            this.btnGuardar.Location = new System.Drawing.Point(650, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // Inputs
            this.label6.Location = new System.Drawing.Point(30, 30);
            this.label6.AutoSize = true; this.label6.Text = "ID";
            this.txtIdProv.Location = new System.Drawing.Point(100, 27);
            this.txtIdProv.Enabled = false; this.txtIdProv.Size = new System.Drawing.Size(100, 22);

            this.label7.Location = new System.Drawing.Point(30, 70);
            this.label7.AutoSize = true; this.label7.Text = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(100, 67); 
            this.txtNombre.Size = new System.Drawing.Size(200, 22);

            this.label8.Location = new System.Drawing.Point(30, 110);
            this.label8.AutoSize = true; this.label8.Text = "Loc.";
            this.txtLocalidad.Location = new System.Drawing.Point(100, 107);
            this.txtLocalidad.Size = new System.Drawing.Size(200, 22);

            this.labelTel.Location = new System.Drawing.Point(350, 70);
            this.labelTel.AutoSize = true; this.labelTel.Text = "Telefono";
            this.txtTelefono.Location = new System.Drawing.Point(420, 67);
            this.txtTelefono.Size = new System.Drawing.Size(120, 22);

            // Headers
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(300, 10);
            this.label5.Text = "Mantenimiento Proveedores";

            // Date/Time
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(790, 10);
            this.groupBox2.Size = new System.Drawing.Size(170, 90);
            this.label4.Text = "Fecha"; this.label4.Location = new System.Drawing.Point(10,25);
            this.textBox1.Location = new System.Drawing.Point(60,22); this.textBox1.Size = new System.Drawing.Size(100,20);
            this.label3.Text = "Hora"; this.label3.Location = new System.Drawing.Point(10,55);
            this.textBox2.Location = new System.Drawing.Point(60,52); this.textBox2.Size = new System.Drawing.Size(100,20);

            // Logo
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Size = new System.Drawing.Size(200, 90);
            this.label1.Text = "Politecnico"; this.label1.Location = new System.Drawing.Point(10,25);
            this.label2.Text = "Consultorio"; this.label2.Location = new System.Drawing.Point(10,55);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmManProveedores07";
            this.Text = "Mantenimiento Proveedores";
            this.Activated += new System.EventHandler(this.frmManProveedores07_Activated);
            this.Load += new System.EventHandler(this.frmManProveedores07_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManPro)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Original
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvManPro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdProv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        
        // Added
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label labelTel;

        // Structural
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
