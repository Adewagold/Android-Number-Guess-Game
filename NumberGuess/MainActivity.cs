using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace NumberGuess
{
    [Activity(Label = "Number Guess", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        //int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);
            Button GuessAgain = FindViewById<Button>(Resource.Id.guessAgain);

            button.Click += delegate {
                button.Visibility = ViewStates.Gone;
                GuessAgain.Visibility = ViewStates.Visible;
            };

            GuessAgain.Click += delegate {
                button.Visibility = ViewStates.Visible;
                GuessAgain.Visibility = ViewStates.Gone;
            };
        }
    }
}

