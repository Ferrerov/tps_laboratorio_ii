using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        #region Propiedades
        /// <summary>
        /// Valida el numero y lo setea en el atributo privado numero
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que establece el atributo numero en el valor por defecto "0"
        /// </summary>
        public Operando()
        {
            this.Numero = "0";
        }

        /// <summary>
        /// Constructor que establece el atributo numero con un parametro de tipo double(parseado a string)
        /// </summary>
        /// <param name="numero"></param> Numero de tipo double
        public Operando(double numero)
        {
            this.Numero = numero.ToString();
        }

        /// <summary>
        /// Constructor que establece el atributo numero con un parametro de tipo string
        /// </summary>
        /// <param name="strNumero"></param> Numero de tipo string
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Valida el numero pasado por parametro
        /// </summary>
        /// <param name="strNumero"></param>Valor de tipo string a validar
        /// <returns></returns> Retorna el numero en formato double en caso de ser posible, de lo contrario retorna 0
        private double ValidarOperando(string strNumero)
        {
            if (double.TryParse(strNumero, out double numero) == true)
            {
                return numero;
            }
            return 0;
        } 
       
        /// <summary>
        /// Valida si un numero es binario o no
        /// </summary>
        /// <param name="binario"></param> Cadena a validar
        /// <returns></returns> Retorna true  si es binario y false si no lo es
        private bool EsBinario(string binario)
        {
            foreach (char value in binario)
            {
                if (!(value == '0' || value == '1'))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Convierte un numero binario a decimal
        /// </summary>
        /// <param name="binario"></param> Numero binario a convertir
        /// <returns></returns> Retorna el numero binario o un mensaje de error si no se pudo convertir
        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario) == true)
            {
                double resultado = 0;
                int longitud = binario.Length;

                for (int i = longitud - 1; i > -1; i--)
                {
                    string auxBinario = binario[longitud - i - 1].ToString();
                    double auxNumero = double.Parse(auxBinario);
                    resultado += auxNumero * Math.Pow(2, i);
                }
                return resultado.ToString();
            }

            return "Valor inválido";
        }

        /// <summary>
        /// Convierte un numero decimal a binario
        /// </summary>
        /// <param name="numero"></param> Numero decimal a convertir
        /// <returns></returns> Retorna el numero decimal o un mensaje de error si no se pudo convertir
        public string DecimalBinario(string numero)
        {
            if(int.TryParse(numero, out int decNumero) && decNumero > 0)
            {
                string binario = "";

                while (decNumero > 0)
                {
                    binario = (decNumero % 2).ToString() + binario;
                    decNumero /= 2;
                }
                return binario;
            }
            return "Valor inválido";
        }

        /// <summary>
        /// Convierte un numero decimal a binario
        /// </summary> Numero decimal a convertir
        /// <param name="numero"></param>
        /// <returns></returns> Retorna el numero decimal o un mensaje de error si no se pudo convertir
        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }

        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga del operador "+"
        /// </summary>
        /// <param name="n1"></param> Primer numero
        /// <param name="n2"></param> Segundo numero
        /// <returns></returns> Retorna el resultado de la suma entre los dos numeros
        public static double operator +(Operando n1, Operando n2)
        {
            double numero = n1.numero + n2.numero;
            return numero;
        }

        /// <summary>
        /// Sobrecarga del operador "-"
        /// </summary>
        /// <param name="n1"></param> Primer numero
        /// <param name="n2"></param> Segundo numero
        /// <returns></returns> Retorna el resultado de la resta entre los dos numeros
        public static double operator -(Operando n1, Operando n2)
        {
            double numero = n1.numero - n2.numero;
            return numero;
        }

        /// <summary>
        /// Sobrecarga del operador "*"
        /// </summary>
        /// <param name="n1"></param> Primer numero
        /// <param name="n2"></param> Segundo numero
        /// <returns></returns> Retorna el resultado de la multiplicacion entre los dos numeros
        public static double operator *(Operando n1, Operando n2)
        {
            double numero = n1.numero * n2.numero;
            return numero;
        }

        /// <summary>
        /// Sobrecarga del operador "/"
        /// </summary>
        /// <param name="n1"></param> Primer numero
        /// <param name="n2"></param> Segundo numero
        /// <returns></returns> Retorna el resultado de la division entre los dos numeros
        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero != 0)
            {
                double numero = n1.numero / n2.numero;
                return numero;
            }
            return double.MinValue;
        }
        #endregion
    }
}
