using Entidad;
using SautinSoft.Document;
using SistemaMediar.Control;
using SistemaMediar.Dialogo;
using SistemaMediar.Model;
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
    public partial class FrmNuevoCaso2 : Form
    {
        public FrmNuevoCaso2()
        {
            InitializeComponent();
        }
        public static string rutaOrigin;


        private string RutaLocal { get; set; } = "C:\\inetpub\\wwwroot\\ApiFile\\Archivos\\";
      
        string RultaArchivos= @"C:\Ejercicios";

        private void FrmNuevoCaso2_Load(object sender, EventArgs e)
        {
            cargarComboMaterias();

          //  txtraiz.Visible = false;
          //  txtraiz.Texts = @"C:\Ejercicios";
            //txtraiz.Texts = "dasdasd";
            lblRuta.Text = @"C:\Ejercicios";
        }
        private void cargarComboMaterias()
        {
            //ClsCarpeta car = new ClsCarpeta();
            //car.IdEmpresa = 4;                          
            //cbomaterias.DataSource = car.Lista(car);
            //if (car.Lista(car).Rows.Count > 0)
            //{
            //    cbomaterias.DisplayMember = "NombreCarpeta";
            //    cbomaterias.ValueMember = "IdCarpeta";
            //   // CargarDgvFiles(Convert.ToInt32(cbomaterias.SelectedValue));
            //}
            ListarInicio();
        }

        private void ListarInicio()
        {
            FlowLayout.Controls.Clear();
            //int si = FlowLayout.Width;
            //   string[] entries = Directory.GetFileSystemEntries(@"C:\Ejercicios", "*", SearchOption.AllDirectories);
            string dir = @"C:\Ejercicios";
            rutaOrigin = @"C:\Ejercicios";

            List<ControlArchivo2> Lista1 = new List<ControlArchivo2>();
            foreach (string d in Directory.GetDirectories(dir))
            {
                ///  dgv.Rows.Add(Path.GetFileName(d));
                ControlArchivo2 objeto = new ControlArchivo2();
                objeto.changeParentTextWithCustomEvent += new EventHandler<TextChangedEventArgs>(log_changeParentTextWithCustomEvent);

                objeto.IdCarpeta = 1;
                objeto.Nombre = Path.GetFileName(d);
                objeto.IdEmpresa = 1;
                objeto.FechaC = "sdsds";
                objeto.Icon = Resources.carpeta1;
                objeto.TipoFile = "Directorio";
                string fullpath = Path.GetFullPath(d);
                objeto.RutaFile = fullpath;
                Lista1.Add(objeto);
            }
           // ControlArchivo2 objeto1 = new ControlArchivo2();
            foreach (string f in Directory.GetFiles(dir))
            {
                ControlArchivo2 objeto = new ControlArchivo2();
                objeto.changeParentTextWithCustomEvent += new EventHandler<TextChangedEventArgs>(log_changeParentTextWithCustomEvent);
                objeto.IdCarpeta = 1;                
                objeto.Nombre = Path.GetFileName(f);
                FileInfo info = new FileInfo(objeto.Nombre);
                string fullpath = Path.GetFullPath(f);                
                objeto.IdEmpresa = 1;
                objeto.RutaFile = fullpath;
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
                objeto.Extension = info.Extension;
                objeto.TipoFile = "File";
                Lista1.Add(objeto);
            }

            foreach (var item in Lista1)
            {
                //item.Width = si;                
                FlowLayout.Controls.Add(item);
            }
           // objeto1.
            //objeto1.mensaje(@interface: new MyInterface()
            //{

            //});


        }
        private void log_changeParentTextWithCustomEvent(object sender, TextChangedEventArgs e)
        {
            //this.Text = e.RutaFile;         
            ptbfile.Visible = false;
            string tipoDocumento = e.Tipo;
            if (tipoDocumento.Equals("File"))
            {
                if (e.Extension.Equals(".docx"))
                {
                 //   FullPath = RutaLocal + e.RutaFile;
                    ConvertirWordPdf(e.RutaFile);                 
                }
                else if (e.Extension.Equals(".pdf"))
                {
                    OpeFilePdf(e.RutaFile);
                }
                lblnombredoc.Text = e.Nombre;
            }
            else if (tipoDocumento.Equals("Directorio"))
            {
                //MessageBox.Show(e.RutaFile);
                SubCarpetas(e.RutaFile);
               // this.pnlpdfview.Controls.Clear();
                ptbfile.Visible = true;
                mostrarFicturi();
            }
        }
        private void mostrarFicturi()
        {
            if (this.pnlpdfview.Controls.Count > 0)
                this.pnlpdfview.Controls.RemoveAt(0);
           // Form fh = formHijo as Form;
            //fh.TopLevel = false;
            //fh.FormBorderStyle = FormBorderStyle.None;
            //fh.Dock = DockStyle.Fill;
            PictureBox picture = new PictureBox();
            picture.Name = "ptbimaen";
            picture.Size = new Size(205, 183);
            picture.Image = Resources.imagenul;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pnlpdfview.Controls.Add(picture);
           // picture.Parent = pnlpdfview;
            picture.Left = (this.pnlpdfview.Width - picture.Width) / 2;
            picture.Top = (this.pnlpdfview.Height - picture.Height) / 2;
            //  this.pnlpdfview.Tag = fh;
            // fh.Show();
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            //   string path = lblRuta.Text + lblnombredoc.Text;
            if (lblRuta.Text!="" && lblnombredoc.Text!="")
            {
                string paht = Path.Combine(lblRuta.Text, lblnombredoc.Text);
                if (File.Exists(paht))
                {
                    string path = Path.Combine(RultaArchivos, txtdni1.Texts);
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                       // Directory.CreateDirectory(path);
                       // System.Diagnostics.Process.Start(paht);
                    }
                   
                }
             
               // MessageBox.Show(paht);
            }
          
           // 
        }

        private void OpeFilePdf(string pathfile)
        {
            if (File.Exists(pathfile))
            {
                byte[] file = File.ReadAllBytes(pathfile);
                MemoryStream stream = new MemoryStream(file);
                if (stream != null)
                {
                    MainForm fv = new MainForm();
                    fv.stream = stream;
                    pnlpdfview.Visible = true;
                    pnlpdfview.Dock = DockStyle.Fill;
                    AbrirFormInPanel(fv);
                    return;
                }
            }
         
        }

        private void ConvertirWordPdf(string fileName)
        {
            byte[] fileData = null;

            DocumentCore dc = DocumentCore.Load(fileName);
            using (MemoryStream ms = new MemoryStream())
            {
                dc.Save(ms, new PdfSaveOptions()
                {
                    PageIndex = 0,
                    PageCount = 2,
                    Compliance = PdfCompliance.PDF_A1a
                });
                fileData = ms.ToArray();
            }
            MemoryStream stream = new MemoryStream(fileData);
            if (stream != null)
            {
                MainForm fv = new MainForm();
                fv.stream = stream;
                pnlpdfview.Visible = true;
                pnlpdfview.Dock = DockStyle.Fill;
                AbrirFormInPanel(fv);
                return;
            }
        }

        private void AbrirFormInPanel(object formHijo)
        {
            if (this.pnlpdfview.Controls.Count > 0)
                this.pnlpdfview.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.pnlpdfview.Controls.Add(fh);
            this.pnlpdfview.Tag = fh;
            fh.Show();
        }

        private void txtfiltro__TextChanged(object sender, EventArgs e)
        {
            foreach (ControlArchivo2 item in FlowLayout.Controls)
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

        private void lblnombredoc_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Retrceder()
        {
            string ruta = lblRuta.Text;
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
               // txtraiz.Texts = nuenvaruta;
                lblRuta.Text = nuenvaruta;
                // ListarSecond2(nuenvaruta);
                SubCarpetas(nuenvaruta);
                lblnombredoc.Text = "";
            }
        }

        public void SubCarpetas(string ruta)
        {
            FlowLayout.Controls.Clear();
            lblnombredoc.Text = "";
            int si = FlowLayout.Width;
            //string raiz = txtraiz.Texts;
        //    txtraiz.Texts =  ruta;
            lblRuta.Text = ruta;
            //string dir = txtraiz.Texts;
            // string dir = @"C:\Ejercicios\"+ ruta;
            List<ControlArchivo2> Lista1 = new List<ControlArchivo2>();

            foreach (string d in Directory.GetDirectories(ruta))
            {                
                ControlArchivo2 objeto = new ControlArchivo2();
                objeto.changeParentTextWithCustomEvent += new EventHandler<TextChangedEventArgs>(log_changeParentTextWithCustomEvent);
                objeto.IdCarpeta = 1;
                objeto.Nombre = Path.GetFileName(d);
                objeto.IdEmpresa = 1;
                objeto.FechaC = "sdsds";
                objeto.Icon = Resources.carpeta1;
                objeto.TipoFile = "Directorio";
                string fullpath = Path.GetFullPath(d);
                objeto.RutaFile = fullpath;
                Lista1.Add(objeto);
            }

            foreach (string f in Directory.GetFiles(ruta))
            {               
                ControlArchivo2 objeto = new ControlArchivo2();
                objeto.changeParentTextWithCustomEvent += new EventHandler<TextChangedEventArgs>(log_changeParentTextWithCustomEvent);
                objeto.IdCarpeta = 1;
                objeto.Nombre = Path.GetFileName(f);
                FileInfo info = new FileInfo(objeto.Nombre);
                string fullpath = Path.GetFullPath(f);
                objeto.IdEmpresa = 1;
                objeto.RutaFile = fullpath;
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
                objeto.Extension = info.Extension;
                objeto.TipoFile = "File";
                //   objeto.RutaFile = info.Name;
                Lista1.Add(objeto);
            }

            foreach (var item in Lista1)
            {
                // item.Width = 1078;               
                FlowLayout.Controls.Add(item);

            }
        }

        public void ListarSecond2(string ruta)
        {
           
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            Retrceder();
        }

        private void txtraiz__TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtdni1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                DlgClientes dlg = new DlgClientes();

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtdni1.Texts = dlg.dnicliente;
                    txtnombre1.Texts = dlg.nombre +" "+ dlg.apellido;
                  //  txtapellido2.Texts = dlg.apellido;
                }
            }
            else if (e.KeyCode==Keys.Enter)
            {
                if (txtdni1.Texts.Length==8)
                {
                    ClsCliente cliente = new ClsCliente();
                    cliente.DniCliente = txtdni1.Texts;
                    if (cliente.Existe_Cliente(cliente))
                    {
                        cliente = cliente.Registro(cliente);
                        txtnombre1.Texts = cliente.NombreCliente+" "+cliente.ApellidoCliente;
                    }
                    else
                    {
                        //  MessageBox.Show("No Existe Cliente");
                        if (MessageBox.Show("Registrar Cliente" + "\n" + "Desea Registrar Cliente ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                          //  MessageBox.Show("abbre dialogo");// GuardarProyecto();
                            DlgNuevoCliente dlg = new DlgNuevoCliente();

                            dlg.dni = txtdni1.Texts;
                            if (dlg.ShowDialog() == DialogResult.OK)
                            {
                                txtnombre1.Texts = dlg.Nombres;
                            }
                        }
                        else
                        {
                           // this.Close();
                        }

                    }
                }
            }
        }

        private void pnlpdfview_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
