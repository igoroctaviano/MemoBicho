using MemoBicho.Levels.Two;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MemoBicho.Levels.Three
{
    class GridLayoutPage3 : ContentPage
    {
        #region Level 3 Content
        // Animals
        Frame[] animals = {
            new Frame { ClassId = "Tartaruga",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "turtle.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Tatu",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "armadillo.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Serpente",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "snake.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Lagarto",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "lizard.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Jacaré",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "alligator.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Serpente",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "snake.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Dragão de Komodo",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "dragon.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Tartaruga",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "turtle.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Lagarto",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "lizard.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Jacaré",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "alligator.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Tatu",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "armadillo.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },         
            new Frame { ClassId = "Dragão de Komodo",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "dragon.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
        };

        // Content
        Dictionary<string, string> animalsCuriosities = new Dictionary<string, string>
        {
            { "Tatu", "Quando ameaçado o tatu se enrola e obtém a forma de uma bola com isso ele deixa " 
                + "exposto somente às placas que formam sua carapaça escondendo do seu predador sua parte frágil." },
            { "Tartaruga", "..." },
            { "Lagarto", "Quando ameaçados alguns lagartos forçam a queda da cauda para enganar o predador e " 
                + " assim terá alguma chance de sobrevivência. O nome desse fenômeno é autotomia. Depois a cauda " 
                + "regenera e o animal continua sua vida normal." },
            { "Serpente", "Esses animais possuem o corpo coberto por escamas, que funcionam como proteção mecânica " 
                + "e também para evitar a desidratação do animal." },
            { "Jacaré", "Os jacarés passam bastante tempo expostos ao sol com a boca aberta. Isso porque a pele da boca," 
                + " que é fina e rica em vasos sanguíneos, absorve o calor com mais rapidez e eficiência. Vivem cerca de 80 anos.." },
            { "Dragão de Komodo", "O macho pode chegar a medir 3 m de comprimento e a pesar quase 100 kg e as fêmeas "
                + "chegam a medir 1,8 m. Em apenas uma refeição, podem comer o equivalente a 80% de seu peso." }
        };
        Dictionary<string, string> animalsKnowledge = new Dictionary<string, string>
        {
            { "TartarugaTatu", "São animais que possuem carapaça; Tartaruga é Sauropsida, tatu é mamífero; "
                + "Ambas as carapaças são formadas por placas ósseas internas; As vertebras da tartaruga estão "
                + "fundidas a carapaça, já o esqueleto do tatu é completamente independente da sua carapaça." },
            { "TartarugaSerpente", "São Sauropsida. Famílias?." },
            { "TartarugaLagarto", "São Sauropsida. São ectotermicos (animais que regulam a temperatura com o ambiente). Famílias?." },
            { "TartarugaJacaré", "São Sauropsida. São ectotermicos (animais que regulam a temperatura com o ambiente). Famílias?." },
            { "TartarugaDragão de Komodo", "São ectotermicos (animais que regulam a temperatura com o ambiente). Famílias?." },
            { "TatuSerpente", "O Tatu é um mamífero e a Serpente é um sauropsida." },
            { "TatuLagarto", "O Tatu é um mamífero e a Lagarto é um sauropsida." },
            { "TatuJacaré", "O Tatu é um mamífero e o Jacaré é um sauropsida." },
            { "TatuDragão de Komodo", "O Tatu é um mamífero e o Dragão de Komodo é um sauropsida." },
            { "SerpenteLagarto", "São sauropsidas. Serpente perdeu ao longo da evolução seus membros "
                + "já os lagartos não. São ectotermicos (animais que regulam a temperatura com o ambiente)." },
            { "SerpenteJacaré", "São sauropsidas. Serpente teve a perda dos membros ao longo da evolução." },
            { "SerpenteDragão de Komodo", "são sauropsidas. Ambos são predadores e possuem a língua bífida "
                + "que auxilia no processo de rastreamento da presa." },
            { "LagartoJacaré", "São sauropsidas. São ectotermicos. Lagarto vive no meio terrestre e o jacaré vive no meio aquático (??)"},
            { "LagartoDragão de Komodo", "São sauropsidas!" },
            { "JacaréDragão de Komodo", "São sauropsidas!" }
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

        public GridLayoutPage3()
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
                                             Device.BeginInvokeOnMainThread(() => this.Navigation.PushModalAsync(new QuizView3()));
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
                var column = i % 4;
                var row = (int)Math.Floor(i / 4f);

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

            var startButton = new Button { Text = "Começar!", BackgroundColor = Color.FromHex("#8BC34A") };
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
                    App.Current.MainPage = new GridLayoutPage2();
                }
            };

            var scrollView = new ScrollView();
            scrollView.Content = grid;

            layout.Children.Add(new Label
            {
                Text = "MemoBicho",
                TextColor = Color.FromHex("#8BC34A"),
                FontSize = 35,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center
            });
            layout.Children.Add(new Label
            {
                Text = "Jogo da Memória nível 3",
                FontSize = 20,
                TextColor = Color.FromHex("#8BC34A"),
                HorizontalTextAlignment = TextAlignment.Center
            });
            layout.Children.Add(this.timeLabel);
            layout.Children.Add(scrollView);
            layout.Children.Add(startButton);
            Content = layout;
        }
    }
}
