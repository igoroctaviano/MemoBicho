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
            { "Morcego", "Os morcegos hematófagos, aqueles que se alimentam de sangue, não sugam o sangue do animal como os mosquitos,"
                +" eles mordem e lambem o sangue que escorre até se saciarem." },
        };
        Dictionary<string, string> animalsKnowledge = new Dictionary<string, string>
        {
            { "DinossauroGavião", "Sauropsida (Você sabe o que é Sauropsida? é o nome correto para os répteis e as aves); "
                + "Carnívoros; Predadores Raptores(Ladrões, Velozes); Possuem Penas; Garras afiadas; Vocalização Intimidadora." },
            { "DinossauroGalinha", "São Sauropsidas (Você sabe o que é Sauropsida? é o nome correto para os répteis e as aves). Possuem estômago muscular, que se chama moela." },
            { "DinossauroMorcego", "Não possuem penas. Dinossauro: Sauropsida (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves), "
                +" herbívoros, se desloca andando, animal lento. Morcego: Mamífero, herbívoro frugívoro, se desloca por voo, animal rápido." },
            { "DinossauroPreguiça", "Não possuem penas. Dinossauro: sauropsida (Você sabe o que é Sauropsida? é o nome correto "
                +"para os repteis e as aves), herbívoro, vive em terra. Preguiça: Mamífero, herbívoro, vive em árvores." },
            { "DinossauroCavalo", "Não possuem penas, são herbívoros, vivem em terra, caminham. Dinossauro: Sauropsida "
                +"(Você sabe o que é Sauropsida? é o nome correto para os répteis e as aves), animal lento. Cavalo: Mamífero, Animal veloz." },
            { "DinossauroAnta", "Não possuem penas, são herbívoros, animais lentos. Dinossauro: sauropsida (Você sabe o que é Sauropsida? é o "
                +" nome correto para os répteis e as aves). Anta: Mamífero." },
            { "DinossauroElefante", "Não possuem penas, são herbívoros, vivem em terra, animais lentos, possuem pés em forma de colunas. "
                +" Dinossauro: sauropsida (Você sabe o que é Sauropsida? é o nome correto para os répteis e as aves). Elefante: Mamífero." },
            { "GaviãoGalinha", "São Sauropsidas (Você sabe o que é Sauropsida? é o nome correto para os répteis e as aves). "
                +"O Gavião possui musculatura escura no peito, que possui maior irrigação de sangue e permite voos longos."
                +" A galinha possui musculatura clara e pouco irrigada de sangue, pois não consegue voar por uma distancia longa." },
            { "GaviãoMorcego", "Ambos voam, Gavião é um sauropsida (Você sabe o que é Sauropsida? é o nome correto para os répteis e as aves), "
                +"e seus dedos formam um eixo de sustentação para as penas, enquanto o morcego é um mamífero, e possui 5 dedos e entre eles "
                +"possui uma membrana interdigital que permite a formação da asa para voo." },
            { "GaviãoPreguiça", "Gavião é um sauropsida (Você sabe o que é Sauropsida? é o nome correto para os répteis "
                +"e as aves), preguiça é um mamífero. O Gavião possui metabolismo acelerado enquanto a preguiça possui metabolismo lento." },
            { "GaviãoCavalo", "Gavião é um sauropsida (Você sabe o que é Sauropsida? é o nome correto para os répteis e as aves), "
                +"Cavalo é um mamífero. O Gavião se locomove no ar, e possui unhas afiadas que ajudam na predação. O cavalo se "
                +"locomove na terra, e anda sobre a ponta dos cascos, que recobrem o seu único dedo em cada pata." },
            { "GaviãoAnta", "Gavião é um sauropsida (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves) "
                +"e tem a pele recoberta por penas, enquanto a Anta é um mamífero recoberto por pelos." },
            { "GaviãoElefante", "O Gavião é um Sauropsida (Você sabe o que é Sauropsida? é o nome correto para os répteis "
                +" e as aves), controla a temperatura corporal abrindo as asas e a boca. O Elefante é um mamífero, abana as orelhas e esfria o sangue que passa pela região."},
            { "GalinhaMorcego", "A galinha é um sauropsida (Você sabe o que é Sauropsida? é o nome correto para os repteis e as aves),"
                +" e possuem penas recobrindo a pele, perdeu a capacidade de voo. O Morcego é um mamífero e consegue voar." },
            { "GalinhaPreguiça", "A galinha é um sauropsida (Você sabe o que é Sauropsida? é o nome correto para os répteis"
                +" e as aves), é onívoro e possuem penas recobrindo a pele, enquanto que a Preguiça é um mamífero, herbívoro e possui pelos muito grossos recobrindo a pele." },
            { "GalinhaCavalo", "A galinha é um sauropsida e possuem cristas de queratina e seus machos (os galos) possuem uma "
                +"forma de defesa nas patas, chamada esporão. O cavalo é um mamífero e possui queratina recobrindo os dedos, chamada de casco." },
            { "GalinhaAnta", "A galinha é um sauropsida (Você sabe o que é Sauropsida? é o nome correto para os répteis e as aves) "
                +"e possuem penas recobrindo sua pele, enquanto a anta é um mamífero e possui pelos recobrindo a pele." },
            { "GalinhaElefante", "A galinha é um sauropsida (Você sabe o que é Sauropsida? é o nome correto para os répteis"
                +" e as aves) e controla sua temperatura corporal abrindo suas asas, enquanto o elefante é um mamífero e abana suas orelhas fazendo com que esfrie o sangue que passa pela região." },
            { "MorcegoPreguiça", "Ambos Mamíferos. Morcego possui membranas interdigitais adaptadas ao voo, a preguiça possui "
                +"queratina alongada na ponta dos dedos permitindo maior fixação nos galhos das árvores onde vive." },
            { "MorcegoCavalo", "Ambos Mamíferos. Morcego possui patas adaptadas ao voo, enquanto o cavalo possui dedos e cascos adaptados ao galope." },
            { "MorcegoAnta", "Ambos Mamíferos. Morcego pode ser frugívoro (se alimenta de frutos) ou Hematófagos (se alimentam de sangue)"
                +" e é adaptado ao voo, enquanto a Anta é herbívora e adaptada a caminhar." },
            { "MorcegoElefante", "Mamíferos, Morcego pode ser frugívoro (se alimenta de frutos) ou Hematófagos (se alimentam de sangue) "
                +"possui membrana interdigital que permite o voo, o elefante possui patas colunares adaptadas à sustentação do peso do animal." },
            { "PreguiçaCavalo", "Ambos são mamíferos, porém a Preguiça possui metabolismo lento, e o cavalo possui metabolismo acelerado." },
            { "PreguiçaAnta", "Ambos são mamíferos, porém a Preguiça possui metabolismo mais lento que o da Anta. A Anta vive em terra, enquanto a preguiça vive na copa das árvores." },
            { "PreguiçaElefante", "Os dentes da preguiça possuem crescimento contínuo, enquanto os dentes do Elefante se repõem: o "
                +"dente mais interno nasce e empurra o dente mais externo da boca." },
            { "CavaloAnta", "são mamíferos, herbívoros. A Anta possui uma tromba que permite um maior alcance do alimento, enquanto o "
                +"cavalo possui o rosto alongado, que também permite maior alcance dos alimentos." },
            { "CavaloElefante", "cavalos são mamíferos, elefantes são herbívoros. O Elefante possui uma tromba que permite um maior"
                +" alcance do alimento e patas colunares que permitem maior sustentação de seu peso, enquanto o cavalo possui o rosto alongado, "
                +"que também permite maior alcance dos alimentos e possuem cascos que permitem a corrida do animal." },
            { "AntaElefante", "Ambos são mamíferos, Herbívoros, Lentos e possuem uma tromba que permite um maior alcance dos alimentos." }
        };
        #endregion

        #region Attributes
        bool isPlaying = false;
        List<string> matchedAnimals = new List<string>();
        List<Frame> tappedPairAnimals = new List<Frame>();
        Label timeLabel = new Label { HorizontalOptions = LayoutOptions.Center, FontSize = 20 };
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

            var startButton = new Button { Text = "Começar!", FontSize = 25, BackgroundColor = Color.FromHex("#8BC34A") };
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
                    App.Current.MainPage = new GridLayoutPage5();
                }
            };

            var scrollView = new ScrollView();
            scrollView.Content = grid;

            layout.Children.Add(new Label
            {
                Text = "MemoBicho",
                TextColor = Color.FromHex("#8BC34A"),
                FontSize = 40,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center
            });
            layout.Children.Add(new Label
            {
                Text = "Jogo da Memória nível 5",
                FontSize = 25,
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
