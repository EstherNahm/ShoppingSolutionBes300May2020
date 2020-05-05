using AutoMapper;
using ShoppingApi.Data;
using ShoppingApi.Models;


namespace ShoppingApi
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            // // FROM ShoppingItem -> ShoppingListItemResponse
           CreateMap<ShoppingItem, ShoppingListItemResponse>();
        }
    }
}
