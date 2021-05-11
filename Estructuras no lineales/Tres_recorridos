using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Campos Guillen Eduardo
// Ing. Sistemas Computacionales
// Estructura de Datos

namespace Tres_recorridos
{
    class Program
    {
        static Arbol raiz;
        static Arbol t;
        static Arbol t2;
        static Arbol re;
        static Arbol inf;
        static int b = 0;
        static string x;

        class Arbol
        {
            public string dato;
            public Arbol ramadere;
            public Arbol ramaizq;
        }
        static int menu = 1;
        static string opc_2 = null;
        static char opc;
        static void Main(string[] args)
        {
            raiz = null;
            Menu();
        }
        static void Menu()
        {
            do
            {
                Console.Clear();
				Console.WriteLine("=-=-=-=-= Menú =-=-=-=-= \n" +
							"¿Qué desea hacer? \n" +
							"\t\n" +
							"[1] Insertar un nombre\n" +
							"[2] Recorrer por Prefijo\n" +
							"[3] Recorrer por Infijo\n" +
                            "[4] Recorrer por Posfijo\n");
				Console.WriteLine("");
				Console.WriteLine("[5] Salir");
                opc = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (opc)
                {
                    case '1':
                        Console.WriteLine("=-=-=-=-= Insertar un nombre =-=-=-=-=\n");
                        InsertarNombres();
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("=-=-=-=-= Recorrido en prefijo =-=-=-=-=\n");
                        re = raiz;
                        Preorden(re);
				        Console.WriteLine("");
                        Console.WriteLine("Presiona cualquier tecla para volver al menú.");
                        Console.ReadKey();
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("=-=-=-=-= Recorrido en Infijo =-=-=-=-=\n");
                        re = raiz;
                        Infijo(re);
                        Console.WriteLine("");
                        Console.WriteLine("Presiona cualquier tecla para volver al menú.");

                        Console.ReadKey();
                        break;
                    case '4':
                        Console.Clear();
                        Console.WriteLine("=-=-=-=-= Recorrido en Posfijo =-=-=-=-=\n");
                        re = raiz;
                        Posfijo(re);
                        Console.WriteLine("");
                        Console.WriteLine("Presiona cualquier tecla para volver al menú.");

                        Console.ReadKey();
                        break;
                    default:
                        menu = 0;
                        break;
                }
            } while (menu != 0);

        }
        // Metodo que solamente pide capturar los nombres, el de abajo es el encargado de insertar
        public static void InsertarNombres()
        {
                do
                {
                    Console.WriteLine("Ingresa un nombre");
                    x = Console.ReadLine();
                    Insertar();
                    re = raiz;
                    Preorden(re);

                    Console.WriteLine();
					Console.WriteLine("Desea ingresar algo mas? [S], [N]");
                    opc_2 = Console.ReadLine();
                    Console.Clear();
                } while (opc_2 == "S" || opc_2 == "s");
        }
        // Metodo para insertar en el arbol
        public static void Insertar()
        {
            if (raiz == null)
            {
                raiz = new Arbol {dato = x, ramadere = null, ramaizq = null};
            }
            else
            {
                b = 0;
                t = raiz;
                do
                {
                    if (string.Compare(x, t.dato) >= 0)
                    {
                        if (t.ramadere == null)
                        {
                            t2 = new Arbol {dato = x, ramadere = null, ramaizq = null};
                            t.ramadere = t2;
                            b = 1;
                        }
                        else
                            t = t.ramadere;
                    }
                    else
                    {
                        if (t.ramaizq == null)
                        {
                            t2 = new Arbol{ dato = x, ramadere = null, ramaizq = null};
                            t.ramaizq = t2;
                            b = 1;
                        }
                        else
                            t = t.ramaizq;
                    }
                } while (b == 0);
            }
        }
        static void Preorden(Arbol re)
        {
            if (re != null)
            {
                Console.Write("[" + re.dato + "] ");
                Preorden(re.ramaizq);
                Preorden(re.ramadere);
            }
        }
        static void Infijo(Arbol re)
        {
            if (re != null)
            {
                if (re.ramaizq != null)
                    Infijo(re.ramaizq);
                    // Impresión de re.dato
                    Console.WriteLine("[" + re.dato + "] ");
                if (re.ramadere != null)
                    Infijo(re.ramadere);
            }
            else
                Console.WriteLine("No hay nada más que mostrar");
        }
        static void Posfijo(Arbol re)
        {
            if(re != null)
            {
                if(re.ramaizq != null)
                    Posfijo(re.ramaizq);
                if(re.ramadere != null)
                    Posfijo(re.ramadere);
                // Impresión de re.dato    
                Console.WriteLine("[" + re.dato + "] ");
            }
            else
                Console.WriteLine("No hay nada más que mostrar");
        }
    }
}
