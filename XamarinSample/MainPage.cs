using System;
using Xamarin.Forms;

namespace XamarinSample
{
    public class MainPage: ContentPage
    {
        Entry phoneNumberText;
        Button translateButton;
        Button callButton;

        string translatedNumber;


        public MainPage()
        {
            this.Padding = new Thickness(25, 50, 25, 25);

            StackLayout panel = new StackLayout
            {
                Spacing = 25
            };

            panel.Children.Add(new Label
            {
                Text = "Enter a name:",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            });

            panel.Children.Add(phoneNumberText = new Entry
            {
                Text = "",
            });

            panel.Children.Add(translateButton = new Button
            {
                Text = "Login"
            });

            panel.Children.Add(callButton = new Button
            {
                Text = "Register ?",
                IsEnabled = false,
            });

            translateButton.Clicked += OnTranslate;
            callButton.Clicked += (sender, e) => OnCallAsync(sender, e);

            this.Content = panel;

        }

        private void OnTranslate(object sender, EventArgs e)
        {
            string enteredNumber = phoneNumberText.Text;
            translatedNumber = TranslatorClass.ToNumber(enteredNumber);

            callButton.IsEnabled = true;
            if (!string.IsNullOrEmpty(translatedNumber))
            {
                // TODO:
            }
            else
            {
                // TODO:
            }
        }

        async System.Threading.Tasks.Task OnCallAsync(object sender, System.EventArgs e)
        {
            if (await this.DisplayAlert(
        "New Account",
        "Would you like to register ?",
        "Yes",
        "No"))
            {
                // TODO: dial the phone
            }
        }
    }
}
