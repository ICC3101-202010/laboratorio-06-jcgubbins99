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
            this.rutempresa = rutempresa;
            this.nombreempresa = nombreempresa;
            division.Add(new Area("Area:"));
            division.Add(new Seccion("Seccion: "));
            division.Add(new Departamento("Departamento: "));
            division.Add(new Bloque("Bloque: "));

        }
        public string Verinfodiv()
        {

            string stringaux1 =("Empresa: "+nombreempresa+"Rut: "+rutempresa+"\n");
            for (int i = 0; i < division.Count; i++)
            {

                stringaux1 += division[i].information() + "\n";

                stringaux1 += " ";
            }
            return stringaux1;



        }
    }
}
