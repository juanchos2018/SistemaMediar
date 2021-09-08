using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Font = Xceed.Document.NET.Font;

namespace SistemaMediar.Presentacion
{
    public partial class FrmPrueba : Form
    {
        public FrmPrueba()
        {
            InitializeComponent();
        }

        private void FrmPrueba_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\DocxExample\exempleWord.docx";           

            var doc = DocX.Create(fileName);
            string title = "SOLICITO:";
            
            Formatting titleFormat = new Formatting();          
            titleFormat.FontFamily = new Font("Arial");    
            titleFormat.Size = 10;         
            titleFormat.UnderlineColor = System.Drawing.Color.Gray;
            titleFormat.Bold = true;
         
            string title2 = " Audiencia de Conciliación";
        
            //Insert title  
            Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
            paragraphTitle.Alignment = Alignment.right;
            paragraphTitle.Append(title2).Bold().Font("Arial").FontSize(10);
            paragraphTitle.SpacingAfter(1);

            Formatting titleFormat1 = new Formatting();
            titleFormat1.FontFamily = new Font("Arial");
            titleFormat1.Size = 10;         
            titleFormat1.Bold = true;
            

            doc.InsertParagraph(Environment.NewLine, false);
            string centroconciliacion = "SEÑOR DIRECTOR DEL CENTRO DE CONCILIACION EXTRAJUDICIAL “MEDIAR-JSB” ";
            doc.InsertParagraph(centroconciliacion, false, titleFormat1).SpacingAfter(12);

            string numberone = "    I.     ";
            Paragraph number1 = doc.InsertParagraph(numberone, false, titleFormat1);
            number1.Append("DATOS GENERALES").Bold().Font("Arial").FontSize(10).UnderlineColor(System.Drawing.Color.Gray).SpacingAfter(5).SpacingBefore(5);

            string nombreape = "Juan Carlos Panty Sihuayro";
            string dni = "45713875";
            string direccion = "Asoc. Las Begonias Mz. N-3 Lote 39";
            Formatting FormatCliente = new Formatting();
            FormatCliente.FontFamily = new Font("Arial");
            FormatCliente.Size = 10;
            FormatCliente.Bold = true;


            Formatting FormatBold = new Formatting();
            FormatBold.FontFamily = new Font("Arial");
            FormatBold.Size = 10;
            FormatBold.Bold = true;


            Paragraph datoscliente = doc.InsertParagraph(nombreape.ToUpper(), false, FormatCliente);
            datoscliente.Append(", Identificado con Documento Nacional de Identidad N°" + dni + ", con domicilio en " + direccion + ", Distrito de Gregorio Albarracin, Provincia y Departamento de Tacna.")
            .Font("Arial").FontSize(10).Alignment= (Alignment)Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify;         
            datoscliente.LineSpacing =15;

            Paragraph datoscliente2 = doc.InsertParagraph(nombreape.ToUpper(), false, FormatCliente);
            datoscliente2.Append(", Identificado con Documento Nacional de Identidad N°" + dni + ", con domicilio en " + direccion + ", Distrito de Gregorio Albarracin, Provincia y Departamento de Tacna.")
            .Font("Arial").FontSize(10).Alignment = (Alignment)Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify;
            datoscliente2.LineSpacing = 15;

            doc.InsertParagraph(Environment.NewLine, false);
           
          
            string hechos = "    II.     ";
            Paragraph number2 = doc.InsertParagraph(hechos, false, titleFormat1);
            number2.Append("HECHOS DEL PETITORIO").Bold().Font("Arial").FontSize(10).UnderlineColor(System.Drawing.Color.Gray).SpacingAfter(5).SpacingBefore(5);

            string nombrehijo = "JARED VILLALOBOS HERNANDEZ, ";
            string edadhijo = "04";
            string fechaNacimiento = "08 de abril 2013";

            Formatting Formatbasic = new Formatting();
            Formatbasic.FontFamily = new Font("Arial");
            Formatbasic.Size = 10;
            var inicio = doc.InsertParagraph("El señor ", false, FormatCliente);
           
            inicio.InsertText(nombreape.ToUpper(), false, FormatCliente);
            FormatCliente.Bold = false;
            inicio.InsertText(" y la Señora ", false, FormatCliente);
            FormatCliente.Bold = true;
            inicio.InsertText(nombreape.ToUpper(), false, FormatCliente);
            FormatCliente.Bold = false;
            inicio.InsertText(", manifiestan que producto de su convivencia procrearon a su menor hijo ", false, FormatCliente);

            FormatCliente.Bold = true;
            inicio.InsertText(nombrehijo, false, FormatCliente);
            FormatCliente.Bold = false;
            inicio.InsertText("de "+edadhijo+" años de edad, nacido el "+fechaNacimiento+".", false, FormatCliente);

            inicio.LineSpacing = 15;
            inicio.Alignment = (Alignment)Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify;


            string datos = "Ambos padres de familia refieren que teniendo en cuenta el interés superior del niño y por su bienestar, de mutuo acuerdo acordamos venir a este centro de conciliación extrajudicial a fin de fijar la tenencia, pensión de alimentos y régimen de visitas a favor de nuestro menor hijo.";

            doc.InsertParagraph(datos, false, Formatbasic).LineSpacing=15;
            doc.InsertParagraph(Environment.NewLine, false);

            string pretenciones = "    III.     ";
            Paragraph prete = doc.InsertParagraph(pretenciones, false, titleFormat1);
            prete.Append("PRETENSIONES").Bold().Font("Arial").FontSize(10).UnderlineColor(System.Drawing.Color.Gray).SpacingAfter(5).SpacingBefore(5);


            string pre1 = "LA TENENCIA";
            string pre2 = "LA PENSION DE ALIMENTOS";
            string pre3 = "REGIMEN DE VISITAS";


            StringBuilder paraOne = new StringBuilder();
            paraOne.AppendLine("1.- "+ pre1).Append(" del menor "+ nombrehijo);
            paraOne.AppendLine("2.- " + pre2).Append(" del menor " + nombrehijo);
            // doc.InsertParagraph(paraOne.ToString(), false, Formatbasic);

            FormatCliente.Bold = true;
            Paragraph preten = doc.InsertParagraph("1.- "+  pre1.ToUpper(), false, FormatCliente);          
            preten.Append(", del menor ");
            preten.Append( nombrehijo )
            .Font("Arial").FontSize(10).Bold();
            preten.Append("de " + edadhijo + " años de edad, nacido el " + fechaNacimiento+".");
            preten.LineSpacing = 15;

            Paragraph preten2 = doc.InsertParagraph("2.- " + pre2.ToUpper(), false, FormatCliente);
            preten2.Append(", del menor ");
            preten2.Append(nombrehijo)
            .Font("Arial").FontSize(10).Bold();
            preten2.Append("de " + edadhijo + " años de edad, nacido el " + fechaNacimiento + ".");
            preten2.LineSpacing = 15;

            Paragraph preten3 = doc.InsertParagraph("3.- " + pre3.ToUpper(), false, FormatCliente);
            preten3.Append(", del menor ");
            preten3.Append(nombrehijo)
            .Font("Arial").FontSize(10).Bold();
            preten3.Append("de " + edadhijo + " años de edad, nacido el " + fechaNacimiento + ".");
            preten3.LineSpacing = 15;


            string anexo = "    IV.     ";
            Paragraph anex = doc.InsertParagraph(anexo, false, titleFormat1);
            anex.Append("ANEXOS").Bold().Font("Arial").FontSize(10).UnderlineColor(System.Drawing.Color.Gray).SpacingAfter(5).SpacingBefore(5);


            Paragraph docu = doc.InsertParagraph("-  Copia simple de DNI de ", false, Formatbasic);
            docu.Append(nombreape.ToUpper()).Font("Arial").FontSize(10).SpacingAfter(5);

            Paragraph docu2 = doc.InsertParagraph("-  Copia simple de DNI de ", false, Formatbasic);
            docu2.Append(nombreape.ToUpper()).Font("Arial").FontSize(10).SpacingAfter(5);

            Paragraph docu3 = doc.InsertParagraph("-  Copia simple de Partida de nacimiento del menor ", false, Formatbasic);
            docu3.Append(nombrehijo.ToUpper()).Font("Arial").FontSize(10);

            doc.InsertParagraph(Environment.NewLine, false);

            doc.InsertParagraph("POR TANTO:", false, FormatBold);
            string portanto = "Pido a usted señor del Centro de Conciliación acceder a mi solicitud y designar al conciliador a fin de que se proceda conforme a Ley de Conciliación y su reglamento";
            doc.InsertParagraph(portanto, false, Formatbasic).LineSpacing=15;



            CultureInfo ci = new CultureInfo("en-US");
            var month = DateTime.Now.ToString("MMMM", ci);




            var fecha = DateTime.Now.ToShortDateString();
            Paragraph fechadocument = doc.InsertParagraph("Tacna, "+fecha, false, Formatbasic);
            fechadocument.Alignment = Alignment.right;

            doc.InsertParagraph(Environment.NewLine, false);


            int lenghnombre = nombreape.Length+1;
            string raya = "_";
            string linealarga = "_";
            for (int i = 0; i <= lenghnombre; i++)
            {
                linealarga +="_";
            }
            int spacinglef = lenghnombre / 3;
            string spaci = " ";
            for (int i = 0; i < spacinglef; i++)
            {
                spaci += " ";
            }
            string user1 = linealarga + "\n" + nombreape.ToUpper() + "\n" + spaci + "D.N.I. N°" + dni;
            string user2 = linealarga + "\n" + nombreape.ToUpper() + "\n" + spaci + "D.N.I. N°" + dni;

            //Paragraph firma1 =
             Paragraph firma1 =  doc.InsertParagraph(user1, false, Formatbasic);

            /// firma1.Append(user2).IndentationFirstLine=20;
             //doc.para(user2, false, Formatbasic);




            //firma1.lo
            // firma1.Append(linealarga + "\n" + nombreape.ToUpper() + "\n" + spaci + "D.N.I. N°" + dni, false, Formatbasic);
            //   StringBuilder paraOneFirmas = new StringBuilder();
            //  paraOneFirmas.AppendLine(user1+"        "+user2);


            //  paraOneFirmas.AppendLine(user2);
            // doc.InsertParagraph(paraOneFirmas.ToString(), false, Formatbasic);




            string textParagraph = "" + "Dear Friends, " + Environment.NewLine + "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " + "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " + Environment.NewLine + "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " + "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " + "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";

            Formatting textParagraphFormat = new Formatting();
            //font family  
            textParagraphFormat.FontFamily = new Font("Arial");
            //font size  
            textParagraphFormat.Size = 10;
            //Spaces between characters  
          

            //Insert text  
           //doc.InsertParagraph(textParagraph, false, textParagraphFormat);
            doc.Save();
            Process.Start("WINWORD.EXE", fileName);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pictureFileName = @"..\..\rpg-game.png";
            string textFileName = @"D:\DocxExample\text.txt";
          //  string wordDocument = @"..\..\WordDocument.doc";
            string fileName = @"D:\DocxExample\exempleWord.docx";

            //  string fileName = @"C:\Users\Viktor\Desktop\DocXExample.docx";
            var doc = DocX.Load(fileName);
            string headlineText = "5 фундаментальных правил успеха разработчика ";
            StringBuilder paraOne = new StringBuilder();
            paraOne.AppendLine("1. Не изобретайте колесо");
            paraOne.AppendLine("2. Не тратьте время на код, сосредоточьтесь на скорейшем завершении проекта");
            paraOne.AppendLine("3. Обеспечьте техническую поддержку кода ");
            paraOne.AppendLine("4. Пользуйтесь правом возврата денег при отсутствии ТП");
            paraOne.AppendLine("5. Проверяйте коды и модули на наличие угроз и уязвимостей");

            var headLineFormat = new Formatting();
            headLineFormat.FontFamily = new Font("Times New Roman");
            headLineFormat.Size = 18D;
            headLineFormat.Position = 12;

            var paraFormat = new Formatting();
            paraFormat.FontFamily = new Font("Courier New");
            paraFormat.Size = 10D;

            doc.InsertParagraph("paragraph 1");
            doc.InsertParagraph(headlineText, false, headLineFormat);
            doc.InsertParagraph(paraOne.ToString(), false, paraFormat);
            doc.Save();

            // Open in Word:
            Process.Start("WINWORD.EXE", fileName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\DocxExample\exempleWord.docx";
            var footerFormat = new Formatting();
            footerFormat.FontFamily = new Font("Tahoma");
            var doc = DocX.Load(fileName);
            footerFormat.Size = 10D;
            var p = doc.InsertParagraph("The top 3 teams will receive a ", false, footerFormat);
            p.Alignment = Alignment.center;

            footerFormat.Bold = true;
            p.InsertText("SPECTACULAR ", false, footerFormat);

            p.ReplaceAtBookmark("juan carlos", "nombre", null);

           

            footerFormat.Bold = false;
            p.InsertText("prize:\n");

            footerFormat.Bold = true;
            footerFormat.UnderlineStyle = UnderlineStyle.singleLine;
            footerFormat.FontColor = System.Drawing.Color.MediumBlue;
            footerFormat.Size = 14D;
            p.InsertText("A HANDSHAKE FROM NAKOV", false, footerFormat);

            doc.Save();

            // Open in Word:
            Process.Start("WINWORD.EXE", fileName);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string fileName = @"D:\DocxExample\exempleWord.docx";
            string tester = "juan carlos panty en loco quye no sve nada de progmraccion we";
            var doc = DocX.Load(fileName);
            var textStyle = new Formatting();
            textStyle.Size = 12;
            textStyle.FontFamily = new Font("Times New Roman");

            var signatureHeader = doc.InsertParagraph(
                    Environment.NewLine +
                    "Извършил изпитването:",
                    false,
                    textStyle
                );
            signatureHeader.IndentationBefore = 2;

            var nameBox = doc.InsertParagraph(
                    "/" + tester + "/" + Environment.NewLine,
                    false,
                    textStyle
                );
            nameBox.IndentationBefore = 2;
            doc.Save();

            // Open in Word:
            Process.Start("WINWORD.EXE", fileName);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\DocxExample\prueba.docx";
            string tester = "juan carlos panty en loco quye no sve nada de progmraccion we";
            var doc = DocX.Load(fileName);
            var p = doc.InsertParagraph("T", false);
           
            //  p.InsertAtBookmark("juan caros", "nombre", null);
            //  BookmarksNavigator d = new BookmarksNavigator():
            // doc.Bookmarks.add("juan carlos", "nombre", null);
           
            

            doc.Save();
            // Open in Word:
            Process.Start("WINWORD.EXE", fileName);
            //using (var document = DocX.Create("InsertBookmarks.docx"))
            //{
            //    // Insert a bookmark in the document.
            //    document.InsertBookmark("Bookmark1");
            //    // Add a paragraph.
            //    var p = document.InsertParagraph("This document contains a bookmark named \"");
            //    p.Append(document.Bookmarks.First().Name);
            //    p.Append("\" just before this line.");
            //    // Save the document.
            //    document.Save();
            //}


        }

        public virtual void ReplaceAtBookmark(  string text,  string bookmarkName,  Formatting formatting)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreateRejectionLetter();
        }


        public void CreateRejectionLetter()
        {
            // We will need a file name for our output file (change to suit your machine):
           // string fileNameTemplate = @"D:\Users\John\Documents\Rejection-Letter-{0}-{1}.docx";
            string fileNameTemplate = @"D:\DocxExample\SOLICITUD2.docx";
            string nombrepadre1 = "JUAN CARLOS PANTY SIHUAYRO";
            string nombrepadre2 = "rosita cahuanda";
            string dni1 = "45232323";
            string dni2 = "111111111";
            string direccion1 = "casa lejos de m casa";
            string direccion2 = "avenida leguia we";
            string nombrehijo = "alexandra mengoa chalco";
            string edadhijo1 = "09";
            string fechanacimiento = "02 de marzo del 2015";


            // Let's save the file with a meaningful name, including the 
            // applicant name and the letter date:
           // string outputFileName =  string.Format(fileNameTemplate, applicantName, DateTime.Now.ToString("MM-dd-yy"));
            var doc = DocX.Load(fileNameTemplate);
            // Grab a reference to our document template:
        //    DocX letter = this.GetRejectionLetterTemplate();
            // Perform the replace:

            doc.ReplaceText("NOMBREPADRE1", nombrepadre1);
            doc.ReplaceText("NOMBREPADRE2", nombrepadre2);
            doc.ReplaceText("DNI1", dni1);
            doc.ReplaceText("DNI2", dni2);
            doc.ReplaceText("DIRECCION1", direccion1);
            doc.ReplaceText("NOMBREHIJO1", nombrehijo); 
            doc.ReplaceText("EDAD", edadhijo1);
            doc.ReplaceText("FECHANACIMIENTO", fechanacimiento);
            // Save as New filename:
            doc.SaveAs(fileNameTemplate);

            // Open in word:
            Process.Start("WINWORD.EXE", "\"" + fileNameTemplate + "\"");
        }


        private DocX GetRejectionLetterTemplate()
        {
            // Adjust the path so suit your machine:
           // string fileName = @"D:\Users\John\Documents\DocXExample.docx";
            string fileName = @"D:\DocxExample\word.docx";
            // Set up our paragraph contents:
            string headerText = "Rejection Letter";
            string letterBodyText = DateTime.Now.ToShortDateString();
            string paraTwo = ""
                + "Dear %APPLICANT%" + Environment.NewLine + Environment.NewLine
                + "I am writing to thank you for your resume. Unfortunately, your skills and "
                + "experience do not match our needs at the present time. We will keep your "
                + "resume in our circular file for future reference. Don't call us, "
                + "we'll call you. "

                + Environment.NewLine + Environment.NewLine
                + "Sincerely, "
                + Environment.NewLine + Environment.NewLine
                + "Jim Smith, Corporate Hiring Manager";

            // Title Formatting:
            var titleFormat = new Formatting();
            titleFormat.FontFamily = new Font("Arial Black");
            titleFormat.Size = 18D;
            titleFormat.Position = 12;

            // Body Formatting
            var paraFormat = new Formatting();
            paraFormat.FontFamily = new Font("Calibri");
            paraFormat.Size = 10D;
            titleFormat.Position = 12;

            // Create the document in memory:
            var doc = DocX.Create(fileName);

            // Insert each prargraph, with appropriate spacing and alignment:
            Paragraph title = doc.InsertParagraph(headerText, false, titleFormat);
            title.Alignment = Alignment.center;

            doc.InsertParagraph(Environment.NewLine);
            Paragraph letterBody = doc.InsertParagraph(letterBodyText, false, paraFormat);
            letterBody.Alignment = Alignment.both;

            doc.InsertParagraph(Environment.NewLine);
            doc.InsertParagraph(paraTwo, false, paraFormat);

            return doc;
        }

    }
}
