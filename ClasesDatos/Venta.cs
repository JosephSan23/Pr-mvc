using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDatos
{
    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idVenta { get; set; }
        public int idCliente { get; set; }
        public int totalCompra { get; set; }
        public float montoTotal { get; set; }
        public string contacto { get; set; }
        public string Ciudad { get; set; }
        public string departamento { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string idTransaccion { get; set; }
        public List<DetalleVenta> ODetalleVenta { get; set; }

    }
}
