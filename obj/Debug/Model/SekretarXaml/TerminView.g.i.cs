﻿#pragma checksum "..\..\..\..\Model\SekretarXaml\TerminView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B20D02DA772951F64AC7D1696B07F1610666920C7E876E7F943EA57915612B12"
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


namespace Bolnica.Model.SekretarXaml {
    
    
    /// <summary>
    /// TerminView
    /// </summary>
    public partial class TerminView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\Model\SekretarXaml\TerminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox JMBG;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Model\SekretarXaml\TerminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ImeP;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Model\SekretarXaml\TerminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PrezimeP;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/model/sekretarxaml/terminview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Model\SekretarXaml\TerminView.xaml"
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
            
            #line 10 "..\..\..\..\Model\SekretarXaml\TerminView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Povratak);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 18 "..\..\..\..\Model\SekretarXaml\TerminView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ZakaziOperacije);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 19 "..\..\..\..\Model\SekretarXaml\TerminView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OtkaziOperacije);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 29 "..\..\..\..\Model\SekretarXaml\TerminView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ZakaziPreglede);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 30 "..\..\..\..\Model\SekretarXaml\TerminView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OtkaziPreglede);
            
            #line default
            #line hidden
            return;
            case 6:
            this.JMBG = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ImeP = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.PrezimeP = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

