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
    public class AzkarFragment : AndroidX.Fragment.App.Fragment
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

            View view = inflater.Inflate(Resource.Layout.fragment_azkar, container, false);
            Button imgazkarsabah = view.FindViewById<Button>(Resource.Id.imgazkarsabah);
            imgazkarsabah.Click += Imgazkarsabah_Click;     
            
            Button imgazkarmasaa = view.FindViewById<Button>(Resource.Id.imgazkarmasaa);
            imgazkarmasaa.Click += Imgazkarmasaa_Click;

            Button imgazkaresteqaz = view.FindViewById<Button>(Resource.Id.imgazkaresteqaz);
            imgazkaresteqaz.Click += Imgazkaresteqaz_Click;

            Button imgazkarnoom = view.FindViewById<Button>(Resource.Id.imgazkarnoom);
            imgazkarnoom.Click += Imgazkarnoom_Click;

            Button imgazkarmasgad = view.FindViewById<Button>(Resource.Id.imgazkarmasgad);
            imgazkarmasgad.Click += Imgazkarmasged_Click;

            Button imgazkarmanzal = view.FindViewById<Button>(Resource.Id.imgazkarmanzal);
            imgazkarmanzal.Click += Imgazkarmanazel_Click;

            Button imgazkarkhalaa = view.FindViewById<Button>(Resource.Id.imgazkarkhalaa);
            imgazkarkhalaa.Click += Imgazkarkhalaa_Click;

            Button imgazkarsalaa = view.FindViewById<Button>(Resource.Id.imgazkarsalaa);
            imgazkarsalaa.Click += ImgazkarSalah_Click;

            Button imgazkartaamwasharp = view.FindViewById<Button>(Resource.Id.imgazkartaamwasharp);
            imgazkartaamwasharp.Click += ImgazkarTaam_Click;

            Button imgazkarazaan = view.FindViewById<Button>(Resource.Id.imgazkarazaan);
            imgazkarazaan.Click += ImgazkarAzaan_Click;

            Button imgazkarwedoow = view.FindViewById<Button>(Resource.Id.imgazkarwedoow);
            imgazkarwedoow.Click += ImgazkarWedoa_Click;

            Button imgazkarhegweomra = view.FindViewById<Button>(Resource.Id.imgazkarhegweomra);
            imgazkarhegweomra.Click += ImgazkarHeeg_Click;

            Button imgazkarkhoofwedeeq = view.FindViewById<Button>(Resource.Id.imgazkarkhoofwedeeq);
            imgazkarkhoofwedeeq.Click += ImgazkarHozn_Click;

            Button imgazkartasbeeh = view.FindViewById<Button>(Resource.Id.imgazkartasbeeh);

            imgazkartasbeeh.Click += ImgazkarTasbeeh_Click;



            return view;
        }

        private void Imgazkarsabah_Click(object sender, EventArgs e)
        {
            Intent sabahintent = new Intent(MainActivity, typeof(DisplayActivity));
            sabahintent.PutExtra("AzkarType", 1);
            StartActivity(sabahintent);

        }
        private void Imgazkarmasaa_Click(object sender, EventArgs e)
        {
            Intent masaahintent = new Intent(MainActivity, typeof(DisplayActivity));
            masaahintent.PutExtra("AzkarType", 2);
            StartActivity(masaahintent);

        }
         private void Imgazkaresteqaz_Click(object sender, EventArgs e)
        {
            Intent masaahintent = new Intent(MainActivity, typeof(DisplayActivity));
            masaahintent.PutExtra("AzkarType", 3);
            StartActivity(masaahintent);

        }
        private void Imgazkarnoom_Click(object sender, EventArgs e)
        {
            Intent masaahintent = new Intent(MainActivity, typeof(DisplayActivity));
            masaahintent.PutExtra("AzkarType", 4);
            StartActivity(masaahintent);

        }
        private void Imgazkarmasged_Click(object sender, EventArgs e)
        {
            Intent masaahintent = new Intent(MainActivity, typeof(DisplayActivity));
            masaahintent.PutExtra("AzkarType", 5);
            StartActivity(masaahintent);

        }
        private void Imgazkarmanazel_Click(object sender, EventArgs e)
        {
            Intent masaahintent = new Intent(MainActivity, typeof(DisplayActivity));
            masaahintent.PutExtra("AzkarType", 6);
            StartActivity(masaahintent);

        }
        private void Imgazkarkhalaa_Click(object sender, EventArgs e)
        {
            Intent masaahintent = new Intent(MainActivity, typeof(DisplayActivity));
            masaahintent.PutExtra("AzkarType", 7);
            StartActivity(masaahintent);

        }
        private void ImgazkarSalah_Click(object sender, EventArgs e)
        {
            Intent masaahintent = new Intent(MainActivity, typeof(DisplayActivity));
            masaahintent.PutExtra("AzkarType", 8);
            StartActivity(masaahintent);

        }
        private void ImgazkarTaam_Click(object sender, EventArgs e)
        {
            Intent masaahintent = new Intent(MainActivity, typeof(DisplayActivity));
            masaahintent.PutExtra("AzkarType", 9);
            StartActivity(masaahintent);

        }
        private void ImgazkarAzaan_Click(object sender, EventArgs e)
        {
            Intent masaahintent = new Intent(MainActivity, typeof(DisplayActivity));
            masaahintent.PutExtra("AzkarType", 10);
            StartActivity(masaahintent);

        }
        private void ImgazkarWedoa_Click(object sender, EventArgs e)
        {
            Intent masaahintent = new Intent(MainActivity, typeof(DisplayActivity));
            masaahintent.PutExtra("AzkarType", 11);
            StartActivity(masaahintent);

        }
        private void ImgazkarHeeg_Click(object sender, EventArgs e)
        {
            Intent masaahintent = new Intent(MainActivity, typeof(DisplayActivity));
            masaahintent.PutExtra("AzkarType", 12);
            StartActivity(masaahintent);

        }
        private void ImgazkarHozn_Click(object sender, EventArgs e)
        {
            Intent masaahintent = new Intent(MainActivity, typeof(DisplayActivity));
            masaahintent.PutExtra("AzkarType", 13);
            StartActivity(masaahintent);

        }
        private void ImgazkarTasbeeh_Click(object sender, EventArgs e)
        {
            Intent masaahintent = new Intent(MainActivity, typeof(DisplayActivity));
            masaahintent.PutExtra("AzkarType", 14);
            StartActivity(masaahintent);

        }
    }
}