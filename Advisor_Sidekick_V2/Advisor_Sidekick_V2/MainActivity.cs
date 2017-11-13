using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using static BCrypt.Net.BCrypt;

namespace Advisor_Sidekick_V2
{
    [Activity(Theme = "@android:style/Theme.Material.Light", Label = "Advisor SideKick", Icon = "@drawable/icon",
        MainLauncher = true)]
    public class MainActivity : Activity
    {
        private string _startPasstext1;
        private string _startUserText1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            // ReSharper disable once ObjectCreationAsStatement
            var login = FindViewById<Button>(Resource.Id.loginButton);
            var register = FindViewById<Button>(Resource.Id.registerButton);
            var startUserText = FindViewById<EditText>(Resource.Id.usernameTbox);
            var startPasstext = FindViewById<EditText>(Resource.Id.passwordTBox);
            const string hardSalt = "ETSU";

            startPasstext.Text = "password";
            startUserText.Text = "Username";

            login.Click += (sender, e) =>
            {
                _startUserText1 = startUserText.Text.ToLower();
                _startPasstext1 = startPasstext.Text;

                //verify password
                var db = new DbConnect();
                var hashInDatabase = db.VerifyPass(_startUserText1);

                if (Verify(_startPasstext1 + hardSalt, hashInDatabase.Trim()))
                {
                    var intent = new Intent(this, typeof(MajorList));
                    intent.PutExtra("User", _startUserText1);
                    StartActivity(intent);
                }
                else
                {
                    Toast.MakeText(this, "Invalid Username/Password", ToastLength.Long).Show();

                    StartActivity(new Intent(this, typeof(MainActivity)));
                }
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