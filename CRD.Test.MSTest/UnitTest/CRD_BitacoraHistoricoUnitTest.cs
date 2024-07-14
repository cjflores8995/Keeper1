using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_BitacoraHistoricoUnitTest
    {
        CRD_BitacoraHistoricoServicio _service = new CRD_BitacoraHistoricoServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_BitacoraHistorico entry = new CRD_BitacoraHistorico();

            entry.ID = 1;
            entry.Bienes_Recibidos = "Bienes Ejemplo";
            entry.Ciudad = "Ciudad Ejemplo";
            entry.Origen_Documento = "Documento Ejemplo";
            entry.Empresa = "Empresa Ejemplo";
            entry.Estado = "Estado Ejemplo";
            entry.Factura = "Factura Ejemplo";
            entry.Fecha_Emision = "2024-06-25";
            entry.Fecha_Recepcion_CRD = "2024-06-26";
            entry.Iva = "19%";
            entry.Largo_F = "100cm";
            entry.Largo_O = "90cm";
            entry.Responsable = "Responsable Ejemplo";
            entry.Motivo_Rechazo = "Ninguno";
            entry.Nom_Proveedor = "Proveedor Ejemplo";
            entry.Numero_Orden = "123456";
            entry.Observaciones = "Observaciones Ejemplo";
            entry.Operador = "Operador Ejemplo";
            entry.Valija_Origen = "Valija Ejemplo";
            entry.Partner = "Partner Ejemplo";
            entry.ProveedorTipo_Proveedor = "Tipo Proveedor Ejemplo";
            entry.Referencia = "Referencia Ejemplo";
            entry.valija_Remitente = "Remitente Ejemplo";
            entry.Valija_Obs = "Observaciones Valija Ejemplo";
            entry.Ruc = "RUC Ejemplo";
            entry.Sistema_Origen = "Sistema Ejemplo";
            entry.Status_Documentos = "Status Ejemplo";
            entry.Valor = "1000.00";
            entry.Usuario_edita = "Usuario Ejemplo";
            entry.Fecha_edita = "2024-06-25";
            entry.Indices_editados = "Indices Ejemplo";
            entry.TipodeDocumento = "Tipo Documento Ejemplo";
            entry.Caja_Paquete = "Caja Ejemplo";
            entry.Cod_Empresa = "Empresa Ejemplo";
            entry.Tipo_Orden = "Tipo Orden Ejemplo";
            entry.Cod_Pago = "Pago Ejemplo";
            entry.Version_Registro = "1.0";
            entry.Adicional_2 = "Adicional 2 Ejemplo";
            entry.Adicional_3 = "Adicional 3 Ejemplo";

            _service.Add(entry);
        }

        [TestMethod]
        public void ModityTest()
        {
            var entry = _service.GetById(1);

            entry.Motivo_Rechazo = "Nombre modificado";

            _service.Modify(entry);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var getAll = _service.GetAll();

            foreach(var item in getAll)
                Console.WriteLine($"{item.Bienes_Recibidos}, {item.Ciudad}, {item.Origen_Documento}");
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var item = _service.GetById(1);
            Console.WriteLine($"{item.Bienes_Recibidos}, {item.Ciudad}, {item.Origen_Documento}");
        }

        [TestMethod]
        public void PruebaBusquedaFactura()
        {
            var Base_BitacoraHistorico = _service.buscarPorFactura("001001000000001");

            foreach (var bitacorahistorico in Base_BitacoraHistorico)
            {
                Console.WriteLine(
                bitacorahistorico.ID + "-" +
                bitacorahistorico.Bienes_Recibidos + "-" +
                bitacorahistorico.Ciudad + "-" +
                bitacorahistorico.Origen_Documento + "-" +
                bitacorahistorico.Empresa + "-" +
                bitacorahistorico.Estado + "-" +
                bitacorahistorico.Factura + "-" +
                bitacorahistorico.Fecha_Emision + "-" +
                bitacorahistorico.Fecha_Recepcion_CRD + "-" +
                bitacorahistorico.Iva + "-" +
                bitacorahistorico.Largo_F + "-" +
                bitacorahistorico.Largo_O + "-" +
                bitacorahistorico.Responsable + "-" +
                bitacorahistorico.Motivo_Rechazo + "-" +
                bitacorahistorico.Nom_Proveedor + "-" +
                bitacorahistorico.Numero_Orden + "-" +
                bitacorahistorico.Observaciones + "-" +
                bitacorahistorico.Operador + "-" +
                bitacorahistorico.Valija_Origen + "-" +
                bitacorahistorico.Partner + "-" +
                bitacorahistorico.ProveedorTipo_Proveedor + "-" +
                bitacorahistorico.Referencia + "-" +
                bitacorahistorico.valija_Remitente + "-" +
                bitacorahistorico.Valija_Obs + "-" +
                bitacorahistorico.Ruc + "-" +
                bitacorahistorico.Sistema_Origen + "-" +
                bitacorahistorico.Status_Documentos + "-" +
                bitacorahistorico.Valor + "-" +
                bitacorahistorico.Usuario_edita + "-" +
                bitacorahistorico.Fecha_edita + "-" +
                bitacorahistorico.Indices_editados + "-" +
                bitacorahistorico.TipodeDocumento + "-" +
                bitacorahistorico.Caja_Paquete + "-" +
                bitacorahistorico.Cod_Empresa + "-" +
                bitacorahistorico.Version_Registro + "-" +
                bitacorahistorico.Adicional_2 + "-" +
                bitacorahistorico.Adicional_3
                );
            }
        }

        [TestMethod]
        public void PruebaBusquedaPartner()
        {
            var Base_BitacoraHistorico = _service.buscarPorPartner("SE4407");

            foreach (var bitacorahistorico in Base_BitacoraHistorico)
            {
                Console.WriteLine(
                bitacorahistorico.ID + "-" +
                bitacorahistorico.Bienes_Recibidos + "-" +
                bitacorahistorico.Ciudad + "-" +
                bitacorahistorico.Origen_Documento + "-" +
                bitacorahistorico.Empresa + "-" +
                bitacorahistorico.Estado + "-" +
                bitacorahistorico.Factura + "-" +
                bitacorahistorico.Fecha_Emision + "-" +
                bitacorahistorico.Fecha_Recepcion_CRD + "-" +
                bitacorahistorico.Iva + "-" +
                bitacorahistorico.Largo_F + "-" +
                bitacorahistorico.Largo_O + "-" +
                bitacorahistorico.Responsable + "-" +
                bitacorahistorico.Motivo_Rechazo + "-" +
                bitacorahistorico.Nom_Proveedor + "-" +
                bitacorahistorico.Numero_Orden + "-" +
                bitacorahistorico.Observaciones + "-" +
                bitacorahistorico.Operador + "-" +
                bitacorahistorico.Valija_Origen + "-" +
                bitacorahistorico.Partner + "-" +
                bitacorahistorico.ProveedorTipo_Proveedor + "-" +
                bitacorahistorico.Referencia + "-" +
                bitacorahistorico.valija_Remitente + "-" +
                bitacorahistorico.Valija_Obs + "-" +
                bitacorahistorico.Ruc + "-" +
                bitacorahistorico.Sistema_Origen + "-" +
                bitacorahistorico.Status_Documentos + "-" +
                bitacorahistorico.Valor + "-" +
                bitacorahistorico.Usuario_edita + "-" +
                bitacorahistorico.Fecha_edita + "-" +
                bitacorahistorico.Indices_editados + "-" +
                bitacorahistorico.TipodeDocumento + "-" +
                bitacorahistorico.Caja_Paquete + "-" +
                bitacorahistorico.Cod_Empresa + "-" +
                bitacorahistorico.Version_Registro + "-" +
                bitacorahistorico.Adicional_2 + "-" +
                bitacorahistorico.Adicional_3
                );
            }
        }

        [TestMethod]
        public void PruebaBusquedaRuc()
        {
            var Base_BitacoraHistorico = _service.buscarPorRuc("1768188830001");

            foreach (var bitacorahistorico in Base_BitacoraHistorico)
            {
                Console.WriteLine(
                bitacorahistorico.ID + "-" +
                bitacorahistorico.Bienes_Recibidos + "-" +
                bitacorahistorico.Ciudad + "-" +
                bitacorahistorico.Origen_Documento + "-" +
                bitacorahistorico.Empresa + "-" +
                bitacorahistorico.Estado + "-" +
                bitacorahistorico.Factura + "-" +
                bitacorahistorico.Fecha_Emision + "-" +
                bitacorahistorico.Fecha_Recepcion_CRD + "-" +
                bitacorahistorico.Iva + "-" +
                bitacorahistorico.Largo_F + "-" +
                bitacorahistorico.Largo_O + "-" +
                bitacorahistorico.Responsable + "-" +
                bitacorahistorico.Motivo_Rechazo + "-" +
                bitacorahistorico.Nom_Proveedor + "-" +
                bitacorahistorico.Numero_Orden + "-" +
                bitacorahistorico.Observaciones + "-" +
                bitacorahistorico.Operador + "-" +
                bitacorahistorico.Valija_Origen + "-" +
                bitacorahistorico.Partner + "-" +
                bitacorahistorico.ProveedorTipo_Proveedor + "-" +
                bitacorahistorico.Referencia + "-" +
                bitacorahistorico.valija_Remitente + "-" +
                bitacorahistorico.Valija_Obs + "-" +
                bitacorahistorico.Ruc + "-" +
                bitacorahistorico.Sistema_Origen + "-" +
                bitacorahistorico.Status_Documentos + "-" +
                bitacorahistorico.Valor + "-" +
                bitacorahistorico.Usuario_edita + "-" +
                bitacorahistorico.Fecha_edita + "-" +
                bitacorahistorico.Indices_editados + "-" +
                bitacorahistorico.TipodeDocumento + "-" +
                bitacorahistorico.Caja_Paquete + "-" +
                bitacorahistorico.Cod_Empresa + "-" +
                bitacorahistorico.Version_Registro + "-" +
                bitacorahistorico.Adicional_2 + "-" +
                bitacorahistorico.Adicional_3
                );
            }
        }

        [TestMethod]
        public void PruebaBusquedaNumeroOrden()
        {
            var Base_BitacoraHistorico = _service.buscarPorNumeroOrden("OS000351970");

            foreach (var bitacorahistorico in Base_BitacoraHistorico)
            {
                Console.WriteLine(
                bitacorahistorico.ID + "-" +
                bitacorahistorico.Bienes_Recibidos + "-" +
                bitacorahistorico.Ciudad + "-" +
                bitacorahistorico.Origen_Documento + "-" +
                bitacorahistorico.Empresa + "-" +
                bitacorahistorico.Estado + "-" +
                bitacorahistorico.Factura + "-" +
                bitacorahistorico.Fecha_Emision + "-" +
                bitacorahistorico.Fecha_Recepcion_CRD + "-" +
                bitacorahistorico.Iva + "-" +
                bitacorahistorico.Largo_F + "-" +
                bitacorahistorico.Largo_O + "-" +
                bitacorahistorico.Responsable + "-" +
                bitacorahistorico.Motivo_Rechazo + "-" +
                bitacorahistorico.Nom_Proveedor + "-" +
                bitacorahistorico.Numero_Orden + "-" +
                bitacorahistorico.Observaciones + "-" +
                bitacorahistorico.Operador + "-" +
                bitacorahistorico.Valija_Origen + "-" +
                bitacorahistorico.Partner + "-" +
                bitacorahistorico.ProveedorTipo_Proveedor + "-" +
                bitacorahistorico.Referencia + "-" +
                bitacorahistorico.valija_Remitente + "-" +
                bitacorahistorico.Valija_Obs + "-" +
                bitacorahistorico.Ruc + "-" +
                bitacorahistorico.Sistema_Origen + "-" +
                bitacorahistorico.Status_Documentos + "-" +
                bitacorahistorico.Valor + "-" +
                bitacorahistorico.Usuario_edita + "-" +
                bitacorahistorico.Fecha_edita + "-" +
                bitacorahistorico.Indices_editados + "-" +
                bitacorahistorico.TipodeDocumento + "-" +
                bitacorahistorico.Caja_Paquete + "-" +
                bitacorahistorico.Cod_Empresa + "-" +
                bitacorahistorico.Version_Registro + "-" +
                bitacorahistorico.Adicional_2 + "-" +
                bitacorahistorico.Adicional_3
                );
            }
        }
    }
}
