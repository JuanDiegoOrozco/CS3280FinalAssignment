﻿#pragma checksum "..\..\..\Views\NewOrderView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8D2A31568BC0CB92F137D01BD239443B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FinalAssignment.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace FinalAssignment.Views {
    
    
    /// <summary>
    /// NewOrderView
    /// </summary>
    public partial class NewOrderView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Views\NewOrderView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OrdersB;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Views\NewOrderView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InventoryB;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Views\NewOrderView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewOrdersB;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Views\NewOrderView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView OrdersViewList;
        
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
            System.Uri resourceLocater = new System.Uri("/FinalProject;component/views/neworderview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\NewOrderView.xaml"
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
            this.OrdersB = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\Views\NewOrderView.xaml"
            this.OrdersB.Click += new System.Windows.RoutedEventHandler(this.OrdersB_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.InventoryB = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Views\NewOrderView.xaml"
            this.InventoryB.Click += new System.Windows.RoutedEventHandler(this.InventoryB_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NewOrdersB = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Views\NewOrderView.xaml"
            this.NewOrdersB.Click += new System.Windows.RoutedEventHandler(this.NewOrdersB_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OrdersViewList = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

