using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;

namespace XamarinLearning
{
    [Activity(Label = "XamarinLearning", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        Button button;
        bool statement = true;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

             SetContentView (Resource.Layout.Main);
            button = FindViewById<Button>(Resource.Id.myButton);
            button.SetBackgroundColor(Color.Blue);

            button.Click += delegate
            {
                if (statement)
                {
                    button.Text = "Change color to blue";
                    statement = false;
                    button.SetBackgroundColor(Color.Red);
                }
                else
                {
                    button.Text = "Change color to red";
                    statement = true;
                    button.SetBackgroundColor(Color.Blue);
                }


            };
        }

        
    }
}

