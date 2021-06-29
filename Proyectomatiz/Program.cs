using System;



namespace proyectomatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] ma = new string[5, 15];
            char OP = 's';
            int op; while (OP == 's')
            {
                ma[0, 0] = "Nombre";
                ma[1, 0] = "Apellido";
                ma[2, 0] = "Direccion";
                ma[3, 0] = "Telefono";
                ma[4, 0] = "Correo"; Console.Clear();
                Console.WriteLine("Qué Desea Hacer:\n 1.Ingresar Contacto\n 2.Mostrar Contactos\n 3.Buscar");
                op = int.Parse(Console.ReadLine());



                if (op == 1)
                {



                    Console.Clear();
                    Console.WriteLine("Ingrese los siguientes datos: Nombre, Apellido, Direccion, Telefono, Correo\n");
                    for (int f = 1; f <= 15; f++)
                    {
                        for (int x = 0; x < 5; x++)
                        {
                            Console.Write("Ingrese Nota [Valor:" + (f) + ", Dato:" + (x + 1) + "]: "); ma[x, f] = Console.ReadLine();
                        }
                    }
                }
                if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\nDatos de los Contactos: ");
                    for (int f = 0; f < 15; f++)
                    {
                        Console.WriteLine(ma[0, f] + " " + ma[1, f] + " " + ma[2, f] + " " + ma[3, f] + " " + ma[4, f]);
                    }
                }
                if (op == 3)
                {
                    int a;
                    Console.Clear();
                    Console.WriteLine("Seleccione El Número de Contacto que Desea Buscar:\n");
                    a = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("El Contacto que buscaba es: " + ma[0, a] + " " + ma[1, a] + " " + ma[2, a] + " " + ma[3, a] + " " + ma[4, a]);
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Quiere regresar a menú principal?[s/n]");
                OP = char.Parse(Console.ReadLine());
                Console.Clear();
            }



        }



    }
}