using System.Drawing;
using System.Windows.Forms;

namespace ProyectoOdontologia2025
{
    partial class frmConEval08
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
            this.rdbDescripcion = new System.Windows.Forms.RadioButton();
            this.rdbIdCedula = new System.Windows.Forms.RadioButton();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.rdbObservacion = new System.Windows.Forms.RadioButton();
            this.rdbIdDoctor = new System.Windows.Forms.RadioButton();
            this.rdbCuadrante = new System.Windows.Forms.RadioButton();
            this.rdbIdEvaluacion = new System.Windows.Forms.RadioButton();
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
            this.groupBox4.Location = new System.Drawing.Point(32, 281);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(1470, 258);
            this.groupBox4.TabIndex = 9;
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
            this.dataGridView1.Size = new System.Drawing.Size(1441, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbDescripcion);
            this.groupBox3.Controls.Add(this.rdbIdCedula);
            this.groupBox3.Controls.Add(this.rdbFecha);
            this.groupBox3.Controls.Add(this.rdbObservacion);
            this.groupBox3.Controls.Add(this.rdbIdDoctor);
            this.groupBox3.Controls.Add(this.rdbCuadrante);
            this.groupBox3.Controls.Add(this.rdbIdEvaluacion);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtCriterio);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(430, 86);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(634, 185);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // rdbDescripcion
            // 
            this.rdbDescripcion.AutoSize = true;
            this.rdbDescripcion.Location = new System.Drawing.Point(333, 75);
            this.rdbDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbDescripcion.Name = "rdbDescripcion";
            this.rdbDescripcion.Size = new System.Drawing.Size(117, 24);
            this.rdbDescripcion.TabIndex = 3;
            this.rdbDescripcion.TabStop = true;
            this.rdbDescripcion.Text = "Descripcion";
            this.rdbDescripcion.UseVisualStyleBackColor = true;
            // 
            // rdbIdCedula
            // 
            this.rdbIdCedula.AutoSize = true;
            this.rdbIdCedula.Location = new System.Drawing.Point(486, 43);
            this.rdbIdCedula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbIdCedula.Name = "rdbIdCedula";
            this.rdbIdCedula.Size = new System.Drawing.Size(98, 24);
            this.rdbIdCedula.TabIndex = 3;
            this.rdbIdCedula.TabStop = true;
            this.rdbIdCedula.Text = "IdCedula";
            this.rdbIdCedula.UseVisualStyleBackColor = true;
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Location = new System.Drawing.Point(333, 43);
            this.rdbFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(79, 24);
            this.rdbFecha.TabIndex = 3;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Fecha";
            this.rdbFecha.UseVisualStyleBackColor = true;
            // 
            // rdbObservacion
            // 
            this.rdbObservacion.AutoSize = true;
            this.rdbObservacion.Location = new System.Drawing.Point(180, 75);
            this.rdbObservacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbObservacion.Name = "rdbObservacion";
            this.rdbObservacion.Size = new System.Drawing.Size(122, 24);
            this.rdbObservacion.TabIndex = 3;
            this.rdbObservacion.TabStop = true;
            this.rdbObservacion.Text = "Observacion";
            this.rdbObservacion.UseVisualStyleBackColor = true;
            // 
            // rdbIdDoctor
            // 
            this.rdbIdDoctor.AutoSize = true;
            this.rdbIdDoctor.Location = new System.Drawing.Point(186, 43);
            this.rdbIdDoctor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbIdDoctor.Name = "rdbIdDoctor";
            this.rdbIdDoctor.Size = new System.Drawing.Size(96, 24);
            this.rdbIdDoctor.TabIndex = 3;
            this.rdbIdDoctor.TabStop = true;
            this.rdbIdDoctor.Text = "IdDoctor";
            this.rdbIdDoctor.UseVisualStyleBackColor = true;
            // 
            // rdbCuadrante
            // 
            this.rdbCuadrante.AutoSize = true;
            this.rdbCuadrante.Location = new System.Drawing.Point(33, 75);
            this.rdbCuadrante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbCuadrante.Name = "rdbCuadrante";
            this.rdbCuadrante.Size = new System.Drawing.Size(109, 24);
            this.rdbCuadrante.TabIndex = 3;
            this.rdbCuadrante.TabStop = true;
            this.rdbCuadrante.Text = "Cuadrante";
            this.rdbCuadrante.UseVisualStyleBackColor = true;
            // 
            // rdbIdEvaluacion
            // 
            this.rdbIdEvaluacion.AutoSize = true;
            this.rdbIdEvaluacion.Location = new System.Drawing.Point(33, 43);
            this.rdbIdEvaluacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbIdEvaluacion.Name = "rdbIdEvaluacion";
            this.rdbIdEvaluacion.Size = new System.Drawing.Size(125, 24);
            this.rdbIdEvaluacion.TabIndex = 3;
            this.rdbIdEvaluacion.TabStop = true;
            this.rdbIdEvaluacion.Text = "IdEvaluacion";
            this.rdbIdEvaluacion.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 113);
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
            this.txtCriterio.Size = new System.Drawing.Size(206, 26);
            this.txtCriterio.TabIndex = 1;
            this.txtCriterio.TextChanged += new System.EventHandler(this.txtCriterio_TextChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Consula de Evaluaciones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(1240, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(233, 126);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 75);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 26);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 36);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(232, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Consulta Odontologia\r\nPolitecnico las Mercedes";
            // 
            // frmConEval08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1515, 581);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConEval08";
            this.Text = "frmConEval08";
            this.Load += new System.EventHandler(this.frmConEval08_Load);
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
        private RadioButton rdbDescripcion;
        private RadioButton rdbIdCedula;
        private RadioButton rdbFecha;
        private RadioButton rdbObservacion;
        private RadioButton rdbIdDoctor;
        private RadioButton rdbCuadrante;
        private RadioButton rdbIdEvaluacion;
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
