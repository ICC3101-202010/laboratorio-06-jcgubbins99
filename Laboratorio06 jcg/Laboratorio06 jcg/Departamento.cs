using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio06_jcg
{
    [Serializable]
    class Departamento : Division
    {
        public Departamento(string nombre, Person p1)
        {
            this.nombre = nombre;
            this.p1 = p1;
        }
    }
}
