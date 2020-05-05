
using AutoMapper;
using ShoppingApi.Data;
using ShoppingApi.Migrations;
using ShoppingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

            var order = Mapper.Map<OrderForCurbside>(orderToPlace);
            DataContext.CurbsideOrders.Add(order);
            await DataContext.SaveChangesAsync();
            var response = Mapper.Map<CurbsideOrder>(order);
            response.Items = order.Items.Split(",").ToList();
            // Process each of the items.
            foreach(var item in response.Items)
            {
                Thread.Sleep(1000);
            }
            return response;

        }
    }
}
