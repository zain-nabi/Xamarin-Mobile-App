using Mad_Dog.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mad_Dog
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ServicePointManager.ServerCertificateValidationCallback += (o, cert, chain, errors) => true;
        }

        async void onClicked(object sender, System.EventArgs e)
        {
            var cell = "^[0-9]*$";

            if (Regex.IsMatch(EntryUserPhoneNumber.Text, cell))
            {
                var Register = new NewFolder.Users()
                {
                    Username = EntryUserName.Text,
                    Password = EntryUserPassword.Text,
                    Email = EntryUserEmail.Text,
                    Cell = EntryUserPhoneNumber.Text,
                };

                
                await UserService.InsertAsync(Register);

                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Congrats", "Success", "Yes", "Cancel");

                    if (result)
                        await Navigation.PushModalAsync(new MVVM());
                });
            }
            else
            {
                lblPhoneNumberError.Text = "Please enter only numbers";
            }        
        }
    }
}
