using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_PaquetesRepositorio : IBaseRepositorio<CRD_Paquetes>
    {
        List<CRD_Paquetes> ObtenerPaquetesPorNombre(string nombre);
        List<CRD_Paquetes> ObtenerPaquetesPorIdCaja(int id);
        List<CRD_Paquetes> ObtenerElementosActivos();
        bool EliminadoLogico(int id);
        bool InsertarPaquete(CRD_Paquetes obj);
        bool ActualizarPaquete(CRD_Paquetes obj);
    }
}