﻿#pragma checksum "..\..\..\Fenetres\Interface.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FB5DDB6D5D7204DDF5D6AB6C73B885450FCCDB01F0BFE4850DAAAFD0AE763C12"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ACT_8_Banque.Fenetres;
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


namespace ACT_8_Banque.Fenetres {
    
    
    /// <summary>
    /// Interface
    /// </summary>
    public partial class Interface : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Fenetres\Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock compte;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Fenetres\Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton courant;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Fenetres\Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock numCourant;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Fenetres\Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton epargne;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Fenetres\Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock numEpargne;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Fenetres\Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox montant;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Fenetres\Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox destinataire;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Fenetres\Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button valider;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Fenetres\Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button annuler;
        
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
            System.Uri resourceLocater = new System.Uri("/ACT_8-Banque;component/fenetres/interface.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Fenetres\Interface.xaml"
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
            this.compte = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.courant = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.numCourant = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.epargne = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.numEpargne = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.montant = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.destinataire = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.valider = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.annuler = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

