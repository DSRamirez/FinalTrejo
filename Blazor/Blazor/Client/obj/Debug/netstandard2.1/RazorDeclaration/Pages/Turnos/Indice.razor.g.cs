// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Client.Pages.Turnos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\daisr\OneDrive\Documentos\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daisr\OneDrive\Documentos\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\daisr\OneDrive\Documentos\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\daisr\OneDrive\Documentos\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\daisr\OneDrive\Documentos\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\daisr\OneDrive\Documentos\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\daisr\OneDrive\Documentos\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\daisr\OneDrive\Documentos\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using Blazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\daisr\OneDrive\Documentos\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using Blazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\daisr\OneDrive\Documentos\GitHub\FinalTrejo\Blazor\Blazor\Client\_Imports.razor"
using Blazor.Shared.Modelos;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/indice-turnos")]
    public partial class Indice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\daisr\OneDrive\Documentos\GitHub\FinalTrejo\Blazor\Blazor\Client\Pages\Turnos\Indice.razor"
      
    Turnos[] turnos { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await CargarTurnos();
    }

    async Task CargarTurnos()
    {
        turnos = await Http.GetFromJsonAsync<Turnos[]>("turnos");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
