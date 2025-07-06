namespace ECI.DogWalking.Forms.Shared.Menu
{
    public interface IFormNavigator
    {
        void OpenClientsForm();

        void OpenWalksForm();

        void OpenDogsForm();

        void OpenClientDogs(long clientId);

        void LogOut();

    }
}
