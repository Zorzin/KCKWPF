﻿#pragma checksum "..\..\..\..\View\Calendar\Search.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "17D2EC89445E0EAFE29D87A00901830B"
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
    /// Search
    /// </summary>
    public partial class Search : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\View\Calendar\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label InfoLabel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\View\Calendar\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ValueLabel;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\View\Calendar\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BoxGrid;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\View\Calendar\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SearchComboBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\View\Calendar\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\View\Calendar\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DistanceTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\View\Calendar\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NoteTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\View\Calendar\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePicker;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\View\Calendar\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\View\Calendar\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFKCK;component/view/calendar/search.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Calendar\Search.xaml"
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
            this.InfoLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ValueLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.BoxGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.SearchComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\..\..\View\Calendar\Search.xaml"
            this.SearchComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SearchComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.DistanceTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\..\View\Calendar\Search.xaml"
            this.DistanceTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.DistanceTextBox_OnPreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NoteTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.DatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\View\Calendar\Search.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\View\Calendar\Search.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

