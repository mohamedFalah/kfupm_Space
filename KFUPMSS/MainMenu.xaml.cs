using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace KFUPMSS
{
    public partial class MainMenu : MasterDetailPage
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (IsPresented)
                IsPresented = false;
            else
                IsPresented = true;
        }
    }
}
