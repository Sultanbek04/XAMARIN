using InputXAMARIN.Models;
using InputXAMARIN.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InputXAMARIN.Views
{
  public partial class NewItemPage : ContentPage
  {
    public Item Item { get; set; }

    public NewItemPage()
    {
      InitializeComponent();
      BindingContext = new NewItemViewModel();
    }
  }
}