using Entidad;
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
    public partial class DlgCarpeta : Form
    {
        public DlgCarpeta()
        {
            InitializeComponent();
        }

        private void DlgCarpeta_Load(object sender, EventArgs e)
        {
            ClsBotones.BorderPanel(panel1);
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtnombrecarpeta.Texts == "")
            {
                errorProvider1.SetError(txtnombrecarpeta, "llenar Campo");
                txtnombrecarpeta.Focus();
                return;
            }
            errorProvider1.SetError(txtnombrecarpeta, "");

            //ClsCarpeta
            ClsCarpeta car = new ClsCarpeta();
            car.IdEmpresa = 4;
            car.NombreCarpeta = txtnombrecarpeta.Texts;
            car.Estado = "1";
            car.Fecha = DateTime.Now;
            car.Cantidad = 0;
            car.Agregar(car);
            MessageBox.Show("Registrado");
            DialogResult = DialogResult.OK;

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
