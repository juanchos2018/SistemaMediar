using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMediar.Dialogo
{
    public partial class DlgCasos : Form
    {

        public int idcaso { get; set; }
        public string materia { get; set; }
        public string conciliacion { get; set; }
        public string DocumentoPlantilla { get; set; }
        public string TipoDocumento { get; set; }

        DataView dataFilter;


        public DlgCasos()
        {
            InitializeComponent();
        }

        private void DlgCasos_Load(object sender, EventArgs e)
        {
           // cargarCombo();

            cargarComboMaterias();
        }

        private void cargarCombo()
        {
            ClsMateria materia = new ClsMateria();
            materia.IdEmpresa = 4;
            cbomaterias.DataSource = materia.Lista(materia);
            if (materia.Lista(materia).Rows.Count>0)
            {
                cbomaterias.DisplayMember = "NombreMateria";
                cbomaterias.ValueMember = "IdMateria";
                CargarDgv((int)cbomaterias.SelectedValue);
            }
           
        }


        private void cargarComboMaterias()
        {
            ClsCarpeta car = new ClsCarpeta();
            car.IdEmpresa = 4;
         //   DataTable data = car.Lista(car);                   
            cbomaterias.DataSource = car.Lista(car);
            if (car.Lista(car).Rows.Count > 0)
            {
                cbomaterias.DisplayMember = "NombreCarpeta";
                cbomaterias.ValueMember = "IdCarpeta";
                CargarDgvFiles(Convert.ToInt32(cbomaterias.SelectedValue));
            }

        }

        private void CargarDgvFiles(int id)
        {
            ClsArchivo car = new ClsArchivo();
            car.IdEmpresa = 4;
            car.IdCarpeta = id;
           // DataTable data = car.Lista(car);
            dataFilter = car.Lista(car).DefaultView;
            dgvcasos.DataSource = dataFilter;
            dgvcasos.Columns["IdArchivo"].Width = 40;
            dgvcasos.Columns["NombreArchivo"].Width = 150;
            dgvcasos.Columns["IdEmpresa"].Visible = false;
            dgvcasos.Columns["IdCarpeta"].Visible = false;
            dgvcasos.Columns["Size"].Visible = false;
            dgvcasos.Columns["Estado"].Visible = false;
            dgvcasos.Columns["FechaRegistro"].Visible = false;
            dgvcasos.Columns["RutaServidor"].Visible = false;

            dgvcasos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");

        }
        private void CargarDgv(int id)
        {
            ClsCasos ca = new ClsCasos();
            ca.IdEmpresa = 4;
            ca.IdMateria = id;
            dataFilter = ca.Lista(ca).DefaultView;
            dgvcasos.DataSource = dataFilter;
            dgvcasos.Columns["IdCaso"].Width = 50;
            dgvcasos.Columns["IdCaso"].HeaderText = "Codigo";
            dgvcasos.Columns["IdEmpresa"].Visible = false; 
            dgvcasos.Columns["IdMateria"].Visible = false;
            dgvcasos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");


        }
        private void item()
        {
            if (dgvcasos.RowCount > 0)
            {
               // idcaso = int.Parse(dgvcasos["IdCaso", dgvcasos.CurrentCell.RowIndex].Value.ToString()); //de la tabla  TipoMovimientoFF
                materia = cbomaterias.Text;
                conciliacion = dgvcasos["NombreArchivo", dgvcasos.CurrentCell.RowIndex].Value.ToString();
                DocumentoPlantilla = dgvcasos["RutaServidor", dgvcasos.CurrentCell.RowIndex].Value.ToString();
                TipoDocumento= dgvcasos["Tipo", dgvcasos.CurrentCell.RowIndex].Value.ToString();
                DialogResult = DialogResult.OK;
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            item();
        }

        private void dgvcasos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                item();
            }
        }

        private void txtfiltro__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtfiltro.Texts.Length > 0)
                {
                    dataFilter.RowFilter = "NombreArchivo like '%" + txtfiltro.Texts + "%' ";
                }
                else
                {
                    dataFilter.RowFilter = "";
                }

            }
            catch (Exception)
            {               
            }
        }

        private void cbomaterias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //  CargarDgv((int)cbomaterias.SelectedValue);
            CargarDgvFiles(Convert.ToInt32(cbomaterias.SelectedValue));

        }
    }
}
