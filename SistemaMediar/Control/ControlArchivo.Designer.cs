
namespace SistemaMediar.Control
{
    partial class ControlArchivo
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
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnborrar = new SistemaMediar.RJButton();
            this.btncorreo = new SistemaMediar.RJButton();
            this.btnabrir = new SistemaMediar.RJButton();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(105, 49);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(35, 13);
            this.lbltipo.TabIndex = 45;
            this.lbltipo.Text = "label1";
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArchivo.Location = new System.Drawing.Point(99, 5);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(57, 20);
            this.lblNombreArchivo.TabIndex = 43;
            this.lblNombreArchivo.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(105, 32);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 44;
            this.lblFecha.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnborrar);
            this.panel1.Controls.Add(this.btncorreo);
            this.panel1.Controls.Add(this.btnabrir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(218, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 72);
            this.panel1.TabIndex = 46;
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.Red;
            this.btnborrar.BackgroundColor = System.Drawing.Color.Red;
            this.btnborrar.BorderColor = System.Drawing.Color.Red;
            this.btnborrar.BorderRadius = 15;
            this.btnborrar.BorderSize = 2;
            this.btnborrar.FlatAppearance.BorderSize = 0;
            this.btnborrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.ForeColor = System.Drawing.Color.LightYellow;
            this.btnborrar.Location = new System.Drawing.Point(210, 22);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(88, 33);
            this.btnborrar.TabIndex = 49;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.TextColor = System.Drawing.Color.LightYellow;
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btncorreo
            // 
            this.btncorreo.BackColor = System.Drawing.Color.Green;
            this.btncorreo.BackgroundColor = System.Drawing.Color.Green;
            this.btncorreo.BorderColor = System.Drawing.Color.Green;
            this.btncorreo.BorderRadius = 15;
            this.btncorreo.BorderSize = 2;
            this.btncorreo.FlatAppearance.BorderSize = 0;
            this.btncorreo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btncorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncorreo.ForeColor = System.Drawing.Color.LightYellow;
            this.btncorreo.Location = new System.Drawing.Point(117, 23);
            this.btncorreo.Name = "btncorreo";
            this.btncorreo.Size = new System.Drawing.Size(88, 33);
            this.btncorreo.TabIndex = 48;
            this.btncorreo.Text = "Correo";
            this.btncorreo.TextColor = System.Drawing.Color.LightYellow;
            this.btncorreo.UseVisualStyleBackColor = false;
            this.btncorreo.Click += new System.EventHandler(this.btncorreo_Click);
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
            this.btnabrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabrir.ForeColor = System.Drawing.Color.LightYellow;
            this.btnabrir.Location = new System.Drawing.Point(23, 22);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(88, 33);
            this.btnabrir.TabIndex = 47;
            this.btnabrir.Text = "Abrir";
            this.btnabrir.TextColor = System.Drawing.Color.LightYellow;
            this.btnabrir.UseVisualStyleBackColor = false;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // ptbImagen
            // 
            this.ptbImagen.Location = new System.Drawing.Point(18, 4);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(66, 65);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 1;
            this.ptbImagen.TabStop = false;
            // 
            // ControlArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblNombreArchivo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.ptbImagen);
            this.Name = "ControlArchivo";
            this.Size = new System.Drawing.Size(526, 72);
            this.Load += new System.EventHandler(this.ControlArchivo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panel1;
        private RJButton btncorreo;
        private RJButton btnabrir;
        private RJButton btnborrar;
    }
}
