#pragma checksum "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "360fb18f42c68c30c133621fc5256a31c3e66d92"
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
#line 1 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProductoForm")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProductoForm/{Id}")]
    public partial class ProductoForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .oculto{\r\n        display:none\r\n    }\r\n    .visible{\r\n        display:inherit\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>Producto</h3>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "alert" + " alert-success" + " " + (
#nullable restore
#line 14 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                 MessageCss

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "role", "alert");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<h4 class=\"alert-heading\">Producto Agregado Correctamente</h4>\r\n    ");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, "Se agrego el producto: ");
            __builder.AddContent(9, 
#nullable restore
#line 16 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                               _prod.DescripcionLarga

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, " satisfactoriamente");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                              Siguiente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Ir a Productos");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", 
#nullable restore
#line 20 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
             FormCss

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(21);
            __builder.AddAttribute(22, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                      _prod

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(25);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "container-fluid");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.AddMarkupContent(33, "<label class=\"col-sm-3\">id Prod</label>\r\n                ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-sm-9");
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                                                  _prod.IdPro

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _prod.IdPro = __value, _prod.IdPro))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _prod.IdPro));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.AddMarkupContent(48, "<label class=\"col-sm-3\">id Proveedor</label>\r\n                ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "col-sm-9");
                __builder2.AddMarkupContent(51, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(52);
                __builder2.AddAttribute(53, "class", "form-control");
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                                                  _prod.Idprovee

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _prod.Idprovee = __value, _prod.Idprovee))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _prod.Idprovee));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(62, "\r\n                ");
                __builder2.AddMarkupContent(63, "<label class=\"col-sm-3\">Descripcion</label>\r\n                ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col-sm-9");
                __builder2.AddMarkupContent(66, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(67);
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                                                  _prod.DescripcionLarga

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _prod.DescripcionLarga = __value, _prod.DescripcionLarga))));
                __builder2.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _prod.DescripcionLarga));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n                    ");
                __Blazor.POS_Blazor.Pages.ProductoForm.TypeInference.CreateValidationMessage_0(__builder2, 73, 74, 
#nullable restore
#line 40 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                            (()=>_prod.DescripcionLarga)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(75, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n            ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(80, "\r\n                ");
                __builder2.AddMarkupContent(81, "<label class=\"col-sm-3\">Margen de Ganancia</label>\r\n                ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "col-sm-9");
                __builder2.AddMarkupContent(84, "\r\n                    ");
                __Blazor.POS_Blazor.Pages.ProductoForm.TypeInference.CreateInputNumber_1(__builder2, 85, 86, "form-control", 87, 
#nullable restore
#line 46 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                                                    _prod.Frank

#line default
#line hidden
#nullable disable
                , 88, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _prod.Frank = __value, _prod.Frank)), 89, () => _prod.Frank);
                __builder2.AddMarkupContent(90, "\r\n                    ");
                __Blazor.POS_Blazor.Pages.ProductoForm.TypeInference.CreateValidationMessage_2(__builder2, 91, 92, 
#nullable restore
#line 47 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                            (()=>_prod.Frank)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(93, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n            ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(98, "\r\n                ");
                __builder2.AddMarkupContent(99, "<label class=\"col-sm-3\">Precio Compra</label>\r\n                ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "col-sm-9");
                __builder2.AddMarkupContent(102, "\r\n                    ");
                __Blazor.POS_Blazor.Pages.ProductoForm.TypeInference.CreateInputNumber_3(__builder2, 103, 104, "form-control", 105, 
#nullable restore
#line 53 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                                                    _prod.PreCompraS

#line default
#line hidden
#nullable disable
                , 106, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _prod.PreCompraS = __value, _prod.PreCompraS)), 107, () => _prod.PreCompraS);
                __builder2.AddMarkupContent(108, "\r\n                    ");
                __Blazor.POS_Blazor.Pages.ProductoForm.TypeInference.CreateValidationMessage_4(__builder2, 109, 110, 
#nullable restore
#line 54 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                            (()=>_prod.PreCompraS)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(111, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n            ");
                __builder2.OpenElement(114, "div");
                __builder2.AddAttribute(115, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(116, "\r\n                ");
                __builder2.AddMarkupContent(117, "<label class=\"col-sm-3\">Categoria</label>\r\n                ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "col-sm-9");
                __builder2.AddMarkupContent(120, "\r\n                    ");
                __Blazor.POS_Blazor.Pages.ProductoForm.TypeInference.CreateInputNumber_5(__builder2, 121, 122, "form-control", 123, 
#nullable restore
#line 60 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                                                    _prod.IdCat

#line default
#line hidden
#nullable disable
                , 124, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _prod.IdCat = __value, _prod.IdCat)), 125, () => _prod.IdCat);
                __builder2.AddMarkupContent(126, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n            ");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(131, "\r\n                ");
                __builder2.AddMarkupContent(132, "<label class=\"col-sm-3\">Marca</label>\r\n                ");
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "col-sm-9");
                __builder2.AddMarkupContent(135, "\r\n                    ");
                __Blazor.POS_Blazor.Pages.ProductoForm.TypeInference.CreateInputNumber_6(__builder2, 136, 137, "form-control", 138, 
#nullable restore
#line 66 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                                                    _prod.IdMarca

#line default
#line hidden
#nullable disable
                , 139, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _prod.IdMarca = __value, _prod.IdMarca)), 140, () => _prod.IdMarca);
                __builder2.AddMarkupContent(141, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n            ");
                __builder2.OpenElement(144, "div");
                __builder2.AddAttribute(145, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(146, "\r\n                ");
                __builder2.AddMarkupContent(147, "<label class=\"col-sm-3\">Precio Venta Menor</label>\r\n                ");
                __builder2.OpenElement(148, "div");
                __builder2.AddAttribute(149, "class", "col-sm-9");
                __builder2.AddMarkupContent(150, "\r\n                    ");
                __Blazor.POS_Blazor.Pages.ProductoForm.TypeInference.CreateInputNumber_7(__builder2, 151, 152, "form-control", 153, 
#nullable restore
#line 72 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                                                    _prod.PreVntaxMenor

#line default
#line hidden
#nullable disable
                , 154, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _prod.PreVntaxMenor = __value, _prod.PreVntaxMenor)), 155, () => _prod.PreVntaxMenor);
                __builder2.AddMarkupContent(156, "\r\n                    ");
                __Blazor.POS_Blazor.Pages.ProductoForm.TypeInference.CreateValidationMessage_8(__builder2, 157, 158, 
#nullable restore
#line 73 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                            (()=>_prod.PreVntaxMenor)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(159, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n            ");
                __builder2.OpenElement(162, "div");
                __builder2.AddAttribute(163, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(164, "\r\n                ");
                __builder2.AddMarkupContent(165, "<label class=\"col-sm-3\">Unid. Medida</label>\r\n                ");
                __builder2.OpenElement(166, "div");
                __builder2.AddAttribute(167, "class", "col-sm-9");
                __builder2.AddMarkupContent(168, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(169);
                __builder2.AddAttribute(170, "class", "form-control");
                __builder2.AddAttribute(171, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 79 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                                                  _prod.UndMedida

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(172, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _prod.UndMedida = __value, _prod.UndMedida))));
                __builder2.AddAttribute(173, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _prod.UndMedida));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(174, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(175, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(176, "\r\n            ");
                __builder2.OpenElement(177, "div");
                __builder2.AddAttribute(178, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(179, "\r\n                ");
                __builder2.AddMarkupContent(180, "<label class=\"col-sm-3\">Tipo Producto</label>\r\n                ");
                __builder2.OpenElement(181, "div");
                __builder2.AddAttribute(182, "class", "col-sm-9");
                __builder2.AddMarkupContent(183, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(184);
                __builder2.AddAttribute(185, "class", "form-control");
                __builder2.AddAttribute(186, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 85 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                                                  _prod.TipoProdcto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(187, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _prod.TipoProdcto = __value, _prod.TipoProdcto))));
                __builder2.AddAttribute(188, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _prod.TipoProdcto));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(189, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(190, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(191, "\r\n            ");
                __builder2.OpenElement(192, "div");
                __builder2.AddAttribute(193, "class", "form-group row mb-1");
                __builder2.AddMarkupContent(194, "\r\n                ");
                __builder2.OpenElement(195, "div");
                __builder2.AddAttribute(196, "class", "col-sm-12");
                __builder2.AddMarkupContent(197, "\r\n                    ");
                __builder2.OpenElement(198, "button");
                __builder2.AddAttribute(199, "class", "btn btn-primary");
                __builder2.AddAttribute(200, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "C:\NetCore MVC\ZEUS_POS\POS_Blazor\Pages\ProductoForm.razor"
                                                              GuardarProducto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(201, "Guardar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(202, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(203, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(204, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(205, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(206, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.POS_Blazor.Pages.ProductoForm
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
