using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio06_jcg
{
    [Serializable]
    public class Division
    {
        private string Nombre;
        public Person p1;
        public List<Person> personasbloque1 = new List<Person>();
        public List<Person> personasbloque2 = new List<Person>();

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
        public List<Person> Personasbloque1 { get => personasbloque1; set => personasbloque1 = value; }
        public List<Person> Personasbloque2 { get => personasbloque2; set => personasbloque2 = value; }
        public string information()
        {
            string stringaux = "";
            stringaux = ("Encargado de " + nombre + " : " + p1.nombreper + " " + p1.apellido + " de rut : " + p1.rut);
            return stringaux;
        }

        public string Verinfobloque1()
        {

            string stringaux1 = "";
            for (int i = 0; i < personasbloque1.Count; i++)
            {
                stringaux1 += "Bloque 1" + " :" + "\n";
                stringaux1 += "Trabajador " + (i + 1) + " :" + personasbloque1[i].nombreper + " " + personasbloque1[i].apellido + "De rut: " + personasbloque1[i].rut + "\n";


            }
            Console.WriteLine(stringaux1);

            return stringaux1;
        }
        public string Verinfobloque2()
        {

            string stringaux2 = "";
            for (int i = 0; i < personasbloque2.Count; i++)
            {
                stringaux2 += "Bloque 2" + " :" + "\n";
                stringaux2 += "Trabajador " + (i + 1) + " :" + personasbloque2[i].nombreper + " " + personasbloque2[i].apellido + "De rut: " + personasbloque2[i].rut + "\n";


            }
            Console.WriteLine(stringaux2);

            return stringaux2;

        }
    }
}
