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
    public partial class DlgOk : Form
    {

        public string path { get; set; }
        public string Estado { get; set; }

        public DlgOk()
        {
            InitializeComponent();
        }

        private void DlgOk_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Estado = "Abrir";
            DialogResult = DialogResult.OK;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Estado = "Cerrar";
            DialogResult = DialogResult.OK;
        }
        int contador = 0;
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
    }
}
