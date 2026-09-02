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

    public class BaselinePolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>Periodic scan configuration (switch, interval type, scanning period, etc.).</p>
        /// </summary>
        [JsonProperty("CycleScanConf")]
        public CycleScanConf CycleScanConf{ get; set; }

        /// <summary>
        /// <p>Detect asset major category, case-sensitive host baseline and container cluster baseline. Parameter values:</p><ul><li>HOST: Host</li><li>CLUSTER: Container cluster</li></ul>
        /// </summary>
        [JsonProperty("CheckAssetType")]
        public string CheckAssetType{ get; set; }

        /// <summary>
        /// <p>Whether to automatically join this policy when new built-in detection items are added to the system. true: automatically join, false: do not join.</p>
        /// </summary>
        [JsonProperty("AutoSyncItem")]
        public bool? AutoSyncItem{ get; set; }

        /// <summary>
        /// <p>Baseline policy type. Values:</p><ul><li>SYSTEM: system policy (CSIP built-in)</li><li>SELF: user-defined policy</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Policy Name (custom policy is user input, and system policy is a built-in classification name).</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Policy description.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Host effective scope. Value:</p><ul><li>ALL: all hosts (can be used in conjunction with ConfHostExcludeList for removal)</li><li>TAG_MATCH: tag matching, in conjunction with ConfHostTagValue</li><li>PICK: takes effect only on hosts specified in ConfHostIncludeList</li><li>NONE: no configuration</li></ul>
        /// </summary>
        [JsonProperty("ConfHostType")]
        public string ConfHostType{ get; set; }

        /// <summary>
        /// <p>Host InstanceID allowlist, used when ConfHostType=PICK / TAG_MATCH.</p>
        /// </summary>
        [JsonProperty("ConfHostIncludeList")]
        public string[] ConfHostIncludeList{ get; set; }

        /// <summary>
        /// <p>Host InstanceID removal list, used when ConfHostType=ALL.</p>
        /// </summary>
        [JsonProperty("ConfHostExcludeList")]
        public string[] ConfHostExcludeList{ get; set; }

        /// <summary>
        /// <p>Policy activation status. 0 disabled, 1 enabled; once disabled, the policy will not participate in scans and statistics.</p>
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// <p>Cluster effective scope. Value:</p><ul><li>ALL: all clusters (can be used in conjunction with ConfClusterExcludeList for removal)</li><li>PICK: takes effect only on the clusters specified by ConfClusterIncludeList</li><li>NONE: no configuration</li></ul>
        /// </summary>
        [JsonProperty("ConfClusterType")]
        public string ConfClusterType{ get; set; }

        /// <summary>
        /// <p>Cluster ID allowlist, used when ConfClusterType=PICK.</p>
        /// </summary>
        [JsonProperty("ConfClusterIncludeList")]
        public string[] ConfClusterIncludeList{ get; set; }

        /// <summary>
        /// <p>Cluster ID removal list, used when ConfClusterType=ALL.</p>
        /// </summary>
        [JsonProperty("ConfClusterExcludeList")]
        public string[] ConfClusterExcludeList{ get; set; }

        /// <summary>
        /// <p>Hit configuration of system classification / subcategory / detection item (only system policies take effect).</p>
        /// </summary>
        [JsonProperty("CategoryConf")]
        public BaselinePolicySystemCategoryConf[] CategoryConf{ get; set; }

        /// <summary>
        /// <p>Custom detection item parameter value configuration list (overwrites the judgment value based on the system check item).</p>
        /// </summary>
        [JsonProperty("CustomItemConf")]
        public BaselineCustomItemConf[] CustomItemConf{ get; set; }

        /// <summary>
        /// <p>Appid of the associated tenant of the policy.</p>
        /// </summary>
        [JsonProperty("Appid")]
        public ulong? Appid{ get; set; }

        /// <summary>
        /// <p>Baseline policy ID.</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>Number of detection items configured in the current policy.</p>
        /// </summary>
        [JsonProperty("ConfItemCount")]
        public ulong? ConfItemCount{ get; set; }

        /// <summary>
        /// <p>Number of hosts hit by the current policy.</p>
        /// </summary>
        [JsonProperty("ConfHostCount")]
        public ulong? ConfHostCount{ get; set; }

        /// <summary>
        /// <p>Number of clusters hit by the current policy.</p>
        /// </summary>
        [JsonProperty("ConfClusterCount")]
        public ulong? ConfClusterCount{ get; set; }

        /// <summary>
        /// <p>ID of the scan main task currently in progress for the policy; 0 if not in a scan.</p>
        /// </summary>
        [JsonProperty("ScanningTaskID")]
        public ulong? ScanningTaskID{ get; set; }

        /// <summary>
        /// <p>Last scan completion time (including manual/periodic).</p>
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// <p>Last periodic scan completion time.</p>
        /// </summary>
        [JsonProperty("LatestCycleScanTime")]
        public string LatestCycleScanTime{ get; set; }

        /// <summary>
        /// <p>Security Center tag ID list</p>
        /// </summary>
        [JsonProperty("TagIDList")]
        public ulong?[] TagIDList{ get; set; }

        /// <summary>
        /// <p>Cloud tag list</p>
        /// </summary>
        [JsonProperty("CloudTagList")]
        public string[] CloudTagList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "CycleScanConf.", this.CycleScanConf);
            this.SetParamSimple(map, prefix + "CheckAssetType", this.CheckAssetType);
            this.SetParamSimple(map, prefix + "AutoSyncItem", this.AutoSyncItem);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ConfHostType", this.ConfHostType);
            this.SetParamArraySimple(map, prefix + "ConfHostIncludeList.", this.ConfHostIncludeList);
            this.SetParamArraySimple(map, prefix + "ConfHostExcludeList.", this.ConfHostExcludeList);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "ConfClusterType", this.ConfClusterType);
            this.SetParamArraySimple(map, prefix + "ConfClusterIncludeList.", this.ConfClusterIncludeList);
            this.SetParamArraySimple(map, prefix + "ConfClusterExcludeList.", this.ConfClusterExcludeList);
            this.SetParamArrayObj(map, prefix + "CategoryConf.", this.CategoryConf);
            this.SetParamArrayObj(map, prefix + "CustomItemConf.", this.CustomItemConf);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "ConfItemCount", this.ConfItemCount);
            this.SetParamSimple(map, prefix + "ConfHostCount", this.ConfHostCount);
            this.SetParamSimple(map, prefix + "ConfClusterCount", this.ConfClusterCount);
            this.SetParamSimple(map, prefix + "ScanningTaskID", this.ScanningTaskID);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamSimple(map, prefix + "LatestCycleScanTime", this.LatestCycleScanTime);
            this.SetParamArraySimple(map, prefix + "TagIDList.", this.TagIDList);
            this.SetParamArraySimple(map, prefix + "CloudTagList.", this.CloudTagList);
        }
    }
}

