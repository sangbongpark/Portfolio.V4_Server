#pragma checksum "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Shared\DeleteConfirmation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5534ad23c79c394e96ec5668a375ccca510d74fd"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
    public partial class DeleteConfirmation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\n        Are you sure do you want to delete?\n    ");
            }
            ));
            __builder.AddAttribute(3, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(4);
                __builder2.AddAttribute(5, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Shared\DeleteConfirmation.razor"
                            Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(7, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(9);
                __builder2.AddAttribute(10, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 7 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Shared\DeleteConfirmation.razor"
                          Color.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 7 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Shared\DeleteConfirmation.razor"
                                                    Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Shared\DeleteConfirmation.razor"
                                                                             Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(14, "Delete");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Shared\DeleteConfirmation.razor"
       

    [CascadingParameter]
    MudDialogInstance MudDialog { get; set; }

    void Submit() => MudDialog.Close(DialogResult.Ok(true));
    void Cancel() => MudDialog.Cancel();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
