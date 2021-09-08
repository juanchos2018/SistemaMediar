using SistemaMediar.Control;
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
    public partial class FrmArchivos2 : Form
    {
        private static FrmArchivos2 _instancia;
        public static string rutaOrigin;


        public static FrmArchivos2 GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmArchivos2();
            }
            return _instancia;
        }
        public FrmArchivos2()
        {
            InitializeComponent();
        }

        private void FrmArchivos2_Load(object sender, EventArgs e)
        {
            txtruta.Text = @"C:\Ejercicios";

            ListarInicio();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void ListarInicio()
        {
            FlowLayout.Controls.Clear();
            int si = FlowLayout.Width;
         //   string[] entries = Directory.GetFileSystemEntries(@"C:\Ejercicios", "*", SearchOption.AllDirectories);
           string dir = @"C:\Ejercicios";
            rutaOrigin = @"C:\Ejercicios";       

            List<ControlCarpeta2> Lista1 = new List<ControlCarpeta2>();
            foreach (string d in Directory.GetDirectories(dir))
            {
                ///  dgv.Rows.Add(Path.GetFileName(d));
                ControlCarpeta2 objeto = new ControlCarpeta2();
                objeto.IdCarpeta = 1;
                objeto.Nombre = Path.GetFileName(d);
                objeto.IdEmpresa = 1;
                objeto.FechaC = "sdsds";
                objeto.Icon = Resources.carpeta1;
                objeto.TipoFile = "Directorio";
                Lista1.Add(objeto);
            }

            foreach (string f in Directory.GetFiles(dir))
            {
                ControlCarpeta2 objeto = new ControlCarpeta2();
                objeto.IdCarpeta = 1;
                objeto.Nombre = Path.GetFileName(f);
                FileInfo info = new FileInfo(objeto.Nombre);
                objeto.IdEmpresa = 1;
                objeto.FechaC = "1212";
                if (info.Extension.ToString().Equals(".docx") || info.Extension.ToString().Equals(".doc"))
                {
                    objeto.Icon = Resources.imageword;
                }
                else if (info.Extension.ToString().Equals(".pdf"))
                {
                    objeto.Icon = Resources.imagepdf;
                }
                else if (info.Extension.ToString().Equals(".png") || info.Extension.ToString().Equals(".jpg") || info.Extension.ToString().Equals(".jpeg"))
                {
                    objeto.Icon = Resources.logoimagen;
                }
                else if (info.Extension.ToString().Equals(".xls") || info.Extension.ToString().Equals(".xlsx") || info.Extension.ToString().Equals(".csv"))
                {
                    objeto.Icon = Resources.exe1;
                }
                else if (info.Extension.ToString().Equals(".txt"))
                {
                    objeto.Icon = Resources.imagentxt;
                }
                else
                {
                    objeto.Icon = Resources.imagenul;
                }
                objeto.TipoFile = "File";
               
                Lista1.Add(objeto);
            }

            foreach (var item in Lista1)
            {
                item.Width = si;
                FlowLayout.Controls.Add(item);
            }
        }


        public void ListarSecond(string ruta)
        {
            FlowLayout.Controls.Clear();
            int si = FlowLayout.Width;
            string raiz = txtruta.Text;

            txtruta.Text = txtruta.Text + ruta;
            string dir = txtruta.Text;
            // string dir = @"C:\Ejercicios\"+ ruta;
            List<ControlCarpeta2> Lista1 = new List<ControlCarpeta2>();

            foreach (string d in Directory.GetDirectories(dir))
            {
                ///  dgv.Rows.Add(Path.GetFileName(d));
                ControlCarpeta2 objeto = new ControlCarpeta2();
                objeto.IdCarpeta = 1;
                objeto.Nombre = Path.GetFileName(d);
                objeto.IdEmpresa = 1;
                objeto.FechaC = "sdsds";
                objeto.Icon = Resources.carpeta1;
                objeto.TipoFile = "Directorio";
                Lista1.Add(objeto);
            }

            foreach (string f in Directory.GetFiles(dir))
            {
                ControlCarpeta2 objeto = new ControlCarpeta2();
               
                objeto.IdCarpeta = 1;
                objeto.Nombre = Path.GetFileName(f);
                FileInfo info = new FileInfo(objeto.Nombre);
                objeto.IdEmpresa = 1;
                objeto.FechaC = "1212";
                if (info.Extension.ToString().Equals(".docx") || info.Extension.ToString().Equals(".doc"))
                {
                    objeto.Icon = Resources.imageword;
                }
                else if (info.Extension.ToString().Equals(".pdf"))
                {
                    objeto.Icon = Resources.imagepdf;
                }
                else if (info.Extension.ToString().Equals(".png") || info.Extension.ToString().Equals(".jpg") || info.Extension.ToString().Equals(".jpeg"))
                {
                    objeto.Icon = Resources.logoimagen;
                }
                else if (info.Extension.ToString().Equals(".xls") || info.Extension.ToString().Equals(".xlsx") || info.Extension.ToString().Equals(".csv"))
                {
                    objeto.Icon = Resources.exe1;
                }
                else if (info.Extension.ToString().Equals(".txt"))
                {
                    objeto.Icon = Resources.imagentxt;
                }
                else
                {
                    objeto.Icon = Resources.imagenul;
                }
                //objeto.Icon = Resources.carpeta1;
                objeto.TipoFile = "File";
             //   objeto.RutaFile = info.Name;
                Lista1.Add(objeto);
            }

            foreach (var item in Lista1)
            {
                // item.Width = 1078;
                item.Width = si;
                FlowLayout.Controls.Add(item);

            }
        }

        public void ListarSecond2(string ruta)
        {
            FlowLayout.Controls.Clear();
            int si = FlowLayout.Width;
            string raiz = txtruta.Text;          
            string dir = txtruta.Text;   
            List<ControlCarpeta2> Lista1 = new List<ControlCarpeta2>();
            foreach (string d in Directory.GetDirectories(dir))
            {
                ///  dgv.Rows.Add(Path.GetFileName(d));
                ControlCarpeta2 objeto = new ControlCarpeta2();
                objeto.IdCarpeta = 1;
                objeto.Nombre = Path.GetFileName(d);
                objeto.IdEmpresa = 1;
                objeto.FechaC = "sdsds";
                objeto.Icon = Resources.carpeta1;
                objeto.TipoFile = "Directorio";
                Lista1.Add(objeto);
            }

            foreach (string f in Directory.GetFiles(dir))
            {
                ControlCarpeta2 objeto = new ControlCarpeta2();
                objeto.IdCarpeta = 1;
                objeto.Nombre = Path.GetFileName(f);
                objeto.IdEmpresa = 1;
                objeto.FechaC = "1212";

                FileInfo info = new FileInfo(objeto.Nombre);
                if (info.Extension.ToString().Equals(".docx") || info.Extension.ToString().Equals(".doc"))
                {
                    objeto.Icon = Resources.imageword;
                }
                else if (info.Extension.ToString().Equals(".pdf"))
                {
                    objeto.Icon = Resources.imagepdf;
                }
                else if (info.Extension.ToString().Equals(".png") || info.Extension.ToString().Equals(".jpg") || info.Extension.ToString().Equals(".jpeg"))
                {
                    objeto.Icon = Resources.logoimagen;
                }
                else if (info.Extension.ToString().Equals(".xls") || info.Extension.ToString().Equals(".xlsx") || info.Extension.ToString().Equals(".csv"))
                {
                    objeto.Icon = Resources.exe1;
                }
                else if (info.Extension.ToString().Equals(".txt"))
                {
                    objeto.Icon = Resources.imagentxt;
                }
                else
                {
                    objeto.Icon = Resources.imagenul;
                }
                objeto.TipoFile = "File";
                Lista1.Add(objeto);
            }

            foreach (var item in Lista1)
            {
                // item.Width = 1078;
                item.Width = si;
                FlowLayout.Controls.Add(item);
            }

        }

        private void FrmArchivos2_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void btnnuevocarpeta_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ruta = txtruta.Text;           
            if (!rutaOrigin.Equals(ruta))
            {                
                string[] pssss = ruta.Split('\\');               
                string nuenvaruta = "";              
                //    pssss = pssss.Where((source, index) => index != size).ToArray();
                pssss = pssss.Take(pssss.Length - 1).ToArray();
                for (int i = 0; i < pssss.Length; i++)
                {
                    nuenvaruta += pssss[i].ToString() + @"\";
                }
                nuenvaruta = nuenvaruta.Remove(nuenvaruta.Length - 1);
                txtruta.Text = nuenvaruta;              
                ListarSecond2(nuenvaruta);
            }
        }
    }
}
