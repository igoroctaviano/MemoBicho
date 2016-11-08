using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MemoBicho
{
    public class FinalPage : ContentPage
    {
        public FinalPage()
        {
            var restartButton = new Button { Text = "Repetir todos os níveis", BackgroundColor = Color.FromHex("#8BC34A") };
            restartButton.Clicked += delegate { this.Navigation.PopToRootAsync(); };     

            Content = new StackLayout
            {
                Padding = 20,
                Children = {
                    new Label
                    {
                        Text = "MemoBicho",
                        TextColor = Color.FromHex("#8BC34A"),
                        FontSize = 35,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalTextAlignment = TextAlignment.Center
                    },
                    new Label
                    {
                        Text = "Parabéns!",
                        TextColor = Color.FromHex("#8BC34A"),
                        HorizontalTextAlignment = TextAlignment.Center
                    },
                    new StackLayout
                    {
                        Padding = 20,   
                        Children =
                        {
                            new Label
                            {
                                Text = "Você completou todos os desafios.",
                                TextColor = Color.FromHex("#8BC34A"),
                                HorizontalTextAlignment = TextAlignment.Center
                            }
                        }
                    },
                    new StackLayout
                    {
                        Padding = 20,
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.Center,
                        BackgroundColor = Color.FromHex("#8BC34A"),
                        Children = { restartButton }
                    }
                }
            };
        }
    }
}
