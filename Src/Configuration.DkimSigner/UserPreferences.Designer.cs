﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Configuration.DkimSigner {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class UserPreferences : global::System.Configuration.ApplicationSettingsBase {
        
        private static UserPreferences defaultInstance = ((UserPreferences)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new UserPreferences())));
        
        public static UserPreferences Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2048")]
        public int KeyLength {
            get {
                return ((int)(this["KeyLength"]));
            }
            set {
                this["KeyLength"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("stevejost")]
        public string GithubUser {
            get {
                return ((string)(this["GithubUser"]));
            }
            set {
                this["GithubUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dkim-exchange")]
        public string GithubRepoName {
            get {
                return ((string)(this["GithubRepoName"]));
            }
            set {
                this["GithubRepoName"] = value;
            }
        }
    }
}
