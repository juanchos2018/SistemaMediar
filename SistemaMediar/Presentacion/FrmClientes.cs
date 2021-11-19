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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        DataView dt;
        private void rjButton2_Click(object sender, EventArgs e)
        {
            FrmPrincipal f = FrmPrincipal.GetInstancia();
            f.PonerTexto("Registrar Nuevo Cliente");
            f.Abrir(new FrmNuevoCliente());
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ListaCliente();
        }

        private void ListaCliente()
        {
            ClsCliente o = new ClsCliente();
            o.IdEmpresa = 4;
            dt = o.Lista(o).DefaultView;
          



            dgv2.DataSource = dt;
            
            DataGridViewButtonColumn btnImg1 = new DataGridViewButtonColumn();
            btnImg1.Name = "Editar";
            btnImg1.HeaderText = "Editar";
            btnImg1.Width = 40;
            btnImg1.Text = "Editar";
            btnImg1.FlatStyle = FlatStyle.Flat;
            btnImg1.UseColumnTextForButtonValue = true;
            btnImg1.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#007bff");
            btnImg1.DefaultCellStyle.ForeColor = Color.White;
            btnImg1.DividerWidth = 3;

            dgv2.Columns.Add(btnImg1);

            DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
            btnVer.Name = "Ver";
            btnVer.HeaderText = "Ver";
            btnVer.Width = 45;
            btnVer.Text = "Detalle";
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ffc107");
            btnVer.DefaultCellStyle.ForeColor = Color.White;
            btnVer.UseColumnTextForButtonValue = true;
            btnVer.DividerWidth = 3;

            dgv2.Columns.Add(btnVer);

            dgv2.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");


            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "Borrar";
            btnDelete.HeaderText = "Borrar";
            btnDelete.Width = 45;
            btnDelete.Text = "Borrar";
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#dc3545");

            btnDelete.DefaultCellStyle.ForeColor = Color.White;
            btnDelete.UseColumnTextForButtonValue = true;

            dgv2.Columns.Add(btnDelete);


            dgv2.Columns["Editar"].Width = 55;
            dgv2.Columns["Ver"].Width = 55;
            dgv2.Columns["Borrar"].Width = 55;


            DataGridViewButtonCell bc = new DataGridViewButtonCell();
            bc.FlatStyle = FlatStyle.Flat;
            bc.Style.BackColor = Color.AliceBlue;
            //  dgv2.Columns.Add(bc);
        }

        private void txtfiltro__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtfiltro.Texts.Length > 0)
                {
                    // dt.RowFilter = "Nombre like '%" + txtfilro.text + "%' ";
                    dt.RowFilter = " Nombre like '%" + txtfiltro.Texts + "%' or Apellido like '%" + txtfiltro.Texts + "%'";
                    // vcliente.RowFilter = " idcliente like '%" + TxtFiltrar.Text + "%' or Nombre like '%" + TxtFiltrar.Text + "%'";           
                }
                else
                {
                    dt.RowFilter = "";

                }
            }
            catch (Exception)
            {

            }
         }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dgv2.Columns[e.ColumnIndex].Name == "Editar")
            {
                // string nombre = this.dgv2.CurrentRow.Cells["Nombre"].Value.ToString();
                string dniCliente = this.dgv2.CurrentRow.Cells["DniCliente"].Value.ToString();
                FrmPrincipal f = FrmPrincipal.GetInstancia();
                f.Abrir(new FrmClienteEditar(dniCliente));
            }

           else if (this.dgv2.Columns[e.ColumnIndex].Name == "Ver")
            {
                string dniCliente = this.dgv2.CurrentRow.Cells["DniCliente"].Value.ToString();
                FrmPrincipal f = FrmPrincipal.GetInstancia();
                f.Abrir(new FrmDetalleCliente(dniCliente));
            }

            else if (this.dgv2.Columns[e.ColumnIndex].Name == "Borrar")
            {
                string dniCliente = this.dgv2.CurrentRow.Cells["DniCliente"].Value.ToString();
                string nombreCliente = this.dgv2.CurrentRow.Cells["Nombre"].Value.ToString();

                DlgMensaje dlgmen = new DlgMensaje();
                dlgmen.Nombre = nombreCliente;
                dlgmen.ShowDialog();

                ///  FrmPrincipal f = FrmPrincipal.GetInstancia();
                //  f.Abrir(new FrmDetalleCliente(dniCliente));
            }
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

