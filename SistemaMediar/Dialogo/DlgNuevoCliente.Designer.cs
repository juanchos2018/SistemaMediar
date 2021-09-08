
namespace SistemaMediar.Dialogo
{
    partial class DlgNuevoCliente
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rjButton1 = new SistemaMediar.RJButton();
            this.btnregistrar = new SistemaMediar.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnbuscar = new SistemaMediar.RJButton();
            this.txtapellido = new SistemaMediar.Control.RjTexboxt();
            this.txtnombres = new SistemaMediar.Control.RjTexboxt();
            this.txtdnumerodocumento = new SistemaMediar.Control.RjTexboxt();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtapellido);
            this.panel2.Controls.Add(this.txtnombres);
            this.panel2.Controls.Add(this.txtdnumerodocumento);
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.btnregistrar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 268);
            this.panel2.TabIndex = 46;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(192, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(33, 20);
            this.lblNombre.TabIndex = 47;
            this.lblNombre.Text = "Dni";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(5, 263);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(607, 5);
            this.panel5.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 268);
            this.panel4.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(612, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 268);
            this.panel3.TabIndex = 44;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Red;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Red;
            this.rjButton1.BorderColor = System.Drawing.Color.Red;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.LightYellow;
            this.rjButton1.Location = new System.Drawing.Point(374, 201);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(125, 40);
            this.rjButton1.TabIndex = 41;
            this.rjButton1.Text = "Cerrar";
            this.rjButton1.TextColor = System.Drawing.Color.LightYellow;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.Green;
            this.btnregistrar.BackgroundColor = System.Drawing.Color.Green;
            this.btnregistrar.BorderColor = System.Drawing.Color.Green;
            this.btnregistrar.BorderRadius = 15;
            this.btnregistrar.BorderSize = 2;
            this.btnregistrar.FlatAppearance.BorderSize = 0;
            this.btnregistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.ForeColor = System.Drawing.Color.LightYellow;
            this.btnregistrar.Location = new System.Drawing.Point(195, 201);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(135, 40);
            this.btnregistrar.TabIndex = 40;
            this.btnregistrar.Text = "Crear";
            this.btnregistrar.TextColor = System.Drawing.Color.LightYellow;
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 39);
            this.panel1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(204, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nuevo Cliente";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclose.Location = new System.Drawing.Point(579, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(38, 26);
            this.btnclose.TabIndex = 53;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaMediar.Properties.Resources.Clients;
            this.pictureBox1.Location = new System.Drawing.Point(41, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnbuscar.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnbuscar.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnbuscar.BorderRadius = 10;
            this.btnbuscar.BorderSize = 2;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.LightYellow;
            this.btnbuscar.Location = new System.Drawing.Point(396, 42);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(39, 31);
            this.btnbuscar.TabIndex = 66;
            this.btnbuscar.Text = "O";
            this.btnbuscar.TextColor = System.Drawing.Color.LightYellow;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtapellido
            // 
            this.txtapellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtapellido.BorderColor = System.Drawing.Color.Green;
            this.txtapellido.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtapellido.BorderSize = 2;
            this.txtapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtapellido.Location = new System.Drawing.Point(195, 155);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtapellido.Multiline = false;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Padding = new System.Windows.Forms.Padding(7);
            this.txtapellido.PasswordChar = false;
            this.txtapellido.Size = new System.Drawing.Size(240, 30);
            this.txtapellido.TabIndex = 69;
            this.txtapellido.Texts = "";
            this.txtapellido.UnderlinedStyle = false;
            // 
            // txtnombres
            // 
            this.txtnombres.BackColor = System.Drawing.SystemColors.Window;
            this.txtnombres.BorderColor = System.Drawing.Color.Green;
            this.txtnombres.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtnombres.BorderSize = 2;
            this.txtnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombres.ForeColor = System.Drawing.Color.DimGray;
            this.txtnombres.Location = new System.Drawing.Point(195, 99);
            this.txtnombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombres.Multiline = false;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Padding = new System.Windows.Forms.Padding(7);
            this.txtnombres.PasswordChar = false;
            this.txtnombres.Size = new System.Drawing.Size(240, 30);
            this.txtnombres.TabIndex = 68;
            this.txtnombres.Texts = "";
            this.txtnombres.UnderlinedStyle = false;
            // 
            // txtdnumerodocumento
            // 
            this.txtdnumerodocumento.BackColor = System.Drawing.SystemColors.Window;
            this.txtdnumerodocumento.BorderColor = System.Drawing.Color.Green;
            this.txtdnumerodocumento.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtdnumerodocumento.BorderSize = 2;
            this.txtdnumerodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdnumerodocumento.ForeColor = System.Drawing.Color.DimGray;
            this.txtdnumerodocumento.Location = new System.Drawing.Point(195, 42);
            this.txtdnumerodocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtdnumerodocumento.Multiline = false;
            this.txtdnumerodocumento.Name = "txtdnumerodocumento";
            this.txtdnumerodocumento.Padding = new System.Windows.Forms.Padding(7);
            this.txtdnumerodocumento.PasswordChar = false;
            this.txtdnumerodocumento.Size = new System.Drawing.Size(174, 30);
            this.txtdnumerodocumento.TabIndex = 67;
            this.txtdnumerodocumento.Texts = "";
            this.txtdnumerodocumento.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Apellidos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DlgNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(617, 307);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DlgNuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DlgNuevoCliente";
            this.Load += new System.EventHandler(this.DlgNuevoCliente_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private RJButton rjButton1;
        private RJButton btnregistrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private RJButton btnbuscar;
        private Control.RjTexboxt txtapellido;
        private Control.RjTexboxt txtnombres;
        private Control.RjTexboxt txtdnumerodocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}