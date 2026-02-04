namespace ProyectoOdontologia2025
{
    partial class frmManCitas
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
            this.dgvManCit = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            
            this.txtIdUsr = new System.Windows.Forms.TextBox();
            this.txtIdDoc = new System.Windows.Forms.TextBox();
            this.txtIdPac = new System.Windows.Forms.TextBox();
            this.txtIdCita = new System.Windows.Forms.TextBox();

            this.lblEst = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.Label();
            this.lblMtv = new System.Windows.Forms.Label();
            this.lblFec = new System.Windows.Forms.Label();
            this.lblUsr = new System.Windows.Forms.Label();
            this.lblDoc = new System.Windows.Forms.Label();
            this.lblPac = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvManCit)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // groupBox4
            this.groupBox4.Controls.Add(this.dgvManCit);
            this.groupBox4.Location = new System.Drawing.Point(50, 350);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(900, 200);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Citas Registradas";

            // dgvManCit
            this.dgvManCit.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvManCit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManCit.Location = new System.Drawing.Point(20, 30);
            this.dgvManCit.Name = "dgvManCit";
            this.dgvManCit.Size = new System.Drawing.Size(860, 150);
            this.dgvManCit.Click += new System.EventHandler(this.dgvManCit_Click);

            // groupBox3 (Inputs)
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btnGuardar);
            
            this.groupBox3.Controls.Add(this.dtpFecha);
            this.groupBox3.Controls.Add(this.txtComentario);
            this.groupBox3.Controls.Add(this.txtMotivo);
            this.groupBox3.Controls.Add(this.txtEstado);
            
            this.groupBox3.Controls.Add(this.txtIdUsr);
            this.groupBox3.Controls.Add(this.txtIdDoc);
            this.groupBox3.Controls.Add(this.txtIdPac);
            this.groupBox3.Controls.Add(this.txtIdCita);

            this.groupBox3.Controls.Add(this.lblCom);
            this.groupBox3.Controls.Add(this.lblMtv);
            this.groupBox3.Controls.Add(this.lblEst);
            this.groupBox3.Controls.Add(this.lblFec);
            
            this.groupBox3.Controls.Add(this.lblUsr);
            this.groupBox3.Controls.Add(this.lblDoc);
            this.groupBox3.Controls.Add(this.lblPac);
            this.groupBox3.Controls.Add(this.lblId);

            this.groupBox3.Location = new System.Drawing.Point(50, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(900, 220);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Cita";

            // IDs and Basic Info (Left)
            this.lblId.Text = "ID Cita"; this.lblId.Location = new System.Drawing.Point(20, 30); this.lblId.AutoSize = true;
            this.txtIdCita.Location = new System.Drawing.Point(100, 27); this.txtIdCita.Size = new System.Drawing.Size(100, 26);
            this.txtIdCita.Enabled = false;

            this.lblPac.Text = "ID Paciente"; this.lblPac.Location = new System.Drawing.Point(20, 70); this.lblPac.AutoSize = true;
            this.txtIdPac.Location = new System.Drawing.Point(120, 67); this.txtIdPac.Size = new System.Drawing.Size(100, 26);

            this.lblDoc.Text = "ID Doctor"; this.lblDoc.Location = new System.Drawing.Point(20, 110); this.lblDoc.AutoSize = true;
            this.txtIdDoc.Location = new System.Drawing.Point(120, 107); this.txtIdDoc.Size = new System.Drawing.Size(100, 26);

            this.lblUsr.Text = "ID Usuario"; this.lblUsr.Location = new System.Drawing.Point(20, 150); this.lblUsr.AutoSize = true;
            this.txtIdUsr.Location = new System.Drawing.Point(120, 147); this.txtIdUsr.Size = new System.Drawing.Size(100, 26);

            // Details (Middle/Right)
            this.lblFec.Text = "Fecha/Hora"; this.lblFec.Location = new System.Drawing.Point(300, 30); this.lblFec.AutoSize = true;
            this.dtpFecha.Location = new System.Drawing.Point(400, 27); this.dtpFecha.Size = new System.Drawing.Size(200, 26);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.CustomFormat = "yyyy-MM-dd HH:mm";

            this.lblEst.Text = "Estado (ID)"; this.lblEst.Location = new System.Drawing.Point(300, 70); this.lblEst.AutoSize = true;
            this.txtEstado.Location = new System.Drawing.Point(400, 67); this.txtEstado.Size = new System.Drawing.Size(100, 26);

            this.lblMtv.Text = "Motivo"; this.lblMtv.Location = new System.Drawing.Point(300, 100); this.lblMtv.AutoSize = true;
            this.txtMotivo.Location = new System.Drawing.Point(400, 97); this.txtMotivo.Size = new System.Drawing.Size(200, 40);
            this.txtMotivo.Multiline = true;

            this.lblCom.Text = "Coment."; this.lblCom.Location = new System.Drawing.Point(300, 150); this.lblCom.AutoSize = true;
            this.txtComentario.Location = new System.Drawing.Point(400, 147); this.txtComentario.Size = new System.Drawing.Size(200, 60);
            this.txtComentario.Multiline = true;


            // Buttons
            this.btnGuardar.Location = new System.Drawing.Point(750, 50);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.button2.Location = new System.Drawing.Point(750, 100);
            this.button2.Text = "Limpiar/Del";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            
            // Header
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(350, 20);
            this.label5.Text = "Mantenimiento de Citas";

            // Logo & Date
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(790, 16);
            this.groupBox2.Size = new System.Drawing.Size(170, 90);
            this.label4.Text = "Fecha"; this.label4.Location = new System.Drawing.Point(10,25);
            this.textBox1.Location = new System.Drawing.Point(60,22); this.textBox1.Size = new System.Drawing.Size(100,20);
            this.label3.Text = "Hora"; this.label3.Location = new System.Drawing.Point(10,55);
            this.textBox2.Location = new System.Drawing.Point(60,52); this.textBox2.Size = new System.Drawing.Size(100,20);

            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Size = new System.Drawing.Size(200, 90);
            this.label1.Text = "Politecnico"; this.label1.Location = new System.Drawing.Point(10,25);
            this.label2.Text = "Consultorio"; this.label2.Location = new System.Drawing.Point(10,55);


            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmManCitas";
            this.Text = "Mantenimiento Citas";
            this.Load += new System.EventHandler(this.frmManCitas_Load);

            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManCit)).EndInit();
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

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvManCit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGuardar;
        
        private System.Windows.Forms.TextBox txtIdCita;
        private System.Windows.Forms.TextBox txtIdPac;
        private System.Windows.Forms.TextBox txtIdDoc;
        private System.Windows.Forms.TextBox txtIdUsr;
        
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtEstado; // id_eci
        private System.Windows.Forms.TextBox txtComentario; // cmt_cit
        private System.Windows.Forms.DateTimePicker dtpFecha; // fec_cit
        
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPac;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Label lblUsr;
        private System.Windows.Forms.Label lblFec;
        private System.Windows.Forms.Label lblMtv;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.Label lblCom;
        
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
