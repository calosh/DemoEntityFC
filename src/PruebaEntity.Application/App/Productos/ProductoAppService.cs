using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using PruebaEntity.App.Productos.Dto;
using PruebaEntity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEntity.App.Productos
{
    public class ProductoAppService: ApplicationService
    {
        private readonly IRepository<Producto> _repositoryProductos;
        public ProductoAppService(IRepository<Producto> repositoryProductos)
        {
            _repositoryProductos = repositoryProductos;
        }
        public List<ProductoSalidaDto> holaMundo()
        {

            var productos = _repositoryProductos.GetAll()
                .Include("Categorias")
                .Include("Categorias.Nivel");

            var productos2 = _repositoryProductos.GetAll()
                .Include("Categorias")
                .Include("Categorias.Nivel")
                .Where(p => p.stock >= 10)
                .OrderByDescending(p => p.stock)
                .ToList()
                ;

            var productosDto = new List<ProductoSalidaDto>();

            foreach (var prod in productos)
            {
                

                var listaCategorias = new List<CategoriaDto>();
                foreach (var cat in prod.Categorias)
                {
                    listaCategorias.Add(new CategoriaDto { Id = cat.Id, Nombre = cat.Nombre , Nivel = cat.Nivel.Nombre });
                   
                }

                productosDto.Add(new ProductoSalidaDto { Id = prod.Id, Nombre = prod.Nombre, stock = prod.stock, Categorias = listaCategorias });

            }

             return productosDto;
        }
    }
}
