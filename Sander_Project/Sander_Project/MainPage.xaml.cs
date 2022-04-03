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
		public MainPage()
		{
			InitializeComponent();
			
		}

        private void currentTD_Clicked(object sender, EventArgs e)
        {
			var dateA = timePickerA.Time;
			var dateB = timePickerB.Time;
			string strDate = Convert.ToString(dateB - dateA);
			myText.Text = strDate;

		}
    }
}
