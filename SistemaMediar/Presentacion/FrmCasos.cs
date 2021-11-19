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
    public partial class FrmCasos : Form
    {
        public FrmCasos()
        {
            InitializeComponent();
        }

        DataView datafilter;

        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();


        private void FrmCasos_Load(object sender, EventArgs e)
        {
            ListarCasos();
        }

        private void btnnuevocaso_Click(object sender, EventArgs e)
        {
            FrmPrincipal f = FrmPrincipal.GetInstancia();
            f.PonerTexto("Registrar Nuevo Caso");
          /// f.Abrir(new FrmNuevoCaso2());
            f.Abrir(new FrmNuevoCaso());
        }

        private void ListarCasos()
        {
            ClsConciliacion con = new ClsConciliacion();

            con.IdEmpresa = 4;
            datafilter = con.Lista(con).DefaultView;
            dgvCasos.RowHeadersVisible = false;
            dgvCasos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");

            dgvCasos.DataSource = datafilter;
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "Ver";
            button.HeaderText = "Ver";
            button.Text = "Detalle";
            button.FlatStyle = FlatStyle.Flat;
            button.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#007bff");
            button.DefaultCellStyle.ForeColor = Color.White;
            button.UseColumnTextForButtonValue = true;
            dgvCasos.Columns.Add(button);
            dgvCasos.Columns["Ver"].Width = 50;

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    e.Graphics.FillRectangle(new SolidBrush(Color.Red), e.Bounds);
                    break;
                case 1:
                    e.Graphics.FillRectangle(new SolidBrush(Color.Blue), e.Bounds);
                    break;
                default:
                    break;
            }

            // Then draw the current tab button text 
            Rectangle paddedBounds = e.Bounds;
            paddedBounds.Inflate(-2, -2);
            e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, this.Font, SystemBrushes.HighlightText, paddedBounds);

        }

        private void dgvCasos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCasos.Columns[e.ColumnIndex].Name == "Ver")
            {
                FrmPrincipal f = FrmPrincipal.GetInstancia();
                string dni = dgvCasos.Rows[e.RowIndex].Cells["Dni"].Value.ToString();
                int id = int.Parse(dgvCasos.Rows[e.RowIndex].Cells["IdConciliacion"].Value.ToString());
                f.Abrir(new FrmDocumentosCaso(dni, id));
            }
        }

        private void dgvCasos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtfiltro__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtfiltro.Texts.Length > 0)
                {
                    // dt.RowFilter = "Nombre like '%" + txtfilro.text + "%' ";
                    datafilter.RowFilter = " Nombre like '%" + txtfiltro.Texts + "%' or Apellido like '%" + txtfiltro.Texts + "%'";
                    // vcliente.RowFilter = " idcliente like '%" + TxtFiltrar.Text + "%' or Nombre like '%" + TxtFiltrar.Text + "%'";           
                }
                else
                {
                    datafilter.RowFilter = "";
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
