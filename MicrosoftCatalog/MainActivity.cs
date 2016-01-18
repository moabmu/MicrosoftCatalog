using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MicrosoftCatalog
{
    [Activity(Label = "Microsoft Catalog", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button buttonPrev;
        Button buttonNext;
        TextView textTitle;
        ImageView imageItem;
        TextView textDescription;

        Catalog _catalog;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            buttonPrev = FindViewById<Button>(Resource.Id.buttonPrev);
            buttonNext = FindViewById<Button>(Resource.Id.buttonNext);
            textTitle = FindViewById<TextView>(Resource.Id.textTitle);
            imageItem = FindViewById<ImageView>(Resource.Id.imageItem);
            textDescription = FindViewById<TextView>(Resource.Id.textDescription);

            buttonPrev.Click += ButtonPrev_Click;
            buttonNext.Click += ButtonNext_Click;

            _catalog = new Catalog();
            _catalog.MoveFirst();
            UpdateUI();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            _catalog.MoveNext();
            UpdateUI();

        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            _catalog.MovePrev();
            UpdateUI();
        }


        private void UpdateUI()
        {
            textTitle.Text = _catalog.Current.Title;
            textDescription.Text = _catalog.Current.Description;
            imageItem.SetImageResource(_catalog.Current.Image);
        }
    }
}

