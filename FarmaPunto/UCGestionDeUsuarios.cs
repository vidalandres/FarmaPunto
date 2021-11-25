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
    public partial class UCGestionDeUsuarios : UserControl
    {
        UsuarioService servicios = new UsuarioService();
        public UCGestionDeUsuarios()
        {
            InitializeComponent();
        }

        private void UCGestionDeUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void DtgListadeProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = TxtNombre.Text;
                long codico = Convert.ToInt64(TxtIdentificacion.Text);
                string apellidos = TxtApellidos.Text;
                string username = (TxtNombreDeUsuario.Text);
                string tipo = (CboxTipo.Text);
                string contraseña = TxtContraseña.Text;
                decimal salario = Convert.ToDecimal(TxtSalario.Text);
                string celular = TxtCelular.Text;

                Usuario usuario = new Usuario(codico, nombre, apellidos, username, contraseña, tipo, salario,celular);
                string mensaje = servicios.GuardarUsuario(usuario);
                MessageBox.Show(mensaje);
            }
            catch (Exception )
            {     
                MessageBox.Show("Error al ingresar los datos");
            }
        }

        private void TxtApellidos_TextChanged(object sender, EventArgs e)
        {

        }
        long codigo;
        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                 codigo = Convert.ToInt64(TxtIdentificacion.Text);
            }
            catch (Exception E)
            {

                MessageBox.Show("Error al ingresar La identificacion "+E);
            }
           
            Usuario usuario = servicios.BuscarUsuario(codigo);
            if (usuario != null)
            {
                try
                {
                    TxtIdentificacion.Text = Convert.ToString (usuario.Identificacion);
                    TxtNombre.Text = (usuario.Nombre);
                    TxtApellidos.Text = usuario.Apellidos;
                    TxtNombreDeUsuario.Text = (usuario.NombreUsuario);
                    TxtContraseña.Text = usuario.Contraseña;
                    CboxTipo.Text = Convert.ToString(usuario.TipoDeUsuario);
                    TxtSalario.Text = Convert.ToString(usuario.Salario);
                    TxtCelular.Text = usuario.Celular;
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Identificacion = Convert.ToInt64(TxtIdentificacion.Text);
                string mensaje = servicios.EliminarUsuario(usuario);
                MessageBox.Show(mensaje + " " + usuario.Nombre);
                Limpiar();
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
                long codico = Convert.ToInt64(TxtIdentificacion.Text);
                string apellidos = TxtApellidos.Text;
                string username = (TxtNombreDeUsuario.Text);
                string tipo = (CboxTipo.Text);
                string contraseña = TxtContraseña.Text;
                decimal salario = Convert.ToDecimal(TxtSalario.Text);
                string celular = TxtCelular.Text;

                Usuario usuario = new Usuario(codico, nombre, apellidos, username, contraseña, tipo, salario,celular);
                string res = servicios.ModificarUsuario(usuario);
                MessageBox.Show(res, "Resultado de Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception E)
            {
                MessageBox.Show("ERROR" + E.ToString());
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DtgListaUsuarios.DataSource = servicios.ConsultarUsuario();
        }

        private void Limpiar()
        {
            TxtIdentificacion.Text = "";
            TxtNombre.Text = "";
            TxtApellidos.Text = "";
            TxtNombreDeUsuario.Text = "";
            TxtContraseña.Text = "";
            CboxTipo.Text = "";
            TxtSalario.Text = "";
            TxtCelular.Text="";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
