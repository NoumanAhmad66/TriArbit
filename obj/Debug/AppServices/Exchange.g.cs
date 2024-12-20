﻿#pragma checksum "..\..\..\AppServices\Exchange.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "35BF69B11EF20C21D9049CAAA84E5074DFAB54FEC7EE1D405B301537C998D271"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using TriArbit_v1.AppServices;


namespace TriArbit_v1.AppServices {
    
    
    /// <summary>
    /// Exchange
    /// </summary>
    public partial class Exchange : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\AppServices\Exchange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup Success;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\AppServices\Exchange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PopupClose;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\AppServices\Exchange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoDashboard;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\AppServices\Exchange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Exch_1;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\AppServices\Exchange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Api;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\AppServices\Exchange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PasteAPI;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\AppServices\Exchange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Secret;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\AppServices\Exchange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PasteSecret;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\AppServices\Exchange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelBTN;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\AppServices\Exchange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateBTN;
        
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
            System.Uri resourceLocater = new System.Uri("/TriArbit v1;component/appservices/exchange.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AppServices\Exchange.xaml"
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
            this.Success = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 2:
            this.PopupClose = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\AppServices\Exchange.xaml"
            this.PopupClose.Click += new System.Windows.RoutedEventHandler(this.PopupClose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GoDashboard = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\AppServices\Exchange.xaml"
            this.GoDashboard.Click += new System.Windows.RoutedEventHandler(this.GoDashboard_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Exch_1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Api = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.PasteAPI = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\AppServices\Exchange.xaml"
            this.PasteAPI.Click += new System.Windows.RoutedEventHandler(this.PasteAPI_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Secret = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.PasteSecret = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\AppServices\Exchange.xaml"
            this.PasteSecret.Click += new System.Windows.RoutedEventHandler(this.PasteSecret_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CancelBTN = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\AppServices\Exchange.xaml"
            this.CancelBTN.Click += new System.Windows.RoutedEventHandler(this.CancelBTN_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.UpdateBTN = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\AppServices\Exchange.xaml"
            this.UpdateBTN.Click += new System.Windows.RoutedEventHandler(this.UpdateBTN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

