using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Syncfusion.XForms.PopupLayout;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;

namespace Popup_Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            On<iOS>().SetUseSafeArea(true);
           
        }
        private void Button_Clicked1(object sender, EventArgs e)
        {
            PopupLayout.ShowRelativeToView(btn, RelativePosition.AlignBottom, 0, 0);
        }
    }
}
