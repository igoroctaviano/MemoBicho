using MemoBicho.Levels.One;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MemoBicho
{
    public class MainMenu : ContentPage
    {
        Color backgroundColor = Color.FromHex("#8BC34A");
        Color buttonBackgroundColor = Color.FromHex("#689F38");
        Color textColor = Color.FromHex("#33691E");

        public MainMenu()
        {
            BackgroundColor = backgroundColor;

            var button = new Button()
            {
                Text = "Jogar",
                FontSize = 25,
                BackgroundColor = buttonBackgroundColor
            };
            button.Clicked += (object sender, EventArgs e) => 
            { App.Current.MainPage = new GridLayoutPage(); };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Padding = 50,
                Children = {
                    new StackLayout
                    {
                        Padding = 10,
                        Children =
                        {
                            new Label
                            {
                                Text = "MemoBicho", FontSize = 60,
                                HorizontalTextAlignment = TextAlignment.Center,
                                FontAttributes = FontAttributes.Bold,
                                TextColor = textColor
                            }
                        }
                    },
                    new StackLayout
                    {
                        Padding = 60,
                        Children = {
                            new Image
                            {
                                Source = "front.png",
                                HorizontalOptions = LayoutOptions.Center
                            }
                        }
                    },
                    button
                },
            };
        }
    }
}
