using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace FarmaPunto
{
    public partial class UCHistorialDeVentas : UserControl
    {
        FacturaService servicios = new FacturaService();
        ReporteService repService = new ReporteService();

        public UCHistorialDeVentas()
        {
            InitializeComponent();
            DtgFacturas.DataSource = servicios.ConsultarFactura();
        }

        private void UCHistorialDeVentas_Load(object sender, EventArgs e)
        {

        }

        private void BtnFacturaAdministrador_Click(object sender, EventArgs e)
        {
            var reporte = servicios.ConsultarReporte();
            var dialog = new SaveFileDialog();
            dialog.ShowDialog();
            repService.CrearPDF(dialog.FileName, "ventas", reporte);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reporte = servicios.ConsultarFactura();
            var dialog = new SaveFileDialog();
            dialog.ShowDialog();
            repService.CrearPDF(dialog.FileName, "facturas", reporte);
        }

        private void TxtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void TxtProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            //Buscar artículo
            if (e.KeyCode == Keys.Enter)
            {
                DtgFacturas.DataSource = null;
                if (!String.IsNullOrEmpty(TxtProveedor.Text))
                {
                    var factura = servicios.BuscarFactura(TxtProveedor.Text);
                    if (factura != null)
                    {
                        DtgFacturas.DataSource = new List<Factura>() { factura };
                    }
                    else
                    {
                        MessageBox.Show("Sin coincidencias.");
                    }
                }
                else
                    DtgFacturas.DataSource = servicios.ConsultarFactura();
            }
        }
    }
}
