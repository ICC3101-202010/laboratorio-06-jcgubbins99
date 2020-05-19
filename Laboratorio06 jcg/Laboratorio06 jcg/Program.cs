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
                        Console.Clear();
                        Activarlistaempresa();
                        

                        try
                        {



                            
                            string accion20 = "";
                            while (accion20 != "2")
                            {
                                verinforempresa(listaempresas);
                                verinforempresa2(listaempresas);
                                verinforempresa3(listaempresas);
                                Console.WriteLine("=================================================");
                                Console.WriteLine(" ");
                                Console.WriteLine(" 2. PARA SALIR");
                                accion20 = Console.ReadLine();
                                
                                switch (accion20)
                                {
                                    case "2":
                                        break;

                                }
                            }





                        }
                        catch (SerializationException error)

                        {
                            Console.WriteLine("ERROR DE TIPO: " + error.Message);
                            Thread.Sleep(2000);
                            Console.WriteLine("NO SE ENCONTRÓ LA EMPRESA EN LA BASE DE DATOS");
                            Thread.Sleep(2000);
                            Agregarempresa();
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Agregarempresa();
                        break;
                    case "3":
                        break;

                }

            }
            void Agregarempresa()
            {
                Console.Clear();
                string nombree = "";
                string rute = "";
                string nombrep1 = "";
                string apellidop1 = "";
                string rutp1 = "";

                Console.WriteLine("VAMOS A AGREGARLA A LA BASE DE DATOS");
                Console.WriteLine("=====================================");
                Thread.Sleep(1000);
                Console.WriteLine("Ingrese el nombre de su empresa");
                nombree = Console.ReadLine();
                Console.WriteLine("Ingrese el rut de su empresa");
                rute = Console.ReadLine();
                Empresa e = new Empresa(nombree, rute);
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("VAMOS A AGREGAR AL ENCARGADO DE ÁREA" + "\n");
                Thread.Sleep(2000);
                Console.WriteLine("Ingrese el nombre del encargado del Area");
                nombrep1 = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido el nombre del encargado del Area");
                apellidop1 = Console.ReadLine();
                Console.WriteLine("Ingrese el rut del encargado del Area");
                rutp1 = Console.ReadLine();
                Person p = new Person(nombrep1, apellidop1, rutp1);
                Division d = new Area("Area", p);
                e.Division.Add(d);
                Console.WriteLine("Encargado agregado correctamente");
                Thread.Sleep(1500);
                Console.Clear();
                Console.WriteLine("VAMOS A AGREGAR AL ENCARGADO DE DEPARTAMENTO" + "\n");
                Thread.Sleep(2000);
                Console.WriteLine("Ingrese el nombre del encargado del Departamento");
                nombrep1 = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido el nombre del encargado del Departamento");
                apellidop1 = Console.ReadLine();
                Console.WriteLine("Ingrese el rut del encargado del Departamento");
                rutp1 = Console.ReadLine();
                Person p1 = new Person(nombrep1, apellidop1, rutp1);
                Division d1 = new Area("Departamento", p1);
                e.Division.Add(d1);
                Console.WriteLine("Encargado agregado correctamente");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("VAMOS A AGREGAR AL ENCARGADO DE SECCION" + "\n");
                Thread.Sleep(2000);
                Console.WriteLine("Ingrese el nombre del encargado de Seccion");
                nombrep1 = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido el nombre del encargado del Seccion");
                apellidop1 = Console.ReadLine();
                Console.WriteLine("Ingrese el rut del encargado del Seccion");
                rutp1 = Console.ReadLine();
                Person p3 = new Person(nombrep1, apellidop1, rutp1);
                Division d3 = new Area("Seccion", p3);
                e.Division.Add(d3);
                Console.WriteLine("Encargado agregado correctamente");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("VAMOS A AGREGAR AL ENCARGADO DE LOS BLOQUES" + "\n");
                Thread.Sleep(2000);
                Console.WriteLine("Ingrese el nombre del encargado de los Bloques");
                nombrep1 = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido el nombre del encargado de los Bloques");
                apellidop1 = Console.ReadLine();
                Console.WriteLine("Ingrese el rut del encargado de los Bloques");
                rutp1 = Console.ReadLine();
                Person p4 = new Person(nombrep1, apellidop1, rutp1);
                Division d4 = new Area("Bloque", p4);
                e.Division.Add(d4);
                Console.WriteLine("Encargado agregado correctamente");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("VAMOS A AGREGAR AL TRABAJADORES DE LOS BLOQUES" + "\n");
                Thread.Sleep(2000);
                Console.WriteLine("Ingrese el nombre del trabajador 1 del Bloque 1 ");
                nombrep1 = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido el nombre del trabajaor 1 del Bloque 1");
                apellidop1 = Console.ReadLine();
                Console.WriteLine("Ingrese el rut del trabajador 1 del Bloque 1");
                rutp1 = Console.ReadLine();
                Person p5 = new Person(nombrep1, apellidop1, rutp1);
                e.Division[3].personasbloque1.Add(p5);
                Thread.Sleep(1000);
                Console.WriteLine("Ingrese el nombre del trabajador 2 del Bloque 1 ");
                nombrep1 = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido el nombre del trabajaor 2 del Bloque 1");
                apellidop1 = Console.ReadLine();
                Console.WriteLine("Ingrese el rut del trabajador 2 del Bloque 1");
                rutp1 = Console.ReadLine();
                Person p6 = new Person(nombrep1, apellidop1, rutp1);
                e.Division[3].personasbloque1.Add(p6);
                Thread.Sleep(1000);
                Console.WriteLine("Trabajadores agregados correctamente");
                Thread.Sleep(1000);

                Console.Clear();
                Console.WriteLine("Ingrese el nombre del trabajador 1 del Bloque 2 ");
                nombrep1 = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido el nombre del trabajaor 1 del Bloque 2");
                apellidop1 = Console.ReadLine();
                Console.WriteLine("Ingrese el rut del trabajador 1 del Bloque 2");
                rutp1 = Console.ReadLine();
                Person p7 = new Person(nombrep1, apellidop1, rutp1);
                e.Division[3].personasbloque2.Add(p7);
                Thread.Sleep(1000);
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese el nombre del trabajador 2 del Bloque 2 ");
                nombrep1 = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido el nombre del trabajaor 2 del Bloque 2");
                apellidop1 = Console.ReadLine();
                Console.WriteLine("Ingrese el rut del trabajador 2 del Bloque 2");
                rutp1 = Console.ReadLine();
                Person p8 = new Person(nombrep1, apellidop1, rutp1);
                e.Division[3].personasbloque2.Add(p8);
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Trabajadores agregados correctamente");
                Thread.Sleep(1000);
                listaempresas.Add(e);

                AlmacenarEmpresa(listaempresas);


                Console.WriteLine("Empresa agregada a la base de datos exitosamente");
                Thread.Sleep(2000);
            }

            static void AlmacenarEmpresa(List<Empresa> s)      //Serializamos
            {
                Stream stream3;

                IFormatter formatter3 = new BinaryFormatter();
                stream3 = new FileStream("Empresas.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter3.Serialize(stream3, s);
                stream3.Close();



            }
            static List<Empresa> CargarEmpresa()
            {
                try
                {
                    IFormatter formatter4 = new BinaryFormatter();
                    Stream stream4 = new FileStream("Empresas.bin", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                    List<Empresa> s2 = (List<Empresa>)formatter4.Deserialize(stream4);
                    stream4.Close();
                    return s2;

                }
                catch
                {
                    throw new Exception();
                }

            }
            void Activarlistaempresa()
            {
                try
                {
                    listaempresas = CargarEmpresa();

                }
                catch
                {
                    Console.WriteLine("ERROR !!!!!");
                    Thread.Sleep(2000);
                    Console.WriteLine("NO SE ENCONTRÓ EN LA BASE DE DATOS");
                    Thread.Sleep(2000);
                    Agregarempresa();
                }

            }
            void verinforempresa(List<Empresa> e)
            {

                for (int i = 0; i < e.Count; i++)
                {

                    Console.WriteLine(e[i].Verinfodiv());


                }



            }
            void verinforempresa2(List<Empresa> e1)
            {
                Console.WriteLine(e1[0].Division[3].Verinfobloque1());
                


            }
            void verinforempresa3(List<Empresa> e1)
            {
                
                Console.WriteLine(e1[0].Division[3].Verinfobloque2());
                


            }
        }
    }
}



        
    
