#pragma checksum "..\..\..\..\View\pagesSekretar\ZakazivanjeOperacije.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C65A555231CF48111C60B7D0199879DEA994FDA59C178DF2A70374598306BB58"
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
    /// ZakazivanjeOperacije
    /// </summary>
    public partial class ZakazivanjeOperacije : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\View\pagesSekretar\ZakazivanjeOperacije.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox JMBG;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\View\pagesSekretar\ZakazivanjeOperacije.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox JMBG1;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\View\pagesSekretar\ZakazivanjeOperacije.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Lekari;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\View\pagesSekretar\ZakazivanjeOperacije.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Kalendar;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\View\pagesSekretar\ZakazivanjeOperacije.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Vreme;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/view/pagessekretar/zakazivanjeoperacije.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\pagesSekretar\ZakazivanjeOperacije.xaml"
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
            this.JMBG = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.JMBG1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Lekari = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.Kalendar = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.Vreme = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 53 "..\..\..\..\View\pagesSekretar\ZakazivanjeOperacije.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Odustani);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 61 "..\..\..\..\View\pagesSekretar\ZakazivanjeOperacije.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ZakaziOperaciju);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

