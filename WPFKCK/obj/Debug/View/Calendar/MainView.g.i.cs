﻿#pragma checksum "..\..\..\..\View\Calendar\MainView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B6D22A8B5C9A08B8135EDE368768C359"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WPFKCK.View.Calendar;


namespace WPFKCK.View.Calendar {
    
    
    /// <summary>
    /// MainView
    /// </summary>
    public partial class MainView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\View\Calendar\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ScoreLabel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\Calendar\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GoalLabel;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View\Calendar\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\View\Calendar\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\View\Calendar\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\View\Calendar\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogoutButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\View\Calendar\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoalButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\View\Calendar\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DividersButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\View\Calendar\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PasswordButton;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\View\Calendar\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InfoButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\View\Calendar\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFKCK;component/view/calendar/mainview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Calendar\MainView.xaml"
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
            this.ScoreLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.GoalLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\View\Calendar\MainView.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\View\Calendar\MainView.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ShowButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\View\Calendar\MainView.xaml"
            this.ShowButton.Click += new System.Windows.RoutedEventHandler(this.ShowButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LogoutButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\View\Calendar\MainView.xaml"
            this.LogoutButton.Click += new System.Windows.RoutedEventHandler(this.LogoutButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.GoalButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\View\Calendar\MainView.xaml"
            this.GoalButton.Click += new System.Windows.RoutedEventHandler(this.GoalButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DividersButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\View\Calendar\MainView.xaml"
            this.DividersButton.Click += new System.Windows.RoutedEventHandler(this.DividersButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.PasswordButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\View\Calendar\MainView.xaml"
            this.PasswordButton.Click += new System.Windows.RoutedEventHandler(this.PasswordButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.InfoButton = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\View\Calendar\MainView.xaml"
            this.InfoButton.Click += new System.Windows.RoutedEventHandler(this.InfoButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\View\Calendar\MainView.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

