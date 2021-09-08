using Entidad;
using Negocio;
using SistemaMediar.Control;
using SistemaMediar.Dialogo;
using SistemaMediar.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMediar.Presentacion
{
    public partial class FrmArchivos : Form
    {
        public string IdCarpeta { get; set; }
        public int IdEmpresa { get; set; }
        int sizelayout = 937;

        public FrmArchivos(string a, string name, int IdEmpre)
        {
            InitializeComponent();
            IdCarpeta = a;
            IdEmpresa = IdEmpre;
           // lblcarpeta.Text = name + "/";

        }

        private void btnnuevocarpeta_Click(object sender, EventArgs e)
        {
            // FlowLayout.BackColor = Color.Gray;
            DlgNuevoDocumento dlg = new DlgNuevoDocumento();
            dlg.IdCarpeta = IdCarpeta;
            dlg.IdEmpresa = IdEmpresa;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.Creado.Equals("Si"))
                {
                    ListarArchivos();
                }
                else
                {
                    FlowLayout.BackColor = Color.White;
                }

            }
            else
            {
                FlowLayout.BackColor = Color.White;
            }
        }

        private void FrmArchivos_Load(object sender, EventArgs e)
        {
            ListarArchivos();
        }

        private void FlowLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListarArchivos()
        {
            FlowLayout.BackColor = Color.White;
            FlowLayout.Controls.Clear();
            FlowLayout.Dock = DockStyle.Fill;
            sizelayout = FlowLayout.Width;
            ClsArchivo car = new ClsArchivo();
            car.IdEmpresa = IdEmpresa;
            car.IdCarpeta = int.Parse(IdCarpeta);
            DataTable data = car.Lista(car);
            List<ControlArchivo> Lista1 = new List<ControlArchivo>();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                ControlArchivo objeto = new ControlArchivo();
                objeto.Tamanocontrol = sizelayout;
                objeto.IdArchivo = int.Parse(data.Rows[i]["IdArchivo"].ToString());
                objeto.Nombre = data.Rows[i]["NombreArchivo"].ToString();
                objeto.RutaServi = data.Rows[i]["RutaServidor"].ToString();
                objeto.FechaRegistro = data.Rows[i]["FechaRegistro"].ToString();
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
            foreach (var item in Lista1)
            {
               
                item.Width = sizelayout + 100;
              
                FlowLayout.Controls.Add(item);
               
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
           /// MessageBox.Show("dsfds");
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "docx files | *.docx"; 
            dialog.Filter = "Word Documents|*.docx|Excel Worksheets|*.xls|PowerPoint Presentations|*.ppt" +
              "|Office Files|*.docx;*.xls;*.ppt" +
              "|All Files|*.*";
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                int IdEmpresa = 4;
                WebArchivos client = new WebArchivos();
                String path = dialog.FileName;
                var resul = client.SubirArchivos(path, IdEmpresa, IdCarpeta.ToString());

                if (File.Exists(resul))
                {
                    FileInfo info = new FileInfo(path);
                    var ext = Path.GetExtension(path);
                    string fileName = Path.GetFileName(path);
                    string ru = IdEmpresa + "\\" + IdCarpeta.ToString() + "\\" + fileName;
                    ClsArchivo ar = new ClsArchivo();
                    ar.IdCarpeta = int.Parse(IdCarpeta);
                    ar.IdEmpresa = IdEmpresa;
                    ar.NombreArchivo = fileName;
                    ar.Tipo = ext;
                    ar.Estado = "1";
                    ar.RutaServidor = ru;
                    ar.Agregar(ar);
                }
                MessageBox.Show("Registrado");
                ListarArchivos();
            }
        }

        private void txtfiltro__TextChanged(object sender, EventArgs e)
        {
            foreach (ControlArchivo item in FlowLayout.Controls)
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
    }
}
