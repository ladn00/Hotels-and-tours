﻿#pragma checksum "..\..\..\Pages\ToursPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AB51E3E8DC5782B11BE24E529C020F54E583258227233F9FC9E79595E22BC7DD"
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
using Первый_проект_за_год_xddddddd.Pages;


namespace Первый_проект_за_год_xddddddd.Pages {
    
    
    /// <summary>
    /// ToursPage
    /// </summary>
    public partial class ToursPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 20 "..\..\..\Pages\ToursPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearchText;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\ToursPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBType;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\ToursPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lw1;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Pages\ToursPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCurrentPage;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Pages\ToursPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblTotalPages;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Pages\ToursPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblInfo;
        
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
            System.Uri resourceLocater = new System.Uri("/Первый проект за год xddddddd;component/pages/tourspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ToursPage.xaml"
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
            this.tbSearchText = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\Pages\ToursPage.xaml"
            this.tbSearchText.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchTextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CBType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\Pages\ToursPage.xaml"
            this.CBType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBTypeSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 31 "..\..\..\Pages\ToursPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ToursWord_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 32 "..\..\..\Pages\ToursPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ToursExcel_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 33 "..\..\..\Pages\ToursPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ToursByTypesExcel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 34 "..\..\..\Pages\ToursPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Hotel_Add);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lw1 = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            
            #line 72 "..\..\..\Pages\ToursPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToFirstPage);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 73 "..\..\..\Pages\ToursPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToPreviousPage);
            
            #line default
            #line hidden
            return;
            case 12:
            this.TxtCurrentPage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.LblTotalPages = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            
            #line 76 "..\..\..\Pages\ToursPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToNextPage);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 77 "..\..\..\Pages\ToursPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToLastPage);
            
            #line default
            #line hidden
            return;
            case 16:
            this.LblInfo = ((System.Windows.Controls.Label)(target));
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
            case 8:
            
            #line 63 "..\..\..\Pages\ToursPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Hotel_Edit);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 64 "..\..\..\Pages\ToursPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Hotel_Delete);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

