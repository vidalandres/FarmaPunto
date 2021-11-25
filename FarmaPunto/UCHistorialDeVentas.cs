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

namespace FarmaPunto
{
    public partial class UCHistorialDeVentas : UserControl
    {
        FacturaService servicios = new FacturaService();
        public UCHistorialDeVentas()
        {
            InitializeComponent();
            DtgFacturas.DataSource = servicios.ConsultarFactura();
        }

        private void UCHistorialDeVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
