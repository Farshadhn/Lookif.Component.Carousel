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



    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (_jSRuntime is not null)
         await new ItemSliderJSInterop(_jSRuntime).Slick(OuterElementReference,InnerElementReference);


        

    }
    protected override async Task OnParametersSetAsync()
    {
        SliderSize = (Data.Items.Count + 2) * Size.Width;
    }
}
