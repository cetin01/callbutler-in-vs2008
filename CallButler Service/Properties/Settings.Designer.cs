﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3053
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CallButler.Service.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("XmlDataProvider")]
        public global::WOSI.CallButler.Data.LocalCallButlerDataProviderTypes DataProviderType {
            get {
                return ((global::WOSI.CallButler.Data.LocalCallButlerDataProviderTypes)(this["DataProviderType"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\Data")]
        public string XmlDataRootDirectory {
            get {
                return ((string)(this["XmlDataRootDirectory"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\Sounds\\Greetings")]
        public string GreetingSoundRootDirectory {
            get {
                return ((string)(this["GreetingSoundRootDirectory"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int CustomerID {
            get {
                return ((int)(this["CustomerID"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5060")]
        public int SipPort {
            get {
                return ((int)(this["SipPort"]));
            }
            set {
                this["SipPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string StunServer {
            get {
                return ((string)(this["StunServer"]));
            }
            set {
                this["StunServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseStun {
            get {
                return ((bool)(this["UseStun"]));
            }
            set {
                this["UseStun"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public int LineCount {
            get {
                return ((int)(this["LineCount"]));
            }
            set {
                this["LineCount"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\Logs")]
        public string LogDirectory {
            get {
                return ((string)(this["LogDirectory"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SMTPServer {
            get {
                return ((string)(this["SMTPServer"]));
            }
            set {
                this["SMTPServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        public int SMTPPort {
            get {
                return ((int)(this["SMTPPort"]));
            }
            set {
                this["SMTPPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SMTPUseSSL {
            get {
                return ((bool)(this["SMTPUseSSL"]));
            }
            set {
                this["SMTPUseSSL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SMTPUsername {
            get {
                return ((string)(this["SMTPUsername"]));
            }
            set {
                this["SMTPUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SMTPPassword {
            get {
                return ((string)(this["SMTPPassword"]));
            }
            set {
                this["SMTPPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LicenseName {
            get {
                return ((string)(this["LicenseName"]));
            }
            set {
                this["LicenseName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LicenseKey {
            get {
                return ((string)(this["LicenseKey"]));
            }
            set {
                this["LicenseKey"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\Sounds\\System")]
        public string SystemSoundRootDirectory {
            get {
                return ((string)(this["SystemSoundRootDirectory"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\Plugins")]
        public string ImlPluginsFolder {
            get {
                return ((string)(this["ImlPluginsFolder"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Multilingual {
            get {
                return ((bool)(this["Multilingual"]));
            }
            set {
                this["Multilingual"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DefaultLanguage {
            get {
                return ((string)(this["DefaultLanguage"]));
            }
            set {
                this["DefaultLanguage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Languages {
            get {
                return ((string)(this["Languages"]));
            }
            set {
                this["Languages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ServiceEnabled {
            get {
                return ((bool)(this["ServiceEnabled"]));
            }
            set {
                this["ServiceEnabled"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\Voicemail")]
        public string VoicemailRootDirectory {
            get {
                return ((string)(this["VoicemailRootDirectory"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("35")]
        public byte SoundVolume {
            get {
                return ((byte)(this["SoundVolume"]));
            }
            set {
                this["SoundVolume"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255")]
        public byte RecordVolume {
            get {
                return ((byte)(this["RecordVolume"]));
            }
            set {
                this["RecordVolume"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("35")]
        public byte SpeechVolume {
            get {
                return ((byte)(this["SpeechVolume"]));
            }
            set {
                this["SpeechVolume"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\Music")]
        public string HoldMusicRootDirectory {
            get {
                return ((string)(this["HoldMusicRootDirectory"]));
            }
            set {
                this["HoldMusicRootDirectory"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\Scripts\\System")]
        public string SystemScriptsRootDirectory {
            get {
                return ((string)(this["SystemScriptsRootDirectory"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mailer@callbutler.com")]
        public string SMTPEmailFrom {
            get {
                return ((string)(this["SMTPEmailFrom"]));
            }
            set {
                this["SMTPEmailFrom"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ManagementPassword {
            get {
                return ((string)(this["ManagementPassword"]));
            }
            set {
                this["ManagementPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ExpertMode {
            get {
                return ((bool)(this["ExpertMode"]));
            }
            set {
                this["ExpertMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool FirstTimeRun {
            get {
                return ((bool)(this["FirstTimeRun"]));
            }
            set {
                this["FirstTimeRun"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SystemEventLog")]
        public global::WOSI.CallButler.ManagementInterface.LogStorage LogStorage {
            get {
                return ((global::WOSI.CallButler.ManagementInterface.LogStorage)(this["LogStorage"]));
            }
            set {
                this["LogStorage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ErrorsOnly")]
        public global::WOSI.CallButler.ManagementInterface.LogLevel LoggingLevel {
            get {
                return ((global::WOSI.CallButler.ManagementInterface.LogLevel)(this["LoggingLevel"]));
            }
            set {
                this["LoggingLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DefaultTTSVoice {
            get {
                return ((string)(this["DefaultTTSVoice"]));
            }
            set {
                this["DefaultTTSVoice"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SqlConnectionString {
            get {
                return ((string)(this["SqlConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
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
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ReportErrors {
            get {
                return ((bool)(this["ReportErrors"]));
            }
            set {
                this["ReportErrors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseBridgedTransfers {
            get {
                return ((bool)(this["UseBridgedTransfers"]));
            }
            set {
                this["UseBridgedTransfers"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\Management\\CallButler Manager.exe")]
        public string CallButlerManagementAppLocation {
            get {
                return ((string)(this["CallButlerManagementAppLocation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\Plugins")]
        public string PluginDirectory {
            get {
                return ((string)(this["PluginDirectory"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DownloadRegistered {
            get {
                return ((bool)(this["DownloadRegistered"]));
            }
            set {
                this["DownloadRegistered"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30872")]
        public int ManagementServicePort {
            get {
                return ((int)(this["ManagementServicePort"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableRemoteManagement {
            get {
                return ((bool)(this["EnableRemoteManagement"]));
            }
            set {
                this["EnableRemoteManagement"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30874")]
        public int ClientServicePort {
            get {
                return ((int)(this["ClientServicePort"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>PhonospherePBX</string>
  <string>w0sInc06</string>
  <string>https://ws.myiotum.com:4849/RPC2</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection FindMePluginData {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["FindMePluginData"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int AnswerTimeout {
            get {
                return ((int)(this["AnswerTimeout"]));
            }
            set {
                this["AnswerTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int WelcomeGreetingDelay {
            get {
                return ((int)(this["WelcomeGreetingDelay"]));
            }
            set {
                this["WelcomeGreetingDelay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseInternalAddressForSIPMessages {
            get {
                return ((bool)(this["UseInternalAddressForSIPMessages"]));
            }
            set {
                this["UseInternalAddressForSIPMessages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CB-ULM-1B")]
        public string ProductID {
            get {
                return ((string)(this["ProductID"]));
            }
            set {
                this["ProductID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SendLogErrorEmails {
            get {
                return ((bool)(this["SendLogErrorEmails"]));
            }
            set {
                this["SendLogErrorEmails"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LogErrorEmailAddress {
            get {
                return ((string)(this["LogErrorEmailAddress"]));
            }
            set {
                this["LogErrorEmailAddress"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\Recordings")]
        public string CallRecordingSoundPath {
            get {
                return ((string)(this["CallRecordingSoundPath"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int PresenceTimeout {
            get {
                return ((int)(this["PresenceTimeout"]));
            }
            set {
                this["PresenceTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SIPRegistrarDomain {
            get {
                return ((string)(this["SIPRegistrarDomain"]));
            }
            set {
                this["SIPRegistrarDomain"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int CallBlastTimeout {
            get {
                return ((int)(this["CallBlastTimeout"]));
            }
            set {
                this["CallBlastTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AllowOutboundDialing {
            get {
                return ((bool)(this["AllowOutboundDialing"]));
            }
            set {
                this["AllowOutboundDialing"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string OutboundDialingPrefix {
            get {
                return ((string)(this["OutboundDialingPrefix"]));
            }
            set {
                this["OutboundDialingPrefix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TryReceptionistFirst {
            get {
                return ((bool)(this["TryReceptionistFirst"]));
            }
            set {
                this["TryReceptionistFirst"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        public int CallConnectorQueuePeriod {
            get {
                return ((int)(this["CallConnectorQueuePeriod"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00000000-0000-0000-0000-000000000000")]
        public global::System.Guid ReceptionistExtensionID {
            get {
                return ((global::System.Guid)(this["ReceptionistExtensionID"]));
            }
            set {
                this["ReceptionistExtensionID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableCallHistory {
            get {
                return ((bool)(this["EnableCallHistory"]));
            }
            set {
                this["EnableCallHistory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnablePBX {
            get {
                return ((bool)(this["EnablePBX"]));
            }
            set {
                this["EnablePBX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BusyRedirectServer {
            get {
                return ((string)(this["BusyRedirectServer"]));
            }
            set {
                this["BusyRedirectServer"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnablePerformanceCounters {
            get {
                return ((bool)(this["EnablePerformanceCounters"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SendDTMFInAudio {
            get {
                return ((bool)(this["SendDTMFInAudio"]));
            }
            set {
                this["SendDTMFInAudio"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ForceDefaultProviderForOutboundCalls {
            get {
                return ((bool)(this["ForceDefaultProviderForOutboundCalls"]));
            }
            set {
                this["ForceDefaultProviderForOutboundCalls"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public CallButler.Telecom.AudioCodecInformation[] AudioCodecs {
            get {
                return ((CallButler.Telecom.AudioCodecInformation[])(this["AudioCodecs"]));
            }
            set {
                this["AudioCodecs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\Sounds\\Temp")]
        public string GreetingRecordingTempPath {
            get {
                return ((string)(this["GreetingRecordingTempPath"]));
            }
            set {
                this["GreetingRecordingTempPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AutoForwardFaxTo {
            get {
                return ((string)(this["AutoForwardFaxTo"]));
            }
            set {
                this["AutoForwardFaxTo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string InternalSIPDomain {
            get {
                return ((string)(this["InternalSIPDomain"]));
            }
            set {
                this["InternalSIPDomain"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableKinesisServer {
            get {
                return ((bool)(this["EnableKinesisServer"]));
            }
            set {
                this["EnableKinesisServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CustomCallScreeningPrompt {
            get {
                return ((string)(this["CustomCallScreeningPrompt"]));
            }
            set {
                this["CustomCallScreeningPrompt"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CustomIncomingCallerID {
            get {
                return ((string)(this["CustomIncomingCallerID"]));
            }
            set {
                this["CustomIncomingCallerID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CustomIncomingCallerNumber {
            get {
                return ((string)(this["CustomIncomingCallerNumber"]));
            }
            set {
                this["CustomIncomingCallerNumber"] = value;
            }
        }
    }
}
