namespace ECI.DogWalking.Forms.Shared.Menu
{
    public interface IFormNavigator
    {
        void OpenClientsForm();

        void OpenDogsForm();

        void OpenClientDogs(long clientId);

    }
}
