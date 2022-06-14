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
    public class AzkarWedoa
    {
        public string ZekrName { get; set; }
        public int ZekrCount { get; set; }
        public int ZekrId { get; set; }


    }
    public class AzkarWedoaData
    {
        private List<AzkarWedoa> azkarWedoas = new List<AzkarWedoa>()
       {
           new AzkarWedoa()
           {
               ZekrId = 1,
               ZekrCount= 1,
               ZekrName="الذِّكْرُ قَبْـــــــــلَ الْوُضُـــــوءِ" +
               " بِسْمِ اللَّهِ "
           },

           new AzkarWedoa()
           {
               ZekrId = 2,
               ZekrCount= 1,
               ZekrName="الذِّكْرُ بَعْدَ الْفَــرَاغِ مِنَ الْوُضُوءِ " +
               "أَشْهَدُ أَنْ لاَ إِلَهَ إِلاَّ اللَّهُ وَحْدَهُ لاَ شَرِيكَ لَهُ وَأَشْهَدُ أَنَّ مُحَمَّداً عَبْدُهُ وَرَسُولُهُ"
           },
             new AzkarWedoa()
           {
               ZekrId = 3,
               ZekrCount= 1,
               ZekrName= " بَعْدَ الْفَــرَاغِ مِنَ الْوُضُوءِ " +
                 "اللَّهُمَّ اجْعَلْنِي مِنَ التَّوَّابِينَ وَاجْعَلْنِي مِنَ الْمُتَطَهِّرِينَ "
           },
               new AzkarWedoa()
           {
               ZekrId = 4,
               ZekrCount= 1,
               ZekrName=   " بَعْدَ الْفَــرَاغِ مِنَ الْوُضُوءِ " +
                   "سُبْحانَكَ اللَّهُمَّ وَبِحَمْدِكَ، أَشْهَدُ أَنْ لاَ إِلَهَ إِلاَّ أَنْتَ، أَسْتَغْفِرُكَ وَأَتوبُ إِلَيْكَ "
           }
          





       };

        public List<AzkarWedoa> AzkarWedoas { get => azkarWedoas; set => azkarWedoas = value; }
    }
}