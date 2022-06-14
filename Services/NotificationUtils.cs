using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Icu.Util;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Core.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeZone = Android.Icu.Util.TimeZone;

namespace AzkaryApp.Models
{
    public  class NotificationUtils
    {
        private static readonly int NOTIFICATION_ID = 9000;
        private static readonly int PENDING_INTENT_ID = 9001;
        private static readonly string NOTIFICATION_CHANNEL_ID = "azkarchanenl";
        private static NotificationCompat.Builder mNotificationBuilder;
        private static NotificationManager mNotificationManager;
        private static bool isNotificationNew= true;

        private NotificationUtils()
        {


        }

        // SHOW AND BUILD NOTIFICATION ON ANDRIOD SYSTEM 
        public static void showNotification(Context context, string title,string body)
        {
            if (isNotificationNew == false)
            {
                //  UPDATE NOTIFICATION CONTENT IF IT IS NOT NEW 
                updateNotification(title, body);

                return;
            }
            // CREATE NOTIFICATION MANGER;
            mNotificationManager =(NotificationManager) context.GetSystemService(Context.NotificationService);

            // CREATE NOTIFICATION CHANNEL ON ANDROID 8 OR ABOVE 

            if (Build.VERSION.SdkInt >=BuildVersionCodes.O)
            {
                // PREPARE NAME , DESCRIPTION AND PERIORTY OF CHANNEL 
                string channelName = "Awesome Notification Channel";
                string channelDescription = "This channel shows only awesome notificatios";
                NotificationImportance importance =  NotificationImportance.High;

                // CREATE CHANNEL AND REGISTER IT WITH THE SYSTEM
                NotificationChannel channel = new NotificationChannel(NOTIFICATION_CHANNEL_ID, channelName, importance);

                mNotificationManager.CreateNotificationChannel(channel);

                // SET CHANEEL DESCRIPTION 
                channel.Description = channelDescription;

                // CREATE NOTIFICATION WITH THE BUILDER
                mNotificationBuilder = new NotificationCompat.Builder(context, NOTIFICATION_CHANNEL_ID);

                // PUT ALL NOTIFICATIONS UNDER ONE AS A GROUP

                mNotificationBuilder.SetGroup(NotificationCompat.CategoryReminder);
                mNotificationBuilder.SetGroupSummary(true);

                // REQUIRED ICON FOR NOTIFICATION
                mNotificationBuilder.SetSmallIcon(Resource.Drawable.ic_home_black_24dp);

                // SET LARG ICON FOR NOTIFICATION OPTIONAL

                mNotificationBuilder.SetLargeIcon(largIcon(context));

                // SET TITLE TEXT
                mNotificationBuilder.SetContentTitle(title);

                //SET BODY TEXT
                mNotificationBuilder.SetContentText(body);

                // IF YOU WANT MORE TEXT USE STYLE FOR LONGER TEXT
                mNotificationBuilder.SetStyle(new NotificationCompat.BigTextStyle().BigText(body));

                // SET CONTENT INTENT WHEN NOTIFICATION USER TAP ON THIS WILL OPEN AN INTENT
                mNotificationBuilder.SetContentIntent(contentIntent(context));


                // SHOW NOTIFICATION ON LOCKSCREEN
                mNotificationBuilder.SetVisibility(NotificationCompat.VisibilityPublic);

                //ACTIONS 
                //mNotificationBuilder.AddAction(actionShareNotification(context, title, body));
                //mNotificationBuilder.AddAction(actionClaerNotification(context));


                mNotificationBuilder.SetAutoCancel(true);

                // CONFIGURATIONS TO NOTIFICATIONBUILDER ON ANDRIOD 7.1 AND LOWER

                if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBean && Build.VERSION.SdkInt < BuildVersionCodes.O)

                {

                    mNotificationBuilder.SetPriority(NotificationCompat.PriorityMax);

                }

                // BUILD NOTIFICATION

                mNotificationManager.Notify(NOTIFICATION_ID, mNotificationBuilder.Build());

                isNotificationNew = false;



            }


           
            
        }
        // UPDATE NOTIFICATION CONTENT AND 
        public static void updateNotification( string title , string body)
        {

            mNotificationBuilder.SetContentTitle(title)
                .SetContentText(body)
                .SetStyle(new NotificationCompat.BigTextStyle().BigText(body))
                .SetOnlyAlertOnce(false)
                .SetShowWhen(true)
                .SetWhen(Calendar.GetInstance(TimeZone.Default).TimeInMillis);

                          mNotificationManager.Notify(NOTIFICATION_ID, mNotificationBuilder.Build());


        }

        // SET CONTENT INTENT WHEN NOTIFICATION USER TAP ON THIS WILL OPEN AN INTENT

        private static PendingIntent contentIntent(Context context)
        {

            Intent startActivityIntent = new Intent(context, typeof(MainActivity));
            return PendingIntent.GetActivity(context, PENDING_INTENT_ID,
                startActivityIntent, PendingIntentFlags.UpdateCurrent);


        }
        // CREAT LARGICON FOR NOTIFICATION  FROM A DRWABLE 
        private static  Bitmap  largIcon(Context context)
        {
            Resources resource = context.Resources;
            Bitmap largIcon = BitmapFactory.DecodeResource(resource, Resource.Drawable.ic_book);

            return largIcon;

        }
          // CLEAR ALL NOTIFICATIONS  SOMETIMES WE NEED TO CALL IT BEFORE NEW NETOFOICATIONS
        public static void clearNotifications (Context context)
        {

            NotificationManager notificationManager = (NotificationManager) context.GetSystemService(Context.NotificationService);
            notificationManager.CancelAll();
        }

        // HELP TO SHARE THE NOTIFICATION CONTENT WITH OTHER APPS THROUG CHOOSER 
        public static void  shareNotification(Context context , string title , string body)
        {

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(title);
            stringBuilder.Append("\n");
            stringBuilder.Append(body);
            Intent intent = new Intent(Intent.ActionSend);
            intent.SetType("text/plain");
            intent.PutExtra(Intent.ExtraText, stringBuilder.ToString());
            context.StartActivity(Intent.CreateChooser(intent, "Choose the app you want to share on it"));



        }

        //private static NotificationCompat.Action actionShareNotification(Context context,string title, string body)

        //{

        //    Intent intent = new Intent (context,notificationser)




        //}

        
    }
}