using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuario
    {
        public Usuario()
        {

        }
        public long Identificacion { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string NombreUsuario { get; set; }

        public string Contraseña { get; set; }

        public string TipoDeUsuario { get; set; }

        public decimal Salario { get; set; }

        public string Celular { get; set; }

        public Usuario(long identificacion, string nombre, string apellidos,string nombreUsuario ,string contraseña,string tipo,decimal salario, string celular)
        {
            this.Identificacion = identificacion;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.NombreUsuario = nombreUsuario;
            this.Contraseña = contraseña;
            this.TipoDeUsuario = tipo;
            this.Salario = salario;
            this.Celular = celular;
        }

    }
}
