using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_AuditoriaBitacoraUnitTest
    {
        CRD_AuditoriaBitacoraServicio _service = new CRD_AuditoriaBitacoraServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_AuditoriaBitacora entry = new CRD_AuditoriaBitacora();

            entry.CRD_Usuarios.Id = 1;  
            entry.NombreTabla = "CRD_Cajas";
            entry.FechaModificacion = DateTime.Now;  
            entry.RegistroHistorico = "Cambio realizado en la descripción de la caja.";

            _service.Add(entry);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var getAll = _service.GetAll();

            foreach(var item in getAll)
                Console.WriteLine($"{item.NombreTabla}, {item.FechaModificacion.ToString()}, {item.RegistroHistorico}");
        }

        [TestMethod]
        public void ObtenerAuditoriaBitacoraPorNombreUsuarioTest()
        {
            var getAll = _service.ObtenerAuditoriaBitacoraPorNombreUsuario("user1");

            foreach (var item in getAll)
                Console.WriteLine($"{item.NombreTabla}, {item.FechaModificacion.ToString()}, {item.RegistroHistorico}");
        }

        [TestMethod]
        public void ObtenerAuditoriaBitacoraPorRangoFechasTest()
        {


            var getAll = _service.ObtenerAuditoriaBitacoraPorRangoFechas(DateTime.Now, DateTime.Now);

            foreach (var item in getAll)
                Console.WriteLine($"{item.NombreTabla}, {item.FechaModificacion.ToString()}, {item.RegistroHistorico}");
        }

        [TestMethod]
        public void ObtenerAuditoriaBitacoraPorRangoFechasRegistroHistoricoTest()
        {
            var getAll = _service.ObtenerAuditoriaBitacoraPorRangoFechasRegistroHistorico("historico1");

            foreach (var item in getAll)
                Console.WriteLine($"{item.NombreTabla}, {item.FechaModificacion.ToString()}, {item.RegistroHistorico}");
        }
    }
}