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

    public class EdrAlertDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>Primary key ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>Tenant ID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>Alarm unique ID</p>
        /// </summary>
        [JsonProperty("AlertId")]
        public string AlertId{ get; set; }

        /// <summary>
        /// <p>Major category of alarm (English enumeration: VIRUS_TROJAN/ABNORMAL_LOGIN/HOST_BEHAVIOR/NETWORK_BEHAVIOR/LINK_ENGINE)</p>
        /// </summary>
        [JsonProperty("AlertCategory")]
        public string AlertCategory{ get; set; }

        /// <summary>
        /// <p>Alarm sub-type (enum: MALWARE_FILE/MALWARE_PROCESS/RISK_LOGIN/BRUTE_FORCE/DNS/BASH/PRIV_ESCALATION/REVERSE_SHELL/NET_ATTACK/VUL_DEFENCE/MEMORY_SHELL_INJECT/MEMORY_SHELL_SCAN/MULTI_BEHAVIOR_ATTACK)</p>
        /// </summary>
        [JsonProperty("AlertSubType")]
        public string AlertSubType{ get; set; }

        /// <summary>
        /// <p>Associated rule ID</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>Rule type: 0 - system rule; 1 - user-customized</p>
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// <p>Alarm level (English enumeration: CRITICAL/HIGH/MEDIUM/LOW/INFO)</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>Processing status (English enumeration: PENDING/PROCESSED/WHITELISTED/ISOLATED/CLEANED/IGNORED/ISOLATING/RESTORING/BLOCKED/DELETED)</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>ATT&amp;CK attack stages</p>
        /// </summary>
        [JsonProperty("AttackStage")]
        public string AttackStage{ get; set; }

        /// <summary>
        /// <p>Detection Mode (Enum: PRECISE/BALANCED/DEEP)</p>
        /// </summary>
        [JsonProperty("DetectMode")]
        public string DetectMode{ get; set; }

        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Host UUID</p>
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// <p>Number of aggregations</p>
        /// </summary>
        [JsonProperty("EventCount")]
        public long? EventCount{ get; set; }

        /// <summary>
        /// <p>Whether it is a paid edition</p>
        /// </summary>
        [JsonProperty("IsProVersion")]
        public long? IsProVersion{ get; set; }

        /// <summary>
        /// <p>Alarm source (English enumeration: HOST/CONTAINER/K8S/CSIP)</p>
        /// </summary>
        [JsonProperty("AlertSource")]
        public string AlertSource{ get; set; }

        /// <summary>
        /// <p>Container image ID (reserved field, always an empty string).</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>Container ID (reserved field, always an empty string)</p>
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// <p>Cluster ID (reserved field, always an empty string)</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>First discovery time</p>
        /// </summary>
        [JsonProperty("FirstDetectTime")]
        public string FirstDetectTime{ get; set; }

        /// <summary>
        /// <p>Most recent discovery time</p>
        /// </summary>
        [JsonProperty("LatestDetectTime")]
        public string LatestDetectTime{ get; set; }

        /// <summary>
        /// <p>Rule name (rule enrichment)</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>Content type: md5/cmdline/dns/ip_inbound/ip_outbound/custom_file/process_network</p>
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// <p>Instance name (asset enrichment)</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Public IP address (asset enrichment)</p>
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// <p>Private IP address (asset enrichment)</p>
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// <p>Alert details json string (parsed by the frontend via JSON.parse; empty value is &quot;{}&quot;)</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>Alarm name (Chinese and English name of the sub-type)</p>
        /// </summary>
        [JsonProperty("AlertName")]
        public string AlertName{ get; set; }

        /// <summary>
        /// <p>Security center tag</p>
        /// </summary>
        [JsonProperty("CSIPTags")]
        public CSIPTag[] CSIPTags{ get; set; }

        /// <summary>
        /// <p>Severity description (unified field, merged from original independent fields of sub-types)</p>
        /// </summary>
        [JsonProperty("HarmDesc")]
        public string HarmDesc{ get; set; }

        /// <summary>
        /// <p>Repair advice (unified field)</p>
        /// </summary>
        [JsonProperty("SuggestScheme")]
        public string SuggestScheme{ get; set; }

        /// <summary>
        /// <p>Data source: vuldb/vdc/intel/default</p>
        /// </summary>
        [JsonProperty("HarmDescSource")]
        public string HarmDescSource{ get; set; }

        /// <summary>
        /// <p>Unified threat intelligence tag (routes to different intelligence sources by sub-type)</p>
        /// </summary>
        [JsonProperty("ThreatTags")]
        public string[] ThreatTags{ get; set; }

        /// <summary>
        /// <p>Base64-decoded command (unique to high-risk command sub-type)</p>
        /// </summary>
        [JsonProperty("BashCmdDecoded")]
        public string BashCmdDecoded{ get; set; }

        /// <summary>
        /// <p>Vulnerability name (unique to network attack sub-type)</p>
        /// </summary>
        [JsonProperty("NetVulName")]
        public string NetVulName{ get; set; }

        /// <summary>
        /// <p>CVE ID (unique to network attack sub-type)</p>
        /// </summary>
        [JsonProperty("NetCVEId")]
        public string NetCVEId{ get; set; }

        /// <summary>
        /// <p>Exception behavior (unique to network attack sub-type)</p>
        /// </summary>
        [JsonProperty("NetAbnormalAction")]
        public string NetAbnormalAction{ get; set; }

        /// <summary>
        /// <p>IP intelligence information (do not return if empty)</p>
        /// </summary>
        [JsonProperty("IPIntel")]
        public IPIntelInfo IPIntel{ get; set; }

        /// <summary>
        /// <p>Multi-act attack rule type categorization: sequence/threshold/command</p>
        /// </summary>
        [JsonProperty("MultiBehaviorDetectionMode")]
        public string MultiBehaviorDetectionMode{ get; set; }

        /// <summary>
        /// <p>Alarm source description (derived by sub-type, describing which engine/rule detects it)</p>
        /// </summary>
        [JsonProperty("SourceDesc")]
        public string SourceDesc{ get; set; }

        /// <summary>
        /// <p>Time parameter format to process: 2026-05-26 19:45:48</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>Source of intelligence enrichment result (flag indicating whether external intelligence is hit successfully this time). Parameter Value: "VDC" / "IPAnalysis" / "BreakingTI" / empty string</p>
        /// </summary>
        [JsonProperty("IntelSource")]
        public string IntelSource{ get; set; }

        /// <summary>
        /// <p>Comprehensive analysis: Chinese and English are translated. Chinese: Malicious/Safe/Unknown; English: Malicious/Safe/Unknown</p>
        /// </summary>
        [JsonProperty("Verdict")]
        public string Verdict{ get; set; }

        /// <summary>
        /// <p>Analysis basis</p>
        /// </summary>
        [JsonProperty("VerdictBasis")]
        public string VerdictBasis{ get; set; }

        /// <summary>
        /// <p>Virus name</p>
        /// </summary>
        [JsonProperty("VirusName")]
        public string VirusName{ get; set; }

        /// <summary>
        /// <p>Virus family</p>
        /// </summary>
        [JsonProperty("VirusFamily")]
        public string VirusFamily{ get; set; }

        /// <summary>
        /// <p>NetResponsePayload response packet (base64 encoded string)</p>
        /// </summary>
        [JsonProperty("NetResponsePayload")]
        public string NetResponsePayload{ get; set; }

        /// <summary>
        /// <p>Service process information (JSON string after base64 encoding)</p>
        /// </summary>
        [JsonProperty("NetSvcPs")]
        public string NetSvcPs{ get; set; }

        /// <summary>
        /// <p>Container name</p>
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// <p>Container image name</p>
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// <p>Cluster name.</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>Container running status (raw enumeration: RUNNING/PAUSED/STOPPED...; frontend performs mapping itself)</p><p>Enumeration values:</p><ul><li>RUNNING: running</li><li>PAUSED: suspended</li><li>STOPPED: stopped</li><li>CREATED: created</li><li>DESTROYED: terminated</li><li>RESTARTING: restarting</li><li>REMOVING: migrating</li><li>DEAD: DEAD</li><li>UNKNOWN: unknown</li></ul>
        /// </summary>
        [JsonProperty("RunStatus")]
        public string RunStatus{ get; set; }

        /// <summary>
        /// <p>POD Name</p>
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// <p>POD IP</p>
        /// </summary>
        [JsonProperty("PodIp")]
        public string PodIp{ get; set; }

        /// <summary>
        /// <p>Namespace.</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>POD workload type</p>
        /// </summary>
        [JsonProperty("PodWorkloadType")]
        public string PodWorkloadType{ get; set; }

        /// <summary>
        /// <p>Cluster ca cert md5</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5")]
        public string ClusterCaMD5{ get; set; }

        /// <summary>
        /// <p>POD Unique id</p>
        /// </summary>
        [JsonProperty("PodUniqueId")]
        public string PodUniqueId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AlertId", this.AlertId);
            this.SetParamSimple(map, prefix + "AlertCategory", this.AlertCategory);
            this.SetParamSimple(map, prefix + "AlertSubType", this.AlertSubType);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AttackStage", this.AttackStage);
            this.SetParamSimple(map, prefix + "DetectMode", this.DetectMode);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "IsProVersion", this.IsProVersion);
            this.SetParamSimple(map, prefix + "AlertSource", this.AlertSource);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "FirstDetectTime", this.FirstDetectTime);
            this.SetParamSimple(map, prefix + "LatestDetectTime", this.LatestDetectTime);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "AlertName", this.AlertName);
            this.SetParamArrayObj(map, prefix + "CSIPTags.", this.CSIPTags);
            this.SetParamSimple(map, prefix + "HarmDesc", this.HarmDesc);
            this.SetParamSimple(map, prefix + "SuggestScheme", this.SuggestScheme);
            this.SetParamSimple(map, prefix + "HarmDescSource", this.HarmDescSource);
            this.SetParamArraySimple(map, prefix + "ThreatTags.", this.ThreatTags);
            this.SetParamSimple(map, prefix + "BashCmdDecoded", this.BashCmdDecoded);
            this.SetParamSimple(map, prefix + "NetVulName", this.NetVulName);
            this.SetParamSimple(map, prefix + "NetCVEId", this.NetCVEId);
            this.SetParamSimple(map, prefix + "NetAbnormalAction", this.NetAbnormalAction);
            this.SetParamObj(map, prefix + "IPIntel.", this.IPIntel);
            this.SetParamSimple(map, prefix + "MultiBehaviorDetectionMode", this.MultiBehaviorDetectionMode);
            this.SetParamSimple(map, prefix + "SourceDesc", this.SourceDesc);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "IntelSource", this.IntelSource);
            this.SetParamSimple(map, prefix + "Verdict", this.Verdict);
            this.SetParamSimple(map, prefix + "VerdictBasis", this.VerdictBasis);
            this.SetParamSimple(map, prefix + "VirusName", this.VirusName);
            this.SetParamSimple(map, prefix + "VirusFamily", this.VirusFamily);
            this.SetParamSimple(map, prefix + "NetResponsePayload", this.NetResponsePayload);
            this.SetParamSimple(map, prefix + "NetSvcPs", this.NetSvcPs);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "RunStatus", this.RunStatus);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "PodIp", this.PodIp);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "PodWorkloadType", this.PodWorkloadType);
            this.SetParamSimple(map, prefix + "ClusterCaMD5", this.ClusterCaMD5);
            this.SetParamSimple(map, prefix + "PodUniqueId", this.PodUniqueId);
        }
    }
}

