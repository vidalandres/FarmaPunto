using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Proveedor
    {
        public Proveedor()
        {

        }

        public string Nit { get; set; }
        public string DireccionProveedor { get; set; }

        public string Telefono { get; set; }

        public string NombreEmpresa { get; set; }

        public string Ciudad { get; set; }

        public string Representante { get; set; }

        public long IdentificacionRepresentante { get; set; }

        public string CelularRepresentante { get; set; }

        public Proveedor(string nit,string direccion, string telefono,string nombre,string ciudad,string representante,long identificacionRepresentante,string celularRepresentante)
        {
            this.Nit = nit;
            this.DireccionProveedor = direccion;
            this.Telefono = telefono;
            this.NombreEmpresa = nombre;
            this.Ciudad = ciudad;
            this.Representante = representante;
            this.IdentificacionRepresentante = identificacionRepresentante;
            this.CelularRepresentante = celularRepresentante;
        }
    }
    
}
