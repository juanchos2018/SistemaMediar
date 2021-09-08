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
    public partial class DlgArchivarCaso : Form
    {
        public int idConciliacion { get; set; }
        public DlgArchivarCaso()
        {
            InitializeComponent();
        }

        private void DlgArchivarCaso_Load(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            ClsConciliacion con = new ClsConciliacion();
            con.IdConciliacion = idConciliacion;
            con.IdEmpresa = 4;
            con.Estado = "2";
            con.Actualizar(con);

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
    }
}
