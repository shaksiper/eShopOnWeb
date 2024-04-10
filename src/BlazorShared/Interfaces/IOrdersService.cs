using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShared.Models;

namespace BlazorShared.Interfaces;

public interface IOrdersService
{
    Task<Orders> Edit(Orders orders);
    Task<Orders> GetById(int id);
    Task<List<Orders>> ListPaged(int pageSize);
    Task<List<Orders>> List();
}
