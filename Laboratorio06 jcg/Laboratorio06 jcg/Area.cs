﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio06_jcg
{
    [Serializable]
    class Area:Division
    {
        
        public Area(string nombre)
        {
            this.nombre = nombre;
            this.p1 = Empresa.Personarandom();
        }
    }

}
