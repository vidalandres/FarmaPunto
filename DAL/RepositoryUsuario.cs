using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class RepositoryUsuario
    {
        public RepositoryUsuario()
        {

        }
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        private SqlCommand Comando;
        private IList<Usuario> ListaUsuarios;

        public RepositoryUsuario(SqlConnection conexion)
        {
            Conexion = conexion;
        }

        public void GuardarUsuario(Usuario usuario)
        {
            using (Comando = Conexion.CreateCommand())
            {

                Comando.CommandText = "insert into TablaUsuarios(Identificacion,Nombre,Apellidos,NombreUsuario,Contraseña,TipoDeUsuario,Salario,Celular) values (@Identificacion,@Nombre,@Apellidos,@NombreUsuario,@Contraseña,@TipoDeUsuario,@Salario,@Celular)";
                Comando.Parameters.Add("@Identificacion", SqlDbType.BigInt).Value = usuario.Identificacion;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = usuario.Nombre;
                Comando.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = usuario.Apellidos;
                Comando.Parameters.Add("@NombreUsuario", SqlDbType.VarChar).Value = usuario.NombreUsuario;
                Comando.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = usuario.Contraseña;
                Comando.Parameters.Add("@TipoDeUsuario", SqlDbType.VarChar).Value = usuario.TipoDeUsuario;
                Comando.Parameters.Add("@Salario", SqlDbType.Decimal).Value = usuario.Salario;
                Comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = usuario.Celular;
                Comando.ExecuteNonQuery();
            }
        }


        private Usuario MapeoUsuario(SqlDataReader reader)
        {
            Usuario usuario = new Usuario();
            usuario.Identificacion = (long)reader["Identificacion"];
            usuario.Nombre = (string)reader["Nombre"];
            usuario.Apellidos = (string)reader["Apellidos"];
            usuario.NombreUsuario = (string)reader["NombreUsuario"];
            usuario.Contraseña = (string)reader["Contraseña"];
            usuario.TipoDeUsuario = (string)reader["TipoDeUsuario"];
            usuario.Salario = (decimal)reader["Salario"];
            usuario.Celular = (string)reader["Celular"];
            return usuario;
        }

        public IList<Usuario> ConsultarUsuario()
        {
            ListaUsuarios = new List<Usuario>();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from TablaUsuarios";
                Reader = Comando.ExecuteReader();
                while (Reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario = MapeoUsuario(Reader);
                    ListaUsuarios.Add(usuario);
                }
                Reader.Close();
            }
            return ListaUsuarios;
        }

        public void EliminarUsuario(Usuario usuario)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "delete from TablaUsuarios where Identificacion=@Identificacion";
                Comando.Parameters.Add("@Identificacion", SqlDbType.VarChar).Value = usuario.Identificacion;
                Comando.ExecuteNonQuery();
            }
        }

        public Usuario BuscarUsuario(Usuario usuario)
        {
            ConsultarUsuario();
            foreach (Usuario item in ListaUsuarios)
            {
                if (EsEncontrado(item,usuario))
                {
                    return item;
                }
            }
            return null;
        }

        private bool EsEncontrado(Usuario item, Usuario usuario)
        {
            return item.Identificacion == usuario.Identificacion;
        }

        public string ModificarUsuario(Usuario usuario)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Update TablaUsuarios set Identificacion=@Identificacion,Nombre=@Nombre,Apellidos=@Apellidos,NombreUsuario=@NombreUsuario,Contraseña=@Contraseña,TipoDeUsuario=@TipoDeUsuario,Salario=@Salario,Celular=@Celular where Identificacion=@Identificacion";
                Comando.Parameters.Add("@Identificacion", SqlDbType.BigInt).Value = usuario.Identificacion;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = usuario.Nombre;
                Comando.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = usuario.Apellidos;
                Comando.Parameters.Add("@NombreUsuario", SqlDbType.VarChar).Value = usuario.NombreUsuario;
                Comando.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = usuario.Contraseña;
                Comando.Parameters.Add("@TipoDeUsuario", SqlDbType.VarChar).Value = usuario.TipoDeUsuario;
                Comando.Parameters.Add("@Salario", SqlDbType.Decimal).Value = usuario.Salario;
                Comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = usuario.Celular;

                int co = Comando.ExecuteNonQuery();
                if (co == 0)
                {
                    return "No se modifico ningun Usuario";
                }
                else
                {
                    return "Se modifico correctamente el Usuario " + usuario.Nombre +" "+usuario.Apellidos;
                }
            }

            
        }

        public string Iniciar(string user,string pass)
        {

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = ("selet from TablaUsuarios where NombreUsuario='"+user+"'and Contraseña='"+pass+"'");
                Reader = Comando.ExecuteReader();
            }
            return "";
        }
    }
}
