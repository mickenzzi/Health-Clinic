﻿#pragma checksum "..\..\..\..\View\View\AzuriranjeLeka.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3842C3B4B61C7D7FCE81EC58E5CD965B1D64BD0012EC67EA8ED7EC93EFE69342"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bolnica.View;
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
    /// AzuriranjeLeka
    /// </summary>
    public partial class AzuriranjeLeka : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\View\View\AzuriranjeLeka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Lekovi;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\View\View\AzuriranjeLeka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Sastojci;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\View\View\AzuriranjeLeka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Potvrdi;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\View\View\AzuriranjeLeka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Odustani;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\View\View\AzuriranjeLeka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PostojecaZamena;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\View\View\AzuriranjeLeka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NazivLeka;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\View\AzuriranjeLeka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KolicinaLeka;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\View\AzuriranjeLeka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SifraSobe;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\View\View\AzuriranjeLeka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Doza;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/view/view/azuriranjeleka.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\View\AzuriranjeLeka.xaml"
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
            this.Lekovi = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.Sastojci = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Potvrdi = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\View\View\AzuriranjeLeka.xaml"
            this.Potvrdi.Click += new System.Windows.RoutedEventHandler(this.onClickPotvrdi);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Odustani = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\View\View\AzuriranjeLeka.xaml"
            this.Odustani.Click += new System.Windows.RoutedEventHandler(this.onClickOdustani);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PostojecaZamena = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.NazivLeka = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.KolicinaLeka = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.SifraSobe = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Doza = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

