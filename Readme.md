# Introduction

Lookif.Carousel is a library that enables Blazor developers to easily add carousels to their web applications without the need to import any external JavaScript or CSS files. With Lookif.Carousel, developers can add responsive carousels with swipe gestures and customizable settings.

# Installation
Lookif.Carousel can be installed using NuGet. You can install it using the NuGet Package Manager in Visual Studio or by running the following command in the Package Manager Console:
  
	Install-Package Lookif.Component.Carousel
	
	
	
# Getting Started
	
Once you have installed the Lookif.Carousel package, you can add the carousel component to your Blazor pages. Here is an example of how to use the carousel component:



	<LFCarousel 
		Data="@items"
		CarouselType=CarouselType.Item
		Size=ImageSize>
	</LFCarousel>



In this example, we are binding the carousel to a collection of items (@items) and setting various properties, such as the type of carousel, the width and height of each item (Size).


 
# Properties
The following properties are available for the Carousel component:



Property | Definition
------------- | -------------
Items | The collection of items to display in the carousel. It is type of CarouselContextHolder which Contains Title,Image(path),and Listof CarouselItemContextHolder which holds your items(Properties are shown later).
CarouselType | Type of Carousel. we have 2 types right now. "Header,Item"
Size | Size of each items. It is under System.Drawing library that holds Witdh and Height.


CarouselItemContextHolder Contains:

    public string ImageThumbnail { get; set; }
    public string Image { get; set; }
    public string Link { get; set; }
    public string Title { get; set; }
    public string Definition{ get; set; }




# Contributing

Contributions to Lookif.Carousel are always welcome! If you have any bug reports, feature requests, or pull requests, please feel free to open an issue or a pull request on the GitHub repository: https://github.com/Farshadhn/Lookif.Component.Carousel.

# License

Lookif.Carousel is licensed under the GNU license. See the LICENSE file for more information.