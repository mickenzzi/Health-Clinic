﻿#pragma checksum "..\..\..\View\PretragaInventara.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BBF686BD5E4824ED59D3B6EC8E1F16BA941F98C4FE1CA33D3E658B265470A5A1"
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
    /// PretragaInventara
    /// </summary>
    public partial class PretragaInventara : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\View\PretragaInventara.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox soba;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\View\PretragaInventara.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox brojSobeBitan;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\View\PretragaInventara.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox tipInventaraBitan;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\PretragaInventara.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Prikazi;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\PretragaInventara.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Odustani;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\PretragaInventara.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox tipInventara;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\PretragaInventara.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Inventar;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/view/pretragainventara.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\PretragaInventara.xaml"
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
            this.soba = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.brojSobeBitan = ((System.Windows.Controls.CheckBox)(target));
            
            #line 12 "..\..\..\View\PretragaInventara.xaml"
            this.brojSobeBitan.Click += new System.Windows.RoutedEventHandler(this.onClickCheckBoxSobe);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tipInventaraBitan = ((System.Windows.Controls.CheckBox)(target));
            
            #line 13 "..\..\..\View\PretragaInventara.xaml"
            this.tipInventaraBitan.Click += new System.Windows.RoutedEventHandler(this.onClickCheckBoxTip);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Prikazi = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\View\PretragaInventara.xaml"
            this.Prikazi.Click += new System.Windows.RoutedEventHandler(this.onClickPrikazi);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Odustani = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\View\PretragaInventara.xaml"
            this.Odustani.Click += new System.Windows.RoutedEventHandler(this.onClickOdustani);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tipInventara = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.Inventar = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

