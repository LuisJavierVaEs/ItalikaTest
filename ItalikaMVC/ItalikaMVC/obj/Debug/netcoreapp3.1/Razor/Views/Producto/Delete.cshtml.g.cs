#pragma checksum "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d81f08ff6e6972ee75c31b209c8e0533fe2c7bf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Delete), @"mvc.1.0.view", @"/Views/Producto/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d81f08ff6e6972ee75c31b209c8e0533fe2c7bf5", @"/Views/Producto/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"511c91639d8427aa0c2031870222f5e0e954b1f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<producto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n<div class=\"container\">\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 12 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Delete.cshtml"
       Write(Html.DisplayNameFor(model => Model.Sku));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 16 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Delete.cshtml"
       Write(Html.DisplayFor(model => Model.Sku));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 20 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Fert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 24 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 28 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 32 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdTipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 36 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Delete.cshtml"
       Write(ViewBag.IdTipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 40 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumeroSerie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 44 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumeroSerie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 48 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 52 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n");
#nullable restore
#line 55 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Delete.cshtml"
     using (Html.BeginForm())
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-outline-danger\" /> |\r\n            ");
#nullable restore
#line 60 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Delete.cshtml"
       Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 62 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
