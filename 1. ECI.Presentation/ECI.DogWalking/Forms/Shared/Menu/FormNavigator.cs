namespace ECI.DogWalking.Forms.Shared.Menu
{
    using ECI.DogWalking.Forms.Admin;
    using Microsoft.Extensions.DependencyInjection;
    using System.Windows.Forms;

    public class FormNavigator : IFormNavigator
    {
        private readonly IServiceProvider _serviceProvider;

        public FormNavigator(IServiceProvider sp) => _serviceProvider = sp;

        public void OpenClientDogs(long clientId)
        {
            var form = _serviceProvider.GetRequiredService<DogsForm>();
            form.GetDogsByClient(clientId);
            form.ShowDialog();
        }

        public void OpenClientsForm()
        {
            var form = _serviceProvider.GetRequiredService<ClientsForm>();
            form.Show();
        }

        public void OpenDogsForm()
        {
            var form = _serviceProvider.GetRequiredService<DogsForm>();
            form.Show();
        }
    }
}
