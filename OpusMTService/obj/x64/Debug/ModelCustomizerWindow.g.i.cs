﻿#pragma checksum "..\..\..\ModelCustomizerWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2921A4AC04770D11C2CDB6CD72294F84571929A84D3993733B75272254D8D4A7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FiskmoMTEngine;
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


namespace FiskmoMTEngine {
    
    
    /// <summary>
    /// ModelCustomizerWindow
    /// </summary>
    public partial class ModelCustomizerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\ModelCustomizerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SourceFileBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\ModelCustomizerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TargetFileBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\ModelCustomizerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ValidSourceFileBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\ModelCustomizerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ValidTargetFileBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\ModelCustomizerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LabelBox;
        
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
            System.Uri resourceLocater = new System.Uri("/FiskmoMTEngine;component/modelcustomizerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ModelCustomizerWindow.xaml"
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
            
            #line 11 "..\..\..\ModelCustomizerWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.CloseCommandHandler);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SourceFileBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 17 "..\..\..\ModelCustomizerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.browse_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TargetFileBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 22 "..\..\..\ModelCustomizerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.browse_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ValidSourceFileBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 27 "..\..\..\ModelCustomizerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.browse_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ValidTargetFileBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 32 "..\..\..\ModelCustomizerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.browse_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.LabelBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 39 "..\..\..\ModelCustomizerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.customize_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

