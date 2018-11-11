using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace KFUPMSS
{
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }

        async void NavigateToMainPage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}
