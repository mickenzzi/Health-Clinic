#pragma checksum "..\..\..\View\IzdavanjeRecepta.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E977CB7BA7A2BE35A8FA76EA81FDF79DFED84576F60E83F00F6FD740EC9B59E4"
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
    /// IzdavanjeRecepta
    /// </summary>
    public partial class IzdavanjeRecepta : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\View\IzdavanjeRecepta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdTermina;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\View\IzdavanjeRecepta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Pacijent;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\View\IzdavanjeRecepta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox JMBG;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\View\IzdavanjeRecepta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ZdravstvenaU;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\View\IzdavanjeRecepta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DatumIzdavanjaLeka;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\View\IzdavanjeRecepta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KolicinaLeka;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\IzdavanjeRecepta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NacinUpotrebe;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\IzdavanjeRecepta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox LekoviComboBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/view/izdavanjerecepta.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\IzdavanjeRecepta.xaml"
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
            this.IdTermina = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Pacijent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.JMBG = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ZdravstvenaU = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DatumIzdavanjaLeka = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.KolicinaLeka = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.NacinUpotrebe = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 26 "..\..\..\View\IzdavanjeRecepta.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IzdajRecept);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 27 "..\..\..\View\IzdavanjeRecepta.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Odustani);
            
            #line default
            #line hidden
            return;
            case 10:
            this.LekoviComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

