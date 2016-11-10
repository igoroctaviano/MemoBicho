using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MemoBicho.Levels.Two
{
    class GridLayoutPage2 : ContentPage
    {
        #region Level 2 Content
        // Animals
        Frame[] animals = {
            new Frame { ClassId = "Sapo",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "toad.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Raia",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "ray.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Peixe",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "fish.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Perereca",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "littleFrog.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Pato",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "duck.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Peixe",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "fish.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Sapo",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "toad.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Perereca",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "littleFrog.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Pato",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "duck.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } },
            new Frame { ClassId = "Raia",
                        BackgroundColor = Color.FromHex("#CDDC39"),
                        Content = new Image { Source = "ray.png",
                                              Aspect = Aspect.AspectFit,
                                              BackgroundColor = Color.FromHex("#CDDC39"),
                                              Opacity = 1 } }
        };

        // Content
        Dictionary<string, string> animalsCuriosities = new Dictionary<string, string>
        {
            { "Sapo", "Por ser terrestre a pele dos sapos apresentam muitas glândulas que o hidratam e "
                + "protege de desidratação. É um animal de busca ativa e possui mais glândulas de veneno." },
            { "Raia", "As Raias possuem uma abertura atrás dos olhos, chamada opérculo. Essa abertura "
                + "permite a entrada de água para que ela possa respirar quando esta encostada no fundo." },
            { "Perereca", "As pererecas possuem discos adesivos nas extremidades dos dedos, isso ajuda a aderir nas árvores e paredes." },
            { "Pato", "Os patos possuem uma glândula com função de hidratar as penas." },
            { "Peixe", "Possuem linha lateral que auxilia na percepção das ondas e no seu deslocamento." }
        };
        Dictionary<string, string> animalsKnowledge = new Dictionary<string, string>
        {
            { "SapoRaia", "O Sapo é um Anfíbio e a Raia é um peixe, ambos dependem da água para reprodução." },
            { "SapoPerereca", "São Anfíbios, apresentam respiração cutânea e toxinas na pele." },
            { "SapoPato", "O Sapo é Anfíbio e o Pato sauropsida (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves) vivem no lago, nadam, usam a agua pra viver." },
            { "SapoPeixe", "O Peixe não é Anfíbio como o Sapo mas eles nadam e tem muitas glândulas na pele." },
            { "RaiaPerereca", "Perereca possui pele fina e permeável, enquanto as raias possuem escamas para se proteger." },
            { "RaiaPato", "A nadadeira peitoral de ambos são iguais, mas com funções diferentes." },
            { "RaiaPeixe", "Ambos pertencem ao grupo dos peixes, possuem respiração branquial, são animais dependentes da agua para a reprodução." },
            { "PatoPerereca", "A Perereca é Anfibio enquanto o Pato é Sauropsida (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves), ambos nadam." },
            { "PererecaPeixe", "O Peixe não é Anfíbio como a Perereca porém eles nadam e se reproduzem na água." },
            { "PatoPeixe", "O Peixe náo é Sauropsida como o Pato (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves) mas ambos nadam." }
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

        public GridLayoutPage2()
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
                                              Device.BeginInvokeOnMainThread(() => this.Navigation.PushModalAsync(new QuizView2()));
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
                Text = "Jogo da Memória nível 2",
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
