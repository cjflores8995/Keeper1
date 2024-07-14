using Bogus;
using Bogus.DataSets;

using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using CRD.Infraestructura.AccesoDatos.Repositorio;
using CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_IvaUnitTest
    {
        CRD_IvaServicio _service = new CRD_IvaServicio();


        [TestMethod]
        public void AddTest()
        {
            CRD_Iva entry = new CRD_Iva();

            entry.ValorIva = 12;
            entry.Activo = true;

            _service.Add(entry);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var entry = _service.GetById(1);

            entry.ValorIva = 15;

            _service.Modify(entry);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var getAll = _service.GetAll();

            foreach (var item in getAll)
                Console.WriteLine($"{item.ValorIva}, {item.Activo}");
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var item = _service.GetById(1);
            Console.WriteLine($"{item.ValorIva}, {item.Activo}");
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
