using AutoMapper;
using Bakery.WebApi.Models;

namespace Bakery.WebApi.Dtos.Profiles
{

    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            CreateMap<Product, ProductReadDto>();
            CreateMap<ProductCreateDto, Product>();
            CreateMap<ProductUpdateDto, Product>();
        }


        
    }
}
