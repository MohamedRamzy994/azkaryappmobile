﻿using Android.App;
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
    public class AzkarSabah
    {
        public string ZekrName { get; set; }
        public int ZekrCount { get; set; }
        public int ZekrId { get; set; }


    }
    public class AzkarSabahData
    {
        private List<AzkarSabah> azkarSabahs = new List<AzkarSabah>()
       {
           new AzkarSabah()
           {
               ZekrId = 1,
               ZekrCount= 1,
               ZekrName="أَعُوذُ بِاللَّهِ مِنَ الشَّيطَانِ الرَّجِيمِ *اللَّهُ لاَ إِلَهَ إِلاَّ هُوَ الْحَيُّ الْقَيُّومُ لاَ تَأْخُذُهُ سِنَةٌ وَلاَ نَوْمٌ لَّهُ مَا فِي السَّمَوَاتِ وَمَا فِي الأَرْضِ مَن ذَا الَّذِي يَشْفَعُ عِنْدَهُ إِلاَّ بِإِذْنِهِ يَعْلَمُ مَا بَيْنَ أَيْدِيهِمْ وَمَا خَلْفَهُمْ وَلاَ يُحِيطُونَ بِشَيْءٍمِّنْ عِلْمِهِ إِلاَّ بِمَا شَاء وَسِعَ كُرْسِيُّهُ السَّمَوَاتِ وَالْأَرْضَ وَلاَ يَؤُودُهُ حِفْظُهُمَا وَهُوَ الْعَلِيُّ الْعَظِيمُ "
           },

           new AzkarSabah()
           {
               ZekrId = 2,
               ZekrCount= 3,
               ZekrName="قُلْ هُوَ اللَّهُ أَحَدٌ* اللَّهُ الصَّمَدُ* لَمْ يَلِدْ وَلَمْ يُولَدْ* وَلَمْ يَكُن لَّهُ كُفُواً أَحَدٌ"
           },
             new AzkarSabah()
           {
               ZekrId = 3,
               ZekrCount= 3,
               ZekrName="قُلْ أَعُوذُ بِرَبِّ الْفَلَقِ* مِن شَرِّ مَا خَلَقَ* وَمِن شَرِّ غَاسِقٍ إِذَا وَقَبَ* وَمِن شَرِّ النَّفَّاثَاتِ فِي الْعُقَدِ* وَمِن شَرِّ حَاسِدٍ إِذَا حَسَدَ"
           },
               new AzkarSabah()
           {
               ZekrId = 4,
               ZekrCount= 3,
               ZekrName="قُلْ أَعُوذُ بِرَبِّ النَّاسِ* مَلِكِ النَّاسِ* إِلَهِ النَّاسِ* مِن شَرِّ الْوَسْوَاسِ الْخَنَّاسِ* الَّذِي يُوَسْوِسُ فِي صُدُورِ النَّاسِ* مِنَ الْجِنَّةِ وَ النَّاسِ"
           },
                 new AzkarSabah()
           {
               ZekrId = 5,
               ZekrCount= 1,
               ZekrName="أَصْبَحْنَا وَأَصْبَحَ الْمُلْكُ لِلَّهِ، وَالْحَمْدُ لِلَّهِ، لاَ إِلَهَ إلاَّ اللَّهُ وَحْدَهُ " +
"لاَ شَرِيكَ لَهُ، لَهُ الْمُلْكُ وَلَهُ الْحَمْدُ وَهُوَ عَلَى كُلِّ شَيْءٍ قَدِيرٌ، رَبِّ "+
"أَسْأَلُكَ خَيْرَ مَا فِي هَذَا الْيَوْمِ وَخَيرَ مَا بَعْدَهُ، وَأَعُوذُ بِكَ مِنْ شَرِّ مَا فِي" +
"هَذَا الْيَوْمِ وَشَرِّ مَا بَعْدَهُ، رَبِّ أَعُوذُ بِكَ مِنَ الْكَسَلِ وَسُوءِ الْكِبَرِ، رَبِّ أَعُوذُ بِكَ مِنْ عَذَابٍ فِي النَّارِ وَعَذَابٍ فِي الْقَبْرِ"
           },
                   new AzkarSabah()
           {
               ZekrId = 6,
               ZekrCount= 1,
               ZekrName="اللَّهُمَّ بِكَ أَصْبَحْنَا، وَبِكَ أَمْسَيْنَا، وَبِكَ نَحْيَا، وَبِكَ نَمُوتُ وَإِلَيْكَ النُّشُورُ"
           },
                     new AzkarSabah()
           {
               ZekrId = 7,
               ZekrCount= 1,
               ZekrName="اللَّهُمَّ أَنْتَ رَبِّي لَا إِلَهَ إِلاَّ أَنْتَ، خَلَقْتَنِي وَأَنَا عَبْدُكَ، وَأَنَا عَلَى عَهْدِكَ وَوَعْدِكَ مَا اسْتَطَعْتُ، أَعُوذُ بِكَ مِنْ شَرِّ مَا صَنَعْتُ، أَبُوءُ لَكَ بِنِعْمَتِكَ عَلَيَّ، وَأَبُوءُ بِذَنْبِي فَاغْفِرْ لِي فَإِنَّهُ لاَ يَغْفِرُ الذُّنوبَ إِلاَّ أَنْتَ"
           },
                       new AzkarSabah()
           {
               ZekrId = 8,
               ZekrCount= 4,
               ZekrName="اللَّهُمَّ إِنِّي أَصْبَحْتُ أُشْهِدُكَ، وَأُشْهِدُ حَمَلَةَ عَرْشِكَ، وَمَلاَئِكَتِكَ، وَجَمِيعَ خَلْقِكَ، أَنَّكَ أَنْتَ اللَّهُ لَا إِلَهَ إِلاَّ أَنْتَ وَحْدَكَ لاَ شَرِيكَ لَكَ، وَأَنَّ مُحَمَّداً عَبْدُكَ وَرَسُولُكَ"
           },
                         new AzkarSabah()
           {
               ZekrId = 9,
               ZekrCount= 1,
               ZekrName="اللَّهُمَّ مَا أَصْبَحَ بِي مِنْ نِعْمَةٍ أَوْ بِأَحَدٍ مِنْ خَلْقِكَ فَمِنْكَ وَحْدَكَ لاَ شَرِيكَ لَكَ، فَلَكَ الْحَمْدُ وَلَكَ الشُّكْر"
           },
                           new AzkarSabah()
           {
               ZekrId = 10,
               ZekrCount= 3,
               ZekrName="اللَّهُمَّ عَافِنِي فِي بَدَنِي، اللَّهُمَّ عَافِنِي فِي سَمْعِي، اللَّهُمَّ عَافِنِي "+
"فِي بَصَرِي، لاَ إِلَهَ إِلاَّ أَنْتَ. اللَّهُمَّ"+
"إِنِّي أَعُوذُ بِكَ مِنَ الْكُفْرِ، وَالفَقْرِ، وَأَعُوذُ بِكَ مِنْ عَذَابِ القَبْرِ، لاَ إِلَهَ إِلاَّ أَنْتَ"
           },
                         new AzkarSabah()
           {
               ZekrId = 11,
               ZekrCount= 7,
               ZekrName="حَسْبِيَ اللَّهُ لاَ إِلَهَ إِلاَّ هُوَ "+
"عَلَيهِ تَوَكَّلتُ وَهُوَ رَبُّ الْعَرْشِ "+
" الْعَظِيمِ "
           },
                          new AzkarSabah()
           {
               ZekrId = 12,
               ZekrCount= 1,
               ZekrName="اللَّهُمَّ إِنِّي أَسْأَلُكَ الْعَفْوَ وَالْعَافِيَةَ فِي الدُّنْيَا وَالآخِرَةِ، اللَّهُمَّ "+
                              "  إِنِّي أَسْأَلُكَ الْعَفْوَ وَالْعَافِيَةَ: فِي دِينِي وَدُنْيَايَ وَأَهْلِي، وَمَالِي، اللَّهُمَّ اسْتُرْ عَوْرَاتِي، وَآمِنْ رَوْعَاتِي، اللَّهُمَّ احْفَظْنِي مِنْ بَينِ يَدَيَّ، وَمِنْ خَلْفِي، وَعَنْ يَمِينِي، وَعَنْ شِمَالِي، وَمِنْ فَوْقِي، وَأَعُوذُ بِعَظَمَتِكَ أَنْ أُغْتَالَ مِنْ تَحْتِي"
           },
                          new AzkarSabah()
           {
               ZekrId = 13,
               ZekrCount= 1,
               ZekrName="اللَّهُمَّ عَالِمَ الغَيْبِ وَالشَّهَادَةِ فَاطِرَ السَّمَوَاتِ وَالْأَرْضِ، رَبَّ كُلِّ شَيْءٍ وَمَلِيكَهُ، أَشْهَدُ أَنْ لاَ إِلَهَ إِلاَّ أَنْتَ، أَعُوذُ بِكَ مِنْ شَرِّ نَفْسِي، وَمِنْ شَرِّ الشَّيْطانِ وَشَرَكِهِ، وَأَنْ أَقْتَرِفَ عَلَى  نَفْسِي سُوءاً، أَوْ أَجُرَّهُ إِلَى مُسْلِمٍ"
           },
                       new AzkarSabah()
           {
               ZekrId = 14,
               ZekrCount= 3,
               ZekrName="بِسْمِ اللَّهِ الَّذِي لاَ يَضُرُّ مَعَ اسْمِهِ شَيْءٌ فِي الْأَرْضِ وَلاَ فِي السّمَاءِ وَهُوَ السَّمِيعُ الْعَلِيمُ"
           },
                        new AzkarSabah()
           {
               ZekrId = 15,
               ZekrCount= 3,
               ZekrName="رَضِيتُ بِاللَّهِ رَبَّاً، وَبِالْإِسْلاَمِ دِيناً، وَبِمُحَمَّدٍ - صلى الله عليه وسلم - نَبِيّاً"
           },
                      new AzkarSabah()
           {
               ZekrId = 16,
               ZekrCount= 1,
               ZekrName="يَا حَيُّ يَا قَيُّومُ بِرَحْمَتِكَ أَسْتَغيثُ أَصْلِحْ لِي شَأْنِيَ كُلَّهُ وَلاَ تَكِلْنِي إِلَى نَفْسِي طَرْفَةَ عَيْنٍ"
           },
                   new AzkarSabah()
           {
               ZekrId = 17,
               ZekrCount= 1,
               ZekrName="أَصْبَحْنَا وَأَصْبَحَ الْمُلْكُ لِلَّهِ رَبِّ الْعَالَمِينَ، اللَّهُـمَّ إِنِّي أَسْأَلُكَ خَيْرَ هَذَا الْيَوْمِ:فَتْحَهُ، وَنَصْرَهُ، وَنورَهُ، وَبَرَكَتَهُ، وَهُدَاهُ، "+
                       "وَأَعُوذُ بِكَ مِنْ شَرِّ مَا فِيهِ وَشَرِّ مَا بَعْدَهُ"
           },
                  new AzkarSabah()
           {
               ZekrId = 18,
               ZekrCount= 1,
               ZekrName="أَصْبَحْنا عَلَى فِطْرَةِ الْإِسْلاَمِ، وَعَلَى كَلِمَةِ الْإِخْلاَصِ، وَعَلَى دِينِ نَبِيِّنَا مُحَمَّدٍ - صلى الله عليه وسلم -، وَعَلَى مِلَّةِ أَبِينَا إِبْرَاهِيمَ، حَنِيفاً مُسْلِماً وَمَا كَانَ مِنَ الْمُشرِكِينَ"
           },
               new AzkarSabah()
           {
               ZekrId = 19,
               ZekrCount= 100,
               ZekrName="سُبْحَانَ اللَّهِ وَبِحَمْدِهِ"
           },
               new AzkarSabah()
           {
               ZekrId = 20,
               ZekrCount= 10,
               ZekrName="لاَ إِلَهَ إِلاَّ اللَّهُ وَحْدَهُ لاَ شَرِيكَ لَهُ، لَهُ الْمُلْكُ وَلَهُ الْحَمْدُ، وَهُوَ عَلَى كُلِّ شَيْءٍ قَدِيرٌ"
           },
             new AzkarSabah()
           {
               ZekrId = 21,
               ZekrCount= 3,
               ZekrName="سُبْحَانَ اللَّهِ وَبِحَمْدِهِ: عَدَدَ خَلْقِهِ، وَرِضَا نَفْسِهِ، وَزِنَةَ عَرْشِهِ، وَمِدَادَ كَلِمَاتِهِ"
           },
             new AzkarSabah()
           {
               ZekrId = 22,
               ZekrCount= 1,
               ZekrName="اللَّهُمَّ إِنِّي أَسْأَلُكَ عِلْماً نَافِعاً، وَرِزْقاً طَيِّباً، وَعَمَلاً مُتَقَبَّلاً"
           },
           new AzkarSabah()
           {
               ZekrId = 23,
               ZekrCount= 3,
               ZekrName="أَعُوذُ بِكَلِمَاتِ اللَّهِ التَّامَّاتِ مِنْ شَرِّ مَا خَلَقَ"
           },                 new AzkarSabah()
           {
               ZekrId = 24,
               ZekrCount= 10,
               ZekrName="اللَّهُمَّ صَلِّ وَسَلِّمْ عَلَى نَبَيِّنَا مُحَمَّدٍ"
           },
                                                       new AzkarSabah()
           {
               ZekrId = 25,
               ZekrCount= 100,
               ZekrName="أَسْتَغْفِرُ اللَّهَ وَأَتُوبُ إِلَيْهِ"
           },






       };

        public List<AzkarSabah> AzkarSabahs { get => azkarSabahs; set => azkarSabahs = value; }
    }
}