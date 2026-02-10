using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02IntroduccionEF
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreCliente { get; set; }

        //propiedad de navegacion
        public List<DetalleCompra> Detalles { get; set; }
    }
}
