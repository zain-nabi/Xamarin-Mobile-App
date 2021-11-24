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
    public partial class MVVM : ContentPage
    {
        public MVVM()
        {
            InitializeComponent();
            BindingContext = new NewFolder.MVVMViewModel();
        }
    }
}