#pragma checksum "C:\Users\Suporte\Desktop\WkWebApplication\WkWebApplication\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0101fa6090720a95c3c9b34b2eac97739f1e972f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Index.cshtml", typeof(AspNetCore.Views_Produto_Index))]
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
#line 1 "C:\Users\Suporte\Desktop\WkWebApplication\WkWebApplication\Views\_ViewImports.cshtml"
using WkWebApplication;

#line default
#line hidden
#line 2 "C:\Users\Suporte\Desktop\WkWebApplication\WkWebApplication\Views\_ViewImports.cshtml"
using WkWebApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0101fa6090720a95c3c9b34b2eac97739f1e972f", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc02abe877e4e9cab5914f5606d477af01eef12", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/View/produto.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "A", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "I", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Suporte\Desktop\WkWebApplication\WkWebApplication\Views\Produto\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(61, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(67, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0067e426caab4d53b270ef91f87f8287", async() => {
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
                EndContext();
                BeginContext(134, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(139, 1864, true);
            WriteLiteral(@"<div class=""container-fluid"" style=""padding-right: 0px"">
    <h2 class=""mt-4"">Gerenciamento de Produto</h2>
    <hr />

    <div class=""form-group"" style=""margin-bottom: 4px"">
        <label style=""font-size: 18px;"">Pesquisar</label>
    </div>
    <div class=""row"">
        <div class=""col-md-8 altEspBtnEsq"">
            <input type=""text"" name=""txtPalavraChave"" id=""txtPalavraChave"" value=""""
                   class=""form-control"" placeholder=""Digite aqui..."" />
        </div>
        <div class=""col-md-4 altEspBtnDir"">
            <button type=""button"" id=""btnPesquisar"" class=""btn btn-primary altTam"">Pesquisar</button>
            <a role=""button"" class=""btn btn-success altTam"" id=""btnNovoProduto"" name=""btnNovoProduto"" data-fancybox data-src=""#formNovoProduto"" href=""javascript:;"">Cadastrar</a>
        </div>
    </div>
    <div class=""form-inline"">
        <input type=""radio"" id=""radioTodos"" name=""radio"" value=""todos"" checked />
        <label for=""radioTodos"" class=""altRadioBotton"" style=");
            WriteLiteral(@"""font-size: 14px;"">&nbsp;Todos</label>

        <input type=""radio"" id=""radioAtivo"" name=""radio"" value=""ativo"" style="" margin-left:20px;"" />
        <label for=""radioAtivo"" class=""altRadioBotton"" style=""font-size: 14px;"">&nbsp;Ativo</label>

        <input type=""radio"" id=""radioInativo"" name=""radio"" value=""inativo"" style="" margin-left:20px;"" />
        <label for=""radioInativo"" class=""altRadioBotton"" style=""font-size: 14px;"">&nbsp;Inativo</label>
    </div>
    <hr />
    <h3>Produto Cadastrados</h3>
    <div class=""table-responsive"">
        <table id=""tableProduto"" class=""table table-striped""></table>
    </div>
    <div style=""display: none; min-width: 300px; width: 1000px"" id=""formNovoProduto"">

        <h3 id=""txtCabecalhoCadastro"" name=""txtCabecalhoCadastro"">Cadastro de Produto</h3>
        <hr />
        ");
            EndContext();
            BeginContext(2003, 2936, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4f5d96a50aa4db89e8511451a7de9ab", async() => {
                BeginContext(2009, 1028, true);
                WriteLiteral(@"
            <div class=""form-group"">
                <input type=""hidden"" id=""txtId"" name=""txtIdAlterar"" value=""0"" />
                <label for=""txtNome"">Descrição*</label>
                <input type=""text"" class=""form-control"" id=""txtDesc"" name=""txtDesc"" placeholder=""Ex: Coca-Cola"">
            </div>
            <div class=""row"">
                <div class=""col-md-4"">
                    <label for=""txtCodBarra"">Codigo de barra:</label>
                    <input type=""text"" class=""form-control"" id=""txtCodBarra"" name=""txtCodBarra"" value="""" placeholder=""Ex: 12202858415"">
                </div>
                <div class=""col-md-4"">
                    <label for=""txtObs"">Observação</label>
                    <input type=""text"" class=""form-control"" id=""txtObs"" name=""txtObs"" value="""" placeholder="""">
                </div>
                <div class=""col-md-4"">
                    <label for=""cbbCat"">Categoria</label>
                    <select id=""cbbCat"" name=""cbbCat"" class=""form-control");
                WriteLiteral("\">\r\n");
                EndContext();
#line 62 "C:\Users\Suporte\Desktop\WkWebApplication\WkWebApplication\Views\Produto\Index.cshtml"
                         foreach (var item in ViewBag.Categorias)
                        {

#line default
#line hidden
                BeginContext(3131, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(3159, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f1a7198696447f4870fb872f4a5c454", async() => {
                    BeginContext(3185, 14, false);
#line 64 "C:\Users\Suporte\Desktop\WkWebApplication\WkWebApplication\Views\Produto\Index.cshtml"
                                                Write(item.Descricao);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Suporte\Desktop\WkWebApplication\WkWebApplication\Views\Produto\Index.cshtml"
                               WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3208, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 65 "C:\Users\Suporte\Desktop\WkWebApplication\WkWebApplication\Views\Produto\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(3237, 1518, true);
                WriteLiteral(@"                    </select>
                </div>
            </div>
            <br />
            <div class=""row"">
                <div class=""col-md-3"">
                    <label for=""txtQuantAtual"">Quantidade atual:</label>
                    <input type=""number"" class=""form-control money"" onblur=""onBlurQtdeAtual()"" id=""txtQuantAtual"" name=""txtQuantAtual"" value=""0"">
                </div>
                <div class=""col-md-3"">
                    <label for=""txtQuantMin"">Quantidade Miníma:</label>
                    <input type=""number"" class=""form-control money"" onblur=""onBlurQtdeMin()"" id=""txtQuantMin"" name=""txtQuantMin"" value=""0"">
                </div>
                <div class=""col-md-3"">
                    <label for=""txtVlrCusto"">Valor de custo:</label>
                    <input type=""number"" class=""form-control money"" onblur=""onBlurVlrCusto()"" id=""txtVlrCusto"" name=""txtVlrCusto"" value=""0"">
                </div>
                <div class=""col-md-3"">
                   ");
                WriteLiteral(@" <label for=""txtVlrVenda"">Valor de venda:</label>
                    <input type=""number"" class=""form-control money"" onblur=""onBlurVlrVenda()"" id=""txtVlrVenda"" name=""txtVlrVenda"" value=""0"">
                </div>
            </div>
            <br />
            <div class=""row"">
                <div class=""col-md-3"">
                    <label for=""cbbStatus"">Status</label>
                    <select id=""cbbStatus"" name=""cbbStatus"" class=""form-control"">
                        ");
                EndContext();
                BeginContext(4755, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5e541da18a6412daa48ce304af8e148", async() => {
                    BeginContext(4773, 5, true);
                    WriteLiteral("Ativo");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4787, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(4813, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fb885ed38c04575a2ff469a8d014c74", async() => {
                    BeginContext(4831, 7, true);
                    WriteLiteral("Inativo");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4847, 85, true);
                WriteLiteral("\r\n                    </select>\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4939, 641, true);
            WriteLiteral(@"

        <hr />
        <div class=""form-inline"">
            <button type=""button"" class=""btn btn-success"" id=""btnGravar"" name=""btnGravar"" style=""width: 100px;"">Cadastrar</button>
            <button type=""button"" name=""btnCancelar"" id=""btnCancelar"" class=""btn btn-danger""
                    onclick=""$.fancybox.close();"" style=""width: 100px;"">
                Cancelar
            </button>
        </div>
        <hr />
        <div id=""divAlertaCadCat"" class=""alert alert-danger"" role=""alert"" style=""display:none""></div>
        <label style=""color:red; font-size: 10px;"">* Campos Obrigatórios</label>
    </div>
</div>
");
            EndContext();
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
