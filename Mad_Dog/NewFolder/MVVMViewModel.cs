using Mad_Dog.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mad_Dog.NewFolder
{
    public class MVVMViewModel : INotifyPropertyChanged
    {
        public MVVMViewModel()
        {

            LaunchSaveContactCommand = new Command(async ()=> await SaveContact());
        }

        string username = "";
        string password = "";
        string email = "";
        string cell = "";
        bool bestFriend;

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = ""/*Name of property*/)
        {
            //Check if propert not null then invoke me as sender
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public string DisplayMessage
        {
            get { return $"Your new friend is names {username} and " + $"{(bestFriend ? "is" : "is not")} your best friend"; }
        }

        public string Username
        {
            get { return username; }
            set 
            { 
                username = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Cell
        {
            get { return cell; }
            set { cell = value; }
        }

        public bool BestFriend
        {
            get { return bestFriend; }
            set 
            { 
                bestFriend = value; 
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayMessage));
            }
        }

        public Command LaunchSaveContactCommand { get; }

        async Task SaveContact()
        {
            var Register = new NewFolder.Users()
            {
                Username = Username,
                Password = Password,
                Email = Email,
                Cell = Cell,
            };


            await UserService.InsertAsync(Register);

            Device.BeginInvokeOnMainThread(async () =>
            {
                await Application.Current.MainPage.DisplayAlert("Congrats", "Success", "Yes", "Cancel");

                await Xamarin.Forms.Application.Current.MainPage.Navigation.PushModalAsync(new Mad_Dog.Users());
            });
        }

    }
}
