#pragma checksum "C:\Users\kenda\source\repos\MoviesRegistration\MoviesRegistration\Views\Movie\ToCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b0d7aaea4fb661108787f8980eb6df7d9b1c13e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_ToCart), @"mvc.1.0.view", @"/Views/Movie/ToCart.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\kenda\source\repos\MoviesRegistration\MoviesRegistration\Views\_ViewImports.cshtml"
using MoviesRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kenda\source\repos\MoviesRegistration\MoviesRegistration\Views\_ViewImports.cshtml"
using MoviesRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b0d7aaea4fb661108787f8980eb6df7d9b1c13e", @"/Views/Movie/ToCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1efae7e429e5b9ec99b8c24589e5db23439821c", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_ToCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RentMovie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kenda\source\repos\MoviesRegistration\MoviesRegistration\Views\Movie\ToCart.cshtml"
  
    ViewData["Title"] = "ToCart";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ToCart</h1>\r\n\r\n<table class=\"table table-dark table-bordered\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Title</th>\r\n        <th>Genre</th>\r\n        <th>Year</th>\r\n        <th>RunTime</th>\r\n        <th>Rental Cost</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\kenda\source\repos\MoviesRegistration\MoviesRegistration\Views\Movie\ToCart.cshtml"
     foreach (RentMovie Movies in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\kenda\source\repos\MoviesRegistration\MoviesRegistration\Views\Movie\ToCart.cshtml"
           Write(Movies.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\kenda\source\repos\MoviesRegistration\MoviesRegistration\Views\Movie\ToCart.cshtml"
           Write(Movies.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\kenda\source\repos\MoviesRegistration\MoviesRegistration\Views\Movie\ToCart.cshtml"
           Write(Movies.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\kenda\source\repos\MoviesRegistration\MoviesRegistration\Views\Movie\ToCart.cshtml"
           Write(Movies.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\kenda\source\repos\MoviesRegistration\MoviesRegistration\Views\Movie\ToCart.cshtml"
           Write(Movies.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\kenda\source\repos\MoviesRegistration\MoviesRegistration\Views\Movie\ToCart.cshtml"
           Write(Movies.RentalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           \r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\kenda\source\repos\MoviesRegistration\MoviesRegistration\Views\Movie\ToCart.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<tr>\r\n    <th>Total</th>\r\n");
#nullable restore
#line 34 "C:\Users\kenda\source\repos\MoviesRegistration\MoviesRegistration\Views\Movie\ToCart.cshtml"
      double total = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\kenda\source\repos\MoviesRegistration\MoviesRegistration\Views\Movie\ToCart.cshtml"
     foreach (RentMovie Movies in Model)
    {
        total = 1 * Movies.RentalCost + total;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <td>");
#nullable restore
#line 40 "C:\Users\kenda\source\repos\MoviesRegistration\MoviesRegistration\Views\Movie\ToCart.cshtml"
   Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RentMovie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
