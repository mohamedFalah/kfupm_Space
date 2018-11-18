using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using KFUPMSS.View;

namespace KFUPMSS
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }


        async void NavigateToSignUpPage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new SignUp()));
        }
    }
}
