﻿#pragma checksum "..\..\..\..\View\Sekretar\ZakazivanjeGuest.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "58C14467EE2B17F1F23BD1361C83A0D51124080EDD72AD888A54AA403D9C03F1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bolnica.Model;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Bolnica.View.Sekretar {
    
    
    /// <summary>
    /// ZakazivanjeGuest
    /// </summary>
    public partial class ZakazivanjeGuest : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\View\Sekretar\ZakazivanjeGuest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton HitanSlucaj;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\View\Sekretar\ZakazivanjeGuest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox JMBG;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\View\Sekretar\ZakazivanjeGuest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Prezime;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\View\Sekretar\ZakazivanjeGuest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Ime;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/view/sekretar/zakazivanjeguest.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Sekretar\ZakazivanjeGuest.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.HitanSlucaj = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.JMBG = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Prezime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Ime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 18 "..\..\..\..\View\Sekretar\ZakazivanjeGuest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Potvrda);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 19 "..\..\..\..\View\Sekretar\ZakazivanjeGuest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Odustanak);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

