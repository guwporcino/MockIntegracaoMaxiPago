#pragma checksum "C:\Users\C5132494\Downloads\MockProdutosIntegracaoPagamento-main\MockProdutosIntegracaoPagamento-main\MockProdutosIntegracaoPagamento\MockProdutosIntegracaoPagamento\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbbbf5eb8d164cc2995d64bd7722f475ed908faf"
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
#line 1 "C:\Users\C5132494\Downloads\MockProdutosIntegracaoPagamento-main\MockProdutosIntegracaoPagamento-main\MockProdutosIntegracaoPagamento\MockProdutosIntegracaoPagamento\Views\_ViewImports.cshtml"
using MockProdutosIntegracaoPagamento;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\C5132494\Downloads\MockProdutosIntegracaoPagamento-main\MockProdutosIntegracaoPagamento-main\MockProdutosIntegracaoPagamento\MockProdutosIntegracaoPagamento\Views\_ViewImports.cshtml"
using MockProdutosIntegracaoPagamento.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbbbf5eb8d164cc2995d64bd7722f475ed908faf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"177b6818fe490b793217228a4ebe0e6d355d95fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Index/InvocarFormPagamento.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/qrcode.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\C5132494\Downloads\MockProdutosIntegracaoPagamento-main\MockProdutosIntegracaoPagamento-main\MockProdutosIntegracaoPagamento\MockProdutosIntegracaoPagamento\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"pt-3 pb-4\"");
            BeginWriteAttribute("id", " id=\"", 65, "\"", 70, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 mb-4"">
                <div class=""card bg-gradient-dark shadow-lg"">
                    <span class=""badge rounded-pill bg-primary w-30 mt-n2 mx-auto"">Platinum</span>
                    <div class=""card-header text-center pt-4 pb-3 bg-transparent"">
                        <h1 class=""font-weight-bold mt-2 text-white"">
                            <small class=""text-lg mb-auto""></small>IBBA<small class=""text-lg"">/mo</small>
                        </h1>
                    </div>
                    <div class=""card-body text-lg-start text-center pt-0"">
                        <div class=""d-flex justify-content-lg-start justify-content-center p-2"">
                            <i class=""material-icons my-auto text-white"">done</i>
                            <span class=""ps-3 text-white"">Gera uma nova cobran??a numa conta pix de teste.</span>
                        </div>
                        <div class=""d-flex justify-co");
            WriteLiteral(@"ntent-lg-start justify-content-center p-2"">
                            <i class=""material-icons my-auto text-white"">done</i>
                            <span class=""ps-3 text-white"">Esta cobran??a ?? no valor de 140 reais. </span>
                        </div>

                        <div class=""d-flex justify-content-lg-start justify-content-center p-2"">
                            <i class=""material-icons my-auto text-white"">remove</i>
                            <span class=""ps-3 text-white"">QRCode n??o pode ser lido pelo celular possivelmente por ser um link de sandbox. </span>
                        </div>

                        <div class=""d-flex justify-content-lg-start justify-content-center p-2"">
                            <i class=""material-icons my-auto text-white"">remove</i>
                            <span class=""ps-3 text-white"">O Link do pix n??o ?? funcional possivelmente por ser em ambiente sandbox. </span>
                        </div>
                        <a href=""javascript:;"" oncl");
            WriteLiteral(@"ick=""CarregarViewComprador()"" class=""btn btn-icon bg-gradient-dark d-lg-block mt-3 mb-0"" data-toggle=""modal"" data-target=""#exampleModalCenter"">
                            Join
                            <i class=""fas fa-arrow-right ms-1""></i>
                        </a>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 mb-4"">
                <div class=""card bg-gradient-dark shadow-lg"">
                    <span class=""badge rounded-pill bg-primary w-30 mt-n2 mx-auto"">Advantage</span>
                    <div class=""card-header text-center pt-4 pb-3 bg-transparent"">
                        <h1 class=""font-weight-bold mt-2 text-white"">
                            <small class=""text-lg mb-auto""></small>maxiPago!<small class=""text-lg"">/cc</small>
                        </h1>
                    </div>
                    <div class=""card-body text-lg-start text-center pt-0"">
                        <div class=""d-flex justify-content-lg-start justify-content");
            WriteLiteral(@"-center p-2"">
                            <i class=""material-icons my-auto text-white"">done</i>
                            <span class=""ps-3 text-white"">Gera uma nova cobran??a para cart??o de d??bito/cr??dito.</span>
                        </div>
                        <div class=""d-flex justify-content-lg-start justify-content-center p-2"">
                            <i class=""material-icons my-auto text-white"">done</i>
                            <span class=""ps-3 text-white"">Esta cobran??a ?? no valor de 140 reais. </span>
                        </div>
                        <div class=""d-flex justify-content-lg-start justify-content-center p-2"">
                            <i class=""material-icons my-auto text-white"">remove</i>
                            <span class=""ps-3 text-white"">O pagamento ?? autenticado via rota disponibilizada pela operadora. </span>
                        </div>
                        <a href=""javascript:;"" onclick=""CarregarViewCompradorCartaoDeCredito()"" class=""btn btn-icon bg");
            WriteLiteral(@"-gradient-dark d-lg-block mt-3 mb-0"" data-toggle=""modal"" data-target=""#exampleModalCenter"">
                            Join
                            <i class=""fas fa-arrow-right ms-1""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbbbf5eb8d164cc2995d64bd7722f475ed908faf9765", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbbbf5eb8d164cc2995d64bd7722f475ed908faf10949", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
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
