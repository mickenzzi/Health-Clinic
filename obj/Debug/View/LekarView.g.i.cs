﻿#pragma checksum "..\..\..\View\LekarView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CB663E3C05ED76FDC9C70C90ED0DC702D5632605B6EB7C45B93E0B846B9D1667"
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
    /// LekarView
    /// </summary>
    public partial class LekarView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\View\LekarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pocetna;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\LekarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Prikazi;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\LekarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PrikazLekova;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\View\LekarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Odjava;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\View\LekarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox LekariComboBox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\View\LekarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frejm;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/view/lekarview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\LekarView.xaml"
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
            
            #line 9 "..\..\..\View\LekarView.xaml"
            ((Bolnica.View.LekarView)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.exitApp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Pocetna = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\View\LekarView.xaml"
            this.Pocetna.Click += new System.Windows.RoutedEventHandler(this.Pocetna_click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Prikazi = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\View\LekarView.xaml"
            this.Prikazi.Click += new System.Windows.RoutedEventHandler(this.PrikaziTermine);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PrikazLekova = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\View\LekarView.xaml"
            this.PrikazLekova.Click += new System.Windows.RoutedEventHandler(this.PrikaziLekove);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Odjava = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\View\LekarView.xaml"
            this.Odjava.Click += new System.Windows.RoutedEventHandler(this.Odjava_click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LekariComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.frejm = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
