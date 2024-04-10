using System;
using Ardalis.Specification;
using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;

namespace Microsoft.eShopWeb.ApplicationCore.Specifications;

public class OrderFilterSpecification : Specification<Order>
{
    public OrderFilterSpecification(string? userId, DateTimeOffset? orderDate)
    {
        Query.Where(
            i =>
                (!String.IsNullOrEmpty(userId) || i.BuyerId == userId)
                && (!orderDate.HasValue || i.OrderDate == orderDate)
        );
    }
}
