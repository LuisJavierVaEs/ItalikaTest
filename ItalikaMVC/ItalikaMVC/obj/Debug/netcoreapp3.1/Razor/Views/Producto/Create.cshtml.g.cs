#pragma checksum "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f4c2b9f210ae7931da2114c3b68e89628c60a07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Create), @"mvc.1.0.view", @"/Views/Producto/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f4c2b9f210ae7931da2114c3b68e89628c60a07", @"/Views/Producto/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"511c91639d8427aa0c2031870222f5e0e954b1f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<producto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<SelectListItem> IdTipo = (List<SelectListItem>)ViewBag.IdTipo;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n");
#nullable restore
#line 9 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <h4>Nuevo Producto</h4>\r\n    <hr />\r\n    ");
#nullable restore
#line 16 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 18 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
   Write(Html.LabelFor(model => model.Sku, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
       Write(Html.EditorFor(model => model.Sku, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 21 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Sku, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 26 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
   Write(Html.LabelFor(model => model.Modelo, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
       Write(Html.EditorFor(model => model.Modelo, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 29 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Modelo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n            ");
#nullable restore
#line 34 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
       Write(Html.LabelFor(model => model.IdTipo, "IdTipo", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 36 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
           Write(Html.DropDownList("IdTipo", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 37 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.IdTipo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 42 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
       Write(Html.LabelFor(model => model.NumeroSerie, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 44 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
           Write(Html.EditorFor(model => model.NumeroSerie, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 45 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.NumeroSerie, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 50 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
       Write(Html.LabelFor(model => model.Fecha, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 52 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
           Write(Html.EditorFor(model => model.Fecha, new { htmlAttributes = new { @class = "form-control", @type="date"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 53 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Fecha, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Create\" class=\"btn btn-primary btn-sm\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 63 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 66 "C:\Users\adriana\source\repos\Italika\ItalikaMVC\ItalikaMVC\Views\Producto\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
