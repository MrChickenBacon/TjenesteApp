using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TjenesteApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
    {
		public HomePage ()
		{
			InitializeComponent ();
            HomePage1();
        }              

        private void HomePage1()
        {
            Content = new StackLayout()
            {                
                Children =
                {
                        new Image
                {
                        Source = "BakgrunnHome.png",
                },

                }

            };

        }
    }
}