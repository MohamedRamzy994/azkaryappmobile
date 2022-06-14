using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Google.Android.Material.BottomNavigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fragment = AndroidX.Fragment.App.Fragment;

namespace AzkaryApp.Fragments
{
    public class HomeFragment : AndroidX.Fragment.App.Fragment
    {

        MainActivity MainActivity;


        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
             MainActivity = (MainActivity)Activity;
           

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            View view = inflater.Inflate(Resource.Layout.fragment_home, container,false);


            Button imgazkar =view.FindViewById<Button>(Resource.Id.imgazkar);
            imgazkar.Click += Imgazkar_Click;
            Button imgsettings = view.FindViewById<Button>(Resource.Id.imgsettings);
            imgsettings.Click += Imgsettings_Click;
            Button imgabout = view.FindViewById<Button>(Resource.Id.imgabout);
            imgabout.Click += Imgabout_Click;

            
           



            return view;
        }
        private void Imgabout_Click(object sender, System.EventArgs e)
        {
            MainActivity.ShowFragment(MainActivity.aboutfragment);
            MainActivity.FindViewById<BottomNavigationView>(Resource.Id.navigation)
          .SelectedItemId = Resource.Id.navigation_notifications;
        }

        private void Imgsettings_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this.Activity, typeof(NotificationsActivity));
            StartActivity(intent);
        }

        private void Imgazkar_Click(object sender, System.EventArgs e)
        {

           MainActivity.ShowFragment(MainActivity.azkarfragment);

            MainActivity.FindViewById<BottomNavigationView>(Resource.Id.navigation)
              .SelectedItemId = Resource.Id.navigation_dashboard;
        }
     





    }
}