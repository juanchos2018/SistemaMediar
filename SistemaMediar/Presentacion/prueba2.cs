
using Word =Microsoft.Office.Interop.Word;
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
using System.Diagnostics;

namespace SistemaMediar.Presentacion
{
    public partial class prueba2 : Form
    {
        public prueba2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\DocxExample\prueba.docx";
            object ObjMiss = System.Reflection.Missing.Value;
            Word.Application ObjWord = new Word.Application();
            Word.Document objDoc = ObjWord.Documents.Open(fileName,ObjMiss);
            // objDoc.Activate();
            
            object nombre1 = "nombre";
            Word.Range nom = objDoc.Bookmarks.get_Item(ref nombre1).Range;
            nom.Text = "no sabes nada";
            object rango1 = nom;


            object direccion = "direccion";
            Word.Range direc = objDoc.Bookmarks.get_Item(ref direccion).Range;
            direc.Text = "Avenida ragel veola";
            object rango2 = direc;

           // objDoc.read = true;
            objDoc.Bookmarks.Add("nombre", ref rango1);
            objDoc.Bookmarks.Add("direccion", ref rango2);
            ObjWord.Visible = true;
          //  objDoc.ReadOnly = false;
            //  objDoc.Save();

            // objDoc.Permission = "121";
            //using (var proc = new Process())
            //{
            //    proc.StartInfo.UseShellExecute = true;

            //    proc.StartInfo.FileName = fileName;

            //    proc.Start();
            //}
            //   Process.Start("WINWORD.EXE", fileName);

        }
    }
}
