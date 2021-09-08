
namespace SistemaMediar.Dialogo
{
    partial class DlgMensajeOk
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
            this.components = new System.ComponentModel.Container();
            this.btnaceptar = new SistemaMediar.RJButton();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.Color.Green;
            this.btnaceptar.BackgroundColor = System.Drawing.Color.Green;
            this.btnaceptar.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnaceptar.BorderRadius = 15;
            this.btnaceptar.BorderSize = 2;
            this.btnaceptar.FlatAppearance.BorderSize = 0;
            this.btnaceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.ForeColor = System.Drawing.Color.LightYellow;
            this.btnaceptar.Location = new System.Drawing.Point(142, 216);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(135, 40);
            this.btnaceptar.TabIndex = 61;
            this.btnaceptar.Text = "OK";
            this.btnaceptar.TextColor = System.Drawing.Color.LightYellow;
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(102, 173);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(155, 24);
            this.lblmensaje.TabIndex = 60;
            this.lblmensaje.Text = "Archivo Creado";
            this.lblmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptb1
            // 
            this.ptb1.Image = global::SistemaMediar.Properties.Resources.animation_500_km2tjo1s;
            this.ptb1.Location = new System.Drawing.Point(106, 17);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(211, 139);
            this.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb1.TabIndex = 59;
            this.ptb1.TabStop = false;
            this.ptb1.Click += new System.EventHandler(this.ptb1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnaceptar);
            this.panel1.Controls.Add(this.ptb1);
            this.panel1.Controls.Add(this.lblmensaje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 308);
            this.panel1.TabIndex = 62;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DlgMensajeOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 308);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DlgMensajeOk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DlgMensajeOk";
            this.Load += new System.EventHandler(this.DlgMensajeOk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RJButton btnaceptar;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}