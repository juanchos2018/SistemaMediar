using Entidad;
using Negocio;
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

namespace SistemaMediar.Dialogo
{
    public partial class DlgNuevoDocumento2 : Form
    {
        public int IdEmpresa { get; set; }
        public string IdCarpeta { get; set; }
        public string Creado { get; set; }
        public int idconciliacion { get; set; }
        public DlgNuevoDocumento2()
        {
            InitializeComponent();
        }

        private void DlgNuevoDocumento2_Load(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtnomword.Texts == "")
            {
                errorProvider1.SetError(txtnomword, "nombre archivo !");
                txtnomword.Focus();
                return;
            }
            errorProvider1.SetError(txtnomword, "");
            crearWord();
        }
        private void crearWord()
        {
            string full = "C:\\files\\";

            string path = full + txtnomword.Texts + ".docx";
            var myFile = File.Create(path);
            myFile.Close();
            WebArchivos client = new WebArchivos();

            var resul = client.SubirArchivos(path, IdEmpresa, IdCarpeta.ToString());

            if (File.Exists(resul))
            {
                string ruta = IdEmpresa.ToString() + "\\" + IdCarpeta.ToString() + "\\" + txtnomword.Texts + ".docx";
                //C:\inetpub\wwwroot\ApiFile\Archivos\4\12\pedifgila.docx

                FileInfo info = new FileInfo(resul);
                var ext = Path.GetExtension(resul);
                string fileName = Path.GetFileName(resul);
                ClsDocumetoConciliacion ar = new ClsDocumetoConciliacion();
                ar.IdEmpresa = IdEmpresa;
                ar.dniCliente = IdCarpeta;
                ar.IdConciliacion = idconciliacion;
                ar.FechaModificaion = DateTime.Now;
                ar.FechaRegistro = DateTime.Now;
                ar.TipoArchivo = ext;
                ar.NombreArchivo = info.Name;
                ar.RutaArchivo = ruta;
                ar.Agregar(ar);

                //ClsArchivo ar = new ClsArchivo();
                //ar.IdCarpeta = int.Parse(IdCarpeta);
                //ar.IdEmpresa = IdEmpresa;
                //ar.NombreArchivo = fileName;
                //ar.Tipo = ext;
                //ar.Size = 100;
                //ar.FechaRegistro = DateTime.Now;
                //ar.Estado = "1";
                //ar.RutaServidor = ruta;
                //ar.FechaRegistro = DateTime.Now;
                //ar.Agregar(ar)


                // MessageBox.Show("Registrado BD");
            }

            DlgOk ok = new DlgOk();
            Creado = "Si";
            //   ok.path = resul;
            if (ok.ShowDialog() == DialogResult.OK)
            {
                //  ok.Estado
                if (ok.Estado.Equals("Abrir"))
                {
                    System.Diagnostics.Process.Start(resul);
                }
                ///C:\inetpub\wwwroot\ApiFile\Archivos\2\1\hoja1.docx
                DialogResult = DialogResult.OK;

            }
            if (File.Exists(path))
            {
                File.Delete(path);
            }

        }
    }
}
