﻿#pragma checksum "..\..\..\View\Order.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3E96652E8FDA67BDD30B90FA10FF602DFD6A5200841B35B9BBE77032D8F9867E"
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
using flowerShop.View;


namespace flowerShop.View {
    
    
    /// <summary>
    /// Order
    /// </summary>
    public partial class Order : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 24 "..\..\..\View\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonNavigation;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxProductsInOrder;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\View\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu cmAddInOrder;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\View\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miAddInOrder;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\View\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbSummaTotal;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\View\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbSummaWithDiscount;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\View\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbSummaDiscount;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\View\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPoint;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\View\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbFIO;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\View\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butCreateOrder;
        
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
            System.Uri resourceLocater = new System.Uri("/flowerShop;component/view/order.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Order.xaml"
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
            this.buttonNavigation = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\View\Order.xaml"
            this.buttonNavigation.Click += new System.Windows.RoutedEventHandler(this.buttonNavigation_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listBoxProductsInOrder = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.cmAddInOrder = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 4:
            this.miAddInOrder = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 7:
            this.tbSummaTotal = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.tbSummaWithDiscount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.tbSummaDiscount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.cbPoint = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.tbFIO = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.butCreateOrder = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\View\Order.xaml"
            this.butCreateOrder.Click += new System.Windows.RoutedEventHandler(this.butCreateOrder_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 73 "..\..\..\View\Order.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 74 "..\..\..\View\Order.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.butDeleteProduct_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

