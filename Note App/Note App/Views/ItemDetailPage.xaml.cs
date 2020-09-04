using System.ComponentModel;
using Xamarin.Forms;
using Note_App.ViewModels;

namespace Note_App.Views
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