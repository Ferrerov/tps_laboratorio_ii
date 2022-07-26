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
        private bool completado;
        private long dniCliente;
        private ETipoServicio tipoServicio;
        private ETipoDispositivo dispositivo;
        private int id;
        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public int Costo { get => costo; set => costo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public bool Completado { get => completado; set => completado = value; }
        public long DniCliente { get => dniCliente; set => dniCliente = value; }
        public ETipoServicio TipoServicio { get => tipoServicio; set => tipoServicio = value; }
        public ETipoDispositivo Dispositivo { get => dispositivo; set => dispositivo = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        #endregion

        #region Constructores
        public Servicio()
        {

        }
        public Servicio(int costo, DateTime fecha, DateTime fechaEntrega, string detalle, bool estado, long dniCliente, ETipoServicio tipoServicio, ETipoDispositivo dispositivo, int id)
        {
            Costo = costo;
            Fecha = fecha;
            FechaEntrega = fechaEntrega;
            Detalle = detalle;
            Completado = estado;
            DniCliente = dniCliente;
            TipoServicio = tipoServicio;
            Dispositivo = dispositivo;
            Id = id;
        }
        #endregion
    }
    
}
