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

    public class CreateEDRManualScanRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Asset selection method: all - all assets/tag - select by tag (hosts only)/direct - direct selection</p>
        /// </summary>
        [JsonProperty("AssetSelectionType")]
        public string AssetSelectionType{ get; set; }

        /// <summary>
        /// <p>Detection mode: full - full-disk detection / quick - rapid detection / include - detect specified paths only / exclude - exclude specified paths</p>
        /// </summary>
        [JsonProperty("ScanType")]
        public string ScanType{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Directly selected host list (used when AssetSelectionType=direct or all)</p>
        /// </summary>
        [JsonProperty("InstanceIDsWithAppId")]
        public InstanceIDWithAppIdItem[] InstanceIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>Host list for removal (used when AssetSelectionType=all)</p>
        /// </summary>
        [JsonProperty("ExcludeInstanceIDsWithAppId")]
        public InstanceIDWithAppIdItem[] ExcludeInstanceIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>Tag ID corresponding to the host</p>
        /// </summary>
        [JsonProperty("TagIds")]
        public ulong?[] TagIds{ get; set; }

        /// <summary>
        /// <p>Cluster list for direct selection</p>
        /// </summary>
        [JsonProperty("ClusterIDsWithAppId")]
        public ClusterWithAppIdItem[] ClusterIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>Cluster list for removal (used when AssetSelectionType=all)</p>
        /// </summary>
        [JsonProperty("ExcludeClusterIDsWithAppId")]
        public ClusterWithAppIdItem[] ExcludeClusterIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>Selected path list (required when ScanType is include or exclude, up to 100 entries)</p>
        /// </summary>
        [JsonProperty("CustomPaths")]
        public string[] CustomPaths{ get; set; }

        /// <summary>
        /// <p>Timeout period in seconds, upper limit 7200</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// <p>Whether deep detection is enabled: 0-No/1-Yes</p>
        /// </summary>
        [JsonProperty("EnableMemShellScan")]
        public long? EnableMemShellScan{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetSelectionType", this.AssetSelectionType);
            this.SetParamSimple(map, prefix + "ScanType", this.ScanType);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArrayObj(map, prefix + "InstanceIDsWithAppId.", this.InstanceIDsWithAppId);
            this.SetParamArrayObj(map, prefix + "ExcludeInstanceIDsWithAppId.", this.ExcludeInstanceIDsWithAppId);
            this.SetParamArraySimple(map, prefix + "TagIds.", this.TagIds);
            this.SetParamArrayObj(map, prefix + "ClusterIDsWithAppId.", this.ClusterIDsWithAppId);
            this.SetParamArrayObj(map, prefix + "ExcludeClusterIDsWithAppId.", this.ExcludeClusterIDsWithAppId);
            this.SetParamArraySimple(map, prefix + "CustomPaths.", this.CustomPaths);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "EnableMemShellScan", this.EnableMemShellScan);
        }
    }
}

