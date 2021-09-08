using PdfiumViewer;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            renderToBitmapsToolStripMenuItem.Enabled = false;

            pdfViewer1.Renderer.DisplayRectangleChanged += Renderer_DisplayRectangleChanged;
            pdfViewer1.Renderer.ZoomChanged += Renderer_ZoomChanged;

            pdfViewer1.Renderer.MouseMove += Renderer_MouseMove;
            pdfViewer1.Renderer.MouseLeave += Renderer_MouseLeave;
            ShowPdfLocation(PdfPoint.Empty);

            cutMarginsWhenPrintingToolStripMenuItem.PerformClick();

            _zoom.Text = pdfViewer1.Renderer.Zoom.ToString();

            Disposed += (s, e) => pdfViewer1.Document?.Dispose();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = showMenu;
            toolStrip1.Visible = showtoolStrip;
            pdfViewer1.Document?.Dispose();
            //pdfViewer1.Document =OpenDocument("");
            pdfViewer1.Document = OpenDocument(stream);
            renderToBitmapsToolStripMenuItem.Enabled = true;
            pdfViewer1.Renderer.Zoom = 1;
        }


        void Renderer_DisplayRectangleChanged(object sender, EventArgs e)
        {
            _page.Text = (pdfViewer1.Renderer.Page + 1).ToString();
        }
        void Renderer_ZoomChanged(object sender, EventArgs e)
        {
            _zoom.Text = pdfViewer1.Renderer.Zoom.ToString();
        }
        private void Renderer_MouseLeave(object sender, EventArgs e)
        {
            ShowPdfLocation(PdfPoint.Empty);
        }

        private void Renderer_MouseMove(object sender, MouseEventArgs e)
        {
            ShowPdfLocation(pdfViewer1.Renderer.PointToPdf(e.Location));
        }
        private void ShowPdfLocation(PdfPoint point)
        {
            if (!point.IsValid)
            {
                _pageToolStripLabel.Text = null;
                _coordinatesToolStripLabel.Text = null;
            }
            else
            {
                _pageToolStripLabel.Text = (point.Page + 1).ToString();
                _coordinatesToolStripLabel.Text = point.Location.X + "," + point.Location.Y;
            }
        }
        private PdfDocument OpenDocument(string fileName)
        {
            try
            {
                return PdfDocument.Load(this, fileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private PdfDocument OpenDocument(MemoryStream fileName)
        {
            try
            {
                return PdfDocument.Load(this, fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void OpenFile()
        {
            using (var form = new OpenFileDialog())
            {
                form.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                form.RestoreDirectory = true;
                form.Title = "Open PDF File";

                if (form.ShowDialog(this) != DialogResult.OK)
                {
                    Dispose();
                    return;
                }
                //http://jch.facturadorpro3.oo/print/document/fb1f392c-1311-440a-8a34-a92e1f691512/a4
                pdfViewer1.Document?.Dispose();

                pdfViewer1.Document = OpenDocument(form.FileName);

                renderToBitmapsToolStripMenuItem.Enabled = true;
            }
        }

        private void FitPage(PdfViewerZoomMode zoomMode)
        {
            int page = pdfViewer1.Renderer.Page;
            pdfViewer1.ZoomMode = zoomMode;
            pdfViewer1.Renderer.Zoom = 1;
            pdfViewer1.Renderer.Page = page;
        }

        private void Rotate(PdfRotation rotate)
        {
            // PdfRenderer does not support changes to the loaded document,
            // so we fake it by reloading the document into the renderer.

            int page = pdfViewer1.Renderer.Page;
            var document = pdfViewer1.Document;
            pdfViewer1.Document = null;
            document.RotatePage(page, rotate);
            pdfViewer1.Document = document;
            pdfViewer1.Renderer.Page = page;
        }

        public bool showMenu { get; set; } = false;
        public bool showtoolStrip { get; set; } = false;
        public MemoryStream stream { get; set; } = null;

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
