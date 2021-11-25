using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entity;
using BLL;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Escenario de factura correcta
        [TestMethod]
        public void Facturado()
            //preparacion ejecucuion calidacion
        {
            //Preparación
            Factura oFactura = new Factura()
            {
                CodigoFactura = 1.ToString(),
                Codigo = 1.ToString(),
                Fecha = DateTime.Now.ToString(),
                Iva = 19,
                Producto =     "A-101",
                Unidades = 10,
                TotalParcial = 1000
            };
            List<DetalleFactura> oFacturados = new List<DetalleFactura>();
            DetalleFactura oDetalle = new DetalleFactura()
            {
                Cantidad = 1,
                Fecha = DateTime.Now.ToString(),
                IdeFactura = 1.ToString(),
                IdeFarmaceutico = 1,
                IdeMedicamento = "A-101",
                IdentificacionDetalle = "1",
                NombreMedicamento = "Algo",
                ValorUnitario = 1000
            };
            oFacturados.Add(oDetalle);
            FacturaService oServicio = new FacturaService();
            //Ejecución
            var Respuesta = oServicio.GuardarFactura(oFactura, oFacturados);

            //Validación
            Assert.AreEqual("Se Registro La factura " + oFactura.CodigoFactura, Respuesta);
        }

        //Cuando la factura no tiene productos no debe permitir facturar
        [TestMethod]
        public void SinMedicamentos()
        {
            //Preparación
            Factura oFactura = new Factura()
            {
                CodigoFactura = 1.ToString(),
                Codigo = 1.ToString(),
                Fecha = DateTime.Now.ToString(),
                Iva = 19,
                Producto = "A-104",
                Unidades = 10,
                TotalParcial = 1000
            };
            List<DetalleFactura> oFacturados = new List<DetalleFactura>();
            FacturaService oServicio = new FacturaService();
            //Ejecución
            var Respuesta = oServicio.GuardarFactura(oFactura, oFacturados);

            //Validación
            Assert.AreEqual("No hay productos para facturar", Respuesta);
        }
        //Escenario que no  se registre factura  si no existe producto
        [TestMethod]
        public void ProductoNoExiste()
        {
            //Preparación
            Factura oFactura = new Factura()
            {
                CodigoFactura = 1.ToString(),
                Codigo = 1.ToString(),
                Fecha = DateTime.Now.ToString(),
                Iva = 19,
                Producto = "A-105",
                Unidades = 10,
                TotalParcial = 1000
            };
            List<DetalleFactura> oFacturados = new List<DetalleFactura>();
            DetalleFactura oDetalle = new DetalleFactura()
            {
                Cantidad = 1,
                Fecha = DateTime.Now.ToString(),
                IdeFactura = 1.ToString(),
                IdeFarmaceutico = 1,
                IdeMedicamento = "A-105",
                IdentificacionDetalle = "1",
                NombreMedicamento = "Algo",
                ValorUnitario = 1000
            };
            oFacturados.Add(oDetalle);
            FacturaService oServicio = new FacturaService();
            //Ejecución
            var Respuesta = oServicio.GuardarFactura(oFactura, oFacturados);

            //Validación
            Assert.AreEqual("el medicamento no existe" , Respuesta);
        }

        //Escenario que se aplique el impuesto
        [TestMethod]
        public void Aplicarimpuesto()
        {
            //Preparación
            Factura oFactura = new Factura()
            {
                CodigoFactura = 1.ToString(),
                Codigo = 1.ToString(),
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
                IdeFactura = 1.ToString(),
                IdeFarmaceutico = 1,
                IdeMedicamento = "A-104",
                IdentificacionDetalle = "1",
                NombreMedicamento = "Algo",
                ValorUnitario = 1000
            };
            oFacturados.Add(oDetalle);
            FacturaService oServicio = new FacturaService();
            //Ejecución
            

            //Validación
            Assert.AreEqual(1190, oFactura.Total);
        }
    }


}
