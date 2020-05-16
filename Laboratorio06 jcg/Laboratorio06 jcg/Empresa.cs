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

        }
    }
}
