﻿#pragma checksum "..\..\Rewards.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2BAC50145A31611F85BE20F9B25E367A0957B353B508E0B2B45C3C88297DCCB4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Destiny2PowerLevelMax;
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


namespace Destiny2PowerLevelMax {
    
    
    /// <summary>
    /// Rewards
    /// </summary>
    public partial class Rewards : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Rewards.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Home;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Rewards.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Soft;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Rewards.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Power;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Rewards.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pinn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Rewards.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl RewardInfo_TB;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Rewards.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem SoftCap_Header;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Rewards.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem PowerCap_Header;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Rewards.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem PinnCap_Header;
        
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
            System.Uri resourceLocater = new System.Uri("/Destiny2PowerLevelMax;component/rewards.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Rewards.xaml"
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
            this.Home = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Rewards.xaml"
            this.Home.Click += new System.Windows.RoutedEventHandler(this.Home_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Soft = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Rewards.xaml"
            this.Soft.Click += new System.Windows.RoutedEventHandler(this.Soft_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Power = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Rewards.xaml"
            this.Power.Click += new System.Windows.RoutedEventHandler(this.Power_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Pinn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Rewards.xaml"
            this.Pinn.Click += new System.Windows.RoutedEventHandler(this.Pinn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RewardInfo_TB = ((System.Windows.Controls.TabControl)(target));
            return;
            case 6:
            this.SoftCap_Header = ((System.Windows.Controls.TabItem)(target));
            return;
            case 7:
            this.PowerCap_Header = ((System.Windows.Controls.TabItem)(target));
            return;
            case 8:
            this.PinnCap_Header = ((System.Windows.Controls.TabItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

