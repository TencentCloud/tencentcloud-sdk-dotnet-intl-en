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

    public class ModifyEDRRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Policy type / Rule Type: 0-System policy/System Rule, 1-Custom policy/Custom Rule</p>
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// <p>Execution action / Action: 0-Alert, 1-Allow, 2-Alert and Block</p>
        /// </summary>
        [JsonProperty("AlertAction")]
        public long? AlertAction{ get; set; }

        /// <summary>
        /// <p>Effective Scope: 0-Specified Hosts, 1-All Hosts, 2-Professional, 3-Flagship, 4-Professional+Flagship     QUUIDS        []string json:&quot;QUUIDS&quot;                                      // Host QUUIDS (when Scope=0)</p>
        /// </summary>
        [JsonProperty("CWPScope")]
        public long? CWPScope{ get; set; }

        /// <summary>
        /// <p>Container Image Scope: 0-Specified Images, 1-All Images</p>
        /// </summary>
        [JsonProperty("TCSSScope")]
        public long? TCSSScope{ get; set; }

        /// <summary>
        /// <p>Switch / Status: 0-Enabled, 1-Disabled</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Policy name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Content Type: md5-File MD5, cmdline-Command Line, dns-DNS, ip_inbound-Inbound IP, ip_outbound-Outbound IP, custom_file-Custom File, process_network-Process Network</p>
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// <p>Alarm Level: 1-High risk, 2-Medium risk, 3-Low risk, 4-Notification</p>
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// <p>Detection Mode: 0-Precise, 1-Balanced, 2-Deep</p>
        /// </summary>
        [JsonProperty("DetectMode")]
        public long? DetectMode{ get; set; }

        /// <summary>
        /// <p>Attack phase</p>
        /// </summary>
        [JsonProperty("AttackStage")]
        public string AttackStage{ get; set; }

        /// <summary>
        /// <p>Policy.</p>
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

        /// <summary>
        /// <p>Policy description</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Handle Old Events: 0-No, 1-Yes</p>
        /// </summary>
        [JsonProperty("DealOldEvents")]
        public long? DealOldEvents{ get; set; }

        /// <summary>
        /// <p>List of MD5 values passed in when ContentType=md5</p>
        /// </summary>
        [JsonProperty("Md5List")]
        public string[] Md5List{ get; set; }

        /// <summary>
        /// <p>List of file names passed in when ContentType=custom_file (Base64 code)</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string[] FileName{ get; set; }

        /// <summary>
        /// <p>Directory list of files passed in when ContentType=custom_file (Base64-encoded)</p>
        /// </summary>
        [JsonProperty("FileDirectory")]
        public string[] FileDirectory{ get; set; }

        /// <summary>
        /// <p>Command line rule passed in when ContentType=cmdline. The Exe/Cmdline fields of Process/PProcess/AProcess need to be Base64 encoded</p>
        /// </summary>
        [JsonProperty("CmdLineRules")]
        public RuleContentCmdLine CmdLineRules{ get; set; }

        /// <summary>
        /// <p>List of domain names passed in when ContentType=dns (Base64-encoded)</p>
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// <p>Outbound IP list passed in when ContentType=ip_outbound (Base64-encoded)</p>
        /// </summary>
        [JsonProperty("OutboundIP")]
        public string[] OutboundIP{ get; set; }

        /// <summary>
        /// <p>Inbound IP list passed in when ContentType=ip_inbound (Base64-encoded)</p>
        /// </summary>
        [JsonProperty("InboundIP")]
        public string[] InboundIP{ get; set; }

        /// <summary>
        /// <p>Image ID list / Image IDs (when TCSSScope=0)</p>
        /// </summary>
        [JsonProperty("ImageIDs")]
        public string[] ImageIDs{ get; set; }

        /// <summary>
        /// <p>Process network rule passed in when ContentType=process_network</p>
        /// </summary>
        [JsonProperty("ProcessNetworkRules")]
        public RuleContentProcessNetwork ProcessNetworkRules{ get; set; }

        /// <summary>
        /// <p>APPID of the selected accounts</p>
        /// </summary>
        [JsonProperty("TargetAppIDs")]
        public ulong?[] TargetAppIDs{ get; set; }

        /// <summary>
        /// <p>Allowlisted target machine information of the alarm</p>
        /// </summary>
        [JsonProperty("Target")]
        public EdrAlertTarget Target{ get; set; }

        /// <summary>
        /// <p>Instance ID and APPID corresponding to the custom asset</p>
        /// </summary>
        [JsonProperty("InstanceIDsWithAppId")]
        public InstanceIDWithAppIdItem[] InstanceIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>Select all instance IDs and APPIDs excluded from assets</p>
        /// </summary>
        [JsonProperty("ExcludeInstanceIDsWithAppId")]
        public InstanceIDWithAppIdItem[] ExcludeInstanceIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>Security center tag ID list (host asset scope "Select by tag", only applicable to hosts); capacity limit 100 (truncate if exceeded). Tag source API: DescribeAssetTagTree</p>
        /// </summary>
        [JsonProperty("TagIDs")]
        public string[] TagIDs{ get; set; }

        /// <summary>
        /// <p>Specify the cluster list to take effect (each item includes AppId + ClusterID, used when TCSSScope=0). The input parameter set has a capacity limit of 3000 (truncated to retain the first 3000 items if exceeded)</p>
        /// </summary>
        [JsonProperty("ClusterIDsWithAppId")]
        public ClusterIDWithAppIdItem[] ClusterIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>Cluster exclusion list (each item contains AppId + ClusterID); input parameter set capacity limit: 3000 (truncate and retain the first 3000 items if exceeded)</p>
        /// </summary>
        [JsonProperty("ExcludeClusterIDsWithAppId")]
        public ClusterIDWithAppIdItem[] ExcludeClusterIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>Directly select images (each item contains AppId + ImageID, and filter further on the basis of the cluster). In multi-account scenarios, each account only stores its own images. The input parameter set capacity limit is 3000 (truncate and retain the first 3000 items if exceeded)</p>
        /// </summary>
        [JsonProperty("ImageIDsWithAppId")]
        public ImageIDWithAppIdItem[] ImageIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>Container condition matching</p>
        /// </summary>
        [JsonProperty("ConditionMatches")]
        public ConditionMatch[] ConditionMatches{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "AlertAction", this.AlertAction);
            this.SetParamSimple(map, prefix + "CWPScope", this.CWPScope);
            this.SetParamSimple(map, prefix + "TCSSScope", this.TCSSScope);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "DetectMode", this.DetectMode);
            this.SetParamSimple(map, prefix + "AttackStage", this.AttackStage);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DealOldEvents", this.DealOldEvents);
            this.SetParamArraySimple(map, prefix + "Md5List.", this.Md5List);
            this.SetParamArraySimple(map, prefix + "FileName.", this.FileName);
            this.SetParamArraySimple(map, prefix + "FileDirectory.", this.FileDirectory);
            this.SetParamObj(map, prefix + "CmdLineRules.", this.CmdLineRules);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArraySimple(map, prefix + "OutboundIP.", this.OutboundIP);
            this.SetParamArraySimple(map, prefix + "InboundIP.", this.InboundIP);
            this.SetParamArraySimple(map, prefix + "ImageIDs.", this.ImageIDs);
            this.SetParamObj(map, prefix + "ProcessNetworkRules.", this.ProcessNetworkRules);
            this.SetParamArraySimple(map, prefix + "TargetAppIDs.", this.TargetAppIDs);
            this.SetParamObj(map, prefix + "Target.", this.Target);
            this.SetParamArrayObj(map, prefix + "InstanceIDsWithAppId.", this.InstanceIDsWithAppId);
            this.SetParamArrayObj(map, prefix + "ExcludeInstanceIDsWithAppId.", this.ExcludeInstanceIDsWithAppId);
            this.SetParamArraySimple(map, prefix + "TagIDs.", this.TagIDs);
            this.SetParamArrayObj(map, prefix + "ClusterIDsWithAppId.", this.ClusterIDsWithAppId);
            this.SetParamArrayObj(map, prefix + "ExcludeClusterIDsWithAppId.", this.ExcludeClusterIDsWithAppId);
            this.SetParamArrayObj(map, prefix + "ImageIDsWithAppId.", this.ImageIDsWithAppId);
            this.SetParamArrayObj(map, prefix + "ConditionMatches.", this.ConditionMatches);
        }
    }
}

