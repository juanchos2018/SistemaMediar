
namespace SistemaMediar.Control
{
    partial class TodosDocumentos
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
            this.lblcarpeta = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.btnabrir = new SistemaMediar.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcarpeta
            // 
            this.lblcarpeta.AutoSize = true;
            this.lblcarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarpeta.ForeColor = System.Drawing.Color.Green;
            this.lblcarpeta.Location = new System.Drawing.Point(100, 50);
            this.lblcarpeta.Name = "lblcarpeta";
            this.lblcarpeta.Size = new System.Drawing.Size(47, 15);
            this.lblcarpeta.TabIndex = 50;
            this.lblcarpeta.Text = "label1";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(100, 31);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(47, 15);
            this.lbltipo.TabIndex = 49;
            this.lbltipo.Text = "label1";
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArchivo.Location = new System.Drawing.Point(98, 7);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(57, 20);
            this.lblNombreArchivo.TabIndex = 47;
            this.lblNombreArchivo.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(169, 34);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 48;
            this.lblFecha.Text = "label1";
            // 
            // ptbImagen
            // 
            this.ptbImagen.Location = new System.Drawing.Point(9, 3);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(66, 65);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 46;
            this.ptbImagen.TabStop = false;
            // 
            // btnabrir
            // 
            this.btnabrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnabrir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnabrir.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnabrir.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnabrir.BorderRadius = 15;
            this.btnabrir.BorderSize = 2;
            this.btnabrir.FlatAppearance.BorderSize = 0;
            this.btnabrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabrir.ForeColor = System.Drawing.Color.LightYellow;
            this.btnabrir.Location = new System.Drawing.Point(340, 23);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(88, 33);
            this.btnabrir.TabIndex = 51;
            this.btnabrir.Text = "Abrir";
            this.btnabrir.TextColor = System.Drawing.Color.LightYellow;
            this.btnabrir.UseVisualStyleBackColor = false;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // TodosDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.lblcarpeta);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblNombreArchivo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.ptbImagen);
            this.Name = "TodosDocumentos";
            this.Size = new System.Drawing.Size(431, 75);
            this.Load += new System.EventHandler(this.TodosDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcarpeta;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox ptbImagen;
        private RJButton btnabrir;
    }
}
