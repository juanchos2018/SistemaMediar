using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMediar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Color _NormalBorderColor = Color.Gray;
        private Color _FocusBorderColor = Color.Blue;
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.RoyalBlue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClsBotones.BorderPanel(panel1);
            ClsBotones.BorderButton(button1);


            //DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            //RJButton btn = new RJButton();
            //button.Name = "Ver";
            //button.HeaderText = "Ver";
            //button.Text = "Detalle";
          
            //button.FlatStyle = FlatStyle.Flat;
            //button.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#007bff");
            //button.DefaultCellStyle.ForeColor = Color.White;
            //button.UseColumnTextForButtonValue = true;

            //dataGridView1.Columns.Add(button);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
          
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_MouseLeave(object sender, EventArgs e)
        {
            rjButton2.ForeColor = Color.RoyalBlue;

        }

        private void rjButton2_MouseHover(object sender, EventArgs e)
        {
            rjButton2.ForeColor = Color.White;
        }
    }
}
