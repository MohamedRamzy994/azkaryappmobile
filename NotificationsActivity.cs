using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AzkaryApp.Models;

namespace AzkaryApp
{
    
    [Activity(Label = "@string/title_settings", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, ParentActivity = typeof(MainActivity), Theme = "@style/AppTheme")]
    public class NotificationsActivity : AppCompatActivity
    {

        private CheckBox checkBox1, checkBox2, checkBox3;
        private NotificationsSettingsData notificationsSettingsData;
     

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            SupportActionBar.SetDisplayShowHomeEnabled(true);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            //SupportActionBar.SetDisplayUseLogoEnabled(true);
            //SupportActionBar.SetLogo(Resource.Mipmap.ic_launcher);
            SupportActionBar.SetDisplayShowTitleEnabled(true);
            // Create your application here

            this.SetContentView(Resource.Layout.activity_settings);
            notificationsSettingsData = new NotificationsSettingsData();
           checkBox1 = FindViewById<CheckBox>(Resource.Id.checkBox1);
            checkBox2 = FindViewById<CheckBox>(Resource.Id.checkBox2);
            checkBox3 = FindViewById<CheckBox>(Resource.Id.checkBox3);


            checkBox1.CheckedChange += CheckBox1_CheckedChange;
            checkBox2.CheckedChange += CheckBox2_CheckedChange;
            checkBox3.CheckedChange += CheckBox3_CheckedChange;

            notificationsSettingsData = RetriveSettings();

            checkBox1.Checked = notificationsSettingsData.NotificationsSettings.AzkarNotificationActivate;
            checkBox2.Checked = notificationsSettingsData.NotificationsSettings.NabyNotificationActivate;
            checkBox3.Checked = notificationsSettingsData.NotificationsSettings.EstghfarNotificationActivate;



        }


        private void CheckBox1_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {


            if (!checkBox1.Checked)
            {

                notificationsSettingsData.NotificationsSettings.AzkarNotificationActivate = false;

            }
            else
            {
                notificationsSettingsData.NotificationsSettings.AzkarNotificationActivate = true;

            }

            SaveSettings(notificationsSettingsData);
            

        }
        private void CheckBox2_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {


            if (!checkBox2.Checked)
            {
                notificationsSettingsData.NotificationsSettings.NabyNotificationActivate = false;

            }
            else
            {
                notificationsSettingsData.NotificationsSettings.NabyNotificationActivate = true;

            }
            SaveSettings(notificationsSettingsData);

            

        }
        private void CheckBox3_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {


            if (!checkBox3.Checked)
            {
                notificationsSettingsData.NotificationsSettings.EstghfarNotificationActivate = false;

            }
            else
            {
                notificationsSettingsData.NotificationsSettings.EstghfarNotificationActivate = true;

            }
            SaveSettings(notificationsSettingsData);
           

        }


        public void SaveSettings(NotificationsSettingsData notificationsSettingsData)
        {
            ISharedPreferences sharedPreferences = AndroidX.Preference.PreferenceManager.GetDefaultSharedPreferences(this);
            ISharedPreferencesEditor sharedPreferencesEditor = sharedPreferences.Edit();
            sharedPreferencesEditor.PutBoolean("AzkarNotificationActivate", notificationsSettingsData.NotificationsSettings.AzkarNotificationActivate);
            sharedPreferencesEditor.PutBoolean("NabyNotificationActivate", notificationsSettingsData.NotificationsSettings.NabyNotificationActivate);
            sharedPreferencesEditor.PutBoolean("EstghfarNotificationActivate", notificationsSettingsData.NotificationsSettings.EstghfarNotificationActivate);
            sharedPreferencesEditor.Apply();

        }
        public NotificationsSettingsData RetriveSettings()
        {
            ISharedPreferences sharedPreferences = AndroidX.Preference.PreferenceManager.GetDefaultSharedPreferences(this);
            NotificationsSettings notificationsSettings = new NotificationsSettings();
            notificationsSettings.AzkarNotificationActivate = sharedPreferences.GetBoolean("AzkarNotificationActivate",true);
            notificationsSettings.NabyNotificationActivate = sharedPreferences.GetBoolean("NabyNotificationActivate", true);
            notificationsSettings.EstghfarNotificationActivate = sharedPreferences.GetBoolean("EstghfarNotificationActivate", true);

            notificationsSettingsData.NotificationsSettings = notificationsSettings;
            return notificationsSettingsData;

        }



    }
}