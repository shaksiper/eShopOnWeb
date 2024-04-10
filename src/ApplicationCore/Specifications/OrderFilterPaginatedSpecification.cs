using System;
using Ardalis.Specification;
using Microsoft.eShopWeb.ApplicationCore.Entities;
using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;

namespace Microsoft.eShopWeb.ApplicationCore.Specifications;

public class OrderFilterPaginatedSpecification : Specification<Order>
{
    public OrderFilterPaginatedSpecification(
        int skip,
        int take,
        DateTimeOffset? orderDate,
        string? BuyerId
    )
        : base()
    {
        if (take == 0)
        {
            take = int.MaxValue;
        }
        Query
            .Where(
                i =>
                    (!orderDate.HasValue || i.OrderDate == orderDate)
                    && (!String.IsNullOrEmpty(BuyerId) || i.BuyerId == BuyerId)
            )
            .Skip(skip)
            .Take(take);
    }
}
