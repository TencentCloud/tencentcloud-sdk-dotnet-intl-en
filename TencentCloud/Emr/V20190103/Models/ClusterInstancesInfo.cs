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

    public class ClusterInstancesInfo : AbstractModel
    {
        
        /// <summary>
        /// ID.
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// Cluster ID.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Title
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ftitle")]
        [System.Obsolete]
        public string Ftitle{ get; set; }

        /// <summary>
        /// Cluster name.
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Region ID.
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// Region ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// User AppID.
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// User UIN.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Cluster VPCID.
        /// </summary>
        [JsonProperty("VpcId")]
        public long? VpcId{ get; set; }

        /// <summary>
        /// Subnet ID.
        /// </summary>
        [JsonProperty("SubnetId")]
        public long? SubnetId{ get; set; }

        /// <summary>
        /// Instance status code. Valid range:
        /// <li>2: the cluster is running.</li>
        /// <li>3: the cluster is being created.</li>
        /// <li>4: the cluster is being scaled out.</li>
        /// <li>5: Router nodes are being added to the cluster.</li>
        /// <li>6: components are being installed in the cluster.</li>
        /// <li>7: commands are being executed in the cluster.</li>
        /// <li>8: the service is being restarted.</li>
        /// <li>9: maintenance is in progress.</li>
        /// <li>10: the service is being suspended.</li>
        /// <li>11: the cluster is exiting maintenance.</li>
        /// <li>12: the cluster is exiting suspension.</li>
        /// <li>13: the configuration is being distributed.</li>
        /// <li>14: the cluster is being terminated.</li>
        /// <li>15: the Core node is being destroyed.</li>
        /// <li>16: the Task node is being destroyed.</li>
        /// <li>17: the Router node is being destroyed.</li>
        /// <li>18: the web proxy password is being changed.</li>
        /// <li>19: the cluster is being isolated.</li>
        /// <li>20: the cluster is undergoing a reversal transaction.</li>
        /// <li>21: the cluster is being recycled.</li>
        /// <li>22: the instance is waiting for resizing.</li>
        /// <li>23: the cluster has been isolated.</li>
        /// <li>24: the number of nodes is being reduced.</li>
        /// <li>33: the cluster is waiting for a refund.</li>
        /// <li>34: the cluster has received a refund.</li>
        /// <li>301: creation failed.</li>
        /// <li>302: scale-out failed.</li>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Adding time.
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// Runtime.
        /// </summary>
        [JsonProperty("RunTime")]
        public string RunTime{ get; set; }

        /// <summary>
        /// Cluster product configuration information
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Config")]
        [System.Obsolete]
        public EmrProductConfigOutter Config{ get; set; }

        /// <summary>
        /// Public network IP address of the primary node.
        /// </summary>
        [JsonProperty("MasterIp")]
        public string MasterIp{ get; set; }

        /// <summary>
        /// EMR version.
        /// </summary>
        [JsonProperty("EmrVersion")]
        public string EmrVersion{ get; set; }

        /// <summary>
        /// Charge type.
        /// </summary>
        [JsonProperty("ChargeType")]
        public long? ChargeType{ get; set; }

        /// <summary>
        /// Transaction version.
        /// </summary>
        [JsonProperty("TradeVersion")]
        public long? TradeVersion{ get; set; }

        /// <summary>
        /// Resource order ID.
        /// </summary>
        [JsonProperty("ResourceOrderId")]
        public long? ResourceOrderId{ get; set; }

        /// <summary>
        /// Whether it is a billing cluster.
        /// </summary>
        [JsonProperty("IsTradeCluster")]
        public long? IsTradeCluster{ get; set; }

        /// <summary>
        /// Alarm information of cluster error status.
        /// </summary>
        [JsonProperty("AlarmInfo")]
        public string AlarmInfo{ get; set; }

        /// <summary>
        /// Whether to adopt new architecture.
        /// </summary>
        [JsonProperty("IsWoodpeckerCluster")]
        public long? IsWoodpeckerCluster{ get; set; }

        /// <summary>
        /// Metadatabase information.
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
        /// Hive metadata information.
        /// </summary>
        [JsonProperty("HiveMetaDb")]
        public string HiveMetaDb{ get; set; }

        /// <summary>
        /// Cluster type: EMR,CLICKHOUSE,DRUID.
        /// </summary>
        [JsonProperty("ServiceClass")]
        public string ServiceClass{ get; set; }

        /// <summary>
        /// Alias serialization of all nodes in the cluster.
        /// </summary>
        [JsonProperty("AliasInfo")]
        public string AliasInfo{ get; set; }

        /// <summary>
        /// Cluster version ID.
        /// </summary>
        [JsonProperty("ProductId")]
        public long? ProductId{ get; set; }

        /// <summary>
        /// Region ID.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Scenario name.
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }

        /// <summary>
        /// Scenario-based cluster type.
        /// </summary>
        [JsonProperty("SceneServiceClass")]
        public string SceneServiceClass{ get; set; }

        /// <summary>
        /// Scenario-based EMR version.
        /// </summary>
        [JsonProperty("SceneEmrVersion")]
        public string SceneEmrVersion{ get; set; }

        /// <summary>
        /// Scenario-based cluster type.
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// vpc name
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// subnet name
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
        /// Cluster vpcid string type.
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// Subnet ID string type.
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
        /// Whether it is a cross-AZ cluster.
        /// </summary>
        [JsonProperty("IsMultiZoneCluster")]
        public bool? IsMultiZoneCluster{ get; set; }

        /// <summary>
        /// Whether to enable automatic compensation for abnormal nodes.
        /// </summary>
        [JsonProperty("IsCvmReplace")]
        public bool? IsCvmReplace{ get; set; }

        /// <summary>
        /// Title.
        /// </summary>
        [JsonProperty("ClusterTitle")]
        public string ClusterTitle{ get; set; }

        /// <summary>
        /// Cluster product configuration information
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConfigDetail")]
        public EmrProductConfigDetail ConfigDetail{ get; set; }

        /// <summary>
        /// Number of file systems bound to a cluster.
        /// </summary>
        [JsonProperty("BindFileSystemNum")]
        public long? BindFileSystemNum{ get; set; }

        /// <summary>
        /// Bound list of the RSS cluster.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterRelationInfoList")]
        public ClusterRelationMeta[] ClusterRelationInfoList{ get; set; }

        /// <summary>
        /// Redis information.
        /// </summary>
        [JsonProperty("RedisId")]
        public string RedisId{ get; set; }


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
            this.SetParamSimple(map, prefix + "IsCvmReplace", this.IsCvmReplace);
            this.SetParamSimple(map, prefix + "ClusterTitle", this.ClusterTitle);
            this.SetParamObj(map, prefix + "ConfigDetail.", this.ConfigDetail);
            this.SetParamSimple(map, prefix + "BindFileSystemNum", this.BindFileSystemNum);
            this.SetParamArrayObj(map, prefix + "ClusterRelationInfoList.", this.ClusterRelationInfoList);
            this.SetParamSimple(map, prefix + "RedisId", this.RedisId);
        }
    }
}

