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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        const string USUARIO= "admin";
        const string PASSWORD = "123456";

        private void rjTexboxt1__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (txtusuario.Texts==USUARIO && txtclave.Texts==PASSWORD)
            {
                FrmPrincipal f = FrmPrincipal.GetInstancia();
                //Application.Run(Presentacion.FrmPrincipal.GetInstancia());
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
          
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtclave.Texts = "123456";
            txtusuario.Texts = "admin";
        }
    }
}
