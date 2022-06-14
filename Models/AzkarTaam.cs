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
    public class AzkarTaam
    {
        public string ZekrName { get; set; }
        public int ZekrCount { get; set; }
        public int ZekrId { get; set; }


    }
    public class AzkarTaamData
    {
        private List<AzkarTaam> azkarTaams = new List<AzkarTaam>()
       {
           new AzkarTaam()
           {
               ZekrId = 1,
               ZekrCount= 1,
               ZekrName="الدُّعَــاءُ قَبْـــلَ الطَّــــعَامِ "+
              " إِذَا أَكَلَ أَحَدُكُمْ طَعَاماً فَلْيَقُلْ بِسْمِ اللَّهِ، فَإِنْ نَسِيَ فِي أَوَّلِهِ فَلْيَقُلْ بسمِ اللَّهِ فِي أَوَّلِهِ وَآخِرِهِ "

           },

           new AzkarTaam()
           {
               ZekrId = 2,
               ZekrCount= 1,
               ZekrName="الدُّعَــاءُ قَبْـــلَ الطَّــــعَامِ "+
               "مَنْ أَطْعَمَهُ اللَّهُ الطَّعَامَ فَلْيَقُلْ: اللَّهُمَّ بَارِكْ لَنَا فِيهِ وَأَطْعِمْنَا خَيْراً مِنْهُ، وَمَنْ سَقَاهُ اللَّهُ لَبَناً فَلْيَقُلْ اللَّهُمَّ بَارِكْ لَنَا فِيهِ وَزِدْنَا مِنْهُ"
           },
             new AzkarTaam()
           {
               ZekrId = 3,
               ZekrCount= 1,
                 ZekrName="الدُّعَــاءُ عِنْدَ الْفَـرَاغِ مِنَ الطَّــعَامِ"+
               " الْحَمْدُ لِلَّهِ الَّذِي أَطْعَمَنِي هَذَا، وَرَزَقَنِيهِ، مِنْ غَيْرِ حَوْلٍ مِنِّي وَلاَ قُوَّةٍ "
          }
             ,
             new AzkarTaam()
           {
               ZekrId = 4,
               ZekrCount= 1,
                 ZekrName="الدُّعَــاءُ عِنْدَ الْفَـرَاغِ مِنَ الطَّــعَامِ"+
               " الْحَمْدُ لِلَّهِ حَمْداً كَثِيراً طَيِّباً مُبَارَكاً فِيهِ، غَيْرَ مَكْفِيٍّ وَلاَ مُوَدَّعٍ، وَلاَ مُسْتَغْنَىً عَنْهُ رَبَّنَا "
          }
              ,
             new AzkarTaam()
           {
               ZekrId = 5,
               ZekrCount= 1,
                 ZekrName="دُعَــاءُ الضَّيْفِ لِصَـــاحِبِ الطَّعَامِ"+
               "  اللَّهُمَّ بَارِكْ لَهُمْ فِيمَا رَزَقْتَهُم، وَاغْفِرْ لَهُمْ وَارْحَمْهُمْ "
          }
                ,
             new AzkarTaam()
           {
               ZekrId = 6,
               ZekrCount= 1,
                 ZekrName="الدُّعَاءُ لِطَلَبِ الطَّعَامِ أَوِ الشَّرَابِ"+
               "اللَّهُمَّ أَطْعِمْ مَنْ أَطْعَمَنِي، وَاسْقِ مَنْ سَقَانِي "
          }

       };

        public List<AzkarTaam> AzkarTaams { get => azkarTaams; set => azkarTaams = value; }
    }
}