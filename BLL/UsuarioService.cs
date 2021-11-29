using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class UsuarioService
    {
        SqlConnection Conexion;
        IList<Usuario> ListaUsuarios;
        RepositoryUsuario repositoryUsuario;
        public UsuarioService()
        {

            Conexion = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bdmtnz\Documents\Desktop\FarmaPunto\DAL\DatosProyecto.mdf;Integrated Security=True");
            repositoryUsuario = new RepositoryUsuario(Conexion);
        }

        public IList<Usuario> ConsultarUsuario()
        {
            Conexion.Open();
            ListaUsuarios = new List<Usuario>();
            ListaUsuarios = repositoryUsuario.ConsultarUsuario();
            Conexion.Close();
            return (ListaUsuarios);
        }

        public Usuario BuscarUsuario(long codigo)
        {
            Conexion.Open();
            Usuario usuario = new Usuario();
            usuario.Identificacion = codigo;
            usuario = repositoryUsuario.BuscarUsuario(usuario);
            Conexion.Close();
            return usuario;
        }

        public string GuardarUsuario(Usuario usuario)
        {
            //probar
            //{
            Conexion.Open();
            repositoryUsuario.GuardarUsuario(usuario);
            Conexion.Close();
            return "se registro el Usuario " + usuario.Nombre + " " + usuario.Apellidos;
            //}
            //captura (Excepción e)
            //{
            //    Conexion.Close();
            //    return "Error de base de datos: " + e.Message.ToString();
            //}
        }


    

        public string EliminarUsuario(Usuario usuario)
        {
            Conexion.Open();
            if (repositoryUsuario.BuscarUsuario(usuario) != null)
            {
                usuario = (repositoryUsuario.BuscarUsuario(usuario));
                repositoryUsuario.EliminarUsuario(usuario);
                Conexion.Close();
                return "Se eliminó al Usuario " + usuario.Nombre +" "+usuario.Apellidos+ " correctamente";
            }
            else
            {
                Conexion.Close();
                return "El Usuario con esa Identificacion no existe";
            }
        }

        public string ModificarUsuario(Usuario usuario)
        {
            Conexion.Open();
            string respuesta;
            respuesta = repositoryUsuario.ModificarUsuario(usuario);
            Conexion.Close();
            return respuesta; 
        }

        public void CArajo() { }

        public string x()
        {
            try
            {
                Conexion.Open();
                Usuario usuario = new Usuario();
                string respuesta;
                respuesta = repositoryUsuario.Iniciar(usuario.NombreUsuario, usuario.Contraseña);
                Conexion.Close();
                return respuesta;
            }
            catch (Exception E)
            {

                return ("No se pudo" + E.ToString());
            }
        }

    }
}