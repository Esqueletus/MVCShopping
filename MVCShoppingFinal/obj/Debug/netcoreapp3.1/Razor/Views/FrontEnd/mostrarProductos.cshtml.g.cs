#pragma checksum "C:\Users\Francisco Torres\source\repos\MVCShoppingFinal\MVCShoppingFinal\Views\FrontEnd\mostrarProductos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d397c185073abdca18abbddbfc79ff53ae1e16b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FrontEnd_mostrarProductos), @"mvc.1.0.view", @"/Views/FrontEnd/mostrarProductos.cshtml")]
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
#line 1 "C:\Users\Francisco Torres\source\repos\MVCShoppingFinal\MVCShoppingFinal\Views\_ViewImports.cshtml"
using MVCShoppingFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Francisco Torres\source\repos\MVCShoppingFinal\MVCShoppingFinal\Views\_ViewImports.cshtml"
using MVCShoppingFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d397c185073abdca18abbddbfc79ff53ae1e16b", @"/Views/FrontEnd/mostrarProductos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be1815c4d237c4c45041311e417a4f4026cb993b", @"/Views/_ViewImports.cshtml")]
    public class Views_FrontEnd_mostrarProductos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCShopping.Models.Producto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Francisco Torres\source\repos\MVCShoppingFinal\MVCShoppingFinal\Views\FrontEnd\mostrarProductos.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<center class=\"texto\">\n    <h1>Productos</h1>\n</center>\n\n<div>\n\n");
#nullable restore
#line 11 "C:\Users\Francisco Torres\source\repos\MVCShoppingFinal\MVCShoppingFinal\Views\FrontEnd\mostrarProductos.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\n            <div class=\"container\">\n                Nombre:\n                ");
#nullable restore
#line 16 "C:\Users\Francisco Torres\source\repos\MVCShoppingFinal\MVCShoppingFinal\Views\FrontEnd\mostrarProductos.cshtml"
           Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n                Descripcion:\n                ");
#nullable restore
#line 18 "C:\Users\Francisco Torres\source\repos\MVCShoppingFinal\MVCShoppingFinal\Views\FrontEnd\mostrarProductos.cshtml"
           Write(Html.DisplayFor(modelItem => item.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n                Precio: $\n                ");
#nullable restore
#line 20 "C:\Users\Francisco Torres\source\repos\MVCShoppingFinal\MVCShoppingFinal\Views\FrontEnd\mostrarProductos.cshtml"
           Write(Html.DisplayFor(modelItem => item.precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n");
#nullable restore
#line 23 "C:\Users\Francisco Torres\source\repos\MVCShoppingFinal\MVCShoppingFinal\Views\FrontEnd\mostrarProductos.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>





<style>

    body {
     background: rgb(0, 0, 0);
    }

   .texto{
       color:white;
   }

    .card {
        background: rgb(255, 255, 255);
        padding-left: 5px;
        margin-left: 20px;
        margin-bottom: 10px;
        transition: 0.3s;
        width: 25%;
        float: left;
        color: black;
        font-family: Arial;
    }

    .card:hover {
        box-shadow: 0 10px 20px 0 rgb(128, 128, 128);
    }

    .container {
        display: inline-block;
        width: card;
        margin: card;
        padding-left: 5px;
        color: black;
        font-family: Arial;
    }
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCShopping.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
