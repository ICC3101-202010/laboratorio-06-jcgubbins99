using System;
using System.Collections.Generic;
using System.IO;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Laboratorio06_jcg
{
    class Program
    {

        static void Main()
        {
            
            List<Empresa> listaempresas = new List<Empresa>();
            string accion1 = "";
            while (accion1 != "3")
            {
                Console.Clear();
                Console.WriteLine("¿Quiere utilizar la base de datos para cargar la información de la empresa");
                Console.WriteLine("======================================================================\n");
                Console.WriteLine("1. SI");
                Console.WriteLine("2. NO");
                Console.WriteLine("3. SALIR");
                accion1 = Console.ReadLine();
                switch (accion1)
                {
                    case "1":

                        try
                        {
                            Activarlistaempresa();
                            verinforempresa(listaempresas);
                            

                        }
                        catch (SerializationException error)

                        {
                            Console.WriteLine("ERROR DE TIPO: " + error.Message);
                            Thread.Sleep(2000);
                            Console.WriteLine("NO SE ENCONTRÓ LA EMPRESA EN LA BASE DE DATOS");
                            Thread.Sleep(2000);
                            Agregarempresa(listaempresas);
                        }
                        break;
                    case "2":
                        Activarlistaempresa();
                        Agregarempresa(listaempresas);
                        break;
                    case "3":
                        break;

                }

            }
            static void Agregarempresa(List<Empresa> empresa)
            {
                Console.Clear();
                string nombree = "";
                string rute = "";
                Console.WriteLine("VAMOS A AGREGARLA A LA BASE DE DATOS");
                Console.WriteLine("=====================================");
                Thread.Sleep(1000);
                Console.WriteLine("Ingrese el nombre de su empresa");
                nombree = Console.ReadLine();
                Console.WriteLine("Ingrese el rut de su empresa");
                rute = Console.ReadLine();
                Empresa e = new Empresa(nombree, rute);
                empresa.Add(e);
                AlmacenarEmpresa(empresa);
                Console.WriteLine("Empresa agregada a la base de datos exitosamente");
                Thread.Sleep(2000);
            }

            static void AlmacenarEmpresa(List<Empresa> s)      //Serializamos
            {
                IFormatter formatter3 = new BinaryFormatter();
                Stream stream3 = new FileStream("Empresas.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter3.Serialize(stream3, s);
                stream3.Close();
            }
            static List<Empresa> CargarEmpresa()
            {
                IFormatter formatter4 = new BinaryFormatter();
                Stream stream4 = new FileStream("Empresas.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                List<Empresa> s2 = (List<Empresa>)formatter4.Deserialize(stream4);
                stream4.Close();
                return s2;
            }
            void Activarlistaempresa()
            {
                listaempresas = CargarEmpresa();
            }
            string verinforempresa(List<Empresa> e)
            {
                string stringaux2 = "";
                for (int i = 0; i < e.Count; i++)
                {

                    stringaux2 += e[i].Verinfodiv() + "\n";

                    stringaux2 += " ";
                }
                return stringaux2;
            }
        }
    }
}
