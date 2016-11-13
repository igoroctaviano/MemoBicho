using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace MemoBicho.Levels.Five
{
    public class QuizView5 : ContentPage
    {
        Color backgroundColor = Color.FromHex("#8BC34A");
        Color buttonBackgroundColor = Color.FromHex("#689F38");
        Color textColor = Color.FromHex("#33691E");

        Dictionary<string, string> questionsAndAnswers = new Dictionary<string, string>()
            {
                { "São características do dinossauro:", "metabolismo lento, herbívoro, sauropsida." },
                { "Os gaviões são animais...?", "predadores." },
                { "A musculatura do peito da galinha é branca por quê?", "porque é pouco irrigada com vasos sanguíneos." },
                { "É característica dos morcegos?", "membranas interdigitais, hematófagos." },
                { "Como são os dentes da preguiça?", "crescimento contínuo." },
                { "Como são as patas dos cavalos?", "formadas por um único dedo." },
                { "É característica da Anta:", "tromba, mamífero, herbívoro." },
                { "Como os Elefantes dissipam calor?", "abanando as orelhas." }
            };

        Dictionary<string, List<string>> possibleAnswers = new Dictionary<string, List<string>>()
            {
                { "São características do dinossauro:", new List<string>() { "herbívoro, metabolismo lento, tromba.",
                                                                             "metabolismo lento, herbívoro, sauropsida.",
                                                                             "sauropsida, rosto alongado, casco.",
                                                                             "casco, sauropsida, herbívoro." } },
                { "Os gaviões são animais...?", new List<string>() { "lentos.",
                                                                     "herbívoros.",
                                                                     "predadores.",
                                                                     "pequenos." } },
                { "A musculatura do peito da galinha é branca por quê?", new List<string>() { "porque é muito irrigada com vasos sanguíneos.",
                                                                                              "porque é pouco irrigada com vasos sanguíneos.",
                                                                                              "porque são aves rápidas.",
                                                                                              "porque são aves que fazem voos grandes." } },
                { "É característica dos morcegos?", new List<string>() { "membranas interdigitais, hematófagos.",
                                                                         "hematófagos, lentos.",
                                                                         "lentos e herbívoros.",
                                                                         "frugívoros e pesados." } },
                { "Como são os dentes da preguiça?", new List<string>() { "frágeis.",
                                                                          "crescimento contínuo.",
                                                                          "de leite.",
                                                                          "grandes." } },
                { "Como são as patas dos cavalos?", new List<string>() { "formadas com cinco dedos.",
                                                                         "um pilar de sustentação.",
                                                                         "formadas com cinco dedos recobertos de casco.",
                                                                         "formadas por um único dedo." } },
                { "É característica da Anta:", new List<string>() { "tromba, mamífero, carnívoro.",
                                                                    "tromba, mamífero, frugívoro.",
                                                                    "tromba, mamífero, herbívoro.",
                                                                    "tromba, carnívoro, metabolismo lento." } },
                { "Como os Elefantes dissipam calor?", new List<string>() { "correndo.",
                                                                            "molhando.",
                                                                            "deitando.",
                                                                            "abanando as orelhas." } }
            };

        public QuizView5()
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
                Text = "Quiz nível 5",
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
            submitButton.Clicked += async delegate
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
                var result = await DisplayAlert("Legal, você completou o seu quinto questionário!", "Você pontuou "
                    + score + " em " + ((questionsLayout.Children.Count - 2) - 1) + " questões.", "Resultado", "Próximo nível");
                if (!result.Equals(true))
                    await Task.Run(() =>
                    {
                        this.Navigation.PopModalAsync();
                        Device.BeginInvokeOnMainThread(() => this.Navigation.PushModalAsync(new FinalPage()));
                    });
            };

            questionsLayout.Children.Add(submitButton);

            var scrollView = new ScrollView();
            scrollView.Content = questionsLayout;

            Content = scrollView;
        }
    }
}
