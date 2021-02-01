#pragma checksum "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6f2113541a80bb4a12df640a7b9f28d703634f9"
// <auto-generated/>
#pragma warning disable 1591
namespace FichaAtendimento.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using FichaAtendimento.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using FichaAtendimento.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
using FichaAtendimento.Shared.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fichasatendimento")]
    public partial class Fichas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div style=\"display: inline-flex\"><h1 style=\"display: inline; margin-right: 30px\">Fichas de Atendimento</h1>\r\n    <button style=\"display:inline; align-self: center\" class=\"btn btn-primary\">NOVA FICHA</button></div>");
#nullable restore
#line 10 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
 if (fichas == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, @"<thead><tr><th>Paciente</th>
                <th>Resumo do Atendimento</th>
                <th>Conduta Clínica</th>
                <th>CID10/DSM</th>
                <th>Prox. Tarefa</th>
                <th>Abordagem Prox. Sessão</th>
                <th>Data Atendimento</th>
                <th>Sessão Paga?</th>
                <th>Recibo Entregue?</th></tr></thead>
        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 31 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
             foreach (var item in fichas)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 34 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
                         item.NomePaciente

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 35 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
                         item.ResumoAtendimento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 36 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
                         item.CondutaClinica

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 37 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
                         item.CID10_DSM

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 38 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
                         item.ProxTarefa

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 39 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
                         item.AbordagemProxSessao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 40 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
                         item.DataAtendimento.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
#nullable restore
#line 42 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
                         if (item.SessaoPaga == true)
                            sessaoPaga = "Sim";
                        else
                            sessaoPaga = "Não";

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, 
#nullable restore
#line 46 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
                         sessaoPaga

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
#nullable restore
#line 49 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
                         if (item.ReciboEntregue == true)
                            reciboEntregue = "Sim";
                        else
                            reciboEntregue = "Não";

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, 
#nullable restore
#line 53 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
                         reciboEntregue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
       
    private Ficha[] fichas;

    protected override async Task OnInitializedAsync()
    {
        fichas = await Http.GetFromJsonAsync<Ficha[]>("api/Fichas");
    }

    private string sessaoPaga;
    private string reciboEntregue;


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591