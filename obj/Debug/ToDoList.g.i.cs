// Updated by XamlIntelliSenseFileGenerator 20/07/2020 12:03:09
#pragma checksum "..\..\ToDoList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9BC7811F952E5EEE8A3372CD0623D6CF04B99EEE291705DE345999D94F34B1FE"
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
using WpfAnimatedGif;


namespace Destiny2PowerLevelMax
{


    /// <summary>
    /// ToDoList
    /// </summary>
    public partial class ToDoList : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 15 "..\..\ToDoList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Home;

#line default
#line hidden


#line 16 "..\..\ToDoList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Calculate;

#line default
#line hidden


#line 19 "..\..\ToDoList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ToDoBox;

#line default
#line hidden

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
            System.Uri resourceLocater = new System.Uri("/Destiny2PowerLevelMax;component/todolist.xaml", System.UriKind.Relative);

#line 1 "..\..\ToDoList.xaml"
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
                    this.Home = ((System.Windows.Controls.Button)(target));

#line 15 "..\..\ToDoList.xaml"
                    this.Home.Click += new System.Windows.RoutedEventHandler(this.Home_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.Calculate = ((System.Windows.Controls.Button)(target));

#line 16 "..\..\ToDoList.xaml"
                    this.Calculate.Click += new System.Windows.RoutedEventHandler(this.Calculate_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.ToDoBox = ((System.Windows.Controls.ListBox)(target));
                    return;
                case 4:
                    this.Pinn = ((System.Windows.Controls.CheckBox)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Label Powerful_lb;
        internal System.Windows.Controls.CheckBox FlashPoint_CB;
        internal System.Windows.Controls.CheckBox Nmh_CB;
        internal System.Windows.Controls.CheckBox Nightfall_CB;
        internal System.Windows.Controls.CheckBox StrikesBounties_CB;
        internal System.Windows.Controls.CheckBox CrucibleBounties_CB;
        internal System.Windows.Controls.CheckBox GambitBounties_CB;
    }
}

