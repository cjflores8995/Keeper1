using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_EmpresasUnitTest
    {
        CRD_EmpresasServicio _service = new CRD_EmpresasServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_Empresas entry = new CRD_Empresas();

            entry.CodigoEmpresa = "EMP005";
            entry.Nombre = "nombre";
            entry.Descripcion = "descripcion";
            entry.Activo = true;

            _service.Add(entry);
        }


        [TestMethod]
        public void GetAllTest()
        {
            var getAll = _service.GetAll();

            foreach(var item in getAll)
                Console.WriteLine($"{item.Nombre}, {item.Descripcion}, {item.Activo}");
        }

        [TestMethod]
        public void BusNomTest()
        {
            var busNom = _service.buscarPorNombre("Empresa Ejemplo 1");
            Console.WriteLine(busNom.CodigoEmpresa + "--" + busNom.Nombre);
        }
        [TestMethod]
        public void BusCodTest()
        {
            var busCod = _service.buscarPorCodigoEmpresa("EMP002");
            Console.WriteLine(busCod.CodigoEmpresa + "--" + busCod.Nombre);
        }
    }
}
