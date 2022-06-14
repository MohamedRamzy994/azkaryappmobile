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
    public class AzkarMasged
    {
        public string ZekrName { get; set; }
        public int ZekrCount { get; set; }
        public int ZekrId { get; set; }


    }
    public class AzkarMasgedData
    {
        private List<AzkarMasged> azkarMasgeds = new List<AzkarMasged>()
       {
           new AzkarMasged()
           {
               ZekrId = 1,
               ZekrCount= 3,
               ZekrName="دُعَــاءُ الذَّهَابِ إِلَى الْـمَسْــجِدِ "+
               "اللَّهُمَّ اجْعَلْ فِي قَلْبِي نُوراً، وَفِي لِسَانِي نُوراً، وَفِي سَمْعِي نُوراً، وَفِي بَصَرِي نُوراً، وَمِنْ فَوْقِي نُوراً، وَمِنْ تَحْتِي نُوراً، وَعَنْ يَمِينِي نُوراً، وَعَنْ شِمَالِي نُوراً، وَمِنْ أَمَامِي نُوراً، وَمِنْ خَلْفِي نُوراً، وَاجْعَلْ فِي نَفْسِي نُوراً، وَأَعْظِمْ لِي نُوراً، وَعَظِّم لِي نُوراً، وَاجْعَلْ لِي نُوراً، وَاجْعَلْنِي نُوراً، اللَّهُمَّ أَعْطِنِي نُوراً، وَاجْعَلْ فِي عَصَبِي نُوراً، وَفِي لَحْمِي نُوراً، وَفِي دَمِي نُوراً، وَفِي شَعْرِي نُوراً، وَفِي بَشَرِي نُوراً"

           },

           new AzkarMasged()
           {
               ZekrId = 2,
               ZekrCount= 1,
               ZekrName="دُعَــاءُ الذَّهَابِ إِلَى الْـمَسْــجِدِ "+
               "  {اللَّهُمَّ اجْعَلْ لِي نُوراً فِي قَبْرِي وَنُوراً فِي عِظَامِي وَزِدْنِي نُوراً، وَزِدْنِي نُوراً، وَزِدْنِي نُوراً وَهَبْ لِي نُوراً عَلَى نُورٍ"
           },
             new AzkarMasged()
           {
               ZekrId = 3,
               ZekrCount= 1,
                 ZekrName="دعَـــاءُ دُخُــولِ الـمَسْــــجِدِ"+
               "(يَبْدَأُ بِرِجْلِهِ الْيُمْنَى)، وَيَقُولُ: (أَعُوذُ بِاللَّهِ العَظِيمِ، وَبِوَجْهِهِ الْكَرِيمِ، وَسُلْطَانِهِ الْقَدِيمِ، مِنَ الشَّيْطَانِ الرَّجِيمِ) [بِسْمِ اللَّهِ، وَالصَّلَاةُ وَالسَّلَامُ عَلَى رَسُولِ اللَّهِ] (اللَّهُمَّ افْتَحْ لِي أَبْوَابَ رَحْمَتِكَ)"
          },
               new AzkarMasged()
           {
               ZekrId = 4,
               ZekrCount= 1,
               ZekrName=" دُعَاءُ الْخُرُوجِ مِنَ الْـمَسْـــجِدِ"+
                   " (يَبْدَأُ بِرِجْلِهِ الْيُسْرَى) وَيَقُولُ: (بِسْمِ اللَّهِ وَالصّلَاةُ وَالسَّلَامُ عَلَى رَسُولِ اللَّهِ، اللَّهُمَّ إِنِّي أَسْأَلُكَ مِنْ فَضْلِك، اللَّهُمَّ اعْصِمْنِي مِنَ الشَّيْطَانِ الرَّجِيمِ) "
           }  
                  
       };

        public List<AzkarMasged> AzkarMasgeds { get => azkarMasgeds; set => azkarMasgeds = value; }
    }
}