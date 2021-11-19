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
    public partial class FrmDocumentosCaso : Form
    {
        public string Dnicliente { get; set; }
        public int idconciliacion { get; set; }

        public string IdCarpeta { get; set; }
        public int IdEmpresa { get; set; }

        public string correoCliente { get; set; } = "correo@gmail.com";


        public FrmDocumentosCaso(string dni, int id)
        {
            Dnicliente = dni;
            idconciliacion = id;
            InitializeComponent();
        }
        private void FrmDocumentosCaso_Load(object sender, EventArgs e)
        {
          
            lbldni.Text = Dnicliente;
            DatosCliente(Dnicliente);
            txtidconciliacion.Text = idconciliacion.ToString();

            ListarDocumentos();
        }

        private void DatosCliente(string dni)
        {
            ClsCliente datos = new ClsCliente();
            datos.DniCliente = dni;
            datos = datos.Registro(datos);
            lblnombres.Text = datos.NombreCliente + " " + datos.ApellidoCliente;
            lbltelefono.Text = datos.CelularCliente;
            correoCliente = datos.CorreoCliente;
            lblcorreo.Text = datos.CorreoCliente;

            ClsConciliacion conciliacion = new ClsConciliacion();
            conciliacion.IdConciliacion = idconciliacion;
            conciliacion.IdEmpresa = 4;
            conciliacion = conciliacion.Registro(conciliacion);
            lbltema.Text = conciliacion.Titulo;

            string etado = conciliacion.Estado;

            if (etado.Equals("1"))
            {
                lblestado.Text = "Activo";
                lblestado.ForeColor = Color.Green;
            }
            else
            {
                lblestado.Text = "Cerrado";
                lblestado.ForeColor = Color.Red;

            }


        }
        private void ListarDocumentos()
        {
            int sizelayout = 0;
            FlowLayout.BackColor = Color.White;
            FlowLayout.Controls.Clear();
            ClsDocumetoConciliacion car = new ClsDocumetoConciliacion();
            car.IdEmpresa = 4;
            car.IdConciliacion = idconciliacion;
            DataTable data = car.Lista(car);
            List<DocConciliacion> Lista1 = new List<DocConciliacion>();
            sizelayout = FlowLayout.Width;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DocConciliacion objeto = new DocConciliacion();

                objeto.Nombre = data.Rows[i]["NombreArchivo"].ToString();
                objeto.RutaServi = data.Rows[i]["RutaArchivo"].ToString();
                objeto.TipoArchivo = data.Rows[i]["TipoArchivo"].ToString();
                objeto.correo = correoCliente;
                if (data.Rows[i]["TipoArchivo"].ToString().Equals(".docx") || data.Rows[i]["TipoArchivo"].ToString().Equals(".doc"))
                {
                    objeto.Icon = Resources.imageword;
                }
                else if (data.Rows[i]["TipoArchivo"].ToString().Equals(".pdf"))
                {
                    objeto.Icon = Resources.imagepdf;
                }
                else if (data.Rows[i]["TipoArchivo"].ToString().Equals(".png") || data.Rows[i]["TipoArchivo"].ToString().Equals(".jpg") || data.Rows[i]["TipoArchivo"].ToString().Equals(".jpeg"))
                {
                    objeto.Icon = Resources.logoimagen;
                }
                else if (data.Rows[i]["TipoArchivo"].ToString().Equals(".xls") || data.Rows[i]["TipoArchivo"].ToString().Equals(".xlsx"))
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
                item.Width = sizelayout ;
                FlowLayout.Controls.Add(item);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            DlgArchivarCaso dlg = new DlgArchivarCaso();
            dlg.idConciliacion = idconciliacion;
            dlg.ShowDialog();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnnuevocarpeta_Click(object sender, EventArgs e)
        {
           // FlowLayout.BackColor = Color.Gray;
            DlgNuevoDocumento2 dlg = new DlgNuevoDocumento2();
            dlg.IdCarpeta = Dnicliente;
            dlg.IdEmpresa = 4;
            dlg.idconciliacion = idconciliacion;

      
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.Creado.Equals("Si"))
                {
                    ListarDocumentos();
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

        private void rjButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "docx files | *.docx"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                int IdEmpresa = 4;
                WebArchivos client = new WebArchivos();
                String path = dialog.FileName;
                var resul = client.SubirArchivos(path, IdEmpresa, Dnicliente);
                // FileInfo infofile = new FileInfo(path);
                string namefile = Path.GetFileName(path);
                //txtfiltro.Texts = namefile;
                if (File.Exists(resul))
                {
                    string ruta = IdEmpresa.ToString() + "\\" + Dnicliente + "\\" + namefile;
                    //C:\inetpub\wwwroot\ApiFile\Archivos\4\12\pedifgila.docx

                    FileInfo info = new FileInfo(path);
                    var ext = Path.GetExtension(path);
                    string fileName = Path.GetFileName(path);

                    ClsDocumetoConciliacion ar = new ClsDocumetoConciliacion();
                    ar.IdEmpresa = IdEmpresa;
                    ar.dniCliente = Dnicliente;
                    ar.IdConciliacion = idconciliacion;
                    ar.FechaModificaion = DateTime.Now;
                    ar.FechaRegistro = DateTime.Now;
                    ar.TipoArchivo = ext;
                    ar.NombreArchivo = info.Name;
                    ar.RutaArchivo = ruta;
                    ar.Agregar(ar);

                }
                            
                DlgMensajeOk mensaje = new DlgMensajeOk();
                mensaje.mensaje = "Documento Adjuntado";
                mensaje.tipo = "Ok";
                mensaje.ShowDialog();
                ListarDocumentos();
               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfiltro__TextChanged(object sender, EventArgs e)
        {
            foreach (DocConciliacion item in FlowLayout.Controls)
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
