using Entidad;
using SistemaMediar.Control;
using SistemaMediar.Dialogo;
using SistemaMediar.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMediar.Presentacion
{
    public partial class FrmCarpetas : Form
    {
        public FrmCarpetas()
        {
            InitializeComponent();
        }
        private void FrmCarpetas_Load(object sender, EventArgs e)
        {
            ListaCarpetas();
        }
        private void btnnuevocarpeta_Click(object sender, EventArgs e)
        {
            DlgCarpeta dlg = new DlgCarpeta();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ListaCarpetas();
            }
        }

        private void ListaCarpetas()
        {
            FlowLayout.Controls.Clear();
            ClsCarpeta car = new ClsCarpeta();
            car.IdEmpresa = 4;
            DataTable data = car.Lista(car);
            int si = FlowLayout.Width;

            List<ControlCarpeta> Lista1 = new List<ControlCarpeta>();
            
            for (int i = 0; i < data.Rows.Count; i++)
            {
                ControlCarpeta objeto = new ControlCarpeta();
                objeto.IdCarpeta = int.Parse(data.Rows[i]["IdCarpeta"].ToString());
                objeto.Nombre = data.Rows[i]["NombreCarpeta"].ToString();
                objeto.IdEmpresa = int.Parse(data.Rows[i]["IdEmpresa"].ToString());
                objeto.FechaC = data.Rows[i]["Fecha"].ToString();
                objeto.Icon = Resources.carpeta1;
                Lista1.Add(objeto);
            }
            foreach (var item in Lista1)
            {
                // item.Width = 1078;
               // item.Width = si;
                FlowLayout.Controls.Add(item);

            }
        }

        private void txtfiltro__TextChanged(object sender, EventArgs e)
        {
            foreach (ControlCarpeta item in FlowLayout.Controls)
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
    }
}
