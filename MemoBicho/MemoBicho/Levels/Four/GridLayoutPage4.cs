using MemoBicho.Levels.Two;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MemoBicho.Levels.Four
{
    class GridLayoutPage4 : ContentPage
    {
        #region Level 4 Content
        // Animals
        Frame[] animals = {
            new Frame { ClassId = "Lampreia",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "lamprey.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Salamandra",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "salamander.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Tubarão",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "shark.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Golfinho",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "dolphin.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Ornitorrinco",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "platypus.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Pinguim",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "penguin.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Tubarão",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "shark.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Baleia",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "whale.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Ornitorrinco",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "platypus.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Lampreia",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "lamprey.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Golfinho",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "dolphin.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Pinguim",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "penguin.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Salamandra",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "salamander.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },         
            new Frame { ClassId = "Baleia",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "whale.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
        };

        // Content
        Dictionary<string, string> animalsCuriosities = new Dictionary<string, string>
        {
            { "Tubarão", "Os tubarões são animais ectotérmicos, ou seja, a temperatura do corpo varia de acordo com a temperatura ambiente." },
            { "Golfinho", "Os golfinhos dormem com um lado do cérebro de cada vez. São animais que precisam ir para a superfície de 5 a 8 minutos para respirar." },
            { "Lampreia", "A pele desses animais é rica em glândulas produtoras de muco, que produzem em grande quantidade para se defenderem de predadores." },
            { "Salamandra", "Algumas salamandras produzem um muco venenoso que permite a ela uma maior proteção contra predadores." },
            { "Pinguim", "Possuem penas, mas suas asas são modificadas para nadar." },
            { "Baleia", "É um mamífero, e por isso precisa sair da água para respirar. Possuem cerdas filtradoras em vez de dentes." },            
            { "Ornitorrinco", "É um mamífero, mas bota ovos, possui uma glândula de veneno como modo de defesa, possui bico e possui penas." }
        };
        Dictionary<string, string> animalsKnowledge = new Dictionary<string, string>
        {
            { "LampreiaSalamandra", "Elas possuem sangue frio (ectotérmicos) e possui dentes. Lampreia é um peixe e a Salamandra é um anfíbio." },
            { "LampreiaTubarão", "Vivem na água, possuem dentes, respiram por brânquias, possuem escamas, são ectotérmicos," 
                + " botam ovos. Lampreia é um peixe ósseo e o Tubarão é um peixe cartilaginoso." },
            { "LampreiaGolfinho", "Vivem na água, possuem dentes. Lampreia é um peixe e os golfinhos são mamíferos." },
            { "LampreiaPinguim", "Botam ovos. Lampreia é um peixe e o pinguim é um sauropsida (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves)." },
            { "LampreiaBaleia", "Vivem na água. A lampreia é um peixe e a baleia é um mamífero." },
            { "LampreiaOrnitorrinco", "Botam ovos. Lampreia é peixe e Ornitorrinco é um mamífero." },
            { "SalamandraTubarão", "Ectotérmicos, possuem dentes, são carnívoros. Salamandra é anfíbio e Tubarão é peixe." },
            { "SalamandraGolfinho", "São carnívoros, possuem pele lisa, possuem dentes. Salamandra é anfíbio e Golfinho é mamífero." },
            { "SalamandraPinguim", "São carnívoros. Salamandra é Anfíbio e Pinguim é sauropsida (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves)." },
            { "SalamandraBaleia", "Pele lisa. Salamandra é anfíbio e Baleia é mamífero." },
            { "SalamandraOrnitorrinco", "São carnívoros. A Salamandra é anfíbio e o Ornitorrinco é mamífero." },
            { "TubarãoGolfinho", "Vivem na água, possuem dentes, são carnívoros. Tubarão é peixe, golfinho é mamífero." },
            { "TubarãoPinguim", "botam ovos, Tubarão é peixe e pinguim sauropsida (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves)."},
            { "TubarãoBaleia", "Vivem na água. Tubarão é peixe, baleia é mamífero." },
            { "TubarãoOrnitorrinco", "Botam ovos, são carnívoros. Tubarão é peixe e ornitorrinco é mamífero." },
            { "GolfinhoPinguim", "Carnívora, respiração pulmonar. Golfinho é mamífero, pinguim sauropsida (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves)." },
            { "GolfinhoBaleia", "São mamíferos, vive na água, nadadeira bate ventralmente, respiração pulmonar, pele lisa, ectotérmicos." },
            { "GolfinhoOrnitorrinco", "Mamíferos, endotérmicos, carnívoros, respiração pulmonar." },
            { "PinguimBaleia", "Ectotérmicos, respiração pulmonar. Sauropsida (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves) e mamífero." },
            { "PinguimOrnitorrinco", "Endotérmicos, botam ovos, possuem bico, são carnívoros. Sauropsida (Você sabe o que é Sauropsida? "
                + "é o nome correto para os repteis e as aves) e mamífero." },
            { "BaleiaOrnitorrinco", "São mamíferos, ectotérmicos." },
        };
        #endregion

        #region Attributes
        Color backgroundColor = Color.FromHex("#8BC34A");
        Color buttonBackgroundColor = Color.FromHex("#689F38");
        Color textColor = Color.FromHex("#33691E");

        bool isPlaying = false;
        List<string> matchedAnimals = new List<string>();
        List<Frame> tappedPairAnimals = new List<Frame>();
        Label timeLabel = new Label
        {
            HorizontalOptions = LayoutOptions.Center,
            FontSize = 20
        };
        TapGestureRecognizer tap = new TapGestureRecognizer();
        private struct AnimalVisibility
        {
            public const double Hide = 0;
            public const double Show = 1;
        }
        #endregion

        public GridLayoutPage4()
        {
            this.BrandNewGrid();
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

        private void BrandNewGrid()
        {
            BackgroundColor = backgroundColor;
            timeLabel.TextColor = textColor;

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
                        string firstAnimal = this.tappedPairAnimals.First().ClassId, 
                               secondAnimal = this.tappedPairAnimals.Last().ClassId;

                        if (firstAnimal == secondAnimal) // Then check for match
                        {
                            this.matchedAnimals.Add(this.tappedPairAnimals.Last().ClassId);

                            if (this.matchedAnimals.Count == ((this.animals.Length) / 2)) // Win if all animals were found
                            {
                                this.isPlaying = false; // Stop the timer
                                DisplayAlert(animal, this.GetAnimalCuriosity(animal), "Continuar!").ContinueWith(t =>
                                {
                                    DisplayAlert("Parabéns", "Você completou esse desafio com o tempo: " 
                                        + this.timeLabel.Text + ".", "Próximo nível!").ContinueWith(w =>
                                         {
                                             this.Navigation.PopModalAsync();
                                             Device.BeginInvokeOnMainThread(() => this.Navigation.PushModalAsync(new QuizView4()));
                                         },
                                         TaskScheduler.FromCurrentSynchronizationContext());
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
                            string invertedPairOfAnimals = this.tappedPairAnimals.Last().ClassId + this.tappedPairAnimals.First().ClassId;

                            string knowledge = this.GetAnimalKnowledge(pairOfAnimals);
                            if (knowledge == null)
                                knowledge = this.GetAnimalKnowledge(invertedPairOfAnimals);

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

        private void NewGrid()
        {
            var width = App.Current.MainPage.Width;
            var height = App.Current.MainPage.Height;

            var grid = new Grid();

            for (var i = 0; i < this.animals.Length; i++)
            {
                var column = i % 3;
                var row = (int)Math.Floor(i / 3f);

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

            var startButton = new Button
            {
                Text = "Começar!",
                FontSize = 25,
                BackgroundColor = buttonBackgroundColor
            };
            startButton.Clicked += delegate
            {
                if (!this.isPlaying)
                {
                    startButton.Text = "Começar denovo!";

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
                {
                    this.isPlaying = false;
                    App.Current.MainPage = new GridLayoutPage4();
                }
            };

            var scrollView = new ScrollView();
            scrollView.Content = grid;

            layout.Children.Add(new Label
            {
                Text = "MemoBicho",
                TextColor = textColor,
                FontSize = 45,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center
            });
            layout.Children.Add(new Label
            {
                Text = "Jogo da Memória nível 4",
                FontSize = 30,
                TextColor = textColor,
                HorizontalTextAlignment = TextAlignment.Center
            });
            layout.Children.Add(this.timeLabel);
            layout.Children.Add(scrollView);
            layout.Children.Add(startButton);
            Content = layout;
        }
    }
}
