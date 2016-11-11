using MemoBicho.Levels.Two;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace MemoBicho.Levels.One
{
    public class QuizView : ContentPage
    {
        Dictionary<string, string> questionsAndAnswers = new Dictionary<string, string>()
            {
                { "Qual a função das vibrissas nos gatos?", "Orientação em relação ao meio" },
                { "Em relação aos leões marque a alternativa correta:", "As leoas são as principais responsáveis pela caça." },
                { "Qual a principal diferença entre o cachorro e o gato?", "O gato pertence ao grupo dos felinos e cachorro ao grupo dos canídeos." },
                { "Em relação às hienas marque a alternativa errada:", "As hienas são herbívoras." }
            };

        Dictionary<string, List<string>> possibleAnswers = new Dictionary<string, List<string>>()
            {
                { "Qual a função das vibrissas nos gatos?", new List<string>() { "Orientação em relação ao meio",
                                                                                 "Proteção contra predadores",
                                                                                 "Atrativo sexual",
                                                                                 "Transpiração" } },
                { "Em relação aos leões marque a alternativa correta:", new List<string>() {
                                                          "A juba dos leões tem a função de proteger o animal.",
                                                          "Os leões são animais que pertencem ao grupo dos canídeos.",
                                                          "As leoas são as principais responsáveis pela caça.",
                                                          "Os leões são animais que não vivem em bandos." } },
                { "Qual a principal diferença entre o cachorro e o gato?", new List<string>() {
                                                          "O gato pertence ao grupo dos felinos e cachorro ao grupo dos canídeos.",
                                                          "O gato é domesticado e o cachorro não.",
                                                          "O cachorro é herbívoro e o gato carnívoro.",
                                                          "O gato não possui garras retrateis, os cachorros possuem." } },
                { "Em relação às hienas marque a alternativa errada:", new List<string>() {
                                                          "As hienas vivem em bandos.",
                                                          "As hienas são animais oportunistas e preferem se alimentar de animais mortos.",
                                                          "As hienas são mamíferos.",
                                                          "As hienas são herbívoras." } }
            };

        public QuizView()
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
                Text = "Quiz",
                FontSize = 25,
                TextColor = Color.FromHex("#003200"),
                HorizontalTextAlignment = TextAlignment.Center
            });

            foreach (var question in questionsAndAnswers)
            {
                var questionLayout = new StackLayout() { Padding = 10 };
                questionLayout.Children.Add(new Label()
                {
                    Text = question.Key, FontSize = 27,
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
                Text = "Submeter respostas!", FontSize = 25,
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
                        Device.BeginInvokeOnMainThread(() => this.Navigation.PushModalAsync(new GridLayoutPage2()));
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
