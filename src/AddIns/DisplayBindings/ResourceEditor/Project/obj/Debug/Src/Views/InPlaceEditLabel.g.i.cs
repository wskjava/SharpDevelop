﻿#pragma checksum "..\..\..\..\Src\Views\InPlaceEditLabel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79A493C04000538ADEF1C35124DD6433DFAF8842"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ResourceEditor.Views;
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


namespace ResourceEditor.Views {
    
    
    /// <summary>
    /// InPlaceEditLabel
    /// </summary>
    public partial class InPlaceEditLabel : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\..\Src\Views\InPlaceEditLabel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock readOnlyTextBlock;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\..\Src\Views\InPlaceEditLabel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox editingTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/ResourceEditor;component/src/views/inplaceeditlabel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Src\Views\InPlaceEditLabel.xaml"
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
            this.readOnlyTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.editingTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\..\Src\Views\InPlaceEditLabel.xaml"
            this.editingTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.EditingTextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\..\Src\Views\InPlaceEditLabel.xaml"
            this.editingTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.EditingTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

