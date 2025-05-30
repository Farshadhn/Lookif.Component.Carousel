using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Lookif.Component.Slider
{
    // This class provides an example of how JavaScript functionality can be wrapped
    // in a .NET class for easy consumption. The associated JavaScript module is
    // loaded on demand when first needed.
    //
    // This class can be registered as scoped DI service and then injected into Blazor
    // components for use.

    public class ItemSliderJSInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public ItemSliderJSInterop(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./_content/Lookif.Component.Carousel/ItemSlider.js").AsTask());
        }

        public async ValueTask<string> Slick(ElementReference outer, ElementReference inner)
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<string>("Slick", outer, inner);
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}