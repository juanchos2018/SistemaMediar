using Entidad;
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
    public partial class FrmClienteEditar : Form
    {
        public string DniCliente { get; set; }

        public FrmClienteEditar(string dni)
        {           
            InitializeComponent();
            DniCliente = dni;
        }

      
        private void FrmClienteEditar_Load(object sender, EventArgs e)
        {
            ClsCliente cli = new ClsCliente();
            cli.DniCliente = DniCliente;
            cli = cli.Registro(cli);
            txtdnumerodocumento.Texts = DniCliente;
            txtnombres.Texts = cli.NombreCliente;
            txtapellido.Texts = cli.ApellidoCliente;
            txttelefono.Texts = cli.CelularCliente;
            txtcorreo.Texts = cli.CorreoCliente;
            txtdireccion.Texts = cli.DireccionCliente;


            txtdnumerodocumento.Enabled = false;


        }

        private void btnregistrar_Click_1(object sender, EventArgs e)
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


            ClsCliente o = new ClsCliente();
            panel3.BackColor = ColorTranslator.FromHtml("#919294");
            DlgMensajeOk mensaje = new DlgMensajeOk();
            o.IdEmpresa = 4;              
            o.DniCliente = DniCliente;
            o.NombreCliente = txtnombres.Texts;
            o.ApellidoCliente = txtapellido.Texts;
            o.CelularCliente = txttelefono.Texts;
            o.CorreoCliente = txtcorreo.Texts;
            o.DireccionCliente = txtdireccion.Texts;
              
            o.Actualizar(o);
            mensaje.mensaje = "Cliente Editaedo";
            mensaje.tipo = "Ok";
            if (mensaje.ShowDialog() == DialogResult.OK)
            {
                panel3.BackColor = Color.White;
            }

            

        }
    }
}
