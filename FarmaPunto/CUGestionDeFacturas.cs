using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace FarmaPunto
{
    public partial class CboxFlitro : UserControl
    {

        FacturaService servicios = new FacturaService();
        string desde = DateTime.Now.ToShortDateString();
        string hasta = DateTime.Now.ToShortDateString();
        public CboxFlitro()
        {
            InitializeComponent();
            dtDesde.Value = DateTime.Today;
            dtHasta.Value = DateTime.Today;

        }

        public DateTime MyProperty { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            }

        private void CUGestionDeFacturas_Load(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboxFiltro.Text.Equals("Todos"))
            {
                DtgListadeProductos.DataSource = servicios.ConsultarFactura();
            }
            else if (CboxFiltro.Text.Equals("Codigo"))
            {
                DtgListadeProductos.DataSource = servicios.ConsultarFacturacodigo(TxtCodigoFactura.Text);
                TxtTotalFactura.Text=Convert.ToString(TxtTotalFactura.Text = Convert.ToString(servicios.Calcular(TxtCodigoFactura.Text).TotalCodigo));
            }
        }

        private void dtDesde_ValueChanged(object sender, EventArgs e)
        {
            desde = dtDesde.Value.ToShortDateString(); //dateTime.ToShortDateString()
            

        }

        private void dtHasta_ValueChanged(object sender, EventArgs e)
        {
            hasta = dtHasta.Value.ToShortDateString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DtgListadeProductos.DataSource = servicios.ConsultarFacturFecha(desde, hasta);
            }
            catch (Exception E)
            {

                MessageBox.Show(E.ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void DtgListadeProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
