// Updated by XamlIntelliSenseFileGenerator 7.5.2021. 17:02:11
#pragma checksum "..\..\..\..\View\Sekretar1\SekretarView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "745E052CE820EC62DECFAB4F131094CE00C70BB1107E790241D86DDB0E1FB7CB"
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


namespace Bolnica.View
{


    /// <summary>
    /// SekretarView
    /// </summary>
    public partial class SekretarView : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Bolnica;component/view/sekretar1/sekretarview.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\View\Sekretar1\SekretarView.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 9 "..\..\..\..\View\Sekretar1\SekretarView.xaml"
                    ((Bolnica.View.Sekretar1.SekretarView)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.exitApp);

#line default
#line hidden
                    return;
                case 2:

#line 24 "..\..\..\..\View\Sekretar1\SekretarView.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Povratak);

#line default
#line hidden
                    return;
                case 3:

#line 33 "..\..\..\..\View\Sekretar1\SekretarView.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Komunikacija);

#line default
#line hidden
                    return;
                case 4:

#line 43 "..\..\..\..\View\Sekretar1\SekretarView.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.KreirajStatistiku);

#line default
#line hidden
                    return;
                case 5:

#line 53 "..\..\..\..\View\Sekretar1\SekretarView.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TerminiRad);

#line default
#line hidden
                    return;
                case 6:

#line 63 "..\..\..\..\View\Sekretar1\SekretarView.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Registrovanje);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

