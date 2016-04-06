
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidControl.Droid
{
	[Activity (Label = "AutoCompleteTextViewActivity")]			
	public class AutoCompleteTextViewActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.ActivityAutoCompleteTextView);

			// Create your application here
			setupUI();
		}

		private void setupUI() {
			var autoCompleteOptions = new String[] { "Hello", "Hey", "Heja", "Hi", 
				"Hola", "Bonjour", "Gday", "Goodbye", "Sayonara", "Farewell", "Adios" };

			ArrayAdapter autoCompleteAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, 
				autoCompleteOptions);

			var autocompleteTextView = FindViewById<AutoCompleteTextView>(Resource.Id.auto_complete_textview);
			autocompleteTextView.Adapter = autoCompleteAdapter;
		}
	}
}

