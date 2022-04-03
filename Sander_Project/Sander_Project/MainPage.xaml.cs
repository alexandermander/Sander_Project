using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sander_Project
{
    public partial class MainPage : ContentPage
	{
		public string mysting;
		private string myStringProperty;
		public int value = 0;
		public string MyStringProperty
		{
			get { return myStringProperty; }
			set
			{
				myStringProperty = value;
				OnPropertyChanged(nameof(MyStringProperty)); // Notify that there was a change on this property
			}
		}

		public MainPage()
		{
			InitializeComponent();
			
		}

        public void HanderClicked(object sender, EventArgs args)
        {
			Console.WriteLine("sander is testing");
			BindingContext = this;
			value = value+1;
			Console.WriteLine(value);

			MyStringProperty = Convert.ToString(value);

		}

      
    }
}
