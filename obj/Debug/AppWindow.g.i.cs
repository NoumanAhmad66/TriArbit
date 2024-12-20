﻿#pragma checksum "..\..\AppWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ABAC2B0C3A56F4BDDC6467EB022DAAB4B370FE5238208C19F178AC2FABE508B1"
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
using TriArbit_v1;
using TriArbit_v1.UserServices;


namespace TriArbit_v1 {
    
    
    /// <summary>
    /// AppWindow
    /// </summary>
    public partial class AppWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 66 "..\..\AppWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label title;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\AppWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MimimizeBTN;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\AppWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseBTN;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\AppWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush ProfilePic;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\AppWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label User;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\AppWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Menu;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\AppWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem Dashboard;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\AppWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem Opportunity;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\AppWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem Exchange;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\AppWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem Profile;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\AppWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem Logout;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\AppWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl AppContent;
        
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
            System.Uri resourceLocater = new System.Uri("/TriArbit v1;component/appwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AppWindow.xaml"
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
            
            #line 43 "..\..\AppWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.title = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.MimimizeBTN = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\AppWindow.xaml"
            this.MimimizeBTN.Click += new System.Windows.RoutedEventHandler(this.MimimizeBTN_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CloseBTN = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\AppWindow.xaml"
            this.CloseBTN.Click += new System.Windows.RoutedEventHandler(this.CloseBTN_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ProfilePic = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 6:
            this.User = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Menu = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.Dashboard = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 91 "..\..\AppWindow.xaml"
            this.Dashboard.Selected += new System.Windows.RoutedEventHandler(this.Dashboard_Selected);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Opportunity = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 98 "..\..\AppWindow.xaml"
            this.Opportunity.Selected += new System.Windows.RoutedEventHandler(this.Opportunity_Selected);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Exchange = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 105 "..\..\AppWindow.xaml"
            this.Exchange.Selected += new System.Windows.RoutedEventHandler(this.Exchange_Selected);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Profile = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 112 "..\..\AppWindow.xaml"
            this.Profile.Selected += new System.Windows.RoutedEventHandler(this.Profile_Selected);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Logout = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 119 "..\..\AppWindow.xaml"
            this.Logout.Selected += new System.Windows.RoutedEventHandler(this.Logout_Selected);
            
            #line default
            #line hidden
            return;
            case 13:
            this.AppContent = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

