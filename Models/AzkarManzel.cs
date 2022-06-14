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
    public class AzkarManzel
    {
        public string ZekrName { get; set; }
        public int ZekrCount { get; set; }
        public int ZekrId { get; set; }


    }
    public class AzkarManzelData
    {
        private List<AzkarManzel> azkarManzels = new List<AzkarManzel>()
       {
           new AzkarManzel()
           {
               ZekrId = 1,
               ZekrCount= 1,
               ZekrName="الذِّكْرُ عِنْـــدَ دُخُـولِ الـمَنْــــزِلِ "+
              "بِسْمِ اللَّهِ وَلَجْنَا، وَبِسْمِ اللَّهِ خَرَجْنَا، وَعَلَى اللَّهِ رَبِّنَا تَوَكَّلْنَا، ثُمَّ لِيُسَلِّمْ عَلَى أَهْلِهِ"

           },

           new AzkarManzel()
           {
               ZekrId = 2,
               ZekrCount= 1,
               ZekrName="الذِّكْرُ عِنْدَ الْخُرُوجِ مِنَ الْمَنْزِلِ "+
               "بِسْمِ اللَّهِ، تَوَكَّلْتُ عَلَى اللَّهِ، وَلَاَ حَوْلَ وَلَا قُوَّةَ إِلاَّ بِاللَّهِ"
           },
             new AzkarManzel()
           {
               ZekrId = 3,
               ZekrCount= 1,
                 ZekrName="الذِّكْرُ عِنْدَ الْخُرُوجِ مِنَ الْمَنْزِلِ"+
               " اللَّهُمَّ إِنِّي أَعُوذُ بِكَ أَنْ أَضِلَّ، أَوْ أُضَلَّ، أَوْ أَزِلَّ، أَوْ أُزَلَّ، أَوْ أَظْلِمَ، أَوْ أُظْلَمَ، أَوْ أَجْهَلَ، أَوْ يُجْهَلَ عَلَيَّ "
          } 
                  
       };

        public List<AzkarManzel> AzkarManzels { get => azkarManzels; set => azkarManzels = value; }
    }
}