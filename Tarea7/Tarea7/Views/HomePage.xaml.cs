using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea7.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea7.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            this.BindingContext = new HomePageViewModel();
        }
    }
}