#pragma checksum "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C36A459A930B09CA07AB5222BA6CA5C11069D91D498E33F5F044E53E477C40E6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bolnica.View.pagesSekretar.Views;
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


namespace Bolnica.View.pagesSekretar.Views {
    
    
    /// <summary>
    /// SekretarView
    /// </summary>
    public partial class SekretarView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 83 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Menu;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Profil1;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame _mainFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/view/pagessekretar/views/sekretarview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
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
            
            #line 9 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((Bolnica.View.pagesSekretar.Views.SekretarView)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.exitApp);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 19 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Povratak);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 28 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Lekari);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 42 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.KreirajStatistiku);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 56 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TerminiRad);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 70 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Registrovanje);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 79 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PrikaziMenu);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 80 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToKontakt);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 81 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToInfo);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Menu = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            
            #line 86 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.SkloniMenu);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 112 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GenerisanjeIzvestaja);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 117 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.goToObavestenja);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 120 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PrikaziProfil);
            
            #line default
            #line hidden
            return;
            case 15:
            this.Profil1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 16:
            
            #line 140 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.goToProfil);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 142 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Odjava);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 143 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Nastavi);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 154 "..\..\..\..\..\View\pagesSekretar\Views\SekretarView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToBugs);
            
            #line default
            #line hidden
            return;
            case 20:
            this._mainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

