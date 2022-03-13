using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstStepInNavigation
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
      Title = "Main Page";
      Button toCommonPageBtn = new Button
      {
        Text = "На обычную страницу",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.CenterAndExpand
      };
      toCommonPageBtn.Clicked += ToCommonPage;

      Button toModalPageBtn = new Button
      {
        Text = "На модальную страницу",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.CenterAndExpand
      };
      toModalPageBtn.Clicked += ToModalPage;

      Content = new StackLayout { Children = { toCommonPageBtn, toModalPageBtn } };
    }

    private async void ToModalPage(object sender, EventArgs e)
    {
      await Navigation.PushModalAsync(new ModalPage());
    }
    private async void ToCommonPage(object sender, EventArgs e)
    {
      await Navigation.PushAsync(new CommonPage());
    }
  }
}

