﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;

namespace Xamarin.Forms_Layouts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {        
        public HomeView()
        {
            InitializeComponent();

            btnGrid.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new GridView()));
            btnScrollView.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new ScrollView()));
            btnStackLayout.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new StackLayoutView()));
            btnRelativeLayout.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new RelativeLayoutView()));
            btnAbsoluteLayout.Clicked += new System.EventHandler((sender, args) => this.Navigation.PushAsync(new AbsoluteLayoutView()));
           
        }

    }
}