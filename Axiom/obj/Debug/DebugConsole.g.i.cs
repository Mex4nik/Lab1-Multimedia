﻿#pragma checksum "..\..\DebugConsole.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "391D7AC75F601B9117E741FFB466A3D5C58AA985E27554DE6A88E6822265B53B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Themes;
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


namespace Axiom {
    
    
    /// <summary>
    /// DebugConsole
    /// </summary>
    public partial class DebugConsole : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\DebugConsole.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox rtbDebug;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\DebugConsole.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDebugMethods;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\DebugConsole.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDebugRandom;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\DebugConsole.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDebugTest;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\DebugConsole.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExpand;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\DebugConsole.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockExpand;
        
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
            System.Uri resourceLocater = new System.Uri("/Axiom;component/debugconsole.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DebugConsole.xaml"
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
            this.rtbDebug = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 2:
            this.btnDebugMethods = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\DebugConsole.xaml"
            this.btnDebugMethods.Click += new System.Windows.RoutedEventHandler(this.btnDebugMethods_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnDebugRandom = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\DebugConsole.xaml"
            this.btnDebugRandom.Click += new System.Windows.RoutedEventHandler(this.btnDebugRandom_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDebugTest = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\DebugConsole.xaml"
            this.btnDebugTest.Click += new System.Windows.RoutedEventHandler(this.btnDebugTest_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnExpand = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\DebugConsole.xaml"
            this.btnExpand.Click += new System.Windows.RoutedEventHandler(this.btnExpand_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textBlockExpand = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
