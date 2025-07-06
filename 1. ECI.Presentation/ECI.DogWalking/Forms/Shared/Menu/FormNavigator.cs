namespace ECI.DogWalking.Forms.Shared.Menu
{
    using ECI.DogWalking.Forms.Admin;
    using ECI.DogWalking.Forms.Walks;
    using Microsoft.Extensions.DependencyInjection;
    using System.Windows.Forms;

    public class FormNavigator : IFormNavigator
    {
        private readonly IServiceProvider _serviceProvider;

        public FormNavigator(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;

        public void OpenClientDogs(long clientId)
        {
            var form = _serviceProvider.GetRequiredService<DogsForm>();
            form.clientId = clientId;
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

        public void OpenWalksForm()
        {
            var form = _serviceProvider.GetRequiredService<WalksForm>();
            form.Show();
        }

        public void LogOut()
        {
            var form = _serviceProvider.GetRequiredService<LoginForm>();
            form.Show();
        }
    }
}
