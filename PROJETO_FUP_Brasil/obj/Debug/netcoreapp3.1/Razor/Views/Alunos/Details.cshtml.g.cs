#pragma checksum "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfe2f4713526abee3f049a3c226fc8475a360638"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alunos_Details), @"mvc.1.0.view", @"/Views/Alunos/Details.cshtml")]
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
#line 1 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\_ViewImports.cshtml"
using PROJETO_FUP_Brasil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\_ViewImports.cshtml"
using PROJETO_FUP_Brasil.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfe2f4713526abee3f049a3c226fc8475a360638", @"/Views/Alunos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b65c0ab00a7977709ba7619ebefffc8dbb2c1e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Alunos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Remake_FUP.Models.Aluno>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("position-absolute mt-5 pt-3 mx-5 ficha "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/ficha.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"py-5\"></div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cfe2f4713526abee3f049a3c226fc8475a3606384642", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"container back-detalhes pt-5 pb-3 \">\r\n    <div class=\"row  p-6\">\r\n        <div class=\"pb-5 text-center\">\r\n\r\n        </div>\r\n        <div class=\"col-md-12 text-left\">\r\n            <h2 class=\"text-uppercase\">NOME COMPLETO - <strong>");
#nullable restore
#line 16 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h2>\r\n        </div>\r\n        <div class=\"col-md-12 py-3\">\r\n            <h2>RG - <strong>");
#nullable restore
#line 19 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Details.cshtml"
                        Write(Html.DisplayFor(model => model.Rg));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h2>\r\n        </div>\r\n        <div class=\"col-md-12 \">\r\n            <h2>CPF - <strong>");
#nullable restore
#line 22 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h2>\r\n        </div>\r\n        <div class=\"col-md-12 py-3\">\r\n            <h2 class=\"text-uppercase\">\r\n                DATA DE NASCIMENTO - <strong>");
#nullable restore
#line 26 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Datanascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </h2>\r\n        </div>\r\n        <div class=\"col-md-12\">\r\n            <h2 class=\"text-uppercase\">\r\n                DATA INICIO CURSO - <strong>");
#nullable restore
#line 31 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.DataInicioCurso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </h2>\r\n        </div>\r\n        <div class=\"col-md-12 py-3\">\r\n            <h2 class=\"text-uppercase\">\r\n                DATA TERMINO CURSO - <strong>");
#nullable restore
#line 36 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.DataTerminoCurso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </h2>\r\n        </div>\r\n        <div class=\"col-md-12\">\r\n            <h2 class=\"text-uppercase\">\r\n                GÊNERO - <strong>");
#nullable restore
#line 41 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Details.cshtml"
                            Write(Html.DisplayFor(model => model.Genero));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </h2>\r\n        </div>\r\n        <div class=\"col-md-12 py-3\">\r\n            <h2 class=\"text-uppercase\">\r\n                CURSO -  <strong>");
#nullable restore
#line 46 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Details.cshtml"
                            Write(Html.DisplayFor(model => model.Cursos.NomeCurso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </h2>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"pb-3 text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfe2f4713526abee3f049a3c226fc8475a3606389597", async() => {
                WriteLiteral("<button class=\"mb-3 btn-abrir roboto rounded-pill border-0 px-5 py-3 my-5 w-75 \">VOLTAR</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Remake_FUP.Models.Aluno> Html { get; private set; }
    }
}
#pragma warning restore 1591
