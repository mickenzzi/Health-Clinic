﻿#pragma checksum "..\..\..\View\HospitalizacijaPacijenta.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "672B33FA372F02871A6CB0C1C1310A2260CE464AF1C3DD73B9F4CDBB899ED1C8"
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
    /// HospitalizacijaPacijenta
    /// </summary>
    public partial class HospitalizacijaPacijenta : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\View\HospitalizacijaPacijenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PacijentInfo;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\View\HospitalizacijaPacijenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatumHospitalizacije;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\View\HospitalizacijaPacijenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Sobe;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\HospitalizacijaPacijenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TrajanjeHospitalizacije;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\HospitalizacijaPacijenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox TrenutnaHospitalizacija;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\HospitalizacijaPacijenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox KrevetiInventar;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/view/hospitalizacijapacijenta.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\HospitalizacijaPacijenta.xaml"
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
            
            #line 19 "..\..\..\View\HospitalizacijaPacijenta.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Odustani);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 20 "..\..\..\View\HospitalizacijaPacijenta.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ZakaziHospitalizaciju);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PacijentInfo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DatumHospitalizacije = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.Sobe = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\View\HospitalizacijaPacijenta.xaml"
            this.Sobe.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Sobe_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TrajanjeHospitalizacije = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\View\HospitalizacijaPacijenta.xaml"
            this.TrajanjeHospitalizacije.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TrenutnaHospitalizacija = ((System.Windows.Controls.CheckBox)(target));
            
            #line 30 "..\..\..\View\HospitalizacijaPacijenta.xaml"
            this.TrenutnaHospitalizacija.Checked += new System.Windows.RoutedEventHandler(this.TrenutnaHospitalizacija_Checked);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\View\HospitalizacijaPacijenta.xaml"
            this.TrenutnaHospitalizacija.Unchecked += new System.Windows.RoutedEventHandler(this.TrenutnaHospitalizacija_Unchecked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.KrevetiInventar = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

