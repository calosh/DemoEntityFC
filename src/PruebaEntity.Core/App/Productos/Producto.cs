using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEntity.App.Productos
{
    public class Producto: Entity
    {
        [Required]
        [StringLength(40)]
        public string Nombre { set; get; }
        [Required]
        public int stock { set; get; }
        
        public virtual List<Categoria> Categorias { set; get; }
    }

    public class Categoria : Entity
    {
        [Required]
        [StringLength(40)]
        public string Nombre { set; get; }

        public virtual Nivel Nivel { set; get;}
        public virtual List<Producto> Productos { set; get; }

        public Categoria()
        {
            this.Productos = new List<Producto>();
        }

    }

    public class Nivel: Entity
    {
        public string Nombre { set; get; }
    }
}
