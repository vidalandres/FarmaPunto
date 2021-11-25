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
    public partial class UCDetallesDeProductos : UserControl
    {
        MedicamentosService servicios = new MedicamentosService();
        public UCDetallesDeProductos()
        {
            InitializeComponent();
        }


        private void UCDetallesDeProductos_Load(object sender, EventArgs e)
        {

        }

       

        private void Txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            Medicamentos medicamento = servicios.BuscarMedicamento(Txtcodigo.Text);
            if (medicamento != null)
            {
                try
                {
                    Txtcodigo.Text = medicamento.CodigoMedicamento;
                    TxtCantidad.Text = Convert.ToString(medicamento.Cantidad);
                    TxtDetalle.Text = medicamento.Detalle;
                    TxtImpuesto.Text = Convert.ToString(medicamento.Impuesto);
                    TxtNombre.Text = medicamento.NombreMedicamento;
                    TxtPrecioVenta.Text = Convert.ToString(medicamento.PrecioVenta);
                    TxtValor.Text = Convert.ToString(medicamento.ValorUnitario);
                    TxtPrecioVenta.Text = Convert.ToString(medicamento.PrecioVenta);
                    TxtProveedor.Text = medicamento.Proveedor;
                    TxtIva.Text = Convert.ToString(medicamento.Iva);
                }
                catch (Exception E)
                {
                    MessageBox.Show("Error !! " + E);
                }
            }
            else
            {
                MessageBox.Show("No se encontro");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DtgListadeProductos.DataSource = servicios.ConsultarMedicamentos();
        }
    }
}
