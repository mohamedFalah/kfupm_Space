using System;
using System.Windows.Input;
using KFUPMSS.Services;
using Xamarin.Forms;


namespace KFUPMSS.ViewModel
{
    public class SignUpViewModel
    {

        ApiServices apiServices = new ApiServices();

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ID { get; set; }

        public string Password { get; set; }

        public String Message { get; set;  }

        public ICommand SignUpCommand
        {

            get
            {

                return new Command(async () =>
                {

                    var isSuccess = await apiServices.RegisterAsync(FirstName, LastName, ID, Password);

                    if (isSuccess)
                        Message = "you have been registeered Successfully";
                    else
                        Message = "Registrations is not completed";

                });


            }

        }

    }
}
