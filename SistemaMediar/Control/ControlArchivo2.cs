using SistemaMediar.Model;
using SistemaMediar.MyInterface;
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
    public partial class ControlArchivo2 : UserControl
    {

        public event EventHandler<TextChangedEventArgs> changeParentTextWithCustomEvent;
        private String customEventText = "Custom Events FTW!!!";

        public ControlArchivo2()
        {
            InitializeComponent();
           // btnabrir.Click += new EventHandler(btnabrir_Click);

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
        private string extension;
        private int sizes;
        private string ruta;

        

        [Category("Custom Props")]
        public string Nombre
        {
            get { return NombreCarpeta; }
            set { NombreCarpeta = value; lblNombreArchivo.Text = value; }
        }

        [Category("Custom Props")]
        public string FechaC
        {
            get { return Fecha; }
            set { Fecha = value; lblFecha.Text = value; }
        }
               
        //public DateTime Fecha { get; set; }

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; ptbImagen.Image = value; }
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
        public string Extension
        {
            get { return extension; }
            set { extension = value; }
        }
        [Category("Custom Props")]
        public string RutaFile
        {
            get { return ruta; }
            set { ruta = value; }
        }
        private void btnabrir_Click(object sender, EventArgs e)
        {
            //  this.OnClick(e);
            if (changeParentTextWithCustomEvent != null)
            {
                changeParentTextWithCustomEvent(sender, new TextChangedEventArgs(RutaFile, TipoFile, Extension,Nombre));
            }
        }

        private void ControlArchivo2_Load(object sender, EventArgs e)
        {

        }
        public void mensaje(MyInterface.MyInterface myinterface)
        {
            myinterface.Mensaje("hola we");
        }

        //internal void mensaje(Interface @interface)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
