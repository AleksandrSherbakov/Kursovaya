﻿#pragma checksum "..\..\..\Windows\EditMaterialWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ECF598DA85F73A064129AED88C8037206664B5CE85EA4902264134BF3E592DC0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialsCalculator.Windows;
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


namespace MaterialsCalculator.Windows {
    
    
    /// <summary>
    /// EditMaterialWindow
    /// </summary>
    public partial class EditMaterialWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\Windows\EditMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBName;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Windows\EditMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBDescription;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Windows\EditMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageMaterialPhoto;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Windows\EditMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonLoadPhoto;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Windows\EditMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxType;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Windows\EditMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxManufacturer;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Windows\EditMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBSquare;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Windows\EditMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBPrice;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Windows\EditMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOk;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Windows\EditMaterialWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/MaterialsCalculator;component/windows/editmaterialwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\EditMaterialWindow.xaml"
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
            this.TBName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TBDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ImageMaterialPhoto = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.ButtonLoadPhoto = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Windows\EditMaterialWindow.xaml"
            this.ButtonLoadPhoto.Click += new System.Windows.RoutedEventHandler(this.ButtonLoadPhoto_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ComboBoxType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.ComboBoxManufacturer = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.TBSquare = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TBPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.BtnOk = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\Windows\EditMaterialWindow.xaml"
            this.BtnOk.Click += new System.Windows.RoutedEventHandler(this.BtnOk_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\Windows\EditMaterialWindow.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

