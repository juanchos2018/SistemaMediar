
namespace SistemaMediar.Presentacion
{
    partial class FrmCasos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvCasos = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnnuevocaso = new SistemaMediar.RJButton();
            this.txtfiltro = new SistemaMediar.Control.RjTexboxt();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvarchivados = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rjButton1 = new SistemaMediar.RJButton();
            this.rjTexboxt1 = new SistemaMediar.Control.RjTexboxt();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasos)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarchivados)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(877, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 548);
            this.panel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 23);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 525);
            this.panel2.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(21, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(856, 525);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.dgvCasos);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(848, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Casos";
            // 
            // dgvCasos
            // 
            this.dgvCasos.AllowUserToAddRows = false;
            this.dgvCasos.AllowUserToDeleteRows = false;
            this.dgvCasos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCasos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCasos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCasos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCasos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCasos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCasos.EnableHeadersVisualStyles = false;
            this.dgvCasos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCasos.Location = new System.Drawing.Point(3, 51);
            this.dgvCasos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCasos.Name = "dgvCasos";
            this.dgvCasos.ReadOnly = true;
            this.dgvCasos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCasos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCasos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvCasos.Size = new System.Drawing.Size(842, 438);
            this.dgvCasos.TabIndex = 4;
            this.dgvCasos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCasos_CellClick);
            this.dgvCasos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCasos_CellContentClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnnuevocaso);
            this.panel6.Controls.Add(this.txtfiltro);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(842, 48);
            this.panel6.TabIndex = 3;
            // 
            // btnnuevocaso
            // 
            this.btnnuevocaso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevocaso.BackColor = System.Drawing.Color.Green;
            this.btnnuevocaso.BackgroundColor = System.Drawing.Color.Green;
            this.btnnuevocaso.BorderColor = System.Drawing.Color.Green;
            this.btnnuevocaso.BorderRadius = 15;
            this.btnnuevocaso.BorderSize = 2;
            this.btnnuevocaso.FlatAppearance.BorderSize = 0;
            this.btnnuevocaso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnnuevocaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevocaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevocaso.ForeColor = System.Drawing.Color.LightYellow;
            this.btnnuevocaso.Location = new System.Drawing.Point(647, 4);
            this.btnnuevocaso.Name = "btnnuevocaso";
            this.btnnuevocaso.Size = new System.Drawing.Size(193, 40);
            this.btnnuevocaso.TabIndex = 12;
            this.btnnuevocaso.Text = "Nuevo Caso";
            this.btnnuevocaso.TextColor = System.Drawing.Color.LightYellow;
            this.btnnuevocaso.UseVisualStyleBackColor = false;
            this.btnnuevocaso.Click += new System.EventHandler(this.btnnuevocaso_Click);
            // 
            // txtfiltro
            // 
            this.txtfiltro.BackColor = System.Drawing.SystemColors.Window;
            this.txtfiltro.BorderColor = System.Drawing.Color.Green;
            this.txtfiltro.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtfiltro.BorderSize = 2;
            this.txtfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltro.ForeColor = System.Drawing.Color.Black;
            this.txtfiltro.Location = new System.Drawing.Point(19, 9);
            this.txtfiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtfiltro.Multiline = false;
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Padding = new System.Windows.Forms.Padding(7);
            this.txtfiltro.PasswordChar = false;
            this.txtfiltro.Size = new System.Drawing.Size(312, 31);
            this.txtfiltro.TabIndex = 13;
            this.txtfiltro.Texts = "";
            this.txtfiltro.UnderlinedStyle = false;
            this.txtfiltro._TextChanged += new System.EventHandler(this.txtfiltro__TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvarchivados);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(848, 492);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Casos Archivados";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvarchivados
            // 
            this.dgvarchivados.AllowUserToAddRows = false;
            this.dgvarchivados.AllowUserToDeleteRows = false;
            this.dgvarchivados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvarchivados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvarchivados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvarchivados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvarchivados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvarchivados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvarchivados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvarchivados.EnableHeadersVisualStyles = false;
            this.dgvarchivados.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvarchivados.Location = new System.Drawing.Point(0, 48);
            this.dgvarchivados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvarchivados.Name = "dgvarchivados";
            this.dgvarchivados.ReadOnly = true;
            this.dgvarchivados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvarchivados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvarchivados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvarchivados.Size = new System.Drawing.Size(848, 444);
            this.dgvarchivados.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rjButton1);
            this.panel5.Controls.Add(this.rjTexboxt1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(848, 48);
            this.panel5.TabIndex = 4;
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.Green;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Green;
            this.rjButton1.BorderColor = System.Drawing.Color.Green;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.LightYellow;
            this.rjButton1.Location = new System.Drawing.Point(642, 4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(193, 40);
            this.rjButton1.TabIndex = 12;
            this.rjButton1.Text = "Nuevo Caso";
            this.rjButton1.TextColor = System.Drawing.Color.LightYellow;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjTexboxt1
            // 
            this.rjTexboxt1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTexboxt1.BorderColor = System.Drawing.Color.Green;
            this.rjTexboxt1.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.rjTexboxt1.BorderSize = 2;
            this.rjTexboxt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTexboxt1.ForeColor = System.Drawing.Color.Black;
            this.rjTexboxt1.Location = new System.Drawing.Point(19, 9);
            this.rjTexboxt1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTexboxt1.Multiline = false;
            this.rjTexboxt1.Name = "rjTexboxt1";
            this.rjTexboxt1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTexboxt1.PasswordChar = false;
            this.rjTexboxt1.Size = new System.Drawing.Size(312, 31);
            this.rjTexboxt1.TabIndex = 13;
            this.rjTexboxt1.Texts = "";
            this.rjTexboxt1.UnderlinedStyle = false;
            // 
            // FrmCasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 548);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCasos";
            this.Text = "FrmCasos";
            this.Load += new System.EventHandler(this.FrmCasos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasos)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvarchivados)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RJButton btnnuevocaso;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvCasos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage tabPage3;
        private Control.RjTexboxt txtfiltro;
        private System.Windows.Forms.DataGridView dgvarchivados;
        private System.Windows.Forms.Panel panel5;
        private RJButton rjButton1;
        private Control.RjTexboxt rjTexboxt1;
    }
}