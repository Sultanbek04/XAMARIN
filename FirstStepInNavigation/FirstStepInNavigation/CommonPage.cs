﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FirstStepInNavigation
{
  class CommonPage : ContentPage
  {
    public CommonPage()
    {
      Title = "Common Page";
      Button backButton = new Button
      {
        Text = "Назад",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
      };
      backButton.Clicked += BackButton_Click;
      Content = backButton;
    }
    private async void BackButton_Click(object sender, EventArgs e)
    {
      await Navigation.PopAsync();
    }

  }
}
