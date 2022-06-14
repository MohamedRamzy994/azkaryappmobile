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
    public class AzkarKhalaa
    {
        public string ZekrName { get; set; }
        public int ZekrCount { get; set; }
        public int ZekrId { get; set; }


    }
    public class AzkarKhalaaData
    {
        private List<AzkarKhalaa> azkarKhalaas = new List<AzkarKhalaa>()
       {
           new AzkarKhalaa()
           {
               ZekrId = 1,
               ZekrCount= 1,
               ZekrName="دُعَـــاءُ دُخُـــــولِ الْخَــــــــلاءِ "+
              " بِسْمِ اللَّهِ اللَّهُمَّ إِنِّي أَعُوذُ بِكَ مِنَ الْخُبْثِ وَالْخَبائِث "

           },

           new AzkarKhalaa()
           {
               ZekrId = 2,
               ZekrCount= 1,
               ZekrName="دُعَاءُ الْخُـــــرُوجِ مِنَ الْخَـــــلاَءِ "+
               "غُفْرَانَكَ"
           }
                  
       };

        public List<AzkarKhalaa> AzkarKhalaas { get => azkarKhalaas; set => azkarKhalaas = value; }
    }
}