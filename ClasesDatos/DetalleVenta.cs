using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDatos
{
    public class DetalleVenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idDetalleVenta { get; set; }
        public int idVenta { get; set; }
        public Producto oProducto { get; set; }
        public int cantidad { get; set; }
        public float total { get; set; }
        public string idTransaccion { get; set; }


    }
}
