using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_PaquetesUnitTest
    {
        CRD_PaquetesServicio _service = new CRD_PaquetesServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_Paquetes entry = new CRD_Paquetes();

            entry.CRD_Cajas.IdCaja = 1;
            entry.NombrePaquete = "nombre";
            entry.Descripcion = "descripcion";
            entry.EstatusPaquete = true;
            entry.Activo = true;

            _service.Add(entry);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var entry = _service.GetById(1);

            entry.Descripcion = "nuevo valor";

            _service.Modify(entry);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var getAll = _service.GetAll();

            foreach(var item in getAll)
                Console.WriteLine($"{item.NombrePaquete}, {item.Descripcion}");
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var item = _service.GetById(1);
            Console.WriteLine($"{item.NombrePaquete}, {item.Descripcion}");
        }

        [TestMethod]
        public void DeleteTest()
        {
            var entry = _service.GetById(1);
            entry.Activo = false;
            _service.Modify(entry);
        }

    }
}
