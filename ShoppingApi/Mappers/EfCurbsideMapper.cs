
using AutoMapper;
using ShoppingApi.Data;
using ShoppingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApi.Mappers
{
    public class EfCurbsideMapper : IMapCurbsideOrders
    {
        private readonly ShoppingDataContext DataContext;
        private readonly IMapper Mapper;
        private readonly MapperConfiguration MapperConfig;

        public EfCurbsideMapper(ShoppingDataContext dataContext, IMapper mapper, MapperConfiguration mapperConfig)
        {
            DataContext = dataContext;
            Mapper = mapper;
            MapperConfig = mapperConfig;
        }

        async Task<CurbsideOrder> IMapCurbsideOrders.PlaceOrder(CreateCurbsideOrder orderToPlace)
        {
            
        }
    }
}
