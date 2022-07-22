using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Servicio
    {
        #region Atributos
        private int costo;
        private DateTime fecha;
        private DateTime fechaEntrega;
        private string detalle;
        private bool estado;
        private long dniCliente;
        private ETipoServicio tipoServicio;
        private ETipoDispositivo dispositivo;
        #endregion

        #region Propiedades
        public int Costo { get => costo; set => costo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public bool Estado { get => estado; set => estado = value; }
        public long DniCliente { get => dniCliente; set => dniCliente = value; }
        public ETipoServicio TipoServicio { get => tipoServicio; set => tipoServicio = value; }
        public ETipoDispositivo Dispositivo { get => dispositivo; set => dispositivo = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        #endregion

        #region Constructores
        public Servicio(int costo, DateTime fecha, DateTime fechaEntrega, string detalle, bool estado, long dniCliente, ETipoServicio tipoServicio, ETipoDispositivo dispositivo)
        {
            Costo = costo;
            Fecha = fecha;
            FechaEntrega = fechaEntrega;
            Detalle = detalle;
            Estado = estado;
            DniCliente = dniCliente;
            TipoServicio = tipoServicio;
            Dispositivo = dispositivo;
        }
        #endregion
    }
    
}
