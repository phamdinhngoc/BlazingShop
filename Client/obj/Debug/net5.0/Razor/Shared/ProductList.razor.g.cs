#pragma checksum "C:\Users\IT4\source\repos\BlazingShop\Client\Shared\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73a7d55b3df4811e4efc118f2f5020279c16e152"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingShop.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\IT4\source\repos\BlazingShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\IT4\source\repos\BlazingShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\IT4\source\repos\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\IT4\source\repos\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\IT4\source\repos\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\IT4\source\repos\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\IT4\source\repos\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\IT4\source\repos\BlazingShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\IT4\source\repos\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\IT4\source\repos\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\IT4\source\repos\BlazingShop\Client\_Imports.razor"
using BlazingShop.Shared;

#line default
#line hidden
#nullable disable
    public partial class ProductList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "list-unstyled");
#nullable restore
#line 2 "C:\Users\IT4\source\repos\BlazingShop\Client\Shared\ProductList.razor"
     foreach(var product in products)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.AddAttribute(3, "class", "media my-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "media-img-wrapper mr-2");
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "href", "/product/" + (
#nullable restore
#line 6 "C:\Users\IT4\source\repos\BlazingShop\Client\Shared\ProductList.razor"
                                   product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "class", "media-img");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 7 "C:\Users\IT4\source\repos\BlazingShop\Client\Shared\ProductList.razor"
                                                 product.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "alt", 
#nullable restore
#line 7 "C:\Users\IT4\source\repos\BlazingShop\Client\Shared\ProductList.razor"
                                                                      product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "media-body");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", "/product/" + (
#nullable restore
#line 12 "C:\Users\IT4\source\repos\BlazingShop\Client\Shared\ProductList.razor"
                                   product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(17, "h4");
            __builder.AddAttribute(18, "class", "mb-0");
#nullable restore
#line 13 "C:\Users\IT4\source\repos\BlazingShop\Client\Shared\ProductList.razor"
__builder.AddContent(19, product.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "p");
#nullable restore
#line 16 "C:\Users\IT4\source\repos\BlazingShop\Client\Shared\ProductList.razor"
__builder.AddContent(22, product.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\IT4\source\repos\BlazingShop\Client\Shared\ProductList.razor"
             if (product.OriginalPrice > product.Price)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "h6");
            __builder.AddAttribute(24, "class", "text-muted original-price");
            __builder.AddContent(25, "$");
#nullable restore
#line 19 "C:\Users\IT4\source\repos\BlazingShop\Client\Shared\ProductList.razor"
__builder.AddContent(26, product.OriginalPrice);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\IT4\source\repos\BlazingShop\Client\Shared\ProductList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "h5");
            __builder.AddAttribute(28, "class", "price");
            __builder.AddMarkupContent(29, "\r\n                $");
#nullable restore
#line 22 "C:\Users\IT4\source\repos\BlazingShop\Client\Shared\ProductList.razor"
__builder.AddContent(30, product.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\IT4\source\repos\BlazingShop\Client\Shared\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\IT4\source\repos\BlazingShop\Client\Shared\ProductList.razor"
       
    List<Product> products = new List<Product>
    {
        new Product {
            Id=1,
            CategoryId=1,
            Title="The Hitchiker's Guide to the Galaxy",
            Description = "The Hitchhiker's Guide to the Galaxy (sometimes referred to as HG2G, HHGTTG, H2G2, or tHGttG) is a comedy science fiction series created by Douglas Adams.",
            Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
            Price=9.99m,
            OriginalPrice=19.99m,
        },
        new Product
        {
            Id=2,
            CategoryId =3,
            Title = "Half-Life 2",
            Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
            Price=8.19m,
            OriginalPrice=29.99m,
        },
    };



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
