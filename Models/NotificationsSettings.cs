using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AzkaryApp.Models
{
    public class NotificationsSettings
    {
        public bool  AzkarNotificationActivate { get; set; }
        public bool NabyNotificationActivate { get; set; }
        public bool EstghfarNotificationActivate { get; set; }




    }

    public class NotificationsSettingsData
    {
        private NotificationsSettings notificationsSettings = new NotificationsSettings()
        {
            AzkarNotificationActivate = true,
            EstghfarNotificationActivate = true,
            NabyNotificationActivate = true


        };

        public NotificationsSettings NotificationsSettings { get => notificationsSettings; set => notificationsSettings = value; }
   }


}