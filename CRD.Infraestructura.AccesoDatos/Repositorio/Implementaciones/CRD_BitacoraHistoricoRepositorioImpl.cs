using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_BitacoraHistoricoRepositorioImpl : BaseRepositorioImpl<CRD_BitacoraHistorico>, ICRD_BitacoraHistoricoRepositorio
    {
        public List<CRD_BitacoraHistorico> buscarPorFactura(string Factura)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from obj in context.CRD_BitacoraHistorico
                                    where obj.Factura == Factura
                                    select obj;
                    return resultado.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar la lista de ordenes", ex);
            }
        }


        public List<CRD_BitacoraHistorico> buscarPorPartner(string Partner)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from obj in context.CRD_BitacoraHistorico
                                    where obj.Partner == Partner
                                    select obj;
                    return resultado.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar la lista de ordenes", ex);
            }
        }

        public List<CRD_BitacoraHistorico> buscarPorRuc(string Ruc)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from obj in context.CRD_BitacoraHistorico
                                    where obj.Ruc == Ruc
                                    select obj;
                    return resultado.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar la lista de ordenes", ex);
            }
        }


        public List<CRD_BitacoraHistorico> buscarPorNumeroOrden(string NumeroOrden)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from obj in context.CRD_BitacoraHistorico
                                    where obj.Numero_Orden == NumeroOrden
                                    select obj;
                    return resultado.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar la lista de ordenes", ex);
            }
        }
    }
}
