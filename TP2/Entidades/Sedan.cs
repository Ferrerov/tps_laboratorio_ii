using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region Enumerados y atributos
        public enum ETipo { CuatroPuertas, CincoPuertas }
        ETipo tipo;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de Sedan
        /// </summary>
        /// <param name="marca"></param> Marca del Sedan
        /// <param name="chasis"></param> Chasis del Sedan
        /// <param name="color"></param> Color del Sedan
        /// <param name="tipoPuertas"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipoPuertas)
            : base(marca, chasis, color)
        {
            tipo = tipoPuertas;
        }
        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param> Marca del Sedan
        /// <param name="chasis"></param> Chasis del Sedan
        /// <param name="color"></param> Color del Sedan
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color, ETipo.CuatroPuertas)
        {
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobreescritura del metodo Mostrar, retorna los datos del Sedan
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendFormat("TIPO : {0}", this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
