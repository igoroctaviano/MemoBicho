using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MemoBicho.UI
{
    class GridLayoutPage : ContentPage
    {
        List<string> matchedAnimals = new List<string>();
        List<Frame> tappedPairAnimals = new List<Frame>();

        Grid grid = new Grid();

        StackLayout layout = new StackLayout
        {
            Orientation = StackOrientation.Vertical,
            Padding = 10
        };

        TapGestureRecognizer tap = new TapGestureRecognizer();

        Frame[] animals = {
            new Frame { ClassId = "Duck",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = ImageSource.FromFile("duck.png"),
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Bulldog",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = ImageSource.FromFile("bulldog.png"),
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Giraffe",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = ImageSource.FromFile("giraffe.png"),
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Duck",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = ImageSource.FromFile("duck.png"),
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Giraffe",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = ImageSource.FromFile("giraffe.png"),
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Bulldog",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = ImageSource.FromFile("bulldog.png"),
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } }
        };

        public GridLayoutPage()
        {
            BackgroundColor = Color.Green;

            layout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Padding = 10
            };

            tap = new TapGestureRecognizer();
            tap.Tapped += (object sender, EventArgs e) =>
            {
                Frame frame = (Frame)sender;
                Image image = (Image)frame.Content;
                string animal = frame.ClassId; // Each represents an Animal

                if (image.Opacity == 0 && tappedPairAnimals.Contains(frame) == false) // If it's dark (clickable) and not cliked yet
                {
                    // Show the Animal and Update the frame (set the frame)
                    image.Opacity = 1;
                    frame.Content = image;
                    sender = frame;

                    // Add Animal Frame to the pair list
                    tappedPairAnimals.Add(frame);

                    if (tappedPairAnimals.Count == 2) // If 2 frames were tapped
                    {
                        if (tappedPairAnimals.First().ClassId == tappedPairAnimals.Last().ClassId) // Then check for match
                        {
                            matchedAnimals.Add(tappedPairAnimals.First().ClassId);

                            if (matchedAnimals.Count == animals.Length - 1) // Win if all animals were found
                            {
                                DisplayAlert("Parabéns", "Você completou esse desafio.", "Ok!");
                                tappedPairAnimals.Clear();
                                matchedAnimals.Clear();
                            }
                            else
                            {
                                DisplayAlert(animal, "Sabia que esse animal é ...", "Continuar!");
                                tappedPairAnimals.Clear();
                            }
                        }
                        else // If they dont match, turn both dark (clickable) again
                        {
                            foreach (Frame animalFrame in tappedPairAnimals.ToList())
                            {
                                for (int i = 0; i < animals.Length; i++)
                                {
                                    if (animals[i].ClassId == animalFrame.ClassId)
                                        animals[i].Content.Opacity = 0;
                                }
                            }
                            tappedPairAnimals.Clear();
                        }
                    }
                }
            };

            NewGrid();
        }

        private void NewGrid()
        {
            grid = new Grid();
            for (var i = 0; i < animals.Length; i++)
            {
                var column = i % 2;
                var row = (int)Math.Floor(i / 2f);

                animals[i].GestureRecognizers.Add(tap);
                grid.Children.Add(animals[i], column, row);
                if (column % 2 == 0)
                    grid.RowDefinitions.Add(new RowDefinition { Height = 120 });
            }
            layout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Padding = 10
            };

            var label = new Label()
            {
                Text = "MemoBicho",
                TextColor = Color.FromHex("#CDDC39"),
                FontSize = 35,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center
            };

            var startButton = new Button { Text = "Começar!", BackgroundColor = Color.FromHex("#8BC34A") };
            startButton.Clicked += delegate
            {
                // Hide animals
                for (int i = 0; i < animals.Length; i++)
                {
                    animals[i].Content.Opacity = 0;
                    Task.Delay(1000);
                }
            };

            layout.Children.Add(label);
            layout.Children.Add(grid);
            layout.Children.Add(startButton);
            Content = layout;
        }
    }
}
