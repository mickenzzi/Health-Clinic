﻿#pragma checksum "..\..\..\..\View\View\KreiranjeProstorije.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "950D110B3BA2328276C76A8A8C90D5192269661BE76BE4034F66FE0F1A71473C"
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
    /// KreiranjeProstorije
    /// </summary>
    public partial class KreiranjeProstorije : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\View\View\KreiranjeProstorije.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Sifra;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\View\View\KreiranjeProstorije.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TipSobe;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\View\View\KreiranjeProstorije.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Sprat;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\View\KreiranjeProstorije.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Potvrdi;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\View\KreiranjeProstorije.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Odustani;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\View\KreiranjeProstorije.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BrojKreveta;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/view/view/kreiranjeprostorije.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\View\KreiranjeProstorije.xaml"
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
            this.Sifra = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TipSobe = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Sprat = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Potvrdi = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\View\View\KreiranjeProstorije.xaml"
            this.Potvrdi.Click += new System.Windows.RoutedEventHandler(this.onClickPotvrdi);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Odustani = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\View\View\KreiranjeProstorije.xaml"
            this.Odustani.Click += new System.Windows.RoutedEventHandler(this.onClickOdustani);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BrojKreveta = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

