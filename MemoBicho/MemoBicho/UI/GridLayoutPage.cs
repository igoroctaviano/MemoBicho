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
        int countTappedAnimals = 0;

        List<string> tappedAnimals = new List<string>();
        List<string> tappedPairAnimals = new List<string>();

        Frame[] animals = {
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
                                              Opacity = 1 } }
        };

        Grid grid = new Grid();

        StackLayout layout = new StackLayout
        {
            Orientation = StackOrientation.Vertical,
            Padding = 10
        };

        TapGestureRecognizer tap = new TapGestureRecognizer();

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
                string animal = frame.ClassId;

                if (image.Opacity == 0) // If it's dark
                {
                    tappedPairAnimals.Add(animal); // Add animal to the pair list

                    image.Opacity = 1; // Show animal and save
                    frame.Content = image;
                    sender = frame;

                    if (tappedPairAnimals.Count == 2) // If 2 tiles tapped
                    {
                        if (tappedAnimals.Contains(animal)) // Then check for win
                        {
                            DisplayAlert("Working!", "Nice!", "Ok!"); // Congratulations!
                            /*if (countTappedAnimals == animals.Length - 1) // If all animals matched
                            {
                                countTappedAnimals = 0; // Then Reset animals
                                tappedAnimals.Clear();
                            
                                NewGrid(); // And get a new grid for the user
                            }*/
                        }
                    }
                    else // If not 2 tiles tapped yet 
                        tappedAnimals.Add(animal); // Add animal to the tappedList
                }
            };
            tap.Tapped += (object sender, EventArgs e) =>
            {
                Frame frame = (Frame)sender;
                Image image = (Image)frame.Content;
                string animal = frame.ClassId;

                if (tappedPairAnimals.Count == 2 && tappedAnimals.Contains(animal) != true) // If 2 tiles tapped
                {
                    for (int i = 0; i < animals.Length; i++)
                    {
                        if (animals[i].ClassId == tappedPairAnimals.ElementAt(0) || animals[i].ClassId == tappedPairAnimals.ElementAt(1)) // Reset just the last non-matched pair animals
                        {
                            Task.Delay(500).Wait();
                            animals[i].Content.Opacity = 0; // Hide the tapped animals again
                            tappedAnimals.Remove(animals[i].ClassId); // Remove those different animals from the tappedList
                        }
                    }
                    tappedPairAnimals.Clear(); // Clear tappedPair
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

            var startButton = new Button { Text = "Começar!" };
            startButton.Clicked += delegate
            {
                // Hide animals
                for (int i = 0; i < animals.Length; i++)
                    animals[i].Content.Opacity = 0;
            };

            layout.Children.Add(grid);
            layout.Children.Add(startButton);
            Content = layout;
        }
    }
}
