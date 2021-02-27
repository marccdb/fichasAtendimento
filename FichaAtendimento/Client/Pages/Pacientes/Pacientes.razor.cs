using FichaAtendimento.Shared.Model;
using System.Threading.Tasks;
using System.Linq;


namespace FichaAtendimento.Client.Pages.Pacientes
{
    public partial class Pacientes
    {

        private IOrderedEnumerable<Paciente> pacientesArr;

        protected override async Task OnInitializedAsync()
        {
            pacientesArr = await _helper.GetPacientes();
        }

        private void NewPaciente()
        {
            NavigationManager.NavigateTo("/addpaciente");
        }

    }
}
