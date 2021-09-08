
namespace SistemaMediar.Control
{
    partial class ControlArchivo2
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnabrir = new SistemaMediar.RJButton();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnabrir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(291, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 57);
            this.panel1.TabIndex = 56;
            // 
            // btnabrir
            // 
            this.btnabrir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnabrir.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnabrir.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnabrir.BorderRadius = 15;
            this.btnabrir.BorderSize = 2;
            this.btnabrir.FlatAppearance.BorderSize = 0;
            this.btnabrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabrir.ForeColor = System.Drawing.Color.LightYellow;
            this.btnabrir.Location = new System.Drawing.Point(5, 18);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(86, 33);
            this.btnabrir.TabIndex = 47;
            this.btnabrir.Text = "Ver";
            this.btnabrir.TextColor = System.Drawing.Color.LightYellow;
            this.btnabrir.UseVisualStyleBackColor = false;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArchivo.Location = new System.Drawing.Point(64, 4);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(57, 20);
            this.lblNombreArchivo.TabIndex = 53;
            this.lblNombreArchivo.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(69, 28);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 54;
            this.lblFecha.Text = "label1";
            // 
            // ptbImagen
            // 
            this.ptbImagen.Location = new System.Drawing.Point(4, 2);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(57, 52);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 52;
            this.ptbImagen.TabStop = false;
            // 
            // ControlArchivo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNombreArchivo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.ptbImagen);
            this.Name = "ControlArchivo2";
            this.Size = new System.Drawing.Size(385, 57);
            this.Load += new System.EventHandler(this.ControlArchivo2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RJButton btnabrir;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox ptbImagen;
    }
}
