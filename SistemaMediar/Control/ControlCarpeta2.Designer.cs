
namespace SistemaMediar.Control
{
    partial class ControlCarpeta2
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
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblNombreCarpeta = new System.Windows.Forms.Label();
            this.ptbimagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(108, 41);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(35, 13);
            this.lblfecha.TabIndex = 11;
            this.lblfecha.Text = "label2";
            this.lblfecha.Click += new System.EventHandler(this.lblfecha_Click);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(191, 44);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(35, 13);
            this.lblcantidad.TabIndex = 10;
            this.lblcantidad.Text = "label1";
            this.lblcantidad.Click += new System.EventHandler(this.lblcantidad_Click);
            // 
            // lblNombreCarpeta
            // 
            this.lblNombreCarpeta.AutoSize = true;
            this.lblNombreCarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCarpeta.Location = new System.Drawing.Point(103, 10);
            this.lblNombreCarpeta.Name = "lblNombreCarpeta";
            this.lblNombreCarpeta.Size = new System.Drawing.Size(57, 20);
            this.lblNombreCarpeta.TabIndex = 9;
            this.lblNombreCarpeta.Text = "label1";
            this.lblNombreCarpeta.Click += new System.EventHandler(this.lblNombreCarpeta_Click);
            // 
            // ptbimagen
            // 
            this.ptbimagen.Location = new System.Drawing.Point(13, 10);
            this.ptbimagen.Name = "ptbimagen";
            this.ptbimagen.Size = new System.Drawing.Size(73, 53);
            this.ptbimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbimagen.TabIndex = 8;
            this.ptbimagen.TabStop = false;
            this.ptbimagen.Click += new System.EventHandler(this.ptbimagen_Click);
            this.ptbimagen.DoubleClick += new System.EventHandler(this.ptbimagen_DoubleClick);
            // 
            // ControlCarpeta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.lblNombreCarpeta);
            this.Controls.Add(this.ptbimagen);
            this.Name = "ControlCarpeta2";
            this.Size = new System.Drawing.Size(372, 76);
            this.Load += new System.EventHandler(this.ControlCarpeta2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbimagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblNombreCarpeta;
        private System.Windows.Forms.PictureBox ptbimagen;
    }
}
