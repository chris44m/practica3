using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace practica3.Models
{
    public class Categoria
    {
        public int id { get; set; }
        public string nombre { get; set; }
        
        public ICollection<Producto> Productos{get;set;}

    }
}