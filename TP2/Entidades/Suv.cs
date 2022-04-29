using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region Constructores
        /// <summary>
        /// Constructor de Suv
        /// </summary>
        /// <param name="marca"></param> La marca del Suv
        /// <param name="chasis"></param> Chasis del Suv
        /// <param name="color"></param> Color del Suv
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(marca, chasis, color)
        {
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobreescritura del metodo Mostrar de la clase Vehiculo, retorna los datos del Suv
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
