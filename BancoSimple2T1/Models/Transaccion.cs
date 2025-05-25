using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSimple2T1.Models
{
    /// <summary>
    /// Representa una transacción bancaria entre dos cuentas.
    /// </summary>
    public class Transaccion
    {
        /// <summary>
        /// Identificador único de la transacción.
        /// </summary>
        public int TransaccionId { get; set; }

        /// <summary>
        /// Monto transferido en la transacción.
        /// </summary>
        public decimal Monto { get; set; }

        /// <summary>
        /// Fecha y hora en que se realizó la transacción.
        /// </summary>
        public DateTime Fecha { get; set; } = DateTime.Now;

        /// <summary>
        /// Descripción opcional de la transacción.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// ID de la cuenta de origen (puede ser null si no aplica).
        /// </summary>
        public int? CuentaOrigenId { get; set; }

        /// <summary>
        /// ID de la cuenta de destino (puede ser null si no aplica).
        /// </summary>
        public int? CuentaDestinoId { get; set; }

        /// <summary>
        /// Valida que la transacción tenga datos correctos y consistentes.
        /// </summary>
        /// <returns>True si la transacción es válida, de lo contrario False.</returns>
        public bool Validar()
        {
            if (Monto <= 0)
                return false;

            if (CuentaOrigenId == null && CuentaDestinoId == null)
                return false;

            if (CuentaOrigenId != null && CuentaDestinoId != null && CuentaOrigenId == CuentaDestinoId)
                return false;

            return true;
        }
    }
}
