using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace POS_Blazor.Pages
{
    public partial class ProductoForm
    {
        [Parameter]
        public string Id { get; set; }
        [Inject]
        public HttpClient Http { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        private string FormCss { get; set; } = "visible";
        private string MessageCss { get; set; } = "oculto";

        public void Siguiente() => NavigationManager.NavigateTo("/ProductoView");
        Data.Producto _prod = new Data.Producto();
        Data.Respuesta<object> _rpt = new Data.Respuesta<object>();
        Data.Respuesta<Data.Producto> _rpt_prod = new Data.Respuesta<Data.Producto>();       
        public string Url = "/api/Producto";
        public async Task GuardarProducto()
        {
            if (Id != null)
            {
                if (Validacion())
                {
                    var response = await Http.PutAsJsonAsync(Url, _prod);//<Data.Producto>
                    _rpt = response.Content.ReadFromJsonAsync<Data.Respuesta<object>>().Result;
                    if (_rpt.exito == 1)
                    {
                        FormCss = "oculto";
                        MessageCss = "visible";
                    }
                }
            }
            else
            {
                if (Validacion())
                {
                    var response = await Http.PostAsJsonAsync(Url, _prod);//<Data.Producto>
                    _rpt = response.Content.ReadFromJsonAsync<Data.Respuesta<object>>().Result;

                    if (_rpt.exito == 1)
                    {
                        FormCss = "oculto";
                        MessageCss = "visible";
                    }
                }
            }
            //para realizar navegaciones a una ruta especifica.
            //NavigationManager.NavigateTo("/ProductoView");
        }
        protected override async Task OnInitializedAsync() //se quito el override
        {
            if (Id != null)
            {
                _rpt_prod = await Http.GetFromJsonAsync<Data.Respuesta<Data.Producto>>(Url + "/" + Id);
                _prod = _rpt_prod.Data;
            }
        }

        bool Validacion()
        {
            if (_prod.IdPro.Length <= 7)
            {
                return false;
            }
            if (_prod.PreCompraS <= 0 | _prod.PreCompraS == null)
            {
                return false;
            }
            if (_prod.DescripcionLarga.Length <= 0)
            {
                return false;
            }
            if (_prod.Frank <= 0 | _prod.Frank == null)
            {
                return false;
            }
            if (_prod.PreVntaxMenor <= 0 | _prod.PreVntaxMenor == null)
            {
                return false;
            }
            return true;
        }
    }
}
