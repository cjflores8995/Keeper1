using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_CargoUnitTest
    {
        CRD_CargoServicio _service = new CRD_CargoServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_Cargo entry = new CRD_Cargo();

            entry.NombreCargo = "cargo 1";
            entry.Descripcion = "descripcion cargo";
            entry.Activo = true;

            _service.Add(entry);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var entry = _service.GetById(1);

            entry.NombreCargo = "Nombre modificado";

            _service.Modify(entry);
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var item = _service.GetById(1);
            Console.WriteLine($"{item.NombreCargo}, {item.Descripcion}");
        }

        [TestMethod]
        public void DeleteTest()
        {
            var entry = _service.GetById(1);
            entry.Activo = false;
            _service.Modify(entry);
        }

        [TestMethod]
        public void ObtenerCargoPorNomreTest()
        {
            var entry = _service.ObtenerElementoPorNombre("Gerente");
        }

        

    }
}
