using Entidad;
using Negocio;
using SautinSoft.Document;
using SistemaMediar.Dialogo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace SistemaMediar.Presentacion
{
    public partial class FrmNuevoCaso : Form
    {

        private string RutaLocal { get; set; } = "C:\\inetpub\\wwwroot\\ApiFile\\Archivos\\";
        string FullPath;
        public FrmNuevoCaso()
        {
            InitializeComponent();
        }

        private void FrmNuevoCaso_Load(object sender, EventArgs e)
        {
            //numericUpDown1.Value = 1;
            //dgvhijos.ColumnCount = 4;
            //dgvhijos.Columns[0].Name = "Dni";
            //dgvhijos.Columns[1].Name = "Nombres";
            //dgvhijos.Columns[2].Name = "Edad";
            //dgvhijos.Columns[3].Name = "FechaNacimiento";

        }

        private void txtdni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                DlgClientes dlg = new DlgClientes();

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtdni1.Texts = dlg.dnicliente;
                    txtnombre1.Texts = dlg.nombre;
                    txtapellido2.Texts = dlg.apellido;

                }
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            //    if (txtdni.Texts=="")
            //    {
            //        errorProvider1.SetError(txtdni, "poner dni");
            //        txtdni.Focus();
            //        return;

            //    }
            //    errorProvider1.SetError(txtdni, "");
            //    if (txtnombre.Texts=="")
            //    {
            //        errorProvider1.SetError(txtnombre, "poner nombre");
            //        txtnombre.Focus();
            //        return;
            //    }
            //    errorProvider1.SetError(txtnombre, "");
            //    if (txtapellido.Texts=="")
            //    {
            //        errorProvider1.SetError(txtapellido, "poner apellido");
            //        txtapellido.Focus();
            //        return;
            //    }
            //    errorProvider1.SetError(txtapellido, "");
            //    if (txtcodigo.Texts=="")
            //    {
            //        errorProvider1.SetError(txtcodigo, "poner cpodigo caso");
            //        txtcodigo.Focus();
            //        return;
            //    }
            //    errorProvider1.SetError(txtcodigo, "");

               ClsConciliacion con = new ClsConciliacion();
              con.IdEmpresa = 4;
              con.DniCliente = txtdni1.Texts;
            con.Titulo = "Caso nuevo";
            con.Materia = txtmateria.Texts;
            con.IdCaso =1;
            con.Desrcipcioncaso = txtdescripcion.Texts;
            con.Tarfia = 100;
            con.FechaCreacion = DateTime.Now;
            con.FechaActualizacion = DateTime.Now;
            con.Estado = "1";
           int isretur=   con.AddReturId(con);
           // MessageBox.Show(isretur.ToString());
            panel7.BackColor = ColorTranslator.FromHtml("#919294");
            int IdEmpresa = 4;
            WebArchivos client = new WebArchivos();
            String path = FullPath;
            var resul = client.SubirArchivos(path, 4, con.DniCliente);
           // MessageBox.Show(resul);
            string pathDocument = resul;
            if (File.Exists(pathDocument))
            {
                DlgMensajeOk mensaje = new DlgMensajeOk();
                mensaje.mensaje = "Caso Registrado, Abrir Documento ?";
                mensaje.tipo = "Ok";

                string ruta = IdEmpresa.ToString() + "\\" + con.DniCliente + "\\" + txtdescripcion.Texts;

                FileInfo info = new FileInfo(pathDocument);
                var ext = Path.GetExtension(pathDocument);
                string fileName = Path.GetFileName(pathDocument);

                ClsDocumetoConciliacion ar = new ClsDocumetoConciliacion();
                ar.IdEmpresa = IdEmpresa;
                ar.dniCliente = con.DniCliente;
                ar.IdConciliacion = isretur;
                ar.FechaModificaion = DateTime.Now;
                ar.FechaRegistro = DateTime.Now;
                ar.TipoArchivo = ext;
                ar.NombreArchivo = info.Name;
                ar.RutaArchivo = ruta;
                ar.Agregar(ar);

                var doc = DocX.Load(pathDocument);

                doc.ReplaceText("NOMBREPADRE1", txtnombre1.Texts);
                doc.ReplaceText("NOMBREPADRE2", txtnombre2.Texts);
                doc.ReplaceText("DNI1", con.DniCliente);
                doc.ReplaceText("DNI2", txtdni2.Texts);
                doc.ReplaceText("DIRECCION1", txtdireccion1.Texts);
                doc.ReplaceText("NOMBREHIJO1", txtnombrehijo1.Texts);
                doc.ReplaceText("EDAD", txtedadhijo.Texts);
                doc.ReplaceText("FECHANACIMIENTO", ftfechanacimiento1.ToString());
                doc.SaveAs(pathDocument);

                if (mensaje.ShowDialog() == DialogResult.OK)
                {
                    panel7.BackColor = System.Drawing.Color.White;
                    Process.Start("WINWORD.EXE", "\"" + pathDocument + "\"");
                }
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            FrmPrincipal f = FrmPrincipal.GetInstancia();
            f.Abrir(new FrmCasos());          

        }

        private void txtcodigo__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                DlgCasos dlg = new DlgCasos();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                 //   txtcodigo.Texts = dlg.idcaso.ToString();
                    txtmateria.Texts = dlg.materia;
                    txtdescripcion.Texts = dlg.conciliacion;
                    string RutaDocumento = dlg.DocumentoPlantilla;
                    string tipoDocumento = dlg.TipoDocumento;

                     FullPath=  RutaLocal+ RutaDocumento;
                    if (tipoDocumento.Equals(".docx"))
                    {
                        ConvertirWordPdf(FullPath);
                    }
                    
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
                    PageCount = 1,
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

        private void txtmateria__TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] file = File.ReadAllBytes("D:\\DocxExample\\pdfprueba.pdf");              

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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtdireccion__TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
