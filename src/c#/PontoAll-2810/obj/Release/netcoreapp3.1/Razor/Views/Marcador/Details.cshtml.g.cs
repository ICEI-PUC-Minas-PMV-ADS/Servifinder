#pragma checksum "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\Marcador\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e654558df448bc442ff1b411247eb592a5eacff4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Marcador_Details), @"mvc.1.0.view", @"/Views/Marcador/Details.cshtml")]
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
#line 1 "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\_ViewImports.cshtml"
using PontoAll_2810;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\_ViewImports.cshtml"
using PontoAll_2810.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e654558df448bc442ff1b411247eb592a5eacff4", @"/Views/Marcador/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d637451a86298b692301512b56189998c7f7ba5", @"/Views/_ViewImports.cshtml")]
    public class Views_Marcador_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoAll_2810.Models.RegistroPonto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\Marcador\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhes da Marcação de ");
#nullable restore
#line 7 "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\Marcador\Details.cshtml"
                       Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h1>\r\n\r\n<div>\r\n    <h4>Realizada em: ");
#nullable restore
#line 10 "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\Marcador\Details.cshtml"
                 Write(Html.DisplayFor(model => model.DataRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral(" as  ");
#nullable restore
#line 10 "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\Marcador\Details.cshtml"
                                                                   Write(Html.DisplayFor(model => model.HoraRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral(". </h4>\r\n    <h4>Que gerou ");
#nullable restore
#line 11 "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\Marcador\Details.cshtml"
             Write(Html.DisplayFor(model => model.SomaHora));

#line default
#line hidden
#nullable disable
            WriteLiteral(" horas no Banco de Horas do Colaborador. </h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-4\">\r\n            Data\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 18 "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\Marcador\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\"\">\r\n           Hora\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 24 "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\Marcador\Details.cshtml"
       Write(Html.DisplayFor(model => model.HoraRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\"\">\r\n            Localização\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 30 "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\Marcador\Details.cshtml"
       Write(Html.DisplayFor(model => model.LocalizacaoRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\"\">\r\n            Perfil\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 36 "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\Marcador\Details.cshtml"
       Write(Html.DisplayFor(model => model.Perfil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\" \">\r\n            Registrando no Banco\r\n        </dt>\r\n        <dd class=\"col-sm-6\">\r\n            ");
#nullable restore
#line 42 "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\Marcador\Details.cshtml"
       Write(Html.DisplayFor(model => model.SomaHora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <!--a asp-action=\"Edit\" asp-route-id=\"");
#nullable restore
#line 47 "C:\Users\ROGER\Documents\GitHub\pmv-ads-2022-2-e2-proj-int-t7-pontoall\src\c#\PontoAll-2810\Views\Marcador\Details.cshtml"
                                     Write(Model.IdRegistroPonto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</a--> |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e654558df448bc442ff1b411247eb592a5eacff48212", async() => {
                WriteLiteral("Voltar para lista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PontoAll_2810.Models.RegistroPonto> Html { get; private set; }
    }
}
#pragma warning restore 1591