using FichaAtendimento.Shared.Model;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FichaAtendimento.Client.Pages.Fichas
{
    public partial class RemoveFicha
    {
        [Parameter]
        public string id { get; set; }
        Ficha newFicha = new Ficha();

        protected override async Task OnInitializedAsync()
        {
            newFicha = await Http.GetFromJsonAsync<Ficha>($"api/Fichas/{id}");
        }


        private async Task DeleteFicha()
        {
            await Http.DeleteAsync($"api/Fichas/{id}");
            NavigationManager.NavigateTo("fichasatendimento");
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("fichasatendimento");
        }

    }
}
