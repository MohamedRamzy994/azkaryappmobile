using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AzkaryApp.Models;

namespace AzkaryApp.Adapters
{
  public  class HeegAzkarAdapter : RecyclerView.Adapter
    {

        public AzkarHeegData AzkarHeegData { get; set; }
       

        public event EventHandler<int> ItemClick;
        public HeegAzkarAdapter(AzkarHeegData azkarHeegData)
        {

            this.AzkarHeegData = azkarHeegData;



        }

        public override long GetItemId(int position)
        {
           return this.AzkarHeegData.AzkarHeegs[position].ZekrId;
        }



        public override int ItemCount
        {
            get { return AzkarHeegData.AzkarHeegs.Count; }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            HeegAzkarAdapterViewHolder vh = holder as HeegAzkarAdapterViewHolder;

            // Set the ImageView and TextView in this ViewHolder's CardView 
            // from this position in the photo album:
            vh.AzkarName.Text= AzkarHeegData.AzkarHeegs[position].ZekrName;
            vh.AzkarCount.Text = AzkarHeegData.AzkarHeegs[position].ZekrCount.ToString();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).
                       Inflate(Resource.Layout.fragment_cardview, parent, false);

            // Create a ViewHolder to find and hold these view references, and 
            // register OnClick with the view holder:
            HeegAzkarAdapterViewHolder vh = 
                new HeegAzkarAdapterViewHolder(itemView, OnClick);
            return vh;
        }

        void OnClick(int position)
        {
            if (ItemClick != null)
                ItemClick(this, position);
        }
    }

    internal class HeegAzkarAdapterViewHolder : RecyclerView.ViewHolder
    {
       
        public TextView AzkarName { get; private set; }
        public TextView AzkarCount { get; private set; }


        // Get references to the views defined in the CardView layout.
        public HeegAzkarAdapterViewHolder(View itemView, Action<int> listener)
            : base(itemView)
        {
            // Locate and cache view references:
            
            AzkarName = itemView.FindViewById<TextView>(Resource.Id.textView1);
            AzkarCount = itemView.FindViewById<TextView>(Resource.Id.textView2);


            // Detect user clicks on the item view and report which item
            // was clicked (by layout position) to the listener:
            itemView.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }
}