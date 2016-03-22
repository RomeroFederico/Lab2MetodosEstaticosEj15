using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_15
{
    /* 
    15.  Realizar un programa que permita realizar operaciones matemáticas
    simples (suma, resta, multiplicación y división). 
    Para ello se le debe pedir al usuario que ingrese dos números y 
    la operación que desea realizar (pulsando el caracter +, -, * ó 
    /).  
    El usuario decidirá cuando finalizar el programa.  
    Crear una clase llamada Calculadora que posea tres métodos 
    estáticos (de clase): 
    Calcular (público): Recibirá tres parámetros, el primer 
    número, el segundo número y la operación matemática. El 
    método devolverá el resultado de la operación.  
    Validar (Privado): Recibirá como parámetro el segundo 
    número. Este método se debe utilizar sólo cuando la 
    operación elegida sea la DIVISION. Este método devolverá 
    TRUE si el número es distinto de CERO.  
    Mostrar (público): Este método recibe como parámetro el 
    resultado de la operación y lo muestra por pantalla. 
    No posee valor de retorno.  
    */

    class Ejercicio_15
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;

            Console.Title = "Ejercicio Nro. 15";

            do
            {
                Console.Clear();
                Console.Write("- Ingrese el pimer numero: ");
                while (!double.TryParse(Console.ReadLine(), out numero1))
                {
                    Console.Clear();
                    Console.Write("- ERROR!!! No se ha ingresado un numero. Ingrese el pimer numero: ");
                }

                Console.Clear();
                Console.WriteLine(numero1);
                Console.Write("- Ingrese el segundo numero: ");
                while (!double.TryParse(Console.ReadLine(), out numero2))
                {
                    Console.Clear();
                    Console.WriteLine(numero1);
                    Console.Write("- ERROR!!! No se ha ingresado un numero. Ingrese el segundo numero: ");
                }

                Console.Clear();
                Console.WriteLine(numero1 + " _ " + numero2);
                Console.Write("- Ingrese la operacion (+, -, *, /): ");

                Calculadora.Mostrar(Calculadora.Calcular(numero1, numero2, Console.ReadLine()));

                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("¿Desea continuar (S)? ");
            } while (Console.ReadLine().ToUpper().Equals("S"));
        }
    }
}
