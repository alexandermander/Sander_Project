using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;

namespace Sander_Project
{
    public partial class MainPage : ContentPage
	{

		public SanderDatabase sanderDatabase;



		public MainPage()
		{
			InitializeComponent();
			
		}

		


		public void currentTD_Clicked(object sender, EventArgs e)
        {
			
			sanderDatabase.AddTime(timePickerA);

        }
    }
}
