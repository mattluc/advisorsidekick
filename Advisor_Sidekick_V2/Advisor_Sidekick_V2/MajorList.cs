using Android.App;
using Android.OS;
using Android.Widget;

namespace Advisor_Sidekick_V2
{
    [Activity(Theme = "@android:style/Theme.Material.Light", Label = "Select Majors")]
    // ReSharper disable once UnusedMember.Global
    public class MajorList : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.MajorScreen);

            var major1 = FindViewById<CheckBox>(Resource.Id.checkBox1);
            var major2 = FindViewById<CheckBox>(Resource.Id.checkBox2);
            var major3 = FindViewById<CheckBox>(Resource.Id.checkBox3);
            var major4 = FindViewById<CheckBox>(Resource.Id.checkBox4);
            var major5 = FindViewById<CheckBox>(Resource.Id.checkBox5);
            var major6 = FindViewById<CheckBox>(Resource.Id.checkBox6);
            var major7 = FindViewById<CheckBox>(Resource.Id.checkBox7);
            var major8 = FindViewById<CheckBox>(Resource.Id.checkBox8);
            var major9 = FindViewById<CheckBox>(Resource.Id.checkBox9);
            var major10 = FindViewById<CheckBox>(Resource.Id.checkBox10);
            var major11 = FindViewById<CheckBox>(Resource.Id.checkBox11);
            var major12 = FindViewById<CheckBox>(Resource.Id.checkBox12);
            var major13 = FindViewById<CheckBox>(Resource.Id.checkBox13);
            var major14 = FindViewById<CheckBox>(Resource.Id.checkBox14);
            var major15 = FindViewById<CheckBox>(Resource.Id.checkBox15);
            var major16 = FindViewById<CheckBox>(Resource.Id.checkBox16);
            var major17 = FindViewById<CheckBox>(Resource.Id.checkBox17);
            var major18 = FindViewById<CheckBox>(Resource.Id.checkBox18);
            var major19 = FindViewById<CheckBox>(Resource.Id.checkBox19);
            var major20 = FindViewById<CheckBox>(Resource.Id.checkBox20);
            var major21 = FindViewById<CheckBox>(Resource.Id.checkBox21);
            var major22 = FindViewById<CheckBox>(Resource.Id.checkBox22);
            var major23 = FindViewById<CheckBox>(Resource.Id.checkBox23);
            var major24 = FindViewById<CheckBox>(Resource.Id.checkBox24);
            var major25 = FindViewById<CheckBox>(Resource.Id.checkBox25);
            var major26 = FindViewById<CheckBox>(Resource.Id.checkBox26);
            var major27 = FindViewById<CheckBox>(Resource.Id.checkBox27);
            var major28 = FindViewById<CheckBox>(Resource.Id.checkBox28);
            var major29 = FindViewById<CheckBox>(Resource.Id.checkBox29);
            var major30 = FindViewById<CheckBox>(Resource.Id.checkBox30);
            var major31 = FindViewById<CheckBox>(Resource.Id.checkBox31);
            var major32 = FindViewById<CheckBox>(Resource.Id.checkBox32);
            var major33 = FindViewById<CheckBox>(Resource.Id.checkBox33);
            var major34 = FindViewById<CheckBox>(Resource.Id.checkBox34);
            var major35 = FindViewById<CheckBox>(Resource.Id.checkBox35);
            var major36 = FindViewById<CheckBox>(Resource.Id.checkBox36);
            var major37 = FindViewById<CheckBox>(Resource.Id.checkBox37);
            var major38 = FindViewById<CheckBox>(Resource.Id.checkBox38);
            var major39 = FindViewById<CheckBox>(Resource.Id.checkBox39);
            var major40 = FindViewById<CheckBox>(Resource.Id.checkBox40);
            var major41 = FindViewById<CheckBox>(Resource.Id.checkBox41);
            var major42 = FindViewById<CheckBox>(Resource.Id.checkBox42);
            var major43 = FindViewById<CheckBox>(Resource.Id.checkBox43);
            var major44 = FindViewById<CheckBox>(Resource.Id.checkBox44);

            var save = FindViewById<Button>(Resource.Id.save);

            var selection = new bool[45]; //[0] false for 1 to 1 numbering

            //If current state from db is true
            //major1.Checked = true;
            //major2.Checked = true;
            //major3.Checked = true;
            //major4.Checked = true;
            //major5.Checked = true;

            //toast for reference
            //if (major1.Checked)
            //Toast.MakeText(this, "Selected", ToastLength.Short).Show();
            //else
            //Toast.MakeText(this, "Not selected", ToastLength.Short).Show();


            major1.Click += (o, e) =>
            {
                if (major1.Checked)
                    selection[1] = true;
                else
                    selection[1] = false;
            };
            major2.Click += (o, e) =>
            {
                if (major2.Checked)
                    selection[2] = true;
                else
                    selection[2] = false;
            };
            major3.Click += (o, e) =>
            {
                if (major3.Checked)
                    selection[3] = true;
                else
                    selection[3] = false;
            };
            major4.Click += (o, e) =>
            {
                if (major4.Checked)
                    selection[4] = true;
                else
                    selection[4] = false;
            };
            major5.Click += (o, e) =>
            {
                if (major5.Checked)
                    selection[5] = true;
                else
                    selection[5] = false;
            };
            major6.Click += (o, e) =>
            {
                if (major6.Checked)
                    selection[6] = true;
                else
                    selection[6] = false;
            };
            major7.Click += (o, e) =>
            {
                if (major7.Checked)
                    selection[7] = true;
                else
                    selection[7] = false;
            };
            major8.Click += (o, e) =>
            {
                if (major8.Checked)
                    selection[8] = true;
                else
                    selection[8] = false;
            };
            major9.Click += (o, e) =>
            {
                if (major9.Checked)
                    selection[9] = true;
                else
                    selection[9] = false;
            };
            major10.Click += (o, e) =>
            {
                if (major10.Checked)
                    selection[10] = true;
                else
                    selection[10] = false;
            };
            major11.Click += (o, e) =>
            {
                if (major11.Checked)
                    selection[11] = true;
                else
                    selection[11] = false;
            };
            major12.Click += (o, e) =>
            {
                if (major12.Checked)
                    selection[12] = true;
                else
                    selection[12] = false;
            };
            major13.Click += (o, e) =>
            {
                if (major13.Checked)
                    selection[13] = true;
                else
                    selection[13] = false;
            };
            major14.Click += (o, e) =>
            {
                if (major14.Checked)
                    selection[14] = true;
                else
                    selection[14] = false;
            };
            major15.Click += (o, e) =>
            {
                if (major15.Checked)
                    selection[15] = true;
                else
                    selection[15] = false;
            };
            major16.Click += (o, e) =>
            {
                if (major16.Checked)
                    selection[16] = true;
                else
                    selection[16] = false;
            };
            major17.Click += (o, e) =>
            {
                if (major17.Checked)
                    selection[17] = true;
                else
                    selection[17] = false;
            };
            major18.Click += (o, e) =>
            {
                if (major18.Checked)
                    selection[18] = true;
                else
                    selection[18] = false;
            };
            major19.Click += (o, e) =>
            {
                if (major19.Checked)
                    selection[19] = true;
                else
                    selection[19] = false;
            };
            major20.Click += (o, e) =>
            {
                if (major20.Checked)
                    selection[20] = true;
                else
                    selection[20] = false;
            };
            major21.Click += (o, e) =>
            {
                if (major21.Checked)
                    selection[21] = true;
                else
                    selection[21] = false;
            };
            major22.Click += (o, e) =>
            {
                if (major22.Checked)
                    selection[22] = true;
                else
                    selection[22] = false;
            };
            major23.Click += (o, e) =>
            {
                if (major23.Checked)
                    selection[23] = true;
                else
                    selection[23] = false;
            };
            major24.Click += (o, e) =>
            {
                if (major24.Checked)
                    selection[24] = true;
                else
                    selection[24] = false;
            };
            major25.Click += (o, e) =>
            {
                if (major25.Checked)
                    selection[25] = true;
                else
                    selection[25] = false;
            };
            major26.Click += (o, e) =>
            {
                if (major26.Checked)
                    selection[26] = true;
                else
                    selection[26] = false;
            };
            major27.Click += (o, e) =>
            {
                if (major27.Checked)
                    selection[27] = true;
                else
                    selection[27] = false;
            };
            major28.Click += (o, e) =>
            {
                if (major28.Checked)
                    selection[28] = true;
                else
                    selection[28] = false;
            };
            major29.Click += (o, e) =>
            {
                if (major29.Checked)
                    selection[29] = true;
                else
                    selection[29] = false;
            };
            major30.Click += (o, e) =>
            {
                if (major30.Checked)
                    selection[30] = true;
                else
                    selection[30] = false;
            };
            major31.Click += (o, e) =>
            {
                if (major31.Checked)
                    selection[31] = true;
                else
                    selection[31] = false;
            };
            major32.Click += (o, e) =>
            {
                if (major32.Checked)
                    selection[32] = true;
                else
                    selection[32] = false;
            };
            major33.Click += (o, e) =>
            {
                if (major33.Checked)
                    selection[33] = true;
                else
                    selection[33] = false;
            };
            major34.Click += (o, e) =>
            {
                if (major34.Checked)
                    selection[34] = true;
                else
                    selection[34] = false;
            };
            major35.Click += (o, e) =>
            {
                if (major35.Checked)
                    selection[35] = true;
                else
                    selection[35] = false;
            };
            major36.Click += (o, e) =>
            {
                if (major36.Checked)
                    selection[36] = true;
                else
                    selection[36] = false;
            };
            major37.Click += (o, e) =>
            {
                if (major37.Checked)
                    selection[37] = true;
                else
                    selection[37] = false;
            };
            major38.Click += (o, e) =>
            {
                if (major38.Checked)
                    selection[38] = true;
                else
                    selection[38] = false;
            };
            major39.Click += (o, e) =>
            {
                if (major39.Checked)
                    selection[39] = true;
                else
                    selection[39] = false;
            };
            major40.Click += (o, e) =>
            {
                if (major40.Checked)
                    selection[40] = true;
                else
                    selection[40] = false;
            };
            major41.Click += (o, e) =>
            {
                if (major41.Checked)
                    selection[41] = true;
                else
                    selection[41] = false;
            };
            major42.Click += (o, e) =>
            {
                if (major42.Checked)
                    selection[42] = true;
                else
                    selection[42] = false;
            };
            major43.Click += (o, e) =>
            {
                if (major43.Checked)
                    selection[43] = true;
                else
                    selection[43] = false;
            };
            major44.Click += (o, e) =>
            {
                if (major44.Checked)
                    selection[44] = true;
                else
                    selection[44] = false;
            };

            //if(major44.Checked)
            save.Click += (o, e) =>
            {
                var count = 0;
                for (var i = 1; i < 45; i++)
                    if (selection[i])
                        count++;
                //attempt to save row-wise with selection?
                //remember [0] offset
                Toast.MakeText(this, count + " Majors Saved", ToastLength.Short).Show();

                //or not saved if there was an error
                //Toast.MakeText(this, "Error Message", ToastLength.Short).Show();
            };
        }
    }
}