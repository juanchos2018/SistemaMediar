//using Calendar.NET;
using Calendar.NET;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMediar.Presentacion
{
    public partial class FrmDashoard : Form
    {
        public FrmDashoard()
        {
            InitializeComponent();
        }

        private void FrmDashoard_Load(object sender, EventArgs e)
        {
            ClsBotones.BorderPanel(panel1);
            ClsBotones.BorderPanel(panel5);
            ClsBotones.BorderPanel(panel4);
            ClsBotones.BorderPanel(panel3);

            HoyDia();
            ListarEventos();

            TotalClientes();
            TotalCasos();

            calendar1.CalendarDate = new DateTime(2021, 5, 2, 0, 0, 0);
            calendar1.CalendarView = CalendarViews.Month;
            calendar1.AllowEditingEvents = true;


        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            FrmPrincipal f = FrmPrincipal.GetInstancia();
            f.Abrir(new FrmTodosDocumentos());
        }

        private void rjButton2_MouseHover(object sender, EventArgs e)
        {
            rjButton2.ForeColor = Color.White;
        }

        private void rjButton2_MouseLeave(object sender, EventArgs e)
        {
            rjButton2.ForeColor = Color.RoyalBlue;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {         


        }
        private void TotalClientes()
        {
            ClsCliente cliente = new ClsCliente();        
            cliente.IdEmpresa = 4;
            DataTable data = cliente.TotalCliente(cliente);
            DataRow row = data.Rows[0];
            string cantidad = row["cantidad"].ToString();
            lbltotalclientes.Text = cantidad;
        }

        private void TotalCasos()
        {
            ClsCasos caso = new ClsCasos();
            caso.IdEmpresa = 4;
            DataTable data = caso.TotalCasos(caso);
            DataRow row = data.Rows[0];
            string cantidad = row["cantidad"].ToString();
            lbltotalcasos.Text = cantidad;
        }


        private void HoyDia()
        {

            //ClsApuntes apun = new ClsApuntes();
            //string nombredia = DateTime.Now.ToString("dddd", new CultureInfo("es-ES"));
            //apun.IdEmpresa = 4;
            //apun.FechaRegistro = DateTime.Now;
            //dgvenventos.DataSource = apun.Lista(apun);
            //dgvenventos.Columns["Dia"].HeaderText = nombredia;
            //dgvenventos.Columns["Hora"].Width = 100;
              
            //dgvenventos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvenventos.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10.75F, FontStyle.Bold);
            //dgvenventos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");

        }
        private void ListarEventos()
        {
            ClsApuntes apuntes = new ClsApuntes();
            apuntes.IdEmpresa = 4;
            DataTable data = apuntes.Lista1(apuntes);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var ce = new CustomEvent();
                ce.EventText = data.Rows[i]["Titulo"].ToString();
                ce.Date = DateTime.Parse(data.Rows[i]["FechaRegistro"].ToString());
                ce.RecurringFrequency = RecurringFrequencies.Yearly;
                if (data.Rows[i]["Tipo"].ToString().Equals("Audiencia"))
                {
                    ce.EventColor = ColorTranslator.FromHtml("#2E8B57");
                }
                else if (data.Rows[i]["Tipo"].ToString().Equals("Reunion"))
                {
                    ce.EventColor = ColorTranslator.FromHtml("#0522C8");
                }
                else
                {
                    ce.EventColor = ColorTranslator.FromHtml("#080809");
                }
                calendar1.AddEvent(ce);
            }

        }
        private void SelectedCalendar()
        {
            //int year = e.Start.Year;
            //int mount = e.Start.Month;
            //int day = e.Start.Day;
            //// Start = 12/05/2021 : End = 12/05/2021
            //DateTime dateValue = new DateTime(year, mount, day);
            ////  txt2.Text =dateValue.ToString("dddd", new CultureInfo("es-ES"));
            //string nombredia = dateValue.ToString("dddd", new CultureInfo("es-ES"));
            //// dgvenventos.Columns[1].HeaderText = nombredia;


            //ClsApuntes apun = new ClsApuntes();
            //apun.IdEmpresa = 4;
            //apun.FechaRegistro = dateValue;
            //dgvenventos.DataSource = apun.Lista(apun);
            //dgvenventos.Columns["Dia"].HeaderText = nombredia;
            //dgvenventos.Columns["Hora"].Width = 100;

            //dgvenventos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvenventos.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10.75F, FontStyle.Bold);
            //dgvenventos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");

        }
        private void dgvenventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calendar1_Load(object sender, EventArgs e)
        {

        }

        private void calendar1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
