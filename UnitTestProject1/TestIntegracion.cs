using BLL;
using Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaPunto.Test
{
    [TestClass]
    public class TestIntegracion
    {
        //Escenario integral de factura correcta y con reporte de venta
        [TestMethod]
        public void Facturado()
        //preparacion ejecucuion calidacion
        {
            //Preparación
            FacturaService oServicio = new FacturaService();
            Factura oFactura = new Factura()
            {
                CodigoFactura = oServicio.consultarContador().ToString(),
                Codigo = oServicio.consultarContador().ToString(),
                Fecha = DateTime.Now.ToString(),
                Iva = 19,
                Producto = "A-101",
                Unidades = 10,
                TotalParcial = 1000
            };
            List<DetalleFactura> oFacturados = new List<DetalleFactura>();
            DetalleFactura oDetalle = new DetalleFactura()
            {
                Cantidad = 1,
                Fecha = DateTime.Now.ToString(),
                IdeFactura = oServicio.consultarContador().ToString(),
                IdeFarmaceutico = 1,
                IdeMedicamento = "A-101",
                IdentificacionDetalle = "1",
                NombreMedicamento = "Algo",
                ValorUnitario = 1000
            };
            oFacturados.Add(oDetalle);
            ReporteService oReporte = new ReporteService();
            //Ejecución
            var Respuesta = oServicio.GuardarFactura(oFactura, oFacturados);
            var Facturas = oServicio.ConsultarFactura();

            var fecha = DateTime.Now.ToString().Replace('/', '_').Replace(':','_').Replace(".","");
            oReporte.CrearPDF(Environment.CurrentDirectory + $"\\TestIntegracionPDF_{fecha}.pdf", "test facturas.", Facturas);
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + $"\\TestIntegracionPDF_{fecha}.pdf");

            //Validación
            Assert.AreEqual("Se Registro La factura " + oFactura.CodigoFactura, Respuesta);
            Assert.IsTrue(File.Exists(Environment.CurrentDirectory + $"\\TestIntegracionPDF_{fecha}.pdf"));
        }
    }
}
