#pragma checksum "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d02269372462953712d71f678459450963498504"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plantilla_PlantillaSalario), @"mvc.1.0.view", @"/Views/Plantilla/PlantillaSalario.cshtml")]
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
#line 1 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\_ViewImports.cshtml"
using MvcEntityFramework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\_ViewImports.cshtml"
using MvcEntityFramework.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d02269372462953712d71f678459450963498504", @"/Views/Plantilla/PlantillaSalario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"066333be036300f973b0871514c280b65a76a868", @"/Views/_ViewImports.cshtml")]
    public class Views_Plantilla_PlantillaSalario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResumenPlantilla>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
  
    List<Plantilla> plantilla = ViewData["plantilla"] as List<Plantilla>;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Plantilla salario</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d02269372462953712d71f6784594509634985043982", async() => {
                WriteLiteral("\r\n    <label>Salario</label>\r\n    <input type=\"text\" name=\"salario\" class=\"form-control\" />\r\n    <button type=\"submit\" class=\"btn btn-info\">Filtrar</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Personas: ");
#nullable restore
#line 13 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
            Write(Model.Personas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Máximo salario: ");
#nullable restore
#line 14 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
                  Write(Model.MaximoSalario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Mínimo salario: ");
#nullable restore
#line 15 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
                  Write(Model.MinimoSalario);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    <table class=""table table-dark"">
        <thead>
            <tr>
                <th>IdEmpleado</th>
                <th>Apellido</th>
                <th>Función</th>
                <th>Salario</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 26 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
             foreach (Plantilla pla in Model.Plantilla)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
                   Write(pla.IdEmpleado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
                   Write(pla.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
                   Write(pla.Funcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
                   Write(pla.Salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 37 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-info"">
        <thead>
            <tr>
                <th>IdEmpleado</th>
                <th>Apellido</th>
                <th>Función</th>
                <th>Salario</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 50 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
             foreach (Plantilla plan in plantilla)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 53 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
                   Write(plan.IdEmpleado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 54 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
                   Write(plan.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 55 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
                   Write(plan.Funcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 56 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
                   Write(plan.Salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 58 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 61 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Plantilla\PlantillaSalario.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResumenPlantilla> Html { get; private set; }
    }
}
#pragma warning restore 1591
