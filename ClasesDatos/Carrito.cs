using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDatos
{
    public class Carrito
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCarrito { get; set; }
        public Cliente oCliente { get; set; }
        public Producto oProducto { get; set; }
        public int cantidad { get; set; }
    }
}
