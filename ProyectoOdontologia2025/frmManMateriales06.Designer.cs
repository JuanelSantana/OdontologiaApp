namespace ProyectoOdontologia2025
{
    partial class frmManMateriales06
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
            this.dgvManMat = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdMaterial = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();

            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCant = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelProv = new System.Windows.Forms.Label();
            
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvManMat)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // groupBox4 (Grid)
            this.groupBox4.Controls.Add(this.dgvManMat);
            this.groupBox4.Location = new System.Drawing.Point(63, 350);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(900, 200);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Registros";

            // dgvManMat
            this.dgvManMat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvManMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManMat.Location = new System.Drawing.Point(14, 32);
            this.dgvManMat.Name = "dgvManMat";
            this.dgvManMat.Size = new System.Drawing.Size(870, 150);
            this.dgvManMat.TabIndex = 0;
            this.dgvManMat.Click += new System.EventHandler(this.dgvManMat_Click);

            // groupBox3 (Inputs)
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btnGuardar);
            
            this.groupBox3.Controls.Add(this.txtProveedor);
            this.groupBox3.Controls.Add(this.txtTipo);
            this.groupBox3.Controls.Add(this.txtCosto);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.txtIdMaterial);

            this.groupBox3.Controls.Add(this.labelProv);
            this.groupBox3.Controls.Add(this.labelTipo);
            this.groupBox3.Controls.Add(this.labelCost);
            this.groupBox3.Controls.Add(this.labelCant); 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);

            this.groupBox3.Location = new System.Drawing.Point(63, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(900, 220);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Material";

            // Buttons
            this.button3.Location = new System.Drawing.Point(750, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 26);
            this.button3.TabIndex = 7;
            this.button3.Text = "Nuevo";
            this.button3.Click += new System.EventHandler(this.button3_Click);

            this.button2.Location = new System.Drawing.Point(750, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Borrar";
            this.button2.Click += new System.EventHandler(this.button2_Click);

            this.btnGuardar.Location = new System.Drawing.Point(750, 50);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 26);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // Controls
            this.label6.Location = new System.Drawing.Point(20, 30);
            this.label6.AutoSize = true; this.label6.Text = "Codigo";
            this.txtIdMaterial.Location = new System.Drawing.Point(90, 27);
            this.txtIdMaterial.Size = new System.Drawing.Size(100, 22);
            this.txtIdMaterial.Enabled = false;

            this.label7.Location = new System.Drawing.Point(20, 70);
            this.label7.AutoSize = true; this.label7.Text = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(90, 67);
            this.txtNombre.Size = new System.Drawing.Size(150, 22);

            this.label8.Location = new System.Drawing.Point(20, 110);
            this.label8.AutoSize = true; this.label8.Text = "Desc.";
            this.txtDescripcion.Location = new System.Drawing.Point(90, 107);
            this.txtDescripcion.Size = new System.Drawing.Size(200, 22);

            // Col 2
            this.labelCant.Location = new System.Drawing.Point(300, 30);
            this.labelCant.AutoSize = true; this.labelCant.Text = "Cantidad";
            this.txtCantidad.Location = new System.Drawing.Point(370, 27);
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);

            this.labelCost.Location = new System.Drawing.Point(300, 70);
            this.labelCost.AutoSize = true; this.labelCost.Text = "Costo";
            this.txtCosto.Location = new System.Drawing.Point(370, 67);
            this.txtCosto.Size = new System.Drawing.Size(100, 22);

            this.labelTipo.Location = new System.Drawing.Point(300, 110);
            this.labelTipo.AutoSize = true; this.labelTipo.Text = "Tipo";
            this.txtTipo.Location = new System.Drawing.Point(370, 107);
            this.txtTipo.Size = new System.Drawing.Size(100, 22);

            this.labelProv.Location = new System.Drawing.Point(300, 150);
            this.labelProv.AutoSize = true; this.labelProv.Text = "Prov (ID)";
            this.txtProveedor.Location = new System.Drawing.Point(370, 147);
            this.txtProveedor.Size = new System.Drawing.Size(100, 22);

            // Header Elements (Keep original style)
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(313, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 21);
            this.label5.Text = "Mantenimiento de Materiales";

            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(790, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 100);
            this.groupBox2.Text = "Fecha/Hora";

            this.label4.Text = "Fecha"; this.label4.Location = new System.Drawing.Point(10,30);
            this.textBox1.Location = new System.Drawing.Point(60,27); this.textBox1.Size = new System.Drawing.Size(100,20);
            
            this.label3.Text = "Hora"; this.label3.Location = new System.Drawing.Point(10,60);
            this.textBox2.Location = new System.Drawing.Point(60,57); this.textBox2.Size = new System.Drawing.Size(100,20);

            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            
            this.label1.Text = "Politecnico Las Mercedes"; this.label1.Location = new System.Drawing.Point(10,30);
            this.label2.Text = "Consultorio Odontologico"; this.label2.Location = new System.Drawing.Point(10,60);


            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmManMateriales06";
            this.Text = "Mantenimiento Materiales";
            this.Activated += new System.EventHandler(this.frmManMateriales06_Activated);
            this.Load += new System.EventHandler(this.frmManMateriales06_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManMat)).EndInit();
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

        // Existing
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvManMat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtIdMaterial;
        
        // Added
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label labelCant;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelProv;
        
        // Structural
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
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
