﻿#pragma checksum "..\..\InsertContract.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D2405D84CC6148D5456AC359060E3F46"
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


namespace ContractStatementManagementSystem {
    
    
    /// <summary>
    /// InsertContract
    /// </summary>
    public partial class InsertContract : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\InsertContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_ContractName;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\InsertContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Customer;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\InsertContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_Contract_Type;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\InsertContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Contract_Amount;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\InsertContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Count;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\InsertContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Contract_Number;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\InsertContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker tb_Contract_Date;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\InsertContract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Save;
        
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
            System.Uri resourceLocater = new System.Uri("/ContractStatementManagementSystem;component/insertcontract.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InsertContract.xaml"
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
            this.tb_ContractName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tb_Customer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cb_Contract_Type = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.tb_Contract_Amount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tb_Count = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tb_Contract_Number = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tb_Contract_Date = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.btn_Save = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\InsertContract.xaml"
            this.btn_Save.Click += new System.Windows.RoutedEventHandler(this.btn_Save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

