#pragma checksum "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fdcfd402c01841b91eac5a0dc90d0ee1ba6fa6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alunos_Delete), @"mvc.1.0.view", @"/Views/Alunos/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fdcfd402c01841b91eac5a0dc90d0ee1ba6fa6c", @"/Views/Alunos/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b65c0ab00a7977709ba7619ebefffc8dbb2c1e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Alunos_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Remake_FUP.Models.Aluno>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("position-absolute mt-5 pt-3 mx-5 ficha "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/ficha.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <div class=\"py-5\"></div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0fdcfd402c01841b91eac5a0dc90d0ee1ba6fa6c5664", async() => {
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
            WriteLiteral(@"
    <div class=""container back-detalhes pt-5 pb-3 "">
        <div class=""row  p-6"">
            <div class=""pb-5 text-center"">

            </div>
            <div class=""col-md-12 text-left"">
                <h2 class=""text-uppercase"">NOME COMPLETO - <strong>");
#nullable restore
#line 18 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Delete.cshtml"
                                                              Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h2>\r\n            </div>\r\n            <div class=\"col-md-12 py-3\">\r\n                <h2>RG - <strong>");
#nullable restore
#line 21 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Delete.cshtml"
                            Write(Html.DisplayFor(model => model.Rg));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h2>\r\n            </div>\r\n            <div class=\"col-md-12 \">\r\n                <h2>CPF - <strong>");
#nullable restore
#line 24 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Delete.cshtml"
                             Write(Html.DisplayFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h2>\r\n            </div>\r\n            <div class=\"col-md-12 py-3\">\r\n                <h2 class=\"text-uppercase\">\r\n                    DATA DE NASCIMENTO - <strong>");
#nullable restore
#line 28 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Delete.cshtml"
                                            Write(Html.DisplayFor(model => model.Datanascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </h2>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <h2 class=\"text-uppercase\">\r\n                    DATA INICIO CURSO - <strong>");
#nullable restore
#line 33 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Delete.cshtml"
                                           Write(Html.DisplayFor(model => model.DataInicioCurso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </h2>\r\n            </div>\r\n            <div class=\"col-md-12 py-3\">\r\n                <h2 class=\"text-uppercase\">\r\n                    DATA TERMINO CURSO - <strong>");
#nullable restore
#line 38 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Delete.cshtml"
                                            Write(Html.DisplayFor(model => model.DataTerminoCurso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </h2>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <h2 class=\"text-uppercase\">\r\n                    GÊNERO - <strong>");
#nullable restore
#line 43 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Delete.cshtml"
                                Write(Html.DisplayFor(model => model.Genero));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </h2>\r\n            </div>\r\n            <div class=\"col-md-12 py-3\">\r\n                <h2 class=\"text-uppercase\">\r\n                    CURSO -  <strong>");
#nullable restore
#line 48 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Delete.cshtml"
                                Write(Html.DisplayFor(model => model.Cursos.NomeCurso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </h2>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"pb-3 text-center\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0fdcfd402c01841b91eac5a0dc90d0ee1ba6fa6c10927", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 57 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id_Matricula);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <input type=\"submit\" id=\"ifood\" value=\"Excluir\" class=\"roboto rounded-pill border-0 px-5 py-3 mt-5 mb-3 w-50 btn-deletar text-uppercase\" />\r\n                </div>\r\n                <div class=\"col-md-12\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fdcfd402c01841b91eac5a0dc90d0ee1ba6fa6c12851", async() => {
                WriteLiteral("<button class=\"mb-3 btn-abrir roboto rounded-pill border-0 mb-5 px-5 py-3  w-50 \">VOLTAR</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>

        <div class=""popup-container"">
            <div class=""popup rounded"">
                <div class=""popup-close"">x</div>
                <div class=""popup-content"">

                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <h2 class=""my-3 roboto"">Tem certeza de que deseja excluir estes dados?</h2>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fdcfd402c01841b91eac5a0dc90d0ee1ba6fa6c14636", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0fdcfd402c01841b91eac5a0dc90d0ee1ba6fa6c14931", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 76 "C:\Users\dionn\Desktop\Nova pasta (2)\Projeto-Final\PROJETO_FUP_Brasil\Views\Alunos\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id_Matricula);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <input type=\"submit\" value=\"EXCLUIR\" class=\"roboto rounded-pill border-0 px-5 py-3 mt-5 mb-3 w-50 btn-deletar text-uppercase\" />\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n\r\n                            <div class=\"col-md-12\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fdcfd402c01841b91eac5a0dc90d0ee1ba6fa6c18167", async() => {
                WriteLiteral("<button class=\"mb-3 btn-abrir roboto rounded-pill border-0 mb-3 px-5 py-3  w-50 \">CANCELAR</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>

    </div>

</div>

<script>
        const button = document.getElementById('ifood');
        const popup = document.querySelector('.popup-container');
        const close = document.querySelector('.popup-close')
        button.addEventListener('click', () => {
            popup.style.display = 'flex';
        })
        close.addEventListener('click', () => {
            popup.style.display = 'none';
        })
        popup.addEventListener('click', () => {
            popup.style.display = 'none';
        });
        const button2 = document.getElementById('last');
        const popup2 = document.querySelector('.popup-container');
        const close2 = document.querySelector('.popup-close')
        button2.addEventListener('click', () => {
            popup2.style.display = 'flex';
        })
        close2.addEventListener");
            WriteLiteral("(\'click\', () => {\r\n            popup2.style.display = \'none\';\r\n        })\r\n        popup2.addEventListener(\'click\', () => {\r\n            popup2.style.display = \'none\';\r\n        })\r\n</script>");
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
