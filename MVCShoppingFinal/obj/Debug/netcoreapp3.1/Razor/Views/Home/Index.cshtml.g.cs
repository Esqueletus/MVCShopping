#pragma checksum "C:\Users\Francisco Torres\source\repos\MVCShoppingFinal\MVCShoppingFinal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "936cdb065ae3f984a0c0c6616c711a1bceb7c332"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936cdb065ae3f984a0c0c6616c711a1bceb7c332", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be1815c4d237c4c45041311e417a4f4026cb993b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Francisco Torres\source\repos\MVCShoppingFinal\MVCShoppingFinal\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">ABM</h1>
    <p>Mirá el ABM de <b>productos</b> <a href=""../Productoes/Index"">cliqueando acá</a>.</p>
    <p>Mirá el ABM de <b>negocios</b> <a href=""../Negocios/Index"">cliqueando acá</a>.</p>
    <p>Mirá como es el <b>frontend</b> <a href=""../FrontEnd/Index"">cliqueando acá</a></p>
    <p>Mirá como es el <b>seleccionar producto por color</b> <a href=""../Home/SeleccionoColor"">cliqueando acá</a></p>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
