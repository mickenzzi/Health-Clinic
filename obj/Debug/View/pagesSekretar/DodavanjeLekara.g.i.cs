﻿#pragma checksum "..\..\..\..\View\pagesSekretar\DodavanjeLekara.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4A38D3374FD37E65D2DFEE570EF40791A92D5079189DE576B1C2BA7C9F2C46BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bolnica.View.pagesSekretar;
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


namespace Bolnica.View.pagesSekretar {
    
    
    /// <summary>
    /// DodavanjeLekara
    /// </summary>
    public partial class DodavanjeLekara : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\View\pagesSekretar\DodavanjeLekara.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Ime;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\View\pagesSekretar\DodavanjeLekara.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Prezime;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\View\pagesSekretar\DodavanjeLekara.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox JMBG;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\View\pagesSekretar\DodavanjeLekara.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label OblastiSpecijalizacije;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\View\pagesSekretar\DodavanjeLekara.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Specijalnosti;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\pagesSekretar\DodavanjeLekara.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Specijalista;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\View\pagesSekretar\DodavanjeLekara.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DatumRodjenja;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\View\pagesSekretar\DodavanjeLekara.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MestoRodjenja;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/view/pagessekretar/dodavanjelekara.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\pagesSekretar\DodavanjeLekara.xaml"
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
            this.Ime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Prezime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.JMBG = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.OblastiSpecijalizacije = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Specijalnosti = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            
            #line 26 "..\..\..\..\View\pagesSekretar\DodavanjeLekara.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DodajLekara);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Specijalista = ((System.Windows.Controls.CheckBox)(target));
            
            #line 27 "..\..\..\..\View\pagesSekretar\DodavanjeLekara.xaml"
            this.Specijalista.Unchecked += new System.Windows.RoutedEventHandler(this.Skloni);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\..\View\pagesSekretar\DodavanjeLekara.xaml"
            this.Specijalista.Checked += new System.Windows.RoutedEventHandler(this.Prikazi);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DatumRodjenja = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.MestoRodjenja = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 32 "..\..\..\..\View\pagesSekretar\DodavanjeLekara.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Nazad);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

