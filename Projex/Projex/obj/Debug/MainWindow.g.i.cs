﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D8833547E9A7A74B0CFAC895624FECA896C2E8F5DC85507416B30AEABD5B0D0B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Projex;
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


namespace Projex {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OkButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FieldName1;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FieldName2;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FieldName3;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar TimeProgressBar;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse FirstPicture;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse SecondPicture;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse ThirdPicture;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas SecondField;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas ThirdField;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas FirstField;
        
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
            System.Uri resourceLocater = new System.Uri("/Projex;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.OkButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\MainWindow.xaml"
            this.OkButton.Click += new System.Windows.RoutedEventHandler(this.OkButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FieldName1 = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.FieldName2 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.FieldName3 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.TimeProgressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 6:
            
            #line 34 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.FirstPicture_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 34 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.FirstPicture_PreviewMouseMove);
            
            #line default
            #line hidden
            
            #line 34 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.FirstPicture_PreviewMouseUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FirstPicture = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 8:
            
            #line 41 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SecondPicture_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 41 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.SecondPicture_PreviewMouseUp);
            
            #line default
            #line hidden
            
            #line 41 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.SecondPicture_PreviewMouseMove);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SecondPicture = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 10:
            
            #line 48 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ThirdPicture_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 48 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.ThirdPicture_PreviewMouseMove);
            
            #line default
            #line hidden
            
            #line 48 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ThirdPicture_PreviewMouseUp);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ThirdPicture = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 12:
            this.SecondField = ((System.Windows.Controls.Canvas)(target));
            return;
            case 13:
            this.ThirdField = ((System.Windows.Controls.Canvas)(target));
            return;
            case 14:
            this.FirstField = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

