using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShared.Models;

namespace BlazorShared.Interfaces;

public interface IOrderItemService
{
    Task<Order> Edit(Order orders);
    Task<Order> GetById(int id);
    Task<List<Order>> ListPaged(int pageSize);
    Task<List<Order>> List();
}
