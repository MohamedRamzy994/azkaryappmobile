using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AzkaryApp.Models;
using AzkaryApp.Adapters;


namespace AzkaryApp
{
    [Activity(Label = "@string/app_name", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, ParentActivity = typeof(MainActivity), Theme = "@style/AppTheme")]
    
    public class DisplayActivity : AppCompatActivity
    {
        public const string Sabah = "أذكار الصباح";
        public const string Masaa = "أذكار المساء";
        public const string Esteqaz = "أذكارالإستيقاظ";
        public const string Noom = "أذكار النوم";
        public const string Masged = "أذكار المسجد";
        public const string Manzel = "أذكار المنزل";
        public const string Khalaa = "أذكار الخلاء";
        public const string Salah = "أذكارالصلاة";
        public const string Taam = "أذكار الطعام";
        public const string Azaan = "أذكار الأذان";
        public const string Wedoa = "أذكار الوضوء";
        public const string Heeg = "أذكار الحج والعمرة";
        public const string Hozn = "أذكار  الخوف والضيق";
        public const string Tasbeeh = "   تسابيح - تسبيح";






        public RecyclerView AzkarRecyclerView;
        public RecyclerView.LayoutManager AzkarLayoutManager;
        public SabahAzkarAdapter  SabahAzkarAdapter;
        public MassaAzkarAdapter MassaAzkarAdapter;
        public EsteqazAzkarAdapter EsteqazAzkarAdapter;
        public NoomAzkarAdapter NoomAzkarAdapter;
        public MasgedAzkarAdapter MasgedAzkarAdapter;
        public ManzelAzkarAdapter ManzelAzkarAdapter;
        public KhalaaAzkarAdapter KhalaaAzkarAdapter;
        public SalahAzkarAdapter SalahAzkarAdapter;
        public TaamAzkarAdapter TaamAzkarAdapter;
        public AzaanAzkarAdapter AzaanAzkarAdapter;
        public WedoaAzkarAdapter WedoaAzkarAdapter;
        public HeegAzkarAdapter HeegAzkarAdapter;
        public HozenAzkarAdapter HozenAzkarAdapter;
        public TasbeehAzkarAdapter TasbeehAzkarAdapter;







        public AzkarSabahData AzkarSabahData;
        public AzkarMasaaData AzkarMasaaData;
        public AzkarEsteqazData AzkarEsteqazData;
        public AzkarNoomData AzkarNoomData;
        public AzkarMasgedData AzkarMasgedData;
        public AzkarManzelData AzkarManzelData;
        public AzkarKhalaaData AzkarKhalaaData;
        public AzkarSalahData AzkarSalahData;
        public AzkarTaamData AzkarTaamData;
        public AzkarAzaanData AzkarAzaanData;
        public AzkarWedoaData AzkarWedoaData;
        public AzkarHeegData AzkarHeegData;
        public AzkarHoznData AzkarHoznData;
        public AzkarTasbeehData AzkarTasbeehData;








        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);



            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.activity_display);
            SupportActionBar.SetDisplayShowHomeEnabled(true);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            //SupportActionBar.SetDisplayUseLogoEnabled(true);
            //SupportActionBar.SetLogo(Resource.Mipmap.ic_launcher);
            SupportActionBar.SetDisplayShowTitleEnabled(true);

            
            AzkarRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView1);

            AzkarLayoutManager = new LinearLayoutManager(this);
            


            AzkarRecyclerView.SetLayoutManager(AzkarLayoutManager);


            int azkarType = Intent.GetIntExtra("AzkarType", 0);

            switch (azkarType)
            {
                case 1:SupportActionBar.Title = Sabah;
                    AzkarSabahData = new AzkarSabahData();
                    SabahAzkarAdapter = new SabahAzkarAdapter(AzkarSabahData);
                    SabahAzkarAdapter.ItemClick += AzkarSabahAdapter_ItemClick;
                    AzkarRecyclerView.SetAdapter(SabahAzkarAdapter);
                   
                    break;
                case 2:
                    SupportActionBar.Title = Masaa;
                    AzkarMasaaData = new AzkarMasaaData();
                    MassaAzkarAdapter = new MassaAzkarAdapter(AzkarMasaaData);
                    
                    MassaAzkarAdapter.ItemClick += AzkarMasaaAdapter_ItemClick;
                    AzkarRecyclerView.SetAdapter(MassaAzkarAdapter);
                    

                 
                    break;
                case 3:
                    SupportActionBar.Title = Esteqaz;
                    AzkarEsteqazData = new AzkarEsteqazData();
                    EsteqazAzkarAdapter = new EsteqazAzkarAdapter(AzkarEsteqazData);

                    EsteqazAzkarAdapter.ItemClick += AzkarEsteqazAdapter_ItemClick;
                    AzkarRecyclerView.SetAdapter(EsteqazAzkarAdapter);

                    break;
                case 4:
                    SupportActionBar.Title = Noom;
                    AzkarNoomData = new AzkarNoomData();
                    NoomAzkarAdapter = new NoomAzkarAdapter(AzkarNoomData);

                    NoomAzkarAdapter.ItemClick += AzkarNoomAdapter_ItemClick;
                    AzkarRecyclerView.SetAdapter(NoomAzkarAdapter);



                    break;
                case 5:
                    SupportActionBar.Title = Masged;
                    AzkarMasgedData = new AzkarMasgedData();
                    MasgedAzkarAdapter = new MasgedAzkarAdapter(AzkarMasgedData);

                    MasgedAzkarAdapter.ItemClick += AzkarMasgedAdapter_ItemClick;
                    AzkarRecyclerView.SetAdapter(MasgedAzkarAdapter);



                    break;
                case 6:
                    SupportActionBar.Title = Manzel;
                    AzkarManzelData = new AzkarManzelData();
                    ManzelAzkarAdapter = new ManzelAzkarAdapter(AzkarManzelData);

                    ManzelAzkarAdapter.ItemClick += AzkarManazelAdapter_ItemClick;
                    AzkarRecyclerView.SetAdapter(ManzelAzkarAdapter);



                    break;
                case 7:
                    SupportActionBar.Title = Khalaa;
                    AzkarKhalaaData = new AzkarKhalaaData();
                    KhalaaAzkarAdapter = new KhalaaAzkarAdapter(AzkarKhalaaData);

                    KhalaaAzkarAdapter.ItemClick += AzkarKhalaaAdapter_ItemClick;
                    AzkarRecyclerView.SetAdapter(KhalaaAzkarAdapter);

                    break;
                case 8:
                    SupportActionBar.Title = Salah;
                    AzkarSalahData = new AzkarSalahData();
                    SalahAzkarAdapter = new SalahAzkarAdapter(AzkarSalahData);

                    SalahAzkarAdapter.ItemClick += AzkarSalahAdapter_ItemClick;
                    AzkarRecyclerView.SetAdapter(SalahAzkarAdapter);

                    break;
                case 9:
                    SupportActionBar.Title = Taam;
                    AzkarTaamData = new AzkarTaamData();
                    TaamAzkarAdapter = new TaamAzkarAdapter(AzkarTaamData);

                    TaamAzkarAdapter.ItemClick += AzkarTaamAdapter_ItemClick;
                    AzkarRecyclerView.SetAdapter(TaamAzkarAdapter);

                    break;
                case 10:
                    SupportActionBar.Title = Azaan;
                    AzkarAzaanData = new AzkarAzaanData();
                    AzaanAzkarAdapter = new AzaanAzkarAdapter(AzkarAzaanData);

                    AzaanAzkarAdapter.ItemClick += AzkarAzaanAdapter_ItemClick;
                    AzkarRecyclerView.SetAdapter(AzaanAzkarAdapter);

                    break;
                case 11:
                    SupportActionBar.Title = Wedoa;
                    AzkarWedoaData = new AzkarWedoaData();
                    WedoaAzkarAdapter = new WedoaAzkarAdapter(AzkarWedoaData);

                    WedoaAzkarAdapter.ItemClick += AzkarWedoaAdapter_ItemClick;
                    AzkarRecyclerView.SetAdapter(WedoaAzkarAdapter);

                    break;
                case 12:
                    SupportActionBar.Title = Heeg;
                    AzkarHeegData = new AzkarHeegData();
                    HeegAzkarAdapter = new HeegAzkarAdapter(AzkarHeegData);

                    HeegAzkarAdapter.ItemClick += AzkarHeegAdapter_ItemClick;
                    AzkarRecyclerView.SetAdapter(HeegAzkarAdapter);

                    break;
                case 13:
                    SupportActionBar.Title = Hozn;
                    AzkarHoznData = new AzkarHoznData();
                    HozenAzkarAdapter = new HozenAzkarAdapter(AzkarHoznData);

                    HozenAzkarAdapter.ItemClick += AzkarHoznAdapter_ItemClick;
                    AzkarRecyclerView.SetAdapter(HozenAzkarAdapter);

                    break;
                case 14:
                    SupportActionBar.Title = Tasbeeh;
                    AzkarTasbeehData = new AzkarTasbeehData();
                    TasbeehAzkarAdapter = new TasbeehAzkarAdapter(AzkarTasbeehData);

                    TasbeehAzkarAdapter.ItemClick += AzkarTasbeehAdapter_ItemClick;
                    AzkarRecyclerView.SetAdapter(TasbeehAzkarAdapter);

                    break;

                default:
                    break;
            }
        }

        private void AzkarSabahAdapter_ItemClick(object sender, int e)
        {
         AzkarSabah azkarSabahSelected = AzkarSabahData.AzkarSabahs[e];
            azkarSabahSelected.ZekrCount--;

            SabahAzkarAdapter.NotifyItemChanged(e);
           




            if (azkarSabahSelected.ZekrCount==0)
            {
                AzkarSabahData.AzkarSabahs.RemoveAt(e);
                SabahAzkarAdapter.NotifyItemRemoved(e);
                SabahAzkarAdapter.NotifyItemRangeChanged(e, AzkarSabahData.AzkarSabahs.Count);
               
                  
            }


        }
        private void AzkarMasaaAdapter_ItemClick(object sender, int e)
        {
            AzkarMasaa azkarSabahSelected = AzkarMasaaData.AzkarMasaas[e];
            azkarSabahSelected.ZekrCount--;

            MassaAzkarAdapter.NotifyItemChanged(e);





            if (azkarSabahSelected.ZekrCount == 0)
            {
                AzkarMasaaData.AzkarMasaas.RemoveAt(e);
                MassaAzkarAdapter.NotifyItemRemoved(e);
                MassaAzkarAdapter.NotifyItemRangeChanged(e, AzkarMasaaData.AzkarMasaas.Count);


            }


        }
        private void AzkarEsteqazAdapter_ItemClick(object sender, int e)
        {
            AzkarEsteqaz azkarSabahSelected = AzkarEsteqazData.AzkarEsteqazs[e];
            azkarSabahSelected.ZekrCount--;

           EsteqazAzkarAdapter.NotifyItemChanged(e);





            if (azkarSabahSelected.ZekrCount == 0)
            {
                AzkarEsteqazData.AzkarEsteqazs.RemoveAt(e);
                EsteqazAzkarAdapter.NotifyItemRemoved(e);
                EsteqazAzkarAdapter.NotifyItemRangeChanged(e, AzkarEsteqazData.AzkarEsteqazs.Count);


            }


        }
        private void AzkarNoomAdapter_ItemClick(object sender, int e)
        {
            AzkarNoom azkarSabahSelected = AzkarNoomData.AzkarNooms[e];
            azkarSabahSelected.ZekrCount--;

            NoomAzkarAdapter.NotifyItemChanged(e);

            if (azkarSabahSelected.ZekrCount == 0)
            {
                AzkarNoomData.AzkarNooms.RemoveAt(e);
                NoomAzkarAdapter.NotifyItemRemoved(e);
                NoomAzkarAdapter.NotifyItemRangeChanged(e, AzkarNoomData.AzkarNooms.Count);


            }


        }
        private void AzkarMasgedAdapter_ItemClick(object sender, int e)
        {
            AzkarMasged azkarSabahSelected = AzkarMasgedData.AzkarMasgeds[e];
            azkarSabahSelected.ZekrCount--;

            MasgedAzkarAdapter.NotifyItemChanged(e);

            if (azkarSabahSelected.ZekrCount == 0)
            {
                AzkarMasaaData.AzkarMasaas.RemoveAt(e);
                MasgedAzkarAdapter.NotifyItemRemoved(e);
                MasgedAzkarAdapter.NotifyItemRangeChanged(e, AzkarMasaaData.AzkarMasaas.Count);


            }


        }
        private void AzkarManazelAdapter_ItemClick(object sender, int e)
        {
            AzkarManzel azkarSabahSelected = AzkarManzelData.AzkarManzels[e];
            azkarSabahSelected.ZekrCount--;

           ManzelAzkarAdapter.NotifyItemChanged(e);

            if (azkarSabahSelected.ZekrCount == 0)
            {
                AzkarManzelData.AzkarManzels.RemoveAt(e);
                ManzelAzkarAdapter.NotifyItemRemoved(e);
                ManzelAzkarAdapter.NotifyItemRangeChanged(e, AzkarManzelData.AzkarManzels.Count);


            }


        }
        private void AzkarKhalaaAdapter_ItemClick(object sender, int e)
        {
            AzkarKhalaa azkarSabahSelected = AzkarKhalaaData.AzkarKhalaas[e];
            azkarSabahSelected.ZekrCount--;

            KhalaaAzkarAdapter.NotifyItemChanged(e);

            if (azkarSabahSelected.ZekrCount == 0)
            {
                AzkarKhalaaData.AzkarKhalaas.RemoveAt(e);
                KhalaaAzkarAdapter.NotifyItemRemoved(e);
                KhalaaAzkarAdapter.NotifyItemRangeChanged(e, AzkarKhalaaData.AzkarKhalaas.Count);


            }


        }
        private void AzkarSalahAdapter_ItemClick(object sender, int e)
        {
            AzkarSalah azkarSabahSelected = AzkarSalahData.AzkarSalahs[e];
            azkarSabahSelected.ZekrCount--;

            SalahAzkarAdapter.NotifyItemChanged(e);

            if (azkarSabahSelected.ZekrCount == 0)
            {
                AzkarSalahData.AzkarSalahs.RemoveAt(e);
                SalahAzkarAdapter.NotifyItemRemoved(e);
                SalahAzkarAdapter.NotifyItemRangeChanged(e, AzkarSalahData.AzkarSalahs.Count);


            }


        }
        private void AzkarTaamAdapter_ItemClick(object sender, int e)
        {
            AzkarTaam azkarSabahSelected = AzkarTaamData.AzkarTaams[e];
            azkarSabahSelected.ZekrCount--;

            TaamAzkarAdapter.NotifyItemChanged(e);

            if (azkarSabahSelected.ZekrCount == 0)
            {
                AzkarTaamData.AzkarTaams.RemoveAt(e);
                TaamAzkarAdapter.NotifyItemRemoved(e);
                TaamAzkarAdapter.NotifyItemRangeChanged(e, AzkarTaamData.AzkarTaams.Count);


            }


        }
        private void AzkarAzaanAdapter_ItemClick(object sender, int e)
        {
            AzkarAzaan azkarSabahSelected = AzkarAzaanData.AzkarAzaans[e];
            azkarSabahSelected.ZekrCount--;

            AzaanAzkarAdapter.NotifyItemChanged(e);

            if (azkarSabahSelected.ZekrCount == 0)
            {
                AzkarAzaanData.AzkarAzaans.RemoveAt(e);
                AzaanAzkarAdapter.NotifyItemRemoved(e);
                AzaanAzkarAdapter.NotifyItemRangeChanged(e, AzkarAzaanData.AzkarAzaans.Count);


            }


        }

        private void AzkarWedoaAdapter_ItemClick(object sender, int e)
        {
            AzkarWedoa azkarSabahSelected = AzkarWedoaData.AzkarWedoas[e];
            azkarSabahSelected.ZekrCount--;

            WedoaAzkarAdapter.NotifyItemChanged(e);

            if (azkarSabahSelected.ZekrCount == 0)
            {
                AzkarWedoaData.AzkarWedoas.RemoveAt(e);
                WedoaAzkarAdapter.NotifyItemRemoved(e);
                WedoaAzkarAdapter.NotifyItemRangeChanged(e, AzkarWedoaData.AzkarWedoas.Count);


            }


        }

        private void AzkarHeegAdapter_ItemClick(object sender, int e)
        {
            AzkarHeeg azkarSabahSelected = AzkarHeegData.AzkarHeegs[e];
            azkarSabahSelected.ZekrCount--;

            HeegAzkarAdapter.NotifyItemChanged(e);

            if (azkarSabahSelected.ZekrCount == 0)
            {
                AzkarHeegData.AzkarHeegs.RemoveAt(e);
                HeegAzkarAdapter.NotifyItemRemoved(e);
                HeegAzkarAdapter.NotifyItemRangeChanged(e, AzkarHeegData.AzkarHeegs.Count);


            }


        }

        private void AzkarHoznAdapter_ItemClick(object sender, int e)
        {
            AzkarHozn azkarSabahSelected = AzkarHoznData.AzkarHozns[e];
            azkarSabahSelected.ZekrCount--;

            HozenAzkarAdapter.NotifyItemChanged(e);

            if (azkarSabahSelected.ZekrCount == 0)
            {
                AzkarHoznData.AzkarHozns.RemoveAt(e);
                HozenAzkarAdapter.NotifyItemRemoved(e);
                HozenAzkarAdapter.NotifyItemRangeChanged(e, AzkarHoznData.AzkarHozns.Count);


            }


        }

        private void AzkarTasbeehAdapter_ItemClick(object sender, int e)
        {
            AzkarTasbeeh azkarSabahSelected = AzkarTasbeehData.AzkarTasbeehs[e];
            azkarSabahSelected.ZekrCount--;

            TasbeehAzkarAdapter.NotifyItemChanged(e);

            if (azkarSabahSelected.ZekrCount == 0)
            {
                AzkarTasbeehData.AzkarTasbeehs.RemoveAt(e);
                TasbeehAzkarAdapter.NotifyItemRemoved(e);
                TasbeehAzkarAdapter.NotifyItemRangeChanged(e, AzkarTasbeehData.AzkarTasbeehs.Count);


            }


        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    
        public override void OnBackPressed()
        {
            if (SupportFragmentManager.BackStackEntryCount > 0)
            {
                SupportFragmentManager.PopBackStack();
               
            }
            else
            {
                base.OnBackPressed();

            }
        }
        

       
    }
}