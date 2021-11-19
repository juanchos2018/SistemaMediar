using Entidad;
using SistemaMediar.Control;
using SistemaMediar.Properties;
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
    public partial class FrmDetalleCliente : Form
    {
        public int IdEmpresa { get; set; } = 4;
        public string DniCliente { get; set; }

        DataView dt;


        public FrmDetalleCliente(string dni)
        {
            InitializeComponent();
            DniCliente = dni;
            txtdniciente.Text = dni;
        }

        private void FrmDetalleCliente_Load(object sender, EventArgs e)
        {
            ListCasos(DniCliente);
            ClsCliente cli = new ClsCliente();
            cli.DniCliente = DniCliente;
            cli = cli.Registro(cli);
            lblnombres.Text = cli.NombreCliente + " " + cli.ApellidoCliente;
            lbltelefono.Text = cli.CelularCliente;
            lbldni.Text = cli.DniCliente;
            txtdniciente.Visible = false;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ListCasos(string dni)
        {
            ClsConciliacion o = new ClsConciliacion();
            o.DniCliente = dni;
            o.IdEmpresa = 4;
            dt = o.ListaDocCliente(o).DefaultView;
          
            dgv2.DataSource = dt;
           
            DataGridViewButtonColumn btnImg1 = new DataGridViewButtonColumn();
            btnImg1.Name = "Documentos";
            btnImg1.HeaderText = "Documentos";
            btnImg1.Width = 40;
            btnImg1.Text = "Ver";
            btnImg1.FlatStyle = FlatStyle.Flat;
            btnImg1.UseColumnTextForButtonValue = true;
            btnImg1.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#007bff");
            btnImg1.DefaultCellStyle.ForeColor = Color.White;
            btnImg1.DividerWidth = 3;
            dgv2.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");
            dgv2.Columns.Add(btnImg1);
            dgv2.RowHeadersVisible = false;

            if (dgv2.Rows.Count>0)
            {
            //    int IdConciliacion = int.Parse(this.dgv2.CurrentRow.Cells["IdConciliacion"].Value.ToString());
                int id = int.Parse( dgv2.Rows[0].Cells["IdConciliacion"].Value.ToString());
               // listarDocumentos(id);
            }
        }

        private void dgv2_Click(object sender, EventArgs e)
        {
           
        }

        private void FlowLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv2.Rows.Count>0)
                {
                    if (this.dgv2.Columns[e.ColumnIndex].Name == "Documentos")
                    {
                        // string nombre = this.dgv2.CurrentRow.Cells["Nombre"].Value.ToString();
                        int IdConciliacion = int.Parse(this.dgv2.CurrentRow.Cells["IdConciliacion"].Value.ToString());
                        if (IdConciliacion != 0)
                        {
                            listarDocumentos(IdConciliacion);
                        }
                    }
                }               
            }
            catch (Exception)
            {              
            }
           
        }
        private void listarDocumentos(int IdConciliacion)
        {
            int sizelayout = 0;
            FlowLayout.BackColor = Color.White;
            FlowLayout.Controls.Clear();
            FlowLayout.Dock = DockStyle.Fill;
            sizelayout = FlowLayout.Width;
            ClsDocumetoConciliacion car = new ClsDocumetoConciliacion();
            car.IdEmpresa = IdEmpresa;
            car.dniCliente = txtdniciente.Text;
            car.IdConciliacion = IdConciliacion;

            DataTable data = car.Lista(car);
            List<ControlCon> Lista1 = new List<ControlCon>();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                ControlCon objeto = new ControlCon();
               // objeto.Tamanocontrol = sizelayout;
              //  objeto.IdArchivo = int.Parse(data.Rows[i]["IdArchivo"].ToString());
                objeto.Nombre = data.Rows[i]["NombreArchivo"].ToString();
                objeto.RutaServi = data.Rows[i]["RutaArchivo"].ToString();
                objeto.FechaRegistro = data.Rows[i]["FechaRegistro"].ToString();
                objeto.TipoArchivo = data.Rows[i]["TipoArchivo"].ToString();
                if (data.Rows[i]["TipoArchivo"].ToString().Equals(".docx") || data.Rows[i]["Tipo"].ToString().Equals(".doc"))
                {
                    objeto.Icon = Resources.imageword;
                }
                else if (data.Rows[i]["TipoArchivo"].ToString().Equals(".pdf"))
                {
                    objeto.Icon = Resources.imagepdf;
                }
                else if (data.Rows[i]["TipoArchivo"].ToString().Equals(".png") || data.Rows[i]["Tipo"].ToString().Equals(".jpg") || data.Rows[i]["Tipo"].ToString().Equals(".jpeg"))
                {
                    objeto.Icon = Resources.logoimagen;
                }
                else if (data.Rows[i]["TipoArchivo"].ToString().Equals(".xls") || data.Rows[i]["Tipo"].ToString().Equals(".xlsx"))
                {
                    objeto.Icon = Resources.exe1;
                }
                else
                {
                    objeto.Icon = Resources.imagepdf;
                }

                Lista1.Add(objeto);
            }
            foreach (var item in Lista1)
            {

                item.Width = sizelayout;

                FlowLayout.Controls.Add(item);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnuevocaso_Click(object sender, EventArgs e)
        {
            FrmPrincipal f = FrmPrincipal.GetInstancia();
            f.PonerTexto("Registrar Nuevo Caso");
            f.Abrir(new FrmNuevoCaso());
        }
    }
}
