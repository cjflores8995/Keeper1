using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class AspNetUsersUnitTest
    {
        CRD_UsuariosServicio _service = new CRD_UsuariosServicio();

        [TestMethod]
        public void ObtenerUsuarioPorEmailTest()
        {
            var result = _service.ObtenerUsuarioPorEmail("john.doe@example.com");

            Console.WriteLine($"{result.Nombre}, {result.Apellido}");

        }

        [TestMethod]
        public void GetByIdTest()
        {
            var result = _service.ObtenerUsuarioPorId(1);
            Console.WriteLine($"{result.Nombre}, {result.Apellido}");
        }

    }
}
