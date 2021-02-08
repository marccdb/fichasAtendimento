using FichaAtendimento.Shared.Model;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FichaAtendimento.Client.Pages.Pacientes
{
    public partial class RemovePaciente
    {

        [Parameter]
        public string id { get; set; }
        Paciente newPaciente = new Paciente();

        protected override async Task OnInitializedAsync()
        {
            newPaciente = await Http.GetFromJsonAsync<Paciente>($"api/Pacientes/{id}");
        }


        private async Task DeletePaciente()
        {
            await Http.DeleteAsync($"api/Pacientes/{id}");
            NavigationManager.NavigateTo("Pacientes");
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("Pacientes");
        }

    }
}
