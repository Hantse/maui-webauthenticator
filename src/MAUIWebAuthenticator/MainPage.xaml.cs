using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;

namespace MAUIWebAuthenticator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void StartAuthenticateAsync(object sender, EventArgs e)
        {
            var authResult = await WebAuthenticator.AuthenticateAsync(
                            new Uri("https://mysuperurl.dotnet"),
                            new Uri("mysuperdomain://"));

        }
    }
}
