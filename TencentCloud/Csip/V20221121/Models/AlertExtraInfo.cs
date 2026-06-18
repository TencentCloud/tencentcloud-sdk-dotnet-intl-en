/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlertExtraInfo : AbstractModel
    {
        
        /// <summary>
        /// Related attack events
        /// </summary>
        [JsonProperty("RelateEvent")]
        public RelatedEvent RelateEvent{ get; set; }

        /// <summary>
        /// Leaked content
        /// </summary>
        [JsonProperty("LeakContent")]
        public string LeakContent{ get; set; }

        /// <summary>
        /// Leak API
        /// </summary>
        [JsonProperty("LeakAPI")]
        public string LeakAPI{ get; set; }

        /// <summary>
        /// secretID
        /// </summary>
        [JsonProperty("SecretID")]
        public string SecretID{ get; set; }

        /// <summary>
        /// hit rule
        /// </summary>
        [JsonProperty("Rule")]
        public string Rule{ get; set; }

        /// <summary>
        /// Rule description
        /// </summary>
        [JsonProperty("RuleDesc")]
        public string RuleDesc{ get; set; }

        /// <summary>
        /// Protocol port
        /// </summary>
        [JsonProperty("ProtocolPort")]
        public string ProtocolPort{ get; set; }

        /// <summary>
        /// Attack content
        /// </summary>
        [JsonProperty("AttackContent")]
        public string AttackContent{ get; set; }

        /// <summary>
        /// Attack IP profiling
        /// </summary>
        [JsonProperty("AttackIPProfile")]
        public string AttackIPProfile{ get; set; }

        /// <summary>
        /// Attack IP tag
        /// </summary>
        [JsonProperty("AttackIPTags")]
        public string AttackIPTags{ get; set; }

        /// <summary>
        /// Request method
        /// </summary>
        [JsonProperty("RequestMethod")]
        public string RequestMethod{ get; set; }

        /// <summary>
        /// HTTP log
        /// </summary>
        [JsonProperty("HttpLog")]
        public string HttpLog{ get; set; }

        /// <summary>
        /// Attacked domain name
        /// </summary>
        [JsonProperty("AttackDomain")]
        public string AttackDomain{ get; set; }

        /// <summary>
        /// File path
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// user_agent
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// Request headers
        /// </summary>
        [JsonProperty("RequestHeaders")]
        public string RequestHeaders{ get; set; }

        /// <summary>
        /// Login username
        /// </summary>
        [JsonProperty("LoginUserName")]
        public string LoginUserName{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("VulnerabilityName")]
        public string VulnerabilityName{ get; set; }

        /// <summary>
        /// Public vulnerability and exposure
        /// </summary>
        [JsonProperty("CVE")]
        public string CVE{ get; set; }

        /// <summary>
        /// Service process
        /// </summary>
        [JsonProperty("ServiceProcess")]
        public string ServiceProcess{ get; set; }

        /// <summary>
        /// Filename
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// File size
        /// </summary>
        [JsonProperty("FileSize")]
        public string FileSize{ get; set; }

        /// <summary>
        /// File MD5
        /// </summary>
        [JsonProperty("FileMD5")]
        public string FileMD5{ get; set; }

        /// <summary>
        /// Last access time of the file
        /// </summary>
        [JsonProperty("FileLastAccessTime")]
        public string FileLastAccessTime{ get; set; }

        /// <summary>
        /// file modification time
        /// </summary>
        [JsonProperty("FileModifyTime")]
        public string FileModifyTime{ get; set; }

        /// <summary>
        /// Last access Time
        /// </summary>
        [JsonProperty("RecentAccessTime")]
        public string RecentAccessTime{ get; set; }

        /// <summary>
        /// Last modification time
        /// </summary>
        [JsonProperty("RecentModifyTime")]
        public string RecentModifyTime{ get; set; }

        /// <summary>
        /// Virus name
        /// </summary>
        [JsonProperty("VirusName")]
        public string VirusName{ get; set; }

        /// <summary>
        /// Virus file tag
        /// </summary>
        [JsonProperty("VirusFileTags")]
        public string VirusFileTags{ get; set; }

        /// <summary>
        /// behavioral characteristics
        /// </summary>
        [JsonProperty("BehavioralCharacteristics")]
        public string BehavioralCharacteristics{ get; set; }

        /// <summary>
        /// process name (PID)
        /// </summary>
        [JsonProperty("ProcessNamePID")]
        public string ProcessNamePID{ get; set; }

        /// <summary>
        /// Process path
        /// </summary>
        [JsonProperty("ProcessPath")]
        public string ProcessPath{ get; set; }

        /// <summary>
        /// Command line of the process
        /// </summary>
        [JsonProperty("ProcessCommandLine")]
        public string ProcessCommandLine{ get; set; }

        /// <summary>
        /// Process permission
        /// </summary>
        [JsonProperty("ProcessPermissions")]
        public string ProcessPermissions{ get; set; }

        /// <summary>
        /// Execute commands
        /// </summary>
        [JsonProperty("ExecutedCommand")]
        public string ExecutedCommand{ get; set; }

        /// <summary>
        /// Affected Filename
        /// </summary>
        [JsonProperty("AffectedFileName")]
        public string AffectedFileName{ get; set; }

        /// <summary>
        /// bait path
        /// </summary>
        [JsonProperty("DecoyPath")]
        public string DecoyPath{ get; set; }

        /// <summary>
        /// Malicious process file size
        /// </summary>
        [JsonProperty("MaliciousProcessFileSize")]
        public string MaliciousProcessFileSize{ get; set; }

        /// <summary>
        /// Malicious process file MD5
        /// </summary>
        [JsonProperty("MaliciousProcessFileMD5")]
        public string MaliciousProcessFileMD5{ get; set; }

        /// <summary>
        /// Malicious process name (PID)
        /// </summary>
        [JsonProperty("MaliciousProcessNamePID")]
        public string MaliciousProcessNamePID{ get; set; }

        /// <summary>
        /// Malicious process path
        /// </summary>
        [JsonProperty("MaliciousProcessPath")]
        public string MaliciousProcessPath{ get; set; }

        /// <summary>
        /// malicious process start time
        /// </summary>
        [JsonProperty("MaliciousProcessStartTime")]
        public string MaliciousProcessStartTime{ get; set; }

        /// <summary>
        /// command content
        /// </summary>
        [JsonProperty("CommandContent")]
        public string CommandContent{ get; set; }

        /// <summary>
        /// Startup user
        /// </summary>
        [JsonProperty("StartupUser")]
        public string StartupUser{ get; set; }

        /// <summary>
        /// User group
        /// </summary>
        [JsonProperty("UserGroup")]
        public string UserGroup{ get; set; }

        /// <summary>
        /// Add new permission
        /// </summary>
        [JsonProperty("NewPermissions")]
        public string NewPermissions{ get; set; }

        /// <summary>
        /// Parent process
        /// </summary>
        [JsonProperty("ParentProcess")]
        public string ParentProcess{ get; set; }

        /// <summary>
        /// Class name
        /// </summary>
        [JsonProperty("ClassName")]
        public string ClassName{ get; set; }

        /// <summary>
        /// class loader
        /// </summary>
        [JsonProperty("ClassLoader")]
        public string ClassLoader{ get; set; }

        /// <summary>
        /// File size
        /// </summary>
        [JsonProperty("ClassFileSize")]
        public string ClassFileSize{ get; set; }

        /// <summary>
        /// Class file MD5
        /// </summary>
        [JsonProperty("ClassFileMD5")]
        public string ClassFileMD5{ get; set; }

        /// <summary>
        /// Parent class name
        /// </summary>
        [JsonProperty("ParentClassName")]
        public string ParentClassName{ get; set; }

        /// <summary>
        /// inherit an API
        /// </summary>
        [JsonProperty("InheritedInterface")]
        public string InheritedInterface{ get; set; }

        /// <summary>
        /// Annotation
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// payload content
        /// </summary>
        [JsonProperty("PayloadContent")]
        public string PayloadContent{ get; set; }

        /// <summary>
        /// Callback address profile
        /// </summary>
        [JsonProperty("CallbackAddressPortrait")]
        public string CallbackAddressPortrait{ get; set; }

        /// <summary>
        /// Callback address tag
        /// </summary>
        [JsonProperty("CallbackAddressTag")]
        public string CallbackAddressTag{ get; set; }

        /// <summary>
        /// Process MD5
        /// </summary>
        [JsonProperty("ProcessMD5")]
        public string ProcessMD5{ get; set; }

        /// <summary>
        /// File permission
        /// </summary>
        [JsonProperty("FilePermission")]
        public string FilePermission{ get; set; }

        /// <summary>
        /// Information field from log analysis
        /// </summary>
        [JsonProperty("FromLogAnalysisData")]
        public KeyValue[] FromLogAnalysisData{ get; set; }

        /// <summary>
        /// probe hit
        /// </summary>
        [JsonProperty("HitProbe")]
        public string HitProbe{ get; set; }

        /// <summary>
        /// hit honeypot
        /// </summary>
        [JsonProperty("HitHoneyPot")]
        public string HitHoneyPot{ get; set; }

        /// <summary>
        /// command list
        /// </summary>
        [JsonProperty("CommandList")]
        public string CommandList{ get; set; }

        /// <summary>
        /// Attack event description
        /// </summary>
        [JsonProperty("AttackEventDesc")]
        public string AttackEventDesc{ get; set; }

        /// <summary>
        /// Process information
        /// </summary>
        [JsonProperty("ProcessInfo")]
        public string ProcessInfo{ get; set; }

        /// <summary>
        /// Login username & password
        /// </summary>
        [JsonProperty("UserNameAndPwd")]
        public string UserNameAndPwd{ get; set; }

        /// <summary>
        /// Host protection policy ID
        /// </summary>
        [JsonProperty("StrategyID")]
        public string StrategyID{ get; set; }

        /// <summary>
        /// Host protection policy name
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// Host protection hit policy is a combination of policy ID and Policy Name
        /// </summary>
        [JsonProperty("HitStrategy")]
        public string HitStrategy{ get; set; }

        /// <summary>
        /// Process name
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// PID
        /// </summary>
        [JsonProperty("PID")]
        public string PID{ get; set; }

        /// <summary>
        /// Container Pod name
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// Container Pod ID
        /// </summary>
        [JsonProperty("PodID")]
        public string PodID{ get; set; }

        /// <summary>
        /// Http response
        /// </summary>
        [JsonProperty("Response")]
        public string Response{ get; set; }

        /// <summary>
        /// system call
        /// </summary>
        [JsonProperty("SystemCall")]
        public string SystemCall{ get; set; }

        /// <summary>
        /// Operation type
        /// </summary>
        [JsonProperty("Verb")]
        public string Verb{ get; set; }

        /// <summary>
        /// Log ID.
        /// </summary>
        [JsonProperty("LogID")]
        public string LogID{ get; set; }

        /// <summary>
        /// Change content
        /// </summary>
        [JsonProperty("Different")]
        public string Different{ get; set; }

        /// <summary>
        /// Event type
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// Event description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Destination address (container reverse shell)
        /// </summary>
        [JsonProperty("TargetAddress")]
        public string TargetAddress{ get; set; }

        /// <summary>
        /// Malicious request domain name (container malicious outbound connection)
        /// </summary>
        [JsonProperty("MaliciousRequestDomain")]
        public string MaliciousRequestDomain{ get; set; }

        /// <summary>
        /// Rule Type (Container K8sAPI Exception Request)
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Requested Resource (Container K8sAPI Exception Request)
        /// </summary>
        [JsonProperty("RequestURI")]
        public string RequestURI{ get; set; }

        /// <summary>
        /// Request Initiating User (Container K8sAPI Exception Request)
        /// </summary>
        [JsonProperty("RequestUser")]
        public string RequestUser{ get; set; }

        /// <summary>
        /// Request Object (Container K8sAPI Exception Request)
        /// </summary>
        [JsonProperty("RequestObject")]
        public string RequestObject{ get; set; }

        /// <summary>
        /// Response object (container K8sAPI exception request)
        /// </summary>
        [JsonProperty("ResponseObject")]
        public string ResponseObject{ get; set; }

        /// <summary>
        /// File type (Container file tamper)
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// Tag feature (malicious outbound connection of container)
        /// </summary>
        [JsonProperty("TIType")]
        public string TIType{ get; set; }

        /// <summary>
        /// Source IP Address (Container K8sAPI Exception Request)
        /// </summary>
        [JsonProperty("SourceIP")]
        public string SourceIP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RelateEvent.", this.RelateEvent);
            this.SetParamSimple(map, prefix + "LeakContent", this.LeakContent);
            this.SetParamSimple(map, prefix + "LeakAPI", this.LeakAPI);
            this.SetParamSimple(map, prefix + "SecretID", this.SecretID);
            this.SetParamSimple(map, prefix + "Rule", this.Rule);
            this.SetParamSimple(map, prefix + "RuleDesc", this.RuleDesc);
            this.SetParamSimple(map, prefix + "ProtocolPort", this.ProtocolPort);
            this.SetParamSimple(map, prefix + "AttackContent", this.AttackContent);
            this.SetParamSimple(map, prefix + "AttackIPProfile", this.AttackIPProfile);
            this.SetParamSimple(map, prefix + "AttackIPTags", this.AttackIPTags);
            this.SetParamSimple(map, prefix + "RequestMethod", this.RequestMethod);
            this.SetParamSimple(map, prefix + "HttpLog", this.HttpLog);
            this.SetParamSimple(map, prefix + "AttackDomain", this.AttackDomain);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "RequestHeaders", this.RequestHeaders);
            this.SetParamSimple(map, prefix + "LoginUserName", this.LoginUserName);
            this.SetParamSimple(map, prefix + "VulnerabilityName", this.VulnerabilityName);
            this.SetParamSimple(map, prefix + "CVE", this.CVE);
            this.SetParamSimple(map, prefix + "ServiceProcess", this.ServiceProcess);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "FileMD5", this.FileMD5);
            this.SetParamSimple(map, prefix + "FileLastAccessTime", this.FileLastAccessTime);
            this.SetParamSimple(map, prefix + "FileModifyTime", this.FileModifyTime);
            this.SetParamSimple(map, prefix + "RecentAccessTime", this.RecentAccessTime);
            this.SetParamSimple(map, prefix + "RecentModifyTime", this.RecentModifyTime);
            this.SetParamSimple(map, prefix + "VirusName", this.VirusName);
            this.SetParamSimple(map, prefix + "VirusFileTags", this.VirusFileTags);
            this.SetParamSimple(map, prefix + "BehavioralCharacteristics", this.BehavioralCharacteristics);
            this.SetParamSimple(map, prefix + "ProcessNamePID", this.ProcessNamePID);
            this.SetParamSimple(map, prefix + "ProcessPath", this.ProcessPath);
            this.SetParamSimple(map, prefix + "ProcessCommandLine", this.ProcessCommandLine);
            this.SetParamSimple(map, prefix + "ProcessPermissions", this.ProcessPermissions);
            this.SetParamSimple(map, prefix + "ExecutedCommand", this.ExecutedCommand);
            this.SetParamSimple(map, prefix + "AffectedFileName", this.AffectedFileName);
            this.SetParamSimple(map, prefix + "DecoyPath", this.DecoyPath);
            this.SetParamSimple(map, prefix + "MaliciousProcessFileSize", this.MaliciousProcessFileSize);
            this.SetParamSimple(map, prefix + "MaliciousProcessFileMD5", this.MaliciousProcessFileMD5);
            this.SetParamSimple(map, prefix + "MaliciousProcessNamePID", this.MaliciousProcessNamePID);
            this.SetParamSimple(map, prefix + "MaliciousProcessPath", this.MaliciousProcessPath);
            this.SetParamSimple(map, prefix + "MaliciousProcessStartTime", this.MaliciousProcessStartTime);
            this.SetParamSimple(map, prefix + "CommandContent", this.CommandContent);
            this.SetParamSimple(map, prefix + "StartupUser", this.StartupUser);
            this.SetParamSimple(map, prefix + "UserGroup", this.UserGroup);
            this.SetParamSimple(map, prefix + "NewPermissions", this.NewPermissions);
            this.SetParamSimple(map, prefix + "ParentProcess", this.ParentProcess);
            this.SetParamSimple(map, prefix + "ClassName", this.ClassName);
            this.SetParamSimple(map, prefix + "ClassLoader", this.ClassLoader);
            this.SetParamSimple(map, prefix + "ClassFileSize", this.ClassFileSize);
            this.SetParamSimple(map, prefix + "ClassFileMD5", this.ClassFileMD5);
            this.SetParamSimple(map, prefix + "ParentClassName", this.ParentClassName);
            this.SetParamSimple(map, prefix + "InheritedInterface", this.InheritedInterface);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "PayloadContent", this.PayloadContent);
            this.SetParamSimple(map, prefix + "CallbackAddressPortrait", this.CallbackAddressPortrait);
            this.SetParamSimple(map, prefix + "CallbackAddressTag", this.CallbackAddressTag);
            this.SetParamSimple(map, prefix + "ProcessMD5", this.ProcessMD5);
            this.SetParamSimple(map, prefix + "FilePermission", this.FilePermission);
            this.SetParamArrayObj(map, prefix + "FromLogAnalysisData.", this.FromLogAnalysisData);
            this.SetParamSimple(map, prefix + "HitProbe", this.HitProbe);
            this.SetParamSimple(map, prefix + "HitHoneyPot", this.HitHoneyPot);
            this.SetParamSimple(map, prefix + "CommandList", this.CommandList);
            this.SetParamSimple(map, prefix + "AttackEventDesc", this.AttackEventDesc);
            this.SetParamSimple(map, prefix + "ProcessInfo", this.ProcessInfo);
            this.SetParamSimple(map, prefix + "UserNameAndPwd", this.UserNameAndPwd);
            this.SetParamSimple(map, prefix + "StrategyID", this.StrategyID);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "HitStrategy", this.HitStrategy);
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "PID", this.PID);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "PodID", this.PodID);
            this.SetParamSimple(map, prefix + "Response", this.Response);
            this.SetParamSimple(map, prefix + "SystemCall", this.SystemCall);
            this.SetParamSimple(map, prefix + "Verb", this.Verb);
            this.SetParamSimple(map, prefix + "LogID", this.LogID);
            this.SetParamSimple(map, prefix + "Different", this.Different);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "TargetAddress", this.TargetAddress);
            this.SetParamSimple(map, prefix + "MaliciousRequestDomain", this.MaliciousRequestDomain);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "RequestURI", this.RequestURI);
            this.SetParamSimple(map, prefix + "RequestUser", this.RequestUser);
            this.SetParamSimple(map, prefix + "RequestObject", this.RequestObject);
            this.SetParamSimple(map, prefix + "ResponseObject", this.ResponseObject);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "TIType", this.TIType);
            this.SetParamSimple(map, prefix + "SourceIP", this.SourceIP);
        }
    }
}

