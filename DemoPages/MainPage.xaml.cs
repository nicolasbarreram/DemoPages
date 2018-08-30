using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoPages
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void btn1_Clicked(object sender, EventArgs e)
        {
            Panel.Children.Add(new Button()
            {
                Text = $"Boton{Panel.Children.Count + 1}"
            });
        }
    }
}
