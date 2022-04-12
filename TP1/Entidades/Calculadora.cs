using System;

namespace Entidades
{
    public static class Calculadora
    {
        #region Metodos
        
        /// <summary>
        /// Valida que el operador sea valido (+,-,/,*)
        /// </summary>
        /// <param name="operador"></param> Operador de tipo char a validar
        /// <returns></returns> Retorna el operador y en caso de que no sea valido, retorna el operador "+"
        private static char ValidarOperador(char operador)
        {
            if (operador == '-' || operador == '*' || operador == '/')
            {
                return operador;
            }
            return '+';
        }

        /// <summary>
        /// Realiza la operacion entre dos numeros mediante la sobrecarga de operadores de la clase Operando
        /// </summary>
        /// <param name="num1"></param> Primer numero
        /// <param name="num2"></param> Segundo numero
        /// <param name="operador"></param> Operador a utilizar
        /// <returns></returns> Retorna el resultado de la operacion realizada
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            char operadorValidado = ValidarOperador(operador);

            switch (operadorValidado)
            {
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
                default:
                    return num1 + num2;
            }
        }
        #endregion
    }
}
