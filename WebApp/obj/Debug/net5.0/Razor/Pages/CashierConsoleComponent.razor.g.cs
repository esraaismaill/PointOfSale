#pragma checksum "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\Pages\CashierConsoleComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "257792cb0fa1aa2abac9bbadfa506017066ce7c8"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\_Imports.razor"
using WebApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\_Imports.razor"
using UseCases;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\Pages\CashierConsoleComponent.razor"
           [Authorize(Policy = "CashierOnly")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cashier_console")]
    public partial class CashierConsoleComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\Pages\CashierConsoleComponent.razor"
 if (!string.IsNullOrWhiteSpace(cashierName))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content px-4");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "<div class=\"col-7 hero_detail-box\"><h3>Cashier\'s Console</h3></div>\r\n        ");
            __builder.AddMarkupContent(5, "<div class=\"col-2\"><label for=\"cashier\">Cashier Name:</label></div>\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-3");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "id", "cashier");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\Pages\CashierConsoleComponent.razor"
                                                                                  cashierName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cashierName = __value, cashierName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n    <br>\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "row");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-4");
            __builder.OpenComponent<WebApp.Controls.SelectProductForSellingComponent>(21);
            __builder.AddAttribute(22, "OnProductSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CoreBusiness.Product>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CoreBusiness.Product>(this, 
#nullable restore
#line 19 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\Pages\CashierConsoleComponent.razor"
                                                                 SelectProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n            <br>\r\n            ");
            __builder.OpenComponent<WebApp.Controls.SellProductComponent>(24);
            __builder.AddAttribute(25, "CashierName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\Pages\CashierConsoleComponent.razor"
                                                cashierName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "SelectedProduct", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CoreBusiness.Product>(
#nullable restore
#line 22 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\Pages\CashierConsoleComponent.razor"
                                                   selectedProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "OnProductSold", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CoreBusiness.Product>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CoreBusiness.Product>(this, 
#nullable restore
#line 23 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\Pages\CashierConsoleComponent.razor"
                                                 SellProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col");
            __builder.AddMarkupContent(31, "<br>\r\n            ");
            __builder.OpenComponent<WebApp.Controls.TodayTransactionsComponent>(32);
            __builder.AddComponentReferenceCapture(33, (__value) => {
#nullable restore
#line 27 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\Pages\CashierConsoleComponent.razor"
                                              transactionComponent = (WebApp.Controls.TodayTransactionsComponent)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\Pages\CashierConsoleComponent.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\esraa\OneDrive\Desktop\PointOfSale\WebApp\Pages\CashierConsoleComponent.razor"
           
private TodayTransactionsComponent transactionComponent;

    private Product selectedProduct;
    private string cashierName;

    [CascadingParameter]
    private Task<AuthenticationState> _authState { get; set; }

    private AuthenticationState authState;

    protected override async Task OnInitializedAsync()
    {
        authState = await _authState;
        cashierName = authState.User.Identity.Name;
    }

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);

        if (firstRender)
        {
            transactionComponent.LoadTransactions(cashierName);
        }
    }

    private void SelectProduct(Product product)
    {
        selectedProduct = product;
    }

    private void SellProduct(Product product)
    {
        transactionComponent.LoadTransactions(cashierName);
    }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
