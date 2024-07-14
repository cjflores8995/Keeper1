using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_EstadoTipoProcesosUnitTest
    {
        CRD_EstadoTipoProcesosServicio _service = new CRD_EstadoTipoProcesosServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_EstadoTipoProcesos entry = new CRD_EstadoTipoProcesos();

            entry.Nombre = "nombre";
            entry.Descripcion = "descripcion";
            entry.Activo = true;

            _service.Add(entry);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var entry = _service.GetById(1);

            entry.Descripcion = "Nombre modificado";

            _service.Modify(entry);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var getAll = _service.GetAll();

            foreach(var item in getAll)
                Console.WriteLine($"{item.Nombre}, {item.Descripcion}, {item.Activo}");
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var item = _service.GetById(6);
            Console.WriteLine($"{item.Nombre}, {item.Descripcion}, {item.Activo}");
        }

        [TestMethod]
        public void DeleteTest()
        {
            var entry = _service.GetById(1);
            entry.Activo = false;
            _service.Modify(entry);
        }

        [TestMethod]
        public void BusNomTest()
        {
            var busNom = _service.buscarPorNombre("nombre");
            Console.WriteLine(busNom.IdEstadoTipoProceso + "--" + busNom.Nombre);
        }
    }
}
