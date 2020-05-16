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
        public static Person p2 = Empresa.Personarandom();
        public static Person p3 = Empresa.Personarandom();
        public static Person p4 = Empresa.Personarandom();
        public static Person p5 = Empresa.Personarandom();
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
            stringaux=("Encargado de "+nombre+" : "+p1.nombreper +" "+p1.apellido+" de rut : "+p1.rut);
            return stringaux;
        }
        public static void informationbloque1()
        {
            
            Console.WriteLine("Personal bloque 1"+"\n");
            Console.WriteLine("Empleado 1: "+ p2.nombreper+" "+p2.apellido+" de rut: "+ p2.rut);
            Console.WriteLine("Empleado 2: " + p3.nombreper + " " + p3.apellido + " de rut: " + p3.rut);
        }
        public static void informationbloque2()
        {
            Console.WriteLine("");
            Console.WriteLine("=================================================");
            Console.WriteLine("Personal bloque 2" + "\n");
            Console.WriteLine("Empleado 1: " + p4.nombreper + " " + p4.apellido + " de rut: " + p4.rut);
            Console.WriteLine("Empleado 2: " + p5.nombreper + " " + p5.apellido + " de rut: " + p5.rut);
        }

    }
}
