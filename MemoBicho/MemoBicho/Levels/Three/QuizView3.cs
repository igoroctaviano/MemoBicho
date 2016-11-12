using MemoBicho.Levels.Four;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace MemoBicho.Levels.Three
{
    public class QuizView3 : ContentPage
    {
        Color backgroundColor = Color.FromHex("#8BC34A");
        Color buttonBackgroundColor = Color.FromHex("#689F38");
        Color textColor = Color.FromHex("#33691E");

        Dictionary<string, string> questionsAndAnswers = new Dictionary<string, string>()
            {
                { "Como o casco da tartaruga é formado?", "Pela junção de ossos como as costelas." },
                { "Quando um lagarto se sente ameaçado qual o mecanismo que ele utiliza para se proteger?", "Provoca a queda da cauda." },
                { "O dragão de Komodo pertence a qual grupo de animais?", "Sauropsida." },
                { "Em relação aos jacarés marque a alternativa incorreta:", "São herbivoros." },
                { "Em relação as serpentes marque a opção correta:", "São animais ectodérmicos." },
                { "O tatu pertence ao grupo dos mamíferos, qual das características abaixo não é uma característica do tatu?", "São aquáticos." }
            };

        Dictionary<string, List<string>> possibleAnswers = new Dictionary<string, List<string>>()
            {
                { "Como o casco da tartaruga é formado?", new List<string>() { "Pela junção de escamas.",
                                                                               "Pela junção de ossos como as costelas.",
                                                                               "Pela junção da pele.",
                                                                               "Pela junção dos órgãos." } },
                { "Quando um lagarto se sente ameaçado qual o mecanismo que ele utiliza para se proteger?", new List<string>() {
                                                                                                            "Provoca a queda da cauda.",
                                                                                                            "O animal fingi de morto.",
                                                                                                            "O animal ataca o possível predador.",
                                                                                                            "O animal promove a queda dos membros." } },
                { "O dragão de Komodo pertence a qual grupo de animais?", new List<string>() {
                                                                               "Peixes.",
                                                                               "Sauropsida.",
                                                                               "Anfíbios.",
                                                                               "Mamíferos." } },
                { "Em relação aos jacarés marque a alternativa incorreta:", new List<string>() {
                                                                               "Botam ovos.",
                                                                               "São herbivoros.",
                                                                               "São ectotérmicos.",
                                                                               "Possuem pele com presença de glândulas." } },
                { "Em relação as serpentes marque a opção correta:", new List<string>() {
                                                                               "Possuem membros.",
                                                                               "São animais herbívoros.",
                                                                               "São animais ectodérmicos.",
                                                                               "Possuem pele com presença de glândulas." } },
                { "O tatu pertence ao grupo dos mamíferos, qual das características abaixo não é uma característica do tatu?",
                                                          new List<string>() { "Presença de pelos.",
                                                                               "Endotérmicos.",
                                                                               "Possuem carapaça.",
                                                                               "São aquáticos." } },
            };

        public QuizView3()
        {
            BackgroundColor = backgroundColor;

            var logo = new Label()
            {
                Text = "MemoBicho",
                TextColor = textColor,
                FontSize = 40,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center
            };

            var questionsLayout = new StackLayout() { Padding = 10 };
            questionsLayout.Children.Add(logo);
            questionsLayout.Children.Add(new Label()
            {
                Text = "Quiz nível 3",
                FontSize = 25,
                TextColor = textColor,
                HorizontalTextAlignment = TextAlignment.Center
            });

            foreach (var question in questionsAndAnswers)
            {
                var questionLayout = new StackLayout() { Padding = 10 };
                questionLayout.Children.Add(new Label()
                {
                    Text = question.Key,
                    FontSize = 27,
                    TextColor = textColor,
                    FontAttributes = FontAttributes.Bold
                });

                var answersButtons = new BindableRadioGroup();
                foreach (var questionAnswers in possibleAnswers.Where(a => a.Key == question.Key).Select(a => a.Value))
                {
                    answersButtons.ItemsSource = questionAnswers.ToArray();
                    foreach (var answerButton in answersButtons.Items) // The button belongs to a question
                    {
                        answerButton.ClassId = question.Key;
                        answerButton.FontSize = 22;
                        answerButton.TextColor = textColor;
                    }
                }
                
                questionLayout.Children.Add(answersButtons);
                questionsLayout.Children.Add(questionLayout);
            }

            var submitButton = new Button
            {
                Text = "Submeter respostas!",
                FontSize = 25,
                BackgroundColor = buttonBackgroundColor,
                FontAttributes = FontAttributes.Bold
            };
            submitButton.Clicked += delegate
            {
                int score = 0;
                foreach (StackLayout questionLayout in questionsLayout.Children
                    .Where(q => q.GetType() == new StackLayout().GetType()))
                {
                    foreach (BindableRadioGroup answersButtons in questionLayout.Children
                            .Where(q => q.GetType() == new BindableRadioGroup().GetType()))
                        foreach (CustomRadioButton answerButton in answersButtons.Items)
                            if (answerButton.Checked)
                            {
                                if (questionsAndAnswers.Where(q => q.Key == answerButton.ClassId)
                                .FirstOrDefault().Value == answerButton.Text) // If correct answer
                                {
                                    score++;
                                    answerButton.TextColor = Color.Lime;
                                }
                                else
                                    answerButton.TextColor = Color.Red;
                            }
                }
                DisplayAlert("Legal, você completou o seu quinto questionário!", "Você pontuou "
                    + score + " em " + (questionsLayout.Children.Count - 2) + " questões.", "Próximo nível!")
                    .ContinueWith(w => 
                    {
                        this.Navigation.PopModalAsync();
                        Device.BeginInvokeOnMainThread(() => this.Navigation.PushModalAsync(new GridLayoutPage4()));
                    },
                    TaskScheduler.FromCurrentSynchronizationContext());
            };

            questionsLayout.Children.Add(submitButton);

            var scrollView = new ScrollView();
            scrollView.Content = questionsLayout;

            Content = scrollView;
        }
    }
}
