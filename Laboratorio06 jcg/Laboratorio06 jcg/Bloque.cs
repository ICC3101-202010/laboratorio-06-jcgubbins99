using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio06_jcg
{
    [Serializable]
    class Bloque:Division 
    {
        
        public Bloque(string nombre)
        {
            this.nombre = nombre;
            this.p1 = Empresa.Personarandom();

        }
    }
}
