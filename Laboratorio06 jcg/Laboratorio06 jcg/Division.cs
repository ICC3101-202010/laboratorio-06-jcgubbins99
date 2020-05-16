using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio06_jcg
{
    [Serializable]
    public class Division
    {
        private string Nombre;

        public string nombre
        {
            get
            {
                return Nombre;

            }
            set
            {
                Nombre = value;
            }
        }
        public string information()
        {
            string stringaux = "";
            stringaux=("Encargado de:"+nombre);
            return stringaux;
        }

        
    }
}
