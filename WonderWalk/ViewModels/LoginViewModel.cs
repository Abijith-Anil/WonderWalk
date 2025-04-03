using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace YourAppName.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _username;

        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private string _errorMessage;

        [ObservableProperty]
        private bool _isLoggingIn;

        [RelayCommand]
        private async Task Login()
        {
            IsLoggingIn = true;
            ErrorMessage = string.Empty; // Clear any previous errors

            // Simulate a login delay (replace with actual logic)
            await Task.Delay(1000);

            // Placeholder login logic (replace with real logic)
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                ErrorMessage = "Username and password are required.";
            }
            else if (Username == "test" && Password == "password")
            {
                // Successful login (navigate to main page)
                IsLoggingIn = false;
                await Shell.Current.GoToAsync("//MainPage"); // Replace with your main page route
            }
            else
            {
                ErrorMessage = "Invalid username or password.";
            }
            IsLoggingIn = false;
        }
    }
}