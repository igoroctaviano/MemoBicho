using MemoBicho.Levels.Two;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MemoBicho.Levels.Five
{
    class GridLayoutPage5 : ContentPage
    {
        #region Level 5 Content
        // Animals
        Frame[] animals = {
            new Frame { ClassId = "Elefante",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "elephant.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Dinossauro",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "dino.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Gavião",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "eagle.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Elefante",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "elephant.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Galinha",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "chicken.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Preguiça",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "sloth.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Cavalo",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "horse.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Morcego",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "bat.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Galinha",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "chicken.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Anta",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "tapir.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Dinossauro",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "dino.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Morcego",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "bat.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Preguiça",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "sloth.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Cavalo",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "horse.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Gavião",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "eagle.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },         
            new Frame { ClassId = "Anta",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Padding = 5,
                        Content = new Image { Source = "tapir.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
        };

        // Content
        Dictionary<string, string> animalsCuriosities = new Dictionary<string, string>
        {
            { "Dinossauro", "Você sabia que as aves surgiram da evolução de um grupo de dinossauros?" },
            { "Gavião", "Você sabia que um gavião voando em queda livre pode chegar a 200km/h?" },
            { "Galinha", "A galinha demora cerca de 24 horas para fazer um ovo. As galinhas podem pôr ovos muito "
                + "cedo, a partir de 120 dias de vida, podendo pôr cerca de 290 ovos por ano." },
            { "Preguiça", "Para cada metro de deslocamento do bicho-preguiça, o homem anda 45 metros." },
            { "Cavalo", "O cavalo possui somente um dedo, e é recoberto por uma queratina protetora, chamado de unguligrado." },
            { "Anta", "Possui uma tromba que permite maior alcance dos alimentos." },
            { "Elefante", "As orelhas dos elefantes são cobertas de pequenas veias que facilitam a "
                + "dissipação de calor, mantendo a temperatura corporal do animal." },
            { "Morcego", "Os morcegos hematófagos, aqueles que se alimentam de sangue, não sugam o sangue do animal "
                +" como os mosquitos, eles mordem e lambem o sangue que escorre até se saciarem." },
        };
        Dictionary<string, string> animalsKnowledge = new Dictionary<string, string>
        {
            { "DinossauroGavião", "São animais que possuem carapaça; Tartaruga é Sauropsida, tatu é mamífero; "
                + "Ambas as carapaças são formadas por placas ósseas internas; As vertebras da tartaruga estão "
                + "fundidas a carapaça, já o esqueleto do tatu é completamente independente da sua carapaça." },
            { "DinossauroGalinha", "São Sauropsida. Famílias?." },
            { "DinossauroMorcego", "São Sauropsida. São ectotermicos (animais que regulam a temperatura com o ambiente). Famílias?." },
            { "DinossauroPreguiça", "São Sauropsida. São ectotermicos (animais que regulam a temperatura com o ambiente). Famílias?." },
            { "DinossauroCavalo", "São ectotermicos (animais que regulam a temperatura com o ambiente). Famílias?." },
            { "DinossauroAnta", "O Tatu é um mamífero e a Serpente é um sauropsida." },
            { "DinossauroElefante", "O Tatu é um mamífero e a Lagarto é um sauropsida." },
            { "GaviãoGalinha", "O Tatu é um mamífero e o Jacaré é um sauropsida." },
            { "GaviãoMorcego", "O Tatu é um mamífero e o Dragão de Komodo é um sauropsida." },
            { "GaviãoPreguiça", "São sauropsidas. Serpente perdeu ao longo da evolução seus membros "
                + "já os lagartos não. São ectotermicos (animais que regulam a temperatura com o ambiente)." },
            { "GaviãoCavalo", "São sauropsidas. Serpente teve a perda dos membros ao longo da evolução." },
            { "GaviãoAnta", "são sauropsidas. Ambos são predadores e possuem a língua bífida "
                + "que auxilia no processo de rastreamento da presa." },
            { "GaviãoElefante", "São sauropsidas. São ectotermicos. Lagarto vive no meio terrestre e o jacaré vive no meio aquático (??)"},
            { "GalinhaMorcego", "São sauropsidas!" },
            { "GalinhaPreguiça", "São sauropsidas!" },
            { "GalinhaCavalo", "São sauropsidas!" },
            { "GalinhaAnta", "São sauropsidas!" },
            { "GalinhaElefante", "São sauropsidas!" },
            { "MorcegoPreguiça", "São sauropsidas!" },
            { "MorcegoCavalo", "São sauropsidas!" }
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

        public GridLayoutPage5()
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
                                             Device.BeginInvokeOnMainThread(() => this.Navigation.PushModalAsync(new QuizView5()));
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

            var grid = new Grid() { };

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

            layout.Children.Add(new Label()
            {
                Text = "MemoBicho",
                TextColor = Color.FromHex("#8BC34A"),
                FontSize = 35,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center
            });
            layout.Children.Add(new Label()
            {
                Text = "Jogo da Memória nível 5",
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
