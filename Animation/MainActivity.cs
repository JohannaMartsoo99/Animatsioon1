using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Animation
{
    [Activity(Label = "Animation", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            AppCenter.Start("810a9973-d125-4cb2-9074-46a180d95902",
                   typeof(Analytics), typeof(Crashes));
            AppCenter.Start("810a9973-d125-4cb2-9074-46a180d95902", typeof(Analytics), typeof(Crashes));

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

