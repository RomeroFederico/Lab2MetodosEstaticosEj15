using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_15
{
    class Calculadora
    {
        /// <summary>
        /// Permite realizar las operaciones aritmeticas basicas entre dos numeros.
        /// </summary>
        /// <param name="numero1">
        /// Numero sobre el cual se operara.
        /// </param>
        /// <param name="numero2">
        /// Operando del calculo.
        /// </param>
        /// <param name="operacion">
        /// "+" => Suma, "-" => Resta, "*" => Multiplicacion, "/" => Division.
        /// </param>
        public static double Calcular(double numero1, double numero2, string operacion)
        {
            switch (operacion)
            {
                case "+":
                    return numero1 + numero2;
                case "-":
                    return numero1 - numero2;
                case "*":
                    return numero1 * numero2;
                case "/":
                    if (Calculadora.Validar(numero2))
                        return numero1 / numero2;
                    Console.WriteLine("- ERROR!!! No se puede dividir por 0. ");
                    break;
                default:
                    Console.WriteLine("- ERROR!!! No se ha elegido una operacion correcta. ");
                    break;
            }

            return 0;
        }

        /// <summary>
        /// Valida si el argumento es distinto de 0.
        /// </summary>
        /// <param name="numero">
        /// Numero a validar.
        /// </param>
        private static bool Validar(double numero)
        {
            if (numero != 0)
                return true;
            return false;
        }

        /// <summary>
        /// Muestra por consola el argumento.
        /// </summary>
        /// <param name="numero">
        /// Numero a mostrar.
        /// </param>
        public static void Mostrar(double numero)
        {
            Console.WriteLine(numero);
        }
    }
}
