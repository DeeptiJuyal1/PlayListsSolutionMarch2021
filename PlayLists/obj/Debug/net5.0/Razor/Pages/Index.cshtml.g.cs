#pragma checksum "C:\dev\PlayListsSolution\PlayLists\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f43d33db1c1f1a8e6b4e5cc79610063eab662e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PlayLists.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace PlayLists.Pages
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
#line 1 "C:\dev\PlayListsSolution\PlayLists\Pages\_ViewImports.cshtml"
using PlayLists;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f43d33db1c1f1a8e6b4e5cc79610063eab662e7", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6559efcc90bbdeebf8ada8ed4c024846f11654a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\dev\PlayListsSolution\PlayLists\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Top Songs This Week:</h1>\r\n");
#nullable restore
#line 8 "C:\dev\PlayListsSolution\PlayLists\Pages\Index.cshtml"
 foreach (var song in Model.Songs)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-info\">\r\n    <p>");
#nullable restore
#line 11 "C:\dev\PlayListsSolution\PlayLists\Pages\Index.cshtml"
  Write(song.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" by ");
#nullable restore
#line 11 "C:\dev\PlayListsSolution\PlayLists\Pages\Index.cshtml"
                 Write(song.Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Played ");
#nullable restore
#line 11 "C:\dev\PlayListsSolution\PlayLists\Pages\Index.cshtml"
                                     Write(song.NumberOfPlays);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Times.</p>   \r\n</div>\r\n");
#nullable restore
#line 13 "C:\dev\PlayListsSolution\PlayLists\Pages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
