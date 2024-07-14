using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace CRD.Test.MSTest.UnitTest
{
    [TestClass]
    public class CRD_ValijasUnitTest
    {
        CRD_ValijasServicio _service = new CRD_ValijasServicio();

        [TestMethod]
        public void AddTest()
        {
            CRD_Valijas entry = new CRD_Valijas();

            entry.CRD_Bitacora.IdBitacora = 24;
            entry.Fecha = DateTime.Now;
            entry.Origen = "origen 1";
            entry.Remitente = "remitente";
            entry.Centro = "centro 1";
            entry.OBSV = "observacion 1";
            entry.Activo = true;

            _service.Add(entry);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var entry = _service.GetById(1);

            entry.Remitente = "nuevo valor";

            _service.Modify(entry);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var getAll = _service.GetAll();

            foreach(var item in getAll)
                Console.WriteLine($"{item.Origen}, {item.Remitente}");
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var item = _service.GetById(1);
            Console.WriteLine($"{item.Origen}, {item.Remitente}");
        }

        [TestMethod]
        public void DeleteTest()
        {
            var entry = _service.GetById(1);
            entry.Activo = false;
            _service.Modify(entry);
        }

        [TestMethod]
        public void BusOriTest()
        {
            var busOri = _service.buscarPorOrigen("Origen1");
            Console.WriteLine(busOri.IdValija + "--" + busOri.Origen);
        }
        public void BusRemTest()
        {
            var busRem = _service.buscarPorRemitente("Remitente1");
            Console.WriteLine(busRem.IdValija + "--" + busRem.Remitente);
        }
    }
}
