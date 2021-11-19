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
using System.Xml;
using System.Xml.Serialization;

namespace SistemaMediar.Sunat
{
    public partial class PruebaSunat : Form
    {
        public PruebaSunat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceType factura = new InvoiceType();
            factura.Cac = "";
            factura.UBLVersionID = new UBLVersionIDType();
            factura.UBLVersionID.Value = "2.1";

            factura.CustomizationID = new CustomizationIDType();
            factura.CustomizationID.Value= "2.0";

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(InvoiceType));
            var xmlesribir = new StringWriter();
            xmlSerializer.Serialize(XmlWriter.Create(xmlesribir), factura); 
            string stringXml = xmlesribir.ToString();
            System.IO.File.WriteAllText("XmlFactura",stringXml);

            MessageBox.Show("CREado we");

        }
    }
}
