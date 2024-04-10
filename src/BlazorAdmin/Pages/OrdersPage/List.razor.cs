﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorAdmin.Helpers;
using BlazorShared.Interfaces;
using BlazorShared.Models;

namespace BlazorAdmin.Pages.OrdersPage;

public partial class List : BlazorComponent
{
    [Microsoft.AspNetCore.Components.Inject]
    public IOrdersService OrdersService { get; set; }

    private List<Orders> orders = new List<Orders>();

    private Edit EditComponent { get; set; }
    private Details DetailsComponent { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            orders = await OrdersService.List();

            CallRequestRefresh();
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    private async void DetailsClick(int id)
    {
        await DetailsComponent.Open(id);
    }

    private async Task EditClick(int id)
    {
        await EditComponent.Open(id);
    }

    private async Task ReloadCatalogItems()
    {
        orders = await OrdersService.List();
        StateHasChanged();
    }
}
