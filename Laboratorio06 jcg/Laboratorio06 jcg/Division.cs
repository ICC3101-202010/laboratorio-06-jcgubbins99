﻿using System;
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
            stringaux1 += "Bloque 1" + " :" + "\n";
            stringaux1 += "Trabajador " + 1 + " :" + personasbloque1[0].nombreper + " " + personasbloque1[0].apellido + " De rut: " + personasbloque1[0].rut + "\n";
            stringaux1 += "Trabajador " + 2 + " :" + personasbloque1[1].nombreper + " " + personasbloque1[1].apellido + " De rut: " + personasbloque1[1].rut + "\n";




            

            return stringaux1;
        }
        public string Verinfobloque2()
        {

            string stringaux2 = "";
            stringaux2 += "Bloque 2" + " :" + "\n";
            stringaux2 += "Trabajador " + 1 + " :" + personasbloque2[0].nombreper + " " + personasbloque2[0].apellido + " De rut: " + personasbloque2[0].rut + "\n";
            
            stringaux2 += "Trabajador " + 2 + " :" + personasbloque2[1].nombreper + " " + personasbloque2[1].apellido + " De rut: " + personasbloque2[1].rut + "\n";





            

            return stringaux2;

        }
    }
}
