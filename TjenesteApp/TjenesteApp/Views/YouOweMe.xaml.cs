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
                    new Button
                {
                        Text = "Push me",
                        Command = new Command(() =>
                          {
}),
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                },

                    new Label
                {                        
                        Text = $"{counter}",
                },





                }
            };
        }        
    }
}