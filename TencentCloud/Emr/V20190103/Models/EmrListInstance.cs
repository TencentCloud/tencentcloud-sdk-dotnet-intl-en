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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EmrListInstance : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Common status: cluster in production, cluster running, cluster creating, cluster closed, and cluster deleted.
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// Cluster name
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Cluster region
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// User APPID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// Running time
        /// </summary>
        [JsonProperty("RunTime")]
        public string RunTime{ get; set; }

        /// <summary>
        /// Cluster IP
        /// </summary>
        [JsonProperty("MasterIp")]
        public string MasterIp{ get; set; }

        /// <summary>
        /// Cluster version
        /// </summary>
        [JsonProperty("EmrVersion")]
        public string EmrVersion{ get; set; }

        /// <summary>
        /// Cluster billing mode
        /// </summary>
        [JsonProperty("ChargeType")]
        public ulong? ChargeType{ get; set; }

        /// <summary>
        /// EMR ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Product ID.
        /// </summary>
        [JsonProperty("ProductId")]
        public ulong? ProductId{ get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Region.
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// Subnet ID.
        /// </summary>
        [JsonProperty("SubnetId")]
        public ulong? SubnetId{ get; set; }

        /// <summary>
        /// Network ID.
        /// </summary>
        [JsonProperty("VpcId")]
        public ulong? VpcId{ get; set; }

        /// <summary>
        /// Region.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Status code. Valid values: -2 (cluster deleted), -1 (cluster closed), 0 (cluster in production), 2 (cluster running), 3 (cluster creating).
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Instance tag
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Alarm information.
        /// </summary>
        [JsonProperty("AlarmInfo")]
        public string AlarmInfo{ get; set; }

        /// <summary>
        /// Whether it is a Woodpecker cluster.
        /// </summary>
        [JsonProperty("IsWoodpeckerCluster")]
        public ulong? IsWoodpeckerCluster{ get; set; }

        /// <summary>
        /// VPC name in Chinese.
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// Subnet in Chinese.
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// String VpcId.
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// String subnet.
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// Cluster type.
        /// </summary>
        [JsonProperty("ClusterClass")]
        public string ClusterClass{ get; set; }

        /// <summary>
        /// Whether it is a cross-AZ cluster.
        /// </summary>
        [JsonProperty("IsMultiZoneCluster")]
        public bool? IsMultiZoneCluster{ get; set; }

        /// <summary>
        /// Whether it is a cluster created by a cluster CVM.
        /// </summary>
        [JsonProperty("IsHandsCluster")]
        public bool? IsHandsCluster{ get; set; }

        /// <summary>
        /// Client component information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OutSideSoftInfo")]
        public SoftDependInfo[] OutSideSoftInfo{ get; set; }

        /// <summary>
        /// Whether the current cluster's scenarios support external clients.
        /// </summary>
        [JsonProperty("IsSupportOutsideCluster")]
        public bool? IsSupportOutsideCluster{ get; set; }

        /// <summary>
        /// Whether the cluster is used in a dedicated cluster scenario.
        /// </summary>
        [JsonProperty("IsDedicatedCluster")]
        public bool? IsDedicatedCluster{ get; set; }

        /// <summary>
        /// Cluster supports for cloning.
        /// </summary>
        [JsonProperty("IsSupportClone")]
        public bool? IsSupportClone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "RunTime", this.RunTime);
            this.SetParamSimple(map, prefix + "MasterIp", this.MasterIp);
            this.SetParamSimple(map, prefix + "EmrVersion", this.EmrVersion);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AlarmInfo", this.AlarmInfo);
            this.SetParamSimple(map, prefix + "IsWoodpeckerCluster", this.IsWoodpeckerCluster);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "ClusterClass", this.ClusterClass);
            this.SetParamSimple(map, prefix + "IsMultiZoneCluster", this.IsMultiZoneCluster);
            this.SetParamSimple(map, prefix + "IsHandsCluster", this.IsHandsCluster);
            this.SetParamArrayObj(map, prefix + "OutSideSoftInfo.", this.OutSideSoftInfo);
            this.SetParamSimple(map, prefix + "IsSupportOutsideCluster", this.IsSupportOutsideCluster);
            this.SetParamSimple(map, prefix + "IsDedicatedCluster", this.IsDedicatedCluster);
            this.SetParamSimple(map, prefix + "IsSupportClone", this.IsSupportClone);
        }
    }
}

