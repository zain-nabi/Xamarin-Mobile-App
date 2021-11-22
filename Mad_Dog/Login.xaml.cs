using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mad_Dog
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void SignUpRedirect(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

        async void LoginRedirect(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Login());
        }
    }
}