using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinSDK.Droid
{
    [Activity(Label = "XamarinSDK", Theme="@style/Theme.Splash", MainLauncher = true, NoHistory = true, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Splash);

            Timer timer = new Timer();

            timer.Interval  = 1000;
            timer.AutoReset = false;

            timer.Elapsed += (object sender, ElapsedEventArgs e) =>
            {
                StartActivity(typeof(MainActivity));
            };

            timer.Start();
        }
    }
}
