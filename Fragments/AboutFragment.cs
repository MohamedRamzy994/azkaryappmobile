using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AzkaryApp.Fragments
{
    public class AboutFragment : AndroidX.Fragment.App.Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            View view = inflater.Inflate(Resource.Layout.fragment_about, container, false);

            Button assesstbtn = view.FindViewById<Button>(Resource.Id.button1);
            assesstbtn.Click += Assesstbtn_Click;

            Button sharebtn = view.FindViewById<Button>(Resource.Id.button2);
            sharebtn.Click += Sharebtn_Click; ;

            Button contactbtn = view.FindViewById<Button>(Resource.Id.button3);
            contactbtn.Click += Contactbtn_Click; ; ;

            return view;
        }

        private void Contactbtn_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(Intent.ActionDial);
          Android.Net.Uri phone = Android.Net.Uri.Parse("tel:+201061876572");
            
            intent.SetData(phone);

            StartActivity(intent);
        }

        private void Sharebtn_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(Intent.ActionSend);
            string text = "مشاركة تطبيق أذكار المسلم مع الأصدقاء  الدال على الخير كفاعله " + "http://www.playstore.com";
            intent.PutExtra(Intent.ExtraText,text );
            intent.SetType("text/plain");
            StartActivity(intent);
       
                }

        private void Assesstbtn_Click(object sender, EventArgs e)
        {
            AlertDialog.Builder alertDialog = new AlertDialog.Builder(this.Activity);
            alertDialog.SetIcon(Resource.Drawable.ic_launcher);
            alertDialog.SetMessage("كيف كانت تجربتك مع التطبيق ؟");
            alertDialog.SetNegativeButton("ذكرنى لاحقا", (sender, args) =>
            {

                ((AlertDialog)sender).Cancel();


            });

            alertDialog.SetView(LayoutInflater.Inflate(Resource.Layout.dialog_customassesst, null));
           
            alertDialog.Show();

        }
    }
}