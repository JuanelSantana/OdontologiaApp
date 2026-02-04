using System.Drawing;
using System.Windows.Forms;

namespace ProyectoOdontologia2025
{
    partial class frmConCita05
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbIdEmpleado = new System.Windows.Forms.RadioButton();
            this.rdbIdDoctor = new System.Windows.Forms.RadioButton();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.rdbCedula = new System.Windows.Forms.RadioButton();
            this.rdbIdCita = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(17, 264);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(765, 306);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(739, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbIdEmpleado);
            this.groupBox3.Controls.Add(this.rdbIdDoctor);
            this.groupBox3.Controls.Add(this.rdbFecha);
            this.groupBox3.Controls.Add(this.rdbCedula);
            this.groupBox3.Controls.Add(this.rdbIdCita);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtCriterio);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(10, 60);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(516, 157);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // rdbIdEmpleado
            // 
            this.rdbIdEmpleado.AutoSize = true;
            this.rdbIdEmpleado.Location = new System.Drawing.Point(382, 37);
            this.rdbIdEmpleado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbIdEmpleado.Name = "rdbIdEmpleado";
            this.rdbIdEmpleado.Size = new System.Drawing.Size(99, 23);
            this.rdbIdEmpleado.TabIndex = 3;
            this.rdbIdEmpleado.TabStop = true;
            this.rdbIdEmpleado.Text = "IdEmpleado";
            this.rdbIdEmpleado.UseVisualStyleBackColor = true;
            // 
            // rdbIdDoctor
            // 
            this.rdbIdDoctor.AutoSize = true;
            this.rdbIdDoctor.Location = new System.Drawing.Point(275, 37);
            this.rdbIdDoctor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbIdDoctor.Name = "rdbIdDoctor";
            this.rdbIdDoctor.Size = new System.Drawing.Size(81, 23);
            this.rdbIdDoctor.TabIndex = 3;
            this.rdbIdDoctor.TabStop = true;
            this.rdbIdDoctor.Text = "IdDoctor";
            this.rdbIdDoctor.UseVisualStyleBackColor = true;
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Location = new System.Drawing.Point(187, 37);
            this.rdbFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(62, 23);
            this.rdbFecha.TabIndex = 3;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Fecha";
            this.rdbFecha.UseVisualStyleBackColor = true;
            // 
            // rdbCedula
            // 
            this.rdbCedula.AutoSize = true;
            this.rdbCedula.Location = new System.Drawing.Point(84, 37);
            this.rdbCedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbCedula.Name = "rdbCedula";
            this.rdbCedula.Size = new System.Drawing.Size(81, 23);
            this.rdbCedula.TabIndex = 3;
            this.rdbCedula.TabStop = true;
            this.rdbCedula.Text = "IdCedula";
            this.rdbCedula.UseVisualStyleBackColor = true;
            // 
            // rdbIdCita
            // 
            this.rdbIdCita.AutoSize = true;
            this.rdbIdCita.Location = new System.Drawing.Point(7, 37);
            this.rdbIdCita.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbIdCita.Name = "rdbIdCita";
            this.rdbIdCita.Size = new System.Drawing.Size(63, 23);
            this.rdbIdCita.TabIndex = 3;
            this.rdbIdCita.TabStop = true;
            this.rdbIdCita.Text = "IdCita";
            this.rdbIdCita.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 104);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "retornar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(176, 101);
            this.txtCriterio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(156, 25);
            this.txtCriterio.TabIndex = 1;
            this.txtCriterio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Digite criterio de busqueda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Consulta de Citas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(593, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(198, 107);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(77, 64);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 31);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(593, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(198, 107);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Consulta Odontologia\r\nPolitecnico las Mercedes";
            // 
            // frmConCita05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConCita05";
            this.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Text = "frmConCita05";
            this.Load += new System.EventHandler(this.frmConCita05_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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

        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private RadioButton rdbIdEmpleado;
        private RadioButton rdbIdDoctor;
        private RadioButton rdbFecha;
        private RadioButton rdbCedula;
        private RadioButton rdbIdCita;
        private Button button1;
        private TextBox txtCriterio;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
    }
}
