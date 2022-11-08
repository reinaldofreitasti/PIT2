#pragma checksum "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Categoria\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72dc03516ac583ba1c789b4abf2a352bfaec4b96"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/categoria/edit/{categoriaid:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Editar Categoria</h2>\r\n\r\n");
            __builder.OpenComponent<Blazor_Catalogo.Client.Pages.Categoria.CategoriaForm>(1);
            __builder.AddAttribute(2, "Categoria", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazor_Catalogo.Shared.Models.Categoria>(
#line 7 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Categoria\Edit.razor"
                           categoria

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 7 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Categoria\Edit.razor"
                                                      EditarCategoria

#line default
#line hidden
            )));
            __builder.AddAttribute(4, "ButtonTextSubmit", "Salvar");
            __builder.AddAttribute(5, "ButtonTextCancelar", "Cancelar");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 12 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Categoria\Edit.razor"
       

    [Parameter]
    public int categoriaid { get; set; }

    Categoria categoria = new Categoria();

    protected async override Task OnParametersSetAsync()
    {
        categoria = await http.GetJsonAsync<Categoria>($"api/categoria/{categoriaid}");
    }

    async Task EditarCategoria()
    {
        await http.PutJsonAsync("api/categoria", categoria);
        navigation.NavigateTo("categoria");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591