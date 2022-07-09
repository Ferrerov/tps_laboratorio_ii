using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region Constructores
        /// <summary>
        /// Constructor de Ciclomotor
        /// </summary>
        /// <param name="marca"></param> Marca del Ciclomotor
        /// <param name="chasis"></param> Chasis del Ciclomotor
        /// <param name="color"></param> Color del Ciclomotor
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) 
            : base(marca,chasis,color)
        {
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobreescritura del metodo Mostrar, retorna los datos del Ciclomotor
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
