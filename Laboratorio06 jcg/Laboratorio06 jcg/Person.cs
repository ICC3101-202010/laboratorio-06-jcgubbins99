using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio06_jcg
{
    [Serializable]
    public class Person
    {
        private string Nombreper;
        private string Apellido;
        private string Rut;

        public string nombreper
        {
            get
            {
                return Nombreper;
            }
            set
            {
                Nombreper = value;
            }
        }
        public string apellido
        {
            get
            {
                return Apellido;
            }
            set
            {
                Apellido = value;
            }
        }
        public string rut
        {
            get
            {
                return Rut;
            }
            set
            {
                Rut = value;
            }
        }

        public Person(string nombre, string apellido, string rut)
        {
            this.nombreper = nombre;
            this.apellido = apellido;
            this.rut = rut;

        }
        
    }
}
