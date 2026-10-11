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
        /// <p>ID.</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Title.</p>
        /// </summary>
        [JsonProperty("Ftitle")]
        [System.Obsolete]
        public string Ftitle{ get; set; }

        /// <summary>
        /// <p>Cluster name.</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>Region ID.</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// <p>Region ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// <p>User APPID.</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>User UIN.</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>Project ID.</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>Cluster VPC ID.</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public long? VpcId{ get; set; }

        /// <summary>
        /// <p>Subnet ID.</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public long? SubnetId{ get; set; }

        /// <summary>
        /// <p>Status code of the instance. Valid values:</p><li>2: The cluster is running.</li><li>3: The cluster is being created.</li><li>4: The cluster is being scaled out.</li><li>5: Router nodes are being added to the cluster.</li><li>6: Components are being installed in the cluster.</li><li>7: The cluster is executing a command.</li><li>8: The service is being restarted.</li><li>9: The cluster is entering maintenance.</li><li>10: The service is being paused.</li><li>11: The cluster is exiting maintenance.</li><li>12: The cluster is exiting the pause status.</li><li>13: The configuration is being delivered.</li><li>14: The cluster is being terminated.</li><li>15: Core nodes are being terminated.</li><li>16: Task nodes are being terminated.</li><li>17: Router nodes are being terminated.</li><li>18: The webproxy password is being changed.</li><li>19: The cluster is being isolated.</li><li>20: The cluster is being reconciled.</li><li>21: The cluster is being reclaimed.</li><li>22: The configuration change is waiting.</li><li>23: The cluster has been isolated.</li><li>24: Nodes are being scaled in.</li><li>33: The cluster is waiting for a refund.</li><li>34: The cluster has been refunded.</li><li>301: Creation failed.</li><li>302: Scale-out failed.</li>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Addition time.</p>
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// <p>Execution duration.</p>
        /// </summary>
        [JsonProperty("RunTime")]
        public string RunTime{ get; set; }

        /// <summary>
        /// <p>Cluster product configuration information.</p>
        /// </summary>
        [JsonProperty("Config")]
        [System.Obsolete]
        public EmrProductConfigOutter Config{ get; set; }

        /// <summary>
        /// <p>Public IP address of the Master node.</p>
        /// </summary>
        [JsonProperty("MasterIp")]
        public string MasterIp{ get; set; }

        /// <summary>
        /// <p>EMR version.</p>
        /// </summary>
        [JsonProperty("EmrVersion")]
        public string EmrVersion{ get; set; }

        /// <summary>
        /// <p>Billing mode.</p>
        /// </summary>
        [JsonProperty("ChargeType")]
        public long? ChargeType{ get; set; }

        /// <summary>
        /// <p>Transaction version.</p>
        /// </summary>
        [JsonProperty("TradeVersion")]
        public long? TradeVersion{ get; set; }

        /// <summary>
        /// <p>Resource order ID.</p>
        /// </summary>
        [JsonProperty("ResourceOrderId")]
        public long? ResourceOrderId{ get; set; }

        /// <summary>
        /// <p>Whether it is a billable cluster.</p>
        /// </summary>
        [JsonProperty("IsTradeCluster")]
        public long? IsTradeCluster{ get; set; }

        /// <summary>
        /// <p>Cluster error status alarm information.</p>
        /// </summary>
        [JsonProperty("AlarmInfo")]
        public string AlarmInfo{ get; set; }

        /// <summary>
        /// <p>Whether a new architecture is used.</p>
        /// </summary>
        [JsonProperty("IsWoodpeckerCluster")]
        public long? IsWoodpeckerCluster{ get; set; }

        /// <summary>
        /// <p>Meta database information.</p>
        /// </summary>
        [JsonProperty("MetaDb")]
        public string MetaDb{ get; set; }

        /// <summary>
        /// <p>Tag information.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Hive metadata information.</p>
        /// </summary>
        [JsonProperty("HiveMetaDb")]
        public string HiveMetaDb{ get; set; }

        /// <summary>
        /// <p>Cluster type. Valid values: EMR, CLICKHOUSE, and DRUID.</p>
        /// </summary>
        [JsonProperty("ServiceClass")]
        public string ServiceClass{ get; set; }

        /// <summary>
        /// <p>Serialization of the aliases of all nodes in the cluster.</p>
        /// </summary>
        [JsonProperty("AliasInfo")]
        public string AliasInfo{ get; set; }

        /// <summary>
        /// <p>Cluster version ID.</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public long? ProductId{ get; set; }

        /// <summary>
        /// <p>Region ID.</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Scenario name.</p>
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }

        /// <summary>
        /// <p>Scenario-based cluster type.</p>
        /// </summary>
        [JsonProperty("SceneServiceClass")]
        public string SceneServiceClass{ get; set; }

        /// <summary>
        /// <p>Scenario-based EMR version.</p>
        /// </summary>
        [JsonProperty("SceneEmrVersion")]
        public string SceneEmrVersion{ get; set; }

        /// <summary>
        /// <p>Scenario-based cluster type.</p>
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// <p>vpc name</p>
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// <p>subnet name</p>
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// <p>Cluster dependency.</p>
        /// </summary>
        [JsonProperty("ClusterExternalServiceInfo")]
        public ClusterExternalServiceInfo[] ClusterExternalServiceInfo{ get; set; }

        /// <summary>
        /// <p>Cluster VPC ID, string type.</p>
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// <p>Subnet ID, string type.</p>
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// <p>Node information.</p>
        /// </summary>
        [JsonProperty("TopologyInfoList")]
        public TopologyInfo[] TopologyInfoList{ get; set; }

        /// <summary>
        /// <p>Whether it is a cross-AZ cluster.</p>
        /// </summary>
        [JsonProperty("IsMultiZoneCluster")]
        public bool? IsMultiZoneCluster{ get; set; }

        /// <summary>
        /// <p>Whether automatic compensation for abnormal nodes is enabled.</p>
        /// </summary>
        [JsonProperty("IsCvmReplace")]
        public bool? IsCvmReplace{ get; set; }

        /// <summary>
        /// <p>Title.</p>
        /// </summary>
        [JsonProperty("ClusterTitle")]
        public string ClusterTitle{ get; set; }

        /// <summary>
        /// <p>Cluster product configuration information.</p>
        /// </summary>
        [JsonProperty("ConfigDetail")]
        public EmrProductConfigDetail ConfigDetail{ get; set; }

        /// <summary>
        /// <p>Number of file systems bound to the cluster.</p>
        /// </summary>
        [JsonProperty("BindFileSystemNum")]
        public long? BindFileSystemNum{ get; set; }

        /// <summary>
        /// <p>Binding list of the RSS cluster.</p>
        /// </summary>
        [JsonProperty("ClusterRelationInfoList")]
        public ClusterRelationMeta[] ClusterRelationInfoList{ get; set; }

        /// <summary>
        /// <p>Redis information.</p>
        /// </summary>
        [JsonProperty("RedisId")]
        public string RedisId{ get; set; }

        /// <summary>
        /// <p>Whether IO fault self-healing is enabled.</p>
        /// </summary>
        [JsonProperty("IsIOHungSelfRecovery")]
        public bool? IsIOHungSelfRecovery{ get; set; }

        /// <summary>
        /// <p>Metadata information.</p>
        /// </summary>
        [JsonProperty("MetaDBGroupInfo")]
        public CustomMetaDBInfo[] MetaDBGroupInfo{ get; set; }


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
            this.SetParamSimple(map, prefix + "IsIOHungSelfRecovery", this.IsIOHungSelfRecovery);
            this.SetParamArrayObj(map, prefix + "MetaDBGroupInfo.", this.MetaDBGroupInfo);
        }
    }
}

