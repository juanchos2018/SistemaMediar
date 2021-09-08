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
    public partial class DlgClientes : Form
    {

        public string dnicliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        DataView dataFilter;


        public DlgClientes()
        {
            InitializeComponent();
        }

        private void DlgClientes_Load(object sender, EventArgs e)
        {
            LsitarCliente();
        }

        private void LsitarCliente()
        {
            ClsCliente o = new ClsCliente();
            o.IdEmpresa = 4;
            dataFilter = o.Lista2(o).DefaultView;
            dgvclientes.DataSource = dataFilter;
            dgvclientes.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");
        }

        private void item()
        {
            if (dgvclientes.RowCount > 0)
            {
                dnicliente = dgvclientes["Dni", dgvclientes.CurrentCell.RowIndex].Value.ToString(); //de la tabla  TipoMovimientoFF
                nombre = dgvclientes["Nombre", dgvclientes.CurrentCell.RowIndex].Value.ToString();
                apellido = dgvclientes["Apellido", dgvclientes.CurrentCell.RowIndex].Value.ToString();
                DialogResult = DialogResult.OK;
            }
        }
        private void dgvclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            item();
        }

        private void dgvclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvclientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                item();
            }
        }

        private void txtfiltro__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtfiltro.Texts.Length > 0)
                {
                    dataFilter.RowFilter = " Nombre like '%" + txtfiltro.Texts + "%' or Dni like '%" + txtfiltro.Texts + "%'";
                }
                else
                {
                    dataFilter.RowFilter = "";
                }

            }
            catch (Exception)
            {

            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
