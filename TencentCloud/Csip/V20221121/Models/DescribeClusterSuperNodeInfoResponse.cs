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

    public class DescribeClusterSuperNodeInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>Region code (unchanged, for example, ap-chengdu).</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Region Chinese Name (for example, Southwest China (Chengdu); obtained by translating the region code using the dictionary).</p>
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// <p>Region English name (for example, Southwest China (Chengdu); obtained by translating the region code using a dictionary).</p>
        /// </summary>
        [JsonProperty("RegionNameEn")]
        public string RegionNameEn{ get; set; }

        /// <summary>
        /// <p>Availability zone (Chinese name, obtained by translating the AZ code via dictionary).</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Last update time of the asset.<br>Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format, UTC time zone)</p>
        /// </summary>
        [JsonProperty("AssetSyncTime")]
        public string AssetSyncTime{ get; set; }

        /// <summary>
        /// <p>Node origin (cluster type).<br>Enumeration values:<br>TKE_MANAGED_CLUSTER: Tencent Cloud Standard Cluster<br>TKE_INDEPENDENT_CLUSTER: Tencent Cloud Standard Cluster (Master Self-maintenance)<br>TKE_SERVERLESS_CLUSTER: Tencent Cloud Serverless cluster<br>TKE_EDGE_CLUSTER: Tencent Cloud edge cluster<br>SELF_BUILT: Self-built cluster within Tencent Cloud<br>SELF_BUILT_OTHER: Self-built cluster outside Tencent Cloud (hybrid cloud)</p>
        /// </summary>
        [JsonProperty("NodeSource")]
        public string NodeSource{ get; set; }

        /// <summary>
        /// <p>Subnet name.</p>
        /// </summary>
        [JsonProperty("SubNetName")]
        public string SubNetName{ get; set; }

        /// <summary>
        /// <p>Subnet ID.</p>
        /// </summary>
        [JsonProperty("SubNetId")]
        public string SubNetId{ get; set; }

        /// <summary>
        /// <p>Subnet segment (CIDR).</p>
        /// </summary>
        [JsonProperty("SubNetCIDR")]
        public string SubNetCIDR{ get; set; }

        /// <summary>
        /// <p>Number of cores (obtained by dividing cpu_request by 1000).<br>Unit: core</p>
        /// </summary>
        [JsonProperty("CoresCount")]
        public long? CoresCount{ get; set; }

        /// <summary>
        /// <p>Cluster Name.</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Cluster operation status.<br>Enumeration values:<br>Running: running<br>Exception: exception<br>Unknown: unknown<br>Creating: creating<br>Destroyed: terminated</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Kubernetes version.</p>
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// <p>Kubelet version.</p>
        /// </summary>
        [JsonProperty("KubeletVersion")]
        public string KubeletVersion{ get; set; }

        /// <summary>
        /// <p>APPID of the account associated with the super node</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>Super node instance ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Super node name.</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>VPCID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "RegionNameEn", this.RegionNameEn);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "AssetSyncTime", this.AssetSyncTime);
            this.SetParamSimple(map, prefix + "NodeSource", this.NodeSource);
            this.SetParamSimple(map, prefix + "SubNetName", this.SubNetName);
            this.SetParamSimple(map, prefix + "SubNetId", this.SubNetId);
            this.SetParamSimple(map, prefix + "SubNetCIDR", this.SubNetCIDR);
            this.SetParamSimple(map, prefix + "CoresCount", this.CoresCount);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "KubeletVersion", this.KubeletVersion);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

