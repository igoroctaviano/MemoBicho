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
            var authors = new Label()
            {
                Text = "Ilustração por Camila Binder",
                FontSize = 20,
                TextColor = Color.FromHex("#8BC34A"),
                HorizontalTextAlignment = TextAlignment.Center,
            };
            var tap = new TapGestureRecognizer();
            tap.Tapped += delegate { Device.OpenUri(new Uri("www.google.com")); };
            authors.GestureRecognizers.Add(tap);

            var restartButton = new Button { Text = "Voltar ao início!", FontSize = 25, BackgroundColor = Color.FromHex("#8BC34A") };
            restartButton.Clicked += delegate
            {
                this.Navigation.PopModalAsync();
                Device.BeginInvokeOnMainThread(() => this.Navigation.PushModalAsync(new MainMenu()));
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Padding = 20,
                Children = {
                    new Label
                    {
                        Text = "MemoBicho",
                        TextColor = Color.FromHex("#8BC34A"),
                        FontSize = 40,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalTextAlignment = TextAlignment.Center
                    },
                    new Label
                    {
                        Text = "Parabéns!",
                        FontSize = 25,
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
                                FontSize = 30,
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
                    },
                    new StackLayout
                    {
                        Padding = 20,
                        Children = { authors }
                    }
                }
            };
        }
    }
}
