using Plugin.SimpleAudioPlayer;
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
    public partial class IOweYou : ContentPage
    {
        private ISimpleAudioPlayer _player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
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
                Children =
                {
                        new Label
                {
                        Text="IOweYou!",
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
                        new Image
                {
                        Source = "Work_Mexican_Work.jpg",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
                        new Button
                {
                        Text = "work",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        Command = new Command(() =>
                        {
                            _player.Load("work.mp3");
                            _player.Play();
                        })
                },
                        new Button
                {
                        Text = "stop work",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        Command = new Command(() =>
                        {
                            _player.Stop();
                        })
                },

                }

            };

        }
    }
}