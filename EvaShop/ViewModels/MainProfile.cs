using AutoMapper;
using EvaShop.Models;

namespace EvaShop.ViewModels
{
    public class MainProfile : Profile
    {
        public MainProfile()
        {
            CreateMap<Inventario, InventarioViewModel>()
                .ForMember(vm=>vm.Articulo,opt=>opt.MapFrom(src=>src.Articulo.Nombre))
                .ForMember(vm=>vm.PrecioDeVenta,opt=>opt.MapFrom(src=>Math.Round(src.PrecioDeVenta,2)))
                .ForMember(vm=>vm.SubCategoriaId,opt=>opt.MapFrom(src=>src.Articulo.SubCategoriaId))
                .ForMember(vm=>vm.SubCategoria,opt=>opt.MapFrom(src=>src.Articulo.SubCategoria.Nombre))
                .ForMember(vm=>vm.CategoriaId,opt=>opt.MapFrom(src=>src.Articulo.SubCategoria.CategoriaId))
                .ForMember(vm=>vm.Categoria,opt=>opt.MapFrom(src=>src.Articulo.SubCategoria.Categoria.Nombre));


            CreateMap<Inventario, ShopingCartViewModel>()
                .ForMember(vm => vm.Articulo, opt => opt.MapFrom(src => src.Articulo.Nombre))
                .ForMember(vm => vm.PrecioDeVenta, opt => opt.MapFrom(src => Math.Round(src.PrecioDeVenta, 2)));
        }
    }
}
