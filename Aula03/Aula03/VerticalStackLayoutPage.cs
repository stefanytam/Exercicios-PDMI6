using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    class VerticalStackLayoutPage: ContentPage
    {
        public VerticalStackLayoutPage()
        {
            Title = "Vertical StackLayout demo";

            StackLayout stackLayout = new StackLayout();

            stackLayout.Add(new Label { Text = "Colors" });
            stackLayout.Add(new BoxView { Color = Colors.PaleVioletRed,HeightRequest=40 });
            stackLayout.Add(new BoxView { Color = Colors.YellowGreen, HeightRequest=40});
            stackLayout.Add(new BoxView { Color = Colors.CadetBlue, HeightRequest=40 });
            stackLayout.Add(new Label { Text = "Colors 2" });
            stackLayout.Add(new BoxView { Color = Colors.DarkGreen, HeightRequest = 40 });
            stackLayout.Add(new BoxView { Color = Colors.DarkOrange, HeightRequest = 40 });
            stackLayout.Add(new BoxView { Color = Colors.MediumPurple, HeightRequest = 40 });

            Content= stackLayout;
        }
    }
}
