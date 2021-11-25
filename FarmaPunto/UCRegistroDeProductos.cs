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
    public partial class UCRegistroDeProductos : UserControl,IReceptor
    {
        MedicamentosService servicios;
        
        public UCRegistroDeProductos()
        {
            InitializeComponent();
            servicios = new MedicamentosService();
            DtgListadeProductos.DataSource = servicios.ConsultarMedicamentos();
            Cargar();
        }

        private void AddProducto_Click(object sender, EventArgs e)
        {
            try
            { 
                string nombre = TxtNombre.Text;
                string codico = Txtcodigo.Text;
                string detalle = TxtDetalle.Text;
                int cantidad = Convert.ToInt32(TxtCantidad.Text);
                decimal valor = Convert.ToDecimal(TxtValor.Text);
                string proveedor = CboxProveedores.Text;
                decimal impuesto = Convert.ToDecimal(TxtImpuesto.Text);

                Medicamentos medicamento = new Medicamentos(codico, nombre, cantidad, valor, detalle,proveedor, impuesto);
                string mensaje = servicios.GuardarMedicamentos(medicamento);
                TxtPrecioVenta.Text = Convert.ToString(medicamento.PrecioVenta);
                TxtImpuesto.Text = Convert.ToString(medicamento.Impuesto);
                TxtIva.Text = Convert.ToString(medicamento.Iva);
                DtgListadeProductos.DataSource = servicios.ConsultarMedicamentos();

                MessageBox.Show(mensaje);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar los datos");
            }
        }

        private void UCRegistroDeProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DtgListadeProductos.DataSource = servicios.ConsultarMedicamentos();
            Cargar();
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Medicamentos medicamento = new Medicamentos();
                medicamento.CodigoMedicamento = Txtcodigo.Text;
                string mensaje = servicios.EliminarMedicamento(medicamento);
                MessageBox.Show(mensaje + " " + medicamento.NombreMedicamento);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = TxtNombre.Text;
                string codico = Txtcodigo.Text;
                string detalle = TxtDetalle.Text;
                int cantidad = Convert.ToInt32(TxtCantidad.Text);
                decimal valor = Convert.ToDecimal(TxtValor.Text);
                string proveedor = CboxProveedores.Text;
                decimal impuesto = Convert.ToDecimal( TxtImpuesto.Text);

                
                Medicamentos medicamento = new Medicamentos(codico, nombre, cantidad, valor, detalle, proveedor, impuesto);
                string res = servicios.ModificarMedicamentos(medicamento);
                MessageBox.Show(res, "Resultado de Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPrecioVenta.Text = Convert.ToString(medicamento.PrecioVenta);
                TxtImpuesto.Text = Convert.ToString(medicamento.Impuesto);
                TxtIva.Text = Convert.ToString(medicamento.Iva);
            }
            catch (Exception)
            {
                MessageBox.Show("Error xd ", "Resultado de Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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
                    CboxProveedores.Text = medicamento.Proveedor;
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

        public void Recibir(Medicamentos medicamento)
        { 
        
            if (medicamento != null)
            {
                Txtcodigo.Text = medicamento.CodigoMedicamento;
                TxtCantidad.Text = Convert.ToString(medicamento.Cantidad);
                TxtDetalle.Text = medicamento.Detalle;
                TxtImpuesto.Text = Convert.ToString(medicamento.Impuesto);
                TxtNombre.Text = medicamento.NombreMedicamento;
                TxtPrecioVenta.Text = Convert.ToString(medicamento.PrecioVenta);
                TxtValor.Text = Convert.ToString(medicamento.ValorUnitario);
                TxtPrecioVenta.Text = Convert.ToString(medicamento.PrecioVenta);
                CboxProveedores.Text = medicamento.Proveedor;
                TxtIva.Text = Convert.ToString(medicamento.Iva);
            }
        }

        private void Cargar()
        {
            ProveedorService serviproveedor = new ProveedorService();
            IList<Proveedor> ListaProveedores = new List<Proveedor>();
            ListaProveedores = serviproveedor.ConsultarProveedor();
            foreach (var item in ListaProveedores)
            {
                CboxProveedores.Items.Add(item.NombreEmpresa);
            }

        }

        private void bunifuSeparator4_Load(object sender, EventArgs e)
        {

        }

        private void CboxProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UCRegistroDeProductos_Load_1(object sender, EventArgs e)
        {

        }

        private void DtgListadeProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }
    }
}