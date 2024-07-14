using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_TipoDocumentosUnitTest
    {
        CRD_TipoDocumentosServicio _service = new CRD_TipoDocumentosServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_TipoDocumentos entry = new CRD_TipoDocumentos();

            entry.Nombre = "nombre";
            entry.Descripcion = "descripcion";
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
                Console.WriteLine($"{item.Nombre}, {item.Descripcion}");
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var item = _service.GetById(1);
            Console.WriteLine($"{item.Nombre}, {item.Descripcion}");
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
