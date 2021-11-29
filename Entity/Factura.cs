using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public Factura()
        {

        }

        public string CodigoFactura  { get; set; }
        public string Codigo { get; set; }
        public string Fecha { get; set; }
        public string Producto { get; set; }
        public int Unidades { get; set; }
        public decimal Iva { get; set; }
        public decimal TotalParcial { get; set; }
        public decimal Total => TotalParcial * (1 + (Iva / 100));

        public Factura(string codigoFactura,string codigo, string producto, int unidades, decimal iva, decimal totalParcial,string fecha )
        {
            this.CodigoFactura = codigoFactura;
            this.Codigo = codigo;
            this.Producto = producto;
            this.Unidades = unidades;
            this.Iva = iva;
            this.TotalParcial = totalParcial;
            this.Fecha = fecha;
        }
    } 

    public class ProductoReporte
    {
        public string Producto { get; set; }
        public int Facturas { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
    }
}
