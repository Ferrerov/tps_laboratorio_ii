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
        public string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }

        public Operando()
        {
            this.Numero = "0";
        }

        public Operando(double numero)
        {
            this.Numero = numero.ToString();
        }

        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        private double ValidarOperando(string strNumero)
        {
            if (double.TryParse(strNumero, out double numero) == true)
            {
                return numero;
            }
            return 0;
        } 
       

        private bool EsBinario(string binario)
        {
            /*for (int i = 0; i < binario.Length ; i++)
            {
                if (!(binario[i] == 0 || binario[i] == 1))
                {
                    return false;
                }

            }*/
            foreach (char value in binario)
            {
                if (!(value == '0' || value == '1'))
                {
                    return false;
                }
            }
            return true;
        }

        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario) == true)
            {
                double resultado = 0;
                int longitud = binario.Length;

                for (int i = longitud - 1; i > -1; i--)
                {
                    string auxBinario = binario[i - longitud - 1].ToString();
                    double auxNumero = double.Parse(auxBinario);
                    resultado += auxNumero * Math.Pow(2, i);
                }
                return resultado.ToString();
            }

            return "Valor inválido";
        }

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

        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }

        public static double operator +(Operando n1, Operando n2)
        {
            double numero = n1.numero + n2.numero;
            return numero;
        }
        public static double operator -(Operando n1, Operando n2)
        {
            double numero = n1.numero - n2.numero;
            return numero;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            double numero = n1.numero * n2.numero;
            return numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero != 0)
            {
                double numero = n1.numero / n2.numero;
                return numero;
            }
            return double.MinValue;
        }
    }
}
