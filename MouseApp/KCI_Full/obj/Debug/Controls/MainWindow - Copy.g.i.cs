﻿#pragma checksum "..\..\..\Controls\MainWindow - Copy.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C1A910DBC3E13CA20AB08489B5E8994B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MouseApp;
using MouseApp.Properties;
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


namespace MouseApp {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Controls\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition OptionsRow;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Controls\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition OptionsColumn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Controls\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBox_MotionType;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Controls\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBox1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Controls\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridSplitter gridSplitter;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Controls\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridSplitter gridSplitter1;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Controls\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Controls\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Controls\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Controls\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock1;
        
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
            System.Uri resourceLocater = new System.Uri("/KCI_Full;component/controls/mainwindow%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\MainWindow - Copy.xaml"
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
            this.OptionsRow = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 2:
            this.OptionsColumn = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 3:
            this.checkBox_MotionType = ((System.Windows.Controls.CheckBox)(target));
            
            #line 21 "..\..\..\Controls\MainWindow - Copy.xaml"
            this.checkBox_MotionType.Checked += new System.Windows.RoutedEventHandler(this.checkBox_MotionType_Checked);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\Controls\MainWindow - Copy.xaml"
            this.checkBox_MotionType.Click += new System.Windows.RoutedEventHandler(this.checkBox_MotionType_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.checkBox1 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 22 "..\..\..\Controls\MainWindow - Copy.xaml"
            this.checkBox1.Checked += new System.Windows.RoutedEventHandler(this.checkBox1_Checked);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\Controls\MainWindow - Copy.xaml"
            this.checkBox1.Click += new System.Windows.RoutedEventHandler(this.checkBox1_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.gridSplitter = ((System.Windows.Controls.GridSplitter)(target));
            return;
            case 6:
            this.gridSplitter1 = ((System.Windows.Controls.GridSplitter)(target));
            return;
            case 7:
            this.slider = ((System.Windows.Controls.Slider)(target));
            
            #line 31 "..\..\..\Controls\MainWindow - Copy.xaml"
            this.slider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.slider1 = ((System.Windows.Controls.Slider)(target));
            
            #line 34 "..\..\..\Controls\MainWindow - Copy.xaml"
            this.slider1.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slider1_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

