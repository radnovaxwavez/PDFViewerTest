﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;

namespace PDFViewerTest
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Viewer());
        }
    }
}
