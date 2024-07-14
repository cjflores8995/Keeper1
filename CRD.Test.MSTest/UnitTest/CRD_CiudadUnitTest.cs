using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_CiudadUnitTest
    {
        CRD_CiudadServicio _service = new CRD_CiudadServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_Ciudad entry = new CRD_Ciudad();

            entry.NombreCiudad = "nombre ciudad";
            entry.Descripcion = "descripcion ciudad";
            entry.Activo = true;

            _service.Add(entry);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var entry = _service.GetById(4);

            entry.NombreCiudad = "Nombre modificado";

            _service.Modify(entry);
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var item = _service.GetById(4);
            Console.WriteLine($"{item.NombreCiudad}, {item.Descripcion}, {item.Activo}");
        }

        [TestMethod]
        public void DeleteTest()
        {
            var entry = _service.GetById(4);
            entry.Activo = false;
            _service.Modify(entry);
        }

        [TestMethod]
        public void ObtenerCiudadPorNomreTest()
        {
            var item = _service.ObtenerCiudadPorNomre("Quito");
            Console.WriteLine($"{item.NombreCiudad}, {item.Descripcion}, {item.Activo}");
        }


        

    }
}
