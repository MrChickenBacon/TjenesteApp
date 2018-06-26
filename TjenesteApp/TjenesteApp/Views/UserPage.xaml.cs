using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TjenesteApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserPage : ContentPage
	{
		public UserPage ()
		{
			InitializeComponent ();
            UserPage1();
        }

        private void UserPage1()
        {
            Content = new StackLayout()
            {
                Margin = 20,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                        new Label
                {
                        Text = "Registrer bruker",
                        FontSize = 30,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,                       
                },
                        
                        new Entry
                {
                        Placeholder = "Skriv brukernavn her",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
                        new Entry
                {
                        Placeholder = "Skriv inn passord her",
                        IsPassword = true,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
                        new Button
                {
                        Text = "Send inn data",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                },

                }

            };

        }

    }
}