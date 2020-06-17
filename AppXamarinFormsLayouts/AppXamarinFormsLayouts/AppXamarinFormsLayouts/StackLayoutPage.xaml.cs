using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarinFormsLayouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayoutPage : ContentPage
    {
        public StackLayoutPage()
        {
            InitializeComponent();

            //1ª maneira de fazer com código c#:
            //var layout = new StackLayout
            //{
            //    BackgroundColor = Color.Silver,
            //    Spacing = 20,
            //    Padding = new Thickness(10, 20, 10, 10),
            //    Orientation = StackOrientation.Vertical
            //};

            //layout.Children.Add(new Label { Text = "Label 1", BackgroundColor = Color.Aqua });
            //layout.Children.Add(new Button { Text = "Button 1", BackgroundColor = Color.Aqua });

            //Content = layout;

            //2ª maneira de fazer com código c#:
            StackLayout stackLayout = new StackLayout
            {
                BackgroundColor = Color.Yellow,
                Spacing = 20,
                Padding = new Thickness(10, 20, 10, 10),
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center,

                Children =
                {
                    new Label
                    {
                        Text="Xamarin Forms",
                        BackgroundColor=Color.Silver,
                        HorizontalOptions = LayoutOptions.Start
                    },

                    new Label
                    {
                        Text="Macoratti.net",
                        BackgroundColor=Color.Silver,
                        HorizontalOptions = LayoutOptions.Center
                    },

                    new StackLayout
                    {
                        BackgroundColor = Color.Silver,
                        Spacing = 10,
                        Padding = new Thickness(30),
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.Center,

                        Children =
                        {
                            new Label
                            {
                                Text="Label 1",
                                BackgroundColor=Color.Red,
                            }
                        }
                    }
                },
            };

            Content = stackLayout;
        }
    }
}


