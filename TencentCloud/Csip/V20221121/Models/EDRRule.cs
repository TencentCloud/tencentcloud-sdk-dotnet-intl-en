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

    public class EDRRule : AbstractModel
    {
        
        /// <summary>
        /// <p>Policy ID.</p>
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

        /// <summary>
        /// <p>Policy type. 0: System policy; 1: Custom policy</p>
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// <p>Policy name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Policy description</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Content Type: md5-File MD5, cmdline-Command Line, dns-DNS, ip_inbound-Inbound IP, ip_outbound-Outbound IP, custom_file-Custom File, process_network-Process Network</p>
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// <p>Executed Action: 0-Alert, 1-Allow, 2-Alert and Block</p>
        /// </summary>
        [JsonProperty("Action")]
        public long? Action{ get; set; }

        /// <summary>
        /// <p>Alarm Level: 0-None, 1-High, 2-Medium, 3-Low, 4-Reminder</p>
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// <p>Detection Mode: 0-Precise, 1-Balanced, 2-Deep</p>
        /// </summary>
        [JsonProperty("DetectMode")]
        public long? DetectMode{ get; set; }

        /// <summary>
        /// <p>Detection mode / Detect Type: 0-Host Detection, 1-Network Detection</p>
        /// </summary>
        [JsonProperty("DetectType")]
        public long? DetectType{ get; set; }

        /// <summary>
        /// <p>Attack phase</p>
        /// </summary>
        [JsonProperty("AttackStage")]
        public string AttackStage{ get; set; }

        /// <summary>
        /// <p>Effective asset scope of host / Effective Scope: 0-Specified Hosts, 1-All Hosts, 2-Professional, 3-Flagship, 4-Professional+Flagship</p>
        /// </summary>
        [JsonProperty("CWPScope")]
        public long? CWPScope{ get; set; }

        /// <summary>
        /// <p>Selected host at host runtime</p>
        /// </summary>
        [JsonProperty("QUUIDS")]
        public string[] QUUIDS{ get; set; }

        /// <summary>
        /// <p>Status: 0-Enabled, 1-Disabled</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Modification time.</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>Whether interception is supported / Support Block: 0-Not Supported, 1-Supported</p>
        /// </summary>
        [JsonProperty("SupportBlock")]
        public long? SupportBlock{ get; set; }

        /// <summary>
        /// <p>MD5 list. This field is filled when ContentType is md5.</p>
        /// </summary>
        [JsonProperty("Md5List")]
        public string[] Md5List{ get; set; }

        /// <summary>
        /// <p>File name list, filled when ContentType=custom_file</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string[] FileName{ get; set; }

        /// <summary>
        /// <p>File directory list, fill when ContentType=custom_file</p>
        /// </summary>
        [JsonProperty("FileDirectory")]
        public string[] FileDirectory{ get; set; }

        /// <summary>
        /// <p>Domain name list. Fill in when ContentType=dns</p>
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// <p>Outbound IP list, populated when ContentType=ip_outbound</p>
        /// </summary>
        [JsonProperty("OutboundIP")]
        public string[] OutboundIP{ get; set; }

        /// <summary>
        /// <p>Inbound IP list, filled when ContentType=ip_inbound</p>
        /// </summary>
        [JsonProperty("InboundIP")]
        public string[] InboundIP{ get; set; }

        /// <summary>
        /// <p>Command line rule, filled when ContentType=cmdline</p>
        /// </summary>
        [JsonProperty("CmdLineRules")]
        public RuleContentCmdLine CmdLineRules{ get; set; }

        /// <summary>
        /// <p>Container Image Scope: 0-Specified Images, 1-All Images</p>
        /// </summary>
        [JsonProperty("TCSSScope")]
        public long? TCSSScope{ get; set; }

        /// <summary>
        /// <p>Image ID list that takes effect / Image IDs (when TCSSScope=0)</p>
        /// </summary>
        [JsonProperty("ImageIDs")]
        public string[] ImageIDs{ get; set; }

        /// <summary>
        /// <p>Image name regular expression / Image Names Regex</p>
        /// </summary>
        [JsonProperty("ImageNamesRegex")]
        public string ImageNamesRegex{ get; set; }

        /// <summary>
        /// <p>Confidence: 0-Low, 1-Medium, 2-High</p>
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// <p>Excluded host list / Excluded Host QUUIDS</p>
        /// </summary>
        [JsonProperty("ExcludeQUUIDS")]
        public string[] ExcludeQUUIDS{ get; set; }

        /// <summary>
        /// <p>Excluded image id list / Excluded Image IDs</p>
        /// </summary>
        [JsonProperty("ExcludeImageIDs")]
        public string[] ExcludeImageIDs{ get; set; }

        /// <summary>
        /// <p>Process network rules</p>
        /// </summary>
        [JsonProperty("ProcessNetworkRules")]
        public RuleContentProcessNetwork ProcessNetworkRules{ get; set; }

        /// <summary>
        /// <p>APPID corresponding to the policy.</p>
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// <p>Selected instance ID range</p>
        /// </summary>
        [JsonProperty("InstanceIDs")]
        public string[] InstanceIDs{ get; set; }

        /// <summary>
        /// <p>Excluded instance ID</p>
        /// </summary>
        [JsonProperty("ExcludeInstanceIDs")]
        public string[] ExcludeInstanceIDs{ get; set; }

        /// <summary>
        /// <p>Cluster ID list that takes effect (with a value when TCSSScope=0; empty returns [])</p>
        /// </summary>
        [JsonProperty("ClusterIDs")]
        public string[] ClusterIDs{ get; set; }

        /// <summary>
        /// <p>Cluster ID list for exclusion (empty returns [])</p>
        /// </summary>
        [JsonProperty("ExcludeClusterIDs")]
        public string[] ExcludeClusterIDs{ get; set; }

        /// <summary>
        /// <p>Container condition matching.</p>
        /// </summary>
        [JsonProperty("ConditionMatches")]
        public ConditionMatch[] ConditionMatches{ get; set; }

        /// <summary>
        /// <p>Security center tag</p>
        /// </summary>
        [JsonProperty("TagItems")]
        public EDRRuleTagItem[] TagItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "DetectMode", this.DetectMode);
            this.SetParamSimple(map, prefix + "DetectType", this.DetectType);
            this.SetParamSimple(map, prefix + "AttackStage", this.AttackStage);
            this.SetParamSimple(map, prefix + "CWPScope", this.CWPScope);
            this.SetParamArraySimple(map, prefix + "QUUIDS.", this.QUUIDS);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "SupportBlock", this.SupportBlock);
            this.SetParamArraySimple(map, prefix + "Md5List.", this.Md5List);
            this.SetParamArraySimple(map, prefix + "FileName.", this.FileName);
            this.SetParamArraySimple(map, prefix + "FileDirectory.", this.FileDirectory);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArraySimple(map, prefix + "OutboundIP.", this.OutboundIP);
            this.SetParamArraySimple(map, prefix + "InboundIP.", this.InboundIP);
            this.SetParamObj(map, prefix + "CmdLineRules.", this.CmdLineRules);
            this.SetParamSimple(map, prefix + "TCSSScope", this.TCSSScope);
            this.SetParamArraySimple(map, prefix + "ImageIDs.", this.ImageIDs);
            this.SetParamSimple(map, prefix + "ImageNamesRegex", this.ImageNamesRegex);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamArraySimple(map, prefix + "ExcludeQUUIDS.", this.ExcludeQUUIDS);
            this.SetParamArraySimple(map, prefix + "ExcludeImageIDs.", this.ExcludeImageIDs);
            this.SetParamObj(map, prefix + "ProcessNetworkRules.", this.ProcessNetworkRules);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamArraySimple(map, prefix + "InstanceIDs.", this.InstanceIDs);
            this.SetParamArraySimple(map, prefix + "ExcludeInstanceIDs.", this.ExcludeInstanceIDs);
            this.SetParamArraySimple(map, prefix + "ClusterIDs.", this.ClusterIDs);
            this.SetParamArraySimple(map, prefix + "ExcludeClusterIDs.", this.ExcludeClusterIDs);
            this.SetParamArrayObj(map, prefix + "ConditionMatches.", this.ConditionMatches);
            this.SetParamArrayObj(map, prefix + "TagItems.", this.TagItems);
        }
    }
}

