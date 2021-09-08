using SistemaMediar.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMediar.Dialogo
{
    public partial class DlgMensajeOk : Form
    {
        public string mensaje { get; set; }
        public string img { get; set; }
        public string detalle { get; set; }
        public string tipo { get; set; }
        int contador = 0;

        public DlgMensajeOk()
        {
            InitializeComponent();
        }

        private void DlgMensajeOk_Load(object sender, EventArgs e)
        {
            ClsBotones.BorderPanel(panel1);
            timer1.Start();
            lblmensaje.Text = mensaje;
            if (tipo== "Ok")
            {
                ptb1.Image = Resources.animation_500_km2tjo1s;
            }
            else if (tipo== "Admiracion")
            {
                ptb1.Image = Resources.alerta;
            }
            else
            {
                ptb1.Image = Resources.animation_500_km2tjo1s;
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
           // Close();
            DialogResult = DialogResult.OK;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            if (contador == 2)
            {
                ptb1.Enabled = false;
                timer1.Stop();
                contador = 0;
            }
        }

        private void ptb1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //base.OnPaint(e);
            //int diameter = radius * 2;
            //Size size = new Size(diameter, diameter);
            //int w = size.Width - 1;
            //int h = size.Height - 1;
            //Rectangle arc = new Rectangle(bounds.Location.X, bounds.Location.Y, w, h);
            //GraphicsPath path = new GraphicsPath();
            //path.AddArc(arc, 180, 90);
            //arc.X = bounds.Right - diameter;
            //path.AddArc(arc, 270, 90);
            //arc.Y = bounds.Bottom - diameter;
            //path.AddArc(arc, 0, 90);
            //arc.X = bounds.Left;
            //path.AddArc(arc, 90, 90);
            //path.CloseFigure();
            //GraphicsPath GraphPath = path;
            //this.Region = new Region(GraphPath);
            //using (Pen pen = new Pen(Color.Blue, 1))
            //{
            //    e.Graphics.DrawPath(pen, path);
            //}
        }
    }
}
