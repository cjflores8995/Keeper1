using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_BitacoraHistoricoRepositorio : IBaseRepositorio<CRD_BitacoraHistorico>
    {
        List<CRD_BitacoraHistorico> buscarPorFactura(string Factura);
        List<CRD_BitacoraHistorico> buscarPorPartner(string Partner);
        List<CRD_BitacoraHistorico> buscarPorRuc(string Ruc);
        List<CRD_BitacoraHistorico> buscarPorNumeroOrden(string NumeroOrden);
    }

}
