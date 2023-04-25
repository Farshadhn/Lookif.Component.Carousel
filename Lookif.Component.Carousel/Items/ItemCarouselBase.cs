using Lookif.Component.Slider;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Drawing;

namespace Lookif.Component.Carousel.Items;
public class ItemCarouselBase : CarouselBase
{
    [Inject] IJSRuntime _jSRuntime { get; set; }
    public ElementReference OuterElementReference { get; set; }
    public ElementReference InnerElementReference { get; set; }

    public int SliderSize { get; set; }

    private ItemSliderJSInterop _itemSliderJSInterop { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (_jSRuntime is not null)
        { 
            _itemSliderJSInterop =  new ItemSliderJSInterop(_jSRuntime, OuterElementReference, InnerElementReference);
             await _itemSliderJSInterop.Slick();
        
        }

    }
    public async void Next() { await _itemSliderJSInterop.MoveCarousel(Size.Width); }
    public async void Prev() { await _itemSliderJSInterop.MoveCarousel(-1 * Size.Width); }
 
    protected override async Task OnParametersSetAsync()
    {
        SliderSize = (Data.Items.Count + 2) * Size.Width;
    }
}
