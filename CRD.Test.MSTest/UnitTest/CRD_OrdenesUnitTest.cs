using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_OrdenesUnitTest
    {
        CRD_OrdenesServicio _service = new CRD_OrdenesServicio();

        [TestMethod]
        public void AddTest()
        {
            var entry = new CRD_Ordenes
            {
                ID = "4",
                Tipo_Orden = "Tipo1",
                CodigoCompania = "Compania1",
                CodigoSistema = "Sistema1",
                CodigoServicio = "Servicio1",
                Proceso = "Proceso1",
                Resultado = "Exito",
                Estado = "Completado",
                Error = "Ninguno",
                FechaProceso = "2024-06-26",
                Id1 = "ID1",
                NumeroOrden = "123456",
                CodTipoOrden = "T01",
                Referencia = "Ref1",
                Facturado = "No",
                Liberado = "Si",
                Divisa = "USD",
                TipoCambio = "1.00",
                Proveedor = "Proveedor1",
                DescProveedor = "Proveedor de Ejemplo",
                CodOrganizacion = "Org1",
                DesOrganizacion = "Organización 1",
                Compania = "Compañía 1",
                DesCompania = "Descripción Compañía",
                CodOrganizacionComp = "OrgComp1",
                DesOrganizacionComp = "Organización Compañía 1",
                ImporteBruto = "1000.00",
                Subtotal = "800.00",
                Iva = "200.00",
                ImporteNetoFacturado = "1000.00",
                NetoEntregado = "950.00",
                IdentPropietario = "Prop1",
                CodPropietario = "CP1",
                NombrePropietario = "Propietario 1",
                IdentComprador = "Comp1",
                CodComprador = "CC1",
                NombreComprador = "Comprador 1",
                FechaOrden = "2024-06-25",
                FechaPlanificadaRecepcion = "2024-06-30",
                FechaRealRecepcion = "2024-06-29",
                EstadoRecupDatos = "Recuperado",
                Texto1 = "Texto 1",
                Texto2 = "Texto 2",
                Texto3 = "Texto 3",
                Texto4 = "Texto 4",
                Texto5 = "Texto 5",
                Texto6 = "Texto 6",
                Texto7 = "Texto 7",
                Texto8 = "Texto 8",
                Texto9 = "Texto 9",
                Texto10 = "Texto 10",
                Numerico1 = "1.0",
                Numerico2 = "2.0",
                Numerico3 = "3.0",
                Numerico4 = "4.0",
                Numerico5 = "5.0",
                Fecha1 = "2024-06-26",
                Fecha2 = "2024-06-27",
                Fecha3 = "2024-06-28",
                Fecha4 = "2024-06-29",
                Fecha5 = "2024-06-30",
                PersonaReferencia = "Referencia 1",
                CodProveedorPrincipal = "ProveedorP1",
                NombreProveedorPrincipal = "Proveedor Principal 1",
                BienesFacturadosRecib = "Si",
                Id2 = "ID2",
                IdOrden = "Orden1",
                NumeroOrden3 = "123457",
                Posicion = "1",
                Facturado4 = "No",
                Liberado5 = "Si",
                CantidadPedida = "10",
                UnidadCompra = "Unidad",
                Precio = "100.00",
                Importe = "1000.00",
                UnidadPrecio = "Unidad",
                ImporteBruto6 = "1000.00",
                Iva7 = "200.00",
                CodFiscal = "F1",
                PorcentajeIva = "20.00",
                ImporteNetoFacturado8 = "1000.00",
                CantidadFacturada = "10",
                CantidadNetaEntregada = "9",
                CantidadEntregada = "9",
                EntregaMercaderiaReq = "Si",
                CodProducto = "P1",
                NombreProducto = "Producto 1",
                Unspsc = "12345678",
                FechaPlanificadaRecepcion9 = "2024-06-30",
                FechaRealRecepcion10 = "2024-06-29",
                Comentario = "Comentario 1",
                Texto111 = "Texto 11",
                Texto212 = "Texto 12",
                Texto313 = "Texto 13",
                Texto414 = "Texto 14",
                Texto515 = "Texto 15",
                Texto616 = "Texto 16",
                Texto717 = "Texto 17",
                Texto818 = "Texto 18",
                Texto919 = "Texto 19",
                Texto1020 = "Texto 20",
                Numerico121 = "1.1",
                Numerico222 = "2.2",
                Numerico323 = "3.3",
                Numerico424 = "4.4",
                Numerico525 = "5.5",
                Fecha126 = "2024-06-26",
                Fecha227 = "2024-06-27",
                Fecha328 = "2024-06-28",
                Fecha429 = "2024-06-29",
                Fecha530 = "2024-06-30",
                Descripcion = "Descripción del objeto",
                CodFactorIng = "Factor1",
                CodEstrategiaIng = "Estrategia1",
                BienesFacturadosRecib31 = "Si",
                MetodoRecepcion = "Recepción 1",
                Id32 = "ID32",
                IdPosicion = "Posicion32",
                NumeroOrden33 = "123458",
                Posicion34 = "2",
                IndicePedidos = "Indice1",
                CodCuenta = "Cuenta1",
                NombreCuenta = "Cuenta 1",
                CodCentroCosto = "Centro1",
                NombreCentroCosto = "Centro de Costo 1",
                CodProyecto = "Proyecto1",
                NombreProyecto = "Proyecto 1",
                ImporteBruto35 = "1000.00",
                Neto = "950.00",
                Iva36 = "200.00",
                CodFiscal37 = "Fiscal1",
                PorcentajeIva38 = "20.00",
                Cantidad = "10",
                Texto139 = "Texto 39",
                Texto240 = "Texto 40",
                Texto341 = "Texto 41",
                Texto442 = "Texto 42",
                Texto543 = "Texto 43",
                Texto644 = "Texto 44",
                Texto745 = "Texto 45",
                Texto846 = "Texto 46",
                Texto947 = "Texto 47",
                Texto1048 = "Texto 48",
                Texto11 = "Texto 11",
                Texto12 = "Texto 12",
                Texto13 = "Texto 13",
                Texto14 = "Texto 14",
                Texto15 = "Texto 15",
                Texto16 = "Texto 16",
                Texto17 = "Texto 17",
                Texto18 = "Texto 18",
                Texto19 = "Texto 19",
                Texto20 = "Texto 20",
                Numerico149 = "1.49",
                Numerico250 = "2.50",
                Numerico351 = "3.51",
                Numerico452 = "4.52",
                Numerico553 = "5.53",
                Fecha154 = "2024-06-26",
                Fecha255 = "2024-06-27",
                Fecha356 = "2024-06-28",
                Fecha457 = "2024-06-29",
                Fecha558 = "2024-06-30",
                Id59 = "ID59",
                NumeroRecepcion = "Recepcion1",
                LineaRecepcion = "Linea1",
                NumeroOrden60 = "123459",
                Posicion61 = "3",
                CantidadRecibida = "10",
                Neto62 = "950.00",
                PrecioNeto = "100.00",
                FechaEntrega = "2024-06-30",
                IdUsuario = "Usuario1",
                CodUsuario = "U1",
                NombreUsuario = "Usuario 1",
                Texto163 = "Texto 63",
                Texto264 = "Texto 64",
                Texto365 = "Texto 65",
                Texto466 = "Texto 66",
                Texto567 = "Texto 67",
                Numerico168 = "1.68",
                Numerico269 = "2.69",
                Numerico370 = "3.70",
                Numerico471 = "4.71",
                Numerico572 = "5.72",
                Fecha173 = "2024-06-26",
                Fecha274 = "2024-06-27",
                Fecha375 = "2024-06-28",
                Fecha476 = "2024-06-29",
                Fecha577 = "2024-06-30",
                MetodoRecepcion78 = "Recepción 2",
                HistoriaPedidos = "Historia 1",
                nombrearchivo = "archivo.txt"
            };

            _service.Add(entry);
        }


        [TestMethod]
        public void GetAllTest()
        {
            var getAll = _service.GetAll();

            foreach(var item in getAll)
                Console.WriteLine($"{item.ID}, {item.Tipo_Orden}");
        }

        [TestMethod]
        public void TestMethod1()
        {
            var datosBase = _service.ObtenerOrdenesPorNumeroOrden("ORD001");

            foreach (var datos in datosBase)
            {
                Console.WriteLine(
                datos.ID + "-" +
                datos.Tipo_Orden + "-" +
                datos.CodigoCompania + "-" +
                datos.CodigoSistema + "-" +
                datos.Proceso + "-" +
                datos.Resultado + "-" +
                datos.Estado + "-" +
                datos.Error + "-" +
                datos.FechaProceso + "-" +
                datos.Id1 + "-" +
                datos.NumeroOrden + "-" +
                datos.CodTipoOrden + "-" +
                datos.Referencia + "-" +
                datos.Facturado + "-" +
                datos.Liberado + "-" +
                datos.Divisa + "-" +
                datos.TipoCambio + "-" +
                datos.Proveedor + "-" +
                datos.DescProveedor + "-" +
                datos.CodOrganizacion + "-" +
                datos.DesCompania + "-" +
                datos.CodOrganizacionComp + "-" +
                datos.DesOrganizacionComp + "-" +
                datos.ImporteBruto + "-" +
                datos.Subtotal + "-" +
                datos.Iva + "-" +
                datos.ImporteNetoFacturado + "-" +
                datos.NetoEntregado + "-" +
                datos.IdentPropietario + "-" +
                datos.CodPropietario + "-" +
                datos.NombrePropietario + "-" +
                datos.IdentComprador + "-" +
                datos.CodComprador + "-" +
                datos.NombreComprador + "-" +
                datos.FechaOrden + "-" +
                datos.FechaPlanificadaRecepcion + "-" +
                datos.FechaRealRecepcion + "-" +
                datos.EstadoRecupDatos + "-" +
                datos.Texto1 + "-" +
                datos.Texto2 + "-" +
                datos.Texto3 + "-" +
                datos.Texto4 + "-" +
                datos.Texto5 + "-" +
                datos.Texto6 + "-" +
                datos.Texto7 + "-" +
                datos.Texto8 + "-" +
                datos.Texto9 + "-" +
                datos.Texto10 + "-" +
                datos.Numerico1 + "-" +
                datos.Numerico2 + "-" +
                datos.Numerico3 + "-" +
                datos.Numerico4 + "-" +
                datos.Numerico5 + "-" +
                datos.Fecha1 + "-" +
                datos.Fecha2 + "-" +
                datos.Fecha3 + "-" +
                datos.Fecha4 + "-" +
                datos.Fecha5 + "-" +
                datos.PersonaReferencia + "-" +
                datos.CodProveedorPrincipal + "-" +
                datos.NombreProveedorPrincipal + "-" +
                datos.BienesFacturadosRecib + "-" +
                datos.Id2 + "-" +
                datos.IdOrden + "-" +
                datos.NumeroOrden3 + "-" +
                datos.Posicion + "-" +
                datos.Facturado4 + "-" +
                datos.Liberado5 + "-" +
                datos.CantidadPedida + "-" +
                datos.UnidadCompra + "-" +
                datos.Precio + "-" +
                datos.Importe + "-" +
                datos.UnidadPrecio + "-" +
                datos.ImporteBruto6 + "-" +
                datos.Iva7 + "-" +
                datos.CodFiscal + "-" +
                datos.PorcentajeIva + "-" +
                datos.ImporteNetoFacturado8 + "-" +
                datos.CantidadFacturada + "-" +
                datos.CantidadNetaEntregada + "-" +
                datos.EntregaMercaderiaReq + "-" +
                datos.CodProducto + "-" +
                datos.NombreProducto + "-" +
                datos.Unspsc + "-" +
                datos.FechaPlanificadaRecepcion9 + "-" +
                datos.FechaRealRecepcion10 + "-" +
                datos.Comentario + "-" +
                datos.Texto111
                );
            }
        }
    }
}
