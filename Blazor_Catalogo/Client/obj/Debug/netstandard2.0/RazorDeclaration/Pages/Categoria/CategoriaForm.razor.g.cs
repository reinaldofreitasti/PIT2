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
    public partial class CategoriaForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 28 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Categoria\CategoriaForm.razor"
      

    [Inject]
    public NavigationManager navigation { get; set; }

    [Parameter]
    public Categoria Categoria { get; set; }

    [Parameter]
    public string ButtonTextSubmit { get; set; } = "Salvar";

    [Parameter]
    public string ButtonTextCancelar { get; set; } = "Cancelar";

    [Parameter]
    public EventCallback OnValidSubmit { get; set; }


#line default
#line hidden
    }
}
#pragma warning restore 1591
