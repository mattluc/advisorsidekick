using Android.App;
using Android.OS;

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
        }
    }
}