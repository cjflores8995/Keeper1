//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRD.Dominio.Modelo.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class CRD_AnalistasCRD_EstadoTipoProcesos
    {
        public int IdAnalistaEstadoProceso { get; set; }
        public bool Activo { get; set; }
    
        public virtual CRD_Analistas CRD_Analistas { get; set; }
        public virtual CRD_EstadoTipoProcesos CRD_EstadoTipoProcesos { get; set; }
    }
}