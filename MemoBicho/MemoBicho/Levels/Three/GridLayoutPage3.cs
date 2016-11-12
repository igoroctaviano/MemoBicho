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
            { "Tartaruga", "O casco das tartarugas é formado em grande parte pela junção das costelas que se originam da derme, a derme é a região onde "
                + "nos mamíferos encontramos as glândulas sebáceas é a camada que traz rigidez a nossa pele." },
            { "Lagarto", "Quando ameaçados alguns lagartos forçam a queda da cauda para enganar o predador e assim terá "
                + "alguma chance de sobrevivência. O nome desse fenômeno é autotomia, depois a cauda regenera." },
            { "Serpente", "Esses animais possuem o corpo coberto por escamas, que funcionam como proteção mecânica e também para evitar a desidratação do animal." },
            { "Jacaré", "Os jacarés passam bastante tempo expostos ao sol com a boca aberta porque a pele da boca, que é fina e rica "
                + "em vasos sanguíneos, absorve o calor com mais rapidez e eficiência." },
            { "Dragão de Komodo", "São lagartos gigantes que podem chegar até os 3m de comprimento e pesar quase 100 kg. A sua forma de "
                + "matar a presa e morder e lamber a ferida para que as bactérias presentes na sua boca causem a morte do animal para que ele possa se alimentar em seguida." }
        };
        Dictionary<string, string> animalsKnowledge = new Dictionary<string, string>
        {
            { "TartarugaTatu", "São animais que possuem carapaça; Tartaruga é Sauropsida (Você sabe o que é Sauropsida? é o nome "
                +"correto para os repteis e as aves), tatu é mamífero; Ambas as carapaças são formadas por placas ósseas internas; "
                +"As vertebras da tartaruga estão fundidas a carapaça, já o esqueleto do tatu é completamente independente da sua carapaça." },
            { "TartarugaSerpente", "São Sauropsidas (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves). "
                + "Possuem vértebras modificadas que são usadas pela tartaruga para recolher o pescoço, e a Serpente utiliza durante a constricção e sufocamento da presa." },
            { "TartarugaLagarto", "São Sauropsidas (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves). "
                + "São ectotérmicos (animais que regulam a temperatura com o ambiente)." },
            { "TartarugaJacaré", "São Sauropsidas (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves). "
                +" São ectotérmicos (animais que regulam a temperatura com o ambiente). Possuem ossos dérmicos para proteção." },
            { "TartarugaDragão de Komodo", "São ectotérmicos (animais que regulam a temperatura com o ambiente). São bons nadadores." },
            { "TatuSerpente", "Tatu é um mamífero e a Serpente é um sauropsida (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves)." },
            { "TatuLagarto", "Tatu é um mamífero e a serpente é um sauropsida (Você sabe o que é Sauropsida? é o nome correto "
                +"para os repteis e as aves). Tatu usa unhas para escavar, e lagarto usa as unhas para escalar." },
            { "TatuJacaré", "Tatu é um mamífero e a serpente é um sauropsida (Você sabe o que é Sauropsida? é o nome "
                + "correto para os repteis e as aves). Possuem ossos dérmicos para proteção." },
            { "TatuDragão de Komodo", "Tatu é um mamífero e o Dragão de Komodo é um sauropsida (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves)." },
            { "SerpenteLagarto", "São sauropsidas (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves). "
                +"A Serpente perdeu ao longo da evolução seus membros já os Lagartos não. São ectotérmicos (animais que regulam a temperatura com o ambiente)." },
            { "SerpenteJacaré", "São sauropsidas (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves). Serpente teve a "
                +"perda dos membros ao longo da evolução. Algumas serpentes tem a cauda achatada, adaptada para o nado, igual o jacaré." },
            { "SerpenteDragão de Komodo", "São sauropsidas (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves). "
                +"Ambos são predadores e possuem a língua bífida que auxilia no processo de rastreamento da presa." },
            { "LagartoJacaré", "São sauropsidas (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves). Jacaré possui 4"
                +" compartimentos no coração, que servem para separar o sangue oxigenado, enquanto o lagarto possui somente 3."},
            { "LagartoDragão de Komodo", "São sauropsidas (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves). "
                +"O dragão de Komodo é a maior espécie de lagarto que existe." },
            { "JacaréDragão de Komodo", "São sauropsidas (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves). "
                +"Jacaré possui 4 compartimentos no coração, que servem para separar o sangue oxigenado, enquanto o lagarto possui somente 3." }
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

                if (image.Opacity == AnimalVisibility.Hide && this.tappedPairAnimals.Contains(frame) == false) // If it's dark (clickable) and not cliked yet
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

            var startButton = new Button { Text = "Começar!", FontSize = 25, BackgroundColor = buttonBackgroundColor };
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
                    App.Current.MainPage = new GridLayoutPage3();
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
                Text = "Jogo da Memória nível 3",
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
