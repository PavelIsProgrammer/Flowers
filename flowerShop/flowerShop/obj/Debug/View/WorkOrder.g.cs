﻿#pragma checksum "..\..\..\View\WorkOrder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "46F97FEB4EC49E911D2B93AE2FBED1673CE3CA903188037ECD580A3C7D45A2CC"
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
    /// WorkOrder
    /// </summary>
    public partial class WorkOrder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\View\WorkOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonNavigate;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\View\WorkOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewOrders;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\View\WorkOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewOrder;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\View\WorkOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateDelivery;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\View\WorkOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbStatus;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\View\WorkOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butEditOrder;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\View\WorkOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbCount;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\View\WorkOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSort;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\View\WorkOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbFilterDiscount;
        
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
            System.Uri resourceLocater = new System.Uri("/flowerShop;component/view/workorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\WorkOrder.xaml"
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
            
            #line 8 "..\..\..\View\WorkOrder.xaml"
            ((flowerShop.View.WorkOrder)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonNavigate = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\View\WorkOrder.xaml"
            this.buttonNavigate.Click += new System.Windows.RoutedEventHandler(this.buttonNavigate_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listViewOrders = ((System.Windows.Controls.ListView)(target));
            
            #line 40 "..\..\..\View\WorkOrder.xaml"
            this.listViewOrders.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listViewOrders_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listViewOrder = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.dateDelivery = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.cbStatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.butEditOrder = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\View\WorkOrder.xaml"
            this.butEditOrder.Click += new System.Windows.RoutedEventHandler(this.butEditOrder_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tbCount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.cbSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 104 "..\..\..\View\WorkOrder.xaml"
            this.cbSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.cbFilterDiscount = ((System.Windows.Controls.ComboBox)(target));
            
            #line 111 "..\..\..\View\WorkOrder.xaml"
            this.cbFilterDiscount.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbFilterDiscount_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

