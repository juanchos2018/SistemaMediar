using Entidad;
using Negocio;
using Newtonsoft.Json.Linq;
using SistemaMediar.Dialogo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMediar.Presentacion
{
    public partial class FrmNuevoCliente : Form
    {
        public FrmNuevoCliente()
        {
            InitializeComponent();
        }

       

        private void FrmNuevoCliente_Load(object sender, EventArgs e)
        {

        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtdnumerodocumento.Texts=="")
            {
                errorProvider1.SetError(txtdnumerodocumento, "poner numero");
                txtdnumerodocumento.Focus();
                return;

            }
            errorProvider1.SetError(txtdnumerodocumento, "");
            if (txtnombres.Texts=="")
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


            ClsCliente o = new ClsCliente();
            DlgMensajeOk mensaje = new DlgMensajeOk();           
            o.IdEmpresa = 4;
            o.DniCliente = txtdnumerodocumento.Texts;
            //si existe cliente
            if (o.Existe_Cliente(o)==true)
            {
                panel3.BackColor = ColorTranslator.FromHtml("#919294"); 
                mensaje.mensaje = "Dni ya esta Registrado";
                mensaje.tipo = "Admiracion";
              
                if (mensaje.ShowDialog()==DialogResult.OK)
                {
                    panel3.BackColor = Color.White;  
                }
            }
            else
            {
                panel3.BackColor = ColorTranslator.FromHtml("#919294");

                o.NombreCliente = txtnombres.Texts;
                o.ApellidoCliente = txtapellido.Texts;
                o.CelularCliente = txttelefono.Texts;
                o.CorreoCliente = txtcorreo.Texts;
                o.DireccionCliente = txtdireccion.Texts;
                o.Pais = "Peru";
                //o.ProvinciaCliente = cboprovincia.selectedValue;
                o.ProvinciaCliente = "Tacna";
                o.CiudadCliente = "Tacna";
                o.Agregar(o);
                mensaje.mensaje = "Clienre Registrado";
                mensaje.tipo = "Ok";
                if (mensaje.ShowDialog() == DialogResult.OK)
                {
                    panel3.BackColor = Color.White;
                }

            }
          
           
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            ClsClienteWeb cliet = new ClsClienteWeb();
            string dni = txtdnumerodocumento.Texts;
            var response = cliet.ConsultaDni(dni);
            //   MessageBox.Show(response)
            var infouser = JObject.Parse(response);
            if (infouser!=null)
            {
                txtnombres.Texts = infouser["nombre"].ToString();
                txtapellido.Texts = infouser["primer_apellido"].ToString() + " " + infouser["segundo_apellido"].ToString();

            }

        }
    }
}
