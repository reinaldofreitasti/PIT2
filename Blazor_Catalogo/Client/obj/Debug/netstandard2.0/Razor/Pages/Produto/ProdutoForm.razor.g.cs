#pragma checksum "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5614ed8052daaef4e164beb3badd635c63b3a1a"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Catalogo.Client.Pages.Produto
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
    public partial class ProdutoForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 1 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                  Produto

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 1 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                                           OnValidSubmit

#line default
#line hidden
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<Blazor_Catalogo.Client.Shared.InputImagem>(12);
                __builder2.AddAttribute(13, "Label", "Imagem");
                __builder2.AddAttribute(14, "ImagemSelecionada", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#line 6 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                                                       ImagemSelecionada

#line default
#line hidden
                )));
                __builder2.AddAttribute(15, "ImagemRemota", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 7 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                                    ImagemRemota

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.AddMarkupContent(21, "<label form=\"nome\">Código: </label>\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 13 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                                    Produto.Codigo

#line default
#line hidden
                ));
                __builder2.AddAttribute(27, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Produto.Codigo = __value, Produto.Codigo))));
                __builder2.AddAttribute(28, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Produto.Codigo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __Blazor.Blazor_Catalogo.Client.Pages.Produto.ProdutoForm.TypeInference.CreateValidationMessage_0(__builder2, 30, 31, 
#line 14 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                                      ()=> Produto.Codigo

#line default
#line hidden
                );
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.AddMarkupContent(38, "<label form=\"descricao\">Descrição: </label>\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(41);
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 20 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                                        Produto.Descricao

#line default
#line hidden
                ));
                __builder2.AddAttribute(44, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Produto.Descricao = __value, Produto.Descricao))));
                __builder2.AddAttribute(45, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Produto.Descricao));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __Blazor.Blazor_Catalogo.Client.Pages.Produto.ProdutoForm.TypeInference.CreateValidationMessage_1(__builder2, 47, 48, 
#line 21 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                                      ()=> Produto.Descricao

#line default
#line hidden
                );
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group");
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.AddMarkupContent(55, "<label form=\"preco\">Preço: </label>\r\n        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddMarkupContent(57, "\r\n            ");
                __Blazor.Blazor_Catalogo.Client.Pages.Produto.ProdutoForm.TypeInference.CreateInputNumber_2(__builder2, 58, 59, "form-control", 60, 
#line 27 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                                      Produto.Preco

#line default
#line hidden
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Produto.Preco = __value, Produto.Preco)), 62, () => Produto.Preco);
                __builder2.AddMarkupContent(63, "\r\n            ");
                __Blazor.Blazor_Catalogo.Client.Pages.Produto.ProdutoForm.TypeInference.CreateValidationMessage_3(__builder2, 64, 65, 
#line 28 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                                      ()=> Produto.Preco

#line default
#line hidden
                );
                __builder2.AddMarkupContent(66, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group");
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.AddMarkupContent(72, "<label form=\"categoria\">Categoria: </label>\r\n        ");
                __builder2.OpenElement(73, "select");
                __builder2.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 33 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                           CategoriaSelectionChanged

#line default
#line hidden
                ));
                __builder2.AddAttribute(75, "class", "form-control");
                __builder2.AddMarkupContent(76, "\r\n");
#line 34 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
             if (categorias != null)
            {
                

#line default
#line hidden
#line 36 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                 foreach (var categoria in categorias)
                {

#line default
#line hidden
                __builder2.AddContent(77, "                    ");
                __builder2.OpenElement(78, "option");
                __builder2.AddAttribute(79, "value", 
#line 38 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                                    categoria.CategoriaId

#line default
#line hidden
                );
                __builder2.AddAttribute(80, "selected", 
#line 39 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                                categoria.CategoriaId == Produto.CategoriaId ? true : false

#line default
#line hidden
                );
                __builder2.AddMarkupContent(81, "\r\n                        ");
#line 40 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
__builder2.AddContent(82, categoria.Nome);

#line default
#line hidden
                __builder2.AddMarkupContent(83, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n");
#line 42 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                }

#line default
#line hidden
#line 42 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                 
            }

#line default
#line hidden
                __builder2.AddContent(85, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n    <br>\r\n    ");
                __builder2.OpenElement(88, "button");
                __builder2.AddAttribute(89, "type", "submit");
                __builder2.AddAttribute(90, "class", "btn btn-success");
                __builder2.AddMarkupContent(91, "\r\n        ");
#line 48 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
__builder2.AddContent(92, ButtonTextSubmit);

#line default
#line hidden
                __builder2.AddMarkupContent(93, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n    ");
                __builder2.OpenElement(95, "button");
                __builder2.AddAttribute(96, "class", "btn btn-danger");
                __builder2.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 51 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
                        ()=> navigation.NavigateTo("Produto")

#line default
#line hidden
                ));
                __builder2.AddMarkupContent(98, "\r\n        ");
#line 52 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
__builder2.AddContent(99, ButtonTextCancelar);

#line default
#line hidden
                __builder2.AddMarkupContent(100, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 56 "D:\Reinaldo\Faculdade - Ciência da Computação\202202\PIT2\Blazor\Blazor_Catalogo\Blazor_Catalogo\Client\Pages\Produto\ProdutoForm.razor"
       

    List<Categoria> categorias;

    [Inject]
    private NavigationManager navigation { get; set; }

    [Inject]
    private HttpClient http { get; set; }

    [Parameter]
    public Produto Produto { get; set; }

    [Parameter]
    public string ButtonTextSubmit { get; set; } = "Salvar";

    [Parameter]
    public string ButtonTextCancelar { get; set; } = "Cancelar";

    [Parameter]
    public EventCallback OnValidSubmit { get; set; }

    [Parameter]
    public string ImagemRemota { get; set; }

    private void ImagemSelecionada(string imagemBase64)
    {
        Produto.ImagemUrl = imagemBase64;
        ImagemRemota = null;
        Produto.CategoriaId = categorias[0].CategoriaId;
    }

    protected async override Task OnInitializedAsync()
    {
        Produto.ImagemUrl = null;
        await CarregaCategorias();
    }

    private async Task CarregaCategorias()
    {
        categorias = await http.GetJsonAsync<List<Categoria>>("api/categoria/todas");
    }

    void CategoriaSelectionChanged(ChangeEventArgs e)
    {
        if (int.TryParse(e.Value.ToString(), out int id))
        {
            Produto.CategoriaId = id;
        }
    }

#line default
#line hidden
    }
}
namespace __Blazor.Blazor_Catalogo.Client.Pages.Produto.ProdutoForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
