#pragma checksum "D:\PROGRAMACION 1\practica3\Views\Producto\Productos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94721a61f15b2a00455b8e071c98057a762ad943"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Productos), @"mvc.1.0.view", @"/Views/Producto/Productos.cshtml")]
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
#line 1 "D:\PROGRAMACION 1\practica3\Views\_ViewImports.cshtml"
using practica3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROGRAMACION 1\practica3\Views\_ViewImports.cshtml"
using practica3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94721a61f15b2a00455b8e071c98057a762ad943", @"/Views/Producto/Productos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1be3d75180ec2d7aa3cc0073d1504c3eeaa9d28", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Productos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Producto/borrarProducto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    
    <h1> Lista de Peticiones</h1>


    <table  class=""table border table-striped"">
        <tr>
            <th>Id</th>
            <th>Nombre</th>
            <th>FotoProducto</th>
            <th>Descripcion</th>
            <th>Precio</th>
            <th>NroCelular</th>
            <th>Lugar de compra</th>
            <th>Nombre Comprador</th>
            <th>Categoria</th>
        </tr>
");
#nullable restore
#line 18 "D:\PROGRAMACION 1\practica3\Views\Producto\Productos.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "D:\PROGRAMACION 1\practica3\Views\Producto\Productos.cshtml"
               Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "D:\PROGRAMACION 1\practica3\Views\Producto\Productos.cshtml"
               Write(item.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 603, "\"", 628, 1);
#nullable restore
#line 23 "D:\PROGRAMACION 1\practica3\Views\Producto\Productos.cshtml"
WriteAttributeValue("", 610, item.fotoproducto, 610, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">url de foto </a></td>\r\n                <td>");
#nullable restore
#line 24 "D:\PROGRAMACION 1\practica3\Views\Producto\Productos.cshtml"
               Write(item.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "D:\PROGRAMACION 1\practica3\Views\Producto\Productos.cshtml"
               Write(item.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\PROGRAMACION 1\practica3\Views\Producto\Productos.cshtml"
               Write(item.nrocelular);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "D:\PROGRAMACION 1\practica3\Views\Producto\Productos.cshtml"
               Write(item.lugarcompra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\PROGRAMACION 1\practica3\Views\Producto\Productos.cshtml"
               Write(item.nombrecomprador);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "D:\PROGRAMACION 1\practica3\Views\Producto\Productos.cshtml"
               Write(item.Categoria.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                 \r\n            <td>\r\n                \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94721a61f15b2a00455b8e071c98057a762ad9437244", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1116, "\"", 1132, 1);
#nullable restore
#line 34 "D:\PROGRAMACION 1\practica3\Views\Producto\Productos.cshtml"
WriteAttributeValue("", 1124, item.id, 1124, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    <button class=\"btn btn-danger\"> borrar</button>\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                \r\n            </td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "D:\PROGRAMACION 1\practica3\Views\Producto\Productos.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\PROGRAMACION 1\practica3\Views\Producto\Productos.cshtml"
         if(Model.Count ==0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"7\" class=\"text-center\">No se encontraron Peticiones</td>\r\n            </tr>\r\n");
#nullable restore
#line 47 "D:\PROGRAMACION 1\practica3\Views\Producto\Productos.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    <a href=\"/Producto/NuevoProducto \" class=\"btn btn-primary\">Añadir Producto</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591