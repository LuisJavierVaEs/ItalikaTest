#pragma checksum "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4f9d914467c86802658d57dece3fa21a7e8edb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Details), @"mvc.1.0.view", @"/Views/Producto/Details.cshtml")]
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
#line 1 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\_ViewImports.cshtml"
using ItalikaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\_ViewImports.cshtml"
using ItalikaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f9d914467c86802658d57dece3fa21a7e8edb6", @"/Views/Producto/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"511c91639d8427aa0c2031870222f5e0e954b1f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<producto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-2 text-right\">\r\n            ");
#nullable restore
#line 11 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Details.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-2 text-left\">\r\n            ");
#nullable restore
#line 14 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Details.cshtml"
       Write(Html.DisplayFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row \">\r\n        <div class=\"col-sm-2 text-right\">\r\n            ");
#nullable restore
#line 19 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Details.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Sku));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-2 text-left\">\r\n            <Label >\r\n               ");
#nullable restore
#line 23 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Details.cshtml"
          Write(Html.DisplayFor(Model => Model.Sku));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </Label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row \">\r\n        <div class=\"col-sm-2 text-right\">\r\n            ");
#nullable restore
#line 29 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Details.cshtml"
       Write(Html.DisplayNameFor(Model => Model.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-2 text-left\">\r\n            <Label ID=\"lblSApellido\">\r\n            ");
#nullable restore
#line 33 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Details.cshtml"
       Write(Html.DisplayFor(Model => Model.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </Label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row \">\r\n        <div class=\"col-sm-2 text-right\">\r\n            Tipo\r\n        </div>\r\n        <div class=\"col-sm-2 text-left\">\r\n            <Label >\r\n            ");
#nullable restore
#line 43 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Details.cshtml"
       Write(ViewBag.IdTipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </Label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row \">\r\n        <div class=\"col-sm-2 text-right\">\r\n            ");
#nullable restore
#line 49 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Details.cshtml"
       Write(Html.DisplayNameFor(Model => Model.NumeroSerie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-2 text-left\">\r\n            <Label >\r\n            ");
#nullable restore
#line 53 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Details.cshtml"
       Write(Html.DisplayFor(Model => Model.NumeroSerie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </Label>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row \">\r\n        <div class=\"col-md-2\">\r\n            <p></p>\r\n            ");
#nullable restore
#line 61 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Details.cshtml"
       Write(Html.ActionLink("Regresar a la lista", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<producto> Html { get; private set; }
    }
}
#pragma warning restore 1591
