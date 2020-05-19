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
        public List<Division> Division { get => division; set => division = value; }

        public Empresa(string nombreempresa, string rutempresa)
        {

            this.rutempresa = rutempresa;
            this.nombreempresa = nombreempresa;
            







        }
        public string Verinfodiv()
        {

            string stringaux1 = ("Empresa: " + nombreempresa + " Rut: " + rutempresa + "\n");
            for (int i = 0; i < Division.Count; i++)
            {

                stringaux1 += "\n" + Division[i].information();

                stringaux1 += " ";
            }
            return stringaux1;



        }
    }
}
