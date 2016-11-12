using MemoBicho.Levels.Five;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace MemoBicho.Levels.Four
{
    public class QuizView4 : ContentPage
    {
        Color backgroundColor = Color.FromHex("#8BC34A");
        Color buttonBackgroundColor = Color.FromHex("#689F38");
        Color textColor = Color.FromHex("#33691E");

        Dictionary<string, string> questionsAndAnswers = new Dictionary<string, string>()
            {
                { "Uma das características da Lampreia é:", "Pele com escamas." },
                { "É uma característica da Salamandra:", "Respira por pulmões e pele." },
                { "Qual dessas NÃO é uma característica de um Tubarão?", "Regulação endotérmica." },
                { "Qual dessas é uma característica do Golfinho?", "Vive na água, mas respira por pulmões." },
                { "São características do Pinguim:", "É um sauropsida, possui pena, põe ovos." },
                { "São características da Baleia:", "Mamífero, filtrador, movimento vertical da cauda." },
                { "Sobre o Ornitorrinco marque a alternativa correta:", "É um mamífero, mas possui bico, e põe ovos." }
            };

        Dictionary<string, List<string>> possibleAnswers = new Dictionary<string, List<string>>()
            {
                { "Uma das características da Lampreia é:", new List<string>() { "Carnívoro.",
                                                                                 "Ectotérmico.",
                                                                                 "Peixe cartilaginoso.",
                                                                                 "Pele com escamas." } },
                { "É uma característica da Salamandra:", new List<string>() { "Respira somente por pulmões.",
                                                                              "Possui escamas na pele.",
                                                                              "Faz regulação endotérmica.",
                                                                              "Respira por pulmões e pele."} },
                { "Qual dessas NÃO é uma característica de um Tubarão?", new List<string>() { "Esqueleto cartilaginoso.",
                                                                                              "Presença de escamas.",
                                                                                              "Regulação endotérmica.",
                                                                                              "Respiração branquial." } },
                { "Qual dessas é uma característica do Golfinho?", new List<string>() { "Vive na água, portanto respira por brânquias.",
                                                                                        "Vive na água, mas respira por pulmões.",
                                                                                        "Somente se reproduz na água, é um mamífero.",
                                                                                        "Vive na água, possui escamas." } },
                { "São características do Pinguim:", new List<string>() { "É um sauropsida, consegue voar, põe ovos.",
                                                                          "É um sauropsida, possui pena, põe ovos.",
                                                                          "É um mamífero, possui pelos, nada.",
                                                                          "É um sauropsida, consegue voar e nadar." } },
                { "São características da Baleia:", new List<string>() { "Mamífero, filtrador, movimento vertical da cauda.",
                                                                         "Peixe, filtrador, movimento vertical da cauda.",
                                                                         "Mamífero, carnívoro, respiração pulmonar.",
                                                                         "Peixe, carnívoro, respiração branquial." } },
                { "Sobre o Ornitorrinco marque a alternativa correta:", new List<string>() { "É um mamífero, mas possui bico, e põe ovos.",
                                                                                             "É um mamífero, mas possuem penas e põe ovos.",
                                                                                             "É um sauropsida, possui bico, põe ovos.",
                                                                                             "É um sauropsida, possui bicos, consegue voar." } }
            };

        public QuizView4()
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
                Text = "Quiz nível 4",
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
                DisplayAlert("Óra óra óra!", "Você pontuou " + score + " em " + questionsLayout.Children.Count + " questões.", "Próximo nível!")
                    .ContinueWith(w => 
                    {
                        this.Navigation.PopModalAsync();
                        Device.BeginInvokeOnMainThread(() => this.Navigation.PushModalAsync(new GridLayoutPage5()));
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
