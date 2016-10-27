using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MemoBicho.UI
{
    class ImageSquare : ContentPage
    {
        /*Image image;

        // Retain current Row and Col position.
        public int Index { private set; get; }
        public int Row { set; get; }
        public int Col { set; get; }

        public ImageSquare(Image image, int index)
        {
            this.Index = index;
            this.image = image;

            // A Frame surrounding two Labels.
            label = new Label
            {
                Text = this.normText,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label tinyLabel = new Label
            {
                Text = (index + 1).ToString(),
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                HorizontalOptions = LayoutOptions.End
            };

            this.Padding = new Thickness(3);
            this.Content = new Frame
            {
                OutlineColor = Color.Accent,
                Padding = new Thickness(5, 10, 5, 0),
                Content = new StackLayout
                {
                    Spacing = 0,
                    Children = {
                        label,
                        tinyLabel,
                    }
                }
            };

            // Don't let touch pass us by.
            // this.BackgroundColor = Color.Transparent;
            this.BackgroundColor = Color.Green;
        }

        public async Task AnimateWinAsync(bool isReverse)
        {
            uint length = 150;
            await Task.WhenAll(this.ScaleTo(3, length), this.RotateTo(180, length));
            label.Text = isReverse ? normText : winText;
            await Task.WhenAll(this.ScaleTo(1, length), this.RotateTo(360, length));
            this.Rotation = 0;
        }

        public void SetLabelFont(double fontSize, FontAttributes attributes)
        {
            label.FontSize = fontSize;
            label.FontAttributes = attributes;
        }*/
    }
}
