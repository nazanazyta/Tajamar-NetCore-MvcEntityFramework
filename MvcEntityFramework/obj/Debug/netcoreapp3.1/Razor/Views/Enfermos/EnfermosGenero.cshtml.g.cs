#pragma checksum "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\EnfermosGenero.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39b8794ee6002a94572e2d33baf0190a3683d958"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enfermos_EnfermosGenero), @"mvc.1.0.view", @"/Views/Enfermos/EnfermosGenero.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39b8794ee6002a94572e2d33baf0190a3683d958", @"/Views/Enfermos/EnfermosGenero.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"066333be036300f973b0871514c280b65a76a868", @"/Views/_ViewImports.cshtml")]
    public class Views_Enfermos_EnfermosGenero : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Enfermo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Enfermos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnfermosGenero", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
  
    List<Genero> generos = ViewData["GENEROS"] as List<Genero>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Buscador enfermos genero</h1>\r\n\r\n<ul class=\"list-group\">\r\n");
#nullable restore
#line 10 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
     foreach (Genero gen in generos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39b8794ee6002a94572e2d33baf0190a3683d9584526", async() => {
#nullable restore
#line 15 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
                                        Write(gen.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-genero", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
                     WriteLiteral(gen.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["genero"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-genero", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["genero"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 17 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<hr />\r\n");
#nullable restore
#line 20 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"list-group\">\r\n");
#nullable restore
#line 23 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
         foreach (Enfermo enf in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item active\">\r\n                ");
#nullable restore
#line 26 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
           Write(enf.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 28 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 30 "C:\Users\Nazaret\Repos\Tajamar-NetCore-MvcEntityFramework\MvcEntityFramework\Views\Enfermos\EnfermosGenero.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Enfermo>> Html { get; private set; }
    }
}
#pragma warning restore 1591