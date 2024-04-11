using System;
using System.Collections.Generic;

namespace BlazorShared.Models;

/// <summary>
/// Orders model
/// </summary>
public class Orders
{
    public int id { get; set; }
    public string buyerId { get; set; }

    public DateTime orderDate { get; set; }
    public IReadOnlyCollection<OrderItem> orderItems { get; set; }
    public decimal Total { get; set; }
}
