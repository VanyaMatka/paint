﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "31708125F0614A3F798B2A51A49D12C0628C134F01DCDF233F6F8439E8CBA78C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace z2 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas DrawingCanvas;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ColorComboBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BrushSizeTextBlock;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider BrushSizeSlider;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EraseButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearButton;
        
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
            System.Uri resourceLocater = new System.Uri("/z2;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.DrawingCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 8 "..\..\MainWindow.xaml"
            this.DrawingCanvas.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DrawingCanvas_MouseDown);
            
            #line default
            #line hidden
            
            #line 9 "..\..\MainWindow.xaml"
            this.DrawingCanvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.DrawingCanvas_MouseMove);
            
            #line default
            #line hidden
            
            #line 10 "..\..\MainWindow.xaml"
            this.DrawingCanvas.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.DrawingCanvas_MouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ColorComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\MainWindow.xaml"
            this.ColorComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ColorComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BrushSizeTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.BrushSizeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.BrushSizeSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.BrushSizeSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EraseButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\MainWindow.xaml"
            this.EraseButton.Click += new System.Windows.RoutedEventHandler(this.EraseButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ClearButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\MainWindow.xaml"
            this.ClearButton.Click += new System.Windows.RoutedEventHandler(this.ClearButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

