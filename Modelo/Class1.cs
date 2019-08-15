using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        public int id { get; set; }
        public int codigo{ get; set; }
        public string descripcion{ get; set; }
    }

    public class ProductoStock { 
        public Producto producto { get; set; }
        public DateTime ingreso { get; set; }
        public DateTime egreso{get; set;}
    }

    //precio?
    public class Stock
    { 
        List<Producto> productos { get; set; }
    }

    public class Venta
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public List<Producto> Productos { get;set;}
        public EnumEstado Estado { get;set; }
    }

    public enum EnumEstado { 
        abierta, consumada, cancelada
    }
}
