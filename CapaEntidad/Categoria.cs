using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    //CREATE TABLE categoria(
    //id_categoria int primary key identity,
    //descripcion varchar (100),
    //activo bit default 1,
    //fecha_registro datetime default getdate()
    //);

    public class Categoria
    {
        public int idCategoria { get; set; }
        public string descripcion { get; set; }
        public bool activo { get; set; }
    }
}
