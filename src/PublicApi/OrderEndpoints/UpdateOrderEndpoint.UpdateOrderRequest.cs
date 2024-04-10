using System.ComponentModel.DataAnnotations;
using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;

namespace Microsoft.eShopWeb.PublicApi.OrderEndpoints;

public class UpdateOrderRequest : BaseRequest
{
    [Range(1, 10000)]
    public int Id { get; set; }
    [Range(1, 10000)]
    public int CatalogBrandId { get; set; }
    [Range(1, 10000)]
    public int CatalogTypeId { get; set; }
    /*[Required]*/
    public Address ShipToAddress { get; set; }
}
