﻿#pragma checksum "..\..\..\..\View\View\PacijentView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A64FF7358F223A544B4C9B33F6A11A6FBA845C5B4873437AD53EF79BB508979F"
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


namespace Bolnica.View {
    
    
    /// <summary>
    /// PacijentView
    /// </summary>
    public partial class PacijentView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\View\View\PacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pretrazi;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\View\View\PacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Prikazi;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\View\View\PacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Otkazi;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\View\View\PacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IstorijaTermina;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\View\View\PacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OcenjivanjeBolnice;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\View\View\PacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button prikazZdravstvenogKartona;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\View\View\PacijentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button prikazListeBeleski;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/view/view/pacijentview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\View\PacijentView.xaml"
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
            
            #line 9 "..\..\..\..\View\View\PacijentView.xaml"
            ((Bolnica.View.PacijentView)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.exitApp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Pretrazi = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\View\View\PacijentView.xaml"
            this.Pretrazi.Click += new System.Windows.RoutedEventHandler(this.onClickPretrazi);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Prikazi = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\View\View\PacijentView.xaml"
            this.Prikazi.Click += new System.Windows.RoutedEventHandler(this.onClickPrikazi);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Otkazi = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\View\View\PacijentView.xaml"
            this.Otkazi.Click += new System.Windows.RoutedEventHandler(this.onClickOtkazi);
            
            #line default
            #line hidden
            return;
            case 5:
            this.IstorijaTermina = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\View\View\PacijentView.xaml"
            this.IstorijaTermina.Click += new System.Windows.RoutedEventHandler(this.onClickIstorijaTermina);
            
            #line default
            #line hidden
            return;
            case 6:
            this.OcenjivanjeBolnice = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\View\View\PacijentView.xaml"
            this.OcenjivanjeBolnice.Click += new System.Windows.RoutedEventHandler(this.onClickOcenjivanjeBolnicePacijent);
            
            #line default
            #line hidden
            return;
            case 7:
            this.prikazZdravstvenogKartona = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\View\View\PacijentView.xaml"
            this.prikazZdravstvenogKartona.Click += new System.Windows.RoutedEventHandler(this.onClickPrikazKartona);
            
            #line default
            #line hidden
            return;
            case 8:
            this.prikazListeBeleski = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\View\View\PacijentView.xaml"
            this.prikazListeBeleski.Click += new System.Windows.RoutedEventHandler(this.onClickPrikazListeBeleski);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

