using System;

class Program
{
    static void Main(string[] args)
    {
        int yes = 1;
        while (yes == 1)
        {
            Console.WriteLine("Hola como estas \nEspero que estes bien\nal igual que yo jajaja. \nBienvenido a:");
            Console.WriteLine("***** CALCULADORA *****");
            Console.WriteLine("1.- Sumar\n2.- Restar\n3.- Multiplicar\n4.- Dividir\n5.- Elevar al cuadrado\nSELECCIONE UN NUMERO PARA REALIZAR SU OPERACION ARITMETICA:");

            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el primer numero por favor:");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero por favor:");
            double n2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = n1 + n2;
                    Console.WriteLine($"El resultado de su suma es: {resultado}");
                    break;
                case 2:
                    resultado = n1 - n2;
                    Console.WriteLine($"El resultado de su resta es: {resultado}");
                    break;
                case 3:
                    resultado = n1 * n2;
                    Console.WriteLine($"El resultado de su multiplicacion es: {resultado}");
                    break;
                case 4:
                    resultado = n1 / n2;
                    Console.WriteLine($"El resultado de su division es: {resultado}");
                    
                    break;
                case 5:
                    resultado = Math.Pow(n1, n2);
                    Console.WriteLine($"El resultado de su elevacion al cuadrado es: {resultado}");
                    break;
               
            }

            Console.WriteLine("¿Te gustaria seguir utilizando la calculadora? \n1.- Si\n2.- No");
            yes = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Gracias por usar esta calculadora.");
    }
}