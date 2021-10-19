using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace practica3.Models
{
    public class ProductoContext: DbContext
    {
        public DbSet<Categoria> Categorias{get;set;}
        public DbSet<Producto> Productos{get; set;}
        public ProductoContext(DbContextOptions dco):base(dco) {
        }
    }
}