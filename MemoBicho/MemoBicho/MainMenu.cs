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
        public MainMenu()
        {
            var button = new Button()
            {
                Text = "Jogar",
                FontSize = 25,
                BackgroundColor = Color.FromHex("#8BC34A")
            };
            button.Clicked += (object sender, EventArgs e) => 
            { App.Current.MainPage = new GridLayoutPage(); };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Padding = 20,
                Children = {
                    new StackLayout
                    {
                        Padding = 10,
                        Children = {
                            new Label
                            {
                                Text = "MemoBicho", FontSize = 40,
                                HorizontalTextAlignment = TextAlignment.Center,
                                FontAttributes = FontAttributes.Bold,
                                TextColor = Color.FromHex("#8BC34A"),
                            }
                        }
                    },
                    new StackLayout
                    {
                        Padding = 50,
                        Children = {
                            new Image
                            {
                                Source = "front.png",
                                HorizontalOptions = LayoutOptions.Center,
                            }
                        }
                    },
                    button
                },
            };
        }
    }
}
