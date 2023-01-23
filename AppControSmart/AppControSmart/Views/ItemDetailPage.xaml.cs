using AppControSmart.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppControSmart.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}