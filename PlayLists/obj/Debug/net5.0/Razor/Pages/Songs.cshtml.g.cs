#pragma checksum "C:\dev\PlayListsSolution\PlayLists\Pages\Songs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edf26084ee81944ab8d3ebb1e88a6c8a1f589f89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PlayLists.Pages.Pages_Songs), @"mvc.1.0.razor-page", @"/Pages/Songs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf26084ee81944ab8d3ebb1e88a6c8a1f589f89", @"/Pages/Songs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6559efcc90bbdeebf8ada8ed4c024846f11654a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Songs : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Your Song List</h2>\r\n");
#nullable restore
#line 7 "C:\dev\PlayListsSolution\PlayLists\Pages\Songs.cshtml"
 foreach(var song in Model.Songs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-info\">\r\n                    <p>Song ");
#nullable restore
#line 10 "C:\dev\PlayListsSolution\PlayLists\Pages\Songs.cshtml"
                       Write(song.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" by ");
#nullable restore
#line 10 "C:\dev\PlayListsSolution\PlayLists\Pages\Songs.cshtml"
                                      Write(song.Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </div>\r\n");
#nullable restore
#line 12 "C:\dev\PlayListsSolution\PlayLists\Pages\Songs.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlayLists.Pages.SongsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PlayLists.Pages.SongsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PlayLists.Pages.SongsModel>)PageContext?.ViewData;
        public PlayLists.Pages.SongsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591