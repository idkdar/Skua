﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Skua.Manager.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <string>Skua,Dark,#FF607D8B,#FF607D8B,#FF000000,#FF000000,true,4.5,Medium,All</string>
  <string>RBot,Light,#FF9C934E,#FF9C934E,#FF000000,#FF000000</string>
  <string>Grimoire,Dark,#FFCC1F41,#FFCC1F41,#FFFFFFFF,#FFFFFFFF</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection DefaultThemes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["DefaultThemes"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection UserThemes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["UserThemes"]));
            }
            set {
                this["UserThemes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Skua,Dark,#FF607D8B,#FF607D8B,#FF000000,#FF000000,true,4.5,Medium,All")]
        public string CurrentTheme {
            get {
                return ((string)(this["CurrentTheme"]));
            }
            set {
                this["CurrentTheme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserGitHubToken {
            get {
                return ((string)(this["UserGitHubToken"]));
            }
            set {
                this["UserGitHubToken"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int AnimationFramerate {
            get {
                return ((int)(this["AnimationFramerate"]));
            }
            set {
                this["AnimationFramerate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CheckClientUpdates {
            get {
                return ((bool)(this["CheckClientUpdates"]));
            }
            set {
                this["CheckClientUpdates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CheckClientPrereleases {
            get {
                return ((bool)(this["CheckClientPrereleases"]));
            }
            set {
                this["CheckClientPrereleases"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.1.3.1")]
        public string ApplicationVersion {
            get {
                return ((string)(this["ApplicationVersion"]));
            }
            set {
                this["ApplicationVersion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ClientDownloadPath {
            get {
                return ((string)(this["ClientDownloadPath"]));
            }
            set {
                this["ClientDownloadPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DeleteZipFileAfter {
            get {
                return ((bool)(this["DeleteZipFileAfter"]));
            }
            set {
                this["DeleteZipFileAfter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SyncThemes {
            get {
                return ((bool)(this["SyncThemes"]));
            }
            set {
                this["SyncThemes"] = value;
            }
        }
    }
}
