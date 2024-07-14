using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_BitacoraUnitTest
    {
        CRD_BitacoraServicio _service = new CRD_BitacoraServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_Bitacora entry = new CRD_Bitacora();

            entry.CRD_TipoDocumentos.IdTipoDocumento = 2;
            entry.CRD_EstadoTipoProcesos.IdEstadoTipoProceso = 3;
            entry.CRD_Usuarios.Id = 1;
            entry.CRD_TipoDocumentoPagos.IdTipoDocumentoPago = 1;
            entry.CRD_Ordenes.ID = "1";
            entry.CRD_Proveedores.CodProveedor = "P001";
            entry.CRD_Empresas.CodigoEmpresa = "EMP001";
            entry.CRD_Paquetes.IdPaquete = 1;
            entry.NumeroDocumentoPago = "DOC456";
            entry.EstadoBienesRecibidos = true;
            entry.FechaEmisionDocumento = new DateTime(2024, 6, 25);
            entry.FechaRecepcionDocumento = new DateTime(2024, 6, 26, 14, 30, 0);
            entry.IvaDocumento = 19.5m;
            entry.IdAnalista = 6;
            entry.Observaciones = "Observaciones de ejemplo";
            entry.ValorTotal = 1500.75m;
            entry.TipoOrden = "TIPO1";

            _service.AddBitacora(entry);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var entry = _service.GetByIdBitacora(24);

            entry.CRD_Usuarios.Id = 1;

            _service.ModifyBitacora(entry);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var getAll = _service.ListarTodo();

            foreach(var item in getAll)
                Console.WriteLine($"{item.CRD_Ordenes.ID}");
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var item = _service.GetByIdBitacora(24);
            Console.WriteLine($"{item.CRD_Ordenes.ID}, {item.CRD_Proveedores.CodProveedor}");
        }

        [TestMethod]
        public void PruebaBusquedaFactura()
        {
            var Base_Bitacora = _service.buscarPorFacturaBitacora("001001000000001");

            foreach (var bitacora in Base_Bitacora)
            {
                Console.WriteLine(
                bitacora.IdBitacora
                );
            }
        }

    }
}
