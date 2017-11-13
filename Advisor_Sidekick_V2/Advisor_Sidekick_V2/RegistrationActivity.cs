using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using static BCrypt.Net.BCrypt;

namespace Advisor_Sidekick_V2
{
    [Activity(Theme = "@android:style/Theme.Material.Light", Label = "RegistrationActivity")]
    public class RegistrationActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Registration);

            var d = new DbConnect();
            var username = FindViewById<EditText>(Resource.Id.usernameEditBox);
            var password = FindViewById<EditText>(Resource.Id.passwordEditBox);
            var firstname = FindViewById<EditText>(Resource.Id.firstNameEditBox);
            var lastname = FindViewById<EditText>(Resource.Id.lastNameEditBox);
            var address = FindViewById<EditText>(Resource.Id.addressEditBox);
            var phone = FindViewById<EditText>(Resource.Id.phoneNumberEditBox);
            var highschool = FindViewById<EditText>(Resource.Id.highschoolEditBox);
            var email = FindViewById<EditText>(Resource.Id.emailEditBox);
            const string hardSalt = "ETSU";

            var register = FindViewById<Button>(Resource.Id.registerButton);

            register.Click += (o, e) =>
            {
                var success = false;

                try
                {
                    var hash = HashPassword(password.Text + hardSalt);
                    //Eg.) For "password", hash "passwordETSU" with generated salt
                    d.InsertNewUser(username.Text.ToLower(), hash, firstname.Text, lastname.Text,
                        address.Text, phone.Text, highschool.Text, email.Text);
                    success = true;
                }
                finally
                {
                    if (success)
                    {
                        Toast.MakeText(this, "Registration Successful", ToastLength.Long).Show();
                        StartActivity(new Intent(this, typeof(MainActivity)));
                    }
                    else
                    {
                        Toast.MakeText(this, "Registration Failed", ToastLength.Short).Show();
                    }
                }
            };
        }
    }
}