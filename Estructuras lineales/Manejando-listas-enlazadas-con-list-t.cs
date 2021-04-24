using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Campos Guillen Eduardo
// Ing. Sistemas Computacionales
// Estructura de Datos
namespace manejando_listas_enlazadas_con_list_t
{
    class Program
    {
        public static string opc = null, busca, elemento=null, other_opc = null;
        public static char respuesta;
        public static int menu = 1;
        public static List <string> ListaT = new List<string> (50);
        public static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            do{
                Console.WriteLine("=-=-=-=-= Menú =-=-=-=-= \n" +
                                "¿Qué desea hacer? \n" +
                                "\t\n" +
                                "[1] Insertar nombres de mascotas\n" +
                                "[2] Eliminar nombres de mascotas\n" +
                                "[3] Eliminar todos los nombres de mascotas\n" +
                                "[4] Buscador de nombre de mascotas\n" +
                                "[5] Mostrar espacios disponibles\n");
                Console.WriteLine("");
                Console.WriteLine("[6] Salir");
                respuesta = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (respuesta)
                {
                    case '1':
                        do
                        {
                            Console.WriteLine("=-=-=-=-= Insertando elementos en la lista =-=-=-=-= \n");
                            Console.WriteLine(" ");
                            Console.WriteLine("Datos de la lista  [" + ListaT.Count + "]");
                            Console.WriteLine(" ");
                            Console.WriteLine("Inserte el nombre de la mascota.");
                            elemento = Console.ReadLine();

                            Insertar(ref ListaT);
                            Console.Clear();
                            Recorre(ref ListaT);

                            Imprimir(ref ListaT);

                            Console.WriteLine("Desea ingresar algo mas? [S], [N]");
                            opc = Console.ReadLine();
                            Console.WriteLine("");
                            Console.Clear();
                        }while (opc == "S" || opc == "s");
                        break;
                    case '2':
                    do{
                            Console.WriteLine("=-=-=-=-= Eliminando elementos en la lista =-=-=-=-= \n");
                            Console.WriteLine(" ");
                            Console.WriteLine("Datos de la lista  [" + ListaT.Count+ "]");
                            Console.WriteLine(" ");
                            Recorre(ref ListaT);
                            Console.WriteLine();

                            Console.WriteLine("Escriba el nombre a eliminar.");
                            busca = Console.ReadLine();
                            if(ListaT.Contains(busca )== true)
                                ListaT.Remove(busca);
                            else
                                Console.WriteLine("El valor [" + busca + "] no se encuentra en la lista.");
                            
                            Imprimir(ref ListaT);
                            Recorre(ref ListaT);
                    }while (opc == "S" || opc == "s");
                        break;
                    case '3':
                            Console.WriteLine("=-=-=-=-= Eliminando todos los elementos de la lista =-=-=-=-= \n");
                            Console.WriteLine(" ");
                            Console.WriteLine("Datos de la lista  [" + ListaT.Count + "]");
                            Console.WriteLine(" ");
                            Recorre(ref ListaT);
                            Console.WriteLine();

                            Console.WriteLine("Desea eliminar todos los elementos? [S], [N]");
                            other_opc = Console.ReadLine();

                            if (other_opc == "S" || other_opc == "s")
                            {
                                ListaT.Clear();
                                Console.WriteLine(" ");
                                Console.WriteLine("Se han eliminado todos los elementos de la lista. \n" +
                                "Presione cualquier tecla para volver al menú");
                                Console.ReadKey();
                            }
                            // if(ListaT.Contains(busca)== true)
                            //     ListaT.Remove(busca);
                            // else
                            //     Console.WriteLine("El valor [" + busca + "] no se encuentra en la lista.");
                        break;
                    case '4':
                        do{
                            Console.WriteLine("=-=-=-=-= Buscando elementos en la lista =-=-=-=-= \n");
                            Console.WriteLine(" ");
                            Console.WriteLine("Datos de la lista  [" + ListaT.Count + "]");
                            Console.WriteLine(" ");
                            Console.WriteLine();

                            Console.WriteLine("Escriba el nombre que desea buscar.");
                            busca = Console.ReadLine();
                            if(ListaT.Contains(busca)== true)
                                Console.WriteLine("Se encontró el nombre [" + busca + "]");
                            else
                                Console.WriteLine("El valor [" + busca + "] no se encuentra en la lista.");

                            Console.WriteLine("Desea buscar otro elemento? [S], [N]");
                            opc = Console.ReadLine();
                    }while (opc == "S" || opc == "s");
                        break;
                    case '5':
                        Console.WriteLine("Los espacios disponibles en la lista son de [" + ListaT.Count + "/" +  ListaT.Capacity+ "]");
                        Console.WriteLine(" ");
                        Console.WriteLine("Presione cualquier tecla para volver al menú");
                        Console.ReadKey();
                        break;
                    default:
                        menu = 0;
                        break;
                }

            } while (menu != 0);
        }
        public static void Insertar (ref List <string> ListaT){
            if (ListaT.Count == ListaT.Capacity)
                Console.WriteLine("La lista está llena.");
            else
                {
                    ListaT.Add(elemento);
                    ListaT.Sort();
                }
        }
        public static void Recorre(ref List <string> ListaT){
            foreach(string item in ListaT)
                Console.WriteLine("[" + item + "]");
        }
        public static void Imprimir (ref List <string> ListaT)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Datos de la lista  [" + ListaT.Capacity + "]");
        }
        // public static void Eliminar (ref List <string> ListaT)
        // {
        //     Console.WriteLine(" ");
        //     Console.WriteLine("Se ha eliminado un elemento de la lista.");
        //     ListaT.RemoveAt(1);
        // }
    }
}
