using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace MemoBicho.UI
{
    public class QuizView : ContentPage
    {
        Dictionary<string, string> questionsAndAnswers = new Dictionary<string, string>()
            {
                { "Quanto é 1 + 1?", "2" },
                { "Quanto é 2 + 1?", "3" }
            };

        Dictionary<string, List<string>> answers = new Dictionary<string, List<string>>()
            {
                { "Quanto é 1 + 1?", new List<string>() { "7", "1", "2" } },
                { "Quanto é 2 + 1?", new List<string>() { "3", "1", "2" } }
            };

        public QuizView()
        {
            var stackLayout = new StackLayout() { Padding = 10 };
            foreach (var question in questionsAndAnswers)
            {
                var questionLayout = new StackLayout() { Padding = 10 };
                questionLayout.Children.Add(new Label() { Text = question.Key });

                var radioButtons = new BindableRadioGroup();
                radioButtons.CheckedChanged += RadioButtons_CheckedChanged; // If button clicked
                foreach (var filteredAnswers in answers.Where(a => a.Key == question.Key).Select(a => a.Value))
                    radioButtons.ItemsSource = filteredAnswers.ToArray();

                questionLayout.Children.Add(radioButtons);
                stackLayout.Children.Add(questionLayout);
            }

            var submitButton = new Button { Text = "Submeter respostas!", BackgroundColor = Color.FromHex("#8BC34A") };
            submitButton.Clicked += delegate
            {
            };

            var scrollView = new ScrollView();
            scrollView.Content = stackLayout;

            Content = scrollView;
        }

        private void RadioButtons_CheckedChanged(object sender, int e)
        {
            var button = (CustomRadioButton)sender;
            if (questionsAndAnswers.Where(a => a.Key == button.ClassId).FirstOrDefault().Value == button.Text)
                DisplayAlert("AEE","AEE","AEEEEE CARAI");
            else
                DisplayAlert("naooo", "AEE", "AEEEEE CARAI");
        }
    }
}
