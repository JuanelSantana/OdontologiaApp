using System.Drawing;
using System.Windows.Forms;

namespace ProyectoOdontologia2025
{
    partial class frmConPago10
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
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.rdbFormaPago = new System.Windows.Forms.RadioButton();
            this.rdbIdCedula = new System.Windows.Forms.RadioButton();
            this.rdbIdEmpleado = new System.Windows.Forms.RadioButton();
            this.rdbIdCotizacion = new System.Windows.Forms.RadioButton();
            this.rdbMontoPago = new System.Windows.Forms.RadioButton();
            this.rdbIdPago = new System.Windows.Forms.RadioButton();
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
            this.groupBox4.Location = new System.Drawing.Point(32, 286);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(984, 290);
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
            this.dataGridView1.Size = new System.Drawing.Size(950, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbFecha);
            this.groupBox3.Controls.Add(this.rdbFormaPago);
            this.groupBox3.Controls.Add(this.rdbIdCedula);
            this.groupBox3.Controls.Add(this.rdbIdEmpleado);
            this.groupBox3.Controls.Add(this.rdbIdCotizacion);
            this.groupBox3.Controls.Add(this.rdbMontoPago);
            this.groupBox3.Controls.Add(this.rdbIdPago);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtCriterio);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(43, 91);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(656, 185);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Location = new System.Drawing.Point(333, 75);
            this.rdbFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(79, 24);
            this.rdbFecha.TabIndex = 3;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Fecha";
            this.rdbFecha.UseVisualStyleBackColor = true;
            // 
            // rdbFormaPago
            // 
            this.rdbFormaPago.AutoSize = true;
            this.rdbFormaPago.Location = new System.Drawing.Point(486, 43);
            this.rdbFormaPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbFormaPago.Name = "rdbFormaPago";
            this.rdbFormaPago.Size = new System.Drawing.Size(117, 24);
            this.rdbFormaPago.TabIndex = 3;
            this.rdbFormaPago.TabStop = true;
            this.rdbFormaPago.Text = "FormaPago";
            this.rdbFormaPago.UseVisualStyleBackColor = true;
            // 
            // rdbIdCedula
            // 
            this.rdbIdCedula.AutoSize = true;
            this.rdbIdCedula.Location = new System.Drawing.Point(333, 43);
            this.rdbIdCedula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbIdCedula.Name = "rdbIdCedula";
            this.rdbIdCedula.Size = new System.Drawing.Size(98, 24);
            this.rdbIdCedula.TabIndex = 3;
            this.rdbIdCedula.TabStop = true;
            this.rdbIdCedula.Text = "IdCedula";
            this.rdbIdCedula.UseVisualStyleBackColor = true;
            // 
            // rdbIdEmpleado
            // 
            this.rdbIdEmpleado.AutoSize = true;
            this.rdbIdEmpleado.Location = new System.Drawing.Point(180, 75);
            this.rdbIdEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbIdEmpleado.Name = "rdbIdEmpleado";
            this.rdbIdEmpleado.Size = new System.Drawing.Size(120, 24);
            this.rdbIdEmpleado.TabIndex = 3;
            this.rdbIdEmpleado.TabStop = true;
            this.rdbIdEmpleado.Text = "IdEmpleado";
            this.rdbIdEmpleado.UseVisualStyleBackColor = true;
            // 
            // rdbIdCotizacion
            // 
            this.rdbIdCotizacion.AutoSize = true;
            this.rdbIdCotizacion.Location = new System.Drawing.Point(186, 43);
            this.rdbIdCotizacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbIdCotizacion.Name = "rdbIdCotizacion";
            this.rdbIdCotizacion.Size = new System.Drawing.Size(122, 24);
            this.rdbIdCotizacion.TabIndex = 3;
            this.rdbIdCotizacion.TabStop = true;
            this.rdbIdCotizacion.Text = "IdCotizacion";
            this.rdbIdCotizacion.UseVisualStyleBackColor = true;
            // 
            // rdbMontoPago
            // 
            this.rdbMontoPago.AutoSize = true;
            this.rdbMontoPago.Location = new System.Drawing.Point(33, 75);
            this.rdbMontoPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbMontoPago.Name = "rdbMontoPago";
            this.rdbMontoPago.Size = new System.Drawing.Size(116, 24);
            this.rdbMontoPago.TabIndex = 3;
            this.rdbMontoPago.TabStop = true;
            this.rdbMontoPago.Text = "MontoPago";
            this.rdbMontoPago.UseVisualStyleBackColor = true;
            // 
            // rdbIdPago
            // 
            this.rdbIdPago.AutoSize = true;
            this.rdbIdPago.Location = new System.Drawing.Point(33, 43);
            this.rdbIdPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbIdPago.Name = "rdbIdPago";
            this.rdbIdPago.Size = new System.Drawing.Size(85, 24);
            this.rdbIdPago.TabIndex = 3;
            this.rdbIdPago.TabStop = true;
            this.rdbIdPago.Text = "IdPago";
            this.rdbIdPago.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 118);
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
            this.txtCriterio.Size = new System.Drawing.Size(202, 26);
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
            this.label4.Location = new System.Drawing.Point(476, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Consulta de Pagos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(791, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(234, 126);
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
            this.textBox2.Location = new System.Drawing.Point(80, 39);
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
            this.groupBox1.Location = new System.Drawing.Point(791, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(234, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Consulta Odontologia\r\nPolitecnico las Mercedes";
            // 
            // frmConPago10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1053, 600);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConPago10";
            this.Text = "frmConPago10";
            this.Load += new System.EventHandler(this.frmConPago10_Load);
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
        private RadioButton rdbFecha;
        private RadioButton rdbFormaPago;
        private RadioButton rdbIdCedula;
        private RadioButton rdbIdEmpleado;
        private RadioButton rdbIdCotizacion;
        private RadioButton rdbMontoPago;
        private RadioButton rdbIdPago;
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
