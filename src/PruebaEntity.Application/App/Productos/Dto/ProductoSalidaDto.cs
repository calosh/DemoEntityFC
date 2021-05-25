using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEntity.App.Productos.Dto
{
    public class ProductoSalidaDto : EntityDto
    {
        public string Nombre { set; get; }
        public int stock { set; get; }
        public List<CategoriaDto> Categorias { set; get; }
    }

    public class CategoriaDto : EntityDto
    {
        public string Nombre { set; get; }
        public string Nivel { set; get; }
    }

    public class NivelDto : EntityDto
    {
        public string Nombre { set; get; }
    }

}
