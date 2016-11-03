﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MemoBicho.UI
{
    class GridLayoutPage : ContentPage
    {
        #region Level 1 Content
        // Animals
        Frame[] animals = {
            new Frame { ClassId = "Cachorro",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "bulldog.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Lobo",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "wolf.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Gato",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "cat.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Leão",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "lion.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Cachorro",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "bulldog.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Gato",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "cat.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Leão",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "lion.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Lobo",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "wolf.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } }
        };

        // Content
        Dictionary<string, string> animalsCuriosities = new Dictionary<string, string>
        {
            { "Gato", "Os gatos não possuem glândulas sudoríparas espalhadas pelo corpo igual os humanos, "
                + "eles suam pelas patas. Glândulas sudoríparas são as glândulas que produzem suor." },
            { "Leão", "As fêmeas são as principais responsáveis pela caça, geralmente em grupos, enquanto os machos cuidam de seus territórios." },
            { "Cachorro", "A impressão digital dos cachorros se encontra no focinho. Cada animal tem uma impressão diferente." },
            { "Lobo", "..." }
        };
        Dictionary<string, string> animalsKnowledge = new Dictionary<string, string>
        {
            { "GatoLeão", "São felinos; Vibrisas (pelos sensoriais). Ahhh você sabe o que são Vibrisas? "
                + "São os bigodes dos mamíferos eles ajudam o animal a se orientar em relação ao meio em que vivem." },
            { "GatoCachorro", "domesticados; dentes afiados; caçadores;" },
            { "GatoLobo", "dentes afiados." },
            { "LeãoCachorro", "Ambos são mamíferos, um é felino o outro é canídeo, ambos apresentam dentes afiados, cachorro domesticado, leão não." },
            { "LeãoLobo", "caçadores; carnívoros; convivência em bando." },
            { "CachorroLobo", "a musculatura da face é adaptada para pegar a presa." }
        };
        #endregion

        #region Attributes
        bool isPlaying = false;
        List<string> matchedAnimals = new List<string>();
        List<Frame> tappedPairAnimals = new List<Frame>();
        Label timeLabel = new Label { HorizontalOptions = LayoutOptions.Center };
        TapGestureRecognizer tap = new TapGestureRecognizer();
        private struct AnimalVisibility
        {
            public const double Hide = 0;
            public const double Show = 1;
        }
        #endregion

        public GridLayoutPage()
        {
            //BackgroundImage = "jungle.png";

            var layout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Padding = 10
            };

            this.tap = new TapGestureRecognizer();
            this.tap.Tapped += (object sender, EventArgs e) => // If somebody tap the animal frame (do some action)
             {
                 var frame = (Frame)sender;
                 var image = (Image)frame.Content;
                 string animal = frame.ClassId; // The frame class id holds the animal name

                if (image.Opacity == 0 && this.tappedPairAnimals.Contains(frame) == false) // If it's dark (clickable) and not cliked yet
                {
                     // Show the Animal and Update the frame(set the frame)
                     image.Opacity = AnimalVisibility.Show; // Set opacity to show the animal
                     frame.Content = image;
                     sender = frame;

                    // Add Animal Frame to the pair list
                    this.tappedPairAnimals.Add(frame);

                     if (this.tappedPairAnimals.Count == 2) // If 2 frames were tapped
                    {
                         string firstAnimal = this.tappedPairAnimals.First().ClassId, secondAnimal = this.tappedPairAnimals.Last().ClassId;
                         if (firstAnimal == secondAnimal) // Then check for match
                         {
                             this.matchedAnimals.Add(this.tappedPairAnimals.Last().ClassId);

                             if (this.matchedAnimals.Count == ((this.animals.Length) / 2)) // Win if all animals were found
                             {
                                 this.isPlaying = false; // Stop the timer
                                 DisplayAlert(animal, this.GetAnimalCuriosity(animal), "Continuar!").ContinueWith(t =>
                                 {
                                     DisplayAlert("Parabéns", "Você completou esse desafio com o tempo: " + this.timeLabel.Text + ".", "Próximo nível!").ContinueWith(w =>
                                     { Device.BeginInvokeOnMainThread(() => this.Navigation.PushModalAsync(new QuizView())); }, TaskScheduler.FromCurrentSynchronizationContext());
                                 }, TaskScheduler.FromCurrentSynchronizationContext());

                                 this.tappedPairAnimals.Clear();
                                 this.matchedAnimals.Clear();
                             }
                             else
                             {
                                 DisplayAlert(animal, this.GetAnimalCuriosity(animal), "Continuar!");
                                 this.tappedPairAnimals.Clear();
                             }
                         }
                         else // If they dont match, turn both dark (clickable) again
                         {
                             string pairOfAnimals = this.tappedPairAnimals.First().ClassId + this.tappedPairAnimals.Last().ClassId;
                             string knowledge = this.GetAnimalKnowledge(pairOfAnimals);

                             if (!String.IsNullOrEmpty(knowledge))
                                 DisplayAlert(firstAnimal + " e " + secondAnimal + ": Você não acertou, mas você sabia que..", knowledge, "Continuar!");

                             foreach (Frame animalFrame in this.tappedPairAnimals.ToList())
                             {
                                 for (int i = 0; i < this.animals.Length; i++)
                                     if (this.animals[i].ClassId == animalFrame.ClassId)
                                         this.animals[i].Content.Opacity = AnimalVisibility.Hide;
                             }
                             this.tappedPairAnimals.Clear();
                         }
                     }
                 }
             };

            this.NewGrid();
        }

        private string GetAnimalKnowledge(string pairOfAnimals)
        {
            return this.animalsKnowledge
                .Where(a => a.Key == pairOfAnimals)
                .Select(a => a.Value).FirstOrDefault();
        }

        private string GetAnimalCuriosity(string animal)
        {
            return this.animalsCuriosities
                .Where(a => a.Key == animal)
                .Select(a => a.Value).FirstOrDefault();
        }

        private void NewGrid()
        {
            var grid = new Grid();

            for (var i = 0; i < this.animals.Length; i++)
            {
                // switch (stage) { }
                var column = i % 2;
                var row = (int)Math.Floor(i / 2f);
                // case 2: var column = i % 3;
                //         var row = (int)Math.Floor(i / 3f);
                //         break;

                this.animals[i].GestureRecognizers.Add(this.tap);
                grid.Children.Add(this.animals[i], column, row);

                if (column % 2 == 0)
                    grid.RowDefinitions.Add(new RowDefinition { Height = 120 });
            }

            var layout = new StackLayout
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
                if (!this.isPlaying)
                {
                    // Prepare for playing.
                    var startTime = DateTime.Now;

                    Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                    {
                        // Round duration and get rid of milliseconds.
                        var timeSpan = (DateTime.Now - startTime) + TimeSpan.FromSeconds(0.5);
                        timeSpan = new TimeSpan(timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);

                        // Display the duration.
                        if (this.isPlaying)
                            this.timeLabel.Text = timeSpan.ToString("t");

                        return this.isPlaying;
                    });
                    this.isPlaying = true;

                    // Hide animals
                    for (int i = 0; i < this.animals.Length; i++)
                        this.animals[i].Content.Opacity = AnimalVisibility.Hide;
                }
                else
                    this.isPlaying = false;
            };

            var scrollView = new ScrollView();
            scrollView.Content = grid;

            layout.Children.Add(label);
            layout.Children.Add(this.timeLabel);
            layout.Children.Add(scrollView);
            layout.Children.Add(startButton);
            Content = layout;
        }
    }
}
