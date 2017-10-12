using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace Advisor_Sidekick_V2
{
    [Activity(Theme = "@android:style/Theme.Material.Light", Label = "Advisor SideKick", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private string _startPasstext1;
        private string _startUserText1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var d = new DbConnect();
            var login = FindViewById<Button>(Resource.Id.loginButton);
            var register = FindViewById<Button>(Resource.Id.registerButton);
            var startUserText = FindViewById<EditText>(Resource.Id.usernameTbox);
            var startPasstext = FindViewById<EditText>(Resource.Id.usernameTbox);

            startPasstext.Text = "password";
            startUserText.Text = "Username";

            login.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MajorList));
                _startUserText1 = startUserText.Text;
                _startPasstext1 = startPasstext.Text;
                intent.PutExtra("User", _startUserText1);
                StartActivity(intent);
            };
            register.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(RegistrationActivity));
                StartActivity(intent);
            };
        }

        public string GetUsername()
        {
            return _startUserText1;
        }

        public string GetPassword()
        {
            return _startPasstext1;
        }
    }
}