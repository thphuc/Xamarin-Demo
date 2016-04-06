
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
	[Activity (Label = "EditTextDemoActivity")]			
	public class EditTextDemoActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your application here
			SetContentView(Resource.Layout.ActivityEditTextDemo);

			SetupUI ();
		}

		private void SetupUI () {
			var edtText = FindViewById<EditText> (Resource.Id.edt_text);
			var tvText = FindViewById<TextView> (Resource.Id.tv_text);

			edtText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
				tvText.Text = e.Text.ToString ();
			};
		}
	}
}

