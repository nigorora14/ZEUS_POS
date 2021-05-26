#pragma checksum "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\EliminarProducto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b3bdd1b9d027220f2d26008a49ae48cbf57414d"
// <auto-generated/>
#pragma warning disable 1591
namespace POS_Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\_Imports.razor"
using POS_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\_Imports.razor"
using POS_Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\EliminarProducto.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\EliminarProducto.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EliminarProducto/{Id}")]
    public partial class EliminarProducto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EliminarProducto</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Deseas Eliminaz el ");
            __builder.AddContent(3, 
#nullable restore
#line 10 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\EliminarProducto.razor"
                       Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ?");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-primary");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\EliminarProducto.razor"
                                              Cancelar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Cancelar");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-primary");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\EliminarProducto.razor"
                                              Eliminar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Eliminar");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\EliminarProducto.razor"
       
    [Parameter]
    public string Id { get; set; }
    Data.Respuesta<object> _rpt = new Data.Respuesta<object>();
    public string Url = "/api/Producto";

    public void Cancelar() => NavigationManager.NavigateTo("/ProductoView");

    public async Task Eliminar()
    {

        var response = await Http.DeleteAsync(Url+"/"+Id);
        _rpt = response.Content.ReadFromJsonAsync<Data.Respuesta<object>>().Result;

        //para realizar navegaciones a una ruta especifica.
        NavigationManager.NavigateTo("/ProductoView");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
