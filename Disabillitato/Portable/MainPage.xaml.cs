using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Disabillitato.Portable
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            find_places_label_click();

        }

        void find_places_label_click()
        {
            find_places_label.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    //Write find places navigation here
                })
            });
        }

        void navigate_label_click()
        {
            navigate_label.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    //Write navigation page navigation here
                })
            });
        }

        void help_label_click()
        {
            help_label.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    //write help label navigation here
                })
            });
        }
    }
}
