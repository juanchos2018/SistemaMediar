
namespace SistemaMediar.Presentacion
{
    partial class FrmApuntes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtdescripcion = new SistemaMediar.Control.RjTexboxt();
            this.rjTexboxt2 = new SistemaMediar.Control.RjTexboxt();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rjButton1 = new SistemaMediar.RJButton();
            this.btnregistrar = new SistemaMediar.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.dtphora = new System.Windows.Forms.DateTimePicker();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.dgvApuntes = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApuntes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtdescripcion.BorderColor = System.Drawing.Color.Green;
            this.txtdescripcion.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtdescripcion.BorderSize = 2;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.txtdescripcion.Location = new System.Drawing.Point(21, 85);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescripcion.Multiline = false;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Padding = new System.Windows.Forms.Padding(7);
            this.txtdescripcion.PasswordChar = false;
            this.txtdescripcion.Size = new System.Drawing.Size(291, 31);
            this.txtdescripcion.TabIndex = 57;
            this.txtdescripcion.Texts = "";
            this.txtdescripcion.UnderlinedStyle = false;
            // 
            // rjTexboxt2
            // 
            this.rjTexboxt2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTexboxt2.BorderColor = System.Drawing.Color.Green;
            this.rjTexboxt2.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.rjTexboxt2.BorderSize = 2;
            this.rjTexboxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexboxt2.ForeColor = System.Drawing.Color.DimGray;
            this.rjTexboxt2.Location = new System.Drawing.Point(44, 359);
            this.rjTexboxt2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexboxt2.Multiline = false;
            this.rjTexboxt2.Name = "rjTexboxt2";
            this.rjTexboxt2.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexboxt2.PasswordChar = false;
            this.rjTexboxt2.Size = new System.Drawing.Size(226, 30);
            this.rjTexboxt2.TabIndex = 56;
            this.rjTexboxt2.Texts = "";
            this.rjTexboxt2.UnderlinedStyle = false;
            this.rjTexboxt2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Descripcion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(22, 501);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(858, 61);
            this.panel5.TabIndex = 60;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rjButton1);
            this.panel6.Controls.Add(this.btnregistrar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(447, 61);
            this.panel6.TabIndex = 48;
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
            this.rjButton1.Location = new System.Drawing.Point(205, 7);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(153, 40);
            this.rjButton1.TabIndex = 14;
            this.rjButton1.Text = "Cancelar";
            this.rjButton1.TextColor = System.Drawing.Color.LightYellow;
            this.rjButton1.UseVisualStyleBackColor = false;
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
            this.btnregistrar.Location = new System.Drawing.Point(12, 7);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(163, 40);
            this.btnregistrar.TabIndex = 13;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.TextColor = System.Drawing.Color.LightYellow;
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(880, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 535);
            this.panel4.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(22, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 27);
            this.panel2.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 562);
            this.panel1.TabIndex = 57;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbotipo);
            this.panel7.Controls.Add(this.dtphora);
            this.panel7.Controls.Add(this.dtpfecha);
            this.panel7.Controls.Add(this.rjTexboxt2);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.txtdescripcion);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(22, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(339, 474);
            this.panel7.TabIndex = 63;
            // 
            // cbotipo
            // 
            this.cbotipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Items.AddRange(new object[] {
            "Audiencia",
            "Reunion",
            "Cita"});
            this.cbotipo.Location = new System.Drawing.Point(22, 24);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(283, 24);
            this.cbotipo.TabIndex = 63;
            // 
            // dtphora
            // 
            this.dtphora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtphora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtphora.Location = new System.Drawing.Point(21, 195);
            this.dtphora.Name = "dtphora";
            this.dtphora.Size = new System.Drawing.Size(113, 22);
            this.dtphora.TabIndex = 62;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(21, 142);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(289, 22);
            this.dtpfecha.TabIndex = 58;
            // 
            // dgvApuntes
            // 
            this.dgvApuntes.AllowUserToAddRows = false;
            this.dgvApuntes.AllowUserToDeleteRows = false;
            this.dgvApuntes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApuntes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvApuntes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApuntes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApuntes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApuntes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApuntes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApuntes.EnableHeadersVisualStyles = false;
            this.dgvApuntes.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvApuntes.Location = new System.Drawing.Point(361, 27);
            this.dgvApuntes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvApuntes.Name = "dgvApuntes";
            this.dgvApuntes.ReadOnly = true;
            this.dgvApuntes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApuntes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvApuntes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvApuntes.Size = new System.Drawing.Size(519, 474);
            this.dgvApuntes.TabIndex = 67;
            // 
            // FrmApuntes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 562);
            this.Controls.Add(this.dgvApuntes);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmApuntes";
            this.Text = "FrmApuntes";
            this.Load += new System.EventHandler(this.FrmApuntes_Load);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApuntes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Control.RjTexboxt txtdescripcion;
        private Control.RjTexboxt rjTexboxt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private RJButton rjButton1;
        private RJButton btnregistrar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvApuntes;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.DateTimePicker dtphora;
        private System.Windows.Forms.ComboBox cbotipo;
    }
}