using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Disabillitato.Portable
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class wheelmap : ContentView
	{
		public wheelmap ()
		{
			InitializeComponent ();
		}

        public static implicit operator Page(wheelmap v)
        {
            throw new NotImplementedException();
        }
    }
}