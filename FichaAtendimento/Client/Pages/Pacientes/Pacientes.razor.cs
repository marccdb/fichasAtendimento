using FichaAtendimento.Shared.Model;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FichaAtendimento.Client.Pages.Pacientes
{
    public partial class Pacientes
    {

        private Paciente[] pacientesArr;

        protected override async Task OnInitializedAsync()
        {
            pacientesArr = await Http.GetFromJsonAsync<Paciente[]>("api/Pacientes");
        }

        private void NewPaciente()
        {
            NavigationManager.NavigateTo("/addpaciente");
        }

    }
}
