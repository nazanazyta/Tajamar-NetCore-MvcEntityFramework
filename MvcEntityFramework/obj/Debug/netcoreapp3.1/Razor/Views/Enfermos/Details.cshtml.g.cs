#pragma checksum "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "498619d0b1ba9a19df476dd138eb23a421232f91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enfermos_Details), @"mvc.1.0.view", @"/Views/Enfermos/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"498619d0b1ba9a19df476dd138eb23a421232f91", @"/Views/Enfermos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"066333be036300f973b0871514c280b65a76a868", @"/Views/_ViewImports.cshtml")]
    public class Views_Enfermos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Enfermo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Enfermos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalles Enfermo</h1>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "498619d0b1ba9a19df476dd138eb23a421232f914173", async() => {
                WriteLiteral("Volver a Index");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br /><br />\r\n<ul class=\"list-group\">\r\n    <li class=\"list-group-item active\">");
#nullable restore
#line 7 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\Details.cshtml"
                                  Write(Model.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li class=\"list-group-item\">Dirección: ");
#nullable restore
#line 8 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\Details.cshtml"
                                      Write(Model.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li class=\"list-group-item\">Fecha de nacimiento: ");
#nullable restore
#line 9 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\Details.cshtml"
                                                Write(Model.FechaNacimiento.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li class=\"list-group-item\">Sexo: ");
#nullable restore
#line 10 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\Details.cshtml"
                                 Write(Model.Sexo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li class=\"list-group-item\">Nº SS: ");
#nullable restore
#line 11 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\Details.cshtml"
                                  Write(Model.SeguridadSocial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Enfermo> Html { get; private set; }
    }
}
#pragma warning restore 1591
