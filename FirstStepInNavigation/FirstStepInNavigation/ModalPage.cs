using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FirstStepInNavigation
{
  public class ModalPage : ContentPage
  {
    public ModalPage()
    {
      Title = "Modal Page";
    
     
      Button backButton = new Button
      {
        Text = "НазаC",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
      };
      backButton.Clicked += BackButton_Click;

      Content = backButton;
    }
    private async void BackButton_Click(object sender, EventArgs e)
    {
      await Navigation.PopModalAsync();
    }
  }
}