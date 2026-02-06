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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRabbitMQVipInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// AZ
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// vpc ID, such as vpc-xxx. valid VpcId can be obtained by logging in to the virtual private cloud console (https://console.cloud.tencent.com/vpc/vpc?rid=1) or via api call to DescribeVpcEx (https://www.tencentcloud.com/document/api/215/1372?from_cn_redirect=1), retrieving the unVpcId field from the api response. if both VpcId and SubnetId are set to DEFAULT when creating an instance, the DEFAULT vpc network will be forcibly used.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// The subnet ID of the vpc, such as subnet-xxx. valid subnet ids can be queried by logging in to the subnet console (https://console.cloud.tencent.com/vpc/subnet?rid=1) or by calling the api [DescribeSubnets](https://www.tencentcloud.com/document/api/215/15784?from_cn_redirect=1) and obtaining the unSubnetId field from the api response. if both SubnetId and VpcId are set to DEFAULT when creating an instance, the DEFAULT vpc network will be forcibly used.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Cluster name
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Node specification of the cluster. need to enter the corresponding specification flag.
        /// 2C8G:rabbit-vip-profession-2c8g
        /// 4C16G:rabbit-vip-profession-4c16g
        /// 8C32G:rabbit-vip-profession-8c32g
        /// 16C32G:rabbit-vip-basic-4
        /// 16C64G:rabbit-vip-profession-16c64g
        /// 2C4G:rabbit-vip-basic-5
        /// 4C8G:rabbit-vip-basic-1
        /// 8C16G (sold out): rabbit-vip-basic-2.
        /// Specifies the default value as 4C8G: rabbit-vip-basic-1.
        /// </summary>
        [JsonProperty("NodeSpec")]
        public string NodeSpec{ get; set; }

        /// <summary>
        /// Number of nodes, which is at least three for multi-AZ deployment. If this parameter is left empty, the value will be set to 1 for single-AZ deployment and 3 for multi-AZ deployment by default.
        /// </summary>
        [JsonProperty("NodeNum")]
        public long? NodeNum{ get; set; }

        /// <summary>
        /// Storage capacity of a single node, which is 200 GB by default.
        /// </summary>
        [JsonProperty("StorageSize")]
        public long? StorageSize{ get; set; }

        /// <summary>
        /// Whether the default image queue is enabled. true means enabled, false means not enabled. defaults to false if not specified.
        /// </summary>
        [JsonProperty("EnableCreateDefaultHaMirrorQueue")]
        public bool? EnableCreateDefaultHaMirrorQueue{ get; set; }

        /// <summary>
        /// Only applies to prepaid clusters (when PayMode parameter is 1). specifies whether the cluster is automatically renewed. true means auto-renewal is enabled. the default is true if not specified.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public bool? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Validity period, which is one month by default.
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// Payment mode. 0: postpaid, (pay-as-you-go); 1: prepaid (monthly subscription). Monthly subscription is used by default.
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// Specifies the cluster edition. defaults to 3.8.30. valid values: 3.8.30, 3.11.8, 3.13.7.
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// Whether the request is from the international website. Default value: false.
        /// </summary>
        [JsonProperty("IsIntl")]
        public bool? IsIntl{ get; set; }

        /// <summary>
        /// Resource tag list.
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// Specifies the public bandwidth size in Mbps.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// Whether to enable public network access. If this parameter is not specified, the value is false by default.
        /// </summary>
        [JsonProperty("EnablePublicAccess")]
        public bool? EnablePublicAccess{ get; set; }

        /// <summary>
        /// Whether to enable cluster deletion protection. if this parameter is not specified, the value is false by default.
        /// </summary>
        [JsonProperty("EnableDeletionProtection")]
        public bool? EnableDeletionProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "NodeSpec", this.NodeSpec);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "StorageSize", this.StorageSize);
            this.SetParamSimple(map, prefix + "EnableCreateDefaultHaMirrorQueue", this.EnableCreateDefaultHaMirrorQueue);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "IsIntl", this.IsIntl);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "EnablePublicAccess", this.EnablePublicAccess);
            this.SetParamSimple(map, prefix + "EnableDeletionProtection", this.EnableDeletionProtection);
        }
    }
}

