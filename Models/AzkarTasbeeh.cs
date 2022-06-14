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
    public class AzkarTasbeeh
    {
        public string ZekrName { get; set; }
        public int ZekrCount { get; set; }
        public int ZekrId { get; set; }


    }
    public class AzkarTasbeehData
    {
        private List<AzkarTasbeeh> azkarTasbeehs = new List<AzkarTasbeeh>()
       {
           new AzkarTasbeeh()
           {
               ZekrId = 1,
               ZekrCount= 100,
               ZekrName="سُبْحَانَ اللَّهِ وَبِحَمْدِهِ  "
               +"(حُطَّتْ خَطَايَاهُ وَلَوْ كَانَتْ مِثْلَ زَبَدِ الْبَحْر)"
           },

           new AzkarTasbeeh()
           {
               ZekrId = 2,
               ZekrCount= 10,
               ZekrName="قَالَ لاَ إِلَهَ إِلاَّ اللَّهُ وَحْدَهُ لاَ شَرِيكَ لَهُ، لَهُ الْمُلْكُ، وَلَهُ الْحَمْدُ، وَهُوَ عَلَى كُلِّ شَيْءٍ قَدِيرٌ "
               +"(كَمَنْ أَعْتَقَ أَرْبَعَةَ أَنْفُسٍ مِنْ وَلَدِ إِسْمَاعِيلَ)"
           },
             new AzkarTasbeeh()
           {
               ZekrId = 3,
               ZekrCount= 100,
               ZekrName=" سُبْحَانَ اللَّهِ وَبِحَمْدِهِ، سُبْحانَ اللَّهِ الْعَظِيمِ "
                 +" (كَلِمَتَانِ خَفِيفَتَانِ عَلَى اللِّسَانِ، ثَقِيلَتَانِ فِي الْمِيزَانِ، حَبِيبَتَانِ إِلَى الرَّحْمَنِ)"
           },
               new AzkarTasbeeh()
           {
               ZekrId = 4,
               ZekrCount= 3,
               ZekrName=" سُبْحَانَ اللَّهِ، وَالْحَمْدُ لِلَّهِ، وَلاَ إِلَهَ إِلاَّ اللَّهُ، وَاللَّهُ أَكْبَرُ "
                  
           },
                 new AzkarTasbeeh()
           {
               ZekrId = 5,
               ZekrCount= 1,
               ZekrName="سُبْحَانَ اللَّهِ الْعَظِيمِ وَبِحَمْدِهِ " 
                 +" (غُرِسَتْ لَهُ نَخْلَةٌ فِي الْجَنَّةِ) "
                 }  ,
                   new AzkarTasbeeh()
           {
               ZekrId = 6,
               ZekrCount= 1,
               ZekrName=" لاَ حَوْلَ وَلاَ قُوَّةَ إِلاَّ بِاللَّهِ "+" ( كَنْزٍ مِنْ كُنُوزِ الْجَنَّةِ )"

           },
                     new AzkarTasbeeh()
           {
               ZekrId = 7,
               ZekrCount= 1,
               ZekrName="سُبْحَانَ اللَّهِ، وَالْحَمْدُ لِلَّهِ، وَلاَ إِلَهَ إِلاَّ اللَّهُ، وَاللَّهُ أَكْبَرُ"   + " (أَحَبُّ الْكَلاَمِ إِلَى اللَّهِ أَرْبَعٌ )"
           },
                       new AzkarTasbeeh()
           {
               ZekrId = 8,
               ZekrCount= 1,
               ZekrName="(( جَاءَ أَعْرَابِيٌّ إِلَى رَسُولِ اللَّهِ - صلى الله عليه وسلم - فَقَالَ: عَلِّمْنِي كَلاماً أَقُولُهُ: قَالَ: ((قُلْ: لاَ إِلَهَ إِلاَّ اللَّهُ وَحْدَهُ لاَ شَرِيكَ لَهُ، اللَّهُ أَكْبَرُ كَبِيراً، وَالْحَمْدُ لِلَّهِ كَثِيراً، سُبْحَانَ اللَّهِ رَبِّ العَالَمِينَ، لاَ حَوْلَ وَلاَ قُوَّةَ إِلاَّ بِاللَّهِ الْعَزِيزِ الْحَكِيمِ)) قَالَ: فَهَؤُلاَءِ لِرَبِّي، فَمَا لِي؟ قَالَ: ((قُلْ: اللَّهُمَّ اغْفِرْ لِي، وَارْحَمْنِي، وَاهْدِنِي، وَارْزُقْنِي))"
           },
                         new AzkarTasbeeh()
           {
               ZekrId = 9,
               ZekrCount= 1,
               ZekrName=" إِنَّ أَفْضَلَ الدُّعَاءِ الْحَمْدُ لِلَّهِ، وَأَفْضَلَ الذِّكْرِ لاَ إِلَهَ إِلاَّ اللَّهُ "
           },
                           new AzkarTasbeeh()
           {
               ZekrId = 10,
               ZekrCount= 3,
               ZekrName="(الْبَاقِيَاتُ الصَّالِحَاتُ: سُبْحَانَ اللَّهِ، وَالْحَمْدُ لِلَّهِ، وَلاَ إِلَهَ إِلاَّ اللَّهُ، وَاللَّهُ أَكْبَرُ، وَلاَ حَوْلَ وَلاَ قُوَّةَ إِلاَّ بِاللَّهِ)"
           }

       };

        public List<AzkarTasbeeh> AzkarTasbeehs { get => azkarTasbeehs; set => azkarTasbeehs = value; }
    }
}