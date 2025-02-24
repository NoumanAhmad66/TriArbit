﻿#pragma checksum "..\..\..\AppServices\Profile.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "817CD12B58F9787B152D5D4B2CBB377D72E5B3DED0207ABA9A53374119866B70"
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
    /// Profile
    /// </summary>
    public partial class Profile : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\AppServices\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup Success;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\AppServices\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PopupClose;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\AppServices\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoDashboard;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\AppServices\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProfilePic;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\AppServices\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FullName;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\AppServices\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Username;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\AppServices\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Email;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\AppServices\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\AppServices\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelBTN;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\AppServices\Profile.xaml"
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
            System.Uri resourceLocater = new System.Uri("/TriArbit v1;component/appservices/profile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AppServices\Profile.xaml"
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
            
            #line 40 "..\..\..\AppServices\Profile.xaml"
            this.PopupClose.Click += new System.Windows.RoutedEventHandler(this.PopupClose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GoDashboard = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\AppServices\Profile.xaml"
            this.GoDashboard.Click += new System.Windows.RoutedEventHandler(this.GoDashboard_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ProfilePic = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\AppServices\Profile.xaml"
            this.ProfilePic.Click += new System.Windows.RoutedEventHandler(this.ProfilePic_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FullName = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\AppServices\Profile.xaml"
            this.FullName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FullName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Username = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Email = ((System.Windows.Controls.TextBox)(target));
            
            #line 72 "..\..\..\AppServices\Profile.xaml"
            this.Email.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Email_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Password = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 79 "..\..\..\AppServices\Profile.xaml"
            this.Password.PasswordChanged += new System.Windows.RoutedEventHandler(this.Password_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CancelBTN = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\AppServices\Profile.xaml"
            this.CancelBTN.Click += new System.Windows.RoutedEventHandler(this.CancelBTN_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.UpdateBTN = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\AppServices\Profile.xaml"
            this.UpdateBTN.Click += new System.Windows.RoutedEventHandler(this.UpdateBTN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

