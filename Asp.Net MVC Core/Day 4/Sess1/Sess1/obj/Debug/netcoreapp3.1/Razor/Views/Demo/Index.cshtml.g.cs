#pragma checksum "D:\Taught\Asp.Net MVC Core\Day 4\Sess1\Sess1\Views\Demo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04fe523d64c134640f8d37d72df35ec5f68ac270"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_Index), @"mvc.1.0.view", @"/Views/Demo/Index.cshtml")]
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
#line 1 "D:\Taught\Asp.Net MVC Core\Day 4\Sess1\Sess1\Views\_ViewImports.cshtml"
using Sess1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Taught\Asp.Net MVC Core\Day 4\Sess1\Sess1\Views\_ViewImports.cshtml"
using Sess1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04fe523d64c134640f8d37d72df35ec5f68ac270", @"/Views/Demo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3c56af6e142728fa6aecc57de3caac60facf31a", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>\r\n    Welcome to the Demo Controller\r\n</p>\r\n<p>\r\n    Below is a list of our Locations\r\n</p>\r\n\r\n");
#nullable restore
#line 8 "D:\Taught\Asp.Net MVC Core\Day 4\Sess1\Sess1\Views\Demo\Index.cshtml"
Write(await Html.PartialAsync("_Locations"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n<p>\r\n    As you can see from the list, we have many locations\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
