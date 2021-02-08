using System.Net.Http.Json;
using System.Threading.Tasks;
using FichaAtendimento.Shared.Model;
using Microsoft.AspNetCore.Components;

namespace FichaAtendimento.Client.Pages.Fichas
{
    public partial class EditFicha
    {
        [Parameter]
        public string id { get; set; }
        Ficha newFicha = new Ficha();

        protected override async Task OnInitializedAsync()
        {
            newFicha = await Http.GetFromJsonAsync<Ficha>($"api/Fichas/{id}");
        }


        private async Task UpdateFicha()
        {
            await Http.PutAsJsonAsync<Ficha>($"api/Fichas/{id}", newFicha);
            NavigationManager.NavigateTo("fichasatendimento");
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("fichasatendimento");
        }

    }
}
