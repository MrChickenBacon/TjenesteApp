using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TjenesteApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IOweYou : ContentPage
    {
        public IOweYou()
        {
            InitializeComponent();
            PageOwe1();
        }

        private void PageOwe1()
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
                        Text = "Skriv noe her OGSÅ123",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
                    new Button
                {
                        Text = "Send",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
            }
            };

        }
    }
}