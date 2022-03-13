using InputXAMARIN.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace InputXAMARIN.Views
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