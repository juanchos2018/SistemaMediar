
namespace SistemaMediar.Presentacion
{
    partial class FrmNuevoCaso2
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnlpdfview = new System.Windows.Forms.Panel();
            this.txtnombre1 = new SistemaMediar.Control.RjTexboxt();
            this.txtdni1 = new SistemaMediar.Control.RjTexboxt();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnregistrar = new SistemaMediar.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblnombredoc = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.rjButton1 = new SistemaMediar.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfiltro = new SistemaMediar.Control.RjTexboxt();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ptbfile = new System.Windows.Forms.PictureBox();
            this.panel8.SuspendLayout();
            this.pnlpdfview.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(914, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 562);
            this.panel4.TabIndex = 70;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pnlpdfview);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(449, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(452, 562);
            this.panel8.TabIndex = 72;
            // 
            // pnlpdfview
            // 
            this.pnlpdfview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlpdfview.Controls.Add(this.ptbfile);
            this.pnlpdfview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlpdfview.Location = new System.Drawing.Point(0, 0);
            this.pnlpdfview.Margin = new System.Windows.Forms.Padding(2);
            this.pnlpdfview.Name = "pnlpdfview";
            this.pnlpdfview.Size = new System.Drawing.Size(452, 562);
            this.pnlpdfview.TabIndex = 70;
            this.pnlpdfview.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlpdfview_Paint);
            // 
            // txtnombre1
            // 
            this.txtnombre1.BackColor = System.Drawing.SystemColors.Window;
            this.txtnombre1.BorderColor = System.Drawing.Color.Green;
            this.txtnombre1.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtnombre1.BorderSize = 2;
            this.txtnombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre1.ForeColor = System.Drawing.Color.Black;
            this.txtnombre1.Location = new System.Drawing.Point(95, 58);
            this.txtnombre1.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre1.Multiline = false;
            this.txtnombre1.Name = "txtnombre1";
            this.txtnombre1.Padding = new System.Windows.Forms.Padding(5);
            this.txtnombre1.PasswordChar = false;
            this.txtnombre1.Size = new System.Drawing.Size(235, 26);
            this.txtnombre1.TabIndex = 56;
            this.txtnombre1.Texts = "";
            this.txtnombre1.UnderlinedStyle = false;
            // 
            // txtdni1
            // 
            this.txtdni1.BackColor = System.Drawing.SystemColors.Window;
            this.txtdni1.BorderColor = System.Drawing.Color.Green;
            this.txtdni1.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtdni1.BorderSize = 2;
            this.txtdni1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni1.ForeColor = System.Drawing.Color.Black;
            this.txtdni1.Location = new System.Drawing.Point(5, 58);
            this.txtdni1.Margin = new System.Windows.Forms.Padding(5);
            this.txtdni1.Multiline = false;
            this.txtdni1.Name = "txtdni1";
            this.txtdni1.Padding = new System.Windows.Forms.Padding(5);
            this.txtdni1.PasswordChar = false;
            this.txtdni1.Size = new System.Drawing.Size(90, 27);
            this.txtdni1.TabIndex = 55;
            this.txtdni1.Texts = "";
            this.txtdni1.UnderlinedStyle = false;
            this.txtdni1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdni1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "Dni   (F3)";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 577);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 20);
            this.panel3.TabIndex = 72;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 562);
            this.panel1.TabIndex = 71;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnregistrar.Location = new System.Drawing.Point(339, 52);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(106, 37);
            this.btnregistrar.TabIndex = 13;
            this.btnregistrar.Text = "Abrir";
            this.btnregistrar.TextColor = System.Drawing.Color.LightYellow;
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 15);
            this.panel2.TabIndex = 69;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.Controls.Add(this.FlowLayout);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(13, 15);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(901, 562);
            this.panel7.TabIndex = 74;
            // 
            // FlowLayout
            // 
            this.FlowLayout.AutoScroll = true;
            this.FlowLayout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayout.Location = new System.Drawing.Point(0, 122);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(449, 440);
            this.FlowLayout.TabIndex = 90;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.Controls.Add(this.tableLayoutPanel1);
            this.panel9.Controls.Add(this.rjButton1);
            this.panel9.Controls.Add(this.btnregistrar);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.txtfiltro);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.txtdni1);
            this.panel9.Controls.Add(this.txtnombre1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(449, 122);
            this.panel9.TabIndex = 90;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 344F));
            this.tableLayoutPanel1.Controls.Add(this.lblnombredoc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRuta, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(78, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 27);
            this.tableLayoutPanel1.TabIndex = 97;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblnombredoc
            // 
            this.lblnombredoc.AutoSize = true;
            this.lblnombredoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombredoc.Location = new System.Drawing.Point(23, 0);
            this.lblnombredoc.Name = "lblnombredoc";
            this.lblnombredoc.Size = new System.Drawing.Size(0, 20);
            this.lblnombredoc.TabIndex = 91;
            this.lblnombredoc.Click += new System.EventHandler(this.lblnombredoc_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(3, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(14, 20);
            this.lblRuta.TabIndex = 92;
            this.lblRuta.Text = "-";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Gold;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Gold;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = global::SistemaMediar.Properties.Resources.atrasgreem;
            this.rjButton1.Location = new System.Drawing.Point(3, 86);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 5);
            this.rjButton1.Size = new System.Drawing.Size(62, 33);
            this.rjButton1.TabIndex = 96;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 54;
            this.label2.Text = "Nombre";
            // 
            // txtfiltro
            // 
            this.txtfiltro.BackColor = System.Drawing.SystemColors.Window;
            this.txtfiltro.BorderColor = System.Drawing.Color.Green;
            this.txtfiltro.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtfiltro.BorderSize = 2;
            this.txtfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltro.ForeColor = System.Drawing.Color.Black;
            this.txtfiltro.Location = new System.Drawing.Point(7, 4);
            this.txtfiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtfiltro.Multiline = false;
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Padding = new System.Windows.Forms.Padding(7);
            this.txtfiltro.PasswordChar = false;
            this.txtfiltro.Size = new System.Drawing.Size(430, 31);
            this.txtfiltro.TabIndex = 89;
            this.txtfiltro.Texts = "";
            this.txtfiltro.UnderlinedStyle = false;
            this.txtfiltro._TextChanged += new System.EventHandler(this.txtfiltro__TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ptbfile
            // 
            this.ptbfile.Image = global::SistemaMediar.Properties.Resources.imagenul;
            this.ptbfile.Location = new System.Drawing.Point(124, 159);
            this.ptbfile.Name = "ptbfile";
            this.ptbfile.Size = new System.Drawing.Size(204, 183);
            this.ptbfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbfile.TabIndex = 0;
            this.ptbfile.TabStop = false;
            // 
            // FrmNuevoCaso2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 597);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevoCaso2";
            this.Text = "FrmNuevoCaso2";
            this.Load += new System.EventHandler(this.FrmNuevoCaso2_Load);
            this.panel8.ResumeLayout(false);
            this.pnlpdfview.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pnlpdfview;
        private Control.RjTexboxt txtnombre1;
        private Control.RjTexboxt txtdni1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private RJButton btnregistrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Control.RjTexboxt txtfiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private System.Windows.Forms.Label lblnombredoc;
        private RJButton rjButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.PictureBox ptbfile;
    }
}