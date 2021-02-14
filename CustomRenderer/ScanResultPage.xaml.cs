using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CustomRenderer
{
    public partial class ScanResultPage : ContentPage
    {
        public string ScanResult { get; set; }

        public ScanResultPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            resultLabel.Text = ScanResult;
        }
    }
}
