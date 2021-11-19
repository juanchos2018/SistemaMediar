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
    public partial class FrmPrincipal : Form
    {

        private static FrmPrincipal _instancia;
        public static FrmPrincipal GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmPrincipal();
            }
            return _instancia;

        }
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            PantallaOk();
            Abrir(new FrmDashoard());
            lbltipoformulario.Text = "Inicio";
            btncarpetas2.Visible = false;
        }
        private Form formaction = null;

        public void Abrir(Form frmhijo)
        {
            if (formaction != null)
                formaction.Close();
            formaction = frmhijo;
            frmhijo.TopLevel = false;
            frmhijo.Dock = DockStyle.Fill;
            pnlcontenedor.Controls.Add(frmhijo);
            pnlcontenedor.Tag = frmhijo;
            frmhijo.BringToFront();
            frmhijo.Show();
        }

        private void PantallaOk()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        public void PonerTexto(string tex)
        {
            lbltipoformulario.Text = tex;
        }
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            Abrir(new FrmClientes());
            lbltipoformulario.Text = "Lista de Clientes";
        }

        private void btnincio_Click(object sender, EventArgs e)
        {
            Abrir(new FrmDashoard());
            lbltipoformulario.Text = "Inicio";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abrir(new FrmCasos());
            lbltipoformulario.Text = "Lista de Casos";
        }

        private void btncarpetas_Click(object sender, EventArgs e)
        {
            Abrir(new FrmCarpetas());
            lbltipoformulario.Text = "Lista de Carpetas";
        }

        private void btnapumtes_Click(object sender, EventArgs e)
        {
            Abrir(new FrmApuntes());
            lbltipoformulario.Text = "Lista de Apuntes";
        }

        private void btncarpetas2_Click(object sender, EventArgs e)
        {
            Abrir(FrmArchivos2.GetInstancia());
            lbltipoformulario.Text = "Lista de Archivos";
        }
    }
}
