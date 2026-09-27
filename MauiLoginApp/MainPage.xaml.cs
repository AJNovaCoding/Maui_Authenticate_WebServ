namespace MauiLoginApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object? sender, EventArgs e)
        {
         //Get the username and password from the entry fields
         string username = txtUserId.Text;
         string password = txtPassword.Text;

            //Create an instance of USerAuthentication
            var userAuth = new DataAccess.UserAuthentication();

            //Authenticate the user
            bool isAuthenticated = userAuth.AuthenticateUser(username, password);

            //Display the result of the authentication
            if (isAuthenticated)
            {
                DisplayAlert("Login Successful", "You have been successfully authenticated.", "OK");
            }
            else
            {
                DisplayAlert("Login Failed", "Invalid username or password.", "OK");
            }
        }
    }
}
