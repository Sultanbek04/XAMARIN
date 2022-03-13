using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstStepTriggers
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();

      Entry entry = new Entry();

      var trigger = new Trigger(typeof(Entry))
      {
        Property = Entry.IsFocusedProperty,
        Value = true
      };
      trigger.Setters.Add(new Setter
      {
        Property = Entry.BackgroundColorProperty,
        Value = Color.Green
      });
      trigger.Setters.Add(new Setter
      {
        Property = Entry.TextColorProperty,
        Value = Color.Red
      });
      trigger.EnterActions.Add(new FocusTriggerAction());
      trigger.ExitActions.Add(new FocusTriggerAction());

      var trigger2 = new Trigger(typeof(Entry))
      {
        Property= Entry.TextColorProperty,
        Value=Color.Green,
      };

      trigger2.EnterActions.Add(new ColorTextTriggerAction());
      trigger2.ExitActions.Add(new ColorTextTriggerAction());


      entry.Triggers.Add(trigger);
      entry.Triggers.Add(trigger2);

      Content = new StackLayout
      {
        Children = { entry }
      };

    }
    public class FocusTriggerAction : TriggerAction<Entry>
    {
      protected override void Invoke(Entry sender)
      {
        if (sender.IsFocused)
          sender.FadeTo(1);
        else
          sender.FadeTo(0.5);
      }
    }

    public class ColorTextTriggerAction : TriggerAction<Entry>
    {
      protected override void Invoke(Entry sender)
      {
        if (sender.TextColor == Color.Red)
        {
          sender.FontSize = 30;
        }
        else
        {
          sender.FontSize = 10;
        }
      }
    }
  }
}
