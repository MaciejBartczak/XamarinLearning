using Android.App;
using Android.Widget;
using Android.OS;

namespace XamarinLearningTask3
{
    [Activity(Label = "XamarinLearningTask3", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var toggle = FindViewById<ToggleButton>(Resource.Id.toggleButton1);
            var radioGroup = FindViewById<RadioGroup>(Resource.Id.radioGroup1);
            var spinner = FindViewById<Spinner>(Resource.Id.spinner1);
            var radioButton1 = FindViewById<RadioButton>(Resource.Id.radioButton1);
            var radioButton2 = FindViewById<RadioButton>(Resource.Id.radioButton2);

            toggle.Checked = true;
            ArrayAdapter adapter = ArrayAdapter.CreateFromResource(this,
                                                    Resource.Array.italianFood,
                                                    Android.Resource.Layout.SimpleSpinnerItem);
            spinner.Adapter = adapter;


            toggle.CheckedChange += delegate
            {
                if (toggle.Checked)
                {
                    radioGroup.Visibility = Android.Views.ViewStates.Visible;
                    spinner.Visibility = Android.Views.ViewStates.Visible;
                }
                else
                {
                    radioGroup.Visibility = Android.Views.ViewStates.Invisible;
                    spinner.Visibility = Android.Views.ViewStates.Invisible;
                }
            };

            radioGroup.CheckedChange += delegate
            {

                if (radioButton1.Checked)
                {
                    adapter = ArrayAdapter.CreateFromResource(this,
                                                        Resource.Array.italianFood,
                                                        Android.Resource.Layout.SimpleSpinnerItem);
                    spinner.Adapter = adapter;
                }
                else
                {
                    adapter = ArrayAdapter.CreateFromResource(this,
                                                        Resource.Array.frenchFood,
                                                        Android.Resource.Layout.SimpleSpinnerItem);
                    spinner.Adapter = adapter;
                }
            };

            
        }
    }
}

