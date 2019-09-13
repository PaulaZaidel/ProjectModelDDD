using AutoMapper;
using ProjectModelDDD.Domain.Entities;
using ProjectModelDDD.MVC.ViewModels;

namespace ProjectModelDDD.MVC.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Client, ClientViewModel>();
            CreateMap<ClientViewModel, Client>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductViewModel, Product>();
        }
    }
}
