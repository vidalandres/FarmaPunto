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
    public partial class UCFacturacion : UserControl
    {
        MedicamentosService servicios = new MedicamentosService();
        FacturaService serviciosFactura = new FacturaService();
        List<MedicamentoViewModel2> Productos = new List<MedicamentoViewModel2>();

        public UCFacturacion()
        {
            InitializeComponent();
            LbelFechaderealizacionA.Text = DateTime.Now.ToShortDateString();
            TxtCodigoFacturaAdministrador.Text = Convert.ToString(serviciosFactura.consultarContador());
            DtgElementosFacturaAdministrador.DataSource = Productos;
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
            TxtCodigoFacturaAdministrador.Text = Convert.ToString(contador);
            DtgElementosFacturaAdministrador.DataSource = null;
            Productos.Clear();
            lbSubtotalAdministrador.Text = "$ #";
            lbTotalAdministrador.Text = "$ #";
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
            if (!String.IsNullOrEmpty(TxtcodigoAdministrador.Text))
            {
                var Medicamento = servicios.BuscarMedicamento(TxtcodigoAdministrador.Text);
                if (Medicamento != null)
                {
                    TbDescripcionAdministrador.Text = Medicamento.NombreMedicamento;
                    NbUnidadesAdministrador.Focus();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            //Buscar artículo
            if(e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(TxtcodigoAdministrador.Text))
                {
                    var Medicamento = servicios.BuscarMedicamento(TxtcodigoAdministrador.Text);
                    if(Medicamento != null)
                    {
                        TbDescripcionAdministrador.Text = Medicamento.NombreMedicamento;
                        NbUnidadesAdministrador.Focus();
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
                var Medicamento = servicios.BuscarMedicamento(TxtcodigoAdministrador.Text);
                if (Medicamento != null)
                {
                    DtgElementosFacturaAdministrador.DataSource = null;
                    Productos.Add(new MedicamentoViewModel2()
                    {
                        Codigo = Medicamento.CodigoMedicamento,
                        Descripcion = Medicamento.NombreMedicamento,
                        Unidades = Convert.ToDouble(NbUnidadesAdministrador.Value),
                        Subtotal = Convert.ToDouble(NbUnidadesAdministrador.Value) * Convert.ToDouble(Medicamento.ValorUnitario),
                        Impuesto = 19
                    });
                    DtgElementosFacturaAdministrador.DataSource = Productos;
                    TxtcodigoAdministrador.Text = "";
                    TbDescripcionAdministrador.Text = "";
                    NbUnidadesAdministrador.Value = 1;
                    TxtcodigoAdministrador.Focus();
                }
            }
        }

        private void DtgElementosFactura_DataSourceChanged(object sender, EventArgs e)
        {
            if(Productos != null)
            {
                lbSubtotalAdministrador.Text = Productos.Sum(x => x.Subtotal).ToString();
                lbTotalAdministrador.Text = Productos.Sum(x => x.Total).ToString();
            }
        }

        private void Txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbelFechaderealizacion_Click(object sender, EventArgs e)
        {

        }
    }
}

public class MedicamentoViewModel2
{
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public double Unidades { get; set; }
    public double Subtotal { get; set; }
    public double Impuesto { get; set; }
    public double Total => Subtotal * (1 + (Impuesto / 100));
}
