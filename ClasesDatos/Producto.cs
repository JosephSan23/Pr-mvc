using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDatos
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Marca oMarca { get; set; }
        public Categoria oCategoria { get; set; }
        public float precio { get; set; }
        public int stock { get; set; }
        public string rutaImagen { get; set; }
        public string nombreImagen { get; set; }
        public bool activo { get; set; }
    }
}
