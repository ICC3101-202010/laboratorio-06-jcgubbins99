using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratorio06_jcg
{
    [Serializable]
    class Bloque : Division
    {

        
        public Bloque(string nombre, Person p1)
        {
            this.nombre = nombre;
            this.p1 = p1;
            personasbloque1 = new List<Person>();
            personasbloque2 = new List<Person>();


        }



        

    }
}

