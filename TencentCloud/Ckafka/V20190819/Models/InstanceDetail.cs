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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>ckafka cluster instance Id.</p>.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <P>Specifies the name of the ckafka cluster instance.</p>.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <P>Specifies the vip information for accessing the instance.</p>.
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <P>Specifies the port information to access the instance.</p>.
        /// </summary>
        [JsonProperty("Vport")]
        public string Vport{ get; set; }

        /// <summary>
        /// <p>Specifies the virtual IP list.</p>.
        /// </summary>
        [JsonProperty("VipList")]
        public VipEntity[] VipList{ get; set; }

        /// <summary>
        /// <P>Specifies the instance status. valid values: 0 (creating), 1 (running), 2 (deleting), 3 (deleted), 5 (isolated), 7 (upgrading), -1 (creation failed).</p>.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Specifies the instance bandwidth in Mbps.</p>.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// <p>Specifies the disk size of the ckafka cluster instance, in gb.</p>.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// <p>Specifies the available zone ID.</p>.
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// <p>vpcId. if empty, indicates a basic network.</p>.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <P>Subnet id.</p>.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <P>Specifies whether to renew the instance. int enumeration value: 1 means auto-renew, 2 means explicitly no auto-renew.</p>.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// <p>Specifies the instance status. valid values: 1 (healthy), 2 (alarm), 3 (instance status exception).</p>.
        /// </summary>
        [JsonProperty("Healthy")]
        public long? Healthy{ get; set; }

        /// <summary>
        /// <P>Specifies the instance status information.</p>.
        /// </summary>
        [JsonProperty("HealthyMessage")]
        public string HealthyMessage{ get; set; }

        /// <summary>
        /// <P>Specifies the instance creation time.</p>.
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <P>Specifies the instance expiration time.</p>.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// <P>Specifies whether it is an internal customer. a value of 1 indicates an internal customer.</p>.
        /// </summary>
        [JsonProperty("IsInternal")]
        public long? IsInternal{ get; set; }

        /// <summary>
        /// <p>Specifies the number of topics.</p>.
        /// </summary>
        [JsonProperty("TopicNum")]
        public long? TopicNum{ get; set; }

        /// <summary>
        /// <P>Specifies the identifier tag.</p>.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>kafka version information.</p>.
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <P>Specifies the cross-availability zone.</p>.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// <P>Specifies the ckafka sales type.</p>.
        /// </summary>
        [JsonProperty("Cvm")]
        public long? Cvm{ get; set; }

        /// <summary>
        /// <P>Specifies the ckafka cluster instance type.</p>.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <P>Specifies the disk type of the ckafka cluster instance.</p>.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// <p>Maximum number of topics for current specifications.</p>.
        /// </summary>
        [JsonProperty("MaxTopicNumber")]
        public long? MaxTopicNumber{ get; set; }

        /// <summary>
        /// <p>Specifies the maximum number of partitions for current specifications.</p>.
        /// </summary>
        [JsonProperty("MaxPartitionNumber")]
        public long? MaxPartitionNumber{ get; set; }

        /// <summary>
        /// <P>Specifies the planned configuration upgrade time.</p>.
        /// </summary>
        [JsonProperty("RebalanceTime")]
        public string RebalanceTime{ get; set; }

        /// <summary>
        /// <P>Current number of partitions of the instance.</p>.
        /// </summary>
        [JsonProperty("PartitionNumber")]
        public ulong? PartitionNumber{ get; set; }

        /// <summary>
        /// <P>Specifies the public network bandwidth type of the ckafka cluster instance.</p>.
        /// </summary>
        [JsonProperty("PublicNetworkChargeType")]
        public string PublicNetworkChargeType{ get; set; }

        /// <summary>
        /// <p>Specifies the public network bandwidth. value range: 3Mbps to 999Mbps. only supported in pro edition.</p>.
        /// </summary>
        [JsonProperty("PublicNetwork")]
        public long? PublicNetwork{ get; set; }

        /// <summary>
        /// <P>Specifies the underlying cluster type of the ckafka cluster instance.</p>.
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <P>Specifies the instance feature list.</p>.
        /// </summary>
        [JsonProperty("Features")]
        public string[] Features{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamArrayObj(map, prefix + "VipList.", this.VipList);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "Healthy", this.Healthy);
            this.SetParamSimple(map, prefix + "HealthyMessage", this.HealthyMessage);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "IsInternal", this.IsInternal);
            this.SetParamSimple(map, prefix + "TopicNum", this.TopicNum);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "Cvm", this.Cvm);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "MaxTopicNumber", this.MaxTopicNumber);
            this.SetParamSimple(map, prefix + "MaxPartitionNumber", this.MaxPartitionNumber);
            this.SetParamSimple(map, prefix + "RebalanceTime", this.RebalanceTime);
            this.SetParamSimple(map, prefix + "PartitionNumber", this.PartitionNumber);
            this.SetParamSimple(map, prefix + "PublicNetworkChargeType", this.PublicNetworkChargeType);
            this.SetParamSimple(map, prefix + "PublicNetwork", this.PublicNetwork);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamArraySimple(map, prefix + "Features.", this.Features);
        }
    }
}

