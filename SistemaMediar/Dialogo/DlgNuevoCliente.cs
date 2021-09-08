using Entidad;
using Negocio;
using Newtonsoft.Json.Linq;
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
    public partial class DlgNuevoCliente : Form
    {
        public string dni { get; set; }
        public string Nombres { get; set; }
        public DlgNuevoCliente()
        {
            InitializeComponent();
        }

        private void DlgNuevoCliente_Load(object sender, EventArgs e)
        {
            txtdnumerodocumento.Texts = dni;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtdnumerodocumento.Texts!="")
            {
                ClsClienteWeb cliet = new ClsClienteWeb();
                string dni = txtdnumerodocumento.Texts;
                var response = cliet.ConsultaDni(dni);               
                var infouser = JObject.Parse(response);
                if (infouser != null)
                {
                    txtnombres.Texts = infouser["nombre"].ToString();
                    txtapellido.Texts = infouser["primer_apellido"].ToString() + " " + infouser["segundo_apellido"].ToString();
                    Nombres = txtnombres.Texts + " " + txtapellido.Texts;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtdnumerodocumento.Texts == "")
            {
                errorProvider1.SetError(txtdnumerodocumento, "poner numero");
                txtdnumerodocumento.Focus();
                return;
            }
            errorProvider1.SetError(txtdnumerodocumento, "");
            if (txtnombres.Texts == "")
            {
                errorProvider1.SetError(txtnombres, "poner nombre");
                txtdnumerodocumento.Focus();
                return;
            }
            errorProvider1.SetError(txtnombres, "");

            if (txtapellido.Texts == "")
            {
                errorProvider1.SetError(txtapellido, "poner apellido");
                txtdnumerodocumento.Focus();
                return;
            }
            errorProvider1.SetError(txtapellido, "");
            DlgMensajeOk mensaje = new DlgMensajeOk();
            ClsCliente o = new ClsCliente();
            o.NombreCliente = txtnombres.Texts;
            o.ApellidoCliente = txtapellido.Texts;
            o.CelularCliente = "";
            o.CorreoCliente = "";
            o.DireccionCliente = "";
            o.Pais = "Peru";
            //o.ProvinciaCliente = cboprovincia.selectedValue;
            o.ProvinciaCliente = "Tacna";
            o.CiudadCliente = "Tacna";
            o.Agregar(o);

            mensaje.mensaje = "Clienre Registrado";
            mensaje.tipo = "Ok";
            if (mensaje.ShowDialog() == DialogResult.OK)
            {
                // panel3.BackColor = Color.White;
              //  this.Close();
                DialogResult = DialogResult.OK;
                Nombres = txtnombres.Texts + " " + txtapellido.Texts;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
