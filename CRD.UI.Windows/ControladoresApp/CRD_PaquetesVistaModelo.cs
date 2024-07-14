﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.ControladoresApp
{
    public class CRD_PaquetesVistaModelo
    {
        public int IdPaquete { get; set; }
        public string NombrePaquete { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> EstatusPaquete { get; set; }
        public bool Activo { get; set; }

        public int IdCajas { get; set; }
    }
}
