using System;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Simulador de cocción estufa");
        Console.WriteLine("Productos disponibles: Pez, Res, Cerdo, Pollo.");
        Console.WriteLine("Combustibles disponibles: Madera, Gas, Hoja, Electricidad & Carbón mineral.");
        Console.WriteLine("Niveles de llama: Fuego bajo, Fuego medio, Fuego alto.");
        Console.WriteLine();

        Console.Write("Ingrese el producto a cocinar: ");
        string producto = Console.ReadLine();

        Console.Write("Ingrese el tipo de combustible: ");
        string combustible = Console.ReadLine();

        Console.Write("Ingrese el nivel de llama (fuego bajo, fuego medio, fuego alto): ");
        string nivelLlama = Console.ReadLine();

        double tiempoCoccion = CalcularTiempoCoccion(producto, combustible, nivelLlama);

        Console.WriteLine();
        Console.WriteLine($"Tiempo estimado de cocción para {producto} usando {combustible} y nivel de llama {nivelLlama}: {tiempoCoccion} minutos");
    }

    static double CalcularTiempoCoccion(string producto, string combustible, string nivelLlama)
    {
        double tiempoBase = 0;

        // Ajustar el tiempo base según el producto
        switch (producto.ToLower())
        {
            case "pez":
                tiempoBase = 10;
                break;
            case "res":
                tiempoBase = 15;
                break;
            case "cerdo":
                tiempoBase = 12;
                break;
            case "pollo":
                tiempoBase = 8;
                break;
            default:
                Console.WriteLine("Producto no válido.");
                Environment.Exit(0);
                break;
        }

        // Ajustar el tiempo base según el combustible
        switch (combustible.ToLower())
        {
            case "madera":
                tiempoBase += 5;
                break;
            case "gas":
                tiempoBase += 3;
                break;
            case "electricidad":
                tiempoBase += 2;
                break;
            case "carbon mineral":
                tiempoBase += 4;
                break;
            case "hoja":
                tiempoBase += 6;
                break;
            default:
                Console.WriteLine("Combustible no válido.");
                Environment.Exit(0);
                break;
        }

        // Ajustar el tiempo base según el nivel de llama
        switch (nivelLlama.ToLower())
        {
            case "fuego bajo":
                tiempoBase += 2;
                break;
            case "fuego medio":
                tiempoBase += 4;
                break;
            case "fuego alto":
                tiempoBase += 6;
                break;
            default:
                Console.WriteLine("Nivel de llama no válido.");
                Environment.Exit(0);
                break;
        }

        return tiempoBase;
    }
}

