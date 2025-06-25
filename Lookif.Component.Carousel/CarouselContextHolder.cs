namespace Lookif.Component.Carousel;

public class CarouselContextHolder
{
    public string Title { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public List<CarouselItemContextHolder> Items{ get; set; }

}
public class CarouselItemContextHolder
{

    public string ImageThumbnail { get; set; }
    public string Image { get; set; }
    public string Link { get; set; }
    public string Title { get; set; }
    public string Definition { get; set; }
    public string Id { get; set; }
}