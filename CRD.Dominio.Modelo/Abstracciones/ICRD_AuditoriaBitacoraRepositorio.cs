using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_AuditoriaBitacoraRepositorio : IBaseRepositorio<CRD_AuditoriaBitacora>
    {
        List<CRD_AuditoriaBitacora> ObtenerAuditoriaBitacoraPorNombreUsuario(string nombre);
        List<CRD_AuditoriaBitacora> ObtenerAuditoriaBitacoraPorRangoFechas(DateTime fechaInicio, DateTime fechaFin);
        List<CRD_AuditoriaBitacora> ObtenerAuditoriaBitacoraPorRangoFechasRegistroHistorico(string registroHistorico);
        List<CRD_AuditoriaBitacora> ObtenerElementos();
    }
}