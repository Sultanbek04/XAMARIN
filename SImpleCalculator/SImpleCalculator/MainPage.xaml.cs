using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SImpleCalculator
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();

      var backgroundImage = new Image();
      backgroundImage.Source = "SimpleCalcBackgroundImg.jpg";
      backgroundImage.HeightRequest = Height;
      backgroundImage.WidthRequest = Width;

      body.WidthRequest = Width;
      body.HeightRequest = Height;
      body.Children.Add(backgroundImage);

     

      for (int i = 0; i < 10; ++i)
      {
        Label label = new Label();
        label.Text = "Hello";
        label.FontSize = 30;
        spLog.Children.Add(label);
      }





    }
  }
}
