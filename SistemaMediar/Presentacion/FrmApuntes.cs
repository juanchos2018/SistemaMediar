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

namespace SistemaMediar.Presentacion
{
    public partial class FrmApuntes : Form
    {
        public FrmApuntes()
        {
            InitializeComponent();
        }

        private void FrmApuntes_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            ClsApuntes apuntes = new ClsApuntes();
            apuntes.IdEmpresa = 4;
            apuntes.Titulo = txtdescripcion.Texts;
            apuntes.Descripcion = txtdescripcion.Texts;
            apuntes.FechaRegistro = dtpfecha.Value;
            apuntes.Hora = dtphora.Text;
            apuntes.Estado = "Activo";
            apuntes.Tipo = cbotipo.Text;
            apuntes.Agregar(apuntes);
            MessageBox.Show("Registrado");
            Listara();
        }


        private void Listara()
        {
            ClsApuntes apuntes = new ClsApuntes();
            apuntes.IdEmpresa = 4;
            dgvApuntes.DataSource = apuntes.Lista1(apuntes);
            dgvApuntes.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
