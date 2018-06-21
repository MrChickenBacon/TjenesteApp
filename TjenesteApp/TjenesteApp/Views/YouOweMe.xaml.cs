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
	public partial class YouOweMe : ContentPage
	{
		public YouOweMe ()
		{
			InitializeComponent ();
            YouOwePage1();
        }

        private void YouOwePage1()
        {
            Content = new StackLayout()
            {
                Margin = 20,
                Children =
                {
                        new Entry
                {
                        Text = "Skriv noe her",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                },

                }

            };

        }

    }
}