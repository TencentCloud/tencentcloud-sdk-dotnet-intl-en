/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class ClusterInstancesInfo : AbstractModel
    {
        
        /// <summary>
        /// ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// Cluster ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Title
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ftitle")]
        public string Ftitle{ get; set; }

        /// <summary>
        /// Cluster name
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Region ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// Region ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// User APPID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// User UIN
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Project ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Cluster `VPCID`
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcId")]
        public long? VpcId{ get; set; }

        /// <summary>
        /// Subnet ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubnetId")]
        public long? SubnetId{ get; set; }

        /// <summary>
        /// Instance status code. Value range:
        /// <li>2: cluster running</li>
        /// <li>3: creating cluster.</li>
        /// <li>4: scaling out cluster.</li>
        /// <li>5: adding router node in cluster.</li>
        /// <li>6: installing component in cluster.</li>
        /// <li>7: cluster executing command.</li>
        /// <li>8: restarting service.</li>
        /// <li>9: entering maintenance.</li>
        /// <li>10: suspending service.</li>
        /// <li>11: exiting maintenance.</li>
        /// <li>12: exiting suspension.</li>
        /// <li>13: delivering configuration.</li>
        /// <li>14: terminating cluster.</li>
        /// <li>15: terminating core node.</li>
        /// <li>16: terminating task node.</li>
        /// <li>17: terminating router node.</li>
        /// <li>18: changing webproxy password.</li>
        /// <li>19: isolating cluster.</li>
        /// <li>20: resuming cluster.</li>
        /// <li>21: repossessing cluster.</li>
        /// <li>22: waiting for configuration adjustment.</li>
        /// <li>23: cluster isolated.</li>
        /// <li>24: removing node.</li>
        /// <li>33: waiting for refund.</li>
        /// <li>34: refunded.</li>
        /// <li>301: creation failed.</li>
        /// <li>302: scale-out failed.</li>
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Creation time
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// Execution duration
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RunTime")]
        public string RunTime{ get; set; }

        /// <summary>
        /// Cluster product configuration information
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Config")]
        public EmrProductConfigOutter Config{ get; set; }

        /// <summary>
        /// Public IP of master node
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MasterIp")]
        public string MasterIp{ get; set; }

        /// <summary>
        /// EMR version
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EmrVersion")]
        public string EmrVersion{ get; set; }

        /// <summary>
        /// Billing mode
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ChargeType")]
        public long? ChargeType{ get; set; }

        /// <summary>
        /// Transaction version
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TradeVersion")]
        public long? TradeVersion{ get; set; }

        /// <summary>
        /// Resource order ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceOrderId")]
        public long? ResourceOrderId{ get; set; }

        /// <summary>
        /// Whether this is a paid cluster
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsTradeCluster")]
        public long? IsTradeCluster{ get; set; }

        /// <summary>
        /// Alarm information for cluster error
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlarmInfo")]
        public string AlarmInfo{ get; set; }

        /// <summary>
        /// Whether the new architecture is used
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsWoodpeckerCluster")]
        public long? IsWoodpeckerCluster{ get; set; }

        /// <summary>
        /// Metadatabase information
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MetaDb")]
        public string MetaDb{ get; set; }

        /// <summary>
        /// Tag information
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Hive metadata
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HiveMetaDb")]
        public string HiveMetaDb{ get; set; }

        /// <summary>
        /// Cluster type: EMR, CLICKHOUSE, DRUID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceClass")]
        public string ServiceClass{ get; set; }

        /// <summary>
        /// Alias serialization of all nodes in cluster
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AliasInfo")]
        public string AliasInfo{ get; set; }

        /// <summary>
        /// Cluster version ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProductId")]
        public long? ProductId{ get; set; }

        /// <summary>
        /// Availability zone
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Scenario name
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }

        /// <summary>
        /// Scenario-based cluster type
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("SceneServiceClass")]
        public string SceneServiceClass{ get; set; }

        /// <summary>
        /// Scenario-based EMR version
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("SceneEmrVersion")]
        public string SceneEmrVersion{ get; set; }

        /// <summary>
        /// Scenario-based cluster type
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// VPC name
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// Subnet name
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// Cluster dependency
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ClusterExternalServiceInfo")]
        public ClusterExternalServiceInfo[] ClusterExternalServiceInfo{ get; set; }

        /// <summary>
        /// The VPC ID string type of the cluster
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// The subnet ID string type of the cluster
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// Node information
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopologyInfoList")]
        public TopologyInfo[] TopologyInfoList{ get; set; }

        /// <summary>
        /// Multi-AZ cluster
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsMultiZoneCluster")]
        public bool? IsMultiZoneCluster{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Ftitle", this.Ftitle);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "RunTime", this.RunTime);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamSimple(map, prefix + "MasterIp", this.MasterIp);
            this.SetParamSimple(map, prefix + "EmrVersion", this.EmrVersion);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "TradeVersion", this.TradeVersion);
            this.SetParamSimple(map, prefix + "ResourceOrderId", this.ResourceOrderId);
            this.SetParamSimple(map, prefix + "IsTradeCluster", this.IsTradeCluster);
            this.SetParamSimple(map, prefix + "AlarmInfo", this.AlarmInfo);
            this.SetParamSimple(map, prefix + "IsWoodpeckerCluster", this.IsWoodpeckerCluster);
            this.SetParamSimple(map, prefix + "MetaDb", this.MetaDb);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "HiveMetaDb", this.HiveMetaDb);
            this.SetParamSimple(map, prefix + "ServiceClass", this.ServiceClass);
            this.SetParamSimple(map, prefix + "AliasInfo", this.AliasInfo);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "SceneName", this.SceneName);
            this.SetParamSimple(map, prefix + "SceneServiceClass", this.SceneServiceClass);
            this.SetParamSimple(map, prefix + "SceneEmrVersion", this.SceneEmrVersion);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamArrayObj(map, prefix + "ClusterExternalServiceInfo.", this.ClusterExternalServiceInfo);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamArrayObj(map, prefix + "TopologyInfoList.", this.TopologyInfoList);
            this.SetParamSimple(map, prefix + "IsMultiZoneCluster", this.IsMultiZoneCluster);
        }
    }
}

