using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_CajasUnitTest
    {
        CRD_CajasServicio _service = new CRD_CajasServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_Cajas entry = new CRD_Cajas();

            entry.NombreCaja = "Caja Principal";
            entry.Descripcion = "Caja principal de la tienda";
            entry.EstatusCaja = true;
            entry.Activo = true;

            _service.Add(entry);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var entry = _service.GetById(1);

            entry.NombreCaja = "Nombre modificado";

            _service.Modify(entry);
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var item = _service.GetById(1);
            Console.WriteLine($"{item.NombreCaja}, {item.Descripcion}, {item.EstatusCaja}");
        }

        [TestMethod]
        public void DeleteTest()
        {
            var entry = _service.GetById(1);
            entry.Activo = false;
            _service.Modify(entry);
        }

        [TestMethod]
        public void ObtenerCajasPorNomreTest()
        {
            var entry = _service.ObtenerCajasPorNomre("Nombre modificado");
        }

        

    }
}
