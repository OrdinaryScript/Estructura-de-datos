using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejercicio_arboles
{
    class Program
    {
        static Arbol raiz;
    public class Arbol
        {
            public double salario;
            public Arbol izq, der;
            public Arbol()
            {
            salario = 0;
            izq = null;
            der = null;
        }
    }
        static void Insertar()
        {
            Arbol n = new Arbol();
            Arbol a = new Arbol();
            double sueldo;
            int bandera;
            bandera = 0;
            n.der = null;
            n.izq = null;
            Console.Write("Ingrese el sueldo: ");
            sueldo = Double.Parse(Console.ReadLine());
            n.salario = sueldo;
            if (raiz == null) raiz = n;
                else
                {
                    a = raiz;
                    while (bandera != 1)
                    {
                    if (n.salario < a.salario)
                    {
                        if (a.izq == null)
                        {
                            a.izq = n;
                            bandera = 1;
                        }
                        else
                            a = a.izq;
                    }
                    else 
                        if (a.der == null)
                        {
                            a.der = n;
                            bandera = 1;
                        }
                        else 
                            a = a.der;
                    }
                }
        }
        static void Preorden(Arbol temp)
        {
            if (temp != null)
            {
                Console.WriteLine("{0},",temp.salario);
                if (temp.izq != null) Preorden(temp.izq);
                if (temp.der != null) Preorden(temp.der);
            }
            else
                Console.WriteLine("El árbol está vacío.");
        }
        static void Main(string[] args)
        {
            char opc;
            int menu = 1;
            string respuesta;
            do
            {
                Console.WriteLine("=-=-=-=-= Menú =-=-=-=-= \n" +
                                "¿Qué desea hacer? \n" +
                                "\t\n" +
                                "[1] Insertar sueldo\n" +
                                "[2] Recorrer en orden previo\n");
                Console.WriteLine("");
                Console.WriteLine("[3] Salir");
                opc = Console.ReadKey().KeyChar;
                Console.Clear();
            switch (opc)
                {
                case '1':
                    do
                    {
                        Console.WriteLine("=-=-=-=-= Insertar sueldo =-=-=-=-= \n");
                        Insertar();
                        Console.WriteLine("Desea ingresar algo mas? [S], [N]");
                        respuesta = Console.ReadLine();
                        Console.Clear();
                    } while (respuesta == "S" || respuesta == "s");
                break;
                case '2':
                    Console.WriteLine("=-=-=-=-= Orden previo =-=-=-=-= \n");
                    Preorden(raiz);
                    Console.Write("Presiona cualquier tecla para regresar al menú.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    menu = 0;
                    break;
                }
            } while (menu != 0);
        }
    }
}
