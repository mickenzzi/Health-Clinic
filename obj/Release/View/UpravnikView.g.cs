﻿#pragma checksum "..\..\..\View\UpravnikView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EDA0599D34077954CCEF3E4F76F1788032680A617B5EEBE61DBBAA459775228E"
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
    /// UpravnikView
    /// </summary>
    public partial class UpravnikView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\View\UpravnikView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegistrujP;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\View\UpravnikView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegistrujI;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\View\UpravnikView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PregledP;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\UpravnikView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PregledI;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\UpravnikView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ObrisiP;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\UpravnikView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ObrisiI;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\UpravnikView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button premestiDI;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/view/upravnikview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\UpravnikView.xaml"
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
            
            #line 9 "..\..\..\View\UpravnikView.xaml"
            ((Bolnica.View.UpravnikView)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RegistrujP = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\View\UpravnikView.xaml"
            this.RegistrujP.Click += new System.Windows.RoutedEventHandler(this.onClickRegistruj);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RegistrujI = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\View\UpravnikView.xaml"
            this.RegistrujI.Click += new System.Windows.RoutedEventHandler(this.onClickRegInventar);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PregledP = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\View\UpravnikView.xaml"
            this.PregledP.Click += new System.Windows.RoutedEventHandler(this.onClickPregled);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PregledI = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\View\UpravnikView.xaml"
            this.PregledI.Click += new System.Windows.RoutedEventHandler(this.onClickPregledInventara);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ObrisiP = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\View\UpravnikView.xaml"
            this.ObrisiP.Click += new System.Windows.RoutedEventHandler(this.onClickObrisi);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ObrisiI = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\View\UpravnikView.xaml"
            this.ObrisiI.Click += new System.Windows.RoutedEventHandler(this.onClickObrisiInventar);
            
            #line default
            #line hidden
            return;
            case 8:
            this.premestiDI = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\View\UpravnikView.xaml"
            this.premestiDI.Click += new System.Windows.RoutedEventHandler(this.onClickPremestiInventar);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
