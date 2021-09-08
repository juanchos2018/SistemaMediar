
namespace SistemaMediar.Presentacion
{
    partial class FrmCarpetas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtfiltro = new SistemaMediar.Control.RjTexboxt();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnnuevocarpeta = new SistemaMediar.RJButton();
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 553);
            this.panel1.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(22, 527);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(905, 26);
            this.panel3.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(903, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 527);
            this.panel4.TabIndex = 40;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtfiltro);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(22, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(881, 59);
            this.panel5.TabIndex = 42;
            // 
            // txtfiltro
            // 
            this.txtfiltro.BackColor = System.Drawing.SystemColors.Window;
            this.txtfiltro.BorderColor = System.Drawing.Color.Green;
            this.txtfiltro.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtfiltro.BorderSize = 2;
            this.txtfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltro.ForeColor = System.Drawing.Color.Black;
            this.txtfiltro.Location = new System.Drawing.Point(20, 13);
            this.txtfiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtfiltro.Multiline = false;
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Padding = new System.Windows.Forms.Padding(7);
            this.txtfiltro.PasswordChar = false;
            this.txtfiltro.Size = new System.Drawing.Size(312, 31);
            this.txtfiltro.TabIndex = 44;
            this.txtfiltro.Texts = "";
            this.txtfiltro.UnderlinedStyle = false;
            this.txtfiltro._TextChanged += new System.EventHandler(this.txtfiltro__TextChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnnuevocarpeta);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(610, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(271, 59);
            this.panel6.TabIndex = 43;
            // 
            // btnnuevocarpeta
            // 
            this.btnnuevocarpeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevocarpeta.BackColor = System.Drawing.Color.Green;
            this.btnnuevocarpeta.BackgroundColor = System.Drawing.Color.Green;
            this.btnnuevocarpeta.BorderColor = System.Drawing.Color.Green;
            this.btnnuevocarpeta.BorderRadius = 15;
            this.btnnuevocarpeta.BorderSize = 2;
            this.btnnuevocarpeta.FlatAppearance.BorderSize = 0;
            this.btnnuevocarpeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnnuevocarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevocarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevocarpeta.ForeColor = System.Drawing.Color.LightYellow;
            this.btnnuevocarpeta.Location = new System.Drawing.Point(89, 12);
            this.btnnuevocarpeta.Name = "btnnuevocarpeta";
            this.btnnuevocarpeta.Size = new System.Drawing.Size(149, 40);
            this.btnnuevocarpeta.TabIndex = 42;
            this.btnnuevocarpeta.Text = "Nuevo Carpeta";
            this.btnnuevocarpeta.TextColor = System.Drawing.Color.LightYellow;
            this.btnnuevocarpeta.UseVisualStyleBackColor = false;
            this.btnnuevocarpeta.Click += new System.EventHandler(this.btnnuevocarpeta_Click);
            // 
            // FlowLayout
            // 
            this.FlowLayout.AutoScroll = true;
            this.FlowLayout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayout.Location = new System.Drawing.Point(22, 59);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(881, 468);
            this.FlowLayout.TabIndex = 43;
            // 
            // FrmCarpetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 553);
            this.Controls.Add(this.FlowLayout);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCarpetas";
            this.Text = "FrmCarpetas";
            this.Load += new System.EventHandler(this.FrmCarpetas_Load);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private System.Windows.Forms.Panel panel6;
        private RJButton btnnuevocarpeta;
        private Control.RjTexboxt txtfiltro;
    }
}