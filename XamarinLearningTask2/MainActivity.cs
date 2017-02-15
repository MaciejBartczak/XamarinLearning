using Android.App;
using Android.Widget;
using Android.OS;
using System.Timers;
using System.Threading.Tasks;
using Java.Lang;

namespace XamarinLearningTask2
{
    [Activity(Label = "XamarinLearningTask2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button button;
        EditText input;
        TextView textField;
        string s;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView (Resource.Layout.Main);
            button = FindViewById<Button>(Resource.Id.button1);
            input = FindViewById<EditText>(Resource.Id.editText1);
            textField = FindViewById<TextView>(Resource.Id.textView1);

            



            button.Click += delegate
            {

                textField.Text = "";
                //textField.Text += input.Text.ToString().Substring(0, 1);
                //input.Text = input.Text.Remove(0, 1).ToString();
                Task.Factory.StartNew(() =>
                {
                    while (input.Text.Length > 0)
                    {
                        RunOnUiThread(() =>
                        {


                            textField.Text = textField.Text + input.Text.Substring(0, 1);
                            input.Text = input.Text.Substring(1);
                        });
                        Thread.Sleep(1000);
                    }
                });
            };

            
        }

        protected void Transportation(object source, ElapsedEventArgs e)
        {

            
            
            /*if (input.Text.ToString() != "")
            {
                textField.Text += input.Text.ToString().Substring(0, 1);
                input.Text.Remove(0, 1);
            }
            else
            {
                t.Stop();
            } */     
        }
    }
}

