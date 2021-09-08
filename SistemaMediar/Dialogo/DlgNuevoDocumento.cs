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
    public partial class DlgNuevoDocumento : Form
    {

        public int IdEmpresa { get; set; }
        public string IdCarpeta { get; set; }
        public string Creado { get; set; }


        public DlgNuevoDocumento()
        {
            InitializeComponent();
        }

        private void DlgNuevoDocumento_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtnomword.Texts=="")
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
                ClsArchivo ar = new ClsArchivo();
                ar.IdCarpeta = int.Parse(IdCarpeta);
                ar.IdEmpresa = IdEmpresa;
                ar.NombreArchivo = fileName;
                ar.Tipo = ext;
                ar.Size = 100;
                ar.FechaRegistro = DateTime.Now;
                ar.Estado = "1";
                ar.RutaServidor = ruta;
                ar.FechaRegistro = DateTime.Now;
                ar.Agregar(ar);
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
        private void rjButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtnomword__TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
