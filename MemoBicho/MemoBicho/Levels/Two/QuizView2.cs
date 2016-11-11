using MemoBicho.Levels.Three;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace MemoBicho.Levels.Two
{
    public class QuizView2 : ContentPage
    {
        Dictionary<string, string> questionsAndAnswers = new Dictionary<string, string>()
            {
                { "Qual a função das glândulas de veneno presentes na pele dos sapos?", "Proteção contra predadores." },
                { "Quando a raia está no fundo do oceano ela utiliza de uma abertura "
                    + "para permitir a entrada de água para a respiração. Qual o nome dessa abertura?", "Opérculo." },
                { "Qual a principal semelhança entre os sapo e a perereca?", "Ambos pertencem ao grupo dos anfíbios." },
                { "Em relação ao pato marque a alternativa errada:", "São animais que se reproduzem na água." },
                { "Qual a função da linha lateral nos peixes?", "Auxiliar no deslocamento do animal." }
            };

        Dictionary<string, List<string>> possibleAnswers = new Dictionary<string, List<string>>()
            {
                { "Qual a função das glândulas de veneno presentes na pele dos sapos?", new List<string>() { "Proteção contra predadores.",
                                                                                                             "Proteção contra a desidratação.",
                                                                                                             "Auxilia na respiração.",
                                                                                                             "Atrativo sexual." } },
                { "Quando a raia está no fundo do oceano ela utiliza de uma abertura "
                    + "para permitir a entrada de água para a respiração. Qual o nome dessa abertura?", new List<string>() { "Brânquias.",
                                                                                                                             "Narina.",
                                                                                                                             "Opérculo.",
                                                                                                                             "Boca." } },
                { "Qual a principal semelhança entre os sapo e a perereca?", new List<string>() { "Ambos possuem discos adesivos nas pontas dos dedos.",
                                                                                                  "Ambos não fazem reproduzem na água.",
                                                                                                  "Ambos pertencem ao grupo dos anfíbios.",
                                                                                                  "Ambos não fazem respiração pela pele." } },
                { "Em relação ao pato marque a alternativa errada:", new List<string>() { "Os patos pertencem ao grupo dos sauropsida.",
                                                                                          "As penas dos patos não se molham porque elas são impermeabilizadas.",
                                                                                          "São animais que se reproduzem na água.",
                                                                                          "Possui muitas glândulas espalhadas pelo corpo." } },
                { "Qual a função da linha lateral nos peixes?", new List<string>() { "Dividir o corpo do animal em duas partes.",
                                                                                     "Sustentar o corpo do animal.",
                                                                                     "Auxiliar no deslocamento do animal.",
                                                                                     "Auxiliar o animal no processo de respiração." } }
            };

        public QuizView2()
        {
            BackgroundColor = Color.FromHex("#CDDC39");

            var logo = new Label()
            {
                Text = "MemoBicho",
                TextColor = Color.FromHex("#003200"),
                FontSize = 40,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center
            };

            var questionsLayout = new StackLayout() { Padding = 10 };
            questionsLayout.Children.Add(logo);
            questionsLayout.Children.Add(new Label()
            {
                Text = "Quiz nível 2",
                FontSize = 25,
                TextColor = Color.FromHex("#003200"),
                HorizontalTextAlignment = TextAlignment.Center
            });

            foreach (var question in questionsAndAnswers)
            {
                var questionLayout = new StackLayout() { Padding = 10 };
                questionLayout.Children.Add(new Label()
                {
                    Text = question.Key,
                    FontSize = 27,
                    TextColor = Color.FromHex("#003200"),
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
                        answerButton.TextColor = Color.FromHex("#003200");
                    }
                }
                
                questionLayout.Children.Add(answersButtons);
                questionsLayout.Children.Add(questionLayout);
            }

            var submitButton = new Button
            {
                Text = "Submeter respostas!",
                FontSize = 25,
                BackgroundColor = Color.FromHex("#1B5E20"),
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
                        Device.BeginInvokeOnMainThread(() => this.Navigation.PushModalAsync(new GridLayoutPage3()));
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
