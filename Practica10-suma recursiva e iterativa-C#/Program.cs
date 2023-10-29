//hazel yorelly perez hernandez
// maquina 11

using System;

class Program
{
    static int SumaIterativa(int n)
    {
        int suma = 0;

        while (n > 9)
        {
            suma += n % 10;
            n /= 10;
        }
        return suma + n;
    }

    static int SumaRecursiva(int n)
    {
        if (n <= 9)
            return n;
        else
            return SumaRecursiva(n / 10) + n % 10;
    }
    // en esta parte se unen las dos operaciones que tenemos anteriormente 
    static void Main()
    {
        int lasopciones;
        int operacion;
        int salir;

        do
        {

            Console.WriteLine("____________________________________________________  \n");
            Console.WriteLine(" :) Ejercicos de las sumas recursivas e iterativa :) \n ");
            Console.WriteLine("____________________________________________________  \n");
            Console.WriteLine("presione 1 para la suma recursiva, 2 para la suma iterativa o 3 para salir. \n ");
            Console.WriteLine("1.-La suma Recursiva. \n ");
            Console.WriteLine("2.-La suma Iterativa. \n ");
            Console.WriteLine("3.-salir........ \n ");
            Console.WriteLine("Ingrese una opcion : \n");

            if (int.TryParse(Console.ReadLine(), out lasopciones))
                // se utiliza el switch para hacer un menu y asi meter las dos sumas que tenemos 
                switch (lasopciones)
                {
                    case 1:
                        Console.WriteLine("Ingrese un numero para la respectiva suma recursiva: "); if (int.TryParse(Console.ReadLine(), out operacion))
                        {
                            Console.WriteLine("Suma recursiva: " + SumaRecursiva(operacion));
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese un numero para la respectiva suma iterativa: "); if (int.TryParse(Console.ReadLine(), out operacion))
                        {
                            Console.WriteLine("Suma iterativa: " + SumaIterativa(operacion));
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("fin del programa :) ");
                            if (int.TryParse(Console.ReadLine(), out salir)) ;
                        }
                            break;
                default:
                        Console.WriteLine("error con la opcion :(");
                    break;
            }
          
        } while (lasopciones != 3);
     
    }
}
