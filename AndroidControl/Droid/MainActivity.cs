using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidControl.Droid
{
	[Activity (Label = "AndroidControl", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		//int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			SetupUI ();
		}

		private void SetupUI () 
		{
			Button button = FindViewById<Button> (Resource.Id.btn_auto_complete_edit_text);

			button.Click += delegate {
				//button.Text = string.Format ("{0} clicks!", count++);
				StartActivity(typeof(AutoCompleteTextViewActivity));
			};

			Button btnEditTextDemo = FindViewById<Button> (Resource.Id.btn_edit_text_demo);
			btnEditTextDemo.Click += delegate {
				StartActivity (typeof(EditTextDemoActivity));
			};
		}
	}
}


