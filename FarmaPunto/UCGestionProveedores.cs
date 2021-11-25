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
    public partial class UCGestionProveedores : UserControl
    {
        ProveedorService servicios = new ProveedorService();
        public UCGestionProveedores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void UCGestionProveedores_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = TxtProveedor.Text;
                string codico = TxtNitProveedor.Text;
                string direccion = TxtDireccion.Text;
                string telefono = TxtTelefono.Text;
                string reperentante = TxtRepresentante.Text;
                string ciudad = CboxCiudades.Text;
                string celular = TxtCelular.Text;
                long id = Convert.ToInt64( TxtIdeRepresentante.Text);
                Proveedor proveedor = new Proveedor(codico, direccion, telefono, nombre, ciudad, reperentante, id, celular);
                string mensaje = servicios.GuardarProveedor(proveedor);
                MessageBox.Show(mensaje);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al ingresar los datos");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DtgTablaProveedores.DataSource = servicios.ConsultarProveedor();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = TxtProveedor.Text;
                string codico = TxtNitProveedor.Text;
                string direccion = TxtDireccion.Text;
                string telefono = TxtTelefono.Text;
                string reperentante = TxtRepresentante.Text;
                string ciudad = CboxCiudades.Text;
                string celular = TxtCelular.Text;
                long id = Convert.ToInt64(TxtIdeRepresentante.Text);
                Proveedor proveedor = new Proveedor(codico, direccion, telefono, nombre, ciudad, reperentante, id, celular);
                string res = servicios.ModificarProveedor(proveedor);
                MessageBox.Show(res, "Resultado de Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error xd ", "Resultado de Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor proveedor = new Proveedor();
                proveedor.Nit = TxtNitProveedor.Text;
                string mensaje = servicios.EliminarProveedor(proveedor);
                MessageBox.Show(mensaje + " " + proveedor.NombreEmpresa);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            Proveedor proveedor = servicios.BuscarProveedor(TxtNitProveedor.Text);
            if (proveedor != null)
            {
                try
                {
                    TxtCelular.Text = proveedor.CelularRepresentante;
                    TxtDireccion.Text = (proveedor.DireccionProveedor);
                    TxtIdeRepresentante.Text = Convert.ToString( proveedor.IdentificacionRepresentante);
                    TxtNitProveedor.Text = (proveedor.Nit);
                    TxtTelefono.Text = proveedor.Telefono;
                    TxtProveedor.Text = (proveedor.NombreEmpresa);
                    CboxCiudades.Text = (proveedor.Ciudad);
                    TxtRepresentante.Text = (proveedor.Representante);
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
    }
}
