// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_Catalogo.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\_Imports.razor"
using Blazor_Catalogo.Client;

#line default
#line hidden
#line 7 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\_Imports.razor"
using Blazor_Catalogo.Client.Shared;

#line default
#line hidden
#line 8 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\_Imports.razor"
using Blazor_Catalogo.Shared.Models;

#line default
#line hidden
#line 9 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#line 10 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
    public partial class Paginacao : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 18 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Shared\Paginacao.razor"
       
    [Parameter] public int paginaAtual { get; set; } = 1;
    [Parameter] public int QuantidadeTotalPaginas { get; set; }
    [Parameter] public int Raio { get; set; } = 3;
    [Parameter] public EventCallback<int> PaginaSelecionada{ get; set; }

    List<LinkModel> links;

    private async Task PaginaSelecionadaLink(LinkModel link){
        if(link.Page == paginaAtual){
            return;
        }

        if(!link.Enabled){
            return;
        }
        paginaAtual = link.Page;
        await PaginaSelecionada.InvokeAsync(link.Page);
    }


    class LinkModel{

        public LinkModel(int page) : this(page, true)
        {}

        public LinkModel(int page, bool enabled) : this(page, enabled, page.ToString())
        {}

        public LinkModel(int page, bool enabled, string text)
        {
            Page = page;
            Enabled = enabled;
            Text = text;
        }

        public string Text{ get; set; }
        public int Page { get; set; }
        public bool Enabled { get; set; } = true;
        public bool Active { get; set; } = false;

    }

    protected override void OnParametersSet()
    {
        CarregaPaginas();
    }

    private void CarregaPaginas(){
        links = new List<LinkModel>();


        //Tratar o link anterior
        var isLinkPaginaAnteriorHabilitado = paginaAtual != 1;
        var paginaAnterior = paginaAtual - 1;

        links.Add(new LinkModel(paginaAnterior, isLinkPaginaAnteriorHabilitado, "Anterior"));

        //tratar os links das paginas especificas

        for(int i=1; i<=QuantidadeTotalPaginas; i++){
            if(i >= paginaAtual - Raio && i<= paginaAtual + Raio)
            {
                links.Add(new LinkModel(i)
                    {
                        Active = paginaAtual == i
                    });
            }
        }


        //Trata o link para a próxima pagina
        var isLinkProximaPaginaHabilitado = paginaAtual != QuantidadeTotalPaginas;
        var proximaPagina = paginaAtual + 1;

        links.Add(new LinkModel(proximaPagina, isLinkProximaPaginaHabilitado, "Próximo"));

    }


#line default
#line hidden
    }
}
#pragma warning restore 1591