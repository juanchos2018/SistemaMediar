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
    public partial class FrmTodosDocumentos : Form
    {

        public string IdCarpeta { get; set; }
        public int IdEmpresa { get; set; } = 4;
        int sizelayout;
        public FrmTodosDocumentos()
        {
            InitializeComponent();
        }

        private void FrmTodosDocumentos_Load(object sender, EventArgs e)
        {
            ListarArchivos();
        }
        private void ListarArchivos()
        {
            //  sizelayout = 937;
            //  FlowLayout.BackColor = Color.White;
            FlowLayout.Controls.Clear();
            // FlowLayout.Dock = DockStyle.Fill;

            ClsArchivo car = new ClsArchivo();
            car.IdEmpresa = IdEmpresa;

            DataTable data = car.ListaTodo(car);
            List<TodosDocumentos> Lista1 = new List<TodosDocumentos>();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                TodosDocumentos objeto = new TodosDocumentos();

                objeto.IdArchivo = int.Parse(data.Rows[i]["IdArchivo"].ToString());
                objeto.Nombre = data.Rows[i]["NombreArchivo"].ToString();
                objeto.RutaServi = data.Rows[i]["RutaServidor"].ToString();
                objeto.FechaRegistro = data.Rows[i]["FechaRegistro"].ToString();
                objeto.NombreCarp = data.Rows[i]["NombreCarpeta"].ToString();
                objeto.TipoArchivo = data.Rows[i]["Tipo"].ToString();
                if (data.Rows[i]["Tipo"].ToString().Equals(".docx") || data.Rows[i]["Tipo"].ToString().Equals(".doc"))
                {
                    objeto.Icon = Resources.imageword;
                }
                else if (data.Rows[i]["Tipo"].ToString().Equals(".pdf"))
                {
                    objeto.Icon = Resources.imagepdf;
                }
                else if (data.Rows[i]["Tipo"].ToString().Equals(".png") || data.Rows[i]["Tipo"].ToString().Equals(".jpg") || data.Rows[i]["Tipo"].ToString().Equals(".jpeg"))
                {
                    objeto.Icon = Resources.logoimagen;
                }
                else if (data.Rows[i]["Tipo"].ToString().Equals(".xls") || data.Rows[i]["Tipo"].ToString().Equals(".xlsx"))
                {
                    objeto.Icon = Resources.exe1;
                }
                else
                {
                    objeto.Icon = Resources.imagepdf;
                }

                Lista1.Add(objeto);
            }

            sizelayout = FlowLayout.Width;
            foreach (var item in Lista1)
            {
                //item.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                item.Width = sizelayout + 100;
                FlowLayout.Controls.Add(item);

            }
        }
        private void txtfiltro__TextChanged(object sender, EventArgs e)
        {
            foreach (TodosDocumentos item in FlowLayout.Controls)
            {
                try
                {
                    if (!item.Nombre.ToLower().Contains(txtfiltro.Texts.ToLower()))
                    {
                        item.Visible = false;
                    }
                    else
                    {
                        item.Visible = true;
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
