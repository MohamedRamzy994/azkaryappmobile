using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AzkaryApp.Models
{
    [Service]
    public class NotificationServices : Service
    {
        private Timer _timer;
        public AzkarHoznData AzkarHoznData;
        public AzkarTasbeehData AzkarTasbeehData;
        public NotificationsSettingsData notificationsSettings;
        private Random random;
        

        public NotificationServices()
        {
            this.AzkarHoznData = new AzkarHoznData();
            this.AzkarTasbeehData = new AzkarTasbeehData();
            random = new Random();
            this.notificationsSettings = new NotificationsSettingsData();
           

        }
       

        [return: GeneratedEnum]
        public override StartCommandResult OnStartCommand(Intent intent, [GeneratedEnum] StartCommandFlags flags, int startId)
        {
            this.notificationsSettings = RetriveSettings();

            if (notificationsSettings.NotificationsSettings.AzkarNotificationActivate == true)
            {
                _timer = new Timer((o) =>
                {
                    int index = random.Next(10);
                    string body = AzkarHoznData.AzkarHozns[index].ZekrName.ToString();

                    NotificationUtils.showNotification(Application.Context, this.GetString(Resource.String.app_name), body);

                }, null, 10000, 660000);

            }



            if (notificationsSettings.NotificationsSettings.NabyNotificationActivate == true)
            {

                _timer = new Timer((o) =>
                {
                    MediaPlayer mediaPlayer = new MediaPlayer();
                    AssetFileDescriptor assetFileDescriptor = Assets.OpenFd("tune.mp3");
                    mediaPlayer.SetDataSource(assetFileDescriptor.FileDescriptor, assetFileDescriptor.StartOffset, assetFileDescriptor.Length);
                    assetFileDescriptor.Close();
                    mediaPlayer.Prepare();
                    mediaPlayer.SetVolume(1f, 1f);
                    mediaPlayer.Looping = false;
                    mediaPlayer.Start();
                    
                    

                    NotificationUtils.showNotification(Application.Context, this.GetString(Resource.String.app_name), "اللهم صلى على سيدنا محمد");

                }, null, 1000, 300000);



            }

            if (notificationsSettings.NotificationsSettings.EstghfarNotificationActivate == true)
            {

                _timer = new Timer((o) =>
                {
                    MediaPlayer mediaPlayer = new MediaPlayer();
                    AssetFileDescriptor assetFileDescriptor = Assets.OpenFd("tune2.mp3");
                    mediaPlayer.SetDataSource(assetFileDescriptor.FileDescriptor, assetFileDescriptor.StartOffset, assetFileDescriptor.Length);
                    assetFileDescriptor.Close();
                    mediaPlayer.Prepare();
                    mediaPlayer.SetVolume(1f, 1f);
                    mediaPlayer.Looping = false;
                    mediaPlayer.Start();

                    NotificationUtils.showNotification(Application.Context, this.GetString(Resource.String.app_name), "    أستغفر الله العظيم و أتوب إليه");
                    
                    
                }, null, 240000, 1860000);



            }


            return StartCommandResult.Sticky;
        }



        public NotificationsSettingsData RetriveSettings()
        {
            ISharedPreferences sharedPreferences = AndroidX.Preference.PreferenceManager.GetDefaultSharedPreferences(this);
            notificationsSettings.NotificationsSettings.AzkarNotificationActivate = sharedPreferences.GetBoolean("AzkarNotificationActivate", true);
            notificationsSettings.NotificationsSettings.NabyNotificationActivate = sharedPreferences.GetBoolean("NabyNotificationActivate", true);
            notificationsSettings.NotificationsSettings.EstghfarNotificationActivate = sharedPreferences.GetBoolean("EstghfarNotificationActivate", true);

            return notificationsSettings;

        }

        public override IBinder OnBind(Intent intent)
        {
            throw new NotImplementedException();
        }
       
    }

}