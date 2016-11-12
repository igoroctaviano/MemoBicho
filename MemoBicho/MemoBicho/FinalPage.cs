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
        Color backgroundColor = Color.FromHex("#8BC34A");
        Color buttonBackgroundColor = Color.FromHex("#689F38");
        Color textColor = Color.FromHex("#33691E");

        public FinalPage()
        {
            BackgroundColor = backgroundColor;

            var authors = new Label()
            {
                Text = "Ilustração por Camila Binder",
                FontSize = 22,
                TextColor = textColor,
                HorizontalTextAlignment = TextAlignment.Center,
            };
            var tap = new TapGestureRecognizer();
            tap.Tapped += delegate { Device.OpenUri(new Uri("http://lattes.cnpq.br/1533775666021835")); };
            authors.GestureRecognizers.Add(tap);

            var restartButton = new Button
            {
                Text = "Voltar ao início!",
                FontSize = 25,
                BackgroundColor = buttonBackgroundColor
            };
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
                        TextColor = textColor,
                        FontSize = 40,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalTextAlignment = TextAlignment.Center
                    },
                    new Label
                    {
                        Text = "Parabéns!",
                        FontSize = 25,
                        TextColor = textColor,
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
                                TextColor = textColor,
                                HorizontalTextAlignment = TextAlignment.Center
                            }
                        }
                    },
                    new StackLayout
                    {
                        Padding = 20,
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.Center,
                        BackgroundColor = buttonBackgroundColor,
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
