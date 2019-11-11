﻿using Foundation;
using UIKit;

namespace SentimentAnalysis.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

#if DEBUG
            Xamarin.Calabash.Start();
#endif

            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}
