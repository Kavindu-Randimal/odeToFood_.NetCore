#pragma checksum "/Users/RandimalGeeganage/Documents/dotNet/OdeToFood/OdeToFood/Pages/Restaurents/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd2b0658aaadb2e6e5504d438cb607a9064dada3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Restaurents.Pages_Restaurents_List), @"mvc.1.0.razor-page", @"/Pages/Restaurents/List.cshtml")]
namespace OdeToFood.Pages.Restaurents
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
#line 1 "/Users/RandimalGeeganage/Documents/dotNet/OdeToFood/OdeToFood/Pages/_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd2b0658aaadb2e6e5504d438cb607a9064dada3", @"/Pages/Restaurents/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca69e3299223c020a4a1f2d7b35d44e62ba96fc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurents_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Restaurents</h1>\n\n<table class=\"table\">\n\n");
#nullable restore
#line 10 "/Users/RandimalGeeganage/Documents/dotNet/OdeToFood/OdeToFood/Pages/Restaurents/List.cshtml"
     foreach (var restaurent in Model.Restaurents)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 13 "/Users/RandimalGeeganage/Documents/dotNet/OdeToFood/OdeToFood/Pages/Restaurents/List.cshtml"
           Write(restaurent.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 14 "/Users/RandimalGeeganage/Documents/dotNet/OdeToFood/OdeToFood/Pages/Restaurents/List.cshtml"
           Write(restaurent.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 15 "/Users/RandimalGeeganage/Documents/dotNet/OdeToFood/OdeToFood/Pages/Restaurents/List.cshtml"
           Write(restaurent.Cuisine);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n        </tr>\n");
#nullable restore
#line 17 "/Users/RandimalGeeganage/Documents/dotNet/OdeToFood/OdeToFood/Pages/Restaurents/List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n");
#nullable restore
#line 19 "/Users/RandimalGeeganage/Documents/dotNet/OdeToFood/OdeToFood/Pages/Restaurents/List.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Pages.Restaurents.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurents.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurents.ListModel>)PageContext?.ViewData;
        public OdeToFood.Pages.Restaurents.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
