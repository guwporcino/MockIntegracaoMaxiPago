#pragma checksum "C:\Users\C5132494\Downloads\MockProdutosIntegracaoPagamento-main\MockProdutosIntegracaoPagamento-main\MockProdutosIntegracaoPagamento\MockProdutosIntegracaoPagamento\Views\Home\ModalFormulario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b7b7eb6582995a6ba70599aa0bd1c20ae50d447"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ModalFormulario), @"mvc.1.0.view", @"/Views/Home/ModalFormulario.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b7b7eb6582995a6ba70599aa0bd1c20ae50d447", @"/Views/Home/ModalFormulario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"177b6818fe490b793217228a4ebe0e6d355d95fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ModalFormulario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.maskMoney.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""modalForm"">
    <div class=""modal-content"" style=""max-height: 768px; overflow-y: scroll;"">
        <div class=""modal-header"">
            <h2>Formulário de checkout</h2>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
            </button>
        </div>
        <div class=""modal-body"">
            <div class=""container"">
                <div class=""py-5 text-center"">
                    <p class=""lead"">Abaixo temos um exemplo de formulário para checkout.</p>
                </div>
                <div class=""row"" style=""width: 100%"">
                    <div class=""col-md-8 order-md-1"" style=""width: 100%"">
                        <h4 class=""mb-3"">Dados Pessoais</h4>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b7b7eb6582995a6ba70599aa0bd1c20ae50d4475988", async() => {
                WriteLiteral(@"
                            <div class=""row"" style=""padding: 10px;"">
                                <div class=""col-md-8 mb-3"">
                                    <label for=""primeiroNome"">Nome</label>
                                    <input type=""text"" class=""form-control"" id=""FirstName"" name=""FirstName""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1148, "\"", 1162, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1163, "\"", 1171, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                    <div class=""invalid-feedback"">
                                        É obrigatório inserir um nome válido.
                                    </div>
                                </div>
                                <div class=""col-md-8 mb-3"">
                                    <label for=""sobrenome"">Sobrenome</label>
                                    <input type=""text"" class=""form-control"" id=""LastName"" name=""LastName""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1652, "\"", 1666, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1667, "\"", 1675, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                    <div class=""invalid-feedback"">
                                        É obrigatório inserir um sobre nome válido.
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-8 mb-3"">
                                <label for=""email"">Telefone</label>
                                <input type=""email"" class=""form-control"" id=""BillingPhone"" name=""BillingPhone"">
                                <div class=""invalid-feedback"">
                                    Por favor, um telefone válido.
                                </div>
                            </div>
                            <div class=""col-md-8 mb-3"">
                                <label for=""email"">E-mail</label>
                                <input type=""email"" class=""form-control"" id=""BillingEmail"" name=""BillingEmail"">
                                <div class=""invalid-feedback"">
        ");
                WriteLiteral(@"                            Por favor, insira um endereço de e-mail válido, para atualizações de entrega.
                                </div>
                            </div>
                            <hr class=""mb-4"">
                            <h4 class=""mb-3"">Endereço de cobrança</h4>
                            <div class=""col-md-8 mb-3"">
                                <label for=""endereco"">Logradouro</label>
                                <input type=""text"" class=""form-control"" id=""BillingAddress1"" name=""BillingAddress"" required>
                                <div class=""invalid-feedback"">
                                    Por favor, insira seu endereço de entrega.
                                </div>
                            </div>
                            <div class=""col-md-8 mb-3"">
                                <label for=""endereco2"">Número</label>
                                <input type=""text"" class=""form-control"" id=""BillingAddress2"" name=""BillingAddress2"">
              ");
                WriteLiteral("              </div>\n                            <div class=\"col-md-4 mb-3\">\n                                <label for=\"cep\">Estado</label>\n                                <input type=\"text\" class=\"form-control\" id=\"State\" name=\"BillingState\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3967, "\"", 3981, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <div class=""invalid-feedback"">
                                    Por favor, insira um estado válido.
                                </div>
                            </div>
                            <div class=""col-md-4 mb-3"">
                                <label for=""cep"">Cidade</label>
                                <input type=""text"" class=""form-control"" id=""City"" name=""BillingCity""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4422, "\"", 4436, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <div class=""invalid-feedback"">
                                    É obrigatório inserir uma cidade.
                                </div>
                            </div>
                            <div class=""col-md-4 mb-3"">
                                <label for=""cep"">CEP</label>
                                <input type=""text"" class=""form-control"" id=""ZipCode"" name=""BillingPostalCode""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4881, "\"", 4895, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <div class=""invalid-feedback"">
                                    É obrigatório inserir um CEP.
                                </div>
                            </div>
                            <hr class=""mb-4"">
                            <h4 class=""mb-3"">Valor a ser creditado</h4>
                            <div class=""col-md-8 mb-3"">
                                <label for=""cc-nome"">Valor:</label>
                                <input type=""text"" class=""form-control"" id=""Valor"" name=""Value""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5447, "\"", 5461, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <div class=""invalid-feedback"">
                                    O valor é obrigatório.
                                </div>
                            </div>
                            <hr class=""mb-4"">
                            <h4 class=""mb-3"">Pagamento</h4>
                            <div class=""col-md-8 mb-3"">
                                <label for=""cc-nome"">Nome no cartão</label>
                                <input type=""text"" class=""form-control"" id=""CreditCardName""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5998, "\"", 6012, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <div class=""invalid-feedback"">
                                    O nome que está no cartão é obrigatório.
                                </div>
                            </div>
                            <div class=""col-md-8 mb-3"">
                                <label for=""cc-numero"">Número do cartão de crédito</label>
                                <input type=""number"" class=""form-control"" id=""CreditCardNumber"" name=""CreditCardNumber"" maxlength=""16""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6519, "\"", 6533, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <div class=""invalid-feedback"">
                                    O número do cartão de crédito é obrigatório.
                                </div>
                            </div>
                            <div class=""col-md-4 mb-3"">
                                <label for=""cc-expiracao"">Data de expiração</label>
                                <input type=""number"" class=""form-control"" id=""ExpMonth"" name=""ExpMonth"" maxlength=""2""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 7020, "\"", 7034, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                                <input type=""number"" class=""form-control"" id=""ExpYear"" name=""ExpYear"" maxlength=""4"" required>
                                <div class=""invalid-feedback"">
                                    Data de expiração é obrigatória.
                                </div>
                            </div>
                            <div class=""col-md-4 mb-3"">
                                <label for=""cc-cvv"">CVV</label>
                                <input type=""number"" class=""form-control"" name=""CvvNumber"" maxlength=""3""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 7602, "\"", 7616, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\n                                <div class=\"invalid-feedback\">\n                                    Código de segurança é obrigatório.\n                                </div>\n                            </div>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
            <button id=""btnPayment"" type=""button"" class=""btn btn-primary"">Efetuar pagamento</button>
        </div>
    </div>
</div>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"" type=""text/javascript""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b7b7eb6582995a6ba70599aa0bd1c20ae50d44717043", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<style>

    .form-control {
        background-color: ghostwhite !important;
    }
</style>

<script type=""text/javascript"">

    $(document).ready(function () {

        $(""#Valor"").maskMoney({
            prefix: ""R$:"",
            decimal: "","",
            thousands: "".""
        });

        function limpa_formulário_cep() {
            // Limpa valores do formulário de cep.
            $(""#BillingAddress1"").val("""");
            $(""#Neighborhood"").val("""");
            $(""#City"").val("""");
            $(""#State"").val("""");
        }

        //Quando o campo cep perde o foco.
        $(""#ZipCode"").blur(function () {

            //Nova variável ""cep"" somente com dígitos.
            var cep = $(this).val().replace(/\D/g, '');

            //Verifica se campo cep possui valor informado.
            if (cep != """") {

                //Expressão regular para validar o CEP.
                var validacep = /^[0-9]{8}$/;

                //Valida o formato do CEP.
                if (validacep.test(cep)) {

    ");
            WriteLiteral(@"                //Preenche os campos com ""..."" enquanto consulta webservice.
                    $(""#BillingAddress1"").val(""..."");
                    $(""#Neighborhood"").val(""..."");
                    $(""#City"").val(""..."");
                    $(""#State"").val(""..."");

                    //Consulta o webservice viacep.com.br/
                    $.getJSON(""https://viacep.com.br/ws/"" + cep + ""/json/?callback=?"", function (dados) {

                        if (!(""erro"" in dados)) {
                            //Atualiza os campos com os valores da consulta.
                            $(""#BillingAddress1"").val(dados.logradouro);
                            $(""#Neighborhood"").val(dados.bairro);
                            $(""#City"").val(dados.localidade);
                            $(""#State"").val(dados.uf);
                        } //end if.
                        else {
                            //CEP pesquisado não foi encontrado.
                            limpa_formulário_cep();
                     ");
            WriteLiteral(@"       alert(""CEP não encontrado."");
                        }
                    });
                } //end if.
                else {
                    //cep é inválido.
                    limpa_formulário_cep();
                    alert(""Formato de CEP inválido."");
                }
            } //end if.
            else {
                //cep sem valor, limpa formulário.
                limpa_formulário_cep();
            }
        });
    });

    $(""#btnPayment"").click(function (e) {
        if (validaCampos()) {
            //Serialize the form datas.
            var valdata = $(""#form"").serialize();
            //to get alert popup
            alert(valdata);
            $.ajax({
                url: ""/Home/EnviarDados"",
                type: ""POST"",
                dataType: 'json',
                contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
                data: valdata,
                success:
                    $('#myModal').show()
            });
        }
    });
");
            WriteLiteral(@"
    function validaCampos() {
        if (firstName = """" || lastName == """" || phone == """" || email == """" || zipcode == """" ||
            value == """" || creditCardName == """" || creditCardNumber == """" || expMonth == """" || expYear == """" ||
            cvv == """") {
            alert(""Um ou mais campos foram preenchidos incorretamente. Verifique os dados digitados e tente novamente!"");
            return false;
        } else {
            return true;
        }
    }

    //Campos
    var firstName = $(""#FirstName"").val();
    var lastName = $(""#LastName"").val();
    var phone = $(""#BillingPhone"").val();
    var email = $(""#BillingEmail"").val();
    var zipcode = $(""#ZipCode"").val();
    var value = $(""#Valor"").val();
    var creditCardName = $(""#CreditCardName"").val();
    var creditCardNumber = $(""#CreditCardNumber"").val();
    var expMonth = $(""#ExpMonth"").val();
    var expYear = $(""#ExpYear"").val();
    var cvv = $(""#CvvNumber"").val();

</script>

<div id=""myModal"" class=""modal"" tabindex=""-1"" role=""di");
            WriteLiteral(@"alog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>O seu pagamento foi efetuado com sucesso em ambiente (Sandbox) </p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Ok</button>
            </div>
        </div>
    </div>
</div>");
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
