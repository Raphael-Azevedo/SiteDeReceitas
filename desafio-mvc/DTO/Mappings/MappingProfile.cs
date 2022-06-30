using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using desafio_mvc.Models;

namespace desafio_mvc.DTO.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Categoria, CategoriaDTO>().ReverseMap();
            CreateMap<Medida, MedidaDTO>().ReverseMap();
            CreateMap<Ingrediente,IngredienteDTO>().ReverseMap();
            CreateMap<Receita, ReceitaDTO>().ReverseMap();
        }

    }
}