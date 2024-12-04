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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceSet : AbstractModel
    {
        
        /// <summary>
        /// Instance name.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// App ID of a user, which is an application ID that uniquely corresponds to the account ID. Some Tencent Cloud products use this app ID.
        /// </summary>
        [JsonProperty("Appid")]
        public long? Appid{ get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Region ID. <ul><li>1: Guangzhou;</li> <li>4: Shanghai;</li> <li>5: Hong Kong (China);</li> <li>7: Shanghai Finance;</li> <li>8: Beijing;</li> <li>9: Singapore;</li> <li>11: Shenzhen Finance;</li> <li>15: Western United States (Silicon Valley);</li> <li>16: Chengdu;</li> <li>17: Frankfurt;</li> <li>18: Seoul;</li> <li>19: Chongqing;</li> <li>21: Mumbai;</li> <li>22: Eastern United States (Virginia);</li> <li>23: Bangkok;</li> <li>25: Tokyo.</li></ul>
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// VPC ID, for example, 75101.
        /// </summary>
        [JsonProperty("VpcId")]
        public long? VpcId{ get; set; }

        /// <summary>
        /// ID of the subnet under VPC, for example, 46315.
        /// </summary>
        [JsonProperty("SubnetId")]
        public long? SubnetId{ get; set; }

        /// <summary>
        /// Current instance status. <ul><li>0: to be initialized;</li> <li>1: in process;</li> <li>2: running;</li> <li>-2: isolated;</li> <li>-3: to be deleted.</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Instance VIP.
        /// </summary>
        [JsonProperty("WanIp")]
        public string WanIp{ get; set; }

        /// <summary>
        /// Instance port number.
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// Instance creation time, for example, in the format of 2020-01-15 10:20:00.
        /// </summary>
        [JsonProperty("Createtime")]
        public string Createtime{ get; set; }

        /// <summary>
        /// Instance memory capacity. Unit: MB (1 MB = 1024 KB).
        /// </summary>
        [JsonProperty("Size")]
        public float? Size{ get; set; }

        /// <summary>
        /// This parameter has been deprecated. Obtain the memory capacity used by the instance through the TCOP API [GetMonitorData](https://intl.cloud.tencent.com/document/product/248/31014?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("SizeUsed")]
        public float? SizeUsed{ get; set; }

        /// <summary>
        /// Instance type.
        /// - 2: Redis 2.8 Memory Edition (standard architecture).
        /// - 3: CKV 3.2 Memory Edition (standard architecture).
        /// - 4: CKV 3.2 Memory Edition (cluster architecture).
        /// - 5: Redis 2.8 Memory Edition (stand-alone).
        /// - 6: Redis 4.0 Memory Edition (standard architecture).
        /// - 7: Redis 4.0 Memory Edition (cluster architecture).
        /// - 8: Redis 5.0 Memory Edition (standard architecture).
        /// - 9: Redis 5.0 Memory Edition (cluster architecture).
        /// - 15: Redis 6.2 Memory Edition (standard architecture).
        /// - 16: Redis 6.2 Memory Edition (cluster architecture).
        /// - 17: Redis 7.0 Memory Edition (standard architecture).
        /// - 18: Redis 7.0 Memory Edition (cluster architecture).
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Whether the automatic renewal flag is set for an instance. <ul><li>1: set;</li> <li>0: not set.</li></ul>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Expiration time of a monthly subscription instance.
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// Engine. Valid values: Redis Community Edition and Tencent Cloud CKV.
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// Product type. <ul><li>standalone: Standard Edition;</li> <li>cluster: Cluster Edition.</li></ul>
        /// </summary>
        [JsonProperty("ProductType")]
        public string ProductType{ get; set; }

        /// <summary>
        /// VPC ID, for example, vpc-fk33jsf43kgv.
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// ID of the subnet under VPC, for example, subnet-fd3j6l35mm0.
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// Billing mode. Only pay-as-you-go billing is supported.
        /// </summary>
        [JsonProperty("BillingMode")]
        public long? BillingMode{ get; set; }

        /// <summary>
        /// Description of the instance running status, for example, running.
        /// </summary>
        [JsonProperty("InstanceTitle")]
        public string InstanceTitle{ get; set; }

        /// <summary>
        /// Default termination time of isolated instances, for example, in the format of 2020-02-15 10:20:00. By default, a pay-as-you-go instance will be terminated after 2 hours of isolation, and a monthly subscription instance will be terminated after 7 days.
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }

        /// <summary>
        /// Sub-status returned for an instance in process.
        /// </summary>
        [JsonProperty("SubStatus")]
        public long? SubStatus{ get; set; }

        /// <summary>
        /// Anti-affinity tag.
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// Instance node information.
        /// </summary>
        [JsonProperty("InstanceNode")]
        public InstanceNode[] InstanceNode{ get; set; }

        /// <summary>
        /// Shard size.
        /// </summary>
        [JsonProperty("RedisShardSize")]
        public long? RedisShardSize{ get; set; }

        /// <summary>
        /// Number of shards.
        /// </summary>
        [JsonProperty("RedisShardNum")]
        public long? RedisShardNum{ get; set; }

        /// <summary>
        /// Number of replicas.
        /// </summary>
        [JsonProperty("RedisReplicasNum")]
        public long? RedisReplicasNum{ get; set; }

        /// <summary>
        /// Billing ID.
        /// </summary>
        [JsonProperty("PriceId")]
        public long? PriceId{ get; set; }

        /// <summary>
        /// Time when an instance starts to be isolated.
        /// </summary>
        [JsonProperty("CloseTime")]
        public string CloseTime{ get; set; }

        /// <summary>
        /// Read weight of a secondary node.
        /// </summary>
        [JsonProperty("SlaveReadWeight")]
        public long? SlaveReadWeight{ get; set; }

        /// <summary>
        /// Tag information associated with an instance.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InstanceTags")]
        public InstanceTagInfo[] InstanceTags{ get; set; }

        /// <summary>
        /// Project name
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// Whether an instance is a password-free instance. <ul><li>true: yes;</li> <li>false: no.</li></ul>
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("NoAuth")]
        public bool? NoAuth{ get; set; }

        /// <summary>
        /// Number of client connections.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClientLimit")]
        public long? ClientLimit{ get; set; }

        /// <summary>
        /// DTS status (internal parameter, which can be ignored).
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DtsStatus")]
        public long? DtsStatus{ get; set; }

        /// <summary>
        /// Upper limit of the shard bandwidth. Unit: MB.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("NetLimit")]
        public long? NetLimit{ get; set; }

        /// <summary>
        /// Password-free instance flag (internal parameter, which can be ignored).
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PasswordFree")]
        public long? PasswordFree{ get; set; }

        /// <summary>
        /// Internal parameter, which can be ignored. This parameter is not properly named. It is recommended to use the IPv6 parameter to replace it.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Vip6")]
        public string Vip6{ get; set; }

        /// <summary>
        /// Internal parameter, which can be ignored.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IPv6")]
        public string IPv6{ get; set; }

        /// <summary>
        /// Instance read-only flag (internal parameter, which can be ignored).
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ReadOnly")]
        public long? ReadOnly{ get; set; }

        /// <summary>
        /// Internal parameter, which can be ignored.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RemainBandwidthDuration")]
        public string RemainBandwidthDuration{ get; set; }

        /// <summary>
        /// For Redis instances, ignore this parameter.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// Monitoring version. <ul><li>1m: 1-minute granularity monitoring. This monitoring granularity has been deprecated. For details, see [1-Minute Granularity Will Be Disused](https://www.tencentcloud.com/document/product/239/50440).</li> <li>5s: 5-second granularity monitoring.</li></ul>
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MonitorVersion")]
        public string MonitorVersion{ get; set; }

        /// <summary>
        /// Minimum value that can be set for the maximum number of client connections.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClientLimitMin")]
        public long? ClientLimitMin{ get; set; }

        /// <summary>
        /// Maximum value that can be set for the maximum number of client connections.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClientLimitMax")]
        public long? ClientLimitMax{ get; set; }

        /// <summary>
        /// Detailed node information of an instance.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("NodeSet")]
        public RedisNodeInfo[] NodeSet{ get; set; }

        /// <summary>
        /// Region information of an instance, for example, ap-guangzhou.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Public network address.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("WanAddress")]
        public string WanAddress{ get; set; }

        /// <summary>
        /// Polaris service address, which is for internal use.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PolarisServer")]
        public string PolarisServer{ get; set; }

        /// <summary>
        /// CDC Redis cluster ID.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RedisClusterId")]
        public string RedisClusterId{ get; set; }

        /// <summary>
        /// CDC cluster ID.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// Product edition. <ul><li>local: local disk;</li> <li>cloud: cloud disk;</li> <li>cdc: CDC cluster.</li></ul>
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ProductVersion")]
        public string ProductVersion{ get; set; }

        /// <summary>
        /// Current Proxy version of an instance.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CurrentProxyVersion")]
        public string CurrentProxyVersion{ get; set; }

        /// <summary>
        /// Current Cache minor version of an instance. If the instance joins a global replication group, the kernel version of the global replication group will be displayed.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CurrentRedisVersion")]
        public string CurrentRedisVersion{ get; set; }

        /// <summary>
        /// Upgradable Proxy version of an instance.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("UpgradeProxyVersion")]
        public string UpgradeProxyVersion{ get; set; }

        /// <summary>
        /// Upgradable Cache minor version of an instance.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("UpgradeRedisVersion")]
        public string UpgradeRedisVersion{ get; set; }

        /// <summary>
        /// Backup mode. SecondLevelBackup: second-level backup; NormalLevelBackup: normal backup.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BackupMode")]
        public string BackupMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "WanIp", this.WanIp);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Createtime", this.Createtime);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "SizeUsed", this.SizeUsed);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "DeadlineTime", this.DeadlineTime);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "BillingMode", this.BillingMode);
            this.SetParamSimple(map, prefix + "InstanceTitle", this.InstanceTitle);
            this.SetParamSimple(map, prefix + "OfflineTime", this.OfflineTime);
            this.SetParamSimple(map, prefix + "SubStatus", this.SubStatus);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "InstanceNode.", this.InstanceNode);
            this.SetParamSimple(map, prefix + "RedisShardSize", this.RedisShardSize);
            this.SetParamSimple(map, prefix + "RedisShardNum", this.RedisShardNum);
            this.SetParamSimple(map, prefix + "RedisReplicasNum", this.RedisReplicasNum);
            this.SetParamSimple(map, prefix + "PriceId", this.PriceId);
            this.SetParamSimple(map, prefix + "CloseTime", this.CloseTime);
            this.SetParamSimple(map, prefix + "SlaveReadWeight", this.SlaveReadWeight);
            this.SetParamArrayObj(map, prefix + "InstanceTags.", this.InstanceTags);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "NoAuth", this.NoAuth);
            this.SetParamSimple(map, prefix + "ClientLimit", this.ClientLimit);
            this.SetParamSimple(map, prefix + "DtsStatus", this.DtsStatus);
            this.SetParamSimple(map, prefix + "NetLimit", this.NetLimit);
            this.SetParamSimple(map, prefix + "PasswordFree", this.PasswordFree);
            this.SetParamSimple(map, prefix + "Vip6", this.Vip6);
            this.SetParamSimple(map, prefix + "IPv6", this.IPv6);
            this.SetParamSimple(map, prefix + "ReadOnly", this.ReadOnly);
            this.SetParamSimple(map, prefix + "RemainBandwidthDuration", this.RemainBandwidthDuration);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "MonitorVersion", this.MonitorVersion);
            this.SetParamSimple(map, prefix + "ClientLimitMin", this.ClientLimitMin);
            this.SetParamSimple(map, prefix + "ClientLimitMax", this.ClientLimitMax);
            this.SetParamArrayObj(map, prefix + "NodeSet.", this.NodeSet);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "WanAddress", this.WanAddress);
            this.SetParamSimple(map, prefix + "PolarisServer", this.PolarisServer);
            this.SetParamSimple(map, prefix + "RedisClusterId", this.RedisClusterId);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamSimple(map, prefix + "ProductVersion", this.ProductVersion);
            this.SetParamSimple(map, prefix + "CurrentProxyVersion", this.CurrentProxyVersion);
            this.SetParamSimple(map, prefix + "CurrentRedisVersion", this.CurrentRedisVersion);
            this.SetParamSimple(map, prefix + "UpgradeProxyVersion", this.UpgradeProxyVersion);
            this.SetParamSimple(map, prefix + "UpgradeRedisVersion", this.UpgradeRedisVersion);
            this.SetParamSimple(map, prefix + "BackupMode", this.BackupMode);
        }
    }
}

