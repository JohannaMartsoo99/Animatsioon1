using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;

namespace Animation
{
    [Activity(Label = "Animation", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
        public override void OnWindowFocusChanged(bool hasFocus)
        {
            if (hasFocus)
            {
                ImageView imageView = FindViewById<ImageView>(Resource.Id.animated_android);
                AnimationDrawable animation1 = (AnimationDrawable)imageView.Drawable;
                animation1.Start();
            }
        }
    }    
}

