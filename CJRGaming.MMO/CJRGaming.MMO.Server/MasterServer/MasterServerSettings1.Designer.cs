﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CJRGaming.MMO.Server.MasterServer {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class MasterServerSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static MasterServerSettings defaultInstance = ((MasterServerSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new MasterServerSettings())));
        
        public static MasterServerSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4520")]
        public int IncomingSubServerPort {
            get {
                return ((int)(this["IncomingSubServerPort"]));
            }
        }
    }
}
