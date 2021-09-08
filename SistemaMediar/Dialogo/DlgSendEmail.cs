using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMediar.Dialogo
{
    public partial class DlgSendEmail : Form
    {

        public string RutaArchivo { get; set; }

        public DlgSendEmail()
        {
            InitializeComponent();
        }

        private void DlgSendEmail_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            if (txtnombrecarpeta.Texts=="")
            {
                errorProvider1.SetError(txtnombrecarpeta, "poner correo");
                txtnombrecarpeta.Focus();
                return;
            }
            errorProvider1.SetError(txtnombrecarpeta, "");
            WebArchivos we = new WebArchivos();
            var response =   we.EnviarCorreo(txtnombrecarpeta.Texts, RutaArchivo);
            DlgMensajeOk mensaje = new DlgMensajeOk();
            mensaje.mensaje = response.ToString();
            mensaje.tipo = "Ok";

            if (mensaje.ShowDialog() == DialogResult.OK)
            {
              //  panel3.BackColor = Color.White;
                this.Close();
            }

        }

        private void txtnombrecarpeta__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
