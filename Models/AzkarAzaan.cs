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
    public class AzkarAzaan
    {
        public string ZekrName { get; set; }
        public int ZekrCount { get; set; }
        public int ZekrId { get; set; }


    }
    public class AzkarAzaanData
    {
        private List<AzkarAzaan> azkarAzaans = new List<AzkarAzaan>()
       {
           new AzkarAzaan()
           {
               ZekrId = 1,
               ZekrCount= 1,
               ZekrName="( يَقُولُ مِثْلَ مَا يَقُولُ المُؤَذِّنُ إِلاَّ فِي (حَيَّ عَلَى الصَّلَاةِ وَحَيَّ عَلَى الْفَلَاحِ) فَيقُولُ: (لاَ حَوْلَ وَلاَ قُوَّةَ إِلاَّ بِاللَّهِ "
           },

           new AzkarAzaan()
           {
               ZekrId = 2,
               ZekrCount= 1,
               ZekrName=" (وَأَنَا أَشْهَدُ أَنْ لاَ إِلَهَ إِلاَّ اللَّهُ وَحْدَهُ لاَ شَرِيكَ لَهُ وَأَنَّ مُحَمَّداً عَبْدُهُ وَرَسُولُهُ، رَضِيتُ بِاللَّهِ رَبَّاً، وَبِمُحَمَّدٍ رَسُولاً، وَبِالْإِسْلاَمِ دِينَاً(يَقُولُ ذَلِكَ عَقِبَ تَشَهُّدِ الْمُؤَذِّنِ "
           },
             new AzkarAzaan()
           {
               ZekrId = 3,
               ZekrCount= 1,
               ZekrName="يُصَلِّي عَلَى النَّبِيِّ - صلى الله عليه وسلم - بَعْدَ فَرَاغِهِ مِنْ إِجَابَةِ الْمُؤَذِّنِ "
           },
               new AzkarAzaan()
           {
               ZekrId = 4,
               ZekrCount= 1,
               ZekrName=" اللَّهُمَّ رَبَّ هَذِهِ الدَّعْوَةِ التَّامَّةِ، وَالصَّلاَةِ الْقَائِمَةِ، آتِ مُحَمَّداً الْوَسِيلَةَ وَالْفَضِيلَةَ، وَابْعَثْهُ مَقَامَاً مَحمُوداً الَّذِي وَعَدْتَهُ، إِنَّكَ لَا تُخْلِفُ الْمِيعَادَ "
           }
             ,
               new AzkarAzaan()
           {
               ZekrId = 5,
               ZekrCount= 1,
               ZekrName="يَدْعُو لِنَفسِهِ بَيْنَ الْأَذَانِ وَالْإِقَامَةِ فَإِنَّ الدُّعَاءَ حِينَئِذٍ لاَ يُرَدُّ "
           }






       };

        public List<AzkarAzaan> AzkarAzaans { get => azkarAzaans; set => azkarAzaans = value; }
    }
}