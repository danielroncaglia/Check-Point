#pragma checksum "C:\Users\28725446827\Desktop\sistemasTarefasSenai\Views\Usuario\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2f329233fcda589dd3109448f7e970009de8fa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Cadastrar), @"mvc.1.0.view", @"/Views/Usuario/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Cadastrar.cshtml", typeof(AspNetCore.Views_Usuario_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f329233fcda589dd3109448f7e970009de8fa8", @"/Views/Usuario/Cadastrar.cshtml")]
    public class Views_Usuario_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 36, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"pt.br\">\n");
            EndContext();
            BeginContext(36, 294, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d076917b0b654832b3e7e49d3bf191d5", async() => {
                BeginContext(42, 281, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Cadastro de Usuários</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link href=""https://fonts.googleapis.com/css?family=Lato"" rel=""stylesheet"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(330, 1582, true);
            WriteLiteral(@"

<style>

* {
    box-sizing: border-box;
    margin: 0;
    padding: 0;
    font-family: ""Lato"";

}
.menu {
    background-color: yellow;
    background-position: center;
    height: 40px;
    margin: auto;
}
.menu ul{
    text-align: center;
    list-style-type: none;
    padding-top: 8px;
}
.menu li{
    display: inline;
    margin: 0 50px;
    font-weight: 100;
    font-size: 25px;
    color: black;
}
#vista{
    margin: 0 auto;
    background-color: lightblue;
    background-size: cover;
    min-height: 100vh;
    padding-top: 50px;
}
#vista *{
    display: block;
    margin: auto;
}
#vista h1 {
    font-size: 60px;
    color: white;
    margin: center;
    margin-left: 400px;
    margin-right: 400px;
    background-color: black;
    text-align: center;
}
.botao {
    font-size: 35px;
    border-radius: 20px;
    text-align: center;
    color:whitesmoke;
    background-color: red;
    width: 200px;
    box-shadow: 0px 1px 1px #ccc;
}
.botao:focus {
    font-size: 35px;
    border-radius: 20px;
    text-");
            WriteLiteral(@"align: center;
    background-color: white;
    color: black;
    width: 200px;
    box-shadow: 0px 1px 1px #ccc;
}
.textoarea {
    font-size: 25px;
    border-radius: 10px;
    text-align: center;
    color: black;
}
.caixaselecao {
    font-size: 25px;
    border-radius: 10px;
    text-align: center;
    color: black;
}
</style>

<main class=""conteudo"">
    <nav class=""menu"">
        <ul>
            <li> <a href=""/Usuario/Cadastrar"">Cadastro de Usuário</a></li>
            <li> <a href=""/Usuario/Login"">Efetuar Login</a></li>
        </ul>
</main>

");
            EndContext();
            BeginContext(1912, 1043, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b02bac4a5d404c7b995842f60490398e", async() => {
                BeginContext(1918, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(1925, 16, false);
#line 100 "C:\Users\28725446827\Desktop\sistemasTarefasSenai\Views\Usuario\Cadastrar.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
                EndContext();
                BeginContext(1941, 1007, true);
                WriteLiteral(@"
    
    <section id=""vista"">

        <h1>Cadastro de Usuários</h1>
        <br>
    <form action=""/Usuario/Cadastrar"" method=""Post"">
        <label>
            <input class=""textoarea"" type=""text"" name=""nomeUsuario"" placeholder=""Nome"" required =""true"">
        </label>
        <br>
        <label>
           <input class=""textoarea"" type=""email"" name=""email"" placeholder=""E-mail"" required =""true"">
        </label>
        <br>        
        <label>
            <input class=""textoarea"" type=""password"" name=""senha"" placeholder=""Senha"" required =""true"">
        </label>
        <br>        
        <label>
                <select class=""caixaselecao"" name=""tipoUsuario"" required=""true"">
                <option valeu="""">Tipo:</option>
                <option value=""usuario"">Usuário</option>
                <option value=""admin"">Administrador</option>
                 </select>
        </label>
        <br>
        <button class=""botao"" type=""submit"">Salvar</button>
    </form>
    </section>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2955, 69, true);
            WriteLiteral("\n<footer>\n        Desenvolvido por Daniel Roncaglia\n</footer>\n</html>");
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
