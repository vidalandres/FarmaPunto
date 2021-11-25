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
using System.Collections;

namespace FarmaPunto
{
    public partial class UCFacturacionAdministrador : UserControl
    {
        MedicamentosService servicios = new MedicamentosService();
        FacturaService serviciosFactura = new FacturaService();
        List<MedicamentoViewModel2> Productos = new List<MedicamentoViewModel2>();

        public UCFacturacionAdministrador()
        {
            InitializeComponent();
            LbelFechaderealizacionF.Text = DateTime.Now.ToShortDateString();
            TxtCodigoFacturaFarmaceutico.Text = Convert.ToString(serviciosFactura.consultarContador());
            DtgElementosFacturaFarmaceutico.DataSource = Productos;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CodProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        //private void BtnAgregarProducto_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        int unidades = Convert.ToInt32(TxtUnidad.Text);

        //        //
        //        string nombre = TxtNombre.Text;
        //        string codigo = Txtcodigo.Text;
        //        string detalle = TxtDetalle.Text;
        //        int cantidad = Convert.ToInt32(TxtCantidad.Text);
        //        decimal precioventa = Convert.ToDecimal(TxtPrecioVenta.Text);
        //        decimal valor = Convert.ToDecimal(TxtValor.Text);
        //        string proveedor = CboxProveedores.Text;
        //        decimal impuesto = Convert.ToDecimal(TxtImpuesto.Text);
        //        decimal iva = Convert.ToDecimal(TxtIva.Text);
        //        //

        //        decimal calculo = (unidades * precioventa);
        //        Txttota.Text = Convert.ToString(calculo);
        //        decimal parcial = Convert.ToDecimal(Txttota.Text);
               
        //        string fecha = LbelFechaderealizacion.Text;
        //        string codigofactura = TxtCodigoFactura.Text;
        //        int nuevacantidad = cantidad - unidades;

        //        Factura factura = new Factura(codigofactura, codigo, nombre,unidades,iva,parcial,fecha);
        //        Medicamentos medicamento = new Medicamentos(codigo, nombre, nuevacantidad, valor, detalle, proveedor, impuesto);
        //        string res = servicios.ModificarMedicamentos(medicamento);
        //        MessageBox.Show("Stock actualizado", "Resultado de Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        string respuesta = serviciosFactura.GuardarFactura(factura);
        //        MessageBox.Show(respuesta);

        //        DtgElementosFactura.DataSource = serviciosFactura.ConsultarFacturacodigo(codigofactura);
        //        TxtTotalFactura.Text = Convert.ToString(serviciosFactura.Calcular(codigofactura).TotalCodigo);

        //    }
        //    catch (Exception E)
        //    {
        //        MessageBox.Show("Error !! " + E.ToString());
        //    }
        //}

        private void UCFacturacion_Load(object sender, EventArgs e)
        {

        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal contador = serviciosFactura.consultarContador();
            Guardar(Convert.ToInt32(contador));
            contador++;
            serviciosFactura.GuardarContador(contador);
            TxtCodigoFacturaFarmaceutico.Text = Convert.ToString(contador);
            DtgElementosFacturaFarmaceutico.DataSource = null;
            lbSubtotalFarmaceutico.Text = "$ #";
            lbTotalFarmaceutico.Text = "$ #";
        }

        private void Guardar(int Codigo)
        {
            Factura oFactura = new Factura()
            {
                CodigoFactura = Codigo.ToString(),
                Codigo = Codigo.ToString(),
                Fecha = DateTime.Now.ToString(),
                Iva = 19,
                Producto = "A-101",
                Unidades = 1,
                TotalParcial = 1000
            };
            List<DetalleFactura> oFacturados = Productos.Select(x => new DetalleFactura() 
            {
                Cantidad = Convert.ToInt32(x.Unidades),
                Fecha = DateTime.Now.ToString(),
                IdeFactura = Codigo.ToString(),
                IdeFarmaceutico = 1,
                IdeMedicamento = x.Codigo,
                IdentificacionDetalle = serviciosFactura.consultarContador().ToString(),
                NombreMedicamento = x.Descripcion,
                ValorUnitario = Convert.ToInt32(x.Subtotal)
            }).ToList();

            MessageBox.Show(serviciosFactura.GuardarFactura(oFactura, oFacturados));
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtcodigoFarmaceutico.Text))
            {
                var Medicamento = servicios.BuscarMedicamento(TxtcodigoFarmaceutico.Text);
                if (Medicamento != null)
                {
                    TbDescripcionFarmaceutico.Text = Medicamento.NombreMedicamento;
                    NbUnidadesFarmaceutico.Focus();
                }
                else
                {
                    MessageBox.Show("Sin coincidencias.");
                }
            }
        }

        private void bunifuSeparator7_Load(object sender, EventArgs e)
        {

        }

        private void TxtImpuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            //Buscar artículo
            if(e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(TxtcodigoFarmaceutico.Text))
                {
                    var Medicamento = servicios.BuscarMedicamento(TxtcodigoFarmaceutico.Text);
                    if(Medicamento != null)
                    {
                        TbDescripcionFarmaceutico.Text = Medicamento.NombreMedicamento;
                        NbUnidadesFarmaceutico.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Sin coincidencias.");
                    }
                }
            }
        }

        private void NbUnidades_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var Medicamento = servicios.BuscarMedicamento(TxtcodigoFarmaceutico.Text);
                if (Medicamento != null)
                {
                    DtgElementosFacturaFarmaceutico.DataSource = null;
                    Productos.Add(new MedicamentoViewModel2()
                    {
                        Codigo = Medicamento.CodigoMedicamento,
                        Descripcion = Medicamento.NombreMedicamento,
                        Unidades = Convert.ToDouble(NbUnidadesFarmaceutico.Value),
                        Subtotal = Convert.ToDouble(NbUnidadesFarmaceutico.Value) * Convert.ToDouble(Medicamento.ValorUnitario),
                        Impuesto = 19
                    });
                    DtgElementosFacturaFarmaceutico.DataSource = Productos;
                    TxtcodigoFarmaceutico.Text = "";
                    TbDescripcionFarmaceutico.Text = "";
                    NbUnidadesFarmaceutico.Value = 1;
                    TxtcodigoFarmaceutico.Focus();
                }
            }
        }

        private void DtgElementosFactura_DataSourceChanged(object sender, EventArgs e)
        {
            lbSubtotalFarmaceutico.Text = Productos.Sum(x => x.Subtotal).ToString();
            lbTotalFarmaceutico.Text = Productos.Sum(x => x.Total).ToString();
        }
    }
}

public class MedicamentoViewModel
{
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public double Unidades { get; set; }
    public double Subtotal { get; set; }
    public double Impuesto { get; set; }
    public double Total => Subtotal * (1 + (Impuesto / 100));
}
