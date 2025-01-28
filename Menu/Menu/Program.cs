internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetCursorPosition(30, 10);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Menu 1 de la 2da Unidad\n");
        Console.SetCursorPosition(30, 13);
        Console.WriteLine("Menu 1");
        Console.SetCursorPosition(30, 14);
        Console.WriteLine("1. Dibujar Grafica");
        Console.SetCursorPosition(30, 15);
        Console.WriteLine("2. Dibujar Espiral");
        Console.SetCursorPosition(30, 16);
        Console.WriteLine("3. Salir");
        Console.SetCursorPosition(30, 17);
       
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.Clear();
                Console.SetCursorPosition(30, 0);
                Console.WriteLine("Dibujar grafica");

                int x = 79, y = 20; 
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(x, y);
                Console.Write("*");
                x -= 1;
                for (int i = 1; i <= 12; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(x + 1, y);
                    Console.Write("*");
                    for (int a = 1; a <= 5; a++)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.SetCursorPosition(x, y);
                        Console.Write("*");
                        x -= 1; 
                        Thread.Sleep(50);
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    if (i % 2 == 0)
                    {
                        for (int a = 1; a <= 14; a++)
                        {
                            Console.SetCursorPosition(x, y);
                            y = y + 1;
                            Console.Write("*");
                            Thread.Sleep(50);
                        }
                        x -= 1; 
                    }
                    else
                    {
                        for (int a = 1; a <= 14; a++)
                        {
                            Console.SetCursorPosition(x, y);
                            y = y - 1;
                            Console.Write("*");
                            Thread.Sleep(50);
                        }
                        x -= 1;  
                    }
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(x + 1, y);
                Console.Write("*");
                x -= 1;
                Thread.Sleep(50);
                for (int a = 1; a <= 5; a++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.SetCursorPosition(x + 1, y);
                    Console.Write("*");
                    x -= 1;
                    Thread.Sleep(50);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(20, 25);
                Console.WriteLine("Listo!!! Presione una tecla para continuar");
                Console.ReadKey();
                break;


            case 2:
                Console.Clear();
                int px = 40;
                int py = 15;
                Console.SetCursorPosition(px, py);
                int longitudX = 4, longitudY = 2;
                int color = 1;

                void CambiarColor(int color)
                {
                    Console.ForegroundColor = color switch
                    {
                        1 => ConsoleColor.Green,
                        2 => ConsoleColor.Yellow,
                        3 => ConsoleColor.Blue,
                        4 => ConsoleColor.Red,
                        _ => ConsoleColor.Cyan
                    };
                }

                for (int capa = 1; capa <= 22; capa++)
                {
                    int pasos = (capa % 2 == 0) ? longitudY : longitudX;
                    for (int i = 1; i <= pasos; i++)
                    {
                        CambiarColor(color);
                        Console.SetCursorPosition(px, py);
                        Console.Write("*");

                        if (capa % 2 == 0)
                        {
                            py += (capa == 2 || capa == 6 || capa == 10 || capa == 14 || capa == 18 || capa == 22) ? -1 : 1;
                        }
                        else 
                        {
                            px += (capa == 1 || capa == 5 || capa == 9 || capa == 13 || capa == 17 || capa == 21) ? -1 : 1;
                        }

                        color = (color < 5) ? color + 1 : 1;
                        Thread.Sleep(100);
                    }
                    if (capa % 2 == 0)
                    {
                        longitudY += 2;
                    }
                    else
                    {
                        longitudX += 5;

                    }
                }
                break;

            case 3:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saliendo del programa...");
                Thread.Sleep(1000);
                break;
        }

        Console.ReadKey();


    }
}
