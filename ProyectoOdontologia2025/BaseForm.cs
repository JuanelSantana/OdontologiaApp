using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoOdontologia2025
{
    public class BaseForm : Form
    {
        // Paleta de colores pastel
        private readonly Color FormBackColor = Color.FromArgb(232, 240, 254);      // Azul pastel muy claro
        private readonly Color GroupBoxBackColor = Color.FromArgb(232, 240, 254);  // Crema pastel
        private readonly Color ControlBackColor = Color.FromArgb(232, 240, 254);   // Azul aún más claro
        private readonly Color ControlForeColor = Color.FromArgb(40, 60, 90);      // Azul oscuro suave
        private readonly Color GroupBoxBorderColor = Color.FromArgb(180, 200, 220);// Azul grisáceo para bordes

        public BaseForm()
        {
            this.BackColor = FormBackColor;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.Padding = new Padding(12);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyThemeToControls(this);
        }

        public void ApplyThemeToControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is GroupBox groupBox)
                {
                    groupBox.BackColor = GroupBoxBackColor;
                    groupBox.ForeColor = ControlForeColor;
                    groupBox.Font = new Font(this.Font, FontStyle.Bold);

                    // Opcional: Redibujar el borde del GroupBox (requiere manejo de eventos Paint)
                    groupBox.Paint += (s, pe) =>
                    {
                        pe.Graphics.Clear(GroupBoxBackColor);
                        using (Pen p = new Pen(GroupBoxBorderColor, 1))
                        {
                            pe.Graphics.DrawRectangle(p, 0, 7, groupBox.Width - 1, groupBox.Height - 9);
                        }
                    };
                }
                else if (ctrl is Button)
                {
                    ctrl.BackColor = Color.FromArgb(210, 225, 245); // Azul pastel para botones
                    ctrl.ForeColor = ControlForeColor;
                    ctrl.Font = new Font(this.Font, FontStyle.Bold);
                }
                else if (ctrl is DataGridView dgv)
                {
                    dgv.BackgroundColor = ControlBackColor;
                    dgv.DefaultCellStyle.BackColor = Color.White;
                    dgv.DefaultCellStyle.ForeColor = ControlForeColor;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = GroupBoxBackColor;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = ControlForeColor;
                    dgv.EnableHeadersVisualStyles = false;
                }
                else
                {
                    ctrl.BackColor = ControlBackColor;
                    ctrl.ForeColor = ControlForeColor;
                    ctrl.Font = this.Font;
                }

                // Recursividad para hijos
                if (ctrl.HasChildren)
                    ApplyThemeToControls(ctrl);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
