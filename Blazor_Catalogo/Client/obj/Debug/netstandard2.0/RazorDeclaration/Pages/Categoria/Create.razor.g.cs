// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_Catalogo.Client.Pages.Categoria
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/categoria/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 13 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Categoria\Create.razor"
       

    Categoria categoria = new Categoria();

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if(firstRender){
            await Focus("txtCategoriaNome");
        }
    }



    async Task Focus(string elementId){
        await js.InvokeVoidAsync("focusById", elementId);
    }

    async Task CriarCategoria()
    {
        await http.PostJsonAsync("api/categoria", categoria);
        navigation.NavigateTo("categoria");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
