﻿#pragma checksum "D:\work\Lottozo\LottoWPUnified\LottozoWP8\Views\FieldsSetUpView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5DBDDEEF3601AE7C2C396A363A5672ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Lottozo.Views.UserControls;
using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Lottozo.Views {
    
    
    public partial class FieldsSetUpView : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Lottozo.Views.UserControls.FieldEditor FieldOne;
        
        internal Lottozo.Views.UserControls.FieldEditor FieldTwo;
        
        internal Lottozo.Views.UserControls.FieldEditor FieldThree;
        
        internal Lottozo.Views.UserControls.FieldEditor FieldFour;
        
        internal Lottozo.Views.UserControls.FieldEditor FieldFive;
        
        internal Lottozo.Views.UserControls.FieldEditor FieldSix;
        
        internal System.Windows.Controls.Button AddNewField;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Lottozo;component/Views/FieldsSetUpView.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.FieldOne = ((Lottozo.Views.UserControls.FieldEditor)(this.FindName("FieldOne")));
            this.FieldTwo = ((Lottozo.Views.UserControls.FieldEditor)(this.FindName("FieldTwo")));
            this.FieldThree = ((Lottozo.Views.UserControls.FieldEditor)(this.FindName("FieldThree")));
            this.FieldFour = ((Lottozo.Views.UserControls.FieldEditor)(this.FindName("FieldFour")));
            this.FieldFive = ((Lottozo.Views.UserControls.FieldEditor)(this.FindName("FieldFive")));
            this.FieldSix = ((Lottozo.Views.UserControls.FieldEditor)(this.FindName("FieldSix")));
            this.AddNewField = ((System.Windows.Controls.Button)(this.FindName("AddNewField")));
        }
    }
}
