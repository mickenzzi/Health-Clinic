﻿#pragma checksum "..\..\..\View\BeleskePacijent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4EE8741B23C636E92D71DA34A60DB91F84E72EFBA3FC4170F4A6C612A155EB41"
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
    /// BeleskePacijent
    /// </summary>
    public partial class BeleskePacijent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\View\BeleskePacijent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Beleske;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\BeleskePacijent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nazad;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\View\BeleskePacijent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button prikazOdabraneBeleske;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\View\BeleskePacijent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dodajBelesku;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\View\BeleskePacijent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button obrisiBelesku;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/view/beleskepacijent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\BeleskePacijent.xaml"
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
            this.Beleske = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.nazad = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\View\BeleskePacijent.xaml"
            this.nazad.Click += new System.Windows.RoutedEventHandler(this.onClickNazad);
            
            #line default
            #line hidden
            return;
            case 3:
            this.prikazOdabraneBeleske = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\View\BeleskePacijent.xaml"
            this.prikazOdabraneBeleske.Click += new System.Windows.RoutedEventHandler(this.onClickPrikazOdabraneBeleske);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dodajBelesku = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\View\BeleskePacijent.xaml"
            this.dodajBelesku.Click += new System.Windows.RoutedEventHandler(this.onClickNapraviBelesku);
            
            #line default
            #line hidden
            return;
            case 5:
            this.obrisiBelesku = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\View\BeleskePacijent.xaml"
            this.obrisiBelesku.Click += new System.Windows.RoutedEventHandler(this.onClickObrisiBelesku);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

