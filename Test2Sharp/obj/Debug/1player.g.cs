﻿

#pragma checksum "C:\Users\Артем\Documents\Visual Studio 2012\Projects\Test2Sharp\Test2Sharp\1player.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "345DE4050B8D468BD8F43E39BCAF0B17"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test2Sharp
{
    partial class BasicPage2 : global::Test2Sharp.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 50 "..\..\1player.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ToggleButton_Click_1;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 36 "..\..\1player.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

