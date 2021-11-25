using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public long IdentificacionCliente { get; set; }

        public string NombreCliente { get; set; }

        public string ApellidosClientes { get; set; }

        public long TelefonoCliente { get; set; }

        public string DireccionCliente { get; set; }

        public DateTime FechaDeRegistro { get; }

        public Cliente(long identificacionCliente, string nombreCliente, string apellidosClientes, long telefonoCliente, string direccionCliente)
        {
            this.IdentificacionCliente = identificacionCliente;
            this.NombreCliente = nombreCliente;
            this.ApellidosClientes = apellidosClientes;
            this.TelefonoCliente = telefonoCliente;
            this.DireccionCliente = direccionCliente;
        }

    }
}

