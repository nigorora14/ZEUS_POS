// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 4 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProductoForm")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProductoForm/{Id}")]
    public partial class ProductoForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
       

    [Parameter]
    public string Id { get; set; }

    Data.Producto _prod = new Data.Producto();
    Data.Respuesta<object> _rpt = new Data.Respuesta<object>();
    Data.Respuesta<Data.Producto> _rpt_prod = new Data.Respuesta<Data.Producto>();
    public string Url = "/api/Producto";

    public async Task GuardarProducto()
    {
        if (Id != null)
        {
            var response = await Http.PutAsJsonAsync<Data.Producto>(Url, _prod);
            _rpt = response.Content.ReadFromJsonAsync<Data.Respuesta<object>>().Result;
        }
        else
        {
            var response = await Http.PostAsJsonAsync<Data.Producto>(Url, _prod);
            _rpt = response.Content.ReadFromJsonAsync<Data.Respuesta<object>>().Result;
        }
        //para realizar navegaciones a una ruta especifica.
        NavigationManager.NavigateTo("/ProductoView");
    }
    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            _rpt_prod = await Http.GetFromJsonAsync<Data.Respuesta<Data.Producto>>(Url + "/" + Id);
            _prod = _rpt_prod.Data;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
