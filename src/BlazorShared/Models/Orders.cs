using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorShared.Models;

/// <summary>
/// OrderItem model for items in orders
/// </summary>
public class Orders
{
    public int id { get; set; }
    public string buyerId { get; set; }

    public DateTime orderDate { get; set; }

    /*public string ShipToAddress_Street { get; set; }*/
    /*public string ShipToAddress_City { get; set; }*/
    /*public string ShipToAddress_State { get; set; }*/
    /*public string ShipToAddress_Country { get; set; }*/
    /*public string ShipToAddress_ZipCode { get; set; }*/
    /**/
    /*public string ItemOrdered_ProductName { get; set; }*/
    /**/
    /*public string ItemOrdered_PictureUri { get; set; }*/

    // decimal(18,2)
    /*[RegularExpression(*/
    /*    @"^\d+(\.\d{0,2})*$",*/
    /*    ErrorMessage = "The field Price must be a positive number with maximum two decimals."*/
    /*)]*/
    /*[Range(0.01, 1000)]*/
    /*[DataType(DataType.Currency)]*/
    /*public decimal UnitPrice { get; set; }*/
    /**/
    /*public int Units { get; set; }*/
    /**/
    /*public int OrderId { get; set; }*/
}
