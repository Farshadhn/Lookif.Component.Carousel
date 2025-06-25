using Microsoft.AspNetCore.Components;
using System;
using System.Drawing;
using static System.Net.WebRequestMethods;

namespace Lookif.Component.Carousel;
public enum CarouselType
{
    Header,Item
}
public class CarouselBase : ComponentBase
{
    [Inject] NavigationManager Navigation { get; set; }
    [Parameter] public CarouselType CarouselType { get; set; }
    [Parameter] public CarouselContextHolder Data { get; set; }
    [Parameter] public Size Size { get; set; } = new Size(200, 290);
    [Parameter] public string NotFoundImage { get; set; } 

   
    protected override Task OnParametersSetAsync()
    {
        if (Data is { Items: { Count: > 0 } } items)
            Selected = Data.Items.FirstOrDefault();

        return base.OnParametersSetAsync();
    }

    public void ChangeImage(CarouselItemContextHolder carouselItemContextHolder)
    {
        StateHasChanged();

        Selected = carouselItemContextHolder;
        StateHasChanged();
    }
    public void NavigateTo(string path)
    {
        Navigation.NavigateTo(path);
    }


    public CarouselItemContextHolder Selected { get; set; } = new();

}
