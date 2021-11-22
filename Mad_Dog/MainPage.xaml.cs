using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
		}

        void onClicked(object sender, System.EventArgs e)
        {
            var cell = "^[0-9]*$";

            if (Regex.IsMatch(EntryUserPhoneNumber.Text, cell))
            {
                var Register = new NewFolder.Register()
                {
                    Username = EntryUserName.Text,
                    Password = EntryUserPassword.Text,
                    Email = EntryUserEmail.Text,
                    PhoneNumber = EntryUserPhoneNumber.Text,
                };

                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Congrats", "Success", "Yes", "Cancel");

                    if (result)
                        await Navigation.PushModalAsync(new Login());
                });
            }
            else
            {
                lblPhoneNumberError.Text = "Please enter only numbers";
            }        
        }
    }
}
