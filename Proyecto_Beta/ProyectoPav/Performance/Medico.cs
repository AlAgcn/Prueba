﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPav
{

    class Medico
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public int  Id { set; get; }
        public DateTime  Fecha_Entrada { set; get; }
        public DateTime  Fecha_Egreso { set; get; }
        public int Id_Usuario { set; get; }
        
    }

}
