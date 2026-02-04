using System.Drawing;
using System.Windows.Forms;

namespace ProyectoOdontologia2025
{
    partial class frmConPaci01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbIdSeg = new System.Windows.Forms.RadioButton();
            this.rdbCondicion = new System.Windows.Forms.RadioButton();
            this.rdbTipoPac = new System.Windows.Forms.RadioButton();
            this.rdbCorreo = new System.Windows.Forms.RadioButton();
            this.rdbTel = new System.Windows.Forms.RadioButton();
            this.rdbFechaNac = new System.Windows.Forms.RadioButton();
            this.rdbApellido = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.rdbCedula = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(802, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(226, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Consulta Odontologia\r\nPolitecnico las Mercedes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(800, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(228, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 72);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 26);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 42);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 26);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Consulta de Paciente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbIdSeg);
            this.groupBox3.Controls.Add(this.rdbCondicion);
            this.groupBox3.Controls.Add(this.rdbTipoPac);
            this.groupBox3.Controls.Add(this.rdbCorreo);
            this.groupBox3.Controls.Add(this.rdbTel);
            this.groupBox3.Controls.Add(this.rdbFechaNac);
            this.groupBox3.Controls.Add(this.rdbApellido);
            this.groupBox3.Controls.Add(this.rdbNombre);
            this.groupBox3.Controls.Add(this.rdbCedula);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtCriterio);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(30, 76);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(733, 185);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // rdbIdSeg
            // 
            this.rdbIdSeg.AutoSize = true;
            this.rdbIdSeg.Location = new System.Drawing.Point(632, 43);
            this.rdbIdSeg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbIdSeg.Name = "rdbIdSeg";
            this.rdbIdSeg.Size = new System.Drawing.Size(100, 24);
            this.rdbIdSeg.TabIndex = 3;
            this.rdbIdSeg.TabStop = true;
            this.rdbIdSeg.Text = "IdSeguro";
            this.rdbIdSeg.UseVisualStyleBackColor = true;
            // 
            // rdbCondicion
            // 
            this.rdbCondicion.AutoSize = true;
            this.rdbCondicion.Location = new System.Drawing.Point(486, 43);
            this.rdbCondicion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbCondicion.Name = "rdbCondicion";
            this.rdbCondicion.Size = new System.Drawing.Size(104, 24);
            this.rdbCondicion.TabIndex = 3;
            this.rdbCondicion.TabStop = true;
            this.rdbCondicion.Text = "Condicion";
            this.rdbCondicion.UseVisualStyleBackColor = true;
            // 
            // rdbTipoPac
            // 
            this.rdbTipoPac.AutoSize = true;
            this.rdbTipoPac.Location = new System.Drawing.Point(333, 43);
            this.rdbTipoPac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbTipoPac.Name = "rdbTipoPac";
            this.rdbTipoPac.Size = new System.Drawing.Size(126, 24);
            this.rdbTipoPac.TabIndex = 3;
            this.rdbTipoPac.TabStop = true;
            this.rdbTipoPac.Text = "TipoPaciente";
            this.rdbTipoPac.UseVisualStyleBackColor = true;
            // 
            // rdbCorreo
            // 
            this.rdbCorreo.AutoSize = true;
            this.rdbCorreo.Location = new System.Drawing.Point(478, 75);
            this.rdbCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbCorreo.Name = "rdbCorreo";
            this.rdbCorreo.Size = new System.Drawing.Size(82, 24);
            this.rdbCorreo.TabIndex = 3;
            this.rdbCorreo.TabStop = true;
            this.rdbCorreo.Text = "Correo";
            this.rdbCorreo.UseVisualStyleBackColor = true;
            // 
            // rdbTel
            // 
            this.rdbTel.AutoSize = true;
            this.rdbTel.Location = new System.Drawing.Point(333, 75);
            this.rdbTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbTel.Name = "rdbTel";
            this.rdbTel.Size = new System.Drawing.Size(96, 24);
            this.rdbTel.TabIndex = 3;
            this.rdbTel.TabStop = true;
            this.rdbTel.Text = "Telefono";
            this.rdbTel.UseVisualStyleBackColor = true;
            // 
            // rdbFechaNac
            // 
            this.rdbFechaNac.AutoSize = true;
            this.rdbFechaNac.Location = new System.Drawing.Point(180, 75);
            this.rdbFechaNac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbFechaNac.Name = "rdbFechaNac";
            this.rdbFechaNac.Size = new System.Drawing.Size(107, 24);
            this.rdbFechaNac.TabIndex = 3;
            this.rdbFechaNac.TabStop = true;
            this.rdbFechaNac.Text = "FechaNac";
            this.rdbFechaNac.UseVisualStyleBackColor = true;
            // 
            // rdbApellido
            // 
            this.rdbApellido.AutoSize = true;
            this.rdbApellido.Location = new System.Drawing.Point(186, 43);
            this.rdbApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbApellido.Name = "rdbApellido";
            this.rdbApellido.Size = new System.Drawing.Size(90, 24);
            this.rdbApellido.TabIndex = 3;
            this.rdbApellido.TabStop = true;
            this.rdbApellido.Text = "Apellido";
            this.rdbApellido.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(33, 75);
            this.rdbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(90, 24);
            this.rdbNombre.TabIndex = 3;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // rdbCedula
            // 
            this.rdbCedula.AutoSize = true;
            this.rdbCedula.Location = new System.Drawing.Point(33, 43);
            this.rdbCedula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbCedula.Name = "rdbCedula";
            this.rdbCedula.Size = new System.Drawing.Size(98, 24);
            this.rdbCedula.TabIndex = 3;
            this.rdbCedula.TabStop = true;
            this.rdbCedula.Text = "IdCedula";
            this.rdbCedula.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "retornar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(261, 118);
            this.txtCriterio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(252, 26);
            this.txtCriterio.TabIndex = 1;
            this.txtCriterio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(33, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Digite criterio de busqueda";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(20, 276);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(1328, 307);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1299, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmConPaci01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1392, 613);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConPaci01";
            this.Text = "frmConPaci01";
            this.Load += new System.EventHandler(this.frmConPaci01_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox3;
        private Label label5;
        private Button button1;
        private TextBox txtCriterio;
        private RadioButton rdbIdSeg;
        private RadioButton rdbCondicion;
        private RadioButton rdbTipoPac;
        private RadioButton rdbApellido;
        private RadioButton rdbCedula;
        private TextBox textBox3;
        private TextBox textBox2;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private RadioButton rdbCorreo;
        private RadioButton rdbTel;
        private RadioButton rdbFechaNac;
        private RadioButton rdbNombre;
    }
}
