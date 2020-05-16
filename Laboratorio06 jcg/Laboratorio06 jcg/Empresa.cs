using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio06_jcg
{
    [Serializable]
    class Empresa
    {
        private string Nombreempresa;
        private string Rutempresa;
        public List<Division> division = new List<Division>();
        public static List<Person> personas = new List<Person>();



        public string nombreempresa
        {
            get
            {
                return Nombreempresa;
            }
            set
            {
                Nombreempresa = value;
            }
        }

        public string rutempresa
        {
            get
            {
                return Rutempresa;
            }
            set
            {
                Rutempresa = value;
            }
        }
        public Empresa(string nombreempresa, string rutempresa)
        {
            personas.Add(new Person("Juan", "Perez", "20.284.512-6"));
            personas.Add(new Person("Jorge", "Gonzalez", "21.274.312-1"));
            personas.Add(new Person("Juan", "Alvarez", "20.284.512-6"));
            personas.Add(new Person("Javier", "Villanueva", "19.570.457-1"));
            personas.Add(new Person("Exequiel", "Del Campo", "20.296.512-7"));
            personas.Add(new Person("Alfonso ", "Conejeros", "15.147.946-K"));
            personas.Add(new Person("Pedro", "Hirmas", "17.467.784-6"));
            personas.Add(new Person("Allan", "Gubbins", "25.678.238-8"));
            personas.Add(new Person("Magdalena", "Alvarez", "18.570.010-4"));
            personas.Add(new Person("Juan Carlos", "Gubbins", "16.684.238-4"));
            personas.Add(new Person("Amelia", "Gubbins", "22.542.845-K"));
            personas.Add(new Person("Rosario", "Gubbins", "26.456.546-9"));
            personas.Add(new Person("Alejandro", "Ochagavia", "23.678.345-8"));
            personas.Add(new Person("Federico", "Brunner", "24.435.343-1"));
            personas.Add(new Person("Benjamín", "Roca", "18.483.243-9"));
            personas.Add(new Person("Benjamín", "Prado", "13.564.823-K"));
            personas.Add(new Person("Mariana", "Rosas", "26.456.546-9"));
            personas.Add(new Person("Alicia", "Vilches", "14.456.292-7"));
            personas.Add(new Person("Marcela", "Torrealba", "24.472.923-6"));
            personas.Add(new Person("Maximiliano", "Gross", "23.565.254-K"));
            personas.Add(new Person("Alberto", "Dominguez", "25.282.874-2"));
            this.rutempresa = rutempresa;
            this.nombreempresa = nombreempresa;
            division.Add(new Area(" Area :"));
            division.Add(new Seccion(" Seccion : "));
            division.Add(new Departamento(" Departamento : "));
            division.Add(new Bloque(" Bloque 1 : "));
            division.Add(new Bloque(" Bloque 2: "));
            





        }
        public string Verinfodiv()
        {

            string stringaux1 = ("Empresa: " + nombreempresa + " Rut: " + rutempresa + "\n");
            for (int i = 0; i < division.Count; i++)
            {

                stringaux1 += "\n" + division[i].information();

                stringaux1 += " ";
            }
            return stringaux1;



        }
        public static Person Personarandom()
        {
            Person p1;
            Random r1 = new Random();
            int i = r1.Next(personas.Count);
            p1 = personas[i];
            personas.Remove(p1);
            return p1;
        }

    }
}
