using SistemaMediar.Presentacion;
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
    public partial class ControlCarpeta2 : UserControl
    {
        public ControlCarpeta2()
        {
            InitializeComponent();
        }

        [Category("Custom Props")]
        public int IdEmpresa { get; set; }

        [Category("Custom Props")]
        public int IdCarpeta { get; set; }


        private string NombreCarpeta;
        private Image _icon;
        private string Fecha;
        private string Cantidad;
        private string tipo;
        private int sizes;
        private string ruta;


        [Category("Custom Props")]
        public string Nombre
        {
            get { return NombreCarpeta; }
            set { NombreCarpeta = value; lblNombreCarpeta.Text = value; }
        }

        [Category("Custom Props")]
        public string FechaC
        {
            get { return Fecha; }
            set { Fecha = value; lblfecha.Text = value; }
        }

        [Category("Custom Props")]
        public string Can
        {
            get { return Cantidad; }
            set { Cantidad = value; lblcantidad.Text = value; }
        }

        //public DateTime Fecha { get; set; }

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; ptbimagen.Image = value; }
        }

        [Category("Custom Props")]
        public int tamano
        {
            get { return sizes; }
            set { sizes = value; }
        }


        [Category("Custom Props")]
        public string TipoFile
        {
            get { return tipo; }
            set { tipo = value; }
        }
        [Category("Custom Props")]
        public string RutaFile
        {
            get { return ruta; }
            set { ruta = value;  }
        }

        private void ptbimagen_Click(object sender, EventArgs e)
        {

        }

        private void lblcantidad_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreCarpeta_Click(object sender, EventArgs e)
        {

        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void ControlCarpeta2_Load(object sender, EventArgs e)
        {

        }

        private void ptbimagen_DoubleClick(object sender, EventArgs e)
        {
            if (tipo.Equals("Directorio"))
            {
                FrmArchivos2 f = FrmArchivos2.GetInstancia();
                f.ListarSecond("\\" + NombreCarpeta);
            }
        }
    }
}
