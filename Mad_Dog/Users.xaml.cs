using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mad_Dog
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Users : ContentPage
    {

        public Users()
        {
            InitializeComponent();
            GetRegistration();
        }

        public async void GetRegistration()
        {
            var UserViewModel = new NewFolder.UserViewModel();
            UserViewModel.UsersList = await Service.UserService.GetAllStatements();
            LV.ItemsSource = UserViewModel.UsersList.ToList();
        }
    }
}