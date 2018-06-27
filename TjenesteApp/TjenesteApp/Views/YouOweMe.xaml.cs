using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TjenesteApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class YouOweMe : ContentPage
    {
        int counter;

        public YouOweMe()
        {
            InitializeComponent();
            YouOwePage1();            
        }

        private void PressMeButton_Clicked(object sender, EventArgs e)
        {
            counter++;
            (sender as Button).Text = "I was just clicked!";
            (sender as Button).Text = $"{counter}";
        }


        private void YouOwePage1()
        {
            var button1 = new Button
            {
                Text = "Push me",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            button1.Command = new Command(() => { PressMeButton_Clicked(button1, null); });

            Content = new StackLayout()
            {
                Margin = 20,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    new Label
                {
                        Text = "Add a job",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
                    new Entry
                {
                        Text = "Skriv noe her",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
                    new Entry
                {
                        Text = "Skriv noe her OGSÅ",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
                    new Button
                {
                        Text = "Send",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
                    
                    button1,

                    
                }
            };
        }        
    }
}