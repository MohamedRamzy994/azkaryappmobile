using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AzkaryApp.Fragments;
using AndroidX.Fragment.App;
using System.Collections.Generic;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;
using Fragment = AndroidX.Fragment.App.Fragment;
using Android.Widget;
using AzkaryApp.Models;
using System.Threading.Tasks;
using Android.Content;
using System.Threading;

namespace AzkaryApp
{
    [Activity(Label = "@string/app_name",ScreenOrientation =Android.Content.PM.ScreenOrientation.Portrait,Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        public Fragment homefragment,azkarfragment,aboutfragment, selectedfragment;
        public Stack<Fragment> stackfragment;
        public AndroidX.Fragment.App.FragmentTransaction transactions = null;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            
           
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
           
            SetContentView(Resource.Layout.activity_main);



            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
          
            navigation.SetOnNavigationItemSelectedListener(this);

            SupportActionBar.SetDisplayShowHomeEnabled(true);
            SupportActionBar.SetDisplayUseLogoEnabled(true);
            SupportActionBar.SetLogo(Resource.Mipmap.ic_launcher);
            SupportActionBar.SetDisplayShowTitleEnabled(true);

            homefragment = new HomeFragment();
            azkarfragment = new AzkarFragment();
            aboutfragment = new AboutFragment();

            stackfragment = new Stack<Fragment>();
           

          transactions  = SupportFragmentManager.BeginTransaction();

            transactions.Add(Resource.Id.framelayout, homefragment, "HomeFragment");
            transactions.Show(homefragment);
            transactions.Add(Resource.Id.framelayout, azkarfragment, "AzkarFragment");
            transactions.Hide(azkarfragment);

            transactions.Add(Resource.Id.framelayout, aboutfragment, "AboutFragment");
            transactions.Hide(aboutfragment);

            transactions.Commit();
           
            selectedfragment = homefragment;

           
        }

        protected override void OnResume()
        {
            base.OnResume();
            for (int i = 0; i < SupportFragmentManager.BackStackEntryCount; i++)
            {
                SupportFragmentManager.PopBackStack();
                selectedfragment = stackfragment.Pop();
            }

            stackfragment.Clear();
            var transactions = SupportFragmentManager.BeginTransaction();
            
            transactions.Show(homefragment);
           
            transactions.Hide(azkarfragment);

           
            transactions.Hide(aboutfragment);

            transactions.Commit();

            selectedfragment = homefragment;



        }

       

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    ShowFragment(homefragment);
                    return true;
                case Resource.Id.navigation_dashboard:
                    ShowFragment(azkarfragment);
                    return true;
                case Resource.Id.navigation_notifications:
                    ShowFragment(aboutfragment);
                    return true;
            }
            return false;
        }
        public override void OnBackPressed()
        {
            if (SupportFragmentManager.BackStackEntryCount > 0)
            {
                SupportFragmentManager.PopBackStack();
                selectedfragment = stackfragment.Pop();
            }
            else
            {
                base.OnBackPressed();

            }
        }

        public  void ShowFragment(Fragment fragment)
        {
            var transactions = SupportFragmentManager.BeginTransaction();

            transactions.Hide(selectedfragment);
            transactions.Show(fragment);
            transactions.AddToBackStack(null);
            transactions.Commit();
            stackfragment.Push(selectedfragment);
            selectedfragment = fragment;

        }



    }
}

