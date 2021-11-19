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

namespace SistemaMediar.Control
{
    public partial class DocConciliacion : UserControl
    {


        public DocConciliacion()
        {
            InitializeComponent();
        }
        private string RutaLocal { get; set; } = "C:\\inetpub\\wwwroot\\ApiFile\\Archivos\\";
        //C:\inetpub\wwwroot\ApiFile\Archivos\4\1\files.docx

        [Category("Custom Props")]
        public int IdArchivo { get; set; }
        private string NombreArchivo;
        private Image _icon;
        private string RutaServidor;
        private string Tipo;
        private string CorreoCli;



        [Category("Custom Props")]
        public string Nombre
        {
            get { return NombreArchivo; }
            set { NombreArchivo = value; lblNombreArchivo.Text = value; }
        }
        [Category("Custom Props")]
        public string TipoArchivo
        {
            get { return Tipo; }
            set { Tipo = value; lbltipo.Text = value; }
        }
        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; ptbImagen.Image = value; }
        }

        [Category("Custom Props")]
        private string RutaFisica;
        public string RutaFi
        {
            get { return RutaFisica; }
            set { RutaFisica = value; }
        }


        [Category("Custom Props")]
        public string RutaServi
        {
            get { return RutaServidor; }
            set { RutaServidor = value; }
        }



        [Category("Custom Props")]
        public string correo
        {
            get { return CorreoCli; }
            set { CorreoCli = value; }
        }

        private void lblNombreArchivo_Click(object sender, EventArgs e)
        {

        }

        private void lbltipo_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void DocConciliacion_Load(object sender, EventArgs e)
        {

        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            if (TipoArchivo.Equals(".docx"))
            {
            }
            string ruta = RutaLocal + RutaServi;
            System.Diagnostics.Process.Start(RutaLocal + RutaServi);
        }

        private void btncorreo_Click(object sender, EventArgs e)
        {
            DlgSendEmail dlgmen = new DlgSendEmail();
            dlgmen.Correo = correo;
            dlgmen.ShowDialog();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            DlgMensaje dlgmen = new DlgMensaje();
            dlgmen.ShowDialog();
        }
    }
}
